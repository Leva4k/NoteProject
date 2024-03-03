
using System.ComponentModel.DataAnnotations;

namespace NoteProject.Models
{
    public class Tags
    {
        [Key]
        public int TagId { get; set; }
        public string Name { get; set; }
    }
}
