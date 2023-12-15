#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vitorhugo.Models;

namespace Vitorhugo.Controllers
{
    public class TipoDePagamentosController : Controller
    {
        private readonly MyDbContext _context;

        public TipoDePagamentosController(MyDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.TipoDePagamentos.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoDePagamento = await _context.TipoDePagamentos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoDePagamento == null)
            {
                return NotFound();
            }

            return View(tipoDePagamento);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NomeDoCobrado,InformacoesAdicionais")] TipoDePagamento tipoDePagamento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoDePagamento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoDePagamento);
        }

        // GET: TipoDePagamentos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoDePagamento = await _context.TipoDePagamentos.FindAsync(id);
            if (tipoDePagamento == null)
            {
                return NotFound();
            }
            return View(tipoDePagamento);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NomeDoCobrado,InformacoesAdicionais")] TipoDePagamento tipoDePagamento)
        {
            if (id != tipoDePagamento.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoDePagamento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoDePagamentoExists(tipoDePagamento.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(tipoDePagamento);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoDePagamento = await _context.TipoDePagamentos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoDePagamento == null)
            {
                return NotFound();
            }

            return View(tipoDePagamento);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipoDePagamento = await _context.TipoDePagamentos.FindAsync(id);
            _context.TipoDePagamentos.Remove(tipoDePagamento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoDePagamentoExists(int id)
        {
            return _context.TipoDePagamentos.Any(e => e.Id == id);
        }
    }
}