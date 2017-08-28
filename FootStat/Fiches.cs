using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace FootStat
{

    public partial class Fiches : UserControl
    {
        StoreData db = new StoreData();
        printWords printer = new printWords(@"C:\Users\MR.CPU\Documents\Visual Studio 2015\Projects\FootStat\FootStat\bin\Debug\fch.docx");
        public Fiches()
        {
            InitializeComponent();
        }

        private void Fiches_Load(object sender, EventArgs e)
        {
            db.Connect();
            DataTable dt = db.table("joueur","lvl = 1");
            DataTable Newdt = dt.DefaultView.ToTable(true, "ID", "Nom", "Prenom", "daten", "numero", "equipe", "addresse", "age");
            ListJoueurs.DataSource = Newdt;
            ListJoueurs.CurrentCell = null;
            ListJoueurs.ClearSelection();
            ListJoueurs.FirstDisplayedScrollingRowIndex = ListJoueurs.RowCount - 1;
            ListJoueurs.Columns[3].HeaderText = "Date Naissance";
            ListJoueurs.Columns[4].HeaderText = "Numero Tel";
            ListJoueurs.Columns[5].HeaderText = "Equipe";
            ListJoueurs.Columns[6].HeaderText = "Addresse";
            ListJoueurs.Columns[7].HeaderText = "Age";
            db.Close();
            Color color = ColorTranslator.FromHtml("#bdc3c7");
            Color color2 = ColorTranslator.FromHtml("#ecf0f1");
            ListJoueurs.RowsDefaultCellStyle.BackColor = color;
            ListJoueurs.AlternatingRowsDefaultCellStyle.BackColor = color2;
            ListJoueurs.CurrentCell = null;
            ListJoueurs.ClearSelection();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IDS,ver=0;
            int.TryParse(ListJoueurs.SelectedCells[0].Value.ToString(), out IDS);
            printer.init(IDS);
            if (db.Exist("physique","jou="+IDS+" ")) {
                printer.eval_phy();
                ver++;
            }
            if (db.Exist("technique", "jou=" + IDS + " "))
            {
                printer.eval_tech();
                ver++;
            }
            if (db.Exist("morphologie", "jou=" + IDS + " ") && db.Exist("physiologique", "jou=" + IDS + " "))
            {
                printer.eval_morphy();
                ver++;
            }
            if (ver == 3)
            {
                printer.TOTALS();
            }
            printer.save();

        }
    }
}
