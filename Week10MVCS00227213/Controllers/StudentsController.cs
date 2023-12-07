using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataModel;
using X.PagedList;
using X.PagedList.Mvc.Core;

namespace Week10MVCS00227213.Controllers
{
    public class StudentsController : Controller
    {
        private readonly SchoolContext _context;

        public StudentsController(SchoolContext context)
        {
            // Initialization of the database context.
            _context = context;
        }

        // Index action for displaying the list of students with paging, sorting, and searching.
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            // Sorting parameters.
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";

            // Search and paging parameters.
            ViewBag.CurrentSearch = searchString;
            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewBag.CurrentFilter = searchString;

            // Building the query for students, applying search and sorting as necessary.
            var students = from s in _context.Students select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                students = students.Where(s => s.FirstName.Contains(searchString) || s.SecondName.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    students = students.OrderByDescending(s => s.FirstName).ThenByDescending(s => s.SecondName);
                    break;
                case "Date":
                    students = students.OrderBy(s => s.RegistrationDate);
                    break;
                case "date_desc":
                    students = students.OrderByDescending(s => s.RegistrationDate);
                    break;
                default:
                    students = students.OrderBy(s => s.FirstName).ThenBy(s => s.SecondName);
                    break;
            }

            // Page size and number for pagination.
            int pageSize = 10;
            int pageNumber = (page ?? 1);

            // Return the view with a paged list of students.
            return View(await students.ToPagedListAsync(pageNumber, pageSize));
        }

        // Details action to display a single student's details.
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            var student = await _context.Students.FirstOrDefaultAsync(m => m.StudentID == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // Action to present a form for creating a new student.
        public IActionResult Create()
        {
            return View();
        }

        // GET: Students/_Create
        // This method is used to display a partial view for creating a student in a modal dialog.
        public IActionResult _Create()
        {
            return PartialView("_Create", new Student { RegistrationDate = DateTime.Now });
        }

        // POST: Students/_Create
        // This method handles the form submission from the modal dialog for creating a new student.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _Create([Bind("StudentID,FirstName,SecondName,RegistrationDate")] Student student)
        {
            string ModalMessage = "";
            if (ModelState.IsValid)
            {
                _context.Add(student);
                await _context.SaveChangesAsync();
                ModalMessage = "Student added successfully!";
            }
            else
            {
                ModalMessage = "An error occurred. Please check your data.";
            }
            return RedirectToAction(nameof(Index), new { ModalMessage = ModalMessage });
        }

        // Action to handle the post request for creating a new student.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StudentID,FirstName,SecondName,RegistrationDate")] Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Add(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // Action to present a form for editing an existing student's details.
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            var student = await _context.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // Action to handle the post request for editing an existing student.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("StudentID,FirstName,SecondName,RegistrationDate")] Student student)
        {
            if (id != student.StudentID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(student);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(student.StudentID))
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
            return View(student);
        }

        // Action to present a form for confirming the deletion of a student.
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            var student = await _context.Students.FirstOrDefaultAsync(m => m.StudentID == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // Action to handle the post request for deleting a student.
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Students == null)
            {
                return Problem("Entity set 'SchoolContext.Students' is null.");
            }
            var student = await _context.Students.FindAsync(id);
            if (student != null)
            {
                _context.Students.Remove(student);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }

        // Utility method to check if a student exists.
        private bool StudentExists(string id)
        {
            return _context.Students.Any(e => e.StudentID == id);
        }
    }
}