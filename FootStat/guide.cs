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
    public partial class guide : UserControl
    {
        public guide()
        {
            InitializeComponent();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Controls.Clear();
            Guide_Phy phy = new Guide_Phy();
            phy.Size = panel1.Size;
            panel1.Controls.Add(phy);

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Controls.Clear();
            Guide_Tech Tec = new Guide_Tech();
            Tec.Size = panel1.Size;
            panel1.Controls.Add(Tec);

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Controls.Clear();
            Guide_morpho mor = new Guide_morpho();
            mor.Size = panel1.Size;
            panel1.Controls.Add(mor);

        }

        private void linkLabel1_MouseHover(object sender, EventArgs e)
        {
            linkLabel1.LinkVisited = true;
        }

        private void linkLabel1_MouseLeave(object sender, EventArgs e)
        {
            linkLabel1.LinkVisited = false;
        }

        private void linkLabel2_MouseHover(object sender, EventArgs e)
        {
            linkLabel2.LinkVisited = true;
        }

        private void linkLabel2_MouseLeave(object sender, EventArgs e)
        {
            linkLabel2.LinkVisited = false;
        }

        private void linkLabel3_MouseHover(object sender, EventArgs e)
        {
            linkLabel3.LinkVisited = true;
        }

        private void linkLabel3_MouseLeave(object sender, EventArgs e)
        {
            linkLabel3.LinkVisited = false;
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            var procs = new System.Diagnostics.ProcessStartInfo(@"C:/FootTest/Guide.pdf");
            System.Diagnostics.Process proc = System.Diagnostics.Process.Start(procs);
        }

        private void linkLabel6_MouseHover(object sender, EventArgs e)
        {
            linkLabel6.LinkVisited = true;
        }

        private void linkLabel6_MouseLeave(object sender, EventArgs e)
        {
            linkLabel6.LinkVisited = false;
        }
    }
}
