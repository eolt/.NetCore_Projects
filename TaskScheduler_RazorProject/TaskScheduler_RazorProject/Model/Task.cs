using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskScheduler_RazorProject.Model
{
    public class Task
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        public DateTimeOffset DueDate { get; set; }

        [Required]
        public DateTimeOffset DueTime { get; set; }

        [Required]
        public string Color { get; set; }
    }
}
