namespace FootStat
{
    partial class Recherche
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ListJoueurs = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lodPros = new System.Windows.Forms.Label();
            this.lodBar = new System.Windows.Forms.ProgressBar();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.test_list = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.type_list = new System.Windows.Forms.ComboBox();
            this.result_list = new System.Windows.Forms.ComboBox();
            this.prenom_v = new System.Windows.Forms.TextBox();
            this.equipe_list = new System.Windows.Forms.ComboBox();
            this.id_v = new System.Windows.Forms.TextBox();
            this.nom_v = new System.Windows.Forms.TextBox();
            this.date_v = new System.Windows.Forms.TextBox();
            this.lod = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.ListJoueurs)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.ListJoueurs.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.ListJoueurs.Location = new System.Drawing.Point(-4, 243);
            this.ListJoueurs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ListJoueurs.MultiSelect = false;
            this.ListJoueurs.Name = "ListJoueurs";
            this.ListJoueurs.ReadOnly = true;
            this.ListJoueurs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ListJoueurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListJoueurs.ShowCellErrors = false;
            this.ListJoueurs.ShowCellToolTips = false;
            this.ListJoueurs.ShowEditingIcon = false;
            this.ListJoueurs.ShowRowErrors = false;
            this.ListJoueurs.Size = new System.Drawing.Size(1249, 616);
            this.ListJoueurs.TabIndex = 11;
            this.ListJoueurs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListJoueurs_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::FootStat.Properties.Resources.WZjZK0Q;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lodPros);
            this.panel1.Controls.Add(this.lodBar);
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.test_list);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.type_list);
            this.panel1.Controls.Add(this.result_list);
            this.panel1.Controls.Add(this.prenom_v);
            this.panel1.Controls.Add(this.equipe_list);
            this.panel1.Controls.Add(this.id_v);
            this.panel1.Controls.Add(this.nom_v);
            this.panel1.Controls.Add(this.date_v);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1245, 247);
            this.panel1.TabIndex = 12;
            // 
            // lodPros
            // 
            this.lodPros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lodPros.AutoSize = true;
            this.lodPros.BackColor = System.Drawing.Color.Transparent;
            this.lodPros.Location = new System.Drawing.Point(1139, 209);
            this.lodPros.Name = "lodPros";
            this.lodPros.Size = new System.Drawing.Size(22, 19);
            this.lodPros.TabIndex = 14;
            this.lodPros.Text = "%";
            this.lodPros.Visible = false;
            // 
            // lodBar
            // 
            this.lodBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lodBar.Location = new System.Drawing.Point(839, 209);
            this.lodBar.Name = "lodBar";
            this.lodBar.Size = new System.Drawing.Size(294, 23);
            this.lodBar.TabIndex = 13;
            this.lodBar.Visible = false;
            // 
            // checkBox4
            // 
            this.checkBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox4.AutoSize = true;
            this.checkBox4.BackColor = System.Drawing.Color.Transparent;
            this.checkBox4.Location = new System.Drawing.Point(839, 181);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 12;
            this.checkBox4.UseVisualStyleBackColor = false;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox3.AutoSize = true;
            this.checkBox3.BackColor = System.Drawing.Color.Transparent;
            this.checkBox3.Location = new System.Drawing.Point(839, 143);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 12;
            this.checkBox3.UseVisualStyleBackColor = false;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.Location = new System.Drawing.Point(839, 105);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(839, 65);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(91, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Prénom:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(91, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(78, 12);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(319, 42);
            this.label9.TabIndex = 10;
            this.label9.Text = "Recherche Avancée";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(91, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom:";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::FootStat.Properties.Resources.xlsx_win_icon;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1089, 162);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 41);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1089, 111);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Récupérer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // test_list
            // 
            this.test_list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.test_list.Enabled = false;
            this.test_list.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test_list.FormattingEnabled = true;
            this.test_list.IntegralHeight = false;
            this.test_list.Items.AddRange(new object[] {
            "Numero Du test",
            "1",
            "2",
            "3",
            "4"});
            this.test_list.Location = new System.Drawing.Point(861, 172);
            this.test_list.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test_list.Name = "test_list";
            this.test_list.Size = new System.Drawing.Size(209, 29);
            this.test_list.TabIndex = 4;
            this.test_list.Text = "Numéro Du test";
            this.test_list.SelectedIndexChanged += new System.EventHandler(this.test_list_SelectedIndexChanged);
            this.test_list.TextUpdate += new System.EventHandler(this.test_list_TextUpdate);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1089, 60);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 41);
            this.button3.TabIndex = 3;
            this.button3.Text = "Archivé";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(91, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Date:";
            // 
            // type_list
            // 
            this.type_list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.type_list.Enabled = false;
            this.type_list.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_list.FormattingEnabled = true;
            this.type_list.Items.AddRange(new object[] {
            "type de joueur",
            "Actif",
            "Archiver"});
            this.type_list.Location = new System.Drawing.Point(861, 135);
            this.type_list.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.type_list.Name = "type_list";
            this.type_list.Size = new System.Drawing.Size(209, 29);
            this.type_list.TabIndex = 4;
            this.type_list.Text = "type de joueur";
            this.type_list.SelectedIndexChanged += new System.EventHandler(this.type_list_SelectedIndexChanged);
            this.type_list.TextUpdate += new System.EventHandler(this.type_list_TextUpdate);
            // 
            // result_list
            // 
            this.result_list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.result_list.Enabled = false;
            this.result_list.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_list.FormattingEnabled = true;
            this.result_list.Items.AddRange(new object[] {
            "Tout",
            "Trés Bien",
            "Bien",
            "Moyen",
            "Faible",
            "Trés Faible"});
            this.result_list.Location = new System.Drawing.Point(861, 96);
            this.result_list.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.result_list.Name = "result_list";
            this.result_list.Size = new System.Drawing.Size(209, 29);
            this.result_list.TabIndex = 4;
            this.result_list.Text = "Résultat";
            this.result_list.SelectedIndexChanged += new System.EventHandler(this.result_list_SelectedIndexChanged);
            this.result_list.TextUpdate += new System.EventHandler(this.result_list_TextUpdate);
            // 
            // prenom_v
            // 
            this.prenom_v.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenom_v.Location = new System.Drawing.Point(178, 143);
            this.prenom_v.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prenom_v.Name = "prenom_v";
            this.prenom_v.Size = new System.Drawing.Size(223, 29);
            this.prenom_v.TabIndex = 2;
            this.prenom_v.TextChanged += new System.EventHandler(this.prenom_v_TextChanged);
            // 
            // equipe_list
            // 
            this.equipe_list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.equipe_list.Enabled = false;
            this.equipe_list.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipe_list.FormattingEnabled = true;
            this.equipe_list.Items.AddRange(new object[] {
            "GCM",
            "IRBM",
            "MB",
            "MCS",
            "NOUDJOUM",
            "RCR",
            "OMA",
            "SA",
            "USMBA",
            "WAT"});
            this.equipe_list.Location = new System.Drawing.Point(861, 58);
            this.equipe_list.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.equipe_list.Name = "equipe_list";
            this.equipe_list.Size = new System.Drawing.Size(209, 29);
            this.equipe_list.TabIndex = 4;
            this.equipe_list.Text = "Equipe";
            this.equipe_list.SelectedIndexChanged += new System.EventHandler(this.equipe_list_SelectedIndexChanged);
            this.equipe_list.TextUpdate += new System.EventHandler(this.equipe_list_TextUpdate);
            // 
            // id_v
            // 
            this.id_v.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_v.Location = new System.Drawing.Point(178, 65);
            this.id_v.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.id_v.Name = "id_v";
            this.id_v.Size = new System.Drawing.Size(73, 29);
            this.id_v.TabIndex = 2;
            this.id_v.TextChanged += new System.EventHandler(this.id_v_TextChanged);
            // 
            // nom_v
            // 
            this.nom_v.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_v.Location = new System.Drawing.Point(178, 105);
            this.nom_v.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nom_v.Name = "nom_v";
            this.nom_v.Size = new System.Drawing.Size(223, 29);
            this.nom_v.TabIndex = 2;
            this.nom_v.TextChanged += new System.EventHandler(this.nom_v_TextChanged);
            // 
            // date_v
            // 
            this.date_v.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_v.Location = new System.Drawing.Point(178, 181);
            this.date_v.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.date_v.Name = "date_v";
            this.date_v.Size = new System.Drawing.Size(223, 29);
            this.date_v.TabIndex = 2;
            this.date_v.TextChanged += new System.EventHandler(this.date_v_TextChanged);
            // 
            // lod
            // 
            this.lod.WorkerReportsProgress = true;
            this.lod.WorkerSupportsCancellation = true;
            this.lod.DoWork += new System.ComponentModel.DoWorkEventHandler(this.lod_DoWork);
            this.lod.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.lod_ProgressChanged);
            this.lod.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.lod_RunWorkerCompleted);
            // 
            // Recherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ListJoueurs);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Recherche";
            this.Size = new System.Drawing.Size(1245, 879);
            this.Load += new System.EventHandler(this.Recherche_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListJoueurs)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id_v;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nom_v;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox prenom_v;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox date_v;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox equipe_list;
        private System.Windows.Forms.ComboBox result_list;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox type_list;
        private System.Windows.Forms.ComboBox test_list;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.DataGridView ListJoueurs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lodPros;
        private System.Windows.Forms.ProgressBar lodBar;
        private System.ComponentModel.BackgroundWorker lod;
    }
}
