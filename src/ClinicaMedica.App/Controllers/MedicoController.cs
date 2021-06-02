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
    public class MedicoController : Controller
    {
        private readonly IMedicoService _medicoService;
        private readonly IEspecialidadeService _especialidadeService;
        private readonly IMapper _mapper;

        public MedicoController(IMedicoService medicoService,
                                IEspecialidadeService especialidadeService,
                                IMapper mapper)
        {
            _medicoService = medicoService;
            _especialidadeService = especialidadeService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<IEnumerable<MedicoViewModel>>(await _medicoService.ObterMedicosPorEspecialidades()));
        }

        public async Task<IActionResult> Details(Guid id)
        {

            var medicoViewModel = await ObterMedicoEspecialidade(id);

            if (medicoViewModel == null)
            {
                return NotFound();
            }

            return View(medicoViewModel);
        }

        public async Task<IActionResult> Create()
        {
            var medicoViewModel = await PopularEspecialidades(new MedicoViewModel());
            return View(medicoViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MedicoViewModel medicoViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(medicoViewModel);
            }

            await _medicoService.Adicionar(_mapper.Map<Medico>(medicoViewModel));

            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var medicoViewModel = await ObterMedico(id);

            medicoViewModel = await PopularEspecialidades(medicoViewModel);

            if (medicoViewModel == null)
            {
                return NotFound();
            }

            return View(medicoViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, MedicoViewModel medicoViewModel)
        {
            if (id != medicoViewModel.Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return View(medicoViewModel);
                
            }

            await _medicoService.Atualizar(_mapper.Map<Medico>(medicoViewModel));

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            var medicoViewModel = await ObterMedicoEspecialidade(id);

            if (medicoViewModel == null)
            {
                return NotFound();
            }

            return View(medicoViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            await _medicoService.Remover(id);

            return RedirectToAction(nameof(Index));
        }

        private async Task<MedicoViewModel> ObterMedico(Guid id)
        {
            var medico = _mapper.Map<MedicoViewModel>(await _medicoService.ObterPorId(id));

            return medico;
        }

        private async Task<MedicoViewModel> ObterMedicoEspecialidade(Guid id)
        {
            var medico = _mapper.Map<MedicoViewModel>(await _medicoService.ObterMedicoEspecialidade(id));

            return medico;
        }

        private async Task<MedicoViewModel> PopularEspecialidades(MedicoViewModel medico)
        {
            medico.Especialidades = _mapper.Map <IEnumerable<EspecialidadeViewModel>> (await _especialidadeService.ObterTodos());
            return medico;
        }
    }
}
