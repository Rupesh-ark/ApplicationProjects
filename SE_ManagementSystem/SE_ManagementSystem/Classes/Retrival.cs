using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SE_ManagementSystem
{
    internal class Retrival
    {
        private static AuthLevel auth = AuthLevel.None;
        private static string loginID;
        public static string LOGINID
        {
            get
            {
                return loginID;
            }
            private set
            {
                loginID = value;
            }
        }
        public static AuthLevel AUTH
        {
            get
            {
                return auth;
            }
            private set
            {
                auth = value;
            }
        }

        public static void GetCustomers(DataGridView dataGridView, DataGridViewColumn customerID, DataGridViewColumn customerName, DataGridViewColumn cusPass, DataGridViewColumn customerAddress, DataGridViewColumn customerNum)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spCustomer_GetAll", CentralControl.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                customerID.DataPropertyName = dt.Columns["customerID"].ToString();
                customerName.DataPropertyName = dt.Columns["customerName"].ToString();
                cusPass.DataPropertyName = dt.Columns["cusPass"].ToString();
                customerAddress.DataPropertyName = dt.Columns["customerAddress"].ToString();
                customerNum.DataPropertyName = dt.Columns["customerNum"].ToString();
                dataGridView.DataSource = dt;

                CentralControl.sNoInitiator(dataGridView, "sNO");
            }
            catch (Exception ex)
            {
                CentralControl.ShowMSG(ex.Message, "Error");
            }
        }

        public static void GetCompanies(DataGridView dataGridView, DataGridViewColumn companyID, DataGridViewColumn companyName, DataGridViewColumn companyType, DataGridViewColumn marketCapital, DataGridViewColumn yearEstablished, DataGridViewColumn seName)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spCompany_GetAll", CentralControl.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                companyID.DataPropertyName = dt.Columns["companyID"].ToString();
                companyName.DataPropertyName = dt.Columns["companyName"].ToString();
                companyType.DataPropertyName = dt.Columns["companyType"].ToString();
                marketCapital.DataPropertyName = dt.Columns["marketCapital"].ToString();
                yearEstablished.DataPropertyName = dt.Columns["yearEstablished"].ToString();
                seName.DataPropertyName = dt.Columns["seName"].ToString();

                dataGridView.DataSource = dt;
                CentralControl.sNoInitiator(dataGridView, "sNO");
            }
            catch (Exception ex)
            {
                CentralControl.ShowMSG(ex.Message, "Error");
            }
        }

        public static void GetBrokers(DataGridView dataGridView, DataGridViewColumn brokerID, DataGridViewColumn brokerName, DataGridViewColumn password, DataGridViewColumn commision, DataGridViewColumn seName)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spBroker_GetAll", CentralControl.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                brokerID.DataPropertyName = dt.Columns["brokerID"].ToString();
                brokerName.DataPropertyName = dt.Columns["brokerName"].ToString();
                password.DataPropertyName = dt.Columns["password"].ToString();
                commision.DataPropertyName = dt.Columns["commision"].ToString();
                seName.DataPropertyName = dt.Columns["seName"].ToString();

                dataGridView.DataSource = dt;
                CentralControl.sNoInitiator(dataGridView, "sNO");
            }
            catch (Exception ex)
            {
                CentralControl.ShowMSG(ex.Message, "Error");
            }
        }

        public static void GetShares(DataGridView dataGridView, DataGridViewColumn shareName, DataGridViewColumn companyID, DataGridViewColumn changeInPrice, DataGridViewColumn openingPrice, DataGridViewColumn volume, DataGridViewColumn holdingsCost, DataGridViewColumn holdingsQuantity)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spShares_GetAll", CentralControl.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                shareName.DataPropertyName = dt.Columns["shareName"].ToString();
                companyID.DataPropertyName = dt.Columns["companyID"].ToString();
                changeInPrice.DataPropertyName = dt.Columns["changeInPrice"].ToString();
                openingPrice.DataPropertyName = dt.Columns["openingPrice"].ToString();
                volume.DataPropertyName = dt.Columns["volume"].ToString();
                holdingsCost.DataPropertyName = dt.Columns["holdingsCost"].ToString();
                holdingsQuantity.DataPropertyName = dt.Columns["holdingsQuantity"].ToString();

                dataGridView.DataSource = dt;
                CentralControl.sNoInitiator(dataGridView, "sNO");
            }
            catch (Exception ex)
            {
                CentralControl.ShowMSG(ex.Message, "Error");
            }
        }

        public static void LoadItems(string proc, ComboBox comboBox, string displayMember, string valueMember)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, CentralControl.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox.DisplayMember = displayMember;
                comboBox.ValueMember = valueMember;
                comboBox.DataSource = dt;
            }
            catch (Exception ex)
            {
                CentralControl.ShowMSG(ex.Message, "Error");
            }
        }
        public static void LoadItems(string proc, ComboBox comboBox, string displayMember,string stParam,string paramToSupply, string valueMember)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, CentralControl.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(stParam, paramToSupply);
                CentralControl.con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox.DisplayMember = displayMember;
                comboBox.ValueMember = valueMember;
                comboBox.DataSource = dt;
                CentralControl.con.Close();
            }
            catch (Exception ex)
            {
                CentralControl.ShowMSG(ex.Message, "Error");
                CentralControl.con.Close();
            }
        }


        public static void LoadItem(Label label,string proc,string stParam,string paramToSupply,string columnName)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, CentralControl.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(stParam, paramToSupply);
                CentralControl.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    while(dr.Read())
                    {
                        label.Text = dr[columnName].ToString();
                    }
                }


                CentralControl.con.Close();
            }
            catch (Exception ex)
            {
                CentralControl.ShowMSG(ex.Message, "Error");
                CentralControl.con.Close();
            }


        }

        public static void LoadItem(string st, string proc, string stParam, string paramToSupply, string columnName)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, CentralControl.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(stParam, paramToSupply);
                CentralControl.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        st = dr[columnName].ToString();
                    }
                }


                CentralControl.con.Close();
            }
            catch (Exception ex)
            {
                CentralControl.ShowMSG(ex.Message, "Error");
                CentralControl.con.Close();
            }


        }


        public static bool IsValidUser(string user, string pass)
        {
            bool status = false;
            try
            {
                SqlCommand cmd = new SqlCommand("spAuthCred_GetSpecific", CentralControl.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userID", user);
                cmd.Parameters.AddWithValue("password", pass);
                CentralControl.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        if (user == dr["ID"].ToString() && pass == dr["password"].ToString())
                        {
                            AUTH = (AuthLevel)Convert.ToInt32((dr["AuthLevel"].ToString()));
                            LOGINID = dr["ID"].ToString();
                            status = true;
                        }
                        else
                            status = false;
                    }
                }
                else
                {
                    CentralControl.ShowMSG("Invalid username & password", "Error");
                    status = false;
                }

                CentralControl.con.Close();
            }
            catch (Exception ex)
            {
                CentralControl.ShowMSG(ex.Message, "Error");
                CentralControl.con.Close();
            }
            return status;
        }
    }
}