using System;
using System.Collections.Generic;

namespace MultimediaShop.Interfaces
{
    internal interface IItem
    {
        string Id { get; set; }
        string Title { get; set; }
        decimal Price { get; set; }
        IList<String> Genres { get; set; } 
    }
}