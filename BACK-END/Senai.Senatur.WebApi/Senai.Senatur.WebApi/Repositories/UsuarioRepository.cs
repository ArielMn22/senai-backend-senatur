using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using Senai.Senatur.WebApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public Usuarios BuscarPorEmailESenha(LoginViewModel login)
        {
            using (SenaTurContext ctx = new SenaTurContext())
            {
                return ctx.Usuarios.FirstOrDefault(u => u.Email == login.Email && u.Senha == login.Senha);
            }
        }

        public List<Usuarios> Listar()
        {
            using (SenaTurContext ctx = new SenaTurContext())
            {
                return ctx.Usuarios.ToList();
            }
        }
    }
}