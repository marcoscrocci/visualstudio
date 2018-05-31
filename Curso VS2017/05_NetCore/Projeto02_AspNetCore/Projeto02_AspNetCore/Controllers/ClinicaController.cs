using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projeto02_AspNetCore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;

namespace Projeto02_AspNetCore.Controllers
{
    public class ClinicaController : Controller
    {
        private ClinicaContext Context { get; set; }

        // O contexto será injetado pelo MVC no sua execução
        public ClinicaController(ClinicaContext context)
        {
            this.Context = context;
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

        public IActionResult IncluirPaciente()
        {
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


    }
}