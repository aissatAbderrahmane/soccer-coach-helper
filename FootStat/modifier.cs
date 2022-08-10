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
    public partial class modifier : UserControl
    {
        StoreData db = new StoreData();
        private string ID;
        DateTime dat = DateTime.Now;
        protected Calcules calculator = new Calcules();
        public modifier(string id)
        {
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            InitializeComponent();
            ID_V.Text = id;
            ID = id;
        }

        private void modifier_Load(object sender, EventArgs e)
        {
            db.Connect();
            db.getData(db.select("joueur", "", "ID=" + ID + " "));
            while (db.reader.Read())
            {
                NOM_V.Text = db.reader["nom"].ToString();
                PRN_V.Text = db.reader["prenom"].ToString();
                ADR_V.Text = db.reader["addresse"].ToString();
                TEL_V.Text = db.reader["numero"].ToString();
                DATE_V.Text = db.reader["daten"].ToString();
                AGE_V.Text = db.reader["age"].ToString();
                JoueurIMG.ImageLocation = db.reader["img"].ToString();
               // Equipes.Text = db.reader["euipe"].ToString();
            }
            db.Close();
            //TALL_V,POID_V
            db.Connect();
            db.getData(db.select("morphologie", "", "nume=" + ID + " "));
            while (db.reader.Read())
            {
                TALL_V.Text = db.reader["taill"].ToString();
                POID_V.Text = db.reader["poid"].ToString();
                IMC_V.Text = db.reader["imc"].ToString();
            }
            db.Close();
            label5.Text += " "+ NOM_V.Text+" "+ PRN_V.Text;
        }

        private void AddNewTest_Click(object sender, EventArgs e)
        {
            double valTAL, valPOI,valIMC,sm1,sm2,smT;
            double.TryParse(TALL_V.Text, out valTAL);
            double.TryParse(POID_V.Text, out valPOI);
            double.TryParse(IMC_V.Text, out valIMC);
            Label on = new Label(), tw = new Label();
            on.Text = TALL_V.Text;
            db.compare("TaillNote", "Val", on, tw, false);
            double.TryParse(on.Text, out sm1);
            on.Text = POID_V.Text;
            db.compare("PoidNote", "Val", on, tw, false);
            double.TryParse(on.Text, out sm2);
            smT = sm1 + sm2;
            db.Connect();
            db.exec(db.update("joueur", "addresse='"+ ADR_V.Text + "' and numero='"+ TEL_V.Text + "'", "ID="+ID+" "));
            db.exec(db.update("morphologie", "taill='" + valTAL + "' and poid='" + valPOI + "' and imc='"+ valIMC + "' and total="+ smT + " ", "nume=" + ID + " "));
            db.Close();
        }

        private void TALL_V_TextChanged(object sender, EventArgs e)
        {
            double valTAL, valPOI;
            double.TryParse(TALL_V.Text, out valTAL);
            double.TryParse(POID_V.Text, out valPOI);
            IMC_V.Text = calculator.cal_IMC(valPOI, valTAL).ToString();
        }

        private void POID_V_TextChanged(object sender, EventArgs e)
        {
            double valTAL, valPOI;
            double.TryParse(TALL_V.Text, out valTAL);
            double.TryParse(POID_V.Text, out valPOI);
            IMC_V.Text = calculator.cal_IMC(valPOI, valTAL).ToString();
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
    }
}
