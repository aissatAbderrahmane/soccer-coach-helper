using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Globalization;
using System.Diagnostics;
using System.IO;

namespace FootStat
{
    public partial class evaluation : UserControl
    {
        private Form1 form1;
        private string type;
        private ResourceManager rsx;
        private CultureInfo cul;
        private int ID;
        private StoreData db = new StoreData();
        private printWords printer ;
        private int NR;
        public evaluation(Form1 fr,string type,int id,int nr)
        {
            string tempee = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
            form1 = fr;
            this.type = type;
            ID = id;
            InitializeComponent();
            NR = nr;
        }

        private void ret_Click(object sender, EventArgs e)
        {
            form1.Evaluations_Click(sender,e);
        }
        private string EquipeImg(string name)
        {
            string equipe_name = null;
            switch (name)
            {
                case "Rapide Club Rélizane": equipe_name = "RCR"; break;
                case "CSA ARRZEW": equipe_name = "OMA"; break;
                case "MASCARA": equipe_name = "GCM"; break;
                case "Sidi Belabbes": equipe_name = "USMBA"; break;
                case "Hessasna": equipe_name = "MB"; break;
                case "WAT Tlemcen": equipe_name = "WAT"; break;
                case "ASM Meghnia": equipe_name = "IRBM"; break;
                case "Les Etoiles de Tiaret": equipe_name = "NOUDJOUM"; break;
                default:
                    equipe_name = name;
                    break;
            }
            return equipe_name;
        }
        private void evaluation_Load(object sender, EventArgs e)
        {
            
          
            rsx = new ResourceManager("language.Resource", typeof(evaluation).Assembly);
            cul = CultureInfo.CreateSpecificCulture("Ar");
            
            if (db.Exist("joueur","ID="+ID.ToString()+" "))
            {
                db.Connect();
                db.getData(db.select("joueur", "", "ID=" + ID.ToString() + " "));
                while (db.reader.Read())
                {
                    Nom.Text = db.reader["nom"].ToString();
                    Prenom.Text = db.reader["prenom"].ToString();
                    Age.Text = db.reader["age"].ToString();
                    NumTel.Text = db.reader["numero"].ToString();
                    Adresse.Text = db.reader["addresse"].ToString();
                    Equipe.Text = db.reader["equipe"].ToString();
                    JouIMG.ImageLocation = db.reader["img"].ToString();
                    JouIMG.Width = 159;
                    JouIMG.Height = 165;
                    string is1 = "C:/FootTest/Equipes/" + EquipeImg(db.reader["equipe"].ToString()) + ".png";
                    string is2 = "C:/FootTest/Equipes/" + EquipeImg(db.reader["equipe"].ToString()) + ".jpg";
                    EquipeIMG.ImageLocation = (File.Exists(is1)) ? is1 : is2;
                    EquipeIMG.Width = 169;
                    EquipeIMG.Height = 149;
                }
                db.Close();
                //reaction(double vits,string note)


            }
            
            switch (type)
            {
                case "Morphologique et Physiologique":
                    label2.Text += " Morphologique \n et Physiologique";
                    MorphPhys MorPhy = new MorphPhys(this.ID.ToString(), NR);
                    cntEval.Controls.Clear();
                    this.Size = form1.CNTS.Size;
                    
                    cntEval.Controls.Add(MorPhy);
                    break;
                case "Physique":
                    label2.Text += " Physique";
                    EvalPhysique Physique = new EvalPhysique(this.ID.ToString(), NR);
                    cntEval.Controls.Clear();
                    this.Size = form1.CNTS.Size;
                    Physique.Size = cntEval.Size;
                    cntEval.Controls.Add(Physique);
                    break;
                case "Technique":
                    label2.Text += " Technique";
                    Technique technique = new Technique(this.ID.ToString(), NR);
                    cntEval.Controls.Clear();
                    this.Size = form1.CNTS.Size;
                    technique.Size = cntEval.Size;
                    cntEval.Controls.Add(technique);
                    //
                    break;
                case "Performance Totale":
                    label2.Text += " Totale ";
                    AllTests all = new AllTests(this.ID.ToString(), NR);
                    cntEval.Controls.Clear();
                    this.Size = form1.CNTS.Size;
                    cntEval.Controls.Add(all);
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printer = new printWords(@"C:\FootTest\Fiches\fch.docx");
            printer.init(ID);
            switch (type)
            {
                case "Morphologique et Physiologique":
                    printer.eval_morphy();
                    break;
                case "Physique":
                    printer.eval_phy();
                    break;
                case "Technique":
                    printer.eval_tech();
                    break;
                case "Tous les types":
                    printer.eval_morphy();
                    printer.eval_phy();
                    printer.eval_tech();
                    printer.TOTALS();
                    break;
            }
            printer.save(false);
            string PrinterName;
            PrintDialog Printdialog = new PrintDialog();
            if (Printdialog.ShowDialog() == DialogResult.OK)
            {
                PrinterName = Printdialog.PrinterSettings.PrinterName;

                ProcessStartInfo info = new ProcessStartInfo(@"C:\FootTest\Fiches\fiches" + ID+".pdf");
            info.Verb = "PrintTo";
            info.Arguments = "\"" + PrinterName + "\"";
            info.CreateNoWindow = true;
            info.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(info);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printer.init(ID);
            switch (type)
            {
                case "Morphologique et Physiologique":
                    printer.eval_morphy();
                    break;
                case "Physique":
                    printer.eval_phy();
                    break;
                case "Technique":
                    printer.eval_tech();
                    break;
                case "Tous les types":
                    printer.eval_morphy();
                    printer.eval_phy();
                    printer.eval_tech();
                    printer.TOTALS();
                    break;
            }
            printer.save();
        }
    }
}
