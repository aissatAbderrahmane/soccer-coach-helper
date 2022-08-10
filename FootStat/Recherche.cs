using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Threading;
using xc = Microsoft.Office.Interop.Excel;
namespace FootStat
{
    public partial class Recherche : UserControl
    {
        private StoreData db = new StoreData();
        private Form1 frm;
        private List<String> check = new List<String>();
        public Recherche(Form1 fr)
        {
            frm = fr;
            InitializeComponent();
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
        }
        public void on_load()
        {

            db.Connect();
            DataTable dt = db.table("joueur","lvl=1");
            LoadDT(dt);
            db.Close();
        }
        private void LoadDT(DataTable dt)
        {
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
            ListJoueurs.Columns[0].FillWeight = 20;
            Color color = ColorTranslator.FromHtml("#bdc3c7");
            Color color2 = ColorTranslator.FromHtml("#ecf0f1");
            ListJoueurs.RowsDefaultCellStyle.BackColor = color;
            ListJoueurs.AlternatingRowsDefaultCellStyle.BackColor = color2;
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
            if (equipe_list.Text != "" && equipe_list.Text != "Equipe") {
                getSources();
            } 
        }

        private void type_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                
            if (type_list.Text != "type de joueur" && type_list.Text != "") {
                if (type_list.Text == "Actif") // 
                {
                    button3.Text = "Archiver";
                    button1.Enabled = false;
                }
                else if (type_list.Text == "Archiver" && type_list.Text != "")
                {
                    button3.Text = "Suprimmer";
                    button1.Enabled = true;
                }
                getSources();
            }
        }
        private int getMyIndex(String txt)
        {
            if (check.Count > 0) { 
            for (int i=0; i<check.Count;i++)
                {
                    if (check[i] == txt) return i;
                }
            }
            return -1;
        }

        private void test_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (test_list.Text != "Numéro Du test" && test_list.Text != "") {
                getSources();
            }
        }
        private void getSources()
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
            
            string select_result = "", select_tests = "", select_equipe = "", select_type = "";
            string selector = "";
            if (equipe_list.Text != "" && equipe_list.Text != "Equipe" && getMyIndex("E") != -1)
            {
                select_equipe += (getMyIndex("E") > 0) ? " and equipe='" + equipe_list.Text + "' " : "  equipe='" + equipe_list.Text + "' ";
            }
            if (type_list.Text != "type de joueur" && type_list.Text != "" && getMyIndex("L") != -1)
            {
                if (getMyIndex("L") == 0)
                    select_type += (type_list.Text == "Actif") ? "  lvl=1 " : "  lvl=0 ";
                else select_type += (type_list.Text == "Actif") ? " and lvl=1 " : " and lvl=0 ";
            }
            
            if (test_list.Text != "Numéro Du test" && test_list.Text != "" && getMyIndex("N") != -1)
            {
                if (getMyIndex("N") == 0)
                    select_tests += "test =" + test_list.Text + " ";
                else select_tests += " and test =" + test_list.Text + " ";
            }
            if (result_list.Text != "Résultat" && result_list.Text != "" && getMyIndex("R") != -1)
            {
                string toADD = "";
                db.Connect();
                switch (result_list.SelectedItem.ToString())
                {
                    case "Tout":
                        toADD = db.Caliter(0);
                        break;
                    case "Tré Bien":
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
                    case "Tré Faible":
                        toADD = db.Caliter(5);
                        break;
                }
                if (getMyIndex("R") == 0)
                    select_result = toADD;
                else if (getMyIndex("R") != -1) select_result = " and " + toADD;
            }// type list = L, N = test list , R = result list, E = equipe list
            if (getMyIndex("R") == 0)
            {
                if (select_result == "") select_result = "qualites > 0";
                selector = select_result + select_tests + select_equipe + select_type;
            }else if (getMyIndex("N") == 0)
            {
                selector = select_tests +select_type + select_result + select_equipe  ;
            }
            else if (getMyIndex("L") == 0)
            {
                selector = select_type + select_result + select_tests + select_equipe;
            }
            else if (getMyIndex("E") == 0)
            {
                selector =  select_equipe + select_type + select_result + select_tests;
            }
            return selector;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (id_v.Text != "")
            {
                db.Connect();
                if (button3.Text == "Archiver") {
                    db.exec(db.update("joueur", "lvl=0", "ID=" + id_v.Text + " "));
                    MessageBox.Show("Le Joueur A Bien été Archiver!");
                }
                else
                {
                    db.exec(db.delete("joueur", "ID=" + id_v.Text + " "));
                    db.exec(db.delete("physique", "jou=" + id_v.Text + " "));
                    db.exec(db.delete("technique", "jou=" + id_v.Text + " "));
                    db.exec(db.delete("physiologique", "jou=" + id_v.Text + " "));
                    db.exec(db.delete("morphologie", "jou=" + id_v.Text + " "));
                    MessageBox.Show("Le Joueur A Bien été suprimmer!");
                }
                db.Close();
            } else MessageBox.Show("il faut choisir un joueur !");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id_v.Text != "")
            {
                db.Connect();
                db.exec(db.update("joueur", "lvl=1", "ID=" + id_v.Text + " "));
                MessageBox.Show("Le Joueur A Bien été DisArchiver!");
                db.Close();
            }
            else MessageBox.Show("il faut choisir un joueur !");
        }

        private void result_list_SelectedIndexChanged(object sender, EventArgs e)
        { // Caliter
            
            if (result_list.Text != "Résultat" && result_list.Text != "" && getMyIndex("R") != -1 )
            {
                getSources();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            lodBar.Visible = true;
            lodPros.Visible = true;
            lodBar.Minimum = 0;
                lodBar.Value = 0;
                lod.RunWorkerAsync();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //
            if (checkBox1.Checked == true)
            {
                equipe_list.Enabled = true;
                check.Add("E");
            }
            else
            {
                equipe_list.ResetText();
                equipe_list.Enabled = false;
                check.RemoveAt(getMyIndex("E"));
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //
            if (checkBox2.Checked == true)  
            {
                result_list.Enabled = true;
                check.Add("R");
            }
            else
            {
                result_list.ResetText();
                result_list.Enabled = false;
                check.RemoveAt(getMyIndex("R"));
                
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            //
            if (checkBox3.Checked == true)
            { 
                type_list.Enabled = true;
                check.Add("L");
            }
            else
            {
                type_list.ResetText();
                type_list.Enabled = false;
                check.RemoveAt(getMyIndex("L"));
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            // 
            if (checkBox4.Checked == true) 
            {
                test_list.Enabled = true;
                check.Add("N");
            }
            else
            {
                test_list.ResetText();
                test_list.Enabled = false;
                check.RemoveAt(getMyIndex("N"));
            }
        }
        
        private void lod_DoWork(object sender, DoWorkEventArgs e)
        {

            printWords pr = new printWords("");
            int MX = db.ID("joueur")+1;
            int indx = 1;

            xc.Application apx = new xc.Application();
            xc.Workbook wr = apx.Workbooks.Add(xc.XlSheetType.xlWorksheet);
            xc.Worksheet wsh = (xc.Worksheet)apx.ActiveSheet;
            apx.Visible = false;
            for (int s = 1; s<=MX;s++) { 
             if (!lod.CancellationPending) {
                lod.ReportProgress(indx++ *100 / MX);
                    //Exc(int MAX,int cl,bool fn)
                    if( s!= MX) pr.Exc(s,s+1,false, apx,wsh);
                    else pr.Exc(s, s + 1, true, apx, wsh);
                }
            }
        }

        private void lod_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lodBar.Value = e.ProgressPercentage;
            lodPros.Text = string.Format("{0}", e.ProgressPercentage);
            lodBar.Update();
        }

        private void lod_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                Thread.Sleep(100);
                lodBar.Visible = false;
                lodPros.Visible = false;
            }
        }

        private void equipe_list_TextUpdate(object sender, EventArgs e)
        {
            MessageBox.Show("Modification Impossible !");
            equipe_list.Text = "Equipe";
        }

        private void result_list_TextUpdate(object sender, EventArgs e)
        {
            MessageBox.Show("Modification Impossible !");
            result_list.Text = "Résultat";
        }

        private void type_list_TextUpdate(object sender, EventArgs e)
        {
            MessageBox.Show("Modification Impossible !");
            type_list.Text = "type de joueur";
        }

        private void test_list_TextUpdate(object sender, EventArgs e)
        {
            MessageBox.Show("Modification Impossible !");
            test_list.Text = "Numéro Du test";
        }
    }
}
