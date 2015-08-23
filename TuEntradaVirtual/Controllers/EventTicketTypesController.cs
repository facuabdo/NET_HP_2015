using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Entities;
using BusinessLayer;

namespace TuEntradaVirtual.Controllers
{
    public class EventTicketTypesController : Controller
    {
        private EventTicketTypesBL eventTicketType = new EventTicketTypesBL();
        private TicketTypesBL ticketType = new TicketTypesBL();
        private EventsBL events = new EventsBL();

        // GET: EventTicketTypes
        public ActionResult Index()
        {
            return View(eventTicketType.getAllEventTicketTypes());
        }

        // GET: EventTicketTypes/Details/5
        public ActionResult Details(Guid id, Guid idEvent)
        {
            EventTicketTypes eventTicketTypes = eventTicketType.getEventTicketTypeByIds(id, idEvent); 
            if (eventTicketTypes == null)
            {
                return HttpNotFound();
            }
            return View(eventTicketTypes);
        }

        // GET: EventTicketTypes/Create
        public ActionResult Create()
        {
            ViewBag.eventId = new SelectList(events.getAllEvents(), "eventId", "name");
            ViewBag.ticketTypeId = new SelectList(ticketType.getAllTicketTypes(), "ticketTypeId", "description");
            return View();
        }

        // POST: EventTicketTypes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ticketTypeId,eventId,price,totalTickets")] EventTicketTypes eventTicketTypes)
        {
            if (ModelState.IsValid)
            {
                eventTicketType.createEventTicketType(eventTicketTypes);
                return RedirectToAction("Index");
            }

            ViewBag.eventId = new SelectList(events.getAllEvents(), "eventId", "name", eventTicketTypes.eventId);
            ViewBag.ticketTypeId = new SelectList(ticketType.getAllTicketTypes(), "ticketTypeId", "description", eventTicketTypes.ticketTypeId);
            return View(eventTicketTypes);
        }

        // GET: EventTicketTypes/Edit/5
        public ActionResult Edit(Guid id, Guid idEvent)
        {
            EventTicketTypes eventTicketTypes = eventTicketType.getEventTicketTypeByIds(id, idEvent);
            if (eventTicketTypes == null)
            {
                return HttpNotFound();
            }
            ViewBag.eventId = new SelectList(events.getAllEvents(), "eventId", "name", eventTicketTypes.eventId);
            ViewBag.ticketTypeId = new SelectList(ticketType.getAllTicketTypes(), "ticketTypeId", "description", eventTicketTypes.ticketTypeId);
            return View(eventTicketTypes);
        }

        // POST: EventTicketTypes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ticketTypeId,eventId,price,totalTickets")] EventTicketTypes eventTicketTypes)
        {
            if (ModelState.IsValid)
            {
                eventTicketType.updateEventTicketType(eventTicketTypes);
                return RedirectToAction("Index");
            }
            ViewBag.eventId = new SelectList(events.getAllEvents(), "eventId", "name", eventTicketTypes.eventId);
            ViewBag.ticketTypeId = new SelectList(ticketType.getAllTicketTypes(), "ticketTypeId", "description", eventTicketTypes.ticketTypeId);
            return View(eventTicketTypes);
        }

        // GET: EventTicketTypes/Delete/5
        public ActionResult Delete(Guid id, Guid idEvent)
        {

            EventTicketTypes eventTicketTypes = eventTicketType.getEventTicketTypeByIds(id, idEvent);
            if (eventTicketTypes == null)
            {
                return HttpNotFound();
            }
            return View(eventTicketTypes);
        }

        // POST: EventTicketTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id, Guid idEvent)
        {
            eventTicketType.deleteEventTicketType(id, idEvent);
            return RedirectToAction("Index");
        }


    }
}
