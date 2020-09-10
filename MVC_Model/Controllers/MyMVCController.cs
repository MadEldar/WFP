using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Model.Controllers
{
    public class MyMVCController : Controller
    {
        // GET: New
        public string Index(string id)
        {
            return id;
        }
    }
}