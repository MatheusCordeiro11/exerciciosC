//Classe de funcionario terceirizado que herda de funcionario
public class FuncionarioTerceirizado : Funcionario{
    //Atributos
    private double valorHora;
    private int horasTrabalhadas;

    //Propriedades
    public double ValorHora{
        get{return valorHora;}
        set{
            if(value > 0){
                valorHora = value;
            }
            else{
                valorHora = 1;
            }
        }
    }
    public int HorasTrabalhadas{
        get{return horasTrabalhadas;}
        set{
            if(value > 0){
                horasTrabalhadas = value;
            }
            else{
                horasTrabalhadas = 1;
            }
        }
    }
    //Construtor
    public FuncionarioTerceirizado(string nome, string matricula, double valorHora, int horasTrabalhadas) : base(nome, matricula){
        this.ValorHora = valorHora;
        this.HorasTrabalhadas = horasTrabalhadas;
    }
    //Método
    public override double CalcularSalario(){
        double salarioFinal;
        salarioFinal = valorHora * horasTrabalhadas;
        return salarioFinal;
    }

    public override void ExibirDados(){
        base.ExibirDados();
        Console.WriteLine($"Valor Hora: {ValorHora}");
        Console.WriteLine($"Horas Trabalhadas : {HorasTrabalhadas}");
    }
}