using OperaWebSite.Validations;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace WebEscuelaMVC.Models
{
    public class Aula
    {

//        Programar una validación personalizada en la propiedad Número.
//El número ingresado debe ser mayor a 100 
//Configurar el ErrorMessage “El número debe ser mayor a 100”
        public int Id { get; set; }

        [Required(ErrorMessage = "Numero es obligatorio")]
        [NumeroMayorACien]
        public int Numero { get; set; }

        [Required(ErrorMessage = "Estado es obligatorio")]
        public string Estado { get; set; }
    }
}
