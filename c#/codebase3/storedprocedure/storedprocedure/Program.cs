using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace StoredProcedure
{
    class Program
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        public static SqlConnection getCon()
        {
            con = new SqlConnection("data source = ADMW46ZLPC1570\\SQLEXPRESS; Initial catalog = ZensarDB; " + "user id = sa; password = Temp1234");
            con.Open();
            return con;
        }
        public static void select()
        {
            try
            {
                con = getCon();
                Console.WriteLine("Enter employee name");
                string empname = Console.ReadLine();
                Console.WriteLine("Enter employee salary");
                double empsal = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter employee type C or P");
                string type = Console.ReadLine();
                cmd = new SqlCommand("spinsert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@empname", empname).Direction = System.Data.ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@empsal", empsal).Direction = System.Data.ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@emptype", type).Direction = System.Data.ParameterDirection.Input;
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("VALUES INSERTED SUCCESSFULLY");
                }
                else
                {
                    Console.WriteLine("VALUES NOT UPDATED");
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            con.Close();
        }
        public static void display()
        {
            con = getCon();
            cmd = new SqlCommand("select * from Code__Employee");
            cmd.Connection = con;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("Employee Id " + dr[0]);
                Console.WriteLine("Employee Name " + dr[1]);
                Console.WriteLine("Employee Salary " + dr[2]);
                Console.WriteLine("Employee Type " + dr[3]);
            }
            con.Close();
        }
        public static void Main(string[] args)
        {
            //select();
            display();
            Console.Read();
        }
    }
}