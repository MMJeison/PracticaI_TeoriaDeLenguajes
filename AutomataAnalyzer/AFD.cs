using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomataAnalyzer
{
    class AFD
    {
        public List<string> _simbEntrada { get; set; }
        public Dictionary<string, Estado> _estados { get; set; }
        public string _estInicial { get; set; }
        public List<string> _estDeAceptacion { get; set; }
        public AFD()
        {
            _simbEntrada = new List<string>();
            _estados = new Dictionary<string, Estado>();
            _estInicial = null;
            _estDeAceptacion = null;
        }
        public AFD(List<string> simbEntrada, List<List<string>> estados, string estInicial, List<string> estDeAceptacion)
        {
            _simbEntrada = simbEntrada;
            _estDeAceptacion = new List<string>();
            _estInicial = estInicial;
            _estados = new Dictionary<string, Estado>();
            Estado estAux;
            string strAux;
            bool esDeAceptacion;
            foreach(List<string> est in estados)
            {
                strAux = string.Empty;
                esDeAceptacion = false;
                foreach(string s in est)
                {
                    strAux += s;
                    if (estDeAceptacion.Contains(s)) esDeAceptacion = true;
                }
                estAux = new Estado(strAux, false, esDeAceptacion);
                if (_estInicial == strAux)
                {
                    estAux._esInicial = true;
                }
                if (esDeAceptacion) _estDeAceptacion.Add(strAux);
                _estados.Add(strAux, estAux);
            }
        }
        public void agregarTransiciones(List<string> transiciones)
        {
            Dictionary<string, Estado> dicAux;
            Estado estAux;
            foreach (var est in _estados)
            {
                foreach(string simb in _simbEntrada)
                {
                    estAux = _estados[transiciones[0]];
                    dicAux = new Dictionary<string, Estado>();
                    dicAux.Add("0", estAux);
                    est.Value._transiciones.Add(simb, dicAux);
                    transiciones.RemoveAt(0);
                }
            }
        }
        public void simplificar()
        {
            List<List<string>> particiones = new List<List<string>>();
            particiones.Add(new List<string>());
            particiones.Add(new List<string>());
            foreach(var i in _estados)
            {
                if (_estados[_estInicial]._esDeAceptacion)
                {
                    if (i.Value._esDeAceptacion) particiones[0].Add(i.Key);
                    else particiones[1].Add(i.Key);
                }
                else
                {
                    if (i.Value._esDeAceptacion) particiones[1].Add(i.Key);
                    else particiones[0].Add(i.Key);
                }
            }
            bool seDividioUnaParticion = true;
            List<string>[] newParticiones;
            while (seDividioUnaParticion)
            {
                seDividioUnaParticion = false;
                for(int i = 0; i < particiones.Count; i++)
                {
                    if (particiones[i].Count == 1) continue;
                    foreach (string simb in _simbEntrada)
                    {
                        if (particiones[i].Count == 1) continue;
                        newParticiones = new List<string>[particiones.Count];
                        for (int j = 0; j < newParticiones.Length; j++) newParticiones[j] = new List<string>();
                        foreach(string est in particiones[i])
                        {
                            for (int k = 0; k < particiones.Count; k++)
                            {
                                if (particiones[k].Contains(_estados[est]._transiciones[simb]["0"]._nombre))
                                {
                                    newParticiones[k].Add(est);
                                    break;
                                }
                            }
                        }
                        int b = 0;
                        foreach(List<string> list in newParticiones)
                        {
                            if(list.Count > 0)
                            {
                                if (b == 0) particiones[i] = list;
                                else particiones.Insert(i + 1, list);
                                b++;
                            }
                        }
                        if (b > 1) seDividioUnaParticion = true;
                    }
                }
            }
            List<string> transiciones = new List<string>();
            List<string> listAux;
            bool hayEstadosEquivalentes = false;
            for(int i = 0; i < particiones.Count; i++)
            {
                foreach(string simb in _simbEntrada)
                {
                    listAux = new List<string>();
                    foreach(string est in particiones[i])
                    {
                        if (!listAux.Contains(_estados[est]._transiciones[simb]["0"]._nombre))
                        {
                            listAux.Add(_estados[est]._transiciones[simb]["0"]._nombre);
                        }
                    }
                    foreach(List<string> list in particiones)
                    {
                        List<string> x1 = list.Where(x => listAux.Contains(x)).ToList();
                        //List<string> x2 = list.Where(x => !listAux.Contains(x)).ToList<string>();
                        if (x1.Count > 0)
                        {
                            listAux = list;
                            break;
                        }
                    }
                    string strAux = listAux[0];
                    transiciones.Add(strAux);
                }
                if (particiones[i].Count > 1) hayEstadosEquivalentes = true;
            }
            if (!hayEstadosEquivalentes) return;
            string estInicial = null;
            bool esEstInicial = false;
            List<List<string>> newEstados = new List<List<string>>();
            foreach(List<string> list in particiones)
            {
                listAux = new List<string>();
                listAux.Add(list[0]);
                newEstados.Add(listAux);
                if (estInicial == null)
                {
                    foreach (string est in list)
                    {
                        if (_estados[est]._esInicial) esEstInicial = true;
                    }
                    if (esEstInicial)
                    {
                        estInicial = list[0];
                    }
                }
            }
            AFD afd = new AFD(_simbEntrada, newEstados, estInicial, _estDeAceptacion);
            afd.agregarTransiciones(transiciones);
            _estados = afd._estados;
            _estInicial = afd._estInicial;
            _estDeAceptacion = afd._estDeAceptacion;
        }
        public string toString()
        {
            string strSimbolos = "Simbolos: " + string.Join(", ", _simbEntrada);
            string strEstados = "Estados: ";
            string strEstInicial = "Estado inicial: " + _estInicial;
            string strEstDeAceptacion = "Estado(s) de Aceptacion: " + string.Join(", ", _estDeAceptacion);
            string strTransiciones = "Transiciones: ";
            Dictionary<string, Estado> aux;
            foreach (var v in _estados)
            {
                strEstados += "{" + v.Value._nombre + "} ";
                foreach (string s in _simbEntrada)
                {
                    aux = v.Value._transiciones[s];
                    foreach (var k in aux) strTransiciones += "{" + k.Key + ":" + k.Value._nombre + "} ";
                }
            }
            string str = strSimbolos + "\n" + strEstados + "\n" + strEstInicial
                + "\n" + strEstDeAceptacion + "\n" + strTransiciones;
            return str;
        }
        public List<Estado> evaluar(List<string> entradas)
        {
            List<Estado> recorrido = new List<Estado>();
            Estado est = _estados[_estInicial];
            recorrido.Add(est);
            foreach(string entrada in entradas)
            {
                if (entrada.Equals(string.Empty)) continue;
                est = est._transiciones[entrada]["0"];
                recorrido.Add(est);
            }
            return recorrido;
        }
    }
}
