namespace FootStat
{
    partial class listJoeur
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ListJoueurs = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Equipe_v = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PIC_v = new System.Windows.Forms.PictureBox();
            this.id = new System.Windows.Forms.TextBox();
            this.num_v = new System.Windows.Forms.Label();
            this.testNum = new System.Windows.Forms.ComboBox();
            this.typeEval = new System.Windows.Forms.ComboBox();
            this.age_v = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.prenom_v = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ntest_v = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nom_v = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ListJoueurs)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Equipe_v)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_v)).BeginInit();
            this.SuspendLayout();
            // 
            // ListJoueurs
            // 
            this.ListJoueurs.AllowUserToAddRows = false;
            this.ListJoueurs.AllowUserToDeleteRows = false;
            this.ListJoueurs.AllowUserToResizeColumns = false;
            this.ListJoueurs.AllowUserToResizeRows = false;
            this.ListJoueurs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListJoueurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListJoueurs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ListJoueurs.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ListJoueurs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ListJoueurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListJoueurs.DefaultCellStyle = dataGridViewCellStyle1;
            this.ListJoueurs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ListJoueurs.GridColor = System.Drawing.Color.Gainsboro;
            this.ListJoueurs.Location = new System.Drawing.Point(0, 274);
            this.ListJoueurs.Margin = new System.Windows.Forms.Padding(4);
            this.ListJoueurs.MultiSelect = false;
            this.ListJoueurs.Name = "ListJoueurs";
            this.ListJoueurs.ReadOnly = true;
            this.ListJoueurs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ListJoueurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListJoueurs.ShowCellErrors = false;
            this.ListJoueurs.ShowCellToolTips = false;
            this.ListJoueurs.ShowEditingIcon = false;
            this.ListJoueurs.ShowRowErrors = false;
            this.ListJoueurs.Size = new System.Drawing.Size(1245, 600);
            this.ListJoueurs.TabIndex = 0;
            this.ListJoueurs.Visible = false;
            this.ListJoueurs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListJoueurs_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::FootStat.Properties.Resources.football_goal;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.Equipe_v);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.PIC_v);
            this.panel1.Controls.Add(this.id);
            this.panel1.Controls.Add(this.num_v);
            this.panel1.Controls.Add(this.testNum);
            this.panel1.Controls.Add(this.typeEval);
            this.panel1.Controls.Add(this.age_v);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.prenom_v);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ntest_v);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.nom_v);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1245, 277);
            this.panel1.TabIndex = 8;
            // 
            // Equipe_v
            // 
            this.Equipe_v.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Equipe_v.BackColor = System.Drawing.Color.Transparent;
            this.Equipe_v.Enabled = false;
            this.Equipe_v.Location = new System.Drawing.Point(1018, 60);
            this.Equipe_v.Margin = new System.Windows.Forms.Padding(4);
            this.Equipe_v.Name = "Equipe_v";
            this.Equipe_v.Size = new System.Drawing.Size(177, 173);
            this.Equipe_v.TabIndex = 3;
            this.Equipe_v.TabStop = false;
            this.Equipe_v.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(28, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(399, 42);
            this.label5.TabIndex = 7;
            this.label5.Text = "Evaluation D\'un Joueur";
            this.label5.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(824, 55);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "Evaluer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PIC_v
            // 
            this.PIC_v.BackColor = System.Drawing.Color.Transparent;
            this.PIC_v.Enabled = false;
            this.PIC_v.Location = new System.Drawing.Point(38, 65);
            this.PIC_v.Margin = new System.Windows.Forms.Padding(4);
            this.PIC_v.Name = "PIC_v";
            this.PIC_v.Size = new System.Drawing.Size(177, 173);
            this.PIC_v.TabIndex = 3;
            this.PIC_v.TabStop = false;
            this.PIC_v.Visible = false;
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.id.Location = new System.Drawing.Point(339, 60);
            this.id.Margin = new System.Windows.Forms.Padding(4);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(148, 29);
            this.id.TabIndex = 6;
            this.id.Visible = false;
            this.id.Click += new System.EventHandler(this.id_Click);
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // num_v
            // 
            this.num_v.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.num_v.AutoSize = true;
            this.num_v.BackColor = System.Drawing.Color.Transparent;
            this.num_v.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_v.ForeColor = System.Drawing.Color.Black;
            this.num_v.Location = new System.Drawing.Point(407, 182);
            this.num_v.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.num_v.Name = "num_v";
            this.num_v.Size = new System.Drawing.Size(0, 22);
            this.num_v.TabIndex = 5;
            // 
            // testNum
            // 
            this.testNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.testNum.Enabled = false;
            this.testNum.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testNum.FormattingEnabled = true;
            this.testNum.Items.AddRange(new object[] {
            "Numero Du Test"});
            this.testNum.Location = new System.Drawing.Point(542, 97);
            this.testNum.Margin = new System.Windows.Forms.Padding(4);
            this.testNum.Name = "testNum";
            this.testNum.Size = new System.Drawing.Size(224, 30);
            this.testNum.TabIndex = 2;
            this.testNum.Text = "Numéro Du Test";
            this.testNum.Visible = false;
            this.testNum.TextUpdate += new System.EventHandler(this.testNum_TextUpdate);
            // 
            // typeEval
            // 
            this.typeEval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.typeEval.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeEval.FormattingEnabled = true;
            this.typeEval.Items.AddRange(new object[] {
            "Morphologique et Physiologique",
            "Physique",
            "Technique",
            "Performance Totale"});
            this.typeEval.Location = new System.Drawing.Point(542, 60);
            this.typeEval.Margin = new System.Windows.Forms.Padding(4);
            this.typeEval.Name = "typeEval";
            this.typeEval.Size = new System.Drawing.Size(224, 30);
            this.typeEval.TabIndex = 2;
            this.typeEval.Text = "Type d\'évaluation";
            this.typeEval.Visible = false;
            this.typeEval.TextUpdate += new System.EventHandler(this.typeEval_TextUpdate);
            // 
            // age_v
            // 
            this.age_v.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.age_v.AutoSize = true;
            this.age_v.BackColor = System.Drawing.Color.Transparent;
            this.age_v.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age_v.ForeColor = System.Drawing.Color.Black;
            this.age_v.Location = new System.Drawing.Point(407, 151);
            this.age_v.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.age_v.Name = "age_v";
            this.age_v.Size = new System.Drawing.Size(0, 22);
            this.age_v.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(232, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nom:";
            this.label1.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(231, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Num Tel:";
            this.label4.Visible = false;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(230, 65);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 22);
            this.label13.TabIndex = 4;
            this.label13.Text = "ID:";
            this.label13.Visible = false;
            // 
            // prenom_v
            // 
            this.prenom_v.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prenom_v.AutoSize = true;
            this.prenom_v.BackColor = System.Drawing.Color.Transparent;
            this.prenom_v.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenom_v.ForeColor = System.Drawing.Color.Black;
            this.prenom_v.Location = new System.Drawing.Point(405, 123);
            this.prenom_v.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prenom_v.Name = "prenom_v";
            this.prenom_v.Size = new System.Drawing.Size(0, 22);
            this.prenom_v.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(231, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prénom:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(234, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Âge:";
            this.label3.Visible = false;
            // 
            // ntest_v
            // 
            this.ntest_v.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ntest_v.AutoSize = true;
            this.ntest_v.BackColor = System.Drawing.Color.Transparent;
            this.ntest_v.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntest_v.ForeColor = System.Drawing.Color.White;
            this.ntest_v.Location = new System.Drawing.Point(718, 233);
            this.ntest_v.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ntest_v.Name = "ntest_v";
            this.ntest_v.Size = new System.Drawing.Size(0, 22);
            this.ntest_v.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(538, 233);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(164, 22);
            this.label11.TabIndex = 4;
            this.label11.Text = "Nombre Des Tests:";
            this.label11.Visible = false;
            // 
            // nom_v
            // 
            this.nom_v.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nom_v.AutoSize = true;
            this.nom_v.BackColor = System.Drawing.Color.Transparent;
            this.nom_v.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_v.ForeColor = System.Drawing.Color.Black;
            this.nom_v.Location = new System.Drawing.Point(405, 94);
            this.nom_v.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nom_v.Name = "nom_v";
            this.nom_v.Size = new System.Drawing.Size(0, 22);
            this.nom_v.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listJoeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ListJoueurs);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "listJoeur";
            this.Size = new System.Drawing.Size(1245, 878);
            ((System.ComponentModel.ISupportInitialize)(this.ListJoueurs)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Equipe_v)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_v)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView ListJoueurs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox typeEval;
        private System.Windows.Forms.PictureBox PIC_v;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nom_v;
        private System.Windows.Forms.Label prenom_v;
        private System.Windows.Forms.Label age_v;
        private System.Windows.Forms.Label num_v;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label ntest_v;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox Equipe_v;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox testNum;
        private System.Windows.Forms.Timer timer1;
    }
}
