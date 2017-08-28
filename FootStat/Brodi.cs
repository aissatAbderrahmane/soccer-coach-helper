using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootStat
{
    public partial class Brodi : UserControl
    {
        private int ID;
        private StoreData db = new StoreData();
        private Calcules cal = new Calcules();
        private double[] test1, testn;
        public Brodi()
        {
            InitializeComponent();
        }//cal_BRODIS(double test1, double testN)

        private void Brodi_Load(object sender, EventArgs e)
        {
           
            
        }

        private void ID_V_TextChanged(object sender, EventArgs e)
        {
            int tn = 0,i;
            NTESTS.Enabled = false;
            
            if ( db.Exist("joueur","ID="+ID_V.Text+" "))
            {
                db.Connect();
                db.getData(db.select("joueur","","ID="+ID_V.Text+" "));
                while (db.reader.Read())
                {
                    int.TryParse(db.reader["test"].ToString(),out tn);
                }
                db.Close();
                if (tn >= 2) { 
                    for (i = 2; i <= tn; i++)
                        NTESTS.Items.Add("test1-test" + i);
                    int.TryParse(ID_V.Text, out ID);
                }
                else MessageBox.Show("Ce Joueur n'a pas enore fait 2 test ou plus !");
            } else MessageBox.Show("Ce Joueur N'exist Pas !");
        }
        private void initGraph()
        {
            //Brodi_Graph
            db.Connect();
        }

     

        private void NTESTS_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n;
            switch (NTESTS.SelectedText)
            {
                case "test1-test2":
                    addVal(2);
                    break;
                case "test1-test3":
                    addVal(3);
                    break;
                case "test1-test4":
                    addVal(4);
                    break;

            }
            

        }
        private void addVal(int n2)
        {
                Morphologie(ID, 1); Physique(ID, 1);
            test1 = testn;
            react1.Text = test1[0].ToString();
            course1.Text = test1[1].ToString();
            serg1.Text = test1[2].ToString();
            soupl1.Text = test1[3].ToString();
            cord1.Text = test1[4].ToString();
            taill1.Text = test1[5].ToString();
            poid1.Text = test1[6].ToString();
            imc1.Text = test1[7].ToString();
            vo1.Text = test1[8].ToString();
                 Morphologie(ID, n2); Physique(ID, n2);
            react1.Text = testn[0].ToString();
            course1.Text = testn[1].ToString();
            serg1.Text = testn[2].ToString();
            soupl1.Text = testn[3].ToString();
            cord1.Text = testn[4].ToString();
            taill1.Text = testn[5].ToString();
            poid1.Text = testn[6].ToString();
            imc1.Text = testn[7].ToString();
            vo1.Text = testn[8].ToString();
            ///
            reactPR.Text = cal.cal_BRODIS(test1[0], testn[0]).ToString();
            coursePR.Text = cal.cal_BRODIS(test1[1], testn[1]).ToString();
            sergPR.Text = cal.cal_BRODIS(test1[2], testn[2]).ToString();
            souplPR.Text = cal.cal_BRODIS(test1[3], testn[3]).ToString();
            cordPR.Text = cal.cal_BRODIS(test1[4], testn[4]).ToString();
            taillPR.Text = cal.cal_BRODIS(test1[5], testn[5]).ToString();
            poidPR.Text = cal.cal_BRODIS(test1[6], testn[6]).ToString();
            imcPR.Text = cal.cal_BRODIS(test1[7], testn[7]).ToString();
            voPR.Text = cal.cal_BRODIS(test1[8], testn[8]).ToString();
        }
        private void Physique(int id, int N) {
            //{ "react", "cours", "serg", "soupl", "cord", "dist", "total", "jou", "nume" };
            db.Connect();
            db.exec(db.select("physique","","jou="+id+" and num="+N+" "));
            while (db.reader.Read())
            {
                double.TryParse(db.reader["react"].ToString(),out testn[0]);
                double.TryParse(db.reader["cours"].ToString(), out testn[1]);
                double.TryParse(db.reader["serg"].ToString(), out testn[2]);
                double.TryParse(db.reader["soupl"].ToString(), out testn[3]);
                double.TryParse(db.reader["cord"].ToString(), out testn[4]);
            }
            db.Close();
        }
        private void Morphologie(int id, int N)
        {//"taill", "poid", "imc", "total", "jou", "nume"
            db.Connect();
            db.exec(db.select("morphologie", "", "jou=" + id + " and num="+N+" "));
            while (db.reader.Read())
            {
                double.TryParse(db.reader["taill"].ToString(), out testn[5]);
                double.TryParse(db.reader["poid"].ToString(), out testn[6]);
                double.TryParse(db.reader["imc"].ToString(), out testn[7]);
            }
            db.Close();
            db.Connect();
            db.exec(db.select("physiologique", "", "jou=" + id + " and num=" + N + " "));
            while (db.reader.Read())
            {
                double.TryParse(db.reader["vo2max"].ToString(), out testn[8]);
            }
            db.Close();
        }
    }
}
