using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Congregação_Crista_no_Brasil.Entities
{
    public class Usuario
    {
        public Guid ID { get; set; }
        public string Nome { get; set; }
        public  string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime Databatismo { get; set; }
        public DateTime Datacadastro { get; set; }
        public string Email { get; set; }
        public string nomeusuario { get; set; }
        public string senha { get; set; }
        #region construtor 
        public Usuario()
        {
            ID = Guid.NewGuid();
            Datacadastro = DateTime.Now;
        }
        #endregion

    }
}
