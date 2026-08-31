public class ChefDeCozinha
{
    private string nomePrato;
    private double valor;

    public string NomePrato
    {
        get { return nomePrato; }
        set
        {
            if (value == "")
            {
                throw new ArgumentException("O nome do prato não pode estar vazio.");
            }

            nomePrato = value;
        }
    }

    public double Valor
    {
        get { return valor; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("O valor deve ser maior que zero.");
            }

            valor = value;
        }
    }

    public ChefDeCozinha(string nomePrato, double valor)
    {
        NomePrato = nomePrato;
        Valor = valor;
    }

    public override string ToString()
    {
        return $"Prato: {NomePrato} | Valor: R$ {Valor:F2}";
    }
}
