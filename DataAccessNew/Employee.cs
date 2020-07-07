using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessNew
{
    public class Employee
    {
        List<EmployeeClass> obj1 = new List<EmployeeClass>();
        public List<EmployeeClass> BindGrid()
        {
            List<EmployeeClass> empList = new List<EmployeeClass>();

            string constring = @"Data Source=DESKTOP-OR7SCKK\SQLEXPRESS;Initial Catalog=CGAKIB;Integrated Security=SSPI";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("Select ID, Username, Firstname, Lastname, Gender, Salary from tbl_userMaster", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            if (dt.Rows.Count > 0)

                            {

                                for (int i = 0; i < dt.Rows.Count; i++)

                                {

                                    EmployeeClass userinfo = new EmployeeClass();

                                    userinfo.ID = Convert.ToInt16(dt.Rows[i]["ID"]);
                                    userinfo.Username = dt.Rows[i]["Username"].ToString();
                                    userinfo.Firstname = dt.Rows[i]["Firstname"].ToString();
                                    userinfo.Lastname = dt.Rows[i]["Lastname"].ToString();
                                    userinfo.Gender = dt.Rows[i]["Gender"].ToString();
                                    //userinfo.Salary = Convert.ToInt32(dt.Rows[i]["Salary"]);
                                    obj1.Add(userinfo);

                                }

                            }
                        }
                    }
                }
            }
            return obj1;
        }
    }
}
