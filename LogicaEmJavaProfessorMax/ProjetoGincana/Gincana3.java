public class Gincana3
{
    public static void main(String args[])
    {
        double acrescentar = 0.15;
        double tirar = 0.9;
        double salario = 1500.00;
        double result;
        double result2;
        
        result2 = salario * acrescentar;
        result = (salario * tirar) + result2;
        
        System.out.print(result);
    }
}