using System.ComponentModel.DataAnnotations;

namespace NoteProject.Models
{
    public class Notes
    {
        [Key]
        public int NoteId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        //public DateTime DateCreate { get; set; }
        //public DateTime DateSelect { get; set; }

    }
}
