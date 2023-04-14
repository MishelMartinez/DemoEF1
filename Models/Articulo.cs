using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoEF1.Models
{
    public class Articulo
    {
        public int Id { get; set; }
        [Column("Titulo")]
        [Required]
        [MaxLength(70)]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
