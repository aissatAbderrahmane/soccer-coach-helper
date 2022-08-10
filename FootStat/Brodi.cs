using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FootStat
{
    public partial class Brodi : UserControl
    {
        private int ID;
        private StoreData db = new StoreData();
        private Calcules cal = new Calcules();
        private double[] test1 = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private double[] testn = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public Brodi()
        {
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
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
                    NTESTS.Enabled = true;
                }
                else MessageBox.Show("Ce Joueur n'a pas enore fait 2 test ou plus !");
            } else MessageBox.Show("Ce Joueur N'exist Pas !");
        }
        private void initGraph(string X, double Y,int n,int tr,bool brds = false)
        {
            //Brodi_Graph
            Series srs = Brodi_Graph.Series[tr] ;
            if (brds == true) srs.ChartType = SeriesChartType.Radar;
            srs.IsValueShownAsLabel = true;
            
            srs.Points.AddXY(X, Y);
            srs.IsValueShownAsLabel = true;
           
        }

     

        private void NTESTS_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (NTESTS.SelectedItem.ToString())
            {
                case "test1-test2":
                    addVal(2);
                    label11.Text += " " + 2;
                    break;
                case "test1-test3":
                    addVal(3);
                    label11.Text += " " + 3;
                    break;
                case "test1-test4":
                    addVal(4);
                    label11.Text += " " + 4;
                    break;//
                
            }
            

        }
        private void initValGR(Label R1, Label R2, Label R3, string X, bool brF)
        {
            double s1, s2, s3;
            double.TryParse(R1.Text, out s1);
            double.TryParse(R2.Text, out s2);
            R3.Text = cal.cal_BRODIS(s1, s2, brF).ToString();
            double.TryParse(R3.Text, out s3);
            initGraph(X, s1, 0, 0);
            initGraph(X, s2, 1, 1);
            initGraph(X, s3, 2, 2);
        }
        private void addVal(int n2)
        {
            Physique(ID, 1);
            Morphologie(ID, 1);
            
            test1 = testn;
            react1.Text = Math.Round(test1[0],2).ToString();
            course1.Text = Math.Round(test1[1], 2).ToString();
            serg1.Text = Math.Round(test1[2], 2).ToString();
            soupl1.Text = Math.Round(test1[3], 2).ToString();
            cord1.Text = Math.Round(test1[4], 2).ToString();
            taill1.Text = Math.Round(test1[5], 2).ToString();
            poid1.Text = Math.Round(test1[6], 2).ToString();
            imc1.Text = Math.Round(test1[7], 2).ToString();
            vo1.Text = Math.Round(test1[8], 2).ToString();

            Physique(ID, n2); Morphologie(ID, n2); 

            react2.Text = Math.Round(testn[0], 2).ToString();
            course2.Text = Math.Round(testn[1], 2).ToString();
            serg2.Text = Math.Round(testn[2], 2).ToString();
            soupl2.Text = Math.Round(testn[3], 2).ToString();
            cord2.Text = Math.Round(testn[4], 2).ToString();
            taill2.Text = Math.Round(testn[5], 2).ToString();
            poid2.Text = Math.Round(testn[6], 2).ToString();
            imc2.Text = Math.Round(testn[7], 2).ToString();
            vo2.Text = Math.Round(testn[8], 2).ToString();
            ///
            Brodi_Graph.Series[0].Points.Clear();
            Brodi_Graph.Series[1].Points.Clear();
            Brodi_Graph.Series[2].Points.Clear();
            initValGR(taill1, taill2, taillPR, "Taille", false);
            initValGR(poid1, poid2, poidPR,"Pois", false);
            initValGR(imc1, imc2, imcPR, "IMC", false);
            initValGR(react1, react2, reactPR, "V.Reaction", true);
            initValGR(course1, course2, coursePR, "V.Course", true);
            initValGR(soupl1, soupl2, souplPR, "Souplesse", false);
            initValGR(cord1, cord2, cordPR, "Cordination", false);
            initValGR(serg1, serg2, sergPR, "Sergent", false);
            initValGR(vo1, vo2, voPR, "Vo2max", false);
            Color color0 = Brodi_Graph.Series[0].Color;
            Color color1 = Brodi_Graph.Series[1].Color;
            Color color2 = Brodi_Graph.Series[2].Color;
            Brodi_Graph.Series[0].Color = Color.FromArgb(128, color0);
            Brodi_Graph.Series[1].Color = Color.FromArgb(128, color1);
            Brodi_Graph.Series[2].Color = Color.FromArgb(128, color2);
        }
        private void Physique(int id, int N) {
            //{ "react", "cours", "serg", "soupl", "cord", "dist", "total", "jou", "nume" };

            db.Connect();
            db.getData(db.select("physique","","jou="+id+" and nume="+N+" "));
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
            db.getData(db.select("morphologie", "", "jou=" + id + " and nume="+N+" "));
            while (db.reader.Read())
            {
                double.TryParse(db.reader["taill"].ToString(), out testn[5]);
                double.TryParse(db.reader["poid"].ToString(), out testn[6]);
                double.TryParse(db.reader["imc"].ToString(), out testn[7]);
            }
            db.Close();
            db.Connect();
            db.getData(db.select("physiologique", "", "jou=" + id + " and nume=" + N + " "));
            while (db.reader.Read())
            {
                double.TryParse(db.reader["vo2max"].ToString(), out testn[8]);
            }
            db.Close();
        }
    }
}
