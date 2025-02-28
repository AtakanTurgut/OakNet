﻿using System.ComponentModel.DataAnnotations;

namespace OakApi.Model
{
	public class Salary
	{
        public Salary()
        {
            Persons = new HashSet<Person>();
        }

        [Key]
        public int SalaryId { get; set; }
        [Required]
        public int Amount { get; set; }

        public virtual ICollection<Person> Persons { get; set; }
    }
}
