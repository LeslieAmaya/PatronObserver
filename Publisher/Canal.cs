using PatronObserver.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronObserver.Publisher
{
    public class Canal
    {
        private string _lastVideo = "";
        private List<ISuscriptor> _suscriptores = new List<ISuscriptor>();

        public void Suscribir(ISuscriptor nuevoSuscriptor) 
        {
            _suscriptores.Add(nuevoSuscriptor);
        }
        public void Desuscribir(ISuscriptor sub)
        {
            _suscriptores.Remove(sub);
        }
        private void NotificarSuscriptores()
        {
            foreach (ISuscriptor sub in _suscriptores) sub.Update(_lastVideo);
        }
        public void PublicarVideo(string titulo)
        {
            _lastVideo = titulo;
            NotificarSuscriptores();
        }
    }
}
