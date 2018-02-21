using MeesterwerkData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeesterwerkData
{
    public interface IPurchaseOrder
    {
        IEnumerable<PurchaseOrder> GetAll();

        PurchaseOrder GetById(int id);

        void Add(PurchaseOrder newPurchaseOrder);

        IEnumerable<PurchaseOrder> GetPurchaseOrderByNumber(string number);

        string GetOrderNumber(int id);
        string GetDescription(int id);
        //IEnumerable<Drawing> GetAllDrawings(int id);

    }
}
