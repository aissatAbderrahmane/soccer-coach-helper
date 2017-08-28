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
        private printWords printer = new printWords(@"C:\Users\MR.CPU\Documents\Visual Studio 2015\Projects\FootStat\FootStat\bin\Debug\fch.docx");
         
        public evaluation(Form1 fr,string type,int id)
        {
            form1 = fr;
            this.type = type;
            ID = id;
            InitializeComponent();
        }

        private void ret_Click(object sender, EventArgs e)
        {
            form1.Evaluations_Click(sender,e);
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
                    EquipeIMG.ImageLocation = "Equipes/"+db.reader["equipe"].ToString()+".png";
                }
                db.Close();
                //reaction(double vits,string note)


            }
            
            switch (type)
            {
                case "Morphologie et Physiologie":
                    MorphPhys MorPhy = new MorphPhys(this.ID.ToString());
                    cntEval.Controls.Clear();
                    this.Size = form1.CNTS.Size;
                    
                    cntEval.Controls.Add(MorPhy);
                    break;
                case "Physique":
                    EvalPhysique Physique = new EvalPhysique(this.ID.ToString());
                    cntEval.Controls.Clear();
                    this.Size = form1.CNTS.Size;
                    Physique.Size = cntEval.Size;
                    cntEval.Controls.Add(Physique);
                    break;
                case "Technique":
                    //
                    Technique technique = new Technique(this.ID.ToString());
                    cntEval.Controls.Clear();
                    this.Size = form1.CNTS.Size;
                    technique.Size = cntEval.Size;
                    cntEval.Controls.Add(technique);
                    //
                    break;
                case "Tous les types":
                    AllTests all = new AllTests(this.ID.ToString());
                    cntEval.Controls.Clear();
                    this.Size = form1.CNTS.Size;
                    cntEval.Controls.Add(all);
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            printer.init(ID);
            switch (type)
            {
                case "Morphologie et Physiologie":
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

                ProcessStartInfo info = new ProcessStartInfo(@"C:\Users\MR.CPU\Documents\Visual Studio 2015\Projects\FootStat\FootStat\bin\Debug\fiches2.pdf");
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
                case "Morphologie et Physiologie":
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
