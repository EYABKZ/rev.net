using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Examen.UI.Web.Controllers
{
    public class ArtisteController : Controller
    {

        IArtisteService ats;

            public ArtisteController(IArtisteService ats)
        {
            this.ats =ats;
        }




        // GET: ArtisteController
        public ActionResult Index()
        {
            return View(ats.GetMany());
        }

        // GET: ArtisteController/Details/5
        public ActionResult Details(int id)
        {
            return View(ats.GetById(id));
        }

        // GET: ArtisteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ArtisteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Artiste collection)
        {
            try
            {

                ats.Add(collection);
                ats.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
     
                return View();
            }
        }

        // GET: ArtisteController/Edit/5
        public ActionResult Edit(int id)
        {
           
            return View(ats.GetById(id));
        }

        // POST: ArtisteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Artiste collection)
        {
            try
            {
                ats.Update(collection);
                ats.Commit();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ArtisteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(ats.GetById(id));
        }

        // POST: ArtisteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                ats.Delete(ats.GetById(id));
                ats.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
