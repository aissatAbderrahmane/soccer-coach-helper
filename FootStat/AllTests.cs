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
    public partial class AllTests : UserControl
    {
        private double tt = 0,toCom = 0;
        private string ID;
        private StoreData db = new StoreData();
        private double physique, technique, morphologique, physiologie;
        private int nt;
        private int counter = 1;
        public AllTests(string id,int n)
        {
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            InitializeComponent();
            ID = id;
            nt = n;
        }

        private void AllTests_Load(object sender, EventArgs e)
        {
            phys();
            tech();
            physio();
            morpho();
            Tot();
            double Y;
            double.TryParse(react.Text, out Y);
            initGraph("Morphologie", Y, 0, Color.White);
            double.TryParse(course.Text,out Y);
            initGraph("Physique",Y , 1, Color.Green);
            double.TryParse(sergent.Text, out Y);
            initGraph("Technique", Y, 2, Color.Red);
            double.TryParse(soupl.Text, out Y);
            initGraph("Physiologique", Y, 3, Color.WhiteSmoke);
        }
        private void phys()
        {
            db.Connect();
            db.getData(db.select("physique", "", "jou=" + ID + " and nume=" + nt + " "));
            while (db.reader.Read())
            {
                course.Text = db.reader["total"].ToString();
            }
            db.Close();
              double.TryParse(course.Text,out physique);
            db.compare("phyTotl", "Val", course, cour_observ, false);
        }
        private void tech() {
            db.Connect();
            db.getData(db.select("technique", "", "jou=" + ID + " and nume=" + nt + " "));
            while (db.reader.Read())
            {
                sergent.Text = db.reader["total"].ToString();
            }
            db.Close();
              double.TryParse(sergent.Text,out technique);
            db.compare("TechAll", "Val", sergent, serg_observ, false);
        }
        private void morpho() {
            db.Connect();
            db.getData(db.select("morphologie", "", "jou=" + ID + " and nume=" + nt + " "));
            while (db.reader.Read())
            {
                react.Text = db.reader["total"].ToString();
            }
            db.Close();
             double.TryParse(react.Text,out morphologique);
            db.compare("MorphNote", "Val", react, react_observ, false);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Enabled == false) pictureBox1.Enabled = true;
            button4.BackgroundImage = FootStat.Properties.Resources.flashpro;
            button4.Click -= button4_Click;
            button4.Click += Button4_Click;
            chart1.Visible = false;
            if (tt >= 44)
            {
                if(tt < toCom) pictureBox1.Image = FootStat.Properties.Resources.Refuser;
                else pictureBox1.Image = FootStat.Properties.Resources.soccer_field_311115;
            }
            else pictureBox1.Image = FootStat.Properties.Resources.Refuser;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Visible = true;
            timer1.Enabled = true;
        }
        private void TB()
        {
            DataTable tbTB = new DataTable();
            tbTB.Columns.Add();
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            chart1.Visible = true;
            button4.BackgroundImage = FootStat.Properties.Resources.soccer_4;
            button4.Click += button4_Click;
            button4.Click -= Button4_Click;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            nvtxt.Visible = true;
            tableLayoutPanel1.Visible = true;
            
            string[] ori = {"","","","","","","","","","","","" };
            switch (trackBar1.Value)
            {
                case 1:
                    ori[0] = "Moyene";
                    ori[1] = "1,88"; // reaction
                    ori[2] = "11,19"; // course
                    ori[3] = "6,13"; // serg
                    ori[4] = "2,11"; // souplesse
                    ori[5] = "9,66"; // cordination
                    ori[6] = "33,10"; // jong
                    ori[7] = "10,44"; // sla
                    ori[8] = "51,17"; //controle
                    ori[9] = "149,94"; // taill
                    ori[10] = "43,42"; // pois
                    ori[11] = "38,23"; // vo2
                    toCom = 50;
                    break;
                case 2:
                    ori[0] = "Moyene";
                    ori[1] = "1,81"; // reaction
                    ori[2] = "10,76"; // course
                    ori[3] = "6,72"; // serg
                    ori[4] = "4,41"; // souplesse
                    ori[5] = "9,05"; // cordination
                    ori[6] = "38,11"; // jong
                    ori[7] = "10,03"; // sla
                    ori[8] = "64,51"; //controle
                    ori[9] = "153,23"; // taill
                    ori[10] = "45,10"; // pois
                    ori[11] = "40,00"; // vo2
                    toCom = 55;
                    break;
                case 3:
                    ori[0] = "Bien";
                    ori[1] = "1,73"; // reaction
                    ori[2] = "10,25"; // course
                    ori[3] = "7,42"; // serg
                    ori[4] = "7,18"; // souplesse
                    ori[5] = "8,31"; // cordination
                    ori[6] = "44,12"; // jong
                    ori[7] = "9,54"; // sla
                    ori[8] = "80,51"; //controle
                    ori[9] = "157,17"; // taill
                    ori[10] = "47,11"; // pois
                    ori[11] = "42,12"; // vo2
                    toCom = 61;
                    break;
                case 4:
                    ori[0] = "Bien";
                    ori[1] = "1,66"; // reaction
                    ori[2] = "9,74"; // course
                    ori[3] = "8,13"; // serg
                    ori[4] = "9,94"; // souplesse
                    ori[5] = "7,57"; // cordination
                    ori[6] = "50,13"; // jong
                    ori[7] = "9,06"; // sla
                    ori[8] = "96,52"; //controle
                    ori[9] = "161,11"; // taill
                    ori[10] = "49,13"; // pois
                    ori[11] = "44,25"; // vo2
                    toCom = 67;
                    break;
                case 5:
                    ori[0] = "Tré Bien";
                    ori[1] = "1,56"; // reaction
                    ori[2] = "9,14"; // course
                    ori[3] = "8,96"; // serg
                    ori[4] = "13,17"; // souplesse
                    ori[5] = "6,71"; // cordination
                    ori[6] = "57,14"; // jong
                    ori[7] = "8,49"; // sla
                    ori[8] = "115,20"; //controle
                    ori[9] = "165,71"; // taill
                    ori[10] = "51,48"; // pois
                    ori[11] = "46,73"; // vo2
                    toCom = 74;
                    break;
                case 6:
                    ori[0] = "Tré Bien";
                    ori[1] = "1,49"; // reaction
                    ori[2] = "8,63"; // course
                    ori[3] = "9,66"; // serg
                    ori[4] = "15,93"; // souplesse
                    ori[5] = "5,97"; // cordination
                    ori[6] = "63,15"; // jong
                    ori[7] = "8,00"; // sla
                    ori[8] = "131,20"; //controle
                    ori[9] = "169,65"; // taill
                    ori[10] = "53,49"; // pois
                    ori[11] = "48,85"; // vo2
                    toCom = 80;
                    break;
                default:
                    nvtxt.Visible = false;
                    tableLayoutPanel1.Visible = false;
                    toCom = 0;
                    break;
            }
            initOrient(ori);
        }
        private void initOrient(string[] ort)
        {
            nvtxt.Text = ort[0];
            react_o.Text = ort[1];
            cour_o.Text = ort[2];
            serg_o.Text = ort[3];
            soupl_o.Text = ort[4];
            cord_o.Text = ort[5];
            jong_o.Text = ort[6];
            cond_o.Text = ort[7];
            cont_o.Text = ort[8];
            tall_o.Text = ort[9];
            poi_o.Text = ort[10];
            vo_o.Text = ort[11];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counter == 30)
            {
                pictureBox1.Enabled = false;
                timer1.Enabled = false;
                counter = 1;
            }
            else counter++;
        }

        private void physio() {
            db.Connect();
            db.getData(db.select("physiologique", "", "jou=" + ID + " and nume=" + nt + " "));
            while (db.reader.Read())
            {
                soupl.Text = db.reader["VO2MAX"].ToString();
            }
            db.Close();
             double.TryParse(soupl.Text,out physiologie);
            db.compare("VO2MAX", "Val", soupl, soupl_observ, false);
        }
        private void Tot() {
            double somme = physique + technique + morphologique + physiologie;
            moy.Text = somme.ToString();
            db.compare("totalNote", "Val", moy, totlObs, false);
            double.TryParse(moy.Text,out tt);
            moy.Text += "/80";
        }
        private void initGraph(string X, double Y,int n, Color clr)
        {
            Series srs = chart1.Series[0];
            srs.Points.AddXY(X,Y);
            srs.Points[n].Color = clr;

        }
    }
}
