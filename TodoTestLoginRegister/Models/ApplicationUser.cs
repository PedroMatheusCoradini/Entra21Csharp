using Microsoft.AspNetCore.Identity;

namespace TodoTestLoginRegister.Models;

public class ApplicationUser : IdentityUser
{
    public string CPF { get; set; }
    public string NomeCompleto { get; set; }
    public string Adress { get; set; }
    public string CEP { get; set; }
}
