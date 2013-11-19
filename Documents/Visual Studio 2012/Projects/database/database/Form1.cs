using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            gagnagrunnur ma = new gagnagrunnur();

            //ma.update(1,"Villi",1,0,"rauður","Villi");
            MessageBox.Show(ma.select_from());
            
            InitializeComponent();
        } 
    }
}

 public class gagnagrunnur
 {
     /*
      * fjoldi_rada();
      * segir til um hversu oft á að keyra lykkjuna.
      * 
      * 
      * select_from();
      *              
             string[] fylki;
             fylki = rowText.Split('-');
      * 
      * og síðan
      * 
      *      string[] fylki;
             fylki = rowText.Split('|');
      * 
      * 
      * ATH. á eftir að setja rétta tölu á númer_spilara í update()
      * 
      */


     public void insert_into(string nafn,int checkpoint,int stig,string litur,string lykilorð)
     {
         MySqlConnection connection;

         string connectionString = "Server=10.0.105.33;Database=Leikur;Uid=first;Pwd=first;";

         connection = new MySqlConnection(connectionString);

         connection.Open();

         string query = "INSERT INTO spilari(nafn, checkpoint, stig, litur, lykilord) VALUES('"+nafn+"',"+checkpoint+","+stig+",'"+litur+"','"+lykilorð+"')";

         MySqlCommand queryCommand = new MySqlCommand(query, connection);

         queryCommand.ExecuteNonQuery();

         connection.Close();
     }

     public int fjöldi_rada()
     {
         MySqlConnection connection;

         string connectionString = "Server=10.0.105.33;Database=Leikur;Uid=first;Pwd=first;";

         connection = new MySqlConnection(connectionString);

         connection.Open();

         string query = @"SELECT * FROM spilari";
         MySqlCommand cmd = new MySqlCommand(query, connection);

         cmd.ExecuteNonQuery();

         MySqlDataReader queryCommandReader = cmd.ExecuteReader();

         DataTable dataTable = new DataTable();
         dataTable.Load(queryCommandReader);

         MySqlDataAdapter adapter = new MySqlDataAdapter();
         DataSet ds = new DataSet();
         adapter.SelectCommand = cmd;
         adapter.Fill(ds, "SQL Temp Table");
         adapter.Dispose();
         cmd.Dispose();

         return ds.Tables[0].Rows.Count;
     }

     public string select_from()
     {
         MySqlConnection connection;

         string connectionString = "Server=10.0.105.33;Database=Leikur;Uid=first;Pwd=first;";

         connection = new MySqlConnection(connectionString);

         connection.Open();

         string query = @"SELECT * FROM spilari";
         MySqlCommand cmd = new MySqlCommand(query, connection);

         cmd.ExecuteNonQuery();

         MySqlDataReader queryCommandReader = cmd.ExecuteReader();

         DataTable dataTable = new DataTable();
         dataTable.Load(queryCommandReader);

         MySqlDataAdapter adapter = new MySqlDataAdapter();
         DataSet ds = new DataSet();
         adapter.SelectCommand = cmd;
         adapter.Fill(ds, "SQL Temp Table");
         adapter.Dispose();
         cmd.Dispose();

         String rowText = string.Empty;
         int topRows = ds.Tables[0].Rows.Count;
         for (int i = 0; i < topRows; i++)
         {
             
             foreach (DataColumn column in dataTable.Columns)
             {
                 rowText += dataTable.Rows[i][column.ColumnName] + "|";
             }
             rowText = rowText + "-"; 
         }
          
         connection.Close();
         return rowText;
     }

     public void update(int numer_spilara,string nafn, int checkpoint, int stig, string litur, string lykilorð)
     {
         MySqlConnection connection;

         string connectionString = "Server=10.0.105.33;Database=Leikur;Uid=first;Pwd=first;";

         connection = new MySqlConnection(connectionString);

         connection.Open();

         string query = "UPDATE spilari SET nafn='"+nafn+"',checkpoint="+checkpoint+",stig="+stig+",litur='"+litur+"',lykilord='"+lykilorð+"' WHERE numer_spilara="+numer_spilara+"; ";

         MySqlCommand queryCommand = new MySqlCommand(query, connection);

         queryCommand.ExecuteNonQuery();

         connection.Close(); 
     }
 }
