public class Medico
{
    private String nome;
    private Especialidade especialidade;
    
    public Medico()
    {
        especialidade = new Especialidade();
    }
    
    public void setNome(String nome)
    {
        this.nome = nome;
    }
    
    public void setEspecialidade(Especialidade especialidade)
    {
        this.especialidade = especialidade;
    }
    
    public String getNome()
    {
        return nome;
    }
    
    public Especialidade getEspecialidade()
    {
        return especialidade;
    }
    
    public String toString()
    {
        return "Nome: " + nome + "/nEspecialidade: " + especialidade;
    }
}
