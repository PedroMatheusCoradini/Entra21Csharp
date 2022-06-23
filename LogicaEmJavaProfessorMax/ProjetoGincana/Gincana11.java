import java.util.Scanner;

public class Gincana11
{
    public static void main(String args[])
    {
        Scanner input = new Scanner(System.in);
        
        System.out.print("Insira graus c");
        int celcius = input.nextInt();
        System.out.println(((celcius * 9) / 5) + 32 + " Farennheit");
        System.out.println(celcius + 273 + " Kelvin");
    }
}