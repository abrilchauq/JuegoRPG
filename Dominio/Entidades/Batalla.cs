using Dominio.Interfaz;

namespace Dominio.Entidades
{
    public class Batalla : IJuego
    {
        public string? Lugar { get; set; }
        public string? NombreBatalla { get; set; }
        public List<IJuego> participantes;
        public bool estaActiva { get; set; } = true;
        public DateTime FechaInicio { get; set; }
        public Batalla(string lugar, string nombreBatalla, DateTime fechaInicio)
        {
            this.Lugar = lugar;
            participantes = new List<IJuego>();
            this.NombreBatalla = nombreBatalla;
            this.FechaInicio = fechaInicio;

        }

        public void AgregarParticipantes(IJuego participante)
        {

            participantes.Add(participante);

        }

        // Método para iniciar la batalla
        public void IniciarBatalla()
        {
            if (estaActiva)
            {
                Console.WriteLine($"La batalla '{NombreBatalla}' ya está en curso.");
            }
            else
            {
                estaActiva = true;
                Console.WriteLine($"La batalla '{NombreBatalla}' ha comenzado el {FechaInicio}.");
            }

        }

        public void FinalizarBatalla()
        {
            estaActiva = false;
        }

        public void MostrarDetalleParticipantes()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Participantes de esta batalla: ");
            foreach (var participante in participantes)
            {
                participante.MostrarDetalle();
            }

            Console.WriteLine("------------------------");
        }
        public void MostrarDetalle()
        {
            Console.WriteLine($"Lugar de batalla: {this.Lugar}");
            Console.WriteLine($"Batalla: {this.NombreBatalla}");
            Console.WriteLine($"Estado de partida: {this.estaActiva}");
            Console.WriteLine($"Fecha: {this.FechaInicio}");
        }
    }
}