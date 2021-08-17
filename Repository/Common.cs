using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using WebApplication2.Models;

namespace WebApplication2.Repository
{
    public class Common
    {
        private SqlConnection con;

        private void Connection()
        {
            string _conString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            con = new SqlConnection(_conString);

        }
        public List<AppRefData> GetAppRefData(int parentId)
        {
            List<AppRefData> appRefDataList = new List<AppRefData>();
            Connection();
            SqlCommand cmd = new SqlCommand("getStatus_Training_Prabhu", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@parentId", SqlDbType.Int);
            cmd.Parameters["@parentId"].Value = parentId;
            con.Open();


            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                appRefDataList.Add(
                    new AppRefData { KeyID = Convert.ToInt32(reader["KeyId"]), KeyName = reader["KeyName"].ToString() }
                    );
            }

            reader.Close();
            con.Close();

            return appRefDataList;
        }

        public List<GetCompData> GetWorkingComp()
        {
            List<GetCompData> getComps = new List<GetCompData>();
            Connection();
            SqlCommand cmd = new SqlCommand("getWorkComp_Training_Prabhu", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                getComps.Add(
                    new GetCompData { Id = Convert.ToInt32(reader["CompanyMaster_Id"]), KeyName = reader["CompanyName"].ToString() }
                    );
            }
            reader.Close();

            con.Close();
            return getComps;
        }
        public List<AppRefData> GetDepartment()
        {
            List<AppRefData> appRefDataList = new List<AppRefData>();
            Connection();
            SqlCommand cmd = new SqlCommand("Get_Dep_Nisarg", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                appRefDataList.Add(new AppRefData { KeyID = Convert.ToInt32(reader["Dept_Code"]), KeyName = reader["Dept_Name"].ToString() }
                );
            }

            reader.Close();
            con.Close();

            return appRefDataList;
        }

        public List<AppRefData> GetWorkLoc()
        {
            List<AppRefData> appRefDataList = new List<AppRefData>();
            Connection();
            SqlCommand cmd = new SqlCommand("Get_WorkLocation_Prabhu", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                appRefDataList.Add(
                    new AppRefData { KeyID = Convert.ToInt32(reader["WorkingLocation_Id"]), KeyName = reader["Location_Name"].ToString() }
                    );
            }

            reader.Close();
            con.Close();

            return appRefDataList;
        }
        public List<AppRefData> GetHr()
        {
            List<AppRefData> appRefDataList = new List<AppRefData>();
            Connection();
            SqlCommand cmd = new SqlCommand("Get_HrRepresentative_Prabhu", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                appRefDataList.Add(
                   new AppRefData { KeyID = Convert.ToInt32(reader["EmployeeDetails_Id"]), KeyName = reader["FullName"].ToString() }
                    );
            }

            reader.Close();
            con.Close();

            return appRefDataList;
        }

        public List<AppRefData> GetActRecr()
        {
            List<AppRefData> appRefDataList = new List<AppRefData>();
            Connection();
            SqlCommand cmd = new SqlCommand("Get_ActRec_Prabhu", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                appRefDataList.Add(
                    new AppRefData { KeyID = Convert.ToInt32(reader["EmployeeDetails_Id"]), KeyName = reader["Full_Name"].ToString() }
                    );
            }

            reader.Close();
            con.Close();

            return appRefDataList;
        }

        //public List<AppRefData> GetAppRefData(string Project_Id)
        //{
        //    Connection();
        //    List<AppRefData> appRefList = new List<AppRefData>();


        //    SqlCommand cmd = new SqlCommand("GetAppRefData_Training_Prabhu", con);
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    cmd.Parameters.Add("@Project_Id", SqlDbType.VarChar);
        //    cmd.Parameters["@Project_Id"].Value = Project_Id;
        //    con.Open();

        //    SqlDataReader reader = cmd.ExecuteReader();


        //    while (reader.Read())
        //    {
        //        appRefList.Add(new AppRefData
        //        {
        //            Project Id = Convert.ToString(reader["Project_Id"])
        //        }
        //            );
        //    }
        //    reader.Close();

        //    SqlParameter[] param = new SqlParameter[1];
        //    param[0] = new SqlParameter("@Project_Id", DbType.Int32);
        //    param[0].Value = Project_Id;

        //    cmd.Parameters.AddRange(param);


        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    con.Open();
        //    da.Fill(dt);
        //    con.Close();

        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        appRefList.Add(

        //            new AppRefData
        //            {
        //                KeyID = Convert.ToInt32(dr["KeyID"]),
        //                KeyName = Convert.ToString(dr["KeyName"])
        //            }

        //            );
        //    }

        //    return appRefList;
        //}

    }
}




