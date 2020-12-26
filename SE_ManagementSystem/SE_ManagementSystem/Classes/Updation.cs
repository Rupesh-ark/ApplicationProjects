using System;
using System.Data;
using System.Data.SqlClient;

namespace SE_ManagementSystem
{
    internal class Updation
    {
        public static void UpdateCustomer(string customerID, string customerName, string cusPass, string customerAddress, string customerNum)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spUpdateCustomers", CentralControl.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@customerID", customerID);
                cmd.Parameters.AddWithValue("@customerName", customerName);
                cmd.Parameters.AddWithValue("@cusPass", cusPass);
                cmd.Parameters.AddWithValue("@customerAddress", customerAddress);
                cmd.Parameters.AddWithValue("@customerNum", customerNum);
                CentralControl.con.Open();
                int res = cmd.ExecuteNonQuery();
                CentralControl.con.Close();
                if (res > 0)
                {
                    CentralControl.ShowMSG(customerID + " updated sucessfully into the system", "Success");
                }
            }
            catch (Exception ex)
            {
                CentralControl.con.Close();
                CentralControl.ShowMSG(ex.Message, "Error");
            }
        }

        public static void UpdateCompany(string companyID, string companyName, string companyType, int marketCapital, Int16 yearEstablished, string seName)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spUpdateCompanies", CentralControl.con);
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
                    CentralControl.ShowMSG(companyID + " updated sucessfully into the system", "Success");
                }
            }
            catch (Exception ex)
            {
                CentralControl.con.Close();
                CentralControl.ShowMSG(ex.Message, "Error");
            }
        }

        public static void UpdateBrokers(string brokerID, string brokerName, string password, Int64 commision, string seName)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spUpdateBrokers", CentralControl.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@brokerID", brokerID);
                cmd.Parameters.AddWithValue("@brokerName", brokerName);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@commision", commision);
                cmd.Parameters.AddWithValue("@seName", seName);
                CentralControl.con.Open();
                int res = cmd.ExecuteNonQuery();
                CentralControl.con.Close();
                if (res > 0)
                {
                    CentralControl.ShowMSG(brokerID + " updated sucessfully into the system", "Success");
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