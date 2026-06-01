public class ContaCorrente : Conta
{
    //Construtor
    public ContaCorrente(string titular, double valor, string numeroConta) : base(titular, valor, numeroConta)
    {
        
    }

    //Métodos
    public override void Depositar(double valor)
    {
        Saldo += valor;
        DispararNotificacao($"O valor de R${valor} foi depositado na conta com sucesso.");
        DispararNotificacao($"Saldo atual: R${Saldo}.");
    }
    public override void Sacar(double valor)
    {
        if(Saldo > 0 && Saldo > valor + (valor * 0.02))
        {   
            double taxa = valor * 0.02;
            Saldo -= valor + taxa;
            DispararNotificacao($"O valor de R${valor} foi sacado da conta com sucesso.");
            DispararNotificacao($"Saldo atual: R${Saldo}.");
        }
    }
}