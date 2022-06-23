import java.util.Scanner;

public class Gincana13
{
    public static void main(String args[])
    {
        Scanner input = new Scanner(System.in);
        
        String[] nDvd = new String[5];
        double[] preco = new double[5];
        int escolha = 0;
        double total = 0;
        
        nDvd[0] = "Lady gaga nao conheco album";
        preco[0] = 3.99;
        nDvd[1] = "Metallica black album";
        preco[1] = 4.99;
        nDvd[2] = "Baroes";
        preco[2] = 5.99;
        nDvd[3] = "Pantera";
        preco[3] = 6.99;
        nDvd[4] = "Megadeth";
        preco[4] = 7.99;
        
        for (int i = 1; i <= 3; i++)
        {
            escolha = input.nextInt();
            System.out.println(nDvd[escolha]);
            System.out.println(preco[escolha]);
            total += preco[escolha];
        }
        System.out.println("Total: " + total);
    }
}