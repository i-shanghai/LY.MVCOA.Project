using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using LY.MVCOA.BLL;
using LY.MVCOA.Models;

namespace LY.MVCOA.Project.Controllers
{
    public class SysSampleController : Controller
    {
        // GET: SysSample
        public ActionResult Index()
        {
            SysSampleBLL bll = new SysSampleBLL();
            List<SysSample> list = bll.GetList("");
            return View(list);
        }

        // GET: SysSample/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SysSample/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SysSample/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SysSample/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SysSample/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SysSample/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SysSample/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
