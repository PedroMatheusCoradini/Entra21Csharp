import java.util.Scanner;

public class Gincana8
{
    public static void main(String args[])
    {
        Scanner input = new Scanner(System.in);
        
        int nota1;
        int nota2;
        int nota3;
        int nota4;
        int frequenciaDoAluno;
        
        System.out.println("Informe as 4 notas do aluno: ");
        nota1 = input.nextInt();
        nota2 = input.nextInt();
        nota3 = input.nextInt();
        nota4 = input.nextInt();
        
        System.out.println("Informe a frequencia do aluno: ");
        frequenciaDoAluno = input.nextInt();
        
        int media = (nota1 + nota2 + nota3 + nota4) / 4;
        
        if (media >= 7 && frequenciaDoAluno >= 75)
        {
            System.out.print("Aprovado");
        }
        else
        {
            System.out.print("Reprovado");
        }
    }
}