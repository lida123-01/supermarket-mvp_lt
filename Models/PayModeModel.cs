using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace supermarket_mvp_lt.Models
{
    internal class PayModeModel
    {
        [DisplayName("Pay Mode Id")]
        public int Id { get; set; }

        [DisplayName("Pay Mode Name")]
        [Required(ErrorMessage = "Pay Mode Name is required")]
        [StringLength(50, MinimumLength= 3, ErrorMessage = "Pay mode name must be between 3 and  50 characteres")]
        public string Name { get; set; }

        [DisplayName("Observation")]
        [Required(ErrorMessage = "Pay mode Observation is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Pay mode Observation must be between 3 and 200 characteres")]
        public string Observation { get; set; }
    }
}
