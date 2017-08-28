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
    public partial class MorphPhys : UserControl
    {
        StoreData db = new StoreData();
        private string ID;
        public MorphPhys(string id)
        {
            InitializeComponent();
            ID = id;
        }

        private void MorphPhys_Load(object sender, EventArgs e)
        {
            db.Connect();
            db.getData(db.select("morphologie", "", "jou=" + ID + " "));
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
            db.Connect();
           db.getData(db.select("physiologique", "", "jou=" + ID + " "));
            while (db.reader.Read())
            {
                cord.Text = db.reader["vo2max"].ToString();
            }
            db.Close();
            db.compare("VO2MAX", "Val", cord, cord_observ, false);
            
           
        }
        private void IMCv( Label val, Label obs)
        {
            double i;
            double.TryParse(val.Text, out i);
            if (i < 14.60 && i>=0)
            {
                
                obs.Text = "Perte de poids";
            }else if (i < 20.51 && i >= 14.60)
            {
                
                obs.Text = "Poids normal";
            }
            else if (i < 23.61 && i >= 20.51)
            {
                
                obs.Text = "Augmentation de poids";
            }
            else if ( i >= 23.62)
            {
                
                obs.Text = "Graisse";
            }
        }

    }
}
