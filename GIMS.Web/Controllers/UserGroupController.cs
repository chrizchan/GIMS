﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GIMS.Web.Controllers
{
    public class UserGroupController : Controller
    {
        //
        // GET: /UserGroup/

        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
    }
}
