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
    public class TicketTypesController : Controller
    {
        private TicketTypesBL ticketTypesBL = new TicketTypesBL();

        // GET: TicketTypes
        public ActionResult Index()
        {
            return View(ticketTypesBL.getAllTicketTypes());
        }

        // GET: TicketTypes/Details/5
        public ActionResult Details(Guid id)
        {
            TicketTypes ticketTypes = ticketTypesBL.getTicketTypeById(id);
            if (ticketTypes == null)
            {
                return HttpNotFound();
            }
            return View(ticketTypes);
        }

        // GET: TicketTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TicketTypes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ticketTypeId,description")] TicketTypes ticketTypes)
        {
            if (ModelState.IsValid)
            {
                ticketTypes.ticketTypeId = Guid.NewGuid();
                ticketTypesBL.createTicketType(ticketTypes);
                return RedirectToAction("Index");
            }

            return View(ticketTypes);
        }

        // GET: TicketTypes/Edit/5
        public ActionResult Edit(Guid id)
        {
            TicketTypes ticketTypes = ticketTypesBL.getTicketTypeById(id);
            if (ticketTypes == null)
            {
                return HttpNotFound();
            }
            return View(ticketTypes);
        }

        // POST: TicketTypes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ticketTypeId,description")] TicketTypes ticketTypes)
        {
            if (ModelState.IsValid)
            {
                ticketTypesBL.updateTicketType(ticketTypes);
                return RedirectToAction("Index");
            }
            return View(ticketTypes);
        }

        // GET: TicketTypes/Delete/5
        public ActionResult Delete(Guid id)
        {
            TicketTypes ticketTypes = ticketTypesBL.getTicketTypeById(id);
            if (ticketTypes == null)
            {
                return HttpNotFound();
            }
            return View(ticketTypes);
        }

        // POST: TicketTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            ticketTypesBL.deleteTicketType(id);
            return RedirectToAction("Index");
        }

    }
}
