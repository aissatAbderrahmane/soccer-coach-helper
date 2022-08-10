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
using System.Windows.Forms.Integration;

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
        Image renderBmp;
        guide gdg;
        public override Image BackgroundImage
        {

            set
            {
                Image baseImage = value;
                renderBmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
                Graphics g = Graphics.FromImage(renderBmp);
                g.DrawImage(baseImage, 0, 0, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                g.Dispose();
            }
            get
            {
                return renderBmp;
            }
        }
        public Form1()
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            InitializeComponent();
            date_time();
            userControl18.addme("C:/FootTest/Buttons/Accueil.png");
            userControl18.b.Click += initHome_Click;
            userControl18.LoadButton();
            userControl17.addme("C:/FootTest/Buttons/Ajouter.png");
            userControl17.b.Click += ajouter_Click;
            userControl17.LoadButton();
            userControl16.addme("C:/FootTest/Buttons/Evaluation.png");
            userControl16.b.Click += Evaluations_Click;
            userControl16.LoadButton();
            userControl15.addme("C:/FootTest/Buttons/Fiches.png");
            userControl15.b.Click += button2_Click;
            userControl15.LoadButton();
            userControl14.addme("C:/FootTest/Buttons/Recherche.png");
            userControl14.b.Click += button10_Click;
            userControl14.LoadButton();
            userControl13.addme("C:/FootTest/Buttons/Brodi.png");
            userControl13.b.Click += button121_Click;
            userControl13.LoadButton();
            userControl12.addme("C:/FootTest/Buttons/Guide.png");
            userControl12.b.Click += Guide_Click;
            userControl12.LoadButton();
            userControl11.addme("C:/FootTest/Buttons/Fermer.png");
            userControl11.b.Click += Exits_Click;
            userControl11.LoadButton();
            label1.Text = DateTime.Now.ToString("hh:mm:ss tt");
            timer1.Start();


        }
        public void date_time()
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            DateTime dat = DateTime.Now;
            String Culture = "ar-DZ";
            var cul = new CultureInfo(Culture);
            //DMT.Text = dat.ToString(cul);
        }


        private void initHome_Click(object sender, EventArgs e)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            CNTS.Controls.Clear();
            CNTS.BackColor = Color.Transparent;
            elementHost1.Enabled = false;
            
        }
        private void Guide_Click(object sender, EventArgs e)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            gdg = new guide();
            CNTS.Controls.Clear();
            gdg.Size = CNTS.Size;
            CNTS.Controls.Add(gdg);
            CNTS.BackColor = Color.Transparent;
            elementHost1.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            Fch = new Fiches();
            CNTS.Controls.Clear();
            Fch.Size = CNTS.Size;
            CNTS.BackColor=Color.White;
            CNTS.Controls.Add(Fch);
            elementHost1.Enabled = true;
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            
            Bitmap img = new Bitmap(global::FootStat.Properties.Resources.grass_background_hd_11);
            ajt = new ajoutement();
            CNTS.Controls.Clear();
            ajt.Size = CNTS.Size;

            CNTS.Controls.Add(ajt);
            ajt.BackgroundImage = img;
            ajt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            elementHost1.Enabled = true;
        }

        public void Evaluations_Click(object sender, EventArgs e)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            lstjr = new listJoeur(this);
            CNTS.Controls.Clear();
            lstjr.Size = CNTS.Size;
            CNTS.BackColor = Color.White;
            CNTS.Controls.Add(lstjr);
            elementHost1.Enabled = true;
        }

        private void button121_Click(object sender, EventArgs e)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            //
            BRD = new Brodi();
            CNTS.Controls.Clear();
            BRD.Size = CNTS.Size;
            CNTS.BackColor = Color.White;
            CNTS.Controls.Add(BRD);
            elementHost1.Enabled = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            Search = new Recherche(this);
            CNTS.Controls.Clear();
            CNTS.BackColor = Color.White;
            Search.Size = CNTS.Size;
            CNTS.Controls.Add(Search);
            elementHost1.Enabled = true;
        }

       
        private void Exits_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}
