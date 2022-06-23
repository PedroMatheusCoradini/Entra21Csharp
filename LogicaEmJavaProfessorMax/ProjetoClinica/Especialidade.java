public class Especialidade
{
    private String especialidade;
    private double valorConsulta;
    
    public void setEspecialidade(String especialidade)
    {
        this.especialidade = especialidade;
    }
    
    public void setValorConsulta(double valorConsulta)
    {
        this.valorConsulta = valorConsulta;
    }
    
    public String getEspecialidade()
    {
        return especialidade;
    }
    
    public double getValorConsulta()
    {
        return valorConsulta;
    }
    
    public String toString()
    {
        return "Especialidade: " + especialidade + "\nValor da consulta: " + valorConsulta;
    }
}