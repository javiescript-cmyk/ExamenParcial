public class Jugador : Persona {
 
    public char Simbolo {get;  set; }
   

    public  Jugador (int id, string nombre, string apellido, char simbolo): base (id, nombre, apellido ) {

    Simbolo = simbolo;

    }
    public new void MostrarInformacion() {
        base.MostrarInformacion();

    Console.WriteLine($"Simbolo: {Simbolo}");

    }
    
}