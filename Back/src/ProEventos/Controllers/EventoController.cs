using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.Models;

namespace ProEventos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]{
            new Evento(){
                EventoId = 1,
                Tema = "Angular 11 e .NET 5",
                Local = "Belo Horizonte",
                Lote = "1 lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemURL = "foto.png"
            },
             new Evento(){
                EventoId = 2,
                Tema = "Angular 11 e .NET 5 e suas novidade",
                Local = "São Paulo",
                Lote = "2 lote",
                QtdPessoas = 350,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                ImagemURL = "foto1.png"
            }
        };
        public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> Get(int id) //sobrecarga do metedo Get
        {
            return _evento.Where(t => t.EventoId == id);
        }

            [HttpPost]

            public string Post()
            {
                return "exemplo de post"
                ;
            }

            [HttpPut("{id}")]
            public string Put(int id)
            {
                return $"exemplo de Put com id = {id}";
            }
            [HttpDelete("{id}")]
            public string Delete(int id)
            {
                return $"exemplo de Delete com id = {id}";
            }
        }
    }
