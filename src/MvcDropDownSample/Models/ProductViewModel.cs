using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace MvcDropDownSample.Models
{
    public class ProductViewModel
    {
        public string Name { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
       // public HttpPostedFileBase Image { get; set; }
        public int SelectedCategoryId { get; set; }
        public List<ProductCategory> Categories { get; set; }
        public ProductCategory Category { get; set; }
    }


    public class ProductCategory
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}