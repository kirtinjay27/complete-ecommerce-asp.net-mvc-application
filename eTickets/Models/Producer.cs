using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
	public class Producer
	{
		[Key]
		public int Id { get; set; }
		public string ProfilePictureURL { get; set; }
		public String FullName { get; set; }
		public string Bio { get; set; }

		//Relationships

		public List<Movie> movies { get; set; }
	}
}
