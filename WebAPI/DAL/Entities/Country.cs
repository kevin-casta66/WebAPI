using System.ComponentModel.DataAnnotations;
using WebAPI.DAL.Entities;

namespace WebAPI.DAL.Entities
{
    public class Country: AuditBase
    {
        [Display (Name = "País")] //´para identificar el nombre mas facil
        [MaxLength (50, ErrorMessage =" el campo {0} debe de tener maximo {1} caracteres")] // longitud maxima 
        [Required(ErrorMessage ="el campo {0} es obligatorio")]// Campo obligatorio
        public String Name { get; set; }



    }
}
