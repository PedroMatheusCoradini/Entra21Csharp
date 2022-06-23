public class Consulta
{
    private Data data;
    private String hora;
    private Medico medico;
    private Paciente paciente;
    
    public Consulta()
    {
        data = new Data();
        medico = new Medico();
        paciente = new Paciente();
    }
    
    public void setData(Data data)
    {
        this.data = data;
    }
    
    public void setHora(String hora)
    {
        this.hora = hora;
    }
    
    public void setMedico(Medico medico)
    {
        this.medico = medico;
    }
    
    public void setPaciente(Paciente paciente)
    {
        this.paciente = paciente;
    }
    
    public Data getData()
    {
        return data;
    }
    
    public String getHora()
    {
        return hora;
    }
    
    public Medico getMedico()
    {
        return medico;
    }
    
    public Paciente getPaciente()
    {
        return paciente;
    }
    
    public String toString()
    {
        return "Consulta:" + "\nPaciente: " + paciente + "\nData: " + data + "\nHora: " + hora +
 "\nMédico: " + medico;
    }
}