using System.ComponentModel.DataAnnotations;

namespace NoteProject.Models
{
    public class Reminders
    {
        [Key]
        public int ReminderId { get; set; }
        public string Title { get; set; }
        public DateTime Deadline { get; set; } //для даты и времни завершения напоминания
        public bool IsComleted { get; set; }

    }
}
