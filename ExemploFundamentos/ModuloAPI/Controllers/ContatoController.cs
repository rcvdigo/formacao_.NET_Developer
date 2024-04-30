using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModuloAPI.Context;
using ModuloAPI.Entities;

namespace ModuloAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        // Atributos
        private readonly AgendaContext _context;
        // Contrutores
        public ContatoController(AgendaContext agendaContext)
        {
            _context = agendaContext;
        }

        // Endpoints
        [HttpPost]
        public IActionResult InsertContato(Contato contato)
        {
            _context.Add(contato);
            _context.SaveChanges();
            return CreatedAtAction(nameof(SelectIdContato), new {  contatoId = contato.Id }, contato);
        }

        [HttpGet("contatoPorId/{contatoId}")]
        public IActionResult SelectIdContato(int contatoId)
        {
            // Primeira forma
            var result = _context.Contatos.Find(contatoId);
            // var result = _context.Find<Contato>(contatoId);

            if (result == null)
                return NotFound();

            return Ok(new { resultado = result });
        }

        [HttpGet("contatoPorNome/{contatoNome}")]
        public IActionResult SelectNomeContato(string contatoNome)
        {
            var result = _context.Contatos.Where(x => x.Nome.Contains(contatoNome));

            return Ok(new { resultado = result });
        }

        [HttpGet("TodosContatos")]
        public IActionResult SelectAllContato()
        {
            // Primeira forma
            // var result = _context.Contatos.Find(contatoId);
            var result = _context.Contatos.ToList();

            if (result == null)
                return NotFound();

            return Ok(new { resultado = result });
        }

        [HttpPut("{contatoId}")]
        public IActionResult UpdateContato(int contatoId, Contato contato)
        {
            // Primeira forma
            // var result = _context.Contatos.Find(contatoId);
            var result = _context.Find<Contato>(contatoId);

            if (result == null)
                return NotFound();

            result.Nome = contato.Nome;
            result.Telefone = contato.Telefone;
            result.Ativo = contato.Ativo;

            _context.Contatos.Update(result);
            _context.SaveChanges();

            return Ok(new { resultado = result});
        }

        [HttpDelete("{contatoId}")]
        public IActionResult DeleteContato(int contatoId)
        {
            // Primeira forma
            // var result = _context.Contatos.Find(contatoId);
            var result = _context.Find<Contato>(contatoId);


            if (result == null)
                return NotFound();

            _context.Contatos.Remove(result);
            _context.SaveChanges();

            return NoContent();
        }

    }
}