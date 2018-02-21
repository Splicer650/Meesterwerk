using MeesterwerkData;
using MeesterwerkData.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MeesterwerkServices
{
    public class DrawingService : IDrawing
    {
        public MeesterwerkContext _context;

        private DrawingService(MeesterwerkContext context)
        {
            _context = context;
        }

        public void Add(Drawing newDrawing)
        {
            _context.Add(newDrawing);
            _context.SaveChanges();
        }

        public IEnumerable<Drawing> GetAll()
        {
            return _context.Drawings;
        }

        public Drawing GetById(int id)
        {
            return _context.Drawings
                .FirstOrDefault(drawing => drawing.Id == id);
        }

        public DateTime? GetDeliveryDate(int id)
        {
           return _context.Drawings
                .FirstOrDefault(drawing => drawing.Id == id).DeliveryDate;
        }

        public IEnumerable<Drawing> GetDrawingByName(string name)
        {
            return _context.Drawings
                .Where(drawing => drawing.Name.Contains(name));
        }

        public IEnumerable<Drawing> GetDrawingByNumber(string number)
        {
            return _context.Drawings
                .Where(drawing => drawing.Number.Contains(number));
        }

        public int GetLine(int id)
        {
            return _context.Drawings
                .FirstOrDefault(drawing => drawing.Id == id).Line;
        }

        public string GetName(int id)
        {
            return _context.Drawings
                .FirstOrDefault(drawing => drawing.Id == id).Name;
        }

        public string GetNumber(int id)
        {
            return _context.Drawings
                .FirstOrDefault(drawing => drawing.Id == id).Number;
        }

        public decimal GetPricePerUnit(int id)
        {
            return _context.Drawings
                .FirstOrDefault(drawing => drawing.Id == id).PricePerUnit;
        }

        public int GetQuantity(int id)
        {
            return _context.Drawings
                .FirstOrDefault(drawing => drawing.Id == id).Quantity;
        }

        public string GetRev(int id)
        {
            return _context.Drawings
                .FirstOrDefault(drawing => drawing.Id == id).Rev;
        }

        public bool IsPrinted(int id)
        {
            return _context.Drawings
                .FirstOrDefault(drawing => drawing.Id == id).Printed;
        }
    }
}
