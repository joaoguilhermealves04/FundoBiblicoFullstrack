using Congregação_Crista_no_Brasil.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Congregação_Crista_no_Brasil.Contracts
{
    interface IUsuarioRepository
    {
        
        
            void Inserir(Usuario usuario);
            Usuario Obter(string nome);
            Usuario Obter(string nomedeUsuario, string senha);
        List<Usuario> ConsultarTodos();
        void Alterar(Usuario usuario);
        
    }
}
