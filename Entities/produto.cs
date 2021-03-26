using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Congregação_Crista_no_Brasil.Entities
{
    public class produto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DateTime Dataentrada { get; set; }
        public int Quantidade { get; set; }
        public string preço{ get; set; }

        public produto()
        {
            Id = Guid.NewGuid();
            Dataentrada = DateTime.Now;
        }

    }
}
