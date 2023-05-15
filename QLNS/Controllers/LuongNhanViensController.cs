using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QLNS.Data;
using QLNS.Models;

namespace QLNS.Controllers
{
    public class LuongNhanViensController : Controller
    {
        private readonly QLNSContext _context;

        public LuongNhanViensController(QLNSContext context)
        {
            _context = context;
        }

        // GET: LuongNhanViens
        public async Task<IActionResult> Index()
        {
              return _context.LuongNhanVien != null ? 
                          View(await _context.LuongNhanVien.ToListAsync()) :
                          Problem("Entity set 'QLNSContext.LuongNhanVien'  is null.");
        }

        // GET: LuongNhanViens/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.LuongNhanVien == null)
            {
                return NotFound();
            }

            var luongNhanVien = await _context.LuongNhanVien
                .FirstOrDefaultAsync(m => m.MaLuong == id);
            if (luongNhanVien == null)
            {
                return NotFound();
            }

            return View(luongNhanVien);
        }

        // GET: LuongNhanViens/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LuongNhanViens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaLuong,MaNV,LCBan")] LuongNhanVien luongNhanVien)
        {
            if (ModelState.IsValid)
            {
                _context.Add(luongNhanVien);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(luongNhanVien);
        }

        // GET: LuongNhanViens/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.LuongNhanVien == null)
            {
                return NotFound();
            }

            var luongNhanVien = await _context.LuongNhanVien.FindAsync(id);
            if (luongNhanVien == null)
            {
                return NotFound();
            }
            return View(luongNhanVien);
        }

        // POST: LuongNhanViens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaLuong,MaNV,LCBan")] LuongNhanVien luongNhanVien)
        {
            if (id != luongNhanVien.MaLuong)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(luongNhanVien);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LuongNhanVienExists(luongNhanVien.MaLuong))
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
            return View(luongNhanVien);
        }

        // GET: LuongNhanViens/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.LuongNhanVien == null)
            {
                return NotFound();
            }

            var luongNhanVien = await _context.LuongNhanVien
                .FirstOrDefaultAsync(m => m.MaLuong == id);
            if (luongNhanVien == null)
            {
                return NotFound();
            }

            return View(luongNhanVien);
        }

        // POST: LuongNhanViens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.LuongNhanVien == null)
            {
                return Problem("Entity set 'QLNSContext.LuongNhanVien'  is null.");
            }
            var luongNhanVien = await _context.LuongNhanVien.FindAsync(id);
            if (luongNhanVien != null)
            {
                _context.LuongNhanVien.Remove(luongNhanVien);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LuongNhanVienExists(string id)
        {
          return (_context.LuongNhanVien?.Any(e => e.MaLuong == id)).GetValueOrDefault();
        }
    }
}
