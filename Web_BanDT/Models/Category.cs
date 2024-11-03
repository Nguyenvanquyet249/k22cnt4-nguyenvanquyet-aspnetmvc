using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_BanDT.Models
{
    public class Category
    {
        public int CategoryId { get; set; }         // Khóa chính
        public string Name { get; set; }            // Tên danh mục
        public List<Product> Products { get; set; } // Danh sách sản phẩm trong danh mục
    }
}