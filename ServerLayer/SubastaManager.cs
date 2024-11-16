using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLayer
{
    class SubastaManager
    {
        private List<Subasta> _subastas;

        public SubastaManager()
        {
            _subastas = new List<Subasta>();
        }

        public void CrearSubasta(string nombre, decimal precioInicial)
        {
            var subasta = new Subasta(nombre, precioInicial);
            _subastas.Add(subasta);
            Console.WriteLine($"Subasta creada: {nombre} con precio inicial {precioInicial}");
        }

        // Aquí puedes añadir más métodos para gestionar las subastas
    }

    public class Subasta
    {
        public string Nombre { get; }
        public decimal PrecioInicial { get; }

        public Subasta(string nombre, decimal precioInicial)
        {
            Nombre = nombre;
            PrecioInicial = precioInicial;
        }
    }
}
