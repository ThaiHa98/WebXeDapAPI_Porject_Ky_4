﻿namespace WebXeDapAPI.Dto
{
    public class ProductGetAllInfPriceDto
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public decimal PriceHasDecreased { get; set; }//giá đã giảm
        public string Image { get; set; }
        public string BrandNamer { get; set; }
    }
}