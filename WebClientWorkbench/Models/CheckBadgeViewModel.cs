using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IQC_WebClient_Workbench.Models
{
    public class CheckBadgeViewModel
    {
        [Required]
        public string BadgeID { get; set; }
    }
}
