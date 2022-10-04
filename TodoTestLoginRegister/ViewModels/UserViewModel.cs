using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TodoTestLoginRegister.ViewModels;

public class UserViewModel
{
    public int Id { get; set; }

    [DisplayName("Titulo")]
    [Required(ErrorMessage = "Campo obrigatorio")]
    public string Title { get; set; }
}
