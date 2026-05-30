using System;

class MainClass{
    public static void Main(string[] args) {
        int contFuncionario = 0;
        //Criando o vetor para funcionarios
        Funcionario[] funcionarios = new Funcionario[4];
        //Criando funcionarios
        funcionarios[contFuncionario++] = new FuncionarioCLT("Matheus", "12345", 1654.0, 4);
        funcionarios[contFuncionario++] = new FuncionarioTerceirizado("Robson", "99999", 12541.0, 6);
        funcionarios[contFuncionario++] = new FuncionarioCLT("Fernanda", "45678", 2356.0, 2);
        funcionarios[contFuncionario++] = new FuncionarioTerceirizado("Raquel", "88888", 1258.0, 0);
        //Percorrendo o vetor para exibir os funcionarios
        for(int i = 0; i < contFuncionario; i++){
            Console.WriteLine($"Funcionário: {funcionarios[i].Nome}");
            Console.WriteLine($"Salário: R$ {funcionarios[i].CalcularSalario():F2}");
            Console.WriteLine("---");
        }
    }
}