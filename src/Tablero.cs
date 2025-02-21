public class Tablero {
    public char[,] Celdas { get; set; }
    
    public Tablero() {
    Celdas = new char[3, 3];
    for (int i = 0; i < 3; i++) {
    for (int j = 0; j < 3; j++) {
    Celdas[i, j] = '-';
            }
        }
    }
    
    public void MostrarTablero() {
    
    Console.WriteLine("Tablero de Tres en Raya:");
    for (int i = 0; i < 3; i++) {
    for (int j = 0; j < 3; j++) {
    
    Console.Write($" {Celdas[i, j]} ");}
    Console.WriteLine();}
    Console.WriteLine();
    }
} 