import java.util.Scanner;
import java.util.ArrayList;

public class Principal
{
    public static void main(String args[])
    {
        Scanner ler = new Scanner(System.in);
        
        ClinicaMedica cm = new ClinicaMedica();
        int opcao;
        
        do
        {
            System.out.println("(1) Cadastrar Médico");
            System.out.println("(2) Cadastrar Paciente");
            System.out.println("(3) Marcar consulta");
            System.out.println("(4) Desmarcar consulta");
            System.out.println("(5) Listar consultas por dia");
            System.out.println("(6) Listar consultas por médico");
            System.out.println("(7) Listar consultas por especialidade");
            System.out.println("(8) Listar consultas por paciente");
            System.out.println("(9) Calcular total em caixa do dia");
            System.out.println("(0) Encerrar");
            
            opcao = ler.nextInt();
            System.out.println();
            
            switch(opcao)
            {
                case 1:
                    Medico md = new Medico();
                    
                    System.out.print("Digite o nome do médico:");
                    md.setNome(ler.next());
                    
                    System.out.print("Digite sua especialidade: ");
                    //String especialidadeSelecionada = ler.nextLine();
                   // md.getEspecialidade().setEspecialidade(especialidadeSelecionada); 
                    md.getEspecialidade().setEspecialidade(ler.next());
                    
                    cm.cadastrarMedico(md);
                    System.out.println("Medico cadastrado com sucesso!");
                    break;
                    
                case 2:
                    Paciente pt = new Paciente();
                    System.out.println("Digite o nome do paciente: ");
                    pt.setNome(ler.next());
                    System.out.println("Digite o RG do paciente: ");
                    pt.setRg(ler.next());
                    System.out.println("Digite a data de nascimento, peso e sexo do paciente!!");
                    System.out.println();
                    System.out.print("Digite o dia: ");
                    pt.getDataDeNascimento().setDia(ler.nextByte());
                    System.out.print("Digite o mês: ");
                    pt.getDataDeNascimento().setMes(ler.nextByte());
                    System.out.print("Digite o ano: ");
                    pt.getDataDeNascimento().setAno(ler.nextInt());
                    System.out.print("Digite o peso do paciente: ");
                    pt.setPeso(ler.nextDouble());
                    System.out.print("Digite o sexo do paciente: ");
                    System.out.print("Digite: (1) Masculino \n(2) Feminino");
                    pt.setSexo(ler.nextByte());
                    
                    cm.cadastrarPaciente(pt);
                    System.out.println("\fPaciente cadastrado com sucesso!!");
                    break;
                 
                case 3:
                    Consulta ct = new Consulta();
                    System.out.println("Digite o nome do paciente: ");
                    ct.getPaciente().setNome(ler.next());
                    System.out.println("Digite o RG do paciente: ");
                    ct.getPaciente().setRg(ler.next());
                    
                    System.out.println("Digite o nome do médico que fará a consulta: ");
                    ct.getMedico().setNome(ler.next());
                    System.out.println("Digite a data da consulta: ");
                    System.out.println("Digite o dia: ");
                    ct.getData().setDia(ler.nextByte());
                    System.out.println("Digite o mês: ");
                    ct.getData().setMes(ler.nextByte());
                    System.out.println("Digite o ano: ");
                    ct.getData().setAno(ler.nextInt());
                    
                    System.out.println("Digite o horário da consulta: ");
                    ct.setHora(ler.next());
                    
                    if(cm.buscarMedico(ct.getMedico().getNome()) != null)
                    {
                        System.out.print("\fMédico já tem uma consulta marcada neste dia e horário!!");
                    }
                    else if(cm.buscarPacienteRg(ct.getPaciente().getRg()) != null)
                    {
                        System.out.print("\fPaciente já tem uma consulta marcada neste dia e horário!!");
                    }
                    else
                    {
                        cm.marcarConsulta(ct);
                        System.out.print("Consulta marcada com sucesso!!");
                    }
                    
                    break;
            }
        }while(opcao != 0);
    }
}