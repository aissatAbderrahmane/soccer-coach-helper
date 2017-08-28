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
    public partial class Technique : UserControl
    {
        private string ID;
        StoreData db = new StoreData();
        public Technique(string id)
        {
            InitializeComponent();
            ID = id;
        }

        private void Technique_Load(object sender, EventArgs e)
        {
            db.Connect();
            db.getData(db.select("technique", "", "jou=" + ID + " "));
            while (db.reader.Read())
            {
                react.Text = db.reader["jengelerie"].ToString();
                course.Text = db.reader["slalome"].ToString();
                sergent.Text = db.reader["controleBall"].ToString();
                cord.Text = db.reader["total"].ToString();
            }
            db.Close();
            db.compare("genglNote", "Val", react, react_observ, false);
            db.compare("slaBallNote", "Val", course, cour_observ, true);
            db.compare("cntBallNote", "Val", sergent, serg_observ, false);     
            db.compare("TechAll", "Val", cord, cord_observ, false);
            initGraph();
        }
        private void initGraph()
        {
            
            int r;
            int.TryParse(react.Text, out r);
            JenBar.Value = r;
            JenBarVal.Text = react.Text;
            //-------------
            int.TryParse(course.Text, out r);
            ContrBar.Value = r;
            ContrBarVal.Text = course.Text;
            //-------------
            int.TryParse(sergent.Text, out r);
            SlalBar.Value = r;
            SlalBarVal.Text = sergent.Text;
        }
    }
}
