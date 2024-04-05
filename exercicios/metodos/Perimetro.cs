namespace metodos;

public class Perimetro : IForma
{
	public Perimetro(int largura, int comprimento)
	{
		Largura = largura;
		Comprimento = comprimento;
	}

	public int Largura { get;  }
    public int Comprimento { get;}
}
