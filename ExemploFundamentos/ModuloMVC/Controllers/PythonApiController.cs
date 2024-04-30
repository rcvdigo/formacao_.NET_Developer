using Microsoft.AspNetCore.Mvc;
using ModuloMVC.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ModuloMVC.Controllers
{
    public class PythonApiController : Controller
    {
        public IActionResult Index()
        {
            using var httpClient = new HttpClient();
            try
            {
                // Faz a requisição GET ao endpoint
                using HttpResponseMessage response = httpClient.GetAsync("https://desafio-uber-clean-architecture.onrender.com/api/select/").Result;

                // Verificação do tipo de requisição GET realizada se for via HTML o valor é = TRUE
                bool isHtmlRequest = Request.Headers.UserAgent.ToString().Contains("Chrome") ||
                                        Request.Headers.UserAgent.ToString().Contains("Firefox") ||
                                        Request.Headers.UserAgent.ToString().Contains("Safari") ||
                                        Request.Headers.UserAgent.ToString().Contains("Edge") ||
                                        Request.Headers.UserAgent.ToString().Contains("Opera");

                // Verifica se a resposta foi bem-sucedida (código 200)
                if (response.IsSuccessStatusCode)
                {
                    // Define a variável ViewBag para passar os dados para a view
                    // ViewBag.Content = content;

                    // Lê o conteúdo da resposta e faz um parse do JSON para um objeto JObject
                    JObject json = JObject.Parse(response.Content.ReadAsStringAsync().Result);

                    // Acessa os objetos dentro dos objetos mongodb_response e postgresql_response
                    JObject mongodbResponseJObject = (JObject)json["mongodb_response"];
                    JObject postgresqlResponseJObject = (JObject)json["postgresql_response"];

                    // Desserializa os objetos em uma lista de objetos Message
                    List<Message> messages = [];

                    foreach (var item in mongodbResponseJObject)
                    {
                        Message message = item.Value.ToObject<Message>();
                        messages.Add(message);
                    }

                    foreach (var item in postgresqlResponseJObject)
                    {
                        Message message = item.Value.ToObject<Message>();
                        message.Id = (string)item.Value["id"];
                        messages.Add(message);
                    }
                    // Se a requisição foi de um navegador WEB retorna a VIEW
                    if (isHtmlRequest)
                    {
                        return View(messages);
                    }
                    // Se não retorna um JSON para a API que está fazendo o consumo do endpoint
                    else
                    {
                        return Content(
                            JsonConvert.SerializeObject(
                                new 
                                {
                                    mongoDb = mongodbResponseJObject,
                                    postgreSql = postgresqlResponseJObject
                                }
                            ), "application/json"
                        );
                    }
                }
                else{
                    Console.WriteLine($"Erro na requisição. Código de status: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao fazer a requisição: {ex.Message}");
            }
            return View();
        }       
    }
}