using OperaWebSite.Validations;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace WebEscuelaMVC.Models
{
    public class Aula
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Numero es obligatorio")]
        [NumeroMayorACien]
        public int Numero { get; set; }

        [Required(ErrorMessage = "Estado es obligatorio")]
        public string Estado { get; set; }
    }
}
