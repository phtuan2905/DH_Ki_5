using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LTW_TrenLop_Day08.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required(ErrorMessage = "Tên danh mục không được để trống")]
        [StringLength(100)]
        public string Name { get; set; }

        [Column(TypeName = "int")]
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }

        public ICollection<Product> Products { get; set; }

        public Category() { }
    }
}
