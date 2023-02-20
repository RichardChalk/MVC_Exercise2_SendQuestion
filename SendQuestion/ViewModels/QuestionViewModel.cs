using System.ComponentModel.DataAnnotations;

namespace SendQuestion.ViewModels
{
    public class QuestionViewModel
    {
        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }
        
        [Required]

        public string Text { get; set; }
    }
}
