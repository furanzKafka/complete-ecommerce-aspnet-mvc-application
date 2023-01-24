using eTickets.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Full Name")]
        [Required(ErrorMessage ="fullname is required")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        [Required(ErrorMessage = "biography is required")]

        public string Bio { get; set; }
        [Display(Name = "Profile Picture ")]
        [Required(ErrorMessage = "profile picture is required")]

        public string ProfilePictureURL { get; set; }
        public List<Movie>? Movies { get; set; }
    }
}
