using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOG_MOUNTER_FUJI
{
    class ConnectDB
    {
        public SqlConnection ConnectionDB()
        {
            var appSettings = ConfigurationManager.AppSettings;

            string ServerIP;
            string DataBase;
            string User;
            string PW;

            ServerIP = appSettings.Get("Server1");
            DataBase = appSettings.Get("DBNane1");
            User = appSettings.Get("User1");
            PW = appSettings.Get("PW1");

            try
            {
                string PoolSize = appSettings.Get("PoolSize");
                string Timeout = appSettings.Get("Timeout");
                string connetionString;
                SqlConnection cnn;
                connetionString = @"Data Source=" + ServerIP + ";"
                                + "Initial Catalog=" + DataBase + ";"
                                + "User ID=" + User + ";"
                                + "Password=" + PW + ";"
                                + "Max Pool Size=" + PoolSize + ";"
                                + "Connect Timeout=" + Timeout + ";";
                cnn = new SqlConnection(connetionString);
                return cnn;
            }
            catch
            {
                SqlConnection cnn;
                cnn = new SqlConnection();
                return cnn;
            }
        }
        public string STBL_MOUNTER_HEADER(string ProgramName, string PanelID, string Time, string MachineName, string LineName)
        {
            try
            {
                SqlConnection cnn = ConnectionDB();
                SqlCommand objCmd = new SqlCommand();
                SqlDataAdapter dtAdapter = new SqlDataAdapter();

                DataSet ds = new DataSet();
                DataTable dt;
                string strStored;
                string Result;
                using (cnn)
                {
                    strStored = "STBL_MOUNTER_HEADER";
                    objCmd.Parameters.Add(new SqlParameter("@vProgramName", ProgramName));
                    objCmd.Parameters.Add(new SqlParameter("@vPanelID", PanelID));
                    objCmd.Parameters.Add(new SqlParameter("@vTime", Time));
                    objCmd.Parameters.Add(new SqlParameter("@vMachineName", MachineName));
                    objCmd.Parameters.Add(new SqlParameter("@vLineName", LineName));

                    objCmd.Connection = cnn;
                    objCmd.CommandText = strStored;
                    objCmd.CommandType = CommandType.StoredProcedure;

                    dtAdapter.SelectCommand = objCmd;

                    dtAdapter.Fill(ds);
                    dt = ds.Tables[0];

                    try
                    {
                        Result = dt.Rows[0]["result"].ToString();
                        return Result;
                    }
                    catch
                    {
                        Result = "SQL Error";
                        return Result;
                    }
                }
            }
            catch (SqlException e)
            {
                string Result = e.ToString();
                return Result;
            }
        }
        public string STBL_MOUNTER_DETAIL(string ModuleNo, string BlockNo, string ReelID, string PartNo, string Vendor, string LotNo, string Reference, string PanelID, string LineName)
        {
            try
            {
                SqlConnection cnn = ConnectionDB();
                SqlCommand objCmd = new SqlCommand();
                SqlDataAdapter dtAdapter = new SqlDataAdapter();

                DataSet ds = new DataSet();
                DataTable dt;
                string strStored;
                string Result;
                using (cnn)
                {
                    strStored = "STBL_MOUNTER_DETAIL";
                    objCmd.Parameters.Add(new SqlParameter("@vModuleNo", ModuleNo));
                    objCmd.Parameters.Add(new SqlParameter("@vBlockNo", BlockNo));
                    objCmd.Parameters.Add(new SqlParameter("@vReelID", ReelID));
                    objCmd.Parameters.Add(new SqlParameter("@vPartNo", PartNo));
                    objCmd.Parameters.Add(new SqlParameter("@vVendor", Vendor));
                    objCmd.Parameters.Add(new SqlParameter("@vLotNo", LotNo));
                    objCmd.Parameters.Add(new SqlParameter("@vReference", Reference));
                    objCmd.Parameters.Add(new SqlParameter("@vPanelID", PanelID));
                    objCmd.Parameters.Add(new SqlParameter("@vLineName", LineName));

                    objCmd.Connection = cnn;
                    objCmd.CommandText = strStored;
                    objCmd.CommandType = CommandType.StoredProcedure;

                    dtAdapter.SelectCommand = objCmd;

                    dtAdapter.Fill(ds);
                    dt = ds.Tables[0];

                    try
                    {
                        Result = dt.Rows[0]["result"].ToString();
                        return Result;
                    }
                    catch
                    {
                        Result = "SQL Error";
                        return Result;
                    }
                }
            }
            catch (SqlException e)
            {
                string Result = e.ToString();
                return Result;
            }
        }
        public string STBL_CHK_BOM_PSES(string ProgramName, string PartNo, string Vendor, string Reference)
        {
            try
            {
                SqlConnection cnn = ConnectionDB();
                SqlCommand objCmd = new SqlCommand();
                SqlDataAdapter dtAdapter = new SqlDataAdapter();

                DataSet ds = new DataSet();
                DataTable dt;
                string strStored;
                string Result;
                using (cnn)
                {
                    strStored = "[STBL_BOM_PANASONIC].[dbo].[STBL_CHK_BOM_PSES]";
                    objCmd.Parameters.Add(new SqlParameter("@pProgramName", ProgramName));
                    objCmd.Parameters.Add(new SqlParameter("@pItemCD", PartNo));
                    objCmd.Parameters.Add(new SqlParameter("@pItemDESC", Vendor));
                    objCmd.Parameters.Add(new SqlParameter("@pLocation", Reference));

                    objCmd.Connection = cnn;
                    objCmd.CommandText = strStored;
                    objCmd.CommandType = CommandType.StoredProcedure;

                    dtAdapter.SelectCommand = objCmd;

                    dtAdapter.Fill(ds);
                    dt = ds.Tables[0];

                    try
                    {
                        Result = dt.Rows[0]["Result"].ToString();
                        return Result;
                    }
                    catch
                    {
                        Result = "SQL Error";
                        return Result;
                    }
                }
            }
            catch (SqlException e)
            {
                string Result = e.ToString();
                return Result;
            }
        }
    }

    class ListProduct
    {
        public string LineNo { get; set; }
        public string ProgramName { get; set; }
        public string SMTDate { get; set; }
        public int Qty { get; set; }
        public string CycleTime { get; set; }
        public ListProduct(string LineNo, string ProgramName,string SMTDate, int Qty, string CycleTime)
        {
            this.LineNo = LineNo;
            this.ProgramName = ProgramName;
            this.SMTDate = SMTDate;
            this.Qty = Qty;
            this.CycleTime = CycleTime;
        }
    }
}
