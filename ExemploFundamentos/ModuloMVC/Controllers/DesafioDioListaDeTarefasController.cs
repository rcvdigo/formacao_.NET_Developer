using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using ModuloMVC.Context;
using ModuloMVC.Models;
using Newtonsoft.Json;

namespace ModuloMVC.Controllers
{
    public class DesafioDioListaDeTarefasController(TarefaContext context) : Controller
    {
        private readonly TarefaContext _tarefaContext = context;

        public IActionResult Index()
        {
            var tarefas = _tarefaContext.Tarefas.ToList();
            return View(tarefas);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Tarefa tarefa)
        {
            // Se a requisição for via api POSTMAN com Header form-data ou Via HTML
            if (Request.ContentType.Contains("form-data") || Request.ContentType.Contains("x-www-form-urlencoded"))
            {
                Console.WriteLine(Request.ContentType);
                _tarefaContext.Tarefas.Add(tarefa);
                _tarefaContext.SaveChanges();
            }
            // Se a requisição for via Json
            if (Request.ContentType.Contains("application/json"))
            {
                using StreamReader reader = new(Request.Body);
                string requestBody = await reader.ReadToEndAsync();
                // Deserialização da string Json e salvando no banco de dados
                tarefa = JsonConvert.DeserializeObject<Tarefa>(requestBody);
                _tarefaContext.Tarefas.Add(tarefa);
                await _tarefaContext.SaveChangesAsync();

                return Json(new { tarefa });
            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var tarefa = _tarefaContext.Tarefas.Find(id);

            if (tarefa == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(tarefa);
        }

        [HttpPost]
        public IActionResult Edit(Tarefa tarefa)
        {
            var tarefaInDb = _tarefaContext.Tarefas.Find(tarefa.Id);

            tarefaInDb.Titulo = tarefa.Titulo;
            tarefaInDb.Descricao = tarefa.Descricao;
            tarefaInDb.Data = tarefa.Data;
            tarefaInDb.Status = tarefa.Status;

            _tarefaContext.Update(tarefaInDb);
            _tarefaContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id)
        {
            var tarefaDetails = _tarefaContext.Tarefas.Find(id);

            if (tarefaDetails == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(tarefaDetails);
        }

        public IActionResult Delete(int id)
        {
            var tarefaDelete = _tarefaContext.Tarefas.Find(id);
            
            if (tarefaDelete == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(tarefaDelete);
        }

        [HttpPost]
        public IActionResult Delete(Tarefa tarefa)
        {
            var tarefaDelete = _tarefaContext.Tarefas.Find(tarefa.Id);

            _tarefaContext.Remove(tarefaDelete);
            _tarefaContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        public IActionResult Search(string searchField, string searchString)
        {
            ViewBag.SearchField = searchField;
            IEnumerable<Tarefa> tarefasEncontradas;

            if (!string.IsNullOrEmpty(searchString))
            {
                switch (searchField)
                {
                    case "Titulo":
                        tarefasEncontradas = _tarefaContext.Tarefas.Where(t => t.Titulo.Contains(searchString)).ToList();
                        break;
                    case "Data":
                        if (DateTime.TryParse(searchString, out DateTime searchDate))
                        {
                            tarefasEncontradas = _tarefaContext.Tarefas.Where(t => t.Data.Date == searchDate.Date).ToList();

                            if (!tarefasEncontradas.Any())
                            {
                                tarefasEncontradas = Enumerable.Empty<Tarefa>();
                                ViewBag.ErrorMessage = "Formato de data inválido. Use o formato correto (dd/mm/yyyy).";
                            }
                        }
                        else
                        {
                            // Lógica para lidar com uma string de busca inválida para data
                            tarefasEncontradas = Enumerable.Empty<Tarefa>();
                            ViewBag.ErrorMessage = "Formato de data inválido. Use o formato correto (dd/mm/yyyy).";
                        }
                        break;
                    case "Status":
                        if (Enum.TryParse(searchString.ToLower().Replace(" ", ""), true, out EnumStatusTarefa statusEnum))
                        {
                            tarefasEncontradas = _tarefaContext.Tarefas.Where(s => s.Status == statusEnum).ToList();
                        }
                        else
                        {
                            // Lógica para lidar com uma string de busca inválida para status
                            tarefasEncontradas = _tarefaContext.Tarefas.ToList()
                            .Where(t => t.Status.ToString().ToLower().Replace(" ", "") == searchString.Trim().Replace(" ", ""));
                        }
                        break;
                    default:
                        // Se nenhum campo válido for selecionado, retorna todas as tarefas
                        tarefasEncontradas = _tarefaContext.Tarefas.ToList();
                        break;
                }

                return View(tarefasEncontradas);
            }
            else
            {
                // Se a string de pesquisa estiver vazia, retorna todas as tarefas
                var todasAsTarefas = _tarefaContext.Tarefas.ToList();
                return View(todasAsTarefas);
            }
        }
    }
}