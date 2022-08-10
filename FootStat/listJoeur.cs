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
        public listJoeur(Form1 fr)
        {
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            frm1 = fr;
            InitializeComponent();
            on_load();
            timer1.Start();
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
            ListJoueurs.Columns[0].FillWeight = 20;
            Color color = ColorTranslator.FromHtml("#bdc3c7");
            Color color2 = ColorTranslator.FromHtml("#ecf0f1");
            ListJoueurs.RowsDefaultCellStyle.BackColor = color;
            ListJoueurs.AlternatingRowsDefaultCellStyle.BackColor = color2;
            db.Close();
        }
        private string EquipeImg(string name)
        {
            string equipe_name = null;
            switch (name)
            {
                case "Rapide Club Rélizane": equipe_name = "RCR"; break;
                case "CSA ARRZEW": equipe_name = "OMA";  break;
                case "MASCARA": equipe_name = "GCM";  break;
                case "Sidi Belabbes": equipe_name = "USMBA";  break;
                case "Hessasna": equipe_name = "MB";  break;
                case "WAT Tlemcen": equipe_name = "WAT";  break;
                case "ASM Meghnia": equipe_name = "IRBM";  break;
                case "Les Etoiles de Tiaret": equipe_name = "NOUDJOUM"; break;
                default:
                    equipe_name = name;
                    break;
            }
            return equipe_name;
        }
        private void id_TextChanged(object sender, EventArgs e)
        {
            int i,n = 1;
            if (!string.IsNullOrWhiteSpace(id.Text)) {
                nom_v.Text = "";
                prenom_v.Text = "";
                age_v.Text = "";
                num_v.Text = "";
                ntest_v.Text = "";
               
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
                    PIC_v.ImageLocation =  (db.reader["img"].ToString() != "") ? db.reader["img"].ToString(): "C:/FootTest/joueurs/standar.png";
                        PIC_v.Width = 177;
                        PIC_v.Height = 173;
                        string is1 = "C:/FootTest/Equipes/" + EquipeImg(db.reader["equipe"].ToString()) + ".png";
                        string is2 = "C:/FootTest/Equipes/" + EquipeImg(db.reader["equipe"].ToString()) + ".jpg";
                        Equipe_v.ImageLocation = (File.Exists(is1)) ? is1 : is2;
                        Equipe_v.Width = 177;
                        Equipe_v.Height = 173;
                        int.TryParse(db.reader["test"]+"",out n);
                        
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
                    testNum.Items.Clear();
                    testNum.Items.Add("Numero Du Test");
                    for (i = 1; i <= n; i++)
                    {
                        testNum.Items.Add("test " + i);
                    }
                    testNum.Enabled = true;
                db.Close();
            }
            else MessageBox.Show("Joueur N'exist pas !");
            }
            else
            {
                testNum.Items.Clear();
                testNum.Items.Add("Numero Du Test");
                testNum.Enabled = false;
                nom_v.Text = "";
                prenom_v.Text = "";
                age_v.Text = "";
                num_v.Text = "";
                ntest_v.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool exist = false;
            int ntest = 1;
            if (typeEval.Text != "Type d'évaluation")
            {
                
                if (id.Text != "" && testNum.SelectedIndex != -1) {
                    int ID;
                    int.TryParse(id.Text, out ID);
                    switch (testNum.SelectedItem.ToString())
                    {
                        case "test 1":
                            ntest = 1;
                            break;
                        case "test 2":
                            ntest = 2;
                            break;
                        case "test 3":
                            ntest = 3;
                            break;
                        case "test 4":
                            ntest = 4;
                            break;
                    }
                    if (typeEval.Text == "Morphologique et Physiologique")
                    {
                        if (db.Exist("physiologique", "jou=" + id.Text + " and nume="+ ntest + " ")) exist = true;
                        else MessageBox.Show("Ce joueur n'a pas encore fait le test physiologie !");

                    }
                    else if (typeEval.Text == "Physique")
                    {
                        if (db.Exist("physique", "jou=" + id.Text + " and nume=" + ntest + " ")) exist = true;
                        else MessageBox.Show("Ce joueur n'a pas encore fait ce test!");
                    }
                    else if (typeEval.Text == "Technique" )
                    {
                       if(db.Exist("technique", "jou=" + id.Text + " and nume=" + ntest + " ")) exist = true;
                        else MessageBox.Show("Ce joueur n'a pas encore fait ce test!");
                    }
                    else if (typeEval.Text == "Performance Totale")
                    {
                        if(db.Exist("technique", "jou=" + id.Text + " and nume=" + ntest + " ") && db.Exist("physique", "jou=" + id.Text + " and nume=" + ntest + " ") && db.Exist("physiologique", "jou=" + id.Text + " and nume=" + ntest + " ") && db.Exist("morphologie", "jou=" + id.Text + " and nume=" + ntest + " "))
                        exist = true;
                        else MessageBox.Show("Ce joueur n'a pas encore fait touts les tests!");
                    }
                    if (exist == true) {
                        eval = new evaluation(frm1, typeEval.Text, ID, ntest);
                        frm1.CNTS.Controls.Clear();
                        frm1.CNTS.Controls.Add(eval);
                        frm1.elementHost1.Enabled = true;
                    }
                }
                else MessageBox.Show("Il faut choisir le joueur en utilisant l'identifiant et aussi le numéro de test.");
            }
            else MessageBox.Show("Il faut choisir le type d'évaluation.");
        
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
        private int counter = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counter == 5) {
                counter = 1;
                PIC_v.Visible = true;
                label13.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                id.Visible = true;
                typeEval.Visible = true;
                testNum.Visible = true;
                label11.Visible = true;
                button1.Visible = true;
                Equipe_v.Visible = true;
                ListJoueurs.Visible = true;
                label5.Visible = true;
                timer1.Stop();
            } else counter++;
        }

        private void typeEval_TextUpdate(object sender, EventArgs e)
        {
            MessageBox.Show("Modification impossible !");
            typeEval.Text = "Type d'évaluation";
        }

        private void testNum_TextUpdate(object sender, EventArgs e)
        {
            MessageBox.Show("Modification impossible !");
            testNum.Text = "Numéro Du Test";
        }
    }
}
