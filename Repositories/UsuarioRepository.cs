using Congregação_Crista_no_Brasil.Contracts;
using Congregação_Crista_no_Brasil.Entities;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Congregação_Crista_no_Brasil.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private string codigo ;
        public UsuarioRepository()
        {
           codigo = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FundoBiblico;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        public void Alterar(Usuario usuario)
        {
            var query = " update Usuario set Nome= @Nome,DataNascimento = @DataNascimento,Databatismo =@Databatismo,Senha = @Senha ,nomeusuario = @nomeusuario " + " where ID=@ID ";
            using (var connection = new SqlConnection(codigo))
            {
                connection.Execute(query, usuario);
            }
        }

        public List<Usuario> ConsultarTodos()
        {
            var query = "select*  from Usuario order by Nome";

            using (var connection = new SqlConnection(codigo))
            {
                 return connection.Query<Usuario>(query).ToList();
            }
        }

        public void Inserir(Usuario usuario)
        {
            var query = "Insert into Usuario (ID,Nome,CPF,DataNascimento,DataBatismo,Datacadastro,Email,nomeusuario,senha)"+ "values(@ID,@Nome,@CPF,@DataNascimento,@Databatismo,@Datacadastro,@Email,@nomeusuario,@senha)";
            
            using (var connection = new SqlConnection(codigo))
            {
                connection.Execute(query, usuario); 
            }
        }

        public Usuario Obter(string nome)
        {
            var query = "select*from Usuario where Nome=@Nome";
            using(var connection = new SqlConnection(codigo))
            {
                return connection.Query<Usuario>(query, new { nome }).FirstOrDefault();
            }
        }

        public Usuario Obter(string nomedeUsuario, string senha)
        {
            var query = "Select*from Usuario where nomedeusuario=@nomedeusuario and Senha=@Senha";
            using(var connection=new SqlConnection(codigo))
            {
                return connection.Query<Usuario>(query, new { nomedeUsuario, senha }).FirstOrDefault();
            }
        }
    }
}
