using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClinicaMedica.App.Data;
using ClinicaMedica.App.ViewModels;
using ClinicaMedica.Business.Interfaces.Services;
using AutoMapper;
using ClinicaMedica.Business.Models;

namespace ClinicaMedica.Application.Controllers
{
    public class PacienteController : Controller
    {
        private readonly IPacienteService _pacienteService;
        private readonly IMapper _mapper;

        public PacienteController(IPacienteService pacienteService, IMapper mapper)
        {
            _pacienteService = pacienteService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<IEnumerable<PacienteViewModel>>(await _pacienteService.ObterPacientesPorEndereco()));
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var pacienteViewModel = await ObterPacienteEndereco(id);

            if (pacienteViewModel == null)
            {
                return NotFound();
            }

            return View(pacienteViewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PacienteViewModel pacienteViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(pacienteViewModel);
            }

            var paciente = _mapper.Map<Paciente>(pacienteViewModel);

            await _pacienteService.Adicionar(paciente);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(Guid id)
        {

            var pacienteViewModel = await ObterPacienteEndereco(id);

            if (pacienteViewModel == null)
            {
                return NotFound();
            }

            return View(pacienteViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, PacienteViewModel pacienteViewModel)
        {
            if (id != pacienteViewModel.Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return View(pacienteViewModel);
            }

            var paciente = _mapper.Map<Paciente>(pacienteViewModel);

            await _pacienteService.Atualizar(paciente);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            var pacienteViewModel = await ObterPacienteEndereco(id);

            if (pacienteViewModel == null)
            {
                return NotFound();
            }

            return View(pacienteViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            await _pacienteService.Remover(id);

            return RedirectToAction(nameof(Index));
        }

        private async Task<PacienteViewModel> ObterPacienteEndereco(Guid id)
        {
            var paciente = _mapper.Map<PacienteViewModel>(await _pacienteService.ObterPacienteEndereco(id));
            return paciente;
        }
    }
}
