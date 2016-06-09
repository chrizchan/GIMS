using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GIMS.Entities;

namespace GIMS.Web.Models
{
    public class ItemVm
    {
        public ItemRCInformation ItemRcInformation { get; set; }
        public ItemAdditionalInformation ItemAdditionalInformation { get; set; }


    }
}