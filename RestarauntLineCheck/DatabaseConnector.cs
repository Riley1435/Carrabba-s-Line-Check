using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RestarauntLineCheck
{
   class DatabaseConnector
   {
      private string connstr = "STRING FROM QUERY GOES HERE";
      private string appearance;
      private string taste;
      private string temp;
      private string present;
      public DatabaseConnector()
      {
         appearance = "X";
         taste = "X";
         temp = "X";
         present = "X";
      }
      public string Appearance
      {
         get
         {
            return appearance;
         }
         set
         {
            appearance = value;
         }
      }
      public string Taste
      {
         get
         {
            return taste;
         }
         set
         {
            taste = value;
         }
      }
      public string Temp
      {
         get
         {
            return temp;
         }
         set
         {
            temp = value;
         }
      }
      public string Present
      {
         get
         {
            return present;
         }
         set
         {
            present = value;
         }
      }
      public void InsertLineCheck(string cmdName, string date, string food, string user)
      {            
            SqlConnection conn = new SqlConnection(connstr);
            SqlCommand cmdInsert = new SqlCommand(cmdName, conn);
            cmdInsert.CommandType = CommandType.StoredProcedure;
            cmdInsert.Parameters.Add(new SqlParameter("@_Date", SqlDbType.DateTime));
            cmdInsert.Parameters["@_Date"].Value = date;
            cmdInsert.Parameters.Add(new SqlParameter("@Food", SqlDbType.NVarChar));
            cmdInsert.Parameters["@Food"].Value = food;
            cmdInsert.Parameters.Add(new SqlParameter("@Appearance", SqlDbType.NVarChar));
            cmdInsert.Parameters["@Appearance"].Value = appearance;
            cmdInsert.Parameters.Add(new SqlParameter("@Taste", SqlDbType.NVarChar));
            cmdInsert.Parameters["@Taste"].Value = taste;
            cmdInsert.Parameters.Add(new SqlParameter("@Temp", SqlDbType.NVarChar));
            cmdInsert.Parameters["@Temp"].Value = temp;
            cmdInsert.Parameters.Add(new SqlParameter("@Username", SqlDbType.NVarChar));
            cmdInsert.Parameters["@Username"].Value = user;
         try
         {
            conn.Open();
            cmdInsert.ExecuteNonQuery();
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.ToString());
         }
         finally
         {
            conn.Close();
         }
      }
      public void InsertLineCheckMisc(string cmdName, string date, string equipment, string user)
      {
         SqlConnection conn = new SqlConnection(connstr);
         SqlCommand cmdInsert = new SqlCommand(cmdName, conn);
         cmdInsert.CommandType = CommandType.StoredProcedure;
         cmdInsert.Parameters.Add(new SqlParameter("@_Date", SqlDbType.DateTime));
         cmdInsert.Parameters["@_Date"].Value = date;
         cmdInsert.Parameters.Add(new SqlParameter("@Equipment", SqlDbType.NVarChar));
         cmdInsert.Parameters["@Equipment"].Value = equipment;
         cmdInsert.Parameters.Add(new SqlParameter("@Present", SqlDbType.NVarChar));
         cmdInsert.Parameters["@Present"].Value = present;
         cmdInsert.Parameters.Add(new SqlParameter("@Username", SqlDbType.NVarChar));
         cmdInsert.Parameters["@Username"].Value = user;
         try
         {
            
            conn.Open();
            cmdInsert.ExecuteNonQuery();
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.ToString());
         }
         finally
         {
            conn.Close();
         }
      }
      public void UpdateLineCheck(string tblName, string date, string food, string user)
      {
          SqlConnection conn = new SqlConnection(connstr);
          SqlCommand cmdUpdate = new SqlCommand("[LineCheck].[uspUpdate" + tblName + "]", conn);
          cmdUpdate.CommandType = CommandType.StoredProcedure;
          cmdUpdate.Parameters.Add(new SqlParameter("@_Date", SqlDbType.DateTime));
          cmdUpdate.Parameters["@_Date"].Value = date;
          cmdUpdate.Parameters.Add(new SqlParameter("@Food", SqlDbType.NVarChar));
          cmdUpdate.Parameters["@Food"].Value = food;
          cmdUpdate.Parameters.Add(new SqlParameter("@Appearance", SqlDbType.NVarChar));
          cmdUpdate.Parameters["@Appearance"].Value = appearance;
          cmdUpdate.Parameters.Add(new SqlParameter("@Taste", SqlDbType.NVarChar));
          cmdUpdate.Parameters["@Taste"].Value = taste;
          cmdUpdate.Parameters.Add(new SqlParameter("@Temp", SqlDbType.NVarChar));
          cmdUpdate.Parameters["@Temp"].Value = temp;
          cmdUpdate.Parameters.Add(new SqlParameter("@Username", SqlDbType.NVarChar));
          cmdUpdate.Parameters["@Username"].Value = user;
          try
          {
              conn.Open();
              cmdUpdate.ExecuteNonQuery();
          }
          catch(Exception ex)
          {
              MessageBox.Show(ex.ToString());
          }
          finally
          {
              conn.Close();
          }
      }
      public void UpdateMisc(string tblName, string date, string equipment, string user)
      {
         SqlConnection conn = new SqlConnection(connstr);
         SqlCommand cmdUpdate = new SqlCommand("[LineCheck].[uspUpdate" + tblName + "]", conn);
         cmdUpdate.CommandType = CommandType.StoredProcedure;
         cmdUpdate.Parameters.Add(new SqlParameter("@_Date", SqlDbType.DateTime));
         cmdUpdate.Parameters["@_Date"].Value = date;
         cmdUpdate.Parameters.Add(new SqlParameter("@Equipment", SqlDbType.NVarChar));
         cmdUpdate.Parameters["@Equipment"].Value = equipment;
         cmdUpdate.Parameters.Add(new SqlParameter("@Present", SqlDbType.NVarChar));
         cmdUpdate.Parameters["@Present"].Value = present;
         cmdUpdate.Parameters.Add(new SqlParameter("@Username", SqlDbType.NVarChar));
         cmdUpdate.Parameters["@Username"].Value = user;
         try
         {
            conn.Open();
            cmdUpdate.ExecuteNonQuery();
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.ToString());
         }
         finally
         {
            conn.Close();
         }
      }

      public void SelectBad(string cmdName, string date, DataGridView dataGridView)
      {
         SqlConnection conn = new SqlConnection(connstr);
         try
         {
            conn.Open();
            using (SqlCommand cmdSelect = new SqlCommand("[LineCheck].[uspSelect" + cmdName + "]", conn))
            {
               cmdSelect.CommandType = CommandType.StoredProcedure;
               cmdSelect.Parameters.Add(new SqlParameter("@_Date", SqlDbType.DateTime));
               cmdSelect.Parameters["@_Date"].Value = date;
               SqlDataAdapter sda = new SqlDataAdapter();
               sda.SelectCommand = cmdSelect;
               DataTable dt = new DataTable();
               sda.Fill(dt);
               BindingSource bSource = new BindingSource();
               bSource.DataSource = dt;
               dataGridView.DataSource = bSource;
               sda.Update(dt);
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.ToString());
         }
         finally
         {
            conn.Close();
         }
      }

      public List<FoodData> SelectXmlFood(string dateMin, string dateMax)
      {
         List<FoodData> foods = new List<FoodData>();
         SqlConnection conn = new SqlConnection(connstr);
         try
         {
            conn.Open();
            using (SqlCommand cmdSelect = new SqlCommand("[LineCheck].[uspSelectAllFood]", conn))
            {
               cmdSelect.CommandType = CommandType.StoredProcedure;
               cmdSelect.Parameters.Add(new SqlParameter("@_DateMin", SqlDbType.DateTime));
               cmdSelect.Parameters["@_DateMin"].Value = dateMin;
               cmdSelect.Parameters.Add(new SqlParameter("@_DateMax", SqlDbType.DateTime));
               cmdSelect.Parameters["@_DateMax"].Value = dateMax;
               SqlDataReader reader = cmdSelect.ExecuteReader();
               while (reader.Read())
               {
                  FoodData f = new FoodData();
                  f._Date = reader["_Date"].ToString();
                  f.Food = (string)reader["Food"];
                  f.Appearance = (string)reader["Appearance"];
                  f.Taste = (string)reader["Taste"];
                  f.Temp = (string)reader["Temp"];
                  f.Username = (string)reader["Username"];
                  foods.Add(f);
               }
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.ToString());
         }
         finally
         {
            conn.Close();
            
         }
         return foods;
      }

        public List<FoodData> SelectXmlMisc(string dateMin, string dateMax)
        {
            List<FoodData> miscs = new List<FoodData>();
            SqlConnection conn = new SqlConnection(connstr);
            try
            {
                conn.Open();
                using (SqlCommand cmdSelect = new SqlCommand("[LineCheck].[uspSelectAllMisc]", conn))
                {
                    cmdSelect.CommandType = CommandType.StoredProcedure;
                    cmdSelect.Parameters.Add(new SqlParameter("@_DateMin", SqlDbType.DateTime));
                    cmdSelect.Parameters["@_DateMin"].Value = dateMin;
                    cmdSelect.Parameters.Add(new SqlParameter("@_DateMax", SqlDbType.DateTime));
                    cmdSelect.Parameters["@_DateMax"].Value = dateMax;
                    SqlDataReader reader = cmdSelect.ExecuteReader();
                    while (reader.Read())
                    {
                        FoodData m = new FoodData();
                        m._Date = reader["_Date"].ToString();
                        m.Equipment = (string)reader["Equipment"];
                        m.Present = (string)reader["Present"];
                        m.Username = (string)reader["Username"];
                        miscs.Add(m);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();

            }
            return miscs;
        }
        public void CreateXmlFileFood(string dateMin, string dateMax, string username, List<FoodData> foodData)
      {
         try
         {
            string path = Application.StartupPath;
            XmlTextWriter fileWriter = new XmlTextWriter(path + "_" + @username + "Food.xml", null);
            fileWriter.Formatting = Formatting.Indented;
            fileWriter.WriteStartDocument();
            fileWriter.WriteStartElement(dateMin + "-" + dateMax);

            foreach (FoodData food in foodData)
            {
               fileWriter.WriteElementString("_Date", food._Date.ToString());
               fileWriter.WriteElementString("Food", food.Food.ToString());
               fileWriter.WriteElementString("Appearance", food.Appearance.ToString());
               fileWriter.WriteElementString("Taste", food.Taste.ToString());
               fileWriter.WriteElementString("Temp", food.Temp.ToString());
               fileWriter.WriteElementString("Username", food.Username.ToString());
            }
            fileWriter.WriteEndElement();
            fileWriter.WriteEndDocument();
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.ToString());
         }
         MessageBox.Show("XML Report created Successfully.");
      }
        public void CreateXmlFileMisc(string dateMin, string dateMax, string username, List<FoodData> foodData)
        {
            try
            {
                string path = Application.StartupPath;
                XmlTextWriter fileWriter = new XmlTextWriter(path + "_" + @username + "Misc.xml", null);
                fileWriter.Formatting = Formatting.Indented;
                fileWriter.WriteStartDocument();
                fileWriter.WriteStartElement(dateMin + "-" + dateMax);

                foreach (FoodData food in foodData)
                {
                    fileWriter.WriteElementString("_Date", food._Date.ToString());
                    fileWriter.WriteElementString("Equipment", food.Equipment.ToString());
                    fileWriter.WriteElementString("Present", food.Present.ToString());
                    fileWriter.WriteElementString("Username", food.Username.ToString());
                }
                fileWriter.WriteEndElement();
                fileWriter.WriteEndDocument();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            MessageBox.Show("XML Report created Successfully.");
        }
        //
        //Primay key check if record exists
        //
        public bool LineCheckExists(string date)
      {
         bool result = false;
         SqlConnection conn = new SqlConnection(connstr);
         try
         {
            string cmdSelect = "SELECT * FROM [LineCheck].[PizzaFood] WHERE _Date='" + date + "'";
            SqlCommand sqlCheck = new SqlCommand(cmdSelect, conn);
            conn.Open();
            SqlDataReader reader = sqlCheck.ExecuteReader();

            if (reader.Read())
               result = true;
         }
         catch
         {
            MessageBox.Show("Cannot Read Database");
         }
         finally
         {
            conn.Close();
         }
         return result;
      }

   }
}
