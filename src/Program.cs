public class Program {
    public static void Main(string[] args) {
        Console.WriteLine("--------BIENVENIDA--------");
        Console.WriteLine("¡Bienvenidos al juego de Tres en Raya!");
        Console.WriteLine("--------");



        Console.WriteLine("--------REGLAS--------");
        Console.WriteLine("¡Bienvenidos al juego de Tres en Raya!");
        Console.WriteLine("Reglas del juego:");
        Console.WriteLine("1. El objetivo es ser el primero en formar una línea con tres de tus símbolos (X o O) en una fila, columna o diagonal.");
        Console.WriteLine("2. El jugador 1 usa 'X' y el jugador 2 usa 'O'.");
        Console.WriteLine("3. Los jugadores alternan turnos.");
        Console.WriteLine("4. Un jugador gana si coloca tres símbolos en una fila, columna o diagonal.");
        Console.WriteLine("5. Si todas las casillas están ocupadas y nadie gana, el juego termina en empate.");
        Console.WriteLine("6. Un movimiento inválido es intentar colocar un símbolo en una casilla ya ocupada.");
        Console.WriteLine("--------");

        Console.WriteLine("Vamos a comenzar.. si pierdes estas reprobado en la materia!!!! 😆");
        Console.WriteLine("--------");
        Console.WriteLine("Jugador 1 será 'X' y Jugador 2 será 'O'");
        Console.WriteLine("--------");
        
        Console.WriteLine("--------JUGADORES--------");
        Jugador objJugador1 = new Jugador(1, "Santi😈", "Cadima", 'X' );
        objJugador1.MostrarInformacion();
        Console.WriteLine("--------");

        Jugador objJugador2 = new Jugador(2, "Victor😇", "Rios", 'O' );
        objJugador2.MostrarInformacion();
        Console.WriteLine("--------");

        Console.WriteLine("--------JUEGO--------");
        Juego objJuego = new Juego(objJugador1, objJugador2);
        objJuego.MostrarInformacion();
        Console.WriteLine("--------");
          
    

        Console.WriteLine("--------TABLERO DE JUEGO--------");
        Console.WriteLine("Estado del Tablero:");
        Console.WriteLine(" X | O | X ");
        Console.WriteLine("-----------");
        Console.WriteLine(" O | X | O ");
        Console.WriteLine("-----------");
        Console.WriteLine(" X |   | O ");
        

       
    }
}
