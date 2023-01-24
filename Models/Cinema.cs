using eTickets.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="logo")]
        [Required(ErrorMessage ="cinema logo is required")]
        public string Logo { get; set; }
        [Display(Name = "name")]
        [Required(ErrorMessage ="cinema name is required")]
        public string Name { get; set; }
        [Display(Name = "description")]
        [Required(ErrorMessage ="descriptipn is required")]
        public string Description { get; set; }
        public List<Movie>? Movies { get; set; }
    }
}
