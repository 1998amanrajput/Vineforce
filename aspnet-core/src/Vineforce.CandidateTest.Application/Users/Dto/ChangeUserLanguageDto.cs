using System.ComponentModel.DataAnnotations;

namespace Vineforce.CandidateTest.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}