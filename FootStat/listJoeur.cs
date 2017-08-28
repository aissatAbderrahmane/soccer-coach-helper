using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;


namespace FootStat
{
    public partial class listJoeur  : UserControl
    {
        private StoreData db = new StoreData();
        private Form1 frm1 ;
        private evaluation eval;
        private int ver = 0;
        public listJoeur(Form1 fr)
        {
            frm1 = fr;
            InitializeComponent();
            on_load();
        }
        public void on_load()
        {

            db.Connect();
            DataTable dt = db.table("joueur","lvl=1");
            DataTable Newdt = dt.DefaultView.ToTable(true,"ID","Nom","Prenom","daten","numero","equipe","addresse","age");
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
        }

        private void id_TextChanged(object sender, EventArgs e)
        {

            
            
            if (!string.IsNullOrWhiteSpace(id.Text)) {
                nom_v.Text = "";
                prenom_v.Text = "";
                age_v.Text = "";
                num_v.Text = "";
                ntest_v.Text = "";
                dtest_v.Text = "";
                if (db.Exist("joueur", " ID=" + id.Text+" "))
            {
                db.Connect();
                db.getData(db.select("joueur","", "ID=" + id.Text + " "));
                while (db.reader.Read())
                {
                    nom_v.Text = db.reader["nom"].ToString();
                    prenom_v.Text = db.reader["prenom"].ToString();
                    age_v.Text = db.reader["age"].ToString();
                    num_v.Text = db.reader["numero"].ToString();
                    ntest_v.Text = db.reader["test"].ToString();
                    PIC_v.ImageLocation = db.reader["img"].ToString();
                        foreach (DataGridViewRow vue in ListJoueurs.Rows)
                        {
                            if (vue.Cells[0].Value.ToString() == id.Text)
                            {
                                vue.Selected = true;
                                ListJoueurs.CurrentCell = vue.Cells[0];
                            }
                            else continue;
                        }
                }
                db.Close();
            }
            else MessageBox.Show("Joueur N'exxist pas !");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool exist = false;
            if (typeEval.Text != "  type d'evaluation")
            {
                if (id.Text != "") {
                    int ID;
                    int.TryParse(id.Text, out ID);
                    
                    if (typeEval.Text == "Morphologie et Physiologie")
                    {
                        if (db.Exist("physiologique", "jou=" + id.Text + " ")) exist = true;
                        else MessageBox.Show("Ce joueur n'a pas encore fait le test physiologie !");

                    }
                    else if (typeEval.Text == "Physique")
                    {
                        if (db.Exist("physique", "jou=" + id.Text + " ")) exist = true;
                        else MessageBox.Show("Ce joueur n'a pas encore fait ce test!");
                    }
                    else if (typeEval.Text == "Technique" )
                    {
                       if(db.Exist("technique", "jou=" + id.Text + " ")) exist = true;
                        else MessageBox.Show("Ce joueur n'a pas encore fait ce test!");
                    }
                    else if (typeEval.Text == "Tous les types")
                    {
                        if(db.Exist("technique", "jou=" + id.Text + " ") && db.Exist("physique", "jou=" + id.Text + " ") && db.Exist("physiologique", "jou=" + id.Text + " ") && db.Exist("morphologie", "jou=" + id.Text + " "))
                        exist = true;
                        else MessageBox.Show("Ce joueur n'a pas encore fait touts les tests!");
                    }
                    if (exist == true) {
                        eval = new evaluation(frm1, typeEval.Text, ID);
                        frm1.CNTS.Controls.Clear();
                        frm1.CNTS.Controls.Add(eval);
                        frm1.initHome.Enabled = true;
                    }
                }
                else MessageBox.Show("Il faut choisir le joueur en utilisant l'identifiant.");
            }
            else MessageBox.Show("Il faut choisir le type d'evaluation.");
        
    }

        private void ListJoueurs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            db.Connect();
            db.getData(db.select("joueur", "", "ID=" + ListJoueurs.SelectedCells[0].Value + " and lvl=1 "));
            while (db.reader.Read())
            {
                nom_v.Text = db.reader["nom"].ToString();
                prenom_v.Text = db.reader["prenom"].ToString();
                age_v.Text = db.reader["age"].ToString();
                num_v.Text = db.reader["numero"].ToString();
                ntest_v.Text = db.reader["test"].ToString();
                PIC_v.ImageLocation = db.reader["img"].ToString();
                break;
            }
            db.reader.Close();
            db.Close();
            id.Text = ListJoueurs.SelectedCells[0].Value.ToString();

            
        }

        private void id_Click(object sender, EventArgs e)
        { 
            if(db.reader != null) db.reader.Close();
            id.Text = "";
            id.TextChanged += id_TextChanged;
        }
    }
}
