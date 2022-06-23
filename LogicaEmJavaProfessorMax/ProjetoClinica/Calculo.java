import java.util.Scanner;

public class Calculo
{
    public static void main(String args[])
    {
        Scanner input = new Scanner(System.in);
        
        int n1, n2, rt;
        
        System.out.println("N1");
        n1 = input.nextInt();
        
        System.out.println("N2");
        n2 = input.nextInt();
        
        rt = n1 + n2;
        
        System.out.println("O resultado é:" + rt);
    }
}