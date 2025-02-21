public class Movimiento  {
    public int Fila { get; set; }
    public int Columna { get; set; }
    public char Simbolo { get; set; }
    
    
    public Movimiento(int fila, int columna, char simbolo)  {
        Fila = fila;
        Columna = columna;
        Simbolo = simbolo;
       
        }
    }
