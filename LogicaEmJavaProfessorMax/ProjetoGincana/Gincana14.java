import java.util.Scanner;

public class Gincana14
{
    public static void main(String args[])
    {
        Scanner input = new Scanner(System.in);
        
        int fazer;
        double saldo = 0;
        
        do
        {
            System.out.println("Depositar (1)");
            System.out.println("Sacar (2)");
            System.out.println("Pagamentos (3)");
            System.out.println("Saldo total da conta (4)");
            System.out.println("Sair (0)");
            
            System.out.println();
            System.out.println("Oq deseja fazer?");
            fazer = input.nextInt();
            
            if (fazer == 1)
            {
                System.out.println("Informe o valor do deposito: ");
                double valor = input.nextDouble();
                saldo += valor;
            }
            else if(fazer == 2)
            {
                System.out.println("Informe o valor do saque: ");
                double valor = input.nextDouble();
                saldo -= valor;
            }
            else if(fazer == 3)
            {
                System.out.println("Informe o valor de pagamento: ");
                double valor = input.nextDouble();
                saldo -= valor;
            }
            else if(fazer == 4)
            {
                System.out.println("Saldo total da conta: " + saldo);
            }
        }while(fazer != 0);
    }
}