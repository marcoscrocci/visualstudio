using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projeto02_AspNetCore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace Projeto02_AspNetCore.Controllers
{
   
    public class ClinicaController : Controller
    {
        HttpClient client;


        private ClinicaContext Context { get; set; }

        // O contexto será injetado pelo MVC no sua execução        
        public ClinicaController(ClinicaContext context)
        {
            this.Context = context;

            if (client == null)
            {
                client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:49956/");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            }
        }

        public IActionResult Index()
        {
            return View();
        }

        private List<Convenio> ListaConvenios()
        {
            return new List<Convenio>()
            {
                new Convenio() { Codigo = 10, Descricao = "Amil" },
                new Convenio() { Codigo = 20, Descricao = "Notredame" },
                new Convenio() { Codigo = 30, Descricao = "Sul America" }
            };
        }

        private static List<Convenio> listaConvenios;
        
        public async Task<IActionResult> IncluirPaciente()
        {
            // Usando WS
            /*HttpResponseMessage response =
                client.GetAsync("api/convenios").Result;

            if (response.IsSuccessStatusCode)
            {
                var resultado = await
                    response.Content.ReadAsStringAsync();

                var lista = JsonConvert
                    .DeserializeObject <Convenio[]>(resultado)
                    .ToList<Convenio>();

                listaConvenios = lista;

                ViewBag.Convenios = new SelectList(listaConvenios, "Descricao", "Descricao");
            }*/

            ViewBag.Convenios = new SelectList(ListaConvenios(), "Descricao", "Descricao");

            return View();
        }

        [HttpPost]
        public IActionResult IncluirPaciente(Paciente paciente, IFormFile foto)
        {
            if (foto != null)
            {
                paciente.Foto = foto.ToByteArray();
                paciente.FotoMimeType = foto.ContentType;

                Context.Add<Paciente>(paciente);
                Context.SaveChanges();

                return RedirectToAction("ListarPacientes");
            }

            ViewBag.Convenios = new SelectList(ListaConvenios(), "Descricao", "Descricao");
            //ViewBag.Convenios = new SelectList(listaConvenios, "Descricao", "Descricao");
            return View();
        }

        public IActionResult ListarPacientes()
        {
            var paciente = Context.Pacientes.ToList<Paciente>();
            return View(paciente);
        }

        public FileResult BuscarFoto(int id)
        {
            var paciente = Context
                .Pacientes
                .Where(p => p.PacienteId == id)
                .Select(s => new { s.Foto, s.FotoMimeType })
                .FirstOrDefault();

            return File(paciente.Foto, paciente.FotoMimeType);
        }

        public IActionResult Detalhes(int id)
        {
            var paciente = Context
                .Pacientes
                .FirstOrDefault(p => p.PacienteId == id);

            return View(paciente);
        }

        // id: do paciente
        public IActionResult IncluirTratamento(int id)
        {
            Tratamento tratamento = new Tratamento();
            tratamento.PacienteId = id;

            return View(tratamento);
        }

        [HttpPost]
        public IActionResult IncluirTratamento(int id, Tratamento tratamento)
        {
            Context.Add<Tratamento>(tratamento);
            Context.SaveChanges();

            return RedirectToAction("ListarPacientes");
        }

        public IActionResult ListarTratamentos(int id)
        {
            var lista = Context
                .Tratamentos
                .Where(p => p.PacienteId == id)
                .ToList<Tratamento>();

            return View(lista);
        }

    }
}