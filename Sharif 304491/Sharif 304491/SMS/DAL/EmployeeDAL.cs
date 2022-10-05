using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;

namespace DAL 
{
    public class EmployeeDAL
    {

        public int InsertUpdateDelete_Employee(Entity.EEmployee objEmp )
        {
            int ret = 0;
            Database db;
            DbCommand dbcmd;
            db = DatabaseFactory.CreateDatabase("cnn");
            dbcmd = db.GetStoredProcCommand("SetupInstituteSp_insertUpdateDelete");

            db.AddInParameter(dbcmd, "Action", DbType.Int32, objEmp.Action);
            db.AddInParameter(dbcmd, "EmployeeId", DbType.Int32, objEmp.EmployeeId);
            db.AddInParameter(dbcmd, "FirstName", DbType.String, objEmp.FirstName);
            db.AddInParameter(dbcmd, "LastName", DbType.String, objEmp.LastName);
            db.AddInParameter(dbcmd, "EmployeeType", DbType.String, objEmp.EmployeeType);
            db.AddInParameter(dbcmd, "DesignationId", DbType.Int32, objEmp.DesignationId);
            db.AddInParameter(dbcmd, "StartingSalary", DbType.Double, objEmp.StartingSalary);
            db.AddInParameter(dbcmd, "Nationality", DbType.String, objEmp.Nationality);
            db.AddInParameter(dbcmd, "NID", DbType.String, objEmp.NID);
            db.AddInParameter(dbcmd, "DOB", DbType.DateTime, objEmp.DOB);
            db.AddInParameter(dbcmd, "JoiningDate", DbType.DateTime, objEmp.JoiningDate);
            db.AddInParameter(dbcmd, "ReligionId", DbType.Int32, objEmp.ReligionId);
            db.AddInParameter(dbcmd, "DistrictId", DbType.Int32, objEmp.DistrictId);
            db.AddInParameter(dbcmd, "UpazilaId", DbType.Int32, objEmp.UpazilaId);
            db.AddInParameter(dbcmd, "Address", DbType.String, objEmp.Address);
            db.AddInParameter(dbcmd, "Email", DbType.String, objEmp.Email);
            db.AddInParameter(dbcmd, "ContactNo", DbType.String, objEmp.ContactNo);
            db.AddInParameter(dbcmd, "Gender", DbType.String, objEmp.Gender);
            db.AddInParameter(dbcmd, "EmpImg", DbType.String, objEmp.EmpImg);
            db.AddInParameter(dbcmd, "BloodGroup", DbType.String, objEmp.BloodGroup);
            db.AddInParameter(dbcmd, "EntryBy", DbType.Int32, objEmp.EntryBy);

            ret = db.ExecuteNonQuery(dbcmd);

            return ret;
        }

    }





        public DataTable SetupSp_GetInstitute(int InstituteId)
        {
            DataTable dt = new DataTable();
            Database db;
            DbCommand dbcmd;
            db = DatabaseFactory.CreateDatabase("cnn");
            dbcmd = db.GetStoredProcCommand("SetupSp_GetInstitute");
            db.AddInParameter(dbcmd, "InstituteId", DbType.Int32, InstituteId);
            dt = db.ExecuteDataSet(dbcmd).Tables[0];

            return dt;
        }


    }
}
