﻿using Microsoft.AspNetCore.Http;

namespace Shop.Application.Services.Product.Command.AddNewProduct
{
    public class AddProductDto
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public int Price  { get; set; }
        public int Inventory { get; set; }
        public long CategoryId { get; set; }
        public bool Displayed { get; set; }
        public IFormFileCollection Image { get; set; }
        public List<AddNewProduct_Feature> Features { get; set; }
    }

}
