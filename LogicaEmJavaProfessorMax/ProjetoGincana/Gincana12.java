import java.util.Scanner;

public class Gincana12
{
    public static void main(String args[])
    {
        Scanner input = new Scanner(System.in);
        System.out.print("Informe um valor: ");
        int valor = input.nextInt();
        int cinquenta = valor / 50;
        int dez = valor / 10;
        int cinco = valor / 5;
        int dois = valor/ 2;
        
        System.out.print("Cinquenta: " + cinquenta + "| dez: " + dez + "| cinco: " + cinco + "| dois: " + dois);
    }
}