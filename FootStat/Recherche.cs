using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FootStat
{
    public partial class Recherche : UserControl
    {
        private StoreData db = new StoreData();
        private Form1 frm;
        public Recherche(Form1 fr)
        {
            frm = fr;
            InitializeComponent();
        }
        public void on_load()
        {

            db.Connect();
            DataTable dt = db.table("joueur");
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
        }
        private void Recherche_Load(object sender, EventArgs e)
        {
            on_load();
           
        }

        private void id_v_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(id_v.Text))
            {
                nom_v.Text = "";
                prenom_v.Text = "";
                date_v.Text = "";
                nom_v.Enabled = false;
                prenom_v.Enabled = false;
                date_v.Enabled = false;
                if (db.Exist("joueur", " ID=" + id_v.Text + " "))
                {
                    db.Connect();
                    db.getData(db.select("joueur", "", "ID=" + id_v.Text + " "));
                    while (db.reader.Read())
                    {
                        nom_v.Text = db.reader["nom"].ToString();
                        prenom_v.Text = db.reader["prenom"].ToString();
                        date_v.Text = db.reader["daten"].ToString();
                        foreach (DataGridViewRow vue in ListJoueurs.Rows)
                        {
                            if (vue.Cells[0].Value.ToString() == id_v.Text)
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
            }else
            {
                nom_v.Text = "";
                prenom_v.Text = "";
                date_v.Text = "";
                nom_v.Enabled = true;
                prenom_v.Enabled = true;
                date_v.Enabled = true;
            }
        }

        private void ListJoueurs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            db.Connect();
            db.getData(db.select("joueur", "", "ID=" + ListJoueurs.SelectedCells[0].Value + " "));
            while (db.reader.Read())
            {
                nom_v.Text = db.reader["nom"].ToString();
                prenom_v.Text = db.reader["prenom"].ToString();
                date_v.Text = db.reader["daten"].ToString();
                break;
            }
            db.reader.Close();
            db.Close();
            id_v.Text = ListJoueurs.SelectedCells[0].Value.ToString();

        }

        private void nom_v_TextChanged(object sender, EventArgs e)
        {
            if (nom_v.Enabled == true)
            {
                foreach (DataGridViewRow vue in ListJoueurs.Rows)
                {
                    if (vue.Cells[1].Value.ToString() == nom_v.Text)
                    {
                        vue.Selected = true;
                        ListJoueurs.CurrentCell = vue.Cells[0];
                    }
                    else continue;
                }
            }
        }

        private void prenom_v_TextChanged(object sender, EventArgs e)
        {
            if (prenom_v.Enabled == true)
            {
                foreach (DataGridViewRow vue in ListJoueurs.Rows)
                {
                    if (vue.Cells[2].Value.ToString() == prenom_v.Text)
                    {
                        vue.Selected = true;
                        ListJoueurs.CurrentCell = vue.Cells[0];
                    }
                    else continue;
                }
            }
        }

        private void date_v_TextChanged(object sender, EventArgs e)
        {
            if (date_v.Enabled == true)
            {
                foreach (DataGridViewRow vue in ListJoueurs.Rows)
                {
                    if (vue.Cells[3].Value.ToString() == date_v.Text)
                    {
                        vue.Selected = true;
                        ListJoueurs.CurrentCell = vue.Cells[0];
                    }
                    else continue;
                }
            }
        }

        private void equipe_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (equipe_list.Text != "Touts") {
                db.Connect();
                db.exec(db.select("joueur", "", recherche_string()));
                DataTable dtTable = new DataTable();
                OleDbDataAdapter adapter = new OleDbDataAdapter(db.cmd);
                adapter.Fill(dtTable);
                DataTable Newdt = dtTable.DefaultView.ToTable(true, "ID", "Nom", "Prenom", "daten", "numero", "equipe", "addresse", "age");
                ListJoueurs.DataSource = Newdt;
                db.Close();
            } else on_load();
        }

        private void type_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                db.Connect();
            if (type_list.Text == "Actif")
            {
                db.exec(db.select("joueur", "", recherche_string()));
                button3.Text = "Archiver";
                button1.Enabled = false;
            }
            else if(type_list.Text != "type de joueur")
            {
                db.exec(db.select("joueur", "", recherche_string()));
                button3.Text = "Suprimmer";
                button1.Enabled = true;
            }
            DataTable dtTable = new DataTable();
                OleDbDataAdapter adapter = new OleDbDataAdapter(db.cmd);
                adapter.Fill(dtTable);
                DataTable Newdt = dtTable.DefaultView.ToTable(true, "ID", "Nom", "Prenom", "daten", "numero", "equipe", "addresse", "age");
                ListJoueurs.DataSource = Newdt;
                db.Close();
            
        }

        private void test_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (test_list.Text != "Numero Du test") {
                db.Connect();
                
                db.exec(db.select("joueur", "", recherche_string()));
                DataTable dtTable = new DataTable();
                OleDbDataAdapter adapter = new OleDbDataAdapter(db.cmd);
                adapter.Fill(dtTable);
                DataTable Newdt = dtTable.DefaultView.ToTable(true, "ID", "Nom", "Prenom", "daten", "numero", "equipe", "addresse", "age");
                ListJoueurs.DataSource = Newdt;
                db.Close();

            }
        }
        private string recherche_string()
        {
            
            string select_result = "", select_tests, select_equipe, select_type;
            if (equipe_list.Text != "Touts" && equipe_list.Text != "Equipe")
            {
                select_equipe = (test_list.Text != "Numero Du test") ? " and equipe='" + equipe_list.Text + "' " : "  equipe='" + equipe_list.Text + "' ";
            }
            else select_equipe = "";
            if (type_list.Text != "type de joueur")
            {
                if ((equipe_list.Text == "Touts" || equipe_list.Text == "Equipe") && test_list.Text == "Numero Du test") 
                select_type = (type_list.Text == "Actif") ? "  lvl=1 " : "  lvl=0 ";
                else select_type = (type_list.Text == "Actif") ? " and lvl=1 " : " and lvl=0 ";
            }
            else select_type = " ";
            select_tests = (test_list.Text != "Numero Du test") ? "test ="+ test_list.Text+" " : "";

            return ""+ select_tests+ select_equipe+ select_type;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrWhiteSpace(id_v.Text))
            {
                
                modifier Modifier = new modifier(id_v.Text);
                frm.CNTS.Controls.Clear();
                frm.CNTS.Controls.Add(Modifier);
            }
            else MessageBox.Show("Vous deviez choisir le joueur!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            db.Connect();
            if (button3.Text == "Archiver" ) {
                db.exec(db.update("joueur","lvl=0", "ID=" + id_v.Text + " "));
                MessageBox.Show("Le Joueur A Bien été Archiver!");
            }
            else
            {
                db.exec(db.delete("joueur", "ID="+ id_v.Text + " "));
                db.exec(db.delete("physique", "jou="+ id_v.Text + " "));
                db.exec(db.delete("technique", "jou="+ id_v.Text + " "));
                db.exec(db.delete("physiologique", "jou="+ id_v.Text + " "));
                db.exec(db.delete("morphologie", "jou="+ id_v.Text + " "));
                MessageBox.Show("Le Joueur A Bien été suprimmer!");
            }
            db.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.Connect();
            db.exec(db.update("joueur", "lvl=1", "ID=" + id_v.Text + " "));
            MessageBox.Show("Le Joueur A Bien été DisArchiver!");
            db.Close();
        }
    }
}
