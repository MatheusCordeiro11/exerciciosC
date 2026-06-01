//Classa abstrata de Conta
public abstract class Conta
{    
    //Atributo delegate
    public delegate void Notificacao(string mensagem);

    //Atributos privados
    private string titular;
    private double saldo;
    private string numeroConta;

    //Propriedades com validação
    public string Titular
    {
        get{return this.titular;}
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                this.titular = value;
            }
            else
            {
                this.titular = "Titular desconhecido";
            }
        }
    }
    public double Saldo
    {
        get{return this.saldo;}
        set
        {
            if(value > 0)
            {
                this.saldo = value;
            }
            else
            {
                this.saldo = 0;
            }
        }
    }
    public string NumeroConta
    {
        get{return numeroConta;}
        set{numeroConta = value;}
    }

    //Construtor
    public Conta(string titular, double saldo, string numeroConta)
    {
        this.Titular = titular;
        this.Saldo = saldo;
        this.NumeroConta = numeroConta;
    }

    //Criando evento do tipo delegate
    public event Notificacao AoMovimentar;

    //Métodos abstratos
    public abstract void Depositar(double valor);
    public abstract void Sacar(double valor);

    //Método protegido
    protected void DispararNotificacao(string mensagem)
    {
        if(AoMovimentar != null)
        {
            AoMovimentar(mensagem);
        }
    }
}