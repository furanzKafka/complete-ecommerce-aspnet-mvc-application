using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="logo")]
        public string Logo { get; set; }
        [Display(Name = "name")]
        public string Name { get; set; }
        [Display(Name = "description")]
        public string Description { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
