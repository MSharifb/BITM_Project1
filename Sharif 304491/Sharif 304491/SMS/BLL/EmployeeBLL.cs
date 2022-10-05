using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Entity; 
using System.Data;

namespace BLL
{
    
    public class EmployeeBLL
    {
        EmployeeDAL objEmpDAL = new EmployeeDAL();



        public int InsertUpdateDelete_EmployeeInfo(EEmployee objEmpyee)
        {
            int ret = 0;
            ret = objEmpDAL.InsertUpdateDelete_Employee(objEmpyee);
            return ret;
        }


        //public DataTable SetupSp_GetInstituteInfo(int InstituteId = 0)
        //{
        //    DataTable dt = new DataTable();
        //    dt = objInsDAL.SetupSp_GetInstitute(InstituteId);
        //    return dt;
        //}




    }
}
