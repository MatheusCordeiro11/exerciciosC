//Classe abstrada de Funcionario
public abstract class Funcionario{
    //Atributos
    private string nome;
    private string matricula;

    //Propriedades
    public string Nome{
        get{return nome;}
        set{
            //Se a string não for nula
            if(!string.IsNullOrEmpty(value)){
                nome = value;
            }
            else{
                nome = "Sem nome";
            }
        }
    }
    public string Matricula{
        get{return matricula;}
        set{
            if(!string.IsNullOrEmpty(value)){
                matricula = value;
            }
            else{
                matricula = "00000";
            }
        }
    }
    //Construtor
    public Funcionario(string nome, string matricula){
        this.Nome = nome;
        this.Matricula = matricula;
    }
    //Métodos
    public abstract double CalcularSalario();

    public virtual void ExibirDados(){
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Matrícula : {Matricula}");
    }
}