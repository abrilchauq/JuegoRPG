
using Dominio.Interfaz;

namespace Dominio.Entidades
{
    public class Arma : IJuego
    {
        public string? NombreArma { get; set; }
        public int Danio { get; set; }
        public Arma(string nombreArma, int danio)
        {
            this.NombreArma = nombreArma;
            this.Danio = danio;
        }

        public void MostrarDetalle()
        {
            Console.WriteLine($"Nombre del arma: {this.NombreArma}");
            Console.WriteLine($"Daño: {this.Danio}");

        }
    }
}