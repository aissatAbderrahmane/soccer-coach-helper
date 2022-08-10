using System.Drawing;
using System.Windows.Forms;

namespace FootStat
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lab = new System.Windows.Forms.Label();
            this.elementHost8 = new System.Windows.Forms.Integration.ElementHost();
            this.userControl11 = new ButtonME.UserControl1();
            this.elementHost7 = new System.Windows.Forms.Integration.ElementHost();
            this.userControl12 = new ButtonME.UserControl1();
            this.elementHost6 = new System.Windows.Forms.Integration.ElementHost();
            this.userControl13 = new ButtonME.UserControl1();
            this.elementHost3 = new System.Windows.Forms.Integration.ElementHost();
            this.userControl14 = new ButtonME.UserControl1();
            this.elementHost5 = new System.Windows.Forms.Integration.ElementHost();
            this.userControl15 = new ButtonME.UserControl1();
            this.elementHost4 = new System.Windows.Forms.Integration.ElementHost();
            this.userControl16 = new ButtonME.UserControl1();
            this.elementHost2 = new System.Windows.Forms.Integration.ElementHost();
            this.userControl17 = new ButtonME.UserControl1();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.userControl18 = new ButtonME.UserControl1();
            this.CNTS = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 658);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 0);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lab);
            this.panel2.Controls.Add(this.elementHost8);
            this.panel2.Controls.Add(this.elementHost7);
            this.panel2.Controls.Add(this.elementHost6);
            this.panel2.Controls.Add(this.elementHost3);
            this.panel2.Controls.Add(this.elementHost5);
            this.panel2.Controls.Add(this.elementHost4);
            this.panel2.Controls.Add(this.elementHost2);
            this.panel2.Controls.Add(this.elementHost1);
            this.panel2.Location = new System.Drawing.Point(3, 510);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1249, 148);
            this.panel2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1158, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "time";
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab.ForeColor = System.Drawing.Color.White;
            this.lab.Location = new System.Drawing.Point(67, 127);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(183, 19);
            this.lab.TabIndex = 0;
            this.lab.Text = "LABOPAPS : 0558158004";
            // 
            // elementHost8
            // 
            this.elementHost8.BackColor = System.Drawing.Color.Transparent;
            this.elementHost8.Location = new System.Drawing.Point(1097, 0);
            this.elementHost8.Name = "elementHost8";
            this.elementHost8.Size = new System.Drawing.Size(155, 143);
            this.elementHost8.TabIndex = 12;
            this.elementHost8.Text = "elementHost1";
            this.elementHost8.Child = this.userControl11;
            // 
            // elementHost7
            // 
            this.elementHost7.BackColor = System.Drawing.Color.Transparent;
            this.elementHost7.Location = new System.Drawing.Point(940, 0);
            this.elementHost7.Name = "elementHost7";
            this.elementHost7.Size = new System.Drawing.Size(155, 143);
            this.elementHost7.TabIndex = 12;
            this.elementHost7.Text = "elementHost1";
            this.elementHost7.Child = this.userControl12;
            // 
            // elementHost6
            // 
            this.elementHost6.BackColor = System.Drawing.Color.Transparent;
            this.elementHost6.Location = new System.Drawing.Point(785, 0);
            this.elementHost6.Name = "elementHost6";
            this.elementHost6.Size = new System.Drawing.Size(155, 143);
            this.elementHost6.TabIndex = 12;
            this.elementHost6.Text = "elementHost1";
            this.elementHost6.Child = this.userControl13;
            // 
            // elementHost3
            // 
            this.elementHost3.BackColor = System.Drawing.Color.Transparent;
            this.elementHost3.Location = new System.Drawing.Point(321, 0);
            this.elementHost3.Name = "elementHost3";
            this.elementHost3.Size = new System.Drawing.Size(155, 143);
            this.elementHost3.TabIndex = 12;
            this.elementHost3.Text = "elementHost1";
            this.elementHost3.Child = this.userControl14;
            // 
            // elementHost5
            // 
            this.elementHost5.BackColor = System.Drawing.Color.Transparent;
            this.elementHost5.Location = new System.Drawing.Point(630, 0);
            this.elementHost5.Name = "elementHost5";
            this.elementHost5.Size = new System.Drawing.Size(155, 143);
            this.elementHost5.TabIndex = 12;
            this.elementHost5.Text = "elementHost1";
            this.elementHost5.Child = this.userControl15;
            // 
            // elementHost4
            // 
            this.elementHost4.BackColor = System.Drawing.Color.Transparent;
            this.elementHost4.Location = new System.Drawing.Point(475, 0);
            this.elementHost4.Name = "elementHost4";
            this.elementHost4.Size = new System.Drawing.Size(155, 143);
            this.elementHost4.TabIndex = 12;
            this.elementHost4.Text = "elementHost1";
            this.elementHost4.Child = this.userControl16;
            // 
            // elementHost2
            // 
            this.elementHost2.BackColor = System.Drawing.Color.Transparent;
            this.elementHost2.Location = new System.Drawing.Point(166, 0);
            this.elementHost2.Name = "elementHost2";
            this.elementHost2.Size = new System.Drawing.Size(155, 143);
            this.elementHost2.TabIndex = 12;
            this.elementHost2.Text = "elementHost1";
            this.elementHost2.Child = this.userControl17;
            // 
            // elementHost1
            // 
            this.elementHost1.BackColor = System.Drawing.Color.Transparent;
            this.elementHost1.Location = new System.Drawing.Point(11, 0);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(155, 143);
            this.elementHost1.TabIndex = 12;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.userControl18;
            // 
            // CNTS
            // 
            this.CNTS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CNTS.AutoSize = true;
            this.CNTS.BackColor = System.Drawing.Color.Transparent;
            this.CNTS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CNTS.Location = new System.Drawing.Point(0, 0);
            this.CNTS.Name = "CNTS";
            this.CNTS.Size = new System.Drawing.Size(1264, 509);
            this.CNTS.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = global::FootStat.Properties.Resources.NEWAcceuim1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 658);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CNTS);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "FootTest";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Panel panel2;
        private System.Windows.Forms.Integration.ElementHost elementHost8;
        private ButtonME.UserControl1 userControl11;
        private System.Windows.Forms.Integration.ElementHost elementHost7;
        private ButtonME.UserControl1 userControl12;
        private System.Windows.Forms.Integration.ElementHost elementHost6;
        private ButtonME.UserControl1 userControl13;
        private System.Windows.Forms.Integration.ElementHost elementHost3;
        private ButtonME.UserControl1 userControl14;
        private System.Windows.Forms.Integration.ElementHost elementHost5;
        private ButtonME.UserControl1 userControl15;
        private System.Windows.Forms.Integration.ElementHost elementHost4;
        private ButtonME.UserControl1 userControl16;
        private System.Windows.Forms.Integration.ElementHost elementHost2;
        private ButtonME.UserControl1 userControl17;
        public System.Windows.Forms.Integration.ElementHost elementHost1;
        public ButtonME.UserControl1 userControl18;
        public Panel CNTS;
        private Label lab;
        private Timer timer1;
        private Label label1;
    }
}

