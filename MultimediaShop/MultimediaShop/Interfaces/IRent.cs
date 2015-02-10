using System;
using MultimediaShop.Models;

namespace MultimediaShop.Interfaces
{
    internal interface IRent
    {
        Item Item { get; set; }
        //TODO: RentState returned overdue
        DateTime RentDate { get; set; }
        DateTime DeadLineDate { get; set; }
        DateTime ReturnDate { get; set; }

        decimal CalculateRentFine();
    }
}