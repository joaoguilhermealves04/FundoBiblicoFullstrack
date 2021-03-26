using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Congregação_Crista_no_Brasil.Models
{
    public class RegisterModel
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime Databatismo { get; set; }
        public DateTime Datacadastro { get; set; }
        public string Email { get; set; }
        public string nomeusuario { get; set; }
        public string senha { get; set; }
        public string senhaconfime { get; set; }

    }
}
