using MeesterwerkData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeesterwerkData
{
    public interface IDrawing
    {
        IEnumerable<Drawing> GetAll();
        Drawing GetById(int id);

        void Add(Drawing newDrawing);
        IEnumerable<Drawing> GetDrawingByNumber(string number);
        IEnumerable<Drawing> GetDrawingByName(string name);

        string GetName(int id);
        string GetNumber(int id);
        string GetRev(int id);
        int GetLine(int id);
        DateTime? GetDeliveryDate(int id);
        int GetQuantity(int id);
        decimal GetPricePerUnit(int id);
        bool IsPrinted(int id);
    }
}
