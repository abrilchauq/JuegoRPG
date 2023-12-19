using Dominio.Interfaz; 
using Dominio.Entidades;

List<IJuego> listaDeDetalles = new List<IJuego>(); 

Arma messi = new Arma("MESSIII", 100000);
Habilidad serMessi = new Habilidad("Ser Messi", "god");
Habilidad curacion = new Habilidad("Curacion", "god tmb");
Personaje jugador = new Personaje("kira", 2, "mujel ofendida");
Enemigo enemigo = new Enemigo("Taylor Swift"); 


// jugador 
jugador.ArmaEquipada = messi; 
jugador.Habilidades.Add(serMessi);
jugador.Habilidades.Add(curacion);


// enemigo
enemigo.ArmaEnemigo = new Arma("Cantar all too well 10 min ver.", 5000);
enemigo.Habilidades.Add(new Habilidad("Canto", "Sonido"));


listaDeDetalles.Add(messi);
listaDeDetalles.Add(serMessi);
listaDeDetalles.Add(jugador);
listaDeDetalles.Add(enemigo);

foreach (var detalle in listaDeDetalles)
{
    detalle.MostrarDetalle();
    Console.WriteLine("-------------------------------"); 
}


// Crear una instancia de Batalla
Batalla miBatalla = new Batalla("Coliseo", "LA BATALLA DE KIRA", DateTime.Now);

// Agregar participantes
    miBatalla.AgregarParticipantes(jugador);
    miBatalla.AgregarParticipantes(enemigo);
    miBatalla.MostrarDetalle();
    miBatalla.MostrarDetalleParticipantes(); 

// Iniciar la batalla
    miBatalla.IniciarBatalla();
    Console.ReadLine();