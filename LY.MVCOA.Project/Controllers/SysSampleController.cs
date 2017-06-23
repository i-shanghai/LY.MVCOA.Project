using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LY.MVCOA.Models.Sys;
using Microsoft.Practices.Unity; 
using LY.MVCOA.BLL;
using LY.MVCOA.Models;
using LY.MVCOA.IBLL;

namespace LY.MVCOA.Project.Controllers
{
    public class SysSampleController : Controller
    {
        //
        // GET: /SysSample/
        /// <summary>
        /// 业务层注入
        /// </summary>
        [Dependency]
        public ISysSampleBLL m_BLL { get; set; }
        public ActionResult Index()
        {
            IEnumerable<SysSampleModel> list = m_BLL.GetList("");
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
