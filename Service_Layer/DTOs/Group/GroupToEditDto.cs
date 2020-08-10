using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Service_Layer.DTOs
{
    public class GroupToEditDto
    {
        [Required]

        public string Description { get; set; }

        public int SortId { get; set; }

        public bool IsActive { get; set; }
    }
}
