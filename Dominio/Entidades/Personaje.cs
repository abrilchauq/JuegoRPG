using Dominio.Interfaz;

namespace Dominio.Entidades
{
    public class Personaje : IJuego
    {
        public string? Nombre { get; set; }
        public int Edad { get; set; }
        public string? Genero { get; set; }
        public Arma? ArmaEquipada { get; set; } 
        public List<Habilidad> Habilidades { get; set; }

        public Personaje(string nombre, int edad, string genero)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Genero = genero;
            this.Habilidades = new List<Habilidad>();

        }

        public void MostrarDetalle()
        {
            Console.WriteLine($"Nombre: {this.Nombre}");
            Console.WriteLine($"Edad: {this.Edad}");
            Console.WriteLine($"Genero: {this.Genero}");
            Console.WriteLine("Arma Equipada: ");
            ArmaEquipada?.MostrarDetalle(); 
            Console.WriteLine("Habilidades: ");
            foreach (var habilidad in Habilidades)
            {
                habilidad.MostrarDetalle();
            }

            Console.WriteLine("-----------------");
            
        }
    }
}