using MeesterwerkData;
using MeesterwerkData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MeesterwerkServices
{
    public class PurchaseOrderService : IPurchaseOrder
    {
        private MeesterwerkContext _context;

        public PurchaseOrderService(MeesterwerkContext context)
        {
            _context = context;
        }

        public void Add(PurchaseOrder newPurchaseOrder)
        {
            _context.Add(newPurchaseOrder);
            _context.SaveChanges();
        }

        public IEnumerable<PurchaseOrder> GetAll()
        {
            return _context.PurchaseOrders
                .Include(order => order.Drawings);
        }

        //public IEnumerable<Drawing> GetAllDrawings(int id)
        //{
        //    return _context.PurchaseOrders
        //        .Include(order => order.Drawings);
        //}

        public PurchaseOrder GetById(int id)
        {
            return _context.PurchaseOrders
                .Include(order => order.Drawings)
                .FirstOrDefault(order => order.Id == id);
        }

        public string GetDescription(int id)
        {
            return _context.PurchaseOrders
                .Include(order => order.Drawings)
                .FirstOrDefault(order => order.Id == id).Description;
        }

        public string GetOrderNumber(int id)
        {
            return _context.PurchaseOrders
                .Include(order => order.Drawings)
                .FirstOrDefault(order => order.Id == id).OrderNumber;
        }

        public IEnumerable<PurchaseOrder> GetPurchaseOrderByNumber(string number)
        {
            return _context.PurchaseOrders
                .Include(order => order.Drawings)
                .Where(order => order.OrderNumber.Contains(number));
        }
    }
}
