using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public EventoController(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _dataContext.Eventos;
        }


        [HttpGet("{id}")]
        public Evento Get(int id)
        {
            return _dataContext.Eventos.FirstOrDefault(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post() 
        {
            return "new Value";            
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de PUT id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete id = {id}";
        }
    }
}
