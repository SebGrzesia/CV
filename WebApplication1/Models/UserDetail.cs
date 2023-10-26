using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class UserDetail : User
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string[] Skills { get; set; }
        public string[] Language { get; set; }
        public string About { get; set; }
        
        public UserDetail()
        {
            Id = Guid.NewGuid();
        }
    }
}
