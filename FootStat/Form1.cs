using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Reflection;

namespace FootStat
{
    public partial class Form1 : Form
    {
        private Calcules cal= new Calcules();

        listJoeur lstjr;
        ajoutement ajt;
        Fiches Fch;
        Brodi BRD ;
        Recherche Search;
        
        public Form1()
        {

            InitializeComponent();
            
                date_time();
           
        }
        public void date_time()
        {
            DateTime dat = DateTime.Now;
            String Culture = "ar-DZ";
            var cul = new CultureInfo(Culture);
            //DMT.Text = dat.ToString(cul);
        }


        private void initHome_Click(object sender, EventArgs e)
        {
            CNTS.Controls.Clear();
            initHome.Enabled = false;
            this.CNTS.BackgroundImage = global::FootStat.Properties.Resources.acceuls;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Fch = new Fiches();
            CNTS.Controls.Clear();
            Fch.Size = CNTS.Size;
            CNTS.Controls.Add(Fch);
            initHome.Enabled = true;
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            
            Bitmap img = new Bitmap(global::FootStat.Properties.Resources.grass_background_hd_11);
            ajt = new ajoutement();
            CNTS.Controls.Clear();
            ajt.Size = CNTS.Size;
            ajt.BackgroundImage = img;
            ajt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            CNTS.Controls.Add(ajt);

            initHome.Enabled = true;
        }

        public void Evaluations_Click(object sender, EventArgs e)
        {
            lstjr = new listJoeur(this);
            CNTS.Controls.Clear();
            lstjr.Size = CNTS.Size;
            CNTS.Controls.Add(lstjr);
            initHome.Enabled = true;
        }

        private void button121_Click(object sender, EventArgs e)
        {
            //
            BRD = new Brodi();
            CNTS.Controls.Clear();
            BRD.Size = CNTS.Size;
            CNTS.Controls.Add(BRD);
            initHome.Enabled = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Search = new Recherche(this);
            CNTS.Controls.Clear();
            Search.Size = CNTS.Size;
            CNTS.Controls.Add(Search);
            initHome.Enabled = true;
        }

        private void Evaluation_MouseLeave(object sender, EventArgs e)
        {
            ZOOM(false, Evaluation);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {

            ZOOM(false, button2);
        }

        private void Exits_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = false;
            
        }

        private void initHome_MouseLeave(object sender, EventArgs e)
        {
            ZOOM(false, initHome);
        }

        private void button121_MouseLeave(object sender, EventArgs e)
        {
            ZOOM(false, button121);
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            ZOOM(false, button10);
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            ZOOM(false, button6);
        }

        private void Exits_MouseLeave(object sender, EventArgs e)
        {
            ZOOM(false, Exits);
        }

        private void ajouter_MouseHover(object sender, EventArgs e)
        {
            ZOOM(true, ajouter);
        }
        private void ajouter_MouseLeave(object sender, EventArgs e)
        {
            ZOOM(false, ajouter);
        }
        private void ZOOM(Boolean up, Button btn)
        {
            if (up == true)
            {
                btn.Left -= 4;
                btn.Top -= 4;
                btn.Width += 8;
                btn.Height += 8;
            }
            else
            {
                btn.Left += 4;
                btn.Top += 4;
                btn.Width -= 8;
                btn.Height -= 8;
            }
        }

        private void initHome_MouseHover(object sender, EventArgs e)
        {
            ZOOM(true, initHome);
        }

        private void Evaluation_MouseHover(object sender, EventArgs e)
        {
            ZOOM(true, Evaluation);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            ZOOM(true, button2);
        }

        private void button121_MouseHover(object sender, EventArgs e)
        {
            ZOOM(true, button121);
        }

        private void button10_MouseHover(object sender, EventArgs e)
        {
            ZOOM(true, button10);
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            ZOOM(true, button6);
        }

        private void Exits_MouseHover(object sender, EventArgs e)
        {
            ZOOM(true, Exits);
        }
    }
}
