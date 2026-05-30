class MainClass
{
    //Criando o atributo delegate
    delegate int Calculo (int a, int b);
    public static void Main(string[] args)
    {
        int Somar (int a, int b) {return a + b;}
        int Subtrair (int a, int b) {return a - b;}
        int value;

        Calculo cal = Somar;
        value = cal(2, 3);
        Console.WriteLine($"A soma final é {value}.");
        cal = Subtrair;
        value = cal(2, 3);
        Console.WriteLine($"A subtração final é {value}.");
    }
}