// cadastrar cpf para reservar mesa e pedir um prato   
public class Cliente
{
    private string nome = "";
    private string cpf = "";

    public string Nome
    {
        get { return nome; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("O nome não pode estar vazio.");
            }

            nome = value;
        }
    }

    public string Cpf
    {
        get { return cpf; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("O CPF não pode estar vazio.");
            }

            if (value.Length != 11)
            {
                throw new ArgumentException("O CPF deve possuir 11 dígitos.");
            }

            if (!long.TryParse(value, out _))
            {
                throw new ArgumentException("O CPF deve conter apenas números.");
            }

            cpf = value;
        }
    }

    public Cliente(string nome, string cpf)
    {
        Nome = nome;
        Cpf = cpf;
    }

    // Reservar mesa
    public void ReservarMesa()
    {
        Console.WriteLine($"Mesa reservada para {Nome}.");
    }

    // Pedir prato
    public void PedirPrato(string prato)
    {
        if (string.IsNullOrWhiteSpace(prato))
        {
            Console.WriteLine("O prato não pode estar vazio.");
            return;
        }

        Console.WriteLine($"Prato pedido: {prato}");
    }


    public override string ToString()
    {
        return $"Cliente: {Nome}\nCPF: {Cpf}";
    }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    