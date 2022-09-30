using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TodoTestLoginRegister.Models;

public class Todo
{
    public int Id { get; set; }

    [DisplayName("Titulo")]
    [Required(ErrorMessage = "Campo obrigatorio")]
    public string Title { get; set; }

    [DisplayName("Concluido")]
    public bool Done { get; set; }

    [DisplayName("Criado em")]
    public DateTime CreateAt { get; set; } = DateTime.Now;

    [DisplayName("Ultima atualização")]
    public DateTime LastUpdateDate { get; set; } = DateTime.Now;

    [DisplayName("Usuario")]
    public string User { get; set; }
}
