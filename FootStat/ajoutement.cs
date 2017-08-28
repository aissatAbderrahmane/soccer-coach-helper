using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace FootStat
{
    public partial class ajoutement : UserControl
    {
        protected Calcules calculator = new Calcules();
        protected Verification verify = new Verification();
        private DateTime dat = DateTime.Now;
        private StoreData db = new StoreData();
        private Label obs = new Label();
        private Label som = new Label();
        private double total = 0;
        private int numTEST = 0;
        private int JouTest = 1;
        private string idv;
        private int nume = 1;
        
        public ajoutement()
        {

            InitializeComponent();
            ID_V.Text = (db.ID("joueur")+1).ToString();
            idv = (db.ID("joueur") + 1).ToString();
        }
        public void addJoueur(string nom, string prenom, string age, string date, string numero, string equipe, string addresse, string img, int ALL, double totl)
        {
            if (!db.Exist("joueur", " nom='" + nom + "' and prenom ='" + prenom + "' "))
            {
                nume = 1;
                string first = "nom,prenom,age,daten,numero,equipe,addresse,lvl,test,qualites,img";
                ALL = (ALL == 3) ? 1 : 0;
                string second = "'" + nom + "', '" + prenom + "', '" + age + "', '" + date + "','" + numero + "', '" + equipe + "', '" + addresse + "',1,"+ALL+","+totl+",'" + img + "'";
                db.Connect();
                db.exec(db.insert("joueur", first, second));
                db.Close();
            }
            else MessageBox.Show("Ce joueur exist dejà!");
        }

        private void AddNewTest_Click(object sender, EventArgs e)
        {
            
            if (verify.Detail(NOM_V, PRN_V, DATE_V, TEL_V, AGE_V, ADR_V) && verify.Morphologie(TALL_V, POID_V))
            {

                if (verify.Physique(VitessR_V, VitesssCRS, VitesssCORD, VitesssSPL, VitesssDST))  { 
                    addPhysique(VitessR_V, VitesssCRS, VitesssCORD, VitesssDST, VitesssSPL, VitesssSRG, ID_V.Text);
                    numTEST++;
                    }

                    if (verify.Technique(GENGLE_V, SLALO_V, CNTR1, CNTR2, CNTR3))
                {
                    addTechnique(GENGLE_V, SLALO_V,CTRLO_V);
                    numTEST++;
                }

                    if (verify.Physiologique(DSTPHY))
                {
                    addPhysiologie(DSTPHY);
                    numTEST++;
                }
                
                    total = (numTEST == 3) ? total : 0;

                if (NEWTESTS.Checked == false) addJoueur(NOM_V.Text, PRN_V.Text, AGE_V.Text, DATE_V.Text, TEL_V.Text, Equipes.Text, ADR_V.Text, JoueurIMG.ImageLocation, numTEST, total);
                else db.exec(db.update("joueur","test","ID="+ID_V.Text+""));
                AddMorpho(POID_V,TALL_V,IMC_V);
                clear();
                
            }
            else MessageBox.Show("Il faut remplir tout les details");
        }
        private void clear()
        {
            NOM_V.Text = "";
            PRN_V.Text = "";
            AGE_V.Text = "";
            DATE_V.Text = "";
            TEL_V.Text = "";
            Equipes.Text = "";
            ADR_V.Text = "";
            VitesssDST.Text = "";
            TALL_V.Text = "";
            POID_V.Text = "";
            CNTR1.Text = "";
            CNTR2.Text = "";
            CNTR3.Text = "";
            DSTPHY.Text = "";
            VTSPHY.Text = "";
            VO2PHY.Text = "";
            VitessR_V.Text = "";
            VitesssCRS.Text = "";
            VitesssCORD.Text = "";
            VitesssDST.Text = "";
            VitesssSPL.Text = "";
            VitesssSRG.Text = "";
            JoueurIMG.Image = null;
            EquipeIMG.Image = null;
            GENGLE_V.Text = "";
            SLALO_V.Text = "";
            CTRLO_V.Text = "";
           if((NEWTESTS.Checked == false)) ID_V.Text = (db.ID("joueur") + 1).ToString();
        }
        private void addPhysiologie(TextBox DSPHY) {
            if (verify.Physiologique(DSPHY))
            {
                double VO2MAX = 0;
                double.TryParse(VO2PHY.Text, out VO2MAX);
                nume = 1;
                nume += db.nume("physiologique", ID_V.Text);
                string[] first = { "distance", "vitesse", "vo2max", "jou", "nume" };
                string[] second = { DSPHY.Text, VTSPHY.Text, VO2PHY.Text, ID_V.Text, nume.ToString() };
                string first1 = "distance,vitesse,vo2max,jou,nume";
                string second2 = "? , ?, ? , ?,? ";
                db.avInsert(db.insert("physiologique", first1, second2), first, second);
                Label VO = new Label(), VOs = new Label();
                VO.Text = VO2MAX.ToString();
                db.compare("VO2MAX", "Val",VO,VOs,false);
                double.TryParse(VO.Text, out VO2MAX);
                total += VO2MAX;
            }
        }
        private void AddMorpho(TextBox poid, TextBox tal,TextBox IMC)
        {
            double sm;
            nume = 1;
            nume += db.nume("morphologie", ID_V.Text);
            sm = TOT("TaillNote", "Val", tal.Text, som, obs, false);
            sm += TOT("PoidNote", "Val", poid.Text, som, obs, false);
            string[] first = { "taill", "poid", "imc", "total", "jou", "nume" };
            string[] second = { tal.Text, poid.Text, IMC.Text, "" + sm, ID_V.Text, nume.ToString() };
            string first1 = "taill,poid,imc,total,jou,nume";
            string second2 = "? , ?, ? , ?,?,? ";
            db.avInsert(db.insert("morphologie", first1, second2), first, second);
            total += sm;
        }
        private void addTechnique(TextBox GENGLE, TextBox SLALO, TextBox CNTRS)
        { 
            
                double somme;
            nume = 1;
             nume+= db.nume("technique", ID_V.Text);
            somme  = TOT("genglNote", "Val", GENGLE.Text, som, obs, false);
                somme  += TOT("slaBallNote", "Val", SLALO.Text, som, obs, true);
                somme += TOT("cntBallNote", "Val", CNTRS.Text, som, obs, false);
                string[] first = { "jengelerie", "slalome", "controleBall","total", "jou", "nume"};
                string[] second = { GENGLE.Text, SLALO.Text, CNTRS.Text, ""+somme, ID_V.Text, nume.ToString() };
                string first1 = "jengelerie,slalome,controleBall,total,jou,nume";
                string second2 = "?,?,?,?,?,?";
                db.avInsert(db.insert("technique", first1, second2), first, second);
            total += somme;
        }
        private void addPhysique(TextBox vitR, TextBox vitcrs, TextBox vitcord, TextBox vitdst, TextBox vitspl,TextBox vitsrg,string id)
        {
            
                double TOTAL = 0;
            nume = 1;
            nume += db.nume("physique", ID_V.Text);
            TOTAL += TOT("ReactNote", "Val", VitessR_V.Text, som, obs, true);
                TOTAL += TOT("souplNote", "Val", VitesssSPL.Text, som, obs, false);
                TOTAL += TOT("CourNote", "Val", VitesssCRS.Text, som, obs, true);
                TOTAL += TOT("sergNote", "Val", VitesssSRG.Text, som, obs, false);
                TOTAL += TOT("coordNote", "Val", VitesssCORD.Text, som, obs, true);
            MessageBox.Show(TOTAL.ToString());
                string[] first = { "react", "cours", "serg", "soupl", "cord", "dist", "total", "jou", "nume" };
                string[] second = { VitessR_V.Text, VitesssCRS.Text, VitesssCORD.Text, VitesssSRG.Text, VitesssSPL.Text, VitesssDST.Text, TOTAL.ToString(), ID_V.Text, nume.ToString() };
                string first1 = "react,cours,serg,soupl,cord,dist,total,jou,nume";
                string second2 = "? , ?, ? , ? ,  ? , ? , ? , ?, ?";
                db.avInsert(db.insert("physique", first1, second2), first, second);
            total += TOTAL;
        }
        private double TOT(string table,string col,string val,Label fi, Label Se, bool ob)
        {
            double sommme;
            fi.Text = val;
            db.compare(table, col, fi, Se, true);
            double.TryParse(fi.Text, out sommme);
            return sommme;
            
        }
        private void VitesssDST_TextChanged(object sender, EventArgs e)
        {
            double valDST, valTAL, valPOI;
            double.TryParse(VitesssDST.Text, out valDST);
            double.TryParse(TALL_V.Text, out valTAL);
            double.TryParse(POID_V.Text, out valPOI);
            VitesssSRG.Text = calculator.cal_sergent(valPOI, valDST, valTAL).ToString();

        }

        private void POID_V_TextChanged(object sender, EventArgs e)
        {
            double valTAL, valPOI;
            double.TryParse(TALL_V.Text, out valTAL);
            double.TryParse(POID_V.Text, out valPOI);
            IMC_V.Text = calculator.cal_IMC(valPOI, valTAL).ToString();
        }

        private void TALL_V_TextChanged(object sender, EventArgs e)
        {
            double valTAL, valPOI;
            double.TryParse(TALL_V.Text, out valTAL);
            double.TryParse(POID_V.Text, out valPOI);
            IMC_V.Text = calculator.cal_IMC(valPOI, valTAL).ToString();
        }

        private void CNTR1_TextChanged(object sender, EventArgs e)
        {
            CNT_VAL();
        }

        private void CNTR2_TextChanged(object sender, EventArgs e)
        {
            CNT_VAL();
        }

        private void CNTR3_TextChanged(object sender, EventArgs e)
        {
            CNT_VAL();
        }
        private void CNT_VAL()
        {
            double cnt1, cnt2, cnt3;
            double.TryParse(CNTR1.Text, out cnt1);//
            double.TryParse(CNTR2.Text, out cnt2);
            double.TryParse(CNTR3.Text, out cnt3);
            CTRLO_V.Text = calculator.cal_controledeball(cnt1, cnt2, cnt3).ToString();
        }

        private void DSTPHY_TextChanged(object sender, EventArgs e)
        {
            double DST_PHY;
            double.TryParse(DSTPHY.Text, out DST_PHY);
            VTSPHY.Text = ((DST_PHY / 1000) * 12).ToString();
            VO2PHY.Text = calculator.cal_VO2MAX(DST_PHY).ToString();//
        }

        private void JoueurIMG_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog img = new OpenFileDialog())
            {
                img.Title = "Choisir l'image fu joueur";
                img.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
                if (img.ShowDialog() == DialogResult.OK)
                {
                    
                    JoueurIMG.Image = new Bitmap(img.FileName);
                    FileInfo inf = new FileInfo(img.FileName);
                   JoueurIMG.Image.Save(@"joueurs/"+ inf.Name, JoueurIMG.Image.RawFormat);
                    JoueurIMG.ImageLocation = @"joueurs/" + inf.Name;
                }
            }
        }


        private void DATE_V_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime dtse = DateTime.Parse(DATE_V.Text).Date;

                AGE_V.Text = (dat.Year - dtse.Year).ToString();
            }
            catch { }
        }

        private void Equipes_SelectedValueChanged(object sender, EventArgs e)
        {
            IMGEQP(Equipes.Text);
        }
        private void IMGEQP(string type)
        {
            string IMG_Name = "";
            switch (Equipes.Text)
            {
                case "USMA":
                    IMG_Name = "Equipes/" + Equipes.Text + ".png";
                    break;
            }
            EquipeIMG.ImageLocation = IMG_Name;
            //
        }

        private void NEWTESTS_CheckedChanged(object sender, EventArgs e)
        {
            if (NEWTESTS.Checked == true)
            {
                ID_V.Enabled = true;
                ID_V.Text = "";
                ID_V.TextChanged += ID_V_TextChanged;
            }
            else {
                ID_V.Enabled = false;
                NOM_V.Enabled = true;
                PRN_V.Enabled = true;
                ADR_V.Enabled = true;
                DATE_V.Enabled = true;
                TEL_V.Enabled = true;
                Equipes.Enabled = true;
                AGE_V.Enabled = false;

                clear();
                ID_V.TextChanged -= ID_V_TextChanged;
                ID_V.Text = idv;
            }
        }

        private void ID_V_TextChanged(object sender, EventArgs e)
        {
            if (db.Exist("joueur", "ID=" + ID_V.Text + ""))
            {
                db.Connect();
                db.getData(db.select("joueur","", "ID=" + ID_V.Text + ""));
                NOM_V.Enabled = false;
                PRN_V.Enabled = false;
                AGE_V.Enabled = false;
                DATE_V.Enabled = false;
                TEL_V.Enabled = false;
                Equipes.Enabled = false;
                ADR_V.Enabled = false;
                while (db.reader.Read())
                {
                    NOM_V.Text = db.reader["nom"].ToString();
                    PRN_V.Text = db.reader["prenom"].ToString();
                    AGE_V.Text = db.reader["age"].ToString();
                    DATE_V.Text = db.reader["daten"].ToString();
                    TEL_V.Text = db.reader["numero"].ToString();
                    Equipes.Text = db.reader["equipe"].ToString();
                    ADR_V.Text = db.reader["addresse"].ToString();
                }
                db.Close();
            }
            else MessageBox.Show("ce joueur n'exist pas!");
        }
    }
}
