import java.util.Scanner;

public class Gincana9
{
    public static void main(String args[])
    {
        Scanner input = new Scanner(System.in);
        
        double ien;
        double br;
        double euro;
        int moeda;
        double valor;
        
        System.out.print("Informe um valor: ");
        valor = input.nextDouble();
        
        ien = 136 * valor;
        br = 5.17 * valor;
        euro = 0.94 * valor;
        
        System.out.print(valor + " iene: " + ien +" br "+ br + " euro" + euro);
    }
}