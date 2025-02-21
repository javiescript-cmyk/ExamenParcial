using System;

    public class Persona    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Persona(int id, string nombre, string apellido) { 
        
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
         }
         public void MostrarInformacion() {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Apellido: {Apellido}");
    }
    }