import java.util.Scanner;

public class Gincana4
{
    public static void main(String args[])
    {
        Scanner input = new Scanner(System.in);
        
        System.out.print("Informe um valor");
        int valor1 = input.nextInt();
        
        if (valor1 > 20)
        {
            System.out.print("Ganhador");
        }
        else if(valor1 < 20)
        {
            System.out.print("Perdedor");
        }
        else
        {
            System.out.print("Empate");
        }
    }
}