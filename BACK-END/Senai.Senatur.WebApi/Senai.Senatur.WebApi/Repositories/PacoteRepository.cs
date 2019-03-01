using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Repositories
{
    public class PacoteRepository : IPacoteRepository
    {
        public void Alterar(Pacotes pacote)
        {
            using (SenaTurContext ctx = new SenaTurContext())
            {
                ctx.Pacotes.Update(pacote);
                ctx.SaveChanges();
            }
        }

        public Pacotes BuscarPorId(int id)
        {
            using (SenaTurContext ctx = new SenaTurContext())
            {
                return ctx.Pacotes.Find(id);
            }
        }

        public void Cadastrar(Pacotes pacote)
        {
            using (SenaTurContext ctx = new SenaTurContext())
            {
                ctx.Pacotes.Add(pacote);
                ctx.SaveChanges();
            }
        }

        public List<Pacotes> Listar()
        {
            using (SenaTurContext ctx = new SenaTurContext())
            {
                return ctx.Pacotes.ToList();
            }
        }

        public List<Pacotes> ListarAtivos()
        {
            using (SenaTurContext ctx = new SenaTurContext())
            {
                return ctx.Pacotes.Where(x => x.Ativo == true).ToList();
            }
        }

        public void Remover(Pacotes pacote)
        {
            using (SenaTurContext ctx = new SenaTurContext())
            {
                ctx.Pacotes.Remove(pacote);
                ctx.SaveChanges();
            }
        }
    }
}
