using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomataAnalyzer
{
    class Estado
    {
        public string _nombre { get; set; }
        public bool _esInicial { get; set; }
        public bool _esDeAceptacion { get; set; }
        public Dictionary<string, Dictionary<string, Estado>> _transiciones { get; set; }
        public Estado()
        {
            _nombre = null;
            _esInicial = false;
            _esDeAceptacion = false;
            _transiciones = new Dictionary<string, Dictionary<string, Estado>>();
        }
        public Estado(string nombre, bool esInicial, bool esDeAceptacion)
        {
            _nombre = nombre;
            _esInicial = esInicial;
            _esDeAceptacion = esDeAceptacion;
            _transiciones = new Dictionary<string, Dictionary<string, Estado>>();
        }
    }
}
