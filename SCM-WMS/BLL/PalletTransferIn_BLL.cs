
using SCM_WMS.DAL.PallateTransfer_DALTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCM_WMS.DAL.PlateTransferInTableAdapters;
namespace SCM_WMS.BLL
{
    public class PalletTransferIn_BLL
    {
        public DataTable PlateTransferEntry(int intPart, string xml, int intWhId, int intPalteId, string strBarcode, ref string Msg)
        {
            try
            {
                sprPlateTransferTableAdapter adp = new sprPlateTransferTableAdapter();
                DataTable dt = new DataTable();
                dt= adp.GetData(intPart, xml, intWhId, intPalteId, strBarcode, ref Msg);
                return adp.GetData(intPart, xml, intWhId, intPalteId, strBarcode, ref Msg);
            }
            catch (Exception)
            {
                return new DataTable();
            }           
        }




        public DataTable PlateTransferIn(int intPart, string xml, int intWhId, int intPalteId, string strBarcode, ref string Msg)
        {
            try
            {
                sprAddHSCodeTableAdapter adp = new sprAddHSCodeTableAdapter();
                return adp.GetPlateTransferInData(intPart, xml, intWhId, intPalteId, strBarcode, ref Msg);
            }
            catch (Exception Ex)
            {
                return new DataTable();
            }
        }


        


    }
}
