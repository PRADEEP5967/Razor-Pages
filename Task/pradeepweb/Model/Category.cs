using System.ComponentModel.DataAnnotations;

namespace pradeepweb.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name="Display Order")]
        [Range(1,100,ErrorMessage ="Display Order Must be in rangle 1-100")]
        public int DisplayOrder { get; set; }
    }
}
