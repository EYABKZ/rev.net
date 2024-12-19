using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Examen.UI.Web.Controllers
{
    public class ChansonController : Controller
    {

        IChansonService cs;
        IArtisteService ats;



            public ChansonController(IChansonService cs,IArtisteService ats)
        {
            this.cs = cs;
            this.ats = ats;
        }



        // GET: ChansonController
        public ActionResult Index()
        {
            return View(cs.GetMany());
        }



        public ActionResult Sort()
        {
            return View(cs.SortChanson());
        }







        // GET: ChansonController/Details/5
        public ActionResult Details(int id)
        {
            return View(cs.GetById(id));
           
        }

        // GET: ChansonController/Create
        public ActionResult Create()
        {
            ViewBag.Artistes = new SelectList(ats.GetMany(), "ArtisteId", "ArtisteId");
            return View();
        }

        // POST: ChansonController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Chanson collection )
        {
            try
            {
                cs.Add(collection);
                cs.Commit();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ChansonController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(cs.GetById(id));
            
        }

        // POST: ChansonController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Chanson collection)
        {
            try
            {

                cs.Update(collection);
                cs.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ChansonController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(cs.GetById(id));
        }

        // POST: ChansonController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
