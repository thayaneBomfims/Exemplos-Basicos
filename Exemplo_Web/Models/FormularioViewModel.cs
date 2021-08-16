using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo_Web.Models
{
    public class FormularioViewModel
    {
        [Required(ErrorMessage = "Nome, obrigatório.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "E-mail, obrigatório.")]
        [RegularExpression("^[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?\\.)+[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?$", ErrorMessage = "E-mail inválido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefone, obrigatório.")]
        public string Phone { get; set; }

        public string About { get; set; }

        public string Message { get; set; }
    }
}
