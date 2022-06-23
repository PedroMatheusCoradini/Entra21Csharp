import java.util.Scanner;

public class Gincana5
{
    public static void main(String args[])
    {
        Scanner input = new Scanner(System.in);
        
        System.out.print("Informe um numero: ");
        int numero = input.nextInt();
        
        if (numero % 2 == 0)
        {
            System.out.print("Par");
        }
        else
        {
            System.out.print("Impar");
        }
    }
}