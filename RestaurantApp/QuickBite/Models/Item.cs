﻿using System.Security.Cryptography.X509Certificates;

namespace QuickBite.Models
{
    /*
     This class represents a menu items. It contains basic properties like name, price etc
     */
    public class Item
    {
        public int ItemId { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        
    }
}
