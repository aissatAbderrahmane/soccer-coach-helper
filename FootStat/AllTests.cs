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
    public partial class AllTests : UserControl
    {
        private string ID;
        private StoreData db = new StoreData();
        private double physique, technique, morphologique, physiologie;
        public AllTests(string id)
        {
            InitializeComponent();
            ID = id;
        }

        private void AllTests_Load(object sender, EventArgs e)
        {
            phys();
            tech();
            physio();
            morpho();
            Tot();
        }
        private void phys()
        {
            db.Connect();
            db.getData(db.select("physique", "", "jou=" + ID + " "));
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
            db.getData(db.select("technique", "", "jou=" + ID + " "));
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
            db.getData(db.select("morphologie", "", "jou=" + ID + " "));
            while (db.reader.Read())
            {
                react.Text = db.reader["total"].ToString();
            }
            db.Close();
             double.TryParse(react.Text,out morphologique);
            db.compare("MorphNote", "Val", react, react_observ, false);
        }
        private void physio() {
            db.Connect();
            db.getData(db.select("physiologique", "", "jou=" + ID + " "));
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
        }
    }
}
