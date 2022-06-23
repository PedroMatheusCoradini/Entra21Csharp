import java.util.Scanner;

public class Gincana7
{
    public static void main(String args[])
    {
        Scanner ler = new Scanner(System.in);
        
        String cor1 = "Vermelho";
        String cor2 = "Roxo";
        String cor3 = "Azul";
        String cor4 = "Amarelo";
        String cor5 = "cinza";
        String cor6 = "";
        
        int numero;
        int opcaoDeCor;
        do
        {
            System.out.println("Carro (1): ");
            System.out.println("Geladeira (2): ");
            System.out.println("Fogao (3): ");
            System.out.println("Lancha (4): ");
            System.out.println("Barco (5): ");
            System.out.println("Escolha uma opcao: ");
            numero = ler.nextInt();
            
            if (numero == 1)
            {
                System.out.println("Escolha uma Cor para o seu carro: ");
                System.out.println("Vermelhor (1)");
                System.out.println("Roxo (2)");
                System.out.println("Azul (3)");
                System.out.println("Amarelo (4)");
                System.out.println("Cinza (5)");
                opcaoDeCor = ler.nextInt();
                
                if (opcaoDeCor == 1)
                {
                    System.out.println("Carro possue a cor" + cor1);
                }
                else if(opcaoDeCor == 2)
                {
                    System.out.println("Carro possue a cor" + cor2);
                }
                else if(opcaoDeCor == 3)
                {
                    System.out.println("Carro possue a cor" + cor3);
                }
                else if(opcaoDeCor == 4)
                {
                    System.out.println("Carro possue a cor" + cor4);
                }
                else if(opcaoDeCor == 5)
                {
                    System.out.println("Carro possue a cor " + cor5);
                }
            }
            else if(numero == 2)
            {
                System.out.println("Escolha uma Cor para sua geladeira: ");
                System.out.println("Vermelhor (1)");
                System.out.println("Roxo (2)");
                System.out.println("Azul (3)");
                System.out.println("Amarelo (4)");
                System.out.println("Cinza (5)");
                opcaoDeCor = ler.nextInt();
                
                if (opcaoDeCor == 1)
                {
                    System.out.println("Geladeira possue a cor" + cor1);
                }
                else if(opcaoDeCor == 2)
                {
                    System.out.println("Geladeira possue a cor" + cor2);
                }
                else if(opcaoDeCor == 3)
                {
                    System.out.println("Geladeira possue a cor" + cor3);
                }
                else if(opcaoDeCor == 4)
                {
                    System.out.println("Geladeira possue a cor" + cor4);
                }
                else if(opcaoDeCor == 5)
                {
                    System.out.println("Geladeira possue a cor" + cor5);
                }
            }
            else if(numero == 3)
            {
                System.out.println("Escolha uma Cor para seu fogão: ");
                System.out.println("Vermelhor (1)");
                System.out.println("Roxo (2)");
                System.out.println("Azul (3)");
                System.out.println("Amarelo (4)");
                System.out.println("Cinza (5)");
                opcaoDeCor = ler.nextInt();
                
                if (opcaoDeCor == 1)
                {
                    System.out.println("Fogao possue a cor " + cor1);
                }
                else if(opcaoDeCor == 2)
                {
                    System.out.println("Fogao possue a cor " + cor2);
                }
                else if(opcaoDeCor == 3)
                {
                    System.out.println("Fogao possue a cor " + cor3);
                }
                else if(opcaoDeCor == 4)
                {
                    System.out.println("Fogao possue a cor " + cor4);
                }
                else if(opcaoDeCor == 5)
                {
                    System.out.println("Fogao possue a cor " + cor5);
                }
            }
            else if(numero == 4)
            {
                System.out.println("Escolha uma Cor para sua lancha: ");
                System.out.println("Vermelhor (1)");
                System.out.println("Roxo (2)");
                System.out.println("Azul (3)");
                System.out.println("Amarelo (4)");
                System.out.println("Cinza (5)");
                opcaoDeCor = ler.nextInt();
                
                if (opcaoDeCor == 1)
                {
                    System.out.println("Lancha possue a cor " + cor1);
                }
                else if(opcaoDeCor == 2)
                {
                    System.out.println("Lancha possue a cor " + cor2);
                }
                else if(opcaoDeCor == 3)
                {
                    System.out.println("Lancha possue a cor " + cor3);
                }
                else if(opcaoDeCor == 4)
                {
                    System.out.println("Lancha possue a cor " + cor4);
                }
                else if(opcaoDeCor == 5)
                {
                    System.out.println("Lancha possue a cor " + cor5);
                }
            }
            else if (numero == 0)
            {
                System.out.println("Programa encerrado");
            }
            else
            {
                System.out.println("Numero não encontrado");
            }
        }while(numero != 0);
    }
}