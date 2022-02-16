using SCM_WMS.Global_DALTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCM_WMS
{
    public class Global
    { 
        public string UserName = Environment.UserName + "@akij.net";
        DataTable DT = new DataTable();
        public Boolean LogedIn;
        public DataTable UserProfile()
        {
            try
            {
                QRYEMPLOYEEPROFILEALLTableAdapter Employee = new QRYEMPLOYEEPROFILEALLTableAdapter();
                return Employee.GetUserData(UserName);
            }
            catch (Exception ex)
            {
                throw;
            }            
      }
        public Boolean isLogedin (string Password)
        {
            try
            {
                QRYEMPLOYEEPROFILEALLTableAdapter Employee = new QRYEMPLOYEEPROFILEALLTableAdapter();

                DT = Employee.GetUserData(UserName);
                if (DT.Rows.Count>0 &&  DT.Rows[0]["intEmployeeID"].ToString()== Password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false; 
            }
            
        }
    }
}
