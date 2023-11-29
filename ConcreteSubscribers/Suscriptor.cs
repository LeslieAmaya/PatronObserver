using PatronObserver.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronObserver.ConcreteSubscribers
{
    public class Suscriptor : ISuscriptor
    {
        private string _nombre;
        public Suscriptor(string nombre) 
        {
            _nombre = nombre;
        }

        public void Update(string nuevoVideo)
        {
            Console.WriteLine($"[{_nombre}] voy a ver el vídeo titulado: {nuevoVideo}");
        }
    }
}
