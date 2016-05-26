using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GIMS.Web.Models
{
    public class ItemInquiryVm
    {
        [Required]
        [Display(Name = "Item Number")]
        public string ItemNo { get; set; }

        [Display(Name = "HQ Plan Code")]
        public string HQPlanCode { get; set; }

        [Display(Name = "HQ SLS Code")]
        public string HQSLSCode { get; set; }

        [Display(Name = "Pricing UOM")]
        public string PricingUOM { get; set; }

        [Display(Name = "HQ Family Gp")]
        public string HQFamilyGp { get; set; }

        [Display(Name = "HQ Demand Code")]
        public string HQDemandCode { get; set; }



        [Display(Name = "Brand Origin")]
        public string BrandOrigin { get; set; }

        [Display(Name = "Product Origin")]
        public string ProductOrigin { get; set; }

        [Display(Name = "HQ Supply Code")]
        public string HQSupplyCode { get; set; }

        [Display(Name = "Unit per Carton")]
        public string UnitPerCarton { get; set; }

        
        //RC
        
        [Display(Name = "Local HQ Code")]
        public string LocalHQCode { get; set; }

        [Display(Name = "Local Code")]
        public string LocalCode { get; set; }

        [Display(Name = "AB Price")]
        public string ABPrice { get; set; }
        public string ABPrice2nd { get; set; }

        [Display(Name = "ExStockATP")]
        public string ExStockATP { get; set; }

        [Display(Name = "POATP")]
        public string POATP { get; set; }

        [Display(Name = "Local HQ Demand Code")]
        public string LocalHQDemandCode { get; set; }

        [Display(Name = "Local Demand Code")]
        public string LocalDemandCode { get; set; }

        [Display(Name = "Resv Qty")]
        public string ResvQty { get; set; }

        [Display(Name = "GIT ATP")]
        public string GitAtp { get; set; }

        public string GitRf { get; set; }

        [Display(Name = "Local HQ Family Gp")]
        public string LocalHQFamilyGp { get; set; }

        [Display(Name = "Local Family Gp")]
        public string LocalFamilyGp { get; set; }

        [Display(Name = "Unit Weight")]
        public string UnitWeight { get; set; }

        [Display(Name = "SKF EXPL Ind")]
        public string SkfExplInd { get; set; }

        [Display(Name = "INSP ATP")]
        public string InspAtp { get; set; }

        //RC end

        //SG

        [Display(Name = "List N")]
        public string ListN { get; set; }
        public string List2nd { get; set; }

        [Display(Name = "LCPL")]
        public string Lcpl { get; set; }
        public string Lcpl2nd { get; set; }

        [Display(Name = "SP")]
        public string Sp { get; set; }
        public string Sp2nd { get; set; }

        [Display(Name = "NETT1")]
        public string Nett1 { get; set; }
        public string Nett12nd { get; set; }

        [Display(Name = "Last 12 Months Highest Selling px ")]
        public string Last12MonthsHighestSellingPx  { get; set; }

        [Display(Name = "BWAC")]
        public string Bwac { get; set; }

        [Display(Name = "AU")]
        public string Au { get; set; }
        public string Au2nd { get; set; }

        [Display(Name = "SKF SPL")]
        public string SkfSpl { get; set; }
        public string SkfSpl2nd { get; set; }

        [Display(Name = "SKF EXPL")]
        public string SkfExpl { get; set; }
        public string SkfExpl2nd { get; set; }

        [Display(Name = "Last 12 Months Average Selling Px (SGD)")]
        public string Last12MonthsAverageSellingPx { get; set; }

        [Display(Name = "LCPE")]
        public string Lcpe { get; set; }
        public string Lcpe2nd { get; set; }

        [Display(Name = "LCPE2")]
        public string Lcpe2 { get; set; }
        public string Lcpe22nd { get; set; }

        [Display(Name = "NETT2")]
        public string Nett2 { get; set; }
        public string Nett22nd { get; set; }

        public ItemAdditionalInformationVm ItemAdditionalInformationVm { get; set; }
     
    }
}