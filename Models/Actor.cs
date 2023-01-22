using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "full name")]
        [Required(ErrorMessage = "full name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "must be between 3-50 chars")]
        public string FullName { get; set; }
        [Display(Name = "biography")]
        [Required(ErrorMessage = "bio is required")]
        public string Bio { get; set; }
        [Display(Name = "profile picture ")]
        [Required(ErrorMessage = "profile picture is required")]
        public string ProfilePictureURL { get; set; }
        public List<ActorMovie>? ActorMovies { get; set; }
    }
}
