using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFrontend.Models
{
    public class Contato
    {
        public int Id{ get; set; }
        public string Nome{ get; set; }
        public string Telefone{ get; set; }
        public bool Ativo{ get; set; }
    }
}