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
        private int JouTest = 0;
        private string idv;
        private int nume = 1;
        
        public ajoutement()
        {
            System.Globalization.CultureInfo.CreateSpecificCulture("sv-SE");
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            InitializeComponent();
            if (db.empty("joueur"))
            {
                ID_V.Text = "1";
                idv = "1";
            }
            else { 
            ID_V.Text = (db.ID("joueur")+1).ToString();
            idv = (db.ID("joueur") + 1).ToString();
            }
            
        }
        public void addJoueur(string nom, string prenom, string age, string date, string numero, string equipe, string addresse, string img, int ALL, double totl,bool md=false)
        {
            
                nume = 1;
                string first = "nom,prenom,age,daten,numero,equipe,addresse,lvl,test,qualites,img";
                ALL = (ALL == 3) ? 1 : 0;
                string second = "'" + nom + "', '" + prenom + "', '" + age + "', '" + date + "','" + numero + "', '" + equipe + "', '" + addresse + "',1,"+ALL+","+totl+",'" + img + "'";
                db.Connect();
                if (md == false) {
                    if (!db.Exist("joueur", " nom='" + nom + "' and prenom ='" + prenom + "' "))
                    {
                    db.Connect();
                        db.exec(db.insert("joueur", first, second));
                    db.Close();
                }
                    else MessageBox.Show("Ce joueur exist dejà!");
            }
            else 
                {
                    db.exec(db.update("joueur","nom='"+ nom + "' ","ID="+ID_V.Text+" "));
                    db.exec(db.update("joueur", "prenom='"+ prenom + "' ","ID="+ID_V.Text+" "));
                    db.exec(db.update("joueur", "age='"+ age + "' ","ID="+ID_V.Text+" "));
                    db.exec(db.update("joueur", "daten='"+ date + "' ","ID="+ID_V.Text+" "));
                    db.exec(db.update("joueur", "numero='"+ numero + "' ","ID="+ID_V.Text+" "));
                    db.exec(db.update("joueur", "equipe='"+ equipe + "' ","ID="+ID_V.Text+" "));
                    db.exec(db.update("joueur", "addresse='"+ addresse + "' ","ID="+ID_V.Text+" "));
                    db.exec(db.update("joueur", "qualites='"+ totl + "' ","ID="+ID_V.Text+" "));
                    db.exec(db.update("joueur", "img='"+ img + "' ","ID="+ID_V.Text+" "));
                }
                db.Close();
            
        }

        private void AddNewTest_Click(object sender, EventArgs e)
        {
            
            if (verify.Detail(NOM_V, PRN_V, DATE_V, TEL_V, AGE_V, ADR_V) && verify.Morphologie(TALL_V, POID_V))
            {

                if (verify.Physique(VitessR_V, VitesssCRS, VitesssCORD, VitesssSPL, VitesssDST))  { 
                    if(modifyJou.Checked == false) addPhysique(VitessR_V, VitesssCRS, VitesssCORD, VitesssDST, VitesssSPL, VitesssSRG, ID_V.Text);
                    else addPhysique(VitessR_V, VitesssCRS, VitesssCORD, VitesssDST, VitesssSPL, VitesssSRG, ID_V.Text,true, JouTest);
                    numTEST++;
                    }

                    if (verify.Technique(GENGLE_V, SLALO_V, CNTR1, CNTR2, CNTR3))
                {
                    if (modifyJou.Checked == false) addTechnique(GENGLE_V, SLALO_V,CTRLO_V);
                    else addTechnique(GENGLE_V, SLALO_V, CTRLO_V, true, JouTest);
                    numTEST++;
                }

                    if (verify.Physiologique(DSTPHY))
                {
                    if (modifyJou.Checked == false) addPhysiologie(DSTPHY);
                    else addPhysiologie(DSTPHY, true, JouTest);
                    numTEST++;
                }
                
                    total = (numTEST == 3) ? total : 0;

                if (NEWTESTS.Checked == false && modifyJou.Checked == false) addJoueur(NOM_V.Text, PRN_V.Text, AGE_V.Text, DATE_V.Text, TEL_V.Text, Equipes.Text, ADR_V.Text, JoueurIMG.ImageLocation, numTEST, total);
                else if (NEWTESTS.Checked == true && modifyJou.Checked == false)
                {
                    db.Connect();
                    db.exec(db.update("joueur", "test=test+1", "ID=" + ID_V.Text + ""));
                    db.Close();
                }
                else addJoueur(NOM_V.Text, PRN_V.Text, AGE_V.Text, DATE_V.Text, TEL_V.Text, Equipes.Text, ADR_V.Text, JoueurIMG.ImageLocation, numTEST, total,true);
                if (modifyJou.Checked == false) AddMorpho(POID_V,TALL_V,IMC_V);
                else AddMorpho(POID_V, TALL_V, IMC_V,true,JouTest);
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
           if((NEWTESTS.Checked == false)  && (modifyJou.Checked == false)) ID_V.Text = (db.ID("joueur") + 1).ToString();
        }
        private void addPhysiologie(TextBox DSPHY, bool md = false, int nt = 0) {
            
            if (verify.Physiologique(DSPHY))
            {
                
                double VO2MAX = 0;
                VO2PHY.Text.Replace(".", ",");
                DSPHY.Text.Replace(".", ",");
                VTSPHY.Text.Replace(".", ",");
                double.TryParse(VO2PHY.Text, out VO2MAX);
                nume = 1;
                nume += db.nume("physiologique", ID_V.Text);
                if (md == false) { 
                string first1 = "distance,vitesse,vo2max,jou,nume";
                string second2 = "'"+ DSPHY.Text + "' , '"+ VTSPHY.Text + "', '"+ VO2PHY.Text + "' , '"+ ID_V.Text + "','"+ nume.ToString() + "' ";
                    db.Connect(); db.exec(db.insert("physiologique", first1, second2));  db.Close();
                }
                else
                {
                    db.Connect();
                    db.exec(db.update("physiologique", "distance='"+ DSPHY.Text + "' "," jou="+ID_V.Text+" and nume="+nt+" "));
                    db.exec(db.update("physiologique", "vitesse='"+ VTSPHY.Text + "' "," jou="+ID_V.Text+" and nume="+nt+" "));
                    db.exec(db.update("physiologique", "vo2max='"+ VO2PHY.Text+ "' ", " jou="+ID_V.Text+" and nume="+nt+" "));
                    db.Close();
                }
                Label VO = new Label(), VOs = new Label();
                VO.Text = VO2MAX.ToString();
                db.compare("VO2MAX", "Val",VO,VOs,false);
                double.TryParse(VO.Text, out VO2MAX);
                total += VO2MAX;
            }
        }
        private void AddMorpho(TextBox poid, TextBox tal,TextBox IMC, bool md = false, int nt = 0)
        {
            
            double sm;
            nume = 1;
            nume += db.nume("morphologie", ID_V.Text);
            tal.Text.Replace(".", ",");
            poid.Text.Replace(".", ",");
            sm = TOT("TaillNote", "Val", tal.Text, som, obs, false);
            sm += TOT("PoidNote", "Val", poid.Text, som, obs, false);
            if (md == false) {
                string first1 = "taill,poid,imc,total,jou,nume";
                string second2 = "'"+ tal.Text+"','"+ poid.Text + "','" + IMC.Text + "','" + sm + "','" + ID_V.Text + "','" + nume.ToString() +"'";
                db.Connect();  db.exec(db.insert("morphologie", first1, second2)); db.Close();
            } else {
                db.Connect();
                db.exec(db.update("morphologie", "taill='"+ tal.Text + "'", "jou="+ID_V.Text+" and nume="+nt+" "));
                db.exec(db.update("morphologie", "poid='"+ poid.Text + "'", "jou="+ID_V.Text+" and nume="+nt+" "));
                db.exec(db.update("morphologie", "imc='"+ IMC.Text + "'", "jou="+ID_V.Text+" and nume="+nt+" "));
                db.exec(db.update("morphologie", "total='"+ sm + "'", "jou="+ID_V.Text+" and nume="+nt+" "));
                db.Close();
            }
            total += sm;
        }
        private void addTechnique(TextBox GENGLE, TextBox SLALO, TextBox CNTRS,bool md=false,int nt=0)
        {
           
            double somme;
            nume = 1;
             nume+= db.nume("technique", ID_V.Text);
            GENGLE.Text.Replace(".", ",");
            SLALO.Text.Replace(".", ",");
            CNTRS.Text.Replace(".", ",");
            somme  = TOT("genglNote", "Val", GENGLE.Text, som, obs, false);
                somme  += TOT("slaBallNote", "Val", SLALO.Text, som, obs, true);
                somme += TOT("cntBallNote", "Val", CNTRS.Text, som, obs, false);
            if (md == false) {
                string first1 = "jengelerie,slalome,controleBall,total,jou,nume";
                string second2 = "'"+ GENGLE.Text + "','"+ SLALO.Text + "','"+ CNTRS.Text + "','"+ somme + "','"+ ID_V.Text + "','"+ nume.ToString() + "'";
                db.Connect();  db.exec(db.insert("technique", first1, second2)); db.Close();
            }
            else
            {
                db.Connect();
                db.exec(db.update("technique", "jengelerie='"+ GENGLE.Text + "' ", "jou="+ID_V.Text+" and nume="+nt+" "));
                db.exec(db.update("technique", "slalome='" + SLALO.Text + "' ", "jou="+ID_V.Text+" and nume="+nt+" "));
                db.exec(db.update("technique", "controleBall='" + CNTRS.Text + "' ", "jou="+ID_V.Text+" and nume="+nt+" "));
                db.exec(db.update("technique", "total='" + somme + "' ", "jou="+ID_V.Text+" and nume="+nt+" "));
                db.Close();
            }
            total += somme;
        }
        private void addPhysique(TextBox vitR, TextBox vitcrs, TextBox vitcord, TextBox vitdst, TextBox vitspl,TextBox vitsrg,string id,bool mdf = false, int nt = 0)
        {
            
            double TOTAL = 0;
            nume = 1;
            nume += db.nume("physique", ID_V.Text);
            VitessR_V.Text.Replace(".", ",");
            VitesssSPL.Text.Replace(".", ",");
            VitesssCRS.Text.Replace(".", ",");
            VitesssSRG.Text.Replace(".", ",");
            VitesssCORD.Text.Replace(".", ",");
            TOTAL += TOT("ReactNote", "Val", VitessR_V.Text, som, obs, true);
                TOTAL += TOT("souplNote", "Val", VitesssSPL.Text, som, obs, false);
                TOTAL += TOT("CourNote", "Val", VitesssCRS.Text, som, obs, true);
                TOTAL += TOT("sergNote", "Val", VitesssSRG.Text, som, obs, false);
                TOTAL += TOT("coordNote", "Val", VitesssCORD.Text, som, obs, true);
            if (mdf == false)
            {
                string first1 = "react,cours,serg,soupl,cord,dist,total,jou,nume";
                string second2 = "'"+ VitessR_V.Text + "' , '"+ VitesssCRS.Text + "', '"+ VitesssSRG.Text + "' , '"+ VitesssSPL.Text + "' ,  '"+ VitesssCORD.Text + "' , '"+ VitesssDST.Text + "' , '"+ TOTAL.ToString() + "' , '"+ ID_V.Text + "', '"+ nume.ToString() + "'";
                db.Connect();  db.exec(db.insert("physique", first1, second2)); db.Close();
            }
            else
            {
                db.Connect();
                db.exec(db.update("physique", "react='"+ VitessR_V.Text + "' ", "jou=" + ID_V.Text+" and nume="+nt+" "));
                db.exec(db.update("physique", "cours='" + VitesssCRS.Text + "' ", "jou=" + ID_V.Text+ " and  nume=" + nt + " "));
                db.exec(db.update("physique", "cord='" + VitesssCORD.Text + "' ", "jou=" + ID_V.Text+ " and  nume=" + nt + " "));
                db.exec(db.update("physique", "serg='" + VitesssSRG.Text + "' ", "jou=" + ID_V.Text+ " and  nume=" + nt + " "));
                db.exec(db.update("physique", "soupl='" + VitesssSPL.Text + "' ", "jou=" + ID_V.Text+ "  and nume=" + nt + " "));
                db.exec(db.update("physique", "dist='" + VitesssDST.Text + "' ", "jou=" + ID_V.Text+ "  and nume=" + nt + " "));
                db.exec(db.update("physique", "total='" + TOTAL.ToString() + "' ", "jou=" + ID_V.Text+ " and  nume=" + nt + " "));
                db.Close();
            }
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
            VitesssDST.Text.Replace(".", ",");
            TALL_V.Text.Replace(".", ",");
            POID_V.Text.Replace(".", ",");
            double.TryParse(VitesssDST.Text, out valDST);
            double.TryParse(TALL_V.Text, out valTAL);
            double.TryParse(POID_V.Text, out valPOI);
            VitesssSRG.Text = calculator.cal_sergent(valPOI, valDST, valTAL).ToString();

        }

        private void POID_V_TextChanged(object sender, EventArgs e)
        {
            double valTAL, valPOI;
            TALL_V.Text.Replace(".", ",");
            POID_V.Text.Replace(".", ",");
            double.TryParse(TALL_V.Text, out valTAL);
            double.TryParse(POID_V.Text, out valPOI);
            IMC_V.Text = calculator.cal_IMC(valPOI, valTAL).ToString();
        }

        private void TALL_V_TextChanged(object sender, EventArgs e)
        {
            double valTAL, valPOI;
            TALL_V.Text.Replace(".", ",");
            POID_V.Text.Replace(".", ",");
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
            CNTR1.Text.Replace(".", ",");
            CNTR2.Text.Replace(".", ",");
            CNTR3.Text.Replace(".", ",");
            double.TryParse(CNTR1.Text, out cnt1);//
            double.TryParse(CNTR2.Text, out cnt2);
            double.TryParse(CNTR3.Text, out cnt3);
            CTRLO_V.Text = calculator.cal_controledeball(cnt1, cnt2, cnt3).ToString();
        }

        private void DSTPHY_TextChanged(object sender, EventArgs e)
        {
            double DST_PHY;
            DSTPHY.Text.Replace(".", ",");
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
                    JoueurIMG.Width = 177;
                    JoueurIMG.Height = 173;
                    FileInfo inf = new FileInfo(img.FileName);
                   JoueurIMG.Image.Save(@"C:/FootTest/joueurs/" + inf.Name, JoueurIMG.Image.RawFormat);
                    JoueurIMG.ImageLocation = @"C:/FootTest/joueurs/" + inf.Name;
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
            
                    IMG_Name = "C:/FootTest/Equipes/" + Equipes.Text + ".png";
            if (!File.Exists(IMG_Name))
            {
                IMG_Name = "C:/FootTest/Equipes/" + Equipes.Text + ".jpg";
            }
            EquipeIMG.ImageLocation = IMG_Name;
            EquipeIMG.Width = 177;
            EquipeIMG.Height = 173;
            //
        }

        private void NEWTESTS_CheckedChanged(object sender, EventArgs e)
        {
            testN.Visible = false;
            if (NEWTESTS.Checked == true)
            {
                ID_V.Enabled = true;
                ID_V.Text = "";
                ID_V.TextChanged += ID_V_TextChanged;
                modifyJou.Enabled = false;
            }
            else {
                modifyJou.Enabled = true;
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
            int it = 0;
            if (db.Exist("joueur", "ID=" + ID_V.Text + ""))
            {
                db.Connect();
                db.getData(db.select("joueur","", "ID=" + ID_V.Text + ""));
                if (NEWTESTS.Checked == true) {
                    NOM_V.Enabled = false;
                    PRN_V.Enabled = false;
                    AGE_V.Enabled = false;
                    DATE_V.Enabled = false;
                    TEL_V.Enabled = false;
                    Equipes.Enabled = false;
                    ADR_V.Enabled = false;
                    JoueurIMG.Enabled = false;
                }
                while (db.reader.Read())
                {
                    NOM_V.Text = db.reader["nom"].ToString();
                    PRN_V.Text = db.reader["prenom"].ToString();
                    AGE_V.Text = db.reader["age"].ToString();
                    DATE_V.Text = db.reader["daten"].ToString();
                    TEL_V.Text = db.reader["numero"].ToString();
                    Equipes.Text = db.reader["equipe"].ToString();
                    ADR_V.Text = db.reader["addresse"].ToString();
                    JoueurIMG.ImageLocation = db.reader["img"].ToString();
                    int.TryParse(db.reader["test"].ToString(), out it);
                    
                }
                db.Close();
                IMGEQP(Equipes.Text);
                testN.Items.Clear();
                for (int i = 1; i<=it;i++)
                {
                    testN.Items.Add("test "+i);
                }
            }
            else MessageBox.Show("ce joueur n'exist pas!");
        }

        private void modifyJou_CheckedChanged(object sender, EventArgs e)
        {
            if (modifyJou.Checked == true)
            {
                ID_V.Enabled = true;
                ID_V.Text = "";
                ID_V.TextChanged += ID_V_TextChanged;
                NEWTESTS.Enabled = false;
                testN.Visible = true;
                AddNewTest.Text = "Modifier";
            }
            else
            {
                AddNewTest.Text = "Ajouter";
                testN.Visible = false;
                testN.Items.Clear();
                testN.Text = "test";
                NEWTESTS.Enabled = true;
                ID_V.Enabled = false;
                clear();
                ID_V.TextChanged -= ID_V_TextChanged;
                ID_V.Text = idv;
            }
        }

        private void testN_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (testN.SelectedItem.ToString())
            {
                case "test 1":
                    JouTest = 1;
                    SelectTest(1);
                    break;
                case "test 2":
                    JouTest = 2;
                    SelectTest(2);
                    break;
                case "test 3":
                    JouTest = 3;
                    SelectTest(3);
                    break;
                case "test 4":
                    JouTest = 4;
                    SelectTest(4);
                    break;
            }
        }
        private void SelectTest(int NumeroT)
        {

            if (ID_V.Text != "")
            {
                if (db.Exist("physiologique", "jou=" + ID_V.Text + " and nume=" + NumeroT + " "))
                {
                    db.Connect();
                    db.getData(db.select("physiologique","", "jou=" + ID_V.Text + " and nume=" + NumeroT + " "));
                    while (db.reader.Read())
                    {
                        DSTPHY.Text = db.reader["distance"].ToString();
                    }
                    db.Close();
                }
                if (db.Exist("physique", "jou=" + ID_V.Text + " and nume=" + NumeroT + " "))
                {
                    db.Connect();
                    db.getData(db.select("physique","", "jou=" + ID_V.Text + " and nume=" + NumeroT + " "));
                    while (db.reader.Read())
                    {
                        VitessR_V.Text = db.reader["react"].ToString();
                        VitesssCRS.Text = db.reader["cours"].ToString();
                        VitesssCORD.Text = db.reader["cord"].ToString();
                        VitesssDST.Text = db.reader["dist"].ToString();
                        VitesssSPL.Text = db.reader["soupl"].ToString();
                    }
                    db.Close();
                }
                if (db.Exist("technique", "jou=" + ID_V.Text + " and nume=" + NumeroT + " "))
                {
                    double geng = 0;
                    db.Connect();
                    db.getData(db.select("technique","", "jou=" + ID_V.Text + " and nume=" + NumeroT + " "));
                    while (db.reader.Read())
                    {
                        GENGLE_V.Text = db.reader["jengelerie"].ToString();
                        SLALO_V.Text = db.reader["slalome"].ToString(); 
                        double.TryParse(db.reader["controleBall"].ToString(), out geng);
                        geng /= 3;
                        CNTR1.Text = geng.ToString();
                        CNTR2.Text = geng.ToString();
                        CNTR3.Text = geng.ToString();
                    }
                    db.Close();
                }
                if (db.Exist("morphologie", "jou=" + ID_V.Text + " and nume=" + NumeroT + " "))
                {
                    db.Connect();
                    db.getData(db.select("morphologie","", "jou=" + ID_V.Text + " and nume=" + NumeroT + " "));
                    while (db.reader.Read())
                    {
                        TALL_V.Text = db.reader["taill"].ToString();
                        POID_V.Text = db.reader["poid"].ToString();
                    }
                    db.Close();
                }
            }
            else MessageBox.Show("Il Faut Selectioné un joueur en utilisent l'ID");
        }
    }
}
