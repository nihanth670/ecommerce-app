using Microsoft.AspNetCore.Mvc;
using EcommerceApi.Models;

namespace EcommerceApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = new List<Product>
            {
                // Mobiles
                new Product { Id = 1, Name = "Apple iPhone 15", Price = 79999, ImageUrl = "https://via.placeholder.com/200x150?text=iPhone+15", Category = "Mobiles" },
                new Product { Id = 2, Name = "Samsung Galaxy S23", Price = 69999, ImageUrl = "https://via.placeholder.com/200x150?text=Galaxy+S23", Category = "Mobiles" },
                new Product { Id = 3, Name = "OnePlus 11", Price = 59999, ImageUrl = "https://via.placeholder.com/200x150?text=OnePlus+11", Category = "Mobiles" },
                new Product { Id = 4, Name = "Xiaomi Redmi Note 12", Price = 17999, ImageUrl = "https://via.placeholder.com/200x150?text=Redmi+Note+12", Category = "Mobiles" },
                new Product { Id = 5, Name = "Realme GT Neo 5", Price = 24999, ImageUrl = "https://via.placeholder.com/200x150?text=Realme+GT+Neo+5", Category = "Mobiles" },
                new Product { Id = 6, Name = "Google Pixel 7", Price = 57999, ImageUrl = "https://via.placeholder.com/200x150?text=Pixel+7", Category = "Mobiles" },
                new Product { Id = 7, Name = "Vivo X90", Price = 52999, ImageUrl = "https://via.placeholder.com/200x150?text=Vivo+X90", Category = "Mobiles" },
                new Product { Id = 8, Name = "Oppo Reno 10", Price = 38999, ImageUrl = "https://via.placeholder.com/200x150?text=Oppo+Reno+10", Category = "Mobiles" },
                new Product { Id = 9, Name = "Motorola Edge 40", Price = 29999, ImageUrl = "https://via.placeholder.com/200x150?text=Motorola+Edge+40", Category = "Mobiles" },
                new Product { Id = 10, Name = "Asus ROG Phone 7", Price = 72999, ImageUrl = "https://via.placeholder.com/200x150?text=ROG+Phone+7", Category = "Mobiles" },

                // Electronics
                new Product { Id = 11, Name = "Sony WH-1000XM5 Headphones", Price = 29999, ImageUrl = "https://via.placeholder.com/200x150?text=Sony+XM5", Category = "Electronics" },
                new Product { Id = 12, Name = "Dell Inspiron Laptop", Price = 55999, ImageUrl = "https://via.placeholder.com/200x150?text=Dell+Laptop", Category = "Electronics" },
                new Product { Id = 13, Name = "Apple MacBook Air M2", Price = 114999, ImageUrl = "https://via.placeholder.com/200x150?text=MacBook+Air+M2", Category = "Electronics" },
                new Product { Id = 14, Name = "Samsung 1TB SSD", Price = 8999, ImageUrl = "https://via.placeholder.com/200x150?text=Samsung+SSD", Category = "Electronics" },
                new Product { Id = 15, Name = "HP LaserJet Printer", Price = 15999, ImageUrl = "https://via.placeholder.com/200x150?text=HP+Printer", Category = "Electronics" },
                new Product {                new Product { Id = 16, Name = "Boat Rockerz 550 Headphones", Price = 1999, ImageUrl = "https://via.placeholder.com/200x150?text=Boat+Rockerz+550", Category = "Electronics" },
                new Product { Id = 17, Name = "Canon EOS 1500D DSLR Camera", Price = 35999, ImageUrl = "https://via.placeholder.com/200x150?text=Canon+1500D", Category = "Electronics" },
                new Product { Id = 18, Name = "LG 55-inch 4K Smart TV", Price = 64999, ImageUrl = "https://via.placeholder.com/200x150?text=LG+4K+TV", Category = "Electronics" },
                new Product { Id = 19, Name = "Mi Smart Band 7", Price = 2999, ImageUrl = "https://via.placeholder.com/200x150?text=Mi+Band+7", Category = "Electronics" },
                new Product { Id = 20, Name = "JBL Flip 6 Bluetooth Speaker", Price = 8999, ImageUrl = "https://via.placeholder.com/200x150?text=JBL+Flip+6", Category = "Electronics" },

                // Fashion
                new Product { Id = 21, Name = "Levi's 511 Slim Fit Jeans", Price = 2499, ImageUrl = "https://via.placeholder.com/200x150?text=Levis+Jeans", Category = "Fashion" },
                new Product { Id = 22, Name = "Nike Air Max Shoes", Price = 7999, ImageUrl = "https://via.placeholder.com/200x150?text=Nike+Air+Max", Category = "Fashion" },
                new Product { Id = 23, Name = "Adidas Hoodie", Price = 3499, ImageUrl = "https://via.placeholder.com/200x150?text=Adidas+Hoodie", Category = "Fashion" },
                new Product { Id = 24, Name = "Puma Sports T-Shirt", Price = 1499, ImageUrl = "https://via.placeholder.com/200x150?text=Puma+Tshirt", Category = "Fashion" },
                new Product { Id = 25, Name = "Ray-Ban Aviator Sunglasses", Price = 5999, ImageUrl = "https://via.placeholder.com/200x150?text=RayBan+Aviator", Category = "Fashion" },

                // Home Appliances
                new Product { Id = 26, Name = "Philips Air Fryer", Price = 8999, ImageUrl = "https://via.placeholder.com/200x150?text=Philips+Air+Fryer", Category = "Home Appliances" },
                new Product { Id = 27, Name = "Samsung 253L Refrigerator", Price = 23999, ImageUrl = "https://via.placeholder.com/200x150?text=Samsung+Fridge", Category = "Home Appliances" },
                new Product { Id = 28, Name = "IFB 6kg Washing Machine", Price = 19999, ImageUrl = "https://via.placeholder.com/200x150?text=IFB+Washing+Machine", Category = "Home Appliances" },
                new Product { Id = 29, Name = "Prestige Mixer Grinder", Price = 3499, ImageUrl = "https://via.placeholder.com/200x150?text=Prestige+Mixer", Category = "Home Appliances" },
                new Product { Id = 30, Name = "Dyson V11 Vacuum Cleaner", Price = 52999, ImageUrl = "https://via.placeholder.com/200x150?text=Dyson+V11", Category = "Home Appliances" },

                // Sports
                new Product { Id = 31, Name = "Yonex Badminton Racket", Price = 2499, ImageUrl = "https://via.placeholder.com/200x150?, ImageUrl = "https://via.placeholder.com/200x150?text=Nivia+Football", Category = "Sports" },
                new Product { Id = 33, Name = "Spalding Basketball", Price = 3499, ImageUrl = "https://via.placeholder.com/200x150?text=Spalding+Basketball", Category = "Sports" },
                new Product { Id = 34, Name = "Cosco Volleyball", Price = 1999, ImageUrl = "https://via.placeholder.com/200x150?text=Cosco+Volleyball", Category = "Sports" },
                new Product { Id = 35, Name = "SG Cricket Bat", Price = 4999, ImageUrl = "https://via.placeholder.com/200x150?text=SG+Cricket+Bat", Category = "Sports" },
                new Product { Id = 36, Name = "Decathlon Yoga Mat", Price = 999, ImageUrl = "https://via.placeholder.com/200x150?text=Yoga+Mat", Category = "Sports" },

                // Books
                new Product { Id = 37, Name = "The Alchemist", Price = 399, ImageUrl = "https://via.placeholder.com/200x150?text=The+Alchemist", Category = "Books" },
                new Product { Id = 38, Name = "Atomic Habits", Price = 499, ImageUrl = "https://via.placeholder.com/200x150?text=Atomic+Habits", Category = "Books" },
                new Product { Id = 39, Name = "Rich Dad Poor Dad", Price = 299, ImageUrl = "https://via.placeholder.com/200x150?text=Rich+Dad+Poor+Dad", Category = "Books" },
                new Product { Id = 40, Name = "Ikigai", Price = 349, ImageUrl = "https://via.placeholder.com/200x150?text=Ikigai", Category = "Books" },
                new Product { Id = 41, Name = "Deep Work", Price = 599, ImageUrl = "https://via.placeholder.com/200x150?text=Deep+Work", Category = "Books" },

                // Miscellaneous
                new Product { Id = 42, Name = "Apple AirPods Pro", Price = 24999, ImageUrl = "https://via.placeholder.com/200x150?text=AirPods+Pro", Category = "Electronics" },
                new Product { Id = 43, Name = "Samsung Galaxy Watch 5", Price = 19999, ImageUrl = "https://via.placeholder.com/200x150?text=Galaxy+Watch+5", Category = "Electronics" },
                new Product { Id = 44, Name = "GoPro Hero 11", Price = 39999, ImageUrl = "https://via.placeholder.com/200x150?text=GoPro+Hero+11", Category = "Electronics" },
                new Product { Id = 45, Name = "Kindle Paperwhite", Price = 13999, ImageUrl = "https://via.placeholder.com/200x150?text=Kindle+Paperwhite", Category = "Electronics" },
                new Product { Id = 46, Name = "Sony PlayStation 5", Price = 49999, ImageUrl = "https://via.placeholder.com/200x150?text=PS5", Category = "Electronics" },
                new Product { Id = 47, Name = "Xbox Series X", Price = 49999, ImageUrl = "https://via.placeholder.com/200x150?text=Xbox+Series+X", Category = "Electronics" },
                new Product { Id = 48, Name = "Nintendo Switch OLED", Price = 34999, ImageUrl = "https://via.placeholder.com/200x150?text=Switch+OLED", Category = "Electronics" },
                new Product { Id = 49, Name = "DJI Mini 3 Drone", Price = 55999, ImageUrl = "https://via.placeholder.com/200x150?text=DJI+Mini+3+Drone", Category = "Electronics" },
                new Product { Id = 50, Name = "Fitbit Charge 6", Price = 14999, ImageUrl = "https://via.placeholder.com/200x150?text=Fitbit+Charge+6", Category = "Electronics" }
            };
            return Ok(products);
        }
    }
}
