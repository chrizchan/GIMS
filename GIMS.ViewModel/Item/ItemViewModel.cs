using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace GIMS.ViewModel.Item
{
    public class ItemViewModel
    {
        [Required]
        public int ShortItemNo { get; set; }

        [Required]
        public string ItemNo2nd { get; set; }
    }
}
