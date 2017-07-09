using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AngularJS_CRUD_ASPNET_MVC5.Models;

namespace AngularJS_CRUD_ASPNET_MVC5.Controllers
{
    public class EmployeeController : Controller
    {               
        // GET Employee/GetEmployee
        public JsonResult GetEmployee()
        {
            using (LearningDBEntities db = new LearningDBEntities())
            {
                List<Employee> empList = db.Employees.ToList();
                return Json(empList, JsonRequestBehavior.AllowGet);
            }
               
        }

    }
}