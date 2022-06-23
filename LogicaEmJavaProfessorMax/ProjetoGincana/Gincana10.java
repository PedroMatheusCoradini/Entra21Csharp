import java.util.Scanner;

public class Gincana10
{
    public static void main(String args[])
    {
        Scanner input = new Scanner(System.in);
        
        int candidato1 = 0;
        int candidato2 = 0;
        int candidato3 = 0;
        int candidato4 = 0;
        int candidato5 = 0;
        
        System.out.println("Pedro (1)");
        System.out.println("Joao (2)");
        System.out.println("Maria (3)");
        System.out.println("Vitor (4)");
        System.out.println("Max (5)");
        
        System.out.println("Informe os 6 votos");
        
        for (int i = 1; i <= 6; i++)
        {
            int voto1 = input.nextInt();
            if (voto1 == 1)
            {
                candidato1 += 1;
            }
            else if(voto1 == 2)
            {
                candidato2 += 1;
            }
            else if(voto1 == 3)
            {
                candidato3 += 1;
            }
            else if(voto1 == 4)
            {
                candidato4 += 1;
            }
            else if(voto1 == 5)
            {
                candidato5 += 1;
            }
        }
        System.out.println("Pedro " + candidato1);
        System.out.println("Joao " + candidato2);
        System.out.println("Maria " + candidato3);
        System.out.println("Vitor " + candidato4);
        System.out.println("Max " + candidato5);
    }
}