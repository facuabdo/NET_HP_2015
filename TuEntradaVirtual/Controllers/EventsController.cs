using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using BusinessLayer;
using Entities;


namespace TuEntradaVirtual.Controllers
{
    public class EventsController : Controller
    {
        private static EventsBL eventBusiness = new EventsBL();

        // GET: Events
        public ActionResult Index()
        {
            IList<Events> events = eventBusiness.getAllEvents().ToList();
            return View(events);
        }

        // GET: Events/Details/5
        public ActionResult Details(Guid id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Events events = eventBusiness.getEventById(id);

            if (events == null)
            {
                return HttpNotFound();
            }
            return View(events);
        }

        // GET: Events/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Events/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "eventId,name,description,startDate,minage")] Events events)
        {
            if (ModelState.IsValid)
            {
                events.eventId = Guid.NewGuid();
                eventBusiness.createEvent(events);
                return RedirectToAction("Index");
            }

            return View(events);
        }

        // GET: Events/Edit/5
        public ActionResult Edit(Guid id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Events events = eventBusiness.getEventById(id);

            if (events == null)
            {
                return HttpNotFound();
            }
            return View(events);
        }

        // POST: Events/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "eventId,name,description,startDate,minage")] Events events)
        {
            if (ModelState.IsValid)
            {
                eventBusiness.updateEvent(events);
                return RedirectToAction("Index");
            }
            return View(events);
        }

        // GET: Events/Delete/5
        public ActionResult Delete(Guid id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Events events = eventBusiness.getEventById(id);

            if (events == null)
            {
                return HttpNotFound();
            }
            return View(events);
        }

        // POST: Events/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            eventBusiness.deleteEvent(id);
            return RedirectToAction("Index");
        }
    }
}
