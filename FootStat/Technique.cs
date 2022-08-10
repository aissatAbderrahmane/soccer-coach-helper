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
        private int nt;
        public Technique(string id,int n)
        {
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            InitializeComponent();
            ID = id;
            nt = n;
        }

        private void Technique_Load(object sender, EventArgs e)
        {
            db.Connect();
            db.getData(db.select("technique", "", "jou=" + ID + " and nume=" + nt + " "));
            while (db.reader.Read())
            {
                react.Text = db.reader["jengelerie"].ToString();
                course.Text = db.reader["slalome"].ToString();
                sergent.Text = db.reader["controleBall"].ToString();
                cord.Text = db.reader["total"].ToString();
            }
            db.Close();
            db.compare("genglNote", "Val", react, react_observ, false);
            db.compare("genglNote", "Val", react, jngOBS, false);
            db.compare("slaBallNote", "Val", course, cour_observ, true);
            db.compare("slaBallNote", "Val", course, slaOBS, true);
            db.compare("cntBallNote", "Val", sergent, serg_observ, false);     
            db.compare("cntBallNote", "Val", sergent, cntOBS, false);
            db.compare("TechAll", "Val", cord, cord_observ, false);
            cord.Text += "/80";
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
