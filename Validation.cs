using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace Student_Management_System_Project
{
	class Validation
	{
        public static Object StuIDExists(String input, DataTable dt, StringBuilder err)
        {
            Object returnData = dt;
            foreach (DataRow row in dt.Rows)
            {
                if (input == row["StudentID"].ToString()) 
                {
                    returnData = null;
                    err.Append("The ID '" + input + "' already exists");
                }
            }
            return returnData;
        }
        public static Object CourseIDExists(String input, DataTable dt, StringBuilder err)
        {
            Object returnData = dt;
            foreach (DataRow row in dt.Rows)
            {
                if (input == row["CourseID"].ToString()) 
                {
                    returnData = null;
                    err.Append("The Course ID '" + input + "' already exists");
                }
            }
            return returnData;
        }
        public static Object InstIDExists(String input, DataTable dt, StringBuilder err)
        {
            Object returnData = dt;
            foreach (DataRow row in dt.Rows)
            {
                if (input == row["InstructorID"].ToString())
                {
                    returnData = null;
                    err.Append("The Instructor ID '" + input + "' already exists");
                }
            }
            return returnData;
        }
        public static Object UsernameExists(String input, DataTable dt, StringBuilder err)
        {
            Object returnData = dt;
            foreach (DataRow row in dt.Rows)
            {
                if (input == row["username"].ToString())
                {
                    returnData = null;
                    err.Append("Username '" + input + "' already exists");
                }
            }
            return returnData;
        }
    }
  
}
