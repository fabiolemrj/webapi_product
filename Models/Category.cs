using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage="Este campo é obrigatorio")]
        [MaxLength(60,ErrorMessage="Este campo deve possuir até 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve possuir até 3 caracteres")]
        public string Title { get; set; }
    }
}