using System.ComponentModel.DataAnnotations;

namespace OnlineShopMVC.Models.ViewModels
{
    public class ProductViewModel
    {
        public Guid ProductId { get; set; }
        [Required(ErrorMessage = "Nom kiriting.")]
        [Display(Name = "ProductName")]
        public string ProductName { get; set; }
        public string Slug { get; set; }
        public string SortDescription { get; set; }
        public string[] Colors { get; set; }
        public string[] Sizes { get; set; }

        [Required(ErrorMessage = "Narxni to'g'ri kiriting")]
        [Range(10, 100)]
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string FullDetail { get; set; }
        public string ProductTags { get; set; }
        public string[] Categories { get; set; }
        // public List<Review> Reviews { get; set; }
        [Required(ErrorMessage = "Rasm tanlang")]
        [Display(Name = "Admission Date")]
        public IFormFile[] ImageData { get; set; }
    }
}
