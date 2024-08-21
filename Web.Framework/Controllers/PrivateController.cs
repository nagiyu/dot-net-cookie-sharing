﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Framework.Controllers
{
    [Authorize]
    public class PrivateController : Controller
    {
        // GET: Private
        public ActionResult Index()
        {
            return View();
        }
    }
}