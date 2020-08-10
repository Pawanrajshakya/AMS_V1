using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Persistence_Layer.Models
{
    public class Group : Audit
    {
        [Required]

        public string Description { get; set; }

        public int SortId { get; set; }
    }
}
