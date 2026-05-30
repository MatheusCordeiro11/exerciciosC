//Classe de funcionario CLT que herda de funcionario
public class FuncionarioCLT : Funcionario{
    private double salarioBase;
    private int anosEmpresa;

    //Propriedades
    public double SalarioBase{
        get{return salarioBase;}
        set{
            if(value > 0 ){
                salarioBase = value;
            }
            else{
                salarioBase = 1;
            }
        }
    }
    public int AnosEmpresa{
        get{return anosEmpresa;}
        set{
            if(value > 0){
                anosEmpresa = value;
            }
            else{
                anosEmpresa = 1;
            }
        }
    }
    //Construtor
    public FuncionarioCLT(string nome, string matricula, double salarioBase, int anosEmpresa) : base(nome, matricula){
        this.SalarioBase = salarioBase;
        this.AnosEmpresa = anosEmpresa;
    }
    //Método de calcular salario
    public override double CalcularSalario(){
        double salarioFinal = salarioBase + (salarioBase * 0.10 * anosEmpresa);
        return salarioFinal;
    }

    public override void ExibirDados(){
        base.ExibirDados();
        Console.WriteLine($"Salario Base: {SalarioBase}");
        Console.WriteLine($"Anos de Empresa : {AnosEmpresa}");
    }
}