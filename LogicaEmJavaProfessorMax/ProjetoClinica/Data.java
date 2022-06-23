public class Data
{
    private byte dia;
    private byte mes;
    private int ano;
    
    public void setDia(byte dia)
    {
        this.dia = dia;
    }
    
    public void setMes(byte mes)
    {
        this.mes = mes;
    }
    
    public void setAno(int ano)
    {
        this.ano = ano;
    }
    
    public byte getDia()
    {
        return dia;
    }
    
    public byte getMes()
    {
        return mes;
    }
    
    public int getAno()
    {
        return ano;
    }
    
    public String toString()
    {
        return "Data: " + dia + "/" + mes + "/" + ano;
    }
}