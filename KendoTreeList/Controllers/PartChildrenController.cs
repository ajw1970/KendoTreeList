using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KendoTreeList.Models;

namespace KendoTreeList.Controllers
{
    public class PartChildrenController : Controller
    {
        // GET: PaChildren
        public JsonResult Index(int? id)
        {
            var data = new List<ChildData>
            {
                new ChildData
                {
                    Id = 1,
                    PartNo = "Top Level",
                    Description = "Top Level Part",
                    HasChildren = true,
                    ParentId = null
                },
                new ChildData
                {
                    Id = 2,
                    PartNo = "Second Level",
                    Description = "Second Level Part",
                    HasChildren = true,
                    ParentId = 1
                },
                new ChildData
                {
                    Id = 3,
                    PartNo = "Third Level",
                    Description = "Third Level Part",
                    HasChildren = false,
                    ParentId = 2
                },
            };

            var children = data
                .Where(c => c.ParentId == id);

            var result = Json(children, JsonRequestBehavior.AllowGet);
            return result;
        }




    }


}