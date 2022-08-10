namespace FootStat
{
    partial class modifier
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.IMC_V = new System.Windows.Forms.TextBox();
            this.POID_V = new System.Windows.Forms.TextBox();
            this.TALL_V = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.AddNewTest = new System.Windows.Forms.Button();
            this.EquipeIMG = new System.Windows.Forms.PictureBox();
            this.JoueurIMG = new System.Windows.Forms.PictureBox();
            this.Equipes = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.ADR_V = new System.Windows.Forms.TextBox();
            this.AGE_V = new System.Windows.Forms.TextBox();
            this.PRN_V = new System.Windows.Forms.TextBox();
            this.DATE_V = new System.Windows.Forms.TextBox();
            this.TEL_V = new System.Windows.Forms.TextBox();
            this.NOM_V = new System.Windows.Forms.TextBox();
            this.ID_V = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EquipeIMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JoueurIMG)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(36, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(339, 42);
            this.label5.TabIndex = 28;
            this.label5.Text = "Modifier Le Joueur:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(14, 326);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(803, 247);
            this.tabControl1.TabIndex = 49;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.IMC_V);
            this.tabPage4.Controls.Add(this.POID_V);
            this.tabPage4.Controls.Add(this.TALL_V);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.label19);
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(795, 215);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Morphologie";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // IMC_V
            // 
            this.IMC_V.Enabled = false;
            this.IMC_V.Location = new System.Drawing.Point(141, 135);
            this.IMC_V.Multiline = true;
            this.IMC_V.Name = "IMC_V";
            this.IMC_V.Size = new System.Drawing.Size(206, 33);
            this.IMC_V.TabIndex = 7;
            // 
            // POID_V
            // 
            this.POID_V.Location = new System.Drawing.Point(141, 83);
            this.POID_V.Multiline = true;
            this.POID_V.Name = "POID_V";
            this.POID_V.Size = new System.Drawing.Size(206, 33);
            this.POID_V.TabIndex = 8;
            this.POID_V.TextChanged += new System.EventHandler(this.POID_V_TextChanged);
            // 
            // TALL_V
            // 
            this.TALL_V.Location = new System.Drawing.Point(141, 30);
            this.TALL_V.Multiline = true;
            this.TALL_V.Name = "TALL_V";
            this.TALL_V.Size = new System.Drawing.Size(206, 33);
            this.TALL_V.TabIndex = 3;
            this.TALL_V.TextChanged += new System.EventHandler(this.TALL_V_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(53, 37);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 19);
            this.label18.TabIndex = 4;
            this.label18.Text = "Taille (Cm)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(69, 141);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 19);
            this.label19.TabIndex = 5;
            this.label19.Text = "IMC";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(45, 86);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(90, 19);
            this.label20.TabIndex = 6;
            this.label20.Text = "Le Poid (Kg)";
            // 
            // AddNewTest
            // 
            this.AddNewTest.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewTest.Location = new System.Drawing.Point(719, 579);
            this.AddNewTest.Name = "AddNewTest";
            this.AddNewTest.Size = new System.Drawing.Size(98, 33);
            this.AddNewTest.TabIndex = 48;
            this.AddNewTest.Text = "Suivant";
            this.AddNewTest.UseVisualStyleBackColor = true;
            this.AddNewTest.Click += new System.EventHandler(this.AddNewTest_Click);
            // 
            // EquipeIMG
            // 
            this.EquipeIMG.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EquipeIMG.Location = new System.Drawing.Point(613, 113);
            this.EquipeIMG.Name = "EquipeIMG";
            this.EquipeIMG.Size = new System.Drawing.Size(206, 158);
            this.EquipeIMG.TabIndex = 46;
            this.EquipeIMG.TabStop = false;
            // 
            // JoueurIMG
            // 
            this.JoueurIMG.BackColor = System.Drawing.Color.WhiteSmoke;
            this.JoueurIMG.Location = new System.Drawing.Point(23, 84);
            this.JoueurIMG.Name = "JoueurIMG";
            this.JoueurIMG.Size = new System.Drawing.Size(165, 153);
            this.JoueurIMG.TabIndex = 45;
            this.JoueurIMG.TabStop = false;
            // 
            // Equipes
            // 
            this.Equipes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equipes.FormattingEnabled = true;
            this.Equipes.Items.AddRange(new object[] {
            "MSA",
            "USMA"});
            this.Equipes.Location = new System.Drawing.Point(613, 84);
            this.Equipes.Name = "Equipes";
            this.Equipes.Size = new System.Drawing.Size(206, 27);
            this.Equipes.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(682, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 19);
            this.label8.TabIndex = 42;
            this.label8.Text = "Equipe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(216, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 41;
            this.label4.Text = "Adresse";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(576, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 19);
            this.label7.TabIndex = 40;
            this.label7.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(219, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 43;
            this.label3.Text = "Prenom";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(163, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 19);
            this.label6.TabIndex = 39;
            this.label6.Text = "Date Naissence";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 38;
            this.label1.Text = "Numero De Tel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nom";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(242, 92);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(25, 19);
            this.label21.TabIndex = 36;
            this.label21.Text = "ID";
            // 
            // ADR_V
            // 
            this.ADR_V.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADR_V.Location = new System.Drawing.Point(278, 204);
            this.ADR_V.Multiline = true;
            this.ADR_V.Name = "ADR_V";
            this.ADR_V.Size = new System.Drawing.Size(206, 33);
            this.ADR_V.TabIndex = 34;
            // 
            // AGE_V
            // 
            this.AGE_V.Enabled = false;
            this.AGE_V.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AGE_V.Location = new System.Drawing.Point(613, 283);
            this.AGE_V.Multiline = true;
            this.AGE_V.Name = "AGE_V";
            this.AGE_V.Size = new System.Drawing.Size(206, 33);
            this.AGE_V.TabIndex = 33;
            // 
            // PRN_V
            // 
            this.PRN_V.Enabled = false;
            this.PRN_V.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRN_V.Location = new System.Drawing.Point(278, 164);
            this.PRN_V.Multiline = true;
            this.PRN_V.Name = "PRN_V";
            this.PRN_V.Size = new System.Drawing.Size(206, 33);
            this.PRN_V.TabIndex = 32;
            // 
            // DATE_V
            // 
            this.DATE_V.Enabled = false;
            this.DATE_V.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DATE_V.Location = new System.Drawing.Point(278, 283);
            this.DATE_V.Multiline = true;
            this.DATE_V.Name = "DATE_V";
            this.DATE_V.Size = new System.Drawing.Size(206, 33);
            this.DATE_V.TabIndex = 31;
            this.DATE_V.TextChanged += new System.EventHandler(this.DATE_V_TextChanged);
            // 
            // TEL_V
            // 
            this.TEL_V.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEL_V.Location = new System.Drawing.Point(278, 243);
            this.TEL_V.Multiline = true;
            this.TEL_V.Name = "TEL_V";
            this.TEL_V.Size = new System.Drawing.Size(206, 33);
            this.TEL_V.TabIndex = 30;
            // 
            // NOM_V
            // 
            this.NOM_V.Enabled = false;
            this.NOM_V.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOM_V.Location = new System.Drawing.Point(278, 124);
            this.NOM_V.Multiline = true;
            this.NOM_V.Name = "NOM_V";
            this.NOM_V.Size = new System.Drawing.Size(206, 33);
            this.NOM_V.TabIndex = 35;
            // 
            // ID_V
            // 
            this.ID_V.Enabled = false;
            this.ID_V.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_V.Location = new System.Drawing.Point(278, 84);
            this.ID_V.Multiline = true;
            this.ID_V.Name = "ID_V";
            this.ID_V.Size = new System.Drawing.Size(206, 33);
            this.ID_V.TabIndex = 29;
            // 
            // modifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.AddNewTest);
            this.Controls.Add(this.EquipeIMG);
            this.Controls.Add(this.JoueurIMG);
            this.Controls.Add(this.Equipes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.ADR_V);
            this.Controls.Add(this.AGE_V);
            this.Controls.Add(this.PRN_V);
            this.Controls.Add(this.DATE_V);
            this.Controls.Add(this.TEL_V);
            this.Controls.Add(this.NOM_V);
            this.Controls.Add(this.ID_V);
            this.Controls.Add(this.label5);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "modifier";
            this.Size = new System.Drawing.Size(866, 647);
            this.Load += new System.EventHandler(this.modifier_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EquipeIMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JoueurIMG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox IMC_V;
        private System.Windows.Forms.TextBox POID_V;
        private System.Windows.Forms.TextBox TALL_V;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button AddNewTest;
        private System.Windows.Forms.PictureBox EquipeIMG;
        private System.Windows.Forms.PictureBox JoueurIMG;
        private System.Windows.Forms.ComboBox Equipes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox ADR_V;
        private System.Windows.Forms.TextBox AGE_V;
        private System.Windows.Forms.TextBox PRN_V;
        private System.Windows.Forms.TextBox DATE_V;
        private System.Windows.Forms.TextBox TEL_V;
        private System.Windows.Forms.TextBox NOM_V;
        private System.Windows.Forms.TextBox ID_V;
    }
}
