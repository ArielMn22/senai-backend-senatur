using Senai.Senatur.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Interfaces
{
    public interface IPacoteRepository
    {
        /// <summary>
        /// Lista todos os pacotes
        /// </summary>
        /// <returns>Object Pacotes</returns>
        List<Pacotes> Listar();
        
        /// <summary>
        /// Busca um pacote pelo seu Id.
        /// </summary>
        /// <param name="id">Id do pacote a ser buscado.</param>
        /// <returns>Object Pacotes</returns>
        Pacotes BuscarPorId(int id);

        /// <summary>
        /// Cadastra um pacote.
        /// </summary>
        /// <param name="pacote">Pacotes Object</param>
        void Cadastrar(Pacotes pacote);

        /// <summary>
        /// Altera um pacote.
        /// </summary>
        /// <param name="pacote">Pacotes Object</param>
        void Alterar(Pacotes pacote);

        /// <summary>
        /// Deleta um pacote.
        /// </summary>
        /// <param name="pacote">Pacotes Object</param>
        void Remover(Pacotes pacote);

        /// <summary>
        /// Lista somente os ativos.
        /// </summary>
        /// <returns>Retorna uma lista.</returns>
        List<Pacotes> ListarAtivos();
    }
}
