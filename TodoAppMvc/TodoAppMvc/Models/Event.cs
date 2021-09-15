using System;
using System.ComponentModel.DataAnnotations;

namespace TodoAppMvc.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [Display(Name ="Due Date")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DueDate { get; set; }

        [Display(Name = "Due Time")]
        [DataType(DataType.Time)]
        [Required]
        public DateTime DateTime { get; set; }

        public string Color { get; set; }
    }
}
