using OnlineShopMVC.Models.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace OnlineShopMVC.Filters
{
    public class ExtensionValidationAttribute : ValidationAttribute
    {
        private readonly string[] _extension;
        public ExtensionValidationAttribute(string[] extension)
        {
            _extension = extension;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            ProductViewModel productViewModel1 = value as ProductViewModel;

            ProductViewModel productViewModel = validationContext.ObjectInstance as ProductViewModel;
            if (productViewModel1 != null)
            {
                //var extension = Path.GetExtension(productViewModel.ImageData[0].FileName);
                //if (!_extension.Contains(extension.ToLower()))
                //{
                //    return new ValidationResult($"This photo extension is not allowed");
                //}
                if (productViewModel1.ProductName.Length > 10)
                {
                    return new ValidationResult($"This photo extension is not allowed");

                }
            }
            return ValidationResult.Success;
        }

    }
}
