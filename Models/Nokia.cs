namespace DesafioPOO.Models
{
	// TODO: Herdar da classe "Smartphone"
	public class Nokia : Smartphone
	{
		public Nokia(string numero, string modelo, string imiei, int memoria) : base(numero, modelo, imiei, memoria)
		{
		}
		// TODO: Sobrescrever o método "InstalarAplicativo" ✅
		public override void InstalarAplicativo(string nomeApp)
		{
			System.Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia");
		}
	}
}