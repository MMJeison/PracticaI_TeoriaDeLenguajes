using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomataAnalyzer
{
    class AF
    {
        public List<string> _simbEntrada { get; set; }
        public Dictionary<string, Estado> _estados { get; set; }
        public List<string> _estIniciales { get; set; }
        public List<string> _estDeAceptacion { get; set; }

        public AF()
        {
            _simbEntrada = new List<string>();
            _estados = new Dictionary<string, Estado>();
            _estIniciales = new List<string>();
            _estDeAceptacion = new List<string>();
        }
        public AF(List<string> simbEntrada, List<string> estados, List<string> estIniciales, List<string> estDeAceptacion)
        {
            _simbEntrada = simbEntrada;
            _estIniciales = estIniciales;
            _estDeAceptacion = estDeAceptacion;
            _estados = new Dictionary<string, Estado>();
            List<string> listAux = estados;
            bool esInicial, esDeAceptacion;
            Estado estAux;
            foreach(string i in listAux)
            {
                esInicial = false;
                esDeAceptacion = false;
                if (_estIniciales.Contains(i)) esInicial = true;
                if (_estDeAceptacion.Contains(i)) esDeAceptacion = true;
                estAux = new Estado(i, esInicial, esDeAceptacion);
                _estados[i] = estAux;
            }
        }
        public void agregarTransiciones(string[,] transiciones)
        {
            int i = 0, j = 0;
            List<string> aux;
            int n;
            foreach(var est in _estados)
            {
                foreach(string simb in _simbEntrada)
                {
                    n = 0;
                    aux = transiciones[i, j].Split(",").ToList<string>();
                    est.Value._transiciones[simb] = new Dictionary<string, Estado>();
                    foreach(string s in aux)
                    {
                        est.Value._transiciones[simb].Add(n.ToString(), _estados[s]);
                        n++;
                    }
                    j++;
                }
                i++; j = 0;
            }
        }
        public AFD toAFD()
        {
            List<List<string>> newEstados = new List<List<string>>();
            List<string> listAux = new List<string>();
            foreach (var est in _estados) if (est.Value._esInicial) { listAux.Add(est.Key); }
            newEstados.Add(listAux);
            List<string> newTransiciones = new List<string>();
            int i = 0, tam = newEstados.Count;
            while (i < tam)
            {
                foreach(string simb in _simbEntrada)
                {
                    listAux = new List<string>();
                    foreach(string s in newEstados[i])
                    {
                        foreach(var v in _estados[s]._transiciones[simb])
                        {
                            if (!listAux.Contains(v.Value._nombre)) listAux.Add(v.Value._nombre);
                        }
                    }
                    bool existeElEstado = false;
                    foreach(List<string> list in newEstados)
                    {
                        List<string> x1 = list.Where(x => !listAux.Contains(x)).ToList();
                        List<string> x2 = listAux.Where(x => !list.Contains(x)).ToList();
                        if (x1.Count == 0 && x2.Count == 0)
                        {
                            existeElEstado = true;
                            listAux = list;
                            break;
                        }
                    }
                    string strAux = string.Empty;
                    foreach (string s in listAux) strAux += s;
                    newTransiciones.Add(strAux);
                    if (!existeElEstado) newEstados.Add(listAux);
                }
                i++;
                tam = newEstados.Count;
            }
            string estInicial = string.Empty;
            foreach(string s in newEstados[0])
            {
                estInicial += s;
            }
            AFD afd = new AFD(_simbEntrada, newEstados, estInicial, _estDeAceptacion);
            afd.agregarTransiciones(newTransiciones);
            return afd;
        }

        public string toString()
        {
            string strSimbolos = "Simbolos: " + string.Join(", ", _simbEntrada);
            string strEstados = "Estados: ";
            string strEstIniciales = "Estado(s) inicial(es): " + string.Join(", ", _estIniciales);
            string strEstDeAceptacion = "Estado(s) de Aceptacion: " + string.Join(", ", _estDeAceptacion);
            string strTransiciones = "Transiciones: ";
            Dictionary<string, Estado> aux;
            foreach (var v in _estados)
            {
                strEstados += "{" + v.Value._nombre + "} ";
                foreach (string s in _simbEntrada)
                {
                    aux = v.Value._transiciones[s];
                    strTransiciones += "{";
                    foreach (var k in aux) strTransiciones += k.Key + ":" + k.Value._nombre + " ";
                    strTransiciones += "} ";
                }
            }
            string str = strSimbolos + "\n" + strEstados + "\n" + strEstIniciales
                + "\n" + strEstDeAceptacion + "\n" + strTransiciones;
            return str;
        }
    }
}
