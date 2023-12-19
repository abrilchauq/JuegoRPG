using Dominio.Interfaz;

namespace Dominio.Entidades
{
    public class Enemigo : IJuego
    {
        public string? NombreEnemigo { get; set; }
        public Arma? ArmaEnemigo { get; set; }
        public List<Habilidad> Habilidades { get; set; }

        public Enemigo(string nombreEnemigo)
        {
            this.NombreEnemigo = nombreEnemigo;
            this.Habilidades = new List<Habilidad>(); 
        }

        public void MostrarDetalle()
        {
            Console.WriteLine($"Nombre: {this.NombreEnemigo}");
            ArmaEnemigo?.MostrarDetalle();
            Console.WriteLine("Habilidades: ");
            foreach (var habilidadE in Habilidades)
            {
                habilidadE.MostrarDetalle(); 
            }
        }
    }
}