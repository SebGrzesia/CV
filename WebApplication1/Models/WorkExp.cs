using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class WorkExp : User
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string Position { get; set; }
        public string Details { get; set; }

        public WorkExp()
        {
            Id = Guid.NewGuid();
        }
    }
}
