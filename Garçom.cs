public class Garcom
{
    private string nome = "";
    private int idade;
    public string Nome
    {
        get { return nome; }
        set
        {
            if (value == "")
            {
                throw new ArgumentException("O nome do garçom não pode estar vazio.");
            }

            nome = value;
        }
    }

    public Garcom(string nome)
    {
        Nome = nome;
    }

    public void ServirCliente(Cliente cliente)
    {
        Console.WriteLine($"O garçom {Nome} está servindo o cliente {cliente.Nome}.");
    }

    public void TrazerConta(double valor)
    {
        if (valor <= 0)
        {
            throw new ArgumentException("O valor da conta deve ser maior que zero.");
        }

        Console.WriteLine($"Conta: R$ {valor:F2}");
    }

    public override string ToString()
    {
        return $"Garçom: {Nome}";
    }
}






