using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Collections.Generic;

namespace FootStat
{

    public partial class Fiches : UserControl
    {
        StoreData db = new StoreData();
        private Color[] colors = { Color.White, Color.Black };
        private List<String> check = new List<String>();
        private int TESTn = 1;
        public Fiches()
        {
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            InitializeComponent();
        }

        private void Fiches_Load(object sender, EventArgs e)
        {
            db.Connect();
            DataTable dt = db.table("joueur","lvl = 1");
            LoadDT(dt,true);
            db.Close();
            timer1.Start();
        }
        private void LoadDT(DataTable dts, Boolean fs = false)
        {
            DataTable Newdt = dts.DefaultView.ToTable(true,  "ID", "Nom", "Prenom", "daten", "numero", "equipe", "addresse", "age");
            ListJoueurs.DataSource = Newdt; 
            ListJoueurs.CurrentCell = null;
            /*if (fs == true) { 
                DataGridViewCheckBoxColumn ds = new DataGridViewCheckBoxColumn();
            ds.TrueValue = 1;
            ds.FalseValue = 0;
            ds.FillWeight = 20;
            ds.ReadOnly = false;
            ListJoueurs.Columns.Insert(0, ds);
            }  */
            ListJoueurs.ClearSelection();
            ListJoueurs.FirstDisplayedScrollingRowIndex = ListJoueurs.RowCount - 1;
            ListJoueurs.Columns[3].HeaderText = "Date Naissance";
            ListJoueurs.Columns[4].HeaderText = "Numero Tel";
            ListJoueurs.Columns[5].HeaderText = "Equipe";
            ListJoueurs.Columns[6].HeaderText = "Addresse";
            ListJoueurs.Columns[7].HeaderText = "Age";
            ListJoueurs.Columns[0].FillWeight = 20;
            ListJoueurs.CurrentCell = null;
            ListJoueurs.ClearSelection();
            ListJoueurs.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            initColors();
        }
        private void initColors()
        {
            int IDcolor = 0;
            foreach (DataGridViewRow row in ListJoueurs.Rows)
            {
                db.Connect();
                db.getData(db.select("joueur","", "ID="+ row.Cells[0].Value+ " and lvl=1"));
                while (db.reader.Read())
                {
                    int.TryParse(db.reader["test"].ToString(), out IDcolor);
                }
                db.Close();
                row.DefaultCellStyle.BackColor = selectColor(IDcolor)[0];
                row.DefaultCellStyle.ForeColor = selectColor(IDcolor)[1];
               
            }
        }
       
        private Color[] selectColor(int num)
        {
            
            switch (num) {
                case 1: 
                    colors[0] = Color.White;
                    colors[1] = Color.Black;
                    break;
                case 2:
                     colors[0] = Color.LightCoral;
                     colors[1] = Color.Red;
                    break;
                case 3:
                     colors[0] = Color.LightGreen;
                     colors[1] = Color.Green;
                    break;
                case 4:
                     colors[0] = Color.Yellow;
                     colors[1] = Color.Orange;
                    break;
            }
            return colors;
         }
        private void button3_Click(object sender, EventArgs e)
        {
             ES(ListJoueurs.SelectedCells[0].Value.ToString());
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
             AS(ListJoueurs.SelectedCells[0].Value.ToString());
        }
        private void ES(string IDe)
        {
            var path = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "C:/FootTest/fch.docx");
            printWords printer = new printWords(path);
            int IDS, ver = 0;
            int.TryParse(IDe, out IDS);
            printer.init(IDS, TESTn);
            if (db.Exist("physique", "jou=" + IDS + " "))
            {
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
        private void AS(string IDe)
        { 
            printWords printer = new printWords("C:/FootTest/fchT.docx");
            int IDS;
            int.TryParse(IDe, out IDS);
            printer.init(IDS);
            if (db.Exist("physique", "jou=" + IDS + " "))
            {
                printer.eval_phy(true);

            }
            if (db.Exist("technique", "jou=" + IDS + " "))
            {
                printer.eval_tech(true);

            }
            if (db.Exist("morphologie", "jou=" + IDS + " ") && db.Exist("physiologique", "jou=" + IDS + " "))
            {
                printer.eval_morphy(true);

            }
            printer.save();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.Text != "" && comboBox1.Text != "Résultat Du joueur")
            {
                if (getMyIndex("R") == -1 && comboBox1.Text != "Tout") check.Add("R");
                if (comboBox1.Text == "Tout" && getMyIndex("R") != -1) check.RemoveAt(getMyIndex("R"));
            }
            selections();
        }
        int counter = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (counter == 3)
            {
                initColors();
                
                timer1.Stop();
            }
            else counter++;
        }


        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int.TryParse(comboBox3.SelectedItem.ToString(), out TESTn);
        }

        private void ListJoueurs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox3.Items.Clear();
            int NT = 1;
            TESTn = 1;
            db.Connect();
            db.getData(db.select("joueur", "", "ID=" + ListJoueurs.SelectedCells[0].Value.ToString() + " and lvl=1"));
            while (db.reader.Read())
            {
                int.TryParse(db.reader["test"] + "", out NT);
            }
            db.Close();
            if (NT >1) {
                for (int J = 1; J <= NT; J++)
                {
                    comboBox3.Items.Add(J);
                }
                comboBox3.Visible = true;
            } else comboBox3.Visible = false;
        }
        private void selections()
        {
            db.Connect();
            db.exec(db.select("joueur", "", recherche_string()));
            DataTable dtTable = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(db.cmd);
            adapter.Fill(dtTable);
            DataTable Newdt = dtTable.DefaultView.ToTable(true, "ID", "Nom", "Prenom", "daten", "numero", "equipe", "addresse", "age");
            ListJoueurs.DataSource = Newdt;
            db.Close();
        }
        private string recherche_string()
        {
            string select_result = "", select_equipe = "", toADD = "";
            string sel = "";
            if (equipe_list.Text != "" && equipe_list.Text != "Equipe" && getMyIndex("E") != -1)
            {
                select_equipe += (getMyIndex("E") > 0) ? " and equipe='" + equipe_list.Text + "' " : "  equipe='" + equipe_list.Text + "' ";
            }
            if (comboBox1.Text != "Résultat" && comboBox1.Text != "" && getMyIndex("R") != -1)
            {
                db.Connect();
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "Tout":
                        toADD = db.Caliter(0);
                        break;
                    case "Trés Bien":
                        toADD = db.Caliter(1);
                        break;
                    case "Bien":
                        toADD = db.Caliter(2);
                        break;
                    case "Moyen":
                        toADD = db.Caliter(3);
                        break;
                    case "Faible":
                        toADD = db.Caliter(4);
                        break;
                    case "Trés Faible":
                        toADD = db.Caliter(5);
                        break;
                } 
            }
            if (getMyIndex("R") == 0)
                select_result = toADD;
            else if (getMyIndex("R") != -1) select_result = " and " + toADD;
            if (getMyIndex("R") == 0)
            {
                if (select_result == "") select_result = "qualites > 0";
                sel = select_result + select_equipe;
            }
            else if (getMyIndex("E") == 0)
            {
                sel = select_equipe + select_result;
            }
            return sel;
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (equipe_list.Text != "" && equipe_list.Text != "Equipe")
            {
                if (getMyIndex("E") == -1 && equipe_list.Text != "Tout") check.Add("E");
                if (equipe_list.Text == "Tout" && getMyIndex("R") != -1) check.RemoveAt(getMyIndex("E"));
            }
            selections();
        }
        private int getMyIndex(String txt)
        {
            if (check.Count > 0)
            {
                for (int i = 0; i < check.Count; i++)
                {
                    if (check[i] == txt) return i;
                }
            }
            return -1; 
        }

        private void equipe_list_TextUpdate(object sender, EventArgs e)
        {
            MessageBox.Show("Modification Impossible !");
            equipe_list.Text = "Equipe";
        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            MessageBox.Show("Modification Impossible !");
            comboBox1.Text = "Résultat";
        }

        private void comboBox3_TextUpdate(object sender, EventArgs e)
        {
            MessageBox.Show("Modification Impossible !");
            comboBox3.Text = "Numéro de Test";
        }
    }
}
