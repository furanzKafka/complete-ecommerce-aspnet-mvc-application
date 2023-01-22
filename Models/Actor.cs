using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="full name")]
        public string FullName { get; set; }
        [Display(Name = "biography")]
        public string Bio { get; set; }
        [Display(Name = "profile picture ")]
        public string ProfilePictureURL { get; set; }
        public List<ActorMovie> ActorMovies { get; set; }
    }
}
