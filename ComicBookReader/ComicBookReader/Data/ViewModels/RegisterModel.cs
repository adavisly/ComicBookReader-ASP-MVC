using System.ComponentModel.DataAnnotations;
namespace ComicBookReader.Data.ViewModels
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Не указано имя")]
        public string UserFirstName { get; set; }

        [Required(ErrorMessage = "Не указана Фамилия")]
        public string UserLastName { get; set; }

        [Required(ErrorMessage = "Не указан Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароль введен неверно")]
        public string ConfirmPassword { get; set; }
    }
}
