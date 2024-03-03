using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OakApi.Model
{
	public class PersonDetail
	{
		[Key]
        public int PersonDetailId { get; set; }
        public string? PersonCity { get; set; }
        public DateTime BirthDay { get; set; }

        [ForeignKey("Person")]
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
