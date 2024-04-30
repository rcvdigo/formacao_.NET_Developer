using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModuloMVC.Context;
using ModuloMVC.Models;

namespace ModuloMVC.Controllers
{
    public class ContatoController(AgendaContext context) : Controller
    {
        private readonly AgendaContext _agendaContext = context;

        public IActionResult Index()
        {
            var contatos = _agendaContext.Contatos.ToList();
            return View(contatos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Contato contato)
        {
            if (ModelState.IsValid)
            {
                _agendaContext.Contatos.Add(contato);
                _agendaContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(contato);
        }

        public IActionResult Editar(int id)
        {
            var contato = _agendaContext.Contatos.Find(id);

            if (contato == null)
                return RedirectToAction(nameof(Index));

            return View(contato);
        }

        [HttpPost]
        public IActionResult Editar(Contato contato)
        {
            var contatoNoBanco = _agendaContext.Contatos.Find(contato.Id);

            contatoNoBanco.Nome = contato.Nome;

            contatoNoBanco.Telefone = contato.Telefone;

            contatoNoBanco.Ativo = contato.Ativo;

            _agendaContext.Update(contatoNoBanco);
            _agendaContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Detalhes(int id)
        {
            var contatoDetalhes = _agendaContext.Contatos.Find(id);

            if (contatoDetalhes == null)
                return RedirectToAction(nameof(Index));

            return View(contatoDetalhes);
        }

        public IActionResult Deletar(int id)
        {
            var contatoDeletar = _agendaContext.Contatos.Find(id);

            if (contatoDeletar == null)
                return RedirectToAction(nameof(Index));


            return View(contatoDeletar);
        }

        [HttpPost]
        public IActionResult Deletar(Contato contato)
        {
            var contatoBanco = _agendaContext.Contatos.Find(contato.Id);
            _agendaContext.Contatos.Remove(contatoBanco);
            _agendaContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}