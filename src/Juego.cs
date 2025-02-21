// Clase Juego
public class Juego {
    public Tablero Tablero { get; set; }
    public Jugador Jugador1 { get; set; }
    public Jugador Jugador2 { get; set; }
    
    public Juego(Jugador jugador1, Jugador jugador2) {
        Tablero = new Tablero();
        Jugador1 = jugador1;
        Jugador2 = jugador2;
    }
    
    public void MostrarInformacion() {
        Console.WriteLine("Jugadores del Juego:");
        Jugador1.MostrarInformacion();
        Jugador2.MostrarInformacion();
        Tablero.MostrarTablero();
    }
}