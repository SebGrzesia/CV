using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class User
    {
        //public Guid Idx { get; set; } //po co to nie wiem
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public User()
        {
            //Idx = Guid.NewGuid();
            Id = Guid.NewGuid();
        }
    }
}
