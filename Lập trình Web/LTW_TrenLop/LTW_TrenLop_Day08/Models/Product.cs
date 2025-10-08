using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LTW_TrenLop_Day08.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Tên sản phẩm")]
        [Column(TypeName = "nvarchar(100)")]
        [Required(ErrorMessage = "Tên sản phẩm không được để trống")]
        [StringLength(100)]
        public string Name { get; set; }

        public string Image {  get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public DateTime CreateDate { get; set; }

        public int CategoryId { get; set; }

        public Product() { }
    }
}
