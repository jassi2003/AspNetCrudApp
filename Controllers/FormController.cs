
using formApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace formApp.Controllers
{
    public class FormController : Controller
    {
        private readonly AppDbContext _context;
        public FormController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var forms = _context.Forms.ToList();
            return View(forms);
        }

        
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
       //CREATE
        [HttpPost]
        public IActionResult Create(FormModel form)
        {
            Console.WriteLine("POST HIT");

            if (ModelState.IsValid)
            {
                _context.Forms.Add(form);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(form);
        }

        //EDIT DATA
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var form = _context.Forms.Find(id);

            if (form == null)
            {
                return NotFound();
            }
            return View(form);
        }

        [HttpPost]
        public IActionResult Edit(FormModel form)
        {
            if (ModelState.IsValid)
            {
                _context.Forms.Update(form);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(form);
        }

        //DELETE DATA
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var form = _context.Forms.Find(id);

            if (form == null)
            {
                return NotFound();
            }

            return View(form);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var form = _context.Forms.Find(id);

            if (form != null)
            {
                _context.Forms.Remove(form);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
