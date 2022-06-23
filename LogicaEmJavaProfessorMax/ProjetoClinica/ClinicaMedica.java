import java.util.ArrayList;
import java.util.Scanner;

public class ClinicaMedica
{
    private ArrayList<Medico> listaDeMedicos;
    private ArrayList<Paciente> listaDePacientes;
    private ArrayList<Consulta> listaDeConsultas;
    
    public ClinicaMedica()
    {
        listaDeMedicos = new ArrayList<Medico>();
        listaDePacientes = new ArrayList<Paciente>();
        listaDeConsultas = new ArrayList<Consulta>();
    }
    
    public ArrayList<Medico> getListaDeMedicos()
    {
        return listaDeMedicos;
    }
    
    public ArrayList<Paciente> getListaDePacientes()
    {
        return listaDePacientes;
    }
    
    public ArrayList<Consulta> getListaDeConsultas()
    {
        return listaDeConsultas;
    }
    
    public void marcarConsulta(Consulta consulta)
    {
        listaDeConsultas.add(consulta);
    }
    
    public void cadastrarMedico(Medico medico)
    {
        listaDeMedicos.add(medico);
    }
    
    public void cadastrarPaciente(Paciente p)
    {
        listaDePacientes.add(p);
    }
    
    public double calcularTotalEmCaixa(Data data)
    {
        double total = 0;
        
        for (int i = 0; i < listaDeConsultas.size(); i++)
        {
            if (listaDeConsultas.get(i).getData() == (data))
            {
                total = total + listaDeConsultas.get(i).getMedico().getEspecialidade().getValorConsulta();
            }
        }
        return total;
    }
    
    public Medico buscarMedico(String medico)
    {
        Medico med = null;
        
        for (int i = 0; i < listaDeMedicos.size() && med == null; i++)
        {
            if (listaDeMedicos.get(i).getNome().equalsIgnoreCase(medico))
            {
                med = listaDeMedicos.get(i);
            }
        }
        return med;
    }
    
    public Paciente buscarPacienteRg(String pacRg)
    {
        Paciente p = null;
        
        for(int i = 0; i < listaDePacientes.size() && p == null; i++)
        {
            if(listaDePacientes.get(i).getRg().equalsIgnoreCase(pacRg))
            {
                p = listaDePacientes.get(i);
            }
        }
        return p;
    }
    
    public Consulta buscaConsultaData(byte dia, byte mes, byte ano)
    {
        Consulta c = null;
        
        for (int i = 0; i < listaDeConsultas.size() && c == null; i++)
        {
            if (listaDeConsultas.get(i).getData().getDia() == dia &&
            listaDeConsultas.get(i).getData().getMes() == mes &&
            listaDeConsultas.get(i).getData().getAno() == ano)
            {
                c = listaDeConsultas.get(i);
            }
        }
        return c;
    }
    
    public Consulta buscarConsultaHora(String cHora)
    {
        Consulta ch = null;
        
        for (int i = 0; i < listaDeConsultas.size() && ch == null; i++)
        {
            if (listaDeConsultas.get(i).getHora().equalsIgnoreCase(cHora))
            {
                ch = listaDeConsultas.get(i);
            }
        }
        return ch;
    }
}
