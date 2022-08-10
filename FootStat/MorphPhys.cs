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
    public partial class MorphPhys : UserControl
    {
        StoreData db = new StoreData();
        private string ID;
        private int nt;
        public MorphPhys(string id,int n)
        {
            InitializeComponent();
            ID = id;
            nt = n;
        }

        private void MorphPhys_Load(object sender, EventArgs e)
        {
            db.Connect();
            db.getData(db.select("morphologie", "", "jou=" + ID + " and nume=" + nt + " "));
            while (db.reader.Read())
            {
                react.Text = db.reader["taill"].ToString();
                course.Text = db.reader["poid"].ToString();
                TOT.Text = db.reader["total"].ToString();
                imcV.Text = db.reader["imc"].ToString();
            }
            db.Close();
            db.compare("TaillNote", "Val", react, react_observ, false);
            db.compare("PoidNote", "Val", course, cour_observ, false);
            IMCv(imcV, imc_obs);
            db.compare("MorphNote", "Val", TOT, TOTobs, false);
            TOT.Text += "/80";
            db.Connect();
           db.getData(db.select("physiologique", "", "jou=" + ID + " and nume=" + nt + " "));
            while (db.reader.Read())
            {
                cord.Text = db.reader["vo2max"].ToString();
            }
            db.Close();
            db.compare("VO2MAX", "Val", cord, cord_observ, false);
           
            double Y;
            double.TryParse(react.Text, out Y);
            initGraph("Taille",Y, 0, Color.AliceBlue);
            double.TryParse(course.Text, out Y);
            initGraph("Poids", Y, 1, Color.AntiqueWhite);
            double.TryParse(cord.Text, out Y);
            initGraph("Vo2max", Y, 2, Color.Blue);


        }
        private void initGraph(string X, double Y,int n,Color clr)
        {
            Series srs = chart1.Series[0];
            srs.Points.AddXY(X,Y);
            srs.Points[n].Color = clr;
            
        }
        private void IMCv( Label val, Label obs)
        {
            double i;
            double.TryParse(val.Text, out i);
            if (i < 14.60 && i>=0)
            {
                
                obs.Text = "Maigreur";
            }else if (i < 20.51 && i >= 14.60)
            {
                
                obs.Text = "Normale";
            }
            else if (i < 23.61 && i >= 20.51)
            {
                
                obs.Text = "Surpoids";
            }
            else if ( i >= 23.62)
            {
                
                obs.Text = "Obèse";
            }
        }

    }
}
