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
        public JsonResult Index(int? id, bool returnNullParentId = false)
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
                .Where(c => c.ParentId == id)
                .Select(c => new ChildData()
                {
                    Id = c.Id,
                    PartNo = c.PartNo,
                    Description = c.Description,
                    HasChildren = c.HasChildren,
                    ParentId = returnNullParentId ? null : c.ParentId
                });

            var result = Json(children, JsonRequestBehavior.AllowGet);
            return result;
        }




    }


}