using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KendoTreeList.Models
{
    public class ChildData
    {
        public int Id { get; set; }
        public string PartNo { get; set; }
        public string Description { get; set; }
        public bool HasChildren { get; set; }
        public int? ParentId { get; set; }
    }
}