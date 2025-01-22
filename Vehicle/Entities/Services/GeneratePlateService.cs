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
public class GeneratePlateService
{
	/// <summary>
	/// Este método gera uma placa veícular no formato Mercosul: "LLL-NLNN".
	/// </summary>
	/// <remarks>
	/// Legenda: L = Letra, N = Número.
	/// </remarks>
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
		char[] plate = new char[8];
		
		for(int i = 0; i < 8; i++)
		{
			if(i == 4 || i == 6 || i == 7)
			{
				plate[i] = (char)( '0' + Random.Shared.Next(0, 10));
			}
			else if (i == 3)
			{
				plate[i] = '-';
			}
			else
			{
				plate[i] = ((char)Random.Shared.Next('A', 'Z' + 1));
			}
		}
		return new string(plate);
	}
}
}