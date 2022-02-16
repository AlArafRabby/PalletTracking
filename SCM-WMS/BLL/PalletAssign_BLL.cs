using SCM_WMS.DAL;
using SCM_WMS.DAL.PalletAssign_DALTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCM_WMS.BLL
{
    public class PalletAssign_BLL
    {
        public DataTable PlateAssign(string xmlString, int type, ref string strMsg)
        {
            try
            {
                sprPlateTransectionTableAdapter oj = new sprPlateTransectionTableAdapter();
                return oj.GetASDFData(xmlString, type, ref strMsg);
            }
            catch (Exception e)
            {
                return new DataTable();
            }
        }

        public DataTable SearchProduct(int WHID)
        {
            try
            {
                sprAutosearchRequesitionTableAdapter oj = new sprAutosearchRequesitionTableAdapter();
                DataTable dt;
                DataTable DT = oj.GetData(WHID);
                string[] retStr = new string[DT.Rows.Count];
                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    retStr[i] = (DT.Rows[i]["strItem"] + "[" + DT.Rows[i]["intItem"] + "]" + "[" + "Stock:" + " " +
                                 DT.Rows[i]["monstock"] + " " + DT.Rows[i]["strUom"] + "]");
                }
                return DT;
            }
            catch (Exception e)
            {
                return new DataTable();
            }
        }
        private static PalletAssign_DAL.sprAutosearchRequesitionDataTable[] tableItem = null;
        int e;   
    }
}
