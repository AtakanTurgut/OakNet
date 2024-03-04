using Microsoft.CodeAnalysis.Elfie.Diagnostics;
using System.ComponentModel.DataAnnotations;

namespace OakMvc.Models
{
	public class Person
	{
        public int PersonId { get; set; }
        [Required]
        public string? Name { get; set; }
		[Required]
		public string? Surname { get; set; }
		[Required]
		public int Age { get; set; }
		[Required]
		public string? Email { get; set; }
		[Required]
        public string? Password { get; set; }
        public string? Address { get; set; }

        public int PositionId { get; set; }
        public int SalaryId { get; set; }
    }
}
