﻿using System;
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
    public partial class EvalPhysique : UserControl
    {
        StoreData db = new StoreData();
        private string ID;
        public EvalPhysique(string id)
        {
            InitializeComponent();
            ID = id;
        }

        private void EvalPhysique_Load(object sender, EventArgs e)
        {
            double val;
            db.Connect();
            db.getData(db.select("physique", "", "jou=" + ID + " "));
          
            while (db.reader.Read())
            {
                react.Text = db.reader["react"].ToString();
                soupl.Text = db.reader["soupl"].ToString();
                course.Text = db.reader["cours"].ToString();
                sergent.Text = db.reader["serg"].ToString();
                cord.Text = db.reader["cord"].ToString();
                moy.Text =db.reader["total"].ToString();
            }
            db.Close();
            db.compare("ReactNote", "Val", react, react_observ, true);
            db.compare("souplNote", "Val", soupl, soupl_observ, false);
            db.compare("CourNote", "Val", course, cour_observ, true);
            db.compare("sergNote", "Val", sergent, serg_observ, false);
            db.compare("coordNote", "Val", cord, cord_observ, true);
            db.compare("phyTotl", "Val", moy, totlObs, false);
            EvalPhyGr.ChartAreas[0].AxisY.Minimum = 20;
            Legend lgn = new Legend();
            Series srs = new Series();
            EvalPhyGr.Series.Add(srs);
            double.TryParse(react.Text, out val);
            GraphChart("Reaction", "Reaction", val,Color.AliceBlue,0);
            double.TryParse(soupl.Text, out val);
            GraphChart("Souplesse", "Souplesse", val, Color.Aqua, 1);
            double.TryParse(course.Text, out val);
            GraphChart("Course", "Course", val, Color.Beige, 2);
            double.TryParse(sergent.Text, out val);
            GraphChart("Sergent", "Sergent", val, Color.Blue, 3);
            double.TryParse(cord.Text, out val);
            GraphChart("Cordination", "Cordination", val, Color.Cyan, 4);
        }
        private void GraphChart(string LGName, string X, double Y,Color clr,int n)
        {
            Series srs = EvalPhyGr.Series[0];
            if (Y == 20) Y = 20.5;
            srs.Points.AddXY(X,Y);
            srs.Points[n].Color = clr;
        }

   
    }
}
