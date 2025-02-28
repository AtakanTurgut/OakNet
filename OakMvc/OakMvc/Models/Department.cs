﻿using System.ComponentModel.DataAnnotations;

namespace OakMvc.Models
{
	public class Department
	{
        public int DepartmentId { get; set; }
        [Required(ErrorMessage = "Please fill department Name Area!")]
        public string? DepartmentName { get; set; }
    }
}
