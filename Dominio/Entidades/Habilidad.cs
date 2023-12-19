using Dominio.Interfaz;

namespace Dominio.Entidades
{
    public class Habilidad : IJuego
    {
        public string NombreHabilidad { get; set; }
        public string TipoHabilidad { get; set; }

        public Habilidad(string nombreHabilidad, string tipoHabilidad)
        {
            this.NombreHabilidad = nombreHabilidad;
            this.TipoHabilidad = tipoHabilidad;
        }

        public void MostrarDetalle()
        {
            Console.WriteLine($"{this.NombreHabilidad}");
            Console.WriteLine($"Tipo: {this.TipoHabilidad}");

        }
    }
}