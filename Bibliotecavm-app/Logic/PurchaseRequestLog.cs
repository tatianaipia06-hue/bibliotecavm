using System;
using System.Data;

namespace Logic
{
    public class PurchaseRequestLog
    {
        // Instancia correcta hacia la capa de datos
        Data.PurchaseRequestDat objDat = new Data.PurchaseRequestDat();

        public DataSet showPurchaseRequest()
        {
            return objDat.showPurchaseRequest();
        }

        public DataSet showPurchaseRequestDDL()
        {
            return objDat.showPurchaseRequestDDL();
        }

        public bool savePurchaseRequest(string solic_ticket, DateTime solic_fecha, int user_id, int solic_cantidad, int mat_id, out string errorMessage)
        {
            return objDat.savePurchaseRequest(solic_ticket, solic_fecha, user_id, solic_cantidad, mat_id, out errorMessage);
        }

        public bool updatePurchaseRequest(int solic_id, string solic_ticket, DateTime solic_fecha, int user_id, int solic_cantidad, int mat_id)
        {
            return objDat.updatePurchaseRequest(solic_id, solic_ticket, solic_fecha, user_id, solic_cantidad, mat_id);
        }

        public bool deletePurchaseRequest(int solic_id)
        {
            return objDat.deletePurchaseRequest(solic_id);
        }

        public int countPurchaseRequests()
        {
            return objDat.countPurchaseRequests();
        }

        public DataSet showPurchaseRequestsByUser(int userId)
        {
            return objDat.showPurchaseRequestsByUser(userId);
        }

        public DataSet showGetMaterials()
        {
            return objDat.showGetMaterials();
        }

        public DataSet ListarMaterialesEducativos()
        {
            return objDat.ListarMaterialesEducativos();
        }
    }
}