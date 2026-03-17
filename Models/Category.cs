using System.ComponentModel.DataAnnotations;

namespace NongQuangTiepB5.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        //Navigation property
        public List<Product> Products { get; set; }
    }

}
