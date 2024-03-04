﻿namespace Web.Models
{
    public class CatalogItemViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public decimal Price { get; set; }

        public string PictureUri { get; set; } = null!;
    }
}
