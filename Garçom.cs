public class Garcom
{
    // Atributos privados
    private string nome;

    // Property Nome
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

    // Construtor com parâmetros
    public Garcom(string nome)
    {
        Nome = nome;
    }

    // Método para servir o cliente
    public void ServirCliente(Cliente cliente)
    {
        Console.WriteLine($"O garçom {Nome} está servindo o cliente {cliente.Nome}.");
    }

    // Método para trazer a conta
    public void TrazerConta(double valor)
    {
        if (valor <= 0)
        {
            throw new ArgumentException("O valor da conta deve ser maior que zero.");
        }

        Console.WriteLine($"Conta: R$ {valor:F2}");
    }

    // ToString
    public override string ToString()
    {
        return $"Garçom: {Nome}";
    }
}






