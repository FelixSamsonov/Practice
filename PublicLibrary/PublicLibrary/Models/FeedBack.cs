using System.ComponentModel.DataAnnotations;

namespace PublicLibrary.Models
{
    public class FeedBack
    {
        [Required(ErrorMessage ="You have to write your name")]
        public string Name {  get; set; }

        [Required(ErrorMessage = "You have to write your surname")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "You have to write your age")]
        public int Age { get; set; }
        [Required(ErrorMessage = "You have to write your email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "You have to write your message")]
        [StringLength(50, ErrorMessage ="Text has to be more than 50 letters")]
        public string Message { get; set; }
    }
}
