using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office;
using System.Drawing.Drawing2D;
using System.IO;
using System.Diagnostics;
using Microsoft.Office.Interop.Word;
using Label = System.Windows.Forms.Label;
using System.Threading;

namespace FootStat
{
    class printWords
    {
        private string filep;
        private Microsoft.Office.Interop.Word.Document doc;
        private Application app = new Application();
        private bool ExitHandl;
        private int ID;
        private StoreData db = new StoreData();
        private string[] note = {"", "", "", "", "", "" }, obs = { "", "", "", "", "", "" };
        public printWords(string filename)
        {
            app.Visible = false;
            filep = filename;
        }
        public void init(int id)
        {
            doc = app.Documents.Open(filep, ReadOnly: false);
            ID = id;
            info();
        }
        public void info()
        {
            db.Connect();
            db.getData(db.select("joueur", "", "ID=" + ID + " "));
            while (db.reader.Read())
            {
                note[0] = db.reader["nom"].ToString();
                note[3] = db.reader["prenom"].ToString();
                note[1] = db.reader["img"].ToString();
                note[2] = db.reader["daten"].ToString();
                note[4] = db.reader["numero"].ToString();
                note[5] = db.reader["addresse"].ToString();
            }
            db.Close();
            add("name", note[0]);
            add("surname", note[3]);
            add("dateN", note[2]);
            add("addresse", note[5]);
            add("tels", note[4]);
            //add("picJou", note[1]);


        }
        public void add(string bookName, string bookVal)
        {
            if (doc.Bookmarks.Exists(bookName))
            {
                Object book = bookName;
                Range rang = doc.Bookmarks.get_Item(ref book).Range;
                rang.Text = bookVal;
                Object NEWrng = rang;
                doc.Bookmarks.Add(bookName, ref NEWrng);
            }
        }
        private void Val(string tab, int n,bool up)
        {
            Label valee = new Label(), ob = new Label();
            valee.Text = note[n];
            db.compare(tab, "Val", valee, ob, up);
            note[n] = valee.Text;
            obs[n] = ob.Text;
            
        }
        public void eval_phy()
        {
            db.Connect();
            db.getData(db.select("physique", "", "jou=" + ID + " "));
            
            while (db.reader.Read())
            {
                note[0] = db.reader["react"].ToString();
                note[3] = db.reader["soupl"].ToString();
                note[1] = db.reader["cours"].ToString();
                note[2] = db.reader["serg"].ToString();
                note[4] = db.reader["cord"].ToString();
                note[5] = db.reader["total"].ToString();
            }
            db.Close();
            Val("ReactNote", 0, true);
            Val("souplNote", 3, false);
            Val("CourNote",1, true);
            Val("sergNote", 2, false);
            Val("coordNote", 4, true);
            Val("phyTotl", 5, false);
            
                add("vreact", note[0]);
                add("vcourse", note[1]);
                add("sergent", note[2]);
                add("soupl", note[3]);
                add("cord", note[4]);
                add("robs", obs[0]);
                add("cobs", obs[1]);
                add("seobs", obs[2]);
                add("soobs", obs[3]);
                add("corobs", obs[4]);
                add("phy", note[5]);
                add("phyobs", obs[5]);
        }
        public void eval_tech()
        {
            db.Connect();
            db.getData(db.select("technique", "", "jou=" + ID + " "));
            while (db.reader.Read())
            {
                note[0] = db.reader["jengelerie"].ToString();
                note[1] = db.reader["slalome"].ToString();
                note[2] = db.reader["controleBall"].ToString();
                note[3] = db.reader["total"].ToString();
            }
            db.Close();
            Val("genglNote", 0, false);
            Val("slaBallNote", 1, true);
            Val("cntBallNote", 2, false);
            Val("TechAll", 3, false);
                add("jonglerie", note[0]);
                add("sla", note[1]);
                add("cntball", note[2]);
                add("jonobs", obs[0]);
                add("slaobs", obs[1]);
                add("cntobs", obs[2]);
                add("tech", note[3]);
                add("techobs", obs[3]);
        }
        public void eval_morphy()
        {
            db.Connect();
            db.getData(db.select("morphologie", "", "jou=" + ID + " ")); 
            while (db.reader.Read())
            {
                note[0] = db.reader["taill"].ToString();
                note[1] = db.reader["poid"].ToString();
                note[2] = db.reader["total"].ToString();
                note[3] = db.reader["total"].ToString();
            }
            db.Close();
            Val("TaillNote", 0, false);
            Val("PoidNote", 1, false);
            Val("MorphNote", 2, false);
            Val("MorphNote", 3, false);
                add("tall", note[0]);
                add("poids", note[1]);
                add("imc", note[2]);
                add("tallobs", obs[0]);
                add("pdobs", obs[1]);
                add("imobs", obs[2]);
                add("mor", note[3]);
                add("morobs", obs[3]);
            //-------------------------------------
            db.Connect();
            db.getData(db.select("physiologique", "", "jou=" + ID + " "));
            while (db.reader.Read())
            {
                note[4] = db.reader["vo2max"].ToString();
            }
            db.Close();
            Val("VO2MAX", 4, false);
            note[5] = note[4];
            obs[5] = obs[4];
                add("voobs", obs[4]);
                add("vo2max", note[4]);
                add("phys", note[5]); 
                add("physobs", obs[5]);
        }
        public void TOTALS()
        {
            db.Connect();
            db.getData(db.select("joueur", "", "ID=" + ID + " "));
            Label val = new Label(), ob = new Label();
            while (db.reader.Read())
            {
                val.Text = db.reader["qualites"].ToString();
            }
            db.Close();
            add("total", val.Text);
            add("totalobs", ob.Text);
        } 
        public void save(Boolean ver = true)
        {
            ExitHandl = false;
            Object missing = Type.Missing;
            Object newName = @"C:\Users\MR.CPU\Documents\Visual Studio 2015\Projects\FootStat\FootStat\bin\Debug\fiches2.pdf";
            doc.SaveAs2(newName, WdSaveFormat.wdFormatPDF);
            doc.Close();
            if (ver == true) {
                var procs = new ProcessStartInfo(newName.ToString());
                Process proc = Process.Start(procs);
                bool found = false;
                for (int i = 0; i < 5; i++)
                {
                    if (!proc.HasExited)
                    {
                        proc.Refresh();
                        Thread.Sleep(10000);
                    }
                    else
                    {
                        found = true;
                        break;
                    }
                }
                proc.Close();
                if (found) {
                    File.Delete("fiches2.pdf");
                }
            }
            
        }

        
    }
}
