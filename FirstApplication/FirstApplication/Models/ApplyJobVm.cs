using FirstApplication.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApplication.Models
{
    public class ApplyJobVm
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int jobsId { get; set; }
        public string Question1 { get; set; }
        public string Question2 { get; set; }
        public string Question3 { get; set; }
        public string Question4 { get; set; }
        public string Question5 { get; set; }
        public virtual jobs jobs { get; set; }

    }
}
