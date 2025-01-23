using System.Text;

namespace Vehicle.Entities.Services
{
	/// <summary>
	/// Este serviço é responsável por gerar placas utilizadas em veículos.
	/// </summary>
	/// <remarks>
	/// Este serviço é utilizado na classe <see cref="OrderCarService"/>
	/// para gerar uma nova placa ao veículo instanciado.
	/// </remarks>
public static class GeneratePlateService
{
	/// <summary>
	/// Este método gera uma placa veícular no formato Mercosul: "LLL-NLNN", onde L representam letras e N representam números.
	/// </summary>
	/// <returns>
	/// Uma 'string' contendo uma placa veicular gerada aleatoriamente.
	/// Exemplo: <c>BRA-7B77</c>
	/// </returns>
	/// <example>
	/// Exemplo de uso:
	/// <code>
	/// string plate = GeneratePlateService.Plate();
	/// Console.WriteLine(plate); // Exemplo de resultado: "BRA-7B77".
	/// </code>
	/// </example>
	/// <seealso cref="OrderCarService"/>
	public static string Plate()
	{
		// Gerando uma placa de 8 caracteres, segundo o padrão Mercosul.
		char[] plate = new char[8];
		
		// Adicionado aleatoriamente letras e números conforme o modelo: 'LLL-NLNN'.
		for(int i = 0; i < 8; i++)
		{
			// Adiciona um 'char' numérico aleatório nas posições 4, 6 e 7 da placa.
			if(i == 4 || i == 6 || i == 7)
			{
				plate[i] = (char)( '0' + Random.Shared.Next(0, 10));
			}
			// Adiciona um hífen na posição 3 da placa.
			else if (i == 3)
			{
				plate[i] = '-';
			}
			// Adiciona um 'char' alfabético nas posições 0, 1, 2 e 5 da placa.
			else
			{
				plate[i] = ((char)Random.Shared.Next('A', 'Z' + 1));
			}
		}
		// Retorna a placa, convertida de 'Char' para 'String'.
		return new string(plate);
	}
}
}