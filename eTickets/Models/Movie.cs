using eTickets.Data;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
	public class Movie
	{
		[Key]
		public int Id { get; set; }
        public string Name { get; set; }
		public string Description { get; set; }
		public double Price { get; set; }
		public string ImageURL { get; set; }
	    public DateTime Startdate{ get; set; }
		public DateTime Enddate { get; set; }
        public MovieCatagory movieCatagory { get; set; }

    }
}
