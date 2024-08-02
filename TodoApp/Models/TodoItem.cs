using System.ComponentModel.DataAnnotations;
using System.Data;

namespace TodoApp.Models
{
    public class TodoItem
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Task")]
        public string Title { get; set; } = string.Empty;

        [Display(Name = "Complete Task")]
        public bool IsComleted { get; set; } = false;
    }
}
