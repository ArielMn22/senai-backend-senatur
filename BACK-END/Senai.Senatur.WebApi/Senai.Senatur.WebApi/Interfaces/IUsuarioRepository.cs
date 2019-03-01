using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Interfaces
{
    public interface IUsuarioRepository
    {
        /// <summary>
        /// Lista todos os usuários do programa
        /// </summary>
        /// <returns>List<Usuarios></returns>
        List<Usuarios> Listar();

        /// <summary>
        /// Busca um usuário por Email e Senha.
        /// </summary>
        /// <param name="login">LoginViewModel</param>
        /// <returns>Um Object Usuarios</returns>
        Usuarios BuscarPorEmailESenha(LoginViewModel login);
    }
}
