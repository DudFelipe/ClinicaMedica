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

namespace ClinicaMedica.App.Controllers
{
    public class EspecialidadeController : BaseController
    {

        private readonly IEspecialidadeService _especialidadeService;
        private readonly IMapper _mapper;

        public EspecialidadeController(IEspecialidadeService especialidadeService,
                                       IMapper mapper)
        {
            _especialidadeService = especialidadeService;
            _mapper = mapper;
        }
        
        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<IEnumerable<EspecialidadeViewModel>>(await _especialidadeService.ObterTodos()));
        }

        public async Task<IActionResult> Details(Guid id)
        {

            var especialidadeViewModel = await ObterEspecialidade(id);

            if (especialidadeViewModel == null)
            {
                return NotFound();
            }

            return View(especialidadeViewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EspecialidadeViewModel especialidadeViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(especialidadeViewModel);
            }

            await _especialidadeService.Adicionar(_mapper.Map<Especialidade>(especialidadeViewModel));

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var especialidadeViewModel = await ObterEspecialidade(id);
            
            if (especialidadeViewModel == null)
            {
                return NotFound();
            }

            return View(especialidadeViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, EspecialidadeViewModel especialidadeViewModel)
        {
            if (id != especialidadeViewModel.Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return View(especialidadeViewModel);
            }

            await _especialidadeService.Atualizar(_mapper.Map<Especialidade>(especialidadeViewModel));

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            var especialidadeViewModel = await ObterEspecialidade(id);

            if (especialidadeViewModel == null)
            {
                return NotFound();
            }

            return View(especialidadeViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            await _especialidadeService.Remover(id);

            return RedirectToAction(nameof(Index));
        }

        private async Task<EspecialidadeViewModel> ObterEspecialidade(Guid id)
        {
            var especialidade = _mapper.Map<EspecialidadeViewModel>(await _especialidadeService.ObterEspecialidade(id));

            return especialidade;
        }
    }
}
