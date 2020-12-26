using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_ManagementSystem
{
    class Insertion
    {
        public static void InsertCustomers(string customerID,string customerName,string cusPass,string customerAddress,string customerNum)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spInsertCustomers", CentralControl.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@customerID", customerID);
                cmd.Parameters.AddWithValue("@customerName", customerName);
                cmd.Parameters.AddWithValue("@cusPass", cusPass);
                cmd.Parameters.AddWithValue("@customerAddress", customerAddress);
                cmd.Parameters.AddWithValue("@customerNum", customerNum);
                CentralControl.con.Open();
                int res = cmd.ExecuteNonQuery();
                CentralControl.con.Close();
                if(res>0)
                {
                    CentralControl.ShowMSG(customerID + " added sucessfully into the system", "Success");
                }
            }
            catch(Exception ex)
            {
                CentralControl.con.Close();
                CentralControl.ShowMSG(ex.Message, "Error");
            }
        }

        public static void InsertCompanies(string companyID,string companyName,string companyType,int marketCapital,Int16 yearEstablished,string seName)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spInsertCompany", CentralControl.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@companyID", companyID);
                cmd.Parameters.AddWithValue("@companyName", companyName);
                cmd.Parameters.AddWithValue("@companyType", companyType);
                cmd.Parameters.AddWithValue("@marketCapital", marketCapital);
                cmd.Parameters.AddWithValue("@yearEstablished", yearEstablished);
                cmd.Parameters.AddWithValue("@seName", seName);
                CentralControl.con.Open();
                int res = cmd.ExecuteNonQuery();
                CentralControl.con.Close();
                if (res > 0)
                {
                    CentralControl.ShowMSG(companyID + " added sucessfully into the system", "Success");
                }
            }
            catch (Exception ex)
            {
                CentralControl.con.Close();
                CentralControl.ShowMSG(ex.Message, "Error");
            }
        }

        public static void InsertBrokers(string brokerID, string brokerName, string password, Int64 commision, string seName)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spInsertBrokers", CentralControl.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@brokerID", brokerID);
                cmd.Parameters.AddWithValue("@brokerName", brokerName);
                cmd.Parameters.AddWithValue("@brokerPass", password);
                cmd.Parameters.AddWithValue("@commision", commision);
                cmd.Parameters.AddWithValue("@seName", seName);
                CentralControl.con.Open();
                int res = cmd.ExecuteNonQuery();
                CentralControl.con.Close();
                if (res > 0)
                {
                    CentralControl.ShowMSG(brokerID + " added sucessfully into the system", "Success");
                }
            }
            catch (Exception ex)
            {
                CentralControl.con.Close();
                CentralControl.ShowMSG(ex.Message, "Error");
            }
        }

    }
}
