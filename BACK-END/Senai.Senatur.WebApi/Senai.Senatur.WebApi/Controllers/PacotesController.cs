using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using Senai.Senatur.WebApi.Repositories;

namespace Senai.Senatur.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class PacotesController : ControllerBase
    {
        private IPacoteRepository PacoteRepository { get; set; }

        public PacotesController()
        {
            PacoteRepository = new PacoteRepository();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            try
            {
                return Ok(PacoteRepository.Listar());
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    mensagem = ex
                });
            }
        }

        [HttpGet("ativos")]
        public IActionResult ListarAtivos()
        {
            try
            {
                return Ok(PacoteRepository.ListarAtivos());
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    mensagem = ex
                });
            }
        }

        [HttpGet("buscarporid/{id}")]
        public IActionResult BuscarPorId(int id)
        {
            try
            {
                Pacotes pacoteProcurado = PacoteRepository.BuscarPorId(id);

                if (pacoteProcurado == null)
                {
                    return NotFound();
                }

                return Ok(pacoteProcurado);
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    mensagem = ex
                });
            }
        }

        [HttpPost]
        public IActionResult Cadastrar(Pacotes pacote)
        {
            try
            {
                PacoteRepository.Cadastrar(pacote);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    mensagem = ex
                });
            }
        }

        [HttpPut]
        public IActionResult Alterar(Pacotes pacote)
        {
            try
            {
                Pacotes pacoteProcurado = PacoteRepository.BuscarPorId(pacote.PacoteId);

                if (pacoteProcurado == null)
                {
                    return NotFound();
                }

                PacoteRepository.Alterar(pacote);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    mensagem = ex
                });
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            try
            {
                Pacotes pacoteProcurado = PacoteRepository.BuscarPorId(id);

                if (pacoteProcurado == null)
                {
                    return NotFound();
                }

                PacoteRepository.Remover(pacoteProcurado);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    mensagem = ex
                });
            }
        }
    }
}