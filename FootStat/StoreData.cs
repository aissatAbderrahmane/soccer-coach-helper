using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Data.SQLite;
namespace FootStat
{

     
    public class StoreData
    {
        private SQLiteConnection cnt;
        public SQLiteCommand cmd;
        public SQLiteDataReader reader = null;
        private string dbs;
        private double com1 = 0, comp2 = 0, comp3 = 0;
        public StoreData()
        {
            cnt = new SQLiteConnection("Data Source =C:/FootTest/FootTest.drf; Version = 3;");
        }
        public void Connect()
        {
            if (cnt.State == ConnectionState.Open) cnt.Close();
            cnt.Open();
        }
        public string create(string table, string rows, bool b = false)
        {
            string Command;
            string ise = (b) ? " " : "ID INTEGER PRIMARY KEY AUTOINCREMENT,";
            Command = (table != "" && rows != "") ? "create table " + table + " (" + ise + " " + rows + ");" : null;
            return Command;
        }
        public string select(string table, string rows = "", string where = "")
        {
            string Command;
            rows = (rows != "") ? "select " + rows + " from " + table : "select * from " + table;
            where = (where != "") ? " where " + where : "";
            Command = rows + where;
            return Command;
        }

        public string insert(string table, string speci, string rows)
        {
            string Command;

            Command = "insert into " + table + " (" + speci + ")  values (" + rows + ") ";
            if (speci == "") Command = "insert into " + table + "   values (" + rows + ") ";
            return Command;
        }
        public string update(string table, string rowsupdate, string where)
        {
            string Command;
            Command = "update " + table + " set " + rowsupdate + " where " + where;
            return Command;
        }
        public string delete(string table, string where)
        {
            string Command;
            Command = "delete from " + table + " where " + where + " ";
            return Command;
        }
        public void exec(string CMD)
        {
            cmd = new SQLiteCommand(CMD, cnt);
            cmd.ExecuteNonQuery();
        }
        public int ID(string table)
        {
            Connect();
            cmd.CommandText = select(table,"MAX(ID)");

            int id = Convert.ToInt32(cmd.ExecuteScalar());//here
            Close();
            return id;
        }
        public void Close()
        {
            
            if (reader != null) reader.Close();
            cnt.Close();
            
        }
        public void getData(string select)
        {
            exec(select);
            reader = cmd.ExecuteReader();
        }

        public Boolean Exist(string table, string value)
        {
            Connect();
            int cnte = 0;
            
            cmd = new SQLiteCommand(select(table, "", value), cnt); 
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cnte++;
            }
            Close();
            if (cnte == 1) return true;
            return false;
        }
        public void avInsert(string CMD, String[] param, String[] val)
        {
            Connect();
            cmd = new SQLiteCommand(CMD, cnt);
            double num;
            for (int i = 0; i < param.Length; i++)
            {
                double.TryParse(val[i], out num);
                cmd.Parameters.AddWithValue(param[i], num);
            }
            cmd.ExecuteNonQuery();
            Close();
        }
        public System.Data.DataTable table(string table, string wh = "")
        {

            exec(select(table, "", wh));
            System.Data.DataTable dtTable = new System.Data.DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dtTable);
            return dtTable;

        }
        public string drop(string tbl)
        {
            string Command;
            Command = "DROP TABLE " + tbl;
            return Command;
        }
        public void ADD(string tb, System.Data.DataTable table)
        {
            var sqliteAdapter = new SQLiteDataAdapter("SELECT * FROM " + tb, cnt);
            var cmdBuilder = new SQLiteCommandBuilder(sqliteAdapter);
            sqliteAdapter.Update(table);
        }
        public int nume(string table, string IDse)
        {
            
            int n = 0;
            Connect();
            getData(select(table, "", "jou=" + IDse + ""));
            while (reader.Read())
            {
                n++;
            }
            Close();
            return n;
        }
        public void compare(string table, string row, System.Windows.Forms.Label ToParse, System.Windows.Forms.Label obs, bool up)
        {
            Connect();
            getData(select(table));
            double.TryParse(ToParse.Text.ToString(), out com1);
            int i = 1, max = 1;
            double grd;

            while (reader.Read())
            {
                double.TryParse(reader[row].ToString(), out grd);
                if (reader[row].ToString() == ToParse.Text.ToString() || (up == true && com1 < grd) || (up == false && grd < com1))
                {
                    ToParse.Text = reader["Note"].ToString();
                    if (reader["Observ"].ToString() == "Tré Bien")
                        obs.Text = "Trés Bien";
                    else if(reader["Observ"].ToString() == "Tré Faible")
                        obs.Text = "Trés Faible";
                    else
                        obs.Text = reader["Observ"].ToString();
                    break;
                }
                else
                {
                    if (i == 1)
                    {
                        double.TryParse(reader[row].ToString(), out comp2);
                        if ((up == true && comp3 != 0 && (com1 < comp2 && comp3 <= com1)) || (up == false && comp3 != 0 && (comp2 < com1 && com1 <= comp3)))
                        {
                            ToParse.Text = reader["Note"].ToString();
                            obs.Text = reader["Observ"].ToString();
                            break;
                        }
                        i++;
                        max++;
                    }
                    else if (i == 2)
                    {
                        double.TryParse(reader[row].ToString(), out comp3);
                        if ((up == true && com1 < comp3 && comp2 <= com1) || (up == true && comp3 < com1 && com1 <= comp2))
                        {
                            ToParse.Text = reader["Note"].ToString();
                            obs.Text = reader["Observ"].ToString();
                            break;
                        }
                        i = 1;
                        max++;
                    }
                    if (max == 62)
                    {
                        ToParse.Text = reader["Note"].ToString();
                        obs.Text = reader["Observ"].ToString();
                        break;
                    }


                }

            }
            Close();
        }
        public void somme(System.Windows.Forms.Label val, double[] somes, System.Windows.Forms.Label obs)
        {
            double some = 0;
            int i;
            for (i = 0; i < somes.Length; i++)
            {
                some += somes[i];
            }
            some = (int)some / i;
            val.Text = some.ToString();
            if (some <= 80 && some >= 68)
            {
                obs.Text = "Trés Bien";
            }
            else if (some < 68 && some >= 56)
            {
                obs.Text = " Bien";
            }
            else if (some < 56 && some >= 44)
            {
                obs.Text = "Moyen";
            }
            else if (some < 44 && some >= 32)
            {
                obs.Text = "Faible";
            }
            else if (some < 32)
            {
                obs.Text = "Tré Faible";
            }
        }
        public Boolean empty(string table)
        {
            Connect();
            getData(select(table));
            if (reader.HasRows)
            {
                Close();
                return false;
            }
            Close();
            return true;
        }
        public String Caliter(int tp)
        {
            if (tp == 1)
                return " qualites >= 630.385 ";
            else if(tp == 2)
                return " qualites >= 576.795 and qualites < 630.385 ";
            else if(tp == 3)
                return " qualites >= 523.204 and qualites < 576.795 ";
            else if(tp == 4)
                return " qualites >= 469.614 and qualites < 523.204 ";
            else if(tp == 5)
                return  " qualites < 469.614 ";
            return "";
        }
        public string CaliterToString(int tp)
        {

            if (tp == 1)
                return "qualites >= 630.385 ";
            else if (tp == 2)
                return "qualites >= 576.795 and qualites < 630.385 ";
            else if (tp == 3)
                return "qualites >= 523.204 and qualites < 576.795 ";
            else if (tp == 4)
                return "qualites >= 469.614 and qualites < 523.204 ";
            else if (tp == 5)
                return "qualites < 469.614 ";
            return "";
        }
    }
}


