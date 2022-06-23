public class Paciente
{
    private String nome;
    private String rg;
    private Data dataDeNascimento;
    private double peso;
    private byte sexo;
    
    public Paciente()
    {
        dataDeNascimento = new Data();
    }
    
    public void setNome(String nome)
    {
        this.nome = nome;
    }
    
    public void setRg(String rg)
    {
        this.rg = rg;
    }
    
    public void setDataDeNascimento(Data dataDeNascimento)
    {
        this.dataDeNascimento = dataDeNascimento;
    }
    
    public void setPeso(double peso)
    {
        this.peso = peso;
    }
    
    public void setSexo(byte sexo)
    {
        this.sexo = sexo;
    }
    
    public String getNome()
    {
        return nome;
    }
    
    public String getRg()
    {
        return rg;
    }
    
    public Data getDataDeNascimento()
    {
        return dataDeNascimento;
    }
    
    public double getPeso()
    {
        return peso;
    }
    
    public byte getSexo()
    {
        return sexo;
    }
    
    public boolean validarSexo()
    {
        if ((sexo == 1) || (sexo == 2))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    public String toString()
    {
        return "Nome do paciente: " + nome + "\nRG: " + rg + "\nData de nascimento: " + dataDeNascimento + "Peso: " + peso + "Sexo: " + sexo;
    }
}