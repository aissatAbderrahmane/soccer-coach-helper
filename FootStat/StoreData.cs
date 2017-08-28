using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FootStat
{

    public class StoreData
    {
        public OleDbConnection connect = new OleDbConnection();
        public OleDbCommand cmd;
        public OleDbDataReader reader = null;
        double com1 = 0, comp2 = 0, comp3 = 0;
        public void Connect()
        {
            try
            {
                connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source =C:\Users\MR.CPU\Documents\Visual Studio 2015\Projects\FootStat\FootStat\bin\Debug\database.accdb";
                connect.Open();
                cmd = connect.CreateCommand();
                cmd.CommandType = CommandType.Text;
            }
            catch (Exception exp)
            {
            }
        }
        public string select(string table, string rows = "", string where = "")
        {
            string Command;
            rows = (rows != "") ? "select " + rows + " from " + table : "select * from " + table;
            where = (where != "") ? " where " + where : "";
            Command = rows + where;
            return Command;
        }
        public string insert(string table,string speci, string rows)
        {
            string Command;
            
            Command = "insert into " + table  + " ("+speci+")  values (" + rows + ") ";
            if(speci == "") Command = "insert into " + table + "   values (" + rows + ") ";
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
            

            cmd.CommandText = CMD;
            cmd.ExecuteNonQuery();
        }

        public void Close()
        {
            if(reader != null) reader.Close();
            connect.Close();
            
        }
        public DataTable table(string table,string wh = "")
        {
           
                exec(select(table,"",wh));
                DataTable dtTable = new DataTable();
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dtTable);
                return dtTable;
            
        }
        public int nume(string table,string IDse)
        {
            int n = 0;
            getData(select(table,"","jou="+IDse+""));
            while (reader.Read())
            {
                n++;
            }
            reader.Close();
            return n;
        }
        public int ID(string table)
        {
            Connect();
            cmd.CommandText = select(table, " last(ID) ");
            int id = (int)cmd.ExecuteScalar();
            Close();
            return id;
        }
        public void getData(string select)
        {
            exec(select);
            reader = cmd.ExecuteReader();
        }
        public Boolean Exist(string table,string value)
        {
            
                int cnt = 0;
            Connect();
               cmd.CommandText = select(table, "", value);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cnt++;
                }
            reader.Close();
                Close();

                if (cnt == 1) return true;
            return false;
        }
        public void avInsert(string CMD,String[] param,String[] val)
        {
            Connect();
            cmd.CommandText = CMD;
            double num;
            for (int i = 0; i <param.Length;i++) {
                double.TryParse(val[i], out num);
            cmd.Parameters.AddWithValue(param[i], num);
            }
            cmd.ExecuteNonQuery();
            Close();
        }
        public void compare(string table, string row, Label ToParse , Label obs,bool up)
        {
            Connect();
            getData(select(table));
            double.TryParse(ToParse.Text.ToString(), out com1);
            int i = 1,max = 1;
            double grd;
           
            while (reader.Read())
            {
                double.TryParse(reader[row].ToString(), out grd);
                if (reader[row].ToString() == ToParse.Text.ToString() || (up == true && com1 < grd) || (up == false && grd < com1))
                {
                    ToParse.Text = reader["Note"].ToString();
                    obs.Text = reader["Observ"].ToString();
                    break;
                }else
                {
                    if (i == 1)
                    {
                        double.TryParse(reader[row].ToString(), out comp2);
                        if ( (up == true && comp3 != 0 && (com1 < comp2 && comp3 <= com1)) || (up == false && comp3 != 0 && (comp2 < com1 && com1 <= comp3)))
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
            for ( i = 0; i<somes.Length;i++)
            {
                some += somes[i];
            }
            some = (int)some / i;
            val.Text =  some.ToString();
            if (some <=80 && some >=68)
            {
                obs.Text = "Tré Bien";
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

    }
}


