using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab15.Models;
using Microsoft.Reporting.WebForms;
using System.IO;
using System.Web.Helpers;
using System.Collections;

namespace Lab15.Controllers
{
    public class PersonController : Controller
    {
        #region Contexto
        private SchoolEntities _contexto;

        public SchoolEntities Contexto
        {
            set { _contexto = value; }
            get
            {
                if (_contexto == null)
                    _contexto = new SchoolEntities();
                return _contexto
            }   
        }
        #endregion
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }
    }
}