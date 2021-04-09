using System;
namespace OperationDigger.Models.ViewModels
{
    public class PageNumbering
    {
        public decimal NumItemsPerPage { get; set; }

        public int CurrentPage { get; set; }

        public int TotalItems { get; set; }

        public int NumPages => (int)(Math.Ceiling(TotalItems / NumItemsPerPage));
    }
}
