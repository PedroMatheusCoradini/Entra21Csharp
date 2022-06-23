import java.util.Scanner;

public class Gincana6
{
    public static void main(String args[])
    {
        Scanner input = new Scanner(System.in);
        
        System.out.print("Informe 6 numeros: ");
        int numero1 = input.nextInt();
        int numero2 = input.nextInt();
       
        if (numero1 > numero2)
        {
            System.out.println(numero1);
            System.out.print(numero2);
        }
        else
        {
            System.out.println(numero2);
            System.out.print(numero1);
        }
    }
}