using System;
using MultimediaShop.Models;

namespace MultimediaShop.Interfaces
{
    internal interface ISale
    {
        Item Item { get; set; }
        DateTime SaleDate { get; set; }
    }
}