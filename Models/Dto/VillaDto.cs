using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HildaVilla.Api.Models.Dto
{
    public class VillaDto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Este Campo es requerido")]
        [StringLength(100, ErrorMessage = "Solo toma 100 caracteres")]
        public string? Nombre { get; set; }
        public DateTime DateTime { get; set; }
        
    }
}
