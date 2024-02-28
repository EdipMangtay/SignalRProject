﻿namespace SignalRApi.DAL.Entities
{
    public class Product
    {
        public int Productid { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ProductStatus { get; set; }


    }
}
