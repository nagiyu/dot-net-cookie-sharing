﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Auth;

namespace Web.Framework.Controllers
{
    [CustomAuthorize]
    public class PrivateController : Controller
    {
        // GET: Private
        public ActionResult Index()
        {
            return View();
        }
    }
}