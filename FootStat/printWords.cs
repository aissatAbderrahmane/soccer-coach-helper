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
using Microsoft.Office.Interop.Word;
using Label = System.Windows.Forms.Label;
using xc = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Tools.Excel;
using Spire.Xls;
using System.Runtime.InteropServices;

namespace FootStat
{
    class printWords
    {
        private string filep;
        private Document doc;
        private Application app = new Application();
        private bool ExitHandl;
        private int ID;
        private int ST = 0;
        private int NumeroTest = 1;
        private StoreData db = new StoreData();
        private string[] note = {"", "", "", "", "", "" }, obs = { "", "", "", "", "", "" };
        public printWords(string filename)
        {
            filep = filename;
        }
        public void init(int id, int Nt = 1)
        {
            app.Visible = false;
            var MSdoc = app.Documents.Open(filep, ReadOnly: false);
            
            doc = CopyToNewDocument(MSdoc);
            
            MSdoc.Close();
            
            ID = id;
            if (Nt != 1) NumeroTest = Nt;
            info();
            
        }
        private Document CopyToNewDocument(Document document)
        {
            document.StoryRanges[WdStoryType.wdMainTextStory].Copy();

            var newDocument = document.Application.Documents.Add();
            
            newDocument.StoryRanges[WdStoryType.wdMainTextStory].Paste();
            return newDocument;
        }

        public void info()
        {
            DateTime dat = DateTime.Now;
            Label vala = new Label(), oba = new Label();
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
                vala.Text = db.reader["qualites"].ToString();
            }
            db.Close();
            db.compare("totalNote", "Val", vala, oba, false);
            int.TryParse(vala.Text, out ST);
            add("name", note[0]);
            add("surname", note[3]);
            add("dateN", note[2]);
            add("addresse", note[5]);
            add("tels", note[4]);
            add("picJou", note[1],true);
            add("EvalDT", dat.ToString());
            //
            
        }
        public void Exc(int MAX,int cl,bool fn, xc.Application apx, xc.Worksheet wsh)
        {

            apx.Visible = false;
           
            wsh.Cells[1, 1] = "Nom";
            wsh.Columns[1].ColumnWidth = 14;
            
            wsh.Cells[1, 2] = "Prenom";
            wsh.Columns[2].ColumnWidth =16;
            wsh.Cells[1, 3] = "Age";
            wsh.Columns[3].ColumnWidth = 9;
            wsh.Cells[1, 4] = "Addresse";
            wsh.Columns[4].ColumnWidth = 13;
            wsh.Cells[1, 5] = "Tel";
            wsh.Columns[5].ColumnWidth = 16;
            wsh.Cells[1, 6] = "Date Naisance";
            wsh.Columns[6].ColumnWidth = 17;
            wsh.Cells[1, 7] = "Taille";
            wsh.Columns[7].ColumnWidth = 9;
            wsh.Cells[1, 8] = "Pois";
            wsh.Columns[8].ColumnWidth = 9;
            wsh.Cells[1, 9] = "IMC";
            wsh.Columns[9].ColumnWidth = 9;
            wsh.Cells[1, 10] = "Vitesse de reaction";
            wsh.Columns[10].ColumnWidth = 18;
            wsh.Cells[1, 11] = "Vitesse de course et changements de direction";
           
            wsh.Columns[11].ColumnWidth = 46;
            wsh.Cells[1, 12] = "Détente vertical (sergent)";
            wsh.Columns[12].ColumnWidth = 36;
            wsh.Cells[1, 13] = "Souplesse";
            wsh.Columns[13].ColumnWidth = 13;
            wsh.Cells[1, 14] = "Coordination neuromusculaire ";
            wsh.Columns[14].ColumnWidth = 36;
            wsh.Cells[1, 15] = "Jonglerie";
            wsh.Columns[15].ColumnWidth = 13;
            wsh.Cells[1, 16] = "Conduite de balle (Slalome)";
            wsh.Columns[16].ColumnWidth = 18;
            wsh.Cells[1, 17] = "Controlle de balle";
            wsh.Columns[17].ColumnWidth = 19;
            wsh.Cells[1, 18] = "Vo2max";
            wsh.Columns[18].ColumnWidth = 9;

                if (db.Exist("joueur", "ID=" + MAX + "") && db.Exist("physique", "jou=" + MAX + "") && db.Exist("technique", "jou=" + MAX + "")
                    && db.Exist("morphologie", "jou=" + MAX + "") && db.Exist("physiologique", "jou=" + MAX + "")
                    )
                { 
                    db.Connect();
                    db.getData(db.select("joueur", "", "ID=" + MAX + ""));
                    while (db.reader.Read())
                    {
                        wsh.Cells[cl, 1] = db.reader["nom"] ;
                        wsh.Cells[cl, 2] = db.reader["prenom"];
                        wsh.Cells[cl, 3] = db.reader["age"];
                        wsh.Cells[cl, 4] = db.reader["addresse"];
                        wsh.Cells[cl, 5] = db.reader["numero"];
                        wsh.Cells[cl, 6] = db.reader["daten"];
                    
                }
                    db.Close();
                    db.Connect();
                    db.getData(db.select("physique", "", "jou=" + MAX + " and nume="+ NumeroTest + " "));
                    while (db.reader.Read())
                    {
                        wsh.Cells[cl, 10] = db.reader["react"];
                        wsh.Cells[cl, 11] = db.reader["cours"];
                        wsh.Cells[cl, 12] = db.reader["serg"];
                        wsh.Cells[cl, 13] = db.reader["soupl"];
                        wsh.Cells[cl, 14] = db.reader["cord"];
                    }
                    db.Close();
                    db.Connect();
                    db.getData(db.select("technique", "", "jou=" + MAX + " and nume=" + NumeroTest + " "));
                    while (db.reader.Read())
                    {
                        wsh.Cells[cl, 15] = db.reader["jengelerie"];
                        wsh.Cells[cl, 16] = db.reader["slalome"];
                        wsh.Cells[cl, 17] = db.reader["controleBall"];
                    }
                    db.Close();
                    db.Connect();
                    db.getData(db.select("morphologie", "", "jou=" + MAX + " and nume=" + NumeroTest + " "));
                    while (db.reader.Read())
                    {
                        wsh.Cells[cl, 7] = db.reader["taill"];
                        wsh.Cells[cl, 8] = db.reader["poid"];
                        wsh.Cells[cl, 9] = db.reader["imc"];
                    }
                    db.Close();
                    db.Connect();
                    db.getData(db.select("physiologique", "", "jou=" + MAX + " and nume=" + NumeroTest + " "));
                    while (db.reader.Read())
                    {
                        wsh.Cells[cl, 18] = db.reader["vo2max"];
                    }
                    db.Close();
                
            }else wsh.Cells[cl, 1] = "Joueur N'exist Pas!";
            //wsh.Cells[cl,6].Style.VerticalAlignment = VerticalAlignType.Justify;
            //   CellStyle clz = apx.Sty
            if (fn == true)
            {
                wsh.get_Range("F1", "F30").Style.HorizontalAlignment = xc.XlHAlign.xlHAlignCenter;
                //wsh.Cells["F1", "F30"].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
                apx.Visible = true;
            }
        }
        public void add(string bookName, string bookVal, bool d = false)
        {
            if (doc.Bookmarks.Exists(bookName))
            {
                
                Object book = bookName;
                Range rang = doc.Bookmarks.get_Item(ref book).Range;
                rang.Text = (d==false) ? bookVal: "";
                Object NEWrng = rang;
                if(d == false) doc.Bookmarks.Add(bookName, ref NEWrng);
                else
                {
                    string pictureName = (File.Exists(@""+bookVal))? @"" + bookVal : @"C:/FootTest/" + bookVal;
                    var shp  = doc.Bookmarks[bookName].Range.InlineShapes.AddPicture( pictureName, false,true);
                    shp.Width = 100;
                    shp.Height = 100;

                    if (ST >= 44)
                    {
                        var Ashp = doc.Bookmarks["RefACT"].Range.InlineShapes.AddPicture(@"C:/FootTest/joueurs/Accept.png", false, true);
                        Ashp.Width = 100;
                        Ashp.Height = 100;
                    }
                    else {
                        var Rshp = doc.Bookmarks["RefACT"].Range.InlineShapes.AddPicture(@"C:/FootTest/joueurs/Refuser.png", false, true);
                        Rshp.Width = 100;
                        Rshp.Height = 100;
                    }
                    
                    
                }
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
        public void eval_phy(bool x = false)
        {
            db.Connect();
            db.getData(db.select("physique", "", "jou=" + ID + " and nume=" + NumeroTest + "  "));
            
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
            if (x == false) {
                Val("ReactNote", 0, true);
                Val("souplNote", 3, false);
                Val("CourNote", 1, true);
                Val("sergNote", 2, false);
                Val("coordNote", 4, true);
                Val("phyTotl", 5, false);
            }
                add("vreact", note[0]);
                add("vcourse", note[1]);
                add("sergent", note[2]);
                add("soupl", note[3]);
                add("cord", note[4]);
            if (x == false)  add("robs", obs[0]);
            if (x == false)  add("cobs", obs[1]);
            if (x == false)  add("seobs", obs[2]);
            if (x == false)  add("soobs", obs[3]);
            if (x == false)  add("corobs", obs[4]);
                add("phy", note[5]);
            if (x == false)  add("phyobs", obs[5]);
        }
        public void eval_tech(bool x = false)
        {//FootStat.Properties.Resources.flashpro
            db.Connect();
            db.getData(db.select("technique", "", "jou=" + ID + "  and nume=" + NumeroTest + " "));
            while (db.reader.Read())
            {
                note[0] = db.reader["jengelerie"].ToString();
                note[1] = db.reader["slalome"].ToString();
                note[2] = db.reader["controleBall"].ToString();
                note[3] = db.reader["total"].ToString();
            }
            db.Close();
            if (x == false) {
                Val("genglNote", 0, false);
                Val("slaBallNote", 1, true);
                Val("cntBallNote", 2, false);
                Val("TechAll", 3, false);
            }
                add("jonglerie", note[0]);
                add("sla", note[1]);
                add("cntball", note[2]);
            if (x == false)  add("jonobs", obs[0]);
            if (x == false)  add("slaobs", obs[1]);
            if (x == false)  add("cntobs", obs[2]);
                add("tech", note[3]);
            if (x == false)  add("techobs", obs[3]);
        }
        public void eval_morphy(bool x=false)
        {
            db.Connect();
            db.getData(db.select("morphologie", "", "jou=" + ID + " and nume=" + NumeroTest + "  ")); 
            while (db.reader.Read())
            {
                note[0] = db.reader["taill"].ToString();
                note[1] = db.reader["poid"].ToString();
                note[2] = db.reader["total"].ToString();
                note[3] = db.reader["total"].ToString();
            }
            db.Close();
            if (x == false) { 
            Val("TaillNote", 0, false);
            Val("PoidNote", 1, false);
            Val("MorphNote", 2, false);
            Val("MorphNote", 3, false);
            }
                add("tall", note[0]);
                add("poids", note[1]);
                add("imc", note[2]);
            if (x == false) add("tallobs", obs[0]);
            if (x == false) add("pdobs", obs[1]);
            if (x == false) add("imobs", obs[2]);
                add("mor", note[3]);
            if (x == false) add("morobs", obs[3]);
            //-------------------------------------
            db.Connect();
            db.getData(db.select("physiologique", "", "jou=" + ID + "  and nume=" + NumeroTest + " "));
            while (db.reader.Read())
            {
                note[4] = db.reader["vo2max"].ToString();
            }
            db.Close();
           if(x == false) Val("VO2MAX", 4, false);
            note[5] = note[4];
            obs[5] = obs[4];
            if (x == false) add("voobs", obs[4]);
                add("vo2max", note[4]);
                add("phys", note[5]);
            if (x == false) add("physobs", obs[5]);
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
            db.compare("totalNote", "Val", val, ob, false);
            add("total", val.Text);
            add("totalobs", ob.Text);
        } 
        public void save(Boolean ver = true)
        {
            ExitHandl = false;
            Object missing = Type.Missing;
            Object newName = @"C:/FootTest/Fiches/fiches"+ID+".pdf";
            if (File.Exists(newName.ToString())) 
                File.Delete(newName.ToString());
                doc.SaveAs(newName, WdSaveFormat.wdFormatPDF);
            doc.Close(false,false,false);
            app.Quit();
            Marshal.ReleaseComObject(doc);
            Marshal.ReleaseComObject(app);
            //ReleaseComObjects();
            if (ver == true) {
                var procs = new ProcessStartInfo(newName.ToString());
                Process proc = Process.Start(procs);
            }
           
             
        }
        private void ReleaseComObjects(bool isQuitting)
        {
            try
            {
                if (isQuitting)
                {
                    doc.Close(false, false, false);
                    app.Quit();
                }
                Marshal.ReleaseComObject(doc);
                Marshal.ReleaseComObject(app);
                doc = null;
                app = null;
            }
            catch { }
            finally { GC.Collect(); }
        }

        private void ReleaseComObjects()
        {
            ReleaseComObjects(false);
        }


    }
}
