﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleMvc1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
			var model = new PageCommon () { Title = "Test Title", Message = "Test Message" };

			return View (model: model);
        }

		/*
        public ActionResult Details(int id)
        {
            return View ();
        }

        public ActionResult Create()
        {
            return View ();
        } 

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try {
                return RedirectToAction ("Index");
            } catch {
                return View ();
            }
        }
        
        public ActionResult Edit(int id)
        {
            return View ();
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try {
                return RedirectToAction ("Index");
            } catch {
                return View ();
            }
        }

        public ActionResult Delete(int id)
        {
            return View ();
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try {
                return RedirectToAction ("Index");
            } catch {
                return View ();
            }
        } */
    }
}