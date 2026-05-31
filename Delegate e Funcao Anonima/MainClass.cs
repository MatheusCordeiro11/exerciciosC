//Calculadora
class MainClass
{
    public delegate double Operacao (double x, double y);

    public static void Main(string[] args)
    {
        //Criando 4 variáveis do tipo Operacao com função anônima;
        Operacao Soma = (x, y) => (x + y);
        Operacao Subtrair = (x, y) => (x - y);
        Operacao Multiplicar = (x, y) => (x * y);
        Operacao Dividir = (x, y) => (x / y);
        //Criando vetor do tipo Operacao;
        Operacao[] Operacoes = new Operacao[4];
        //Adicionando as operações no vetor;
        Operacoes[0] = Soma;
        Operacoes[1] = Subtrair;
        Operacoes[2] = Multiplicar;
        Operacoes[3] = Dividir;
        //Percorrendo o vetor com os valores 10 e 3;
        for(int i = 0; i < 4; i++)
        {
            double value = Operacoes[i](10, 3);
            Console.WriteLine($"Operação {i+1}: {value}");
        }
    }
}