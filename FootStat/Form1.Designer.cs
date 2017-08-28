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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Generale = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CNTS = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.ajouter = new System.Windows.Forms.Button();
            this.button121 = new System.Windows.Forms.Button();
            this.Evaluation = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.initHome = new System.Windows.Forms.Button();
            this.Exits = new System.Windows.Forms.Button();
            this.Generale.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Generale
            // 
            this.Generale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Generale.Controls.Add(this.panel2);
            this.Generale.Controls.Add(this.CNTS);
            this.Generale.Location = new System.Drawing.Point(0, 0);
            this.Generale.Name = "Generale";
            this.Generale.Size = new System.Drawing.Size(1461, 728);
            this.Generale.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackgroundImage = global::FootStat.Properties.Resources.Sans_titre_3;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.ajouter);
            this.panel2.Controls.Add(this.initHome);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.Evaluation);
            this.panel2.Controls.Add(this.button121);
            this.panel2.Controls.Add(this.Exits);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Location = new System.Drawing.Point(0, 558);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1224, 100);
            this.panel2.TabIndex = 9;
            // 
            // CNTS
            // 
            this.CNTS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CNTS.AutoSize = true;
            this.CNTS.BackgroundImage = global::FootStat.Properties.Resources.acceuls;
            this.CNTS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CNTS.Location = new System.Drawing.Point(0, 0);
            this.CNTS.Name = "CNTS";
            this.CNTS.Size = new System.Drawing.Size(1224, 567);
            this.CNTS.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 658);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1220, 0);
            this.panel1.TabIndex = 1;
            // 
            // button10
            // 
            this.button10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button10.AutoSize = true;
            this.button10.BackColor = System.Drawing.Color.Transparent;
            this.button10.BackgroundImage = global::FootStat.Properties.Resources.SCH;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(826, 4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(93, 97);
            this.button10.TabIndex = 7;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            this.button10.MouseLeave += new System.EventHandler(this.button10_MouseLeave);
            this.button10.MouseHover += new System.EventHandler(this.button10_MouseHover);
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.AutoSize = true;
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = global::FootStat.Properties.Resources.GD;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(976, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(93, 97);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.MouseLeave += new System.EventHandler(this.button6_MouseLeave);
            this.button6.MouseHover += new System.EventHandler(this.button6_MouseHover);
            // 
            // ajouter
            // 
            this.ajouter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ajouter.AutoSize = true;
            this.ajouter.BackColor = System.Drawing.Color.Transparent;
            this.ajouter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ajouter.BackgroundImage")));
            this.ajouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ajouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ajouter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ajouter.FlatAppearance.BorderSize = 0;
            this.ajouter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ajouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ajouter.ForeColor = System.Drawing.Color.Transparent;
            this.ajouter.Location = new System.Drawing.Point(206, 3);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(93, 97);
            this.ajouter.TabIndex = 8;
            this.ajouter.UseVisualStyleBackColor = false;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            this.ajouter.MouseLeave += new System.EventHandler(this.ajouter_MouseLeave);
            this.ajouter.MouseHover += new System.EventHandler(this.ajouter_MouseHover);
            // 
            // button121
            // 
            this.button121.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button121.AutoSize = true;
            this.button121.BackColor = System.Drawing.Color.Transparent;
            this.button121.BackgroundImage = global::FootStat.Properties.Resources.BRD;
            this.button121.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button121.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button121.FlatAppearance.BorderSize = 0;
            this.button121.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button121.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button121.Location = new System.Drawing.Point(680, 6);
            this.button121.Name = "button121";
            this.button121.Size = new System.Drawing.Size(93, 97);
            this.button121.TabIndex = 6;
            this.button121.UseVisualStyleBackColor = false;
            this.button121.Click += new System.EventHandler(this.button121_Click);
            this.button121.MouseLeave += new System.EventHandler(this.button121_MouseLeave);
            this.button121.MouseHover += new System.EventHandler(this.button121_MouseHover);
            // 
            // Evaluation
            // 
            this.Evaluation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Evaluation.AutoSize = true;
            this.Evaluation.BackColor = System.Drawing.Color.Transparent;
            this.Evaluation.BackgroundImage = global::FootStat.Properties.Resources.EVS;
            this.Evaluation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Evaluation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Evaluation.FlatAppearance.BorderSize = 0;
            this.Evaluation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Evaluation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Evaluation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Evaluation.Location = new System.Drawing.Point(365, 3);
            this.Evaluation.Name = "Evaluation";
            this.Evaluation.Size = new System.Drawing.Size(93, 97);
            this.Evaluation.TabIndex = 9;
            this.Evaluation.UseVisualStyleBackColor = false;
            this.Evaluation.Click += new System.EventHandler(this.Evaluations_Click);
            this.Evaluation.MouseLeave += new System.EventHandler(this.Evaluation_MouseLeave);
            this.Evaluation.MouseHover += new System.EventHandler(this.Evaluation_MouseHover);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::FootStat.Properties.Resources.SMA_2;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(522, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 97);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // initHome
            // 
            this.initHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.initHome.AutoSize = true;
            this.initHome.BackColor = System.Drawing.Color.Transparent;
            this.initHome.BackgroundImage = global::FootStat.Properties.Resources.AC2;
            this.initHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.initHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.initHome.Enabled = false;
            this.initHome.FlatAppearance.BorderSize = 0;
            this.initHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.initHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.initHome.Location = new System.Drawing.Point(69, 6);
            this.initHome.Name = "initHome";
            this.initHome.Size = new System.Drawing.Size(93, 97);
            this.initHome.TabIndex = 11;
            this.initHome.UseVisualStyleBackColor = false;
            this.initHome.Click += new System.EventHandler(this.initHome_Click);
            this.initHome.MouseLeave += new System.EventHandler(this.initHome_MouseLeave);
            this.initHome.MouseHover += new System.EventHandler(this.initHome_MouseHover);
            // 
            // Exits
            // 
            this.Exits.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Exits.BackColor = System.Drawing.Color.Transparent;
            this.Exits.BackgroundImage = global::FootStat.Properties.Resources.Action_exit_icon;
            this.Exits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exits.FlatAppearance.BorderSize = 0;
            this.Exits.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Exits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exits.Location = new System.Drawing.Point(1115, 6);
            this.Exits.Name = "Exits";
            this.Exits.Size = new System.Drawing.Size(93, 97);
            this.Exits.TabIndex = 12;
            this.Exits.UseVisualStyleBackColor = false;
            this.Exits.Click += new System.EventHandler(this.Exits_Click);
            this.Exits.MouseLeave += new System.EventHandler(this.Exits_MouseLeave);
            this.Exits.MouseHover += new System.EventHandler(this.Exits_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1220, 658);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Generale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Foot Stat";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Generale.ResumeLayout(false);
            this.Generale.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Generale;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel CNTS;
        private Panel panel2;
        private Button ajouter;
        public Button initHome;
        private Button button2;
        private Button Evaluation;
        private Button button121;
        private Button Exits;
        private Button button6;
        private Button button10;
    }
}

