using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_System
{
    class AttendanceData
    {
        public bool AddAttendance(Attendence att)
        {
            string sql = " insert into attendance (employee_id,employee_name,status,late_time,AReason) values(@employeeId,@employeeName,@status,@lateTime,@aReason);";
            MySQLConnection sqlHelp = new MySQLConnection();
            MySqlParameter parameter1 = new MySqlParameter("employeeId", sqlHelp.SqlNull(att.employeeId));
            MySqlParameter parameter2 = new MySqlParameter("employeeName", sqlHelp.SqlNull(att.employeeName));
            MySqlParameter parameter3 = new MySqlParameter("status", sqlHelp.SqlNull(att.status));
            MySqlParameter parameter4 = new MySqlParameter("lateTime", sqlHelp.SqlNull(att.lateTime));
            MySqlParameter parameter5 = new MySqlParameter("aReason", sqlHelp.SqlNull(att.aReason));
            if (sqlHelp.ExecuteNonQuery(sql, parameter1, parameter2, parameter3, parameter4, parameter5)) return true;
            return false;
        }
        public bool DeleteById(int id)
        {
            string sql = " update attendance set deleted=1 where id = @id;";
            MySQLConnection sqlHelp = new MySQLConnection();
            MySqlParameter parameter = new MySqlParameter("id", id);
            if (sqlHelp.ExecuteNonQuery(sql, parameter)) return true;
            return false;
        }
        public bool UpdateById(int id, Attendence att)
        {
            string sql = "update attendance set employee_id = @employeeId,employee_name=@employeeName,status=@status,late_time=@lateTime,AReason=@aReason where id = @id;";
            MySQLConnection sqlHelp = new MySQLConnection();
            MySqlParameter parameter1 = new MySqlParameter("employeeId", sqlHelp.SqlNull(att.employeeId));
            MySqlParameter parameter2 = new MySqlParameter("employeeName", sqlHelp.SqlNull(att.employeeName));
            MySqlParameter parameter3 = new MySqlParameter("status", sqlHelp.SqlNull(att.status));
            MySqlParameter parameter4 = new MySqlParameter("lateTime", sqlHelp.SqlNull(att.lateTime));
            MySqlParameter parameter5 = new MySqlParameter("aReason", sqlHelp.SqlNull(att.aReason));
            if (sqlHelp.ExecuteNonQuery(sql, parameter1, parameter2, parameter3, parameter4, parameter5)) return true;
            return false;
        }
    }
    class Attendence
    {
        public int id { get; set; }
        public int employeeId { get; set; }
        public string employeeName { get; set; }
        public string status { get; set; }
        public DateTime lateTime { get; set; }
        public string aReason { get; set; }
        public DateTime update_time { get; set; }
        public int deleted { get; set; }
        public Attendence()
        {
            id = 0;
            employeeId = 0;
            employeeName = null;
            status = null;
            lateTime = default(DateTime);
            aReason = null;
            update_time = DateTime.Now;
        }
    }
}