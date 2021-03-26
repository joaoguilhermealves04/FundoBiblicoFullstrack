using Congregação_Crista_no_Brasil.Entities;
using Congregação_Crista_no_Brasil.Models;
using Congregação_Crista_no_Brasil.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Congregação_Crista_no_Brasil.Controllers
{
    public class Account : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(RegisterModel model)
        {
            try
            {
                if (!model.senha.Equals(model.senhaconfime))
                {
                    throw new Exception("Senhas não conferem,por favor digite novamente.");
                }


                var usuarioRepository = new UsuarioRepository();

                if (usuarioRepository.Obter(model.Email)!=null)
                {
                    throw new Exception($"O Email{model.Email},Digite Outro Email");

                }

                var usuario = new Usuario();
                usuario.Nome = model.Nome;
                usuario.CPF = model.CPF;
                usuario.DataNascimento = model.DataNascimento;
                usuario.Databatismo = model.Databatismo;
                usuario.Email = model.Email;
                usuario.nomeusuario = model.nomeusuario;
                usuario.senha = model.senha;

               
                usuarioRepository.Inserir(usuario);

                TempData["Mensagem"] = $"Usuario{usuario.Nome},Cadastrado Com Sucesso.";
                

            }
            catch(Exception e)
            {
                TempData["Mensagem"] = e.Message;
            }
            return View();
        }
    }
}
