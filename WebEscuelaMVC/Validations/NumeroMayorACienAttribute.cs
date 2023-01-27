using WebEscuelaMVC.Models;
using System.ComponentModel.DataAnnotations;

namespace OperaWebSite.Validations
{
    public class NumeroMayorACienAttribute : ValidationAttribute
    {
        public NumeroMayorACienAttribute()
        {
            ErrorMessage = "El numero debe ser mayor a 100";
        }

        public override bool IsValid(object value)
        {
            int numero = (int)value;
            if (numero < 100)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}