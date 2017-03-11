using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Data;
using ContosoUniversity.Models.SchoolViewModels;

namespace ContosoUniversity.Controllers
{
    public class StudentViewModelsController : Controller
    {
        private readonly SchoolContext _context;

        public StudentViewModelsController(SchoolContext context)
        {
            _context = context;    
        }

        // GET: StudentViewModels
        public async Task<IActionResult> Index()
        {
            //List<StudentViewModel> model = new List<StudentViewModel>();


            return View(await _context.Students.ToListAsync());
        }

        // GET: StudentViewModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            if(!StudentViewModelExists((int)id))
            {
                return NotFound();
            }
            StudentViewModel studentViewModel = new StudentViewModel();
            studentViewModel.Student =  await _context.Students.SingleOrDefaultAsync(m => m.Id == id);
            studentViewModel.Enrollments = await _context.Enrollments.Where(s => s.StudentId == id)
                .Include(c => c.Course)
                .AsNoTracking()
                .ToListAsync();

            studentViewModel.CourseAssignments = await _context.CourseAssignments
                .Where(c => studentViewModel.Enrollments.Select(e => e.CourseId).Contains(c.CourseId))
                .Include(i => i.Instructor)
                .AsNoTracking()
                .ToListAsync();

            if (studentViewModel == null)
            {
                return NotFound();
            }

            return View(studentViewModel);
        }

        // GET: StudentViewModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StudentViewModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id")] StudentViewModel studentViewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(studentViewModel);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(studentViewModel);
        }

        // GET: StudentViewModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentViewModel = await _context.Students.SingleOrDefaultAsync(m => m.Id == id);
            if (studentViewModel == null)
            {
                return NotFound();
            }
            return View(studentViewModel);
        }

        // POST: StudentViewModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id")] StudentViewModel studentViewModel)
        {
            if (id != studentViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studentViewModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentViewModelExists(studentViewModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(studentViewModel);
        }

        // GET: StudentViewModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentViewModel = await _context.Students.SingleOrDefaultAsync(m => m.Id == id);
            if (studentViewModel == null)
            {
                return NotFound();
            }

            return View(studentViewModel);
        }

        // POST: StudentViewModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var studentViewModel = await _context.Students.SingleOrDefaultAsync(m => m.Id == id);
            _context.Students.Remove(studentViewModel);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool StudentViewModelExists(int id)
        {
            return _context.Students.Any(e => e.Id == id);
        }
    }
}
