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
    public class InstituteDAL
    {
       
       

        public int InsertUpdateDelete_Institute(Entity.EInstitute objEins )
        {
            int ret = 0;
            Database db;
            DbCommand dbcmd;
            db = DatabaseFactory.CreateDatabase("cnn");
            dbcmd = db.GetStoredProcCommand("SetupInstituteSp_insertUpdateDelete");

            db.AddInParameter(dbcmd, "Action", DbType.Int32, objEins.Action);
            db.AddInParameter(dbcmd, "InstituteId", DbType.Int32, objEins.InstituteId);
            db.AddInParameter(dbcmd, "EIIN_RegistrationNo", DbType.String, objEins.EIIN_RegistrationNo);
            db.AddInParameter(dbcmd, "InstituteName", DbType.String, objEins.InstituteName);
            db.AddInParameter(dbcmd, "Email", DbType.String, objEins.Email);
            db.AddInParameter(dbcmd, "Phone", DbType.String, objEins.Phone);
            db.AddInParameter(dbcmd, "Fax", DbType.String, objEins.Fax);
            db.AddInParameter(dbcmd, "DistrictId", DbType.Int32, objEins.DistrictId);
            db.AddInParameter(dbcmd, "UpazilaId", DbType.Int32, objEins.UpazilaId);
            db.AddInParameter(dbcmd, "Address", DbType.String, objEins.Address);
            db.AddInParameter(dbcmd, "SchoolType", DbType.String, objEins.SchoolType);
            db.AddInParameter(dbcmd, "EntryBy", DbType.Int32, objEins.EntryBy);

            ret = db.ExecuteNonQuery(dbcmd);

            return ret;
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
