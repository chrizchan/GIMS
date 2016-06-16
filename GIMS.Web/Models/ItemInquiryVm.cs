using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using GIMS.Entities;

namespace GIMS.Web.Models
{
    public class ItemInquiryVm
    {
        //[Required]
        //[Display(Name = "Item Number")]
        public string ItemNo { get; set; }

        public ItemRCInformation ItemRcInformation { get; set; }

        public ItemSgInformation ItemSgInformation { get; set; }
     
    }
}