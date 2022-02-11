using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomataAnalyzer
{
    public partial class Form1 : Form
    {
        private AF _autFinito;
        private AFD _autFinDet;
        private TableLayoutPanel _tblIngrTransiciones;
        private TableLayoutPanel _tblAutomataMinimo;
        private TableLayoutPanel _tblPasoPaso;
        private TextBox[,] _tb_tblIngrTransiciones;
        private List<Estado> _recorrido;
        private List<string> _entradas;
        private Estado _anterior, _actual;
        private string _simbolo;
        int _n;
        public Form1()
        {
            InitializeComponent();
            MaximizeBox = false;
            CenterToScreen();
            tb_SimbEntrada.KeyPress += _KeyPress;
            tb_Estados.KeyPress += _KeyPress;
            tb_EstIniciales.KeyPress += _KeyPress;
            tb_EstDeAceptacion.KeyPress += _KeyPress;
            tb_CadenaEvaluar.KeyPress += _KeyPress;
            pnl_IngresarDatos.Enabled = false;
            btn_CrearAutomata.Enabled = false;
            btn_EditAutomata.Enabled = false;
            panel2.Enabled = false;
            panel3.Enabled = false;
            panel6.Enabled = false;
        }

        private void _KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (e.KeyChar == 44)
            {
                if (tb.Text.Length == 0)
                {
                    e.Handled = true;
                    return;
                }
                if (tb.Text.Length >= 1 && tb.Text[tb.Text.Length - 1] == ',')
                {
                    e.Handled = true;
                    return;
                }
            }
            if ((e.KeyChar >= 32 && e.KeyChar < 44) || (e.KeyChar > 44 && e.KeyChar <= 47)
                || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96)
                || e.KeyChar >= 123)
            {
                e.Handled = true;
            }
        }
        private void btn_CrearAutomata_Click(object sender, EventArgs e)
        {
            if (tb_SimbEntrada.Text.Length == 0 || tb_Estados.Text.Length == 0
                || tb_EstIniciales.Text.Length == 0)
            {
                MessageBox.Show("Hay campos sin llenar, por favor verifique e intente nuevamente."
                    , "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> simbEntradas = tb_SimbEntrada.Text.Split(",").Distinct().ToList();
            List<string> estados = tb_Estados.Text.Split(",").Distinct().ToList();
            List<string> estIniciales = tb_EstIniciales.Text.Split(",").Distinct().ToList();
            List<string> estDeAceptacion = tb_EstDeAceptacion.Text.Split(",").Distinct().ToList();

            List<string> listAux = estIniciales.Where(x => !estados.Contains(x)).ToList();
            if (listAux.Count > 0)
            {
                MessageBox.Show("Algunos estados iniciales no son validos"
                        , "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            listAux = null;
            listAux = estDeAceptacion.Where(x => !estados.Contains(x)).ToList();
            if (listAux.Count > 0 && tb_EstDeAceptacion.Text.Length > 0)
            {
                MessageBox.Show("Algunos estados de aceptacion no son validos"
                    , "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _autFinito = new AF(simbEntradas, estados, estIniciales, estDeAceptacion);
            crearTblIngrTransiciones();
            btn_EditAutomata.Enabled = true;
            panel2.Enabled = true;
            pnl_IngresarDatos.Enabled = false;
            btn_CrearAutomata.Enabled = false;
            pnl_IngrTransiciones.Enabled = true;
            btn_ValidarAutomata.Enabled = true;
            btn_EditTransiciones.Enabled = false;
            panel3.Enabled = false;
        }
        private void crearTblIngrTransiciones()
        {
            pnl_IngrTransiciones.Controls.Clear();
            _tblIngrTransiciones = new TableLayoutPanel();
            _tblIngrTransiciones.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            int f = _autFinito._estados.Count();
            int c = _autFinito._simbEntrada.Count;
            _tb_tblIngrTransiciones = new TextBox[f, c];

            int ancho = 80, alto = 25;
            Label lbl;
            for (int i = 0; i <= c; i++)
            {
                lbl = new Label();
                if (i == 0) lbl.Text = "AF";
                else lbl.Text = _autFinito._simbEntrada[i - 1];
                //lbl.BorderStyle = BorderStyle.FixedSingle;
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                if (i == 0) lbl.Size = new Size(ancho + 15, alto);
                else lbl.Size = new Size(ancho, alto);
                _tblIngrTransiciones.Controls.Add(lbl, i, 0);
            }
            TextBox txt;
            List<string> estados = _autFinito._estados.Keys.ToList();
            for (int i = 1; i <= f; i++)
            {
                for (int j = 0; j <= c; j++)
                {
                    if (j == 0)
                    {
                        lbl = new Label();
                        if (_autFinito._estados[estados[i - 1]]._esInicial) 
                            lbl.Text = "--> " + _autFinito._estados[estados[i - 1]]._nombre;
                        else lbl.Text = _autFinito._estados[estados[i - 1]]._nombre;
                        //lbl.BorderStyle = BorderStyle.FixedSingle;
                        lbl.TextAlign = ContentAlignment.MiddleCenter;
                        lbl.Size = new Size(ancho + 15, alto);
                        _tblIngrTransiciones.Controls.Add(lbl, j, i);
                    }
                    else
                    {
                        txt = new TextBox();
                        //txt.BorderStyle = BorderStyle.FixedSingle;
                        txt.TextAlign = HorizontalAlignment.Left;
                        txt.Size = new Size(ancho, alto);
                        _tblIngrTransiciones.Controls.Add(txt, j, i);
                        _tb_tblIngrTransiciones[i - 1, j - 1] = txt;
                    }
                }
            }
            for (int i = 0; i <= f; i++)
            {
                lbl = new Label();
                if (i == 0) lbl.Text = "  ";
                else
                {
                    if (_autFinito._estados[estados[i - 1]]._esDeAceptacion) lbl.Text = "1";
                    else lbl.Text = "0";
                }
                //lbl.BorderStyle = BorderStyle.FixedSingle;
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.Size = new Size(ancho / 2, alto);
                _tblIngrTransiciones.Controls.Add(lbl, c + 1, i);
            }
            _tblIngrTransiciones.AutoSize = true;
            pnl_IngrTransiciones.Controls.Add(_tblIngrTransiciones);
        }
        private void btn_ValidarAutomata_Click(object sender, EventArgs e)
        {
            List<string> aux;
            int f = _tb_tblIngrTransiciones.GetLength(0);
            int c = _tb_tblIngrTransiciones.GetLength(1);
            List<string> estados = _autFinito._estados.Keys.ToList();
            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (_tb_tblIngrTransiciones[i, j].Text.Length == 0)
                    {
                        MessageBox.Show("Campos sin llenar", "Alerta",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    aux = _tb_tblIngrTransiciones[i, j].Text.Split(",").ToList<string>();
                    List<string> listAux = aux.Where(x => !estados.Contains(x)).ToList();
                    if(listAux.Count > 0)
                    {
                        MessageBox.Show("Algunos estados igresados no son validos", "Alerta",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            string[,] transiciones = new string[f, c];
            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    transiciones[i, j] = _tb_tblIngrTransiciones[i, j].Text;
                }
            }
            _autFinito.agregarTransiciones(transiciones);

            _autFinDet = _autFinito.toAFD();
            crerTblAutomataMinimo();

            btn_ValidarAutomata.Enabled = false;
            pnl_IngrTransiciones.Enabled = false;
            btn_EditTransiciones.Enabled = true;
            lbl_NomAutomata.Text = "AFD";
            btn_SimpAutomata.Enabled = true;
            panel3.Enabled = true;
        }
        private void crerTblAutomataMinimo()
        {
            pnl_AutMinimo.Controls.Clear();
            _tblAutomataMinimo = new TableLayoutPanel();
            _tblAutomataMinimo.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            int f = _autFinDet._estados.Count();
            int c = _autFinDet._simbEntrada.Count;

            int ancho = 80, alto = 25;
            Label lbl;
            TextBox txt;
            List<string> estados = _autFinDet._estados.Keys.ToList();
            int max = 11;
            foreach (string s in estados) if (s.Length > max) max = s.Length;
            ancho += (int)((max - 11) * 7.4);
            for (int i = 0; i <= c; i++)
            {
                lbl = new Label();
                if (i == 0) lbl.Text = "AFD";
                else lbl.Text = _autFinDet._simbEntrada[i - 1];
                //lbl.BorderStyle = BorderStyle.FixedSingle;
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                if (i == 0) lbl.Size = new Size(ancho + 15, alto);
                else lbl.Size = new Size(ancho, alto);
                _tblAutomataMinimo.Controls.Add(lbl, i, 0);
            }
            for (int i = 1; i <= f; i++)
            {
                for (int j = 0; j <= c; j++)
                {
                    if (j == 0)
                    {
                        lbl = new Label();
                        if (_autFinDet._estados[estados[i - 1]]._esInicial)
                        {
                            lbl.Text = "--> " + _autFinDet._estados[estados[i - 1]]._nombre;
                        }
                        else lbl.Text = _autFinDet._estados[estados[i - 1]]._nombre;
                        //lbl.BorderStyle = BorderStyle.FixedSingle;
                        lbl.TextAlign = ContentAlignment.MiddleCenter;
                        lbl.Size = new Size(ancho + 15, alto);
                        _tblAutomataMinimo.Controls.Add(lbl, j, i);
                    }
                    else
                    {
                        txt = new TextBox();
                        //txt.BorderStyle = BorderStyle.FixedSingle;
                        txt.TextAlign = HorizontalAlignment.Left;
                        txt.Size = new Size(ancho, alto);
                        string simbolo = _autFinDet._simbEntrada[j - 1];
                        Estado estado = _autFinDet._estados[estados[i - 1]];
                        txt.Text = estado._transiciones[simbolo]["0"]._nombre;
                        txt.Enabled = false;
                        _tblAutomataMinimo.Controls.Add(txt, j, i);
                    }
                }
            }
            for (int i = 0; i <= f; i++)
            {
                lbl = new Label();
                if (i == 0) lbl.Text = "  ";
                else
                {
                    if (_autFinDet._estados[estados[i - 1]]._esDeAceptacion) lbl.Text = "1";
                    else lbl.Text = "0";
                }
                //lbl.BorderStyle = BorderStyle.FixedSingle;
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.Size = new Size(ancho / 2, alto);
                _tblAutomataMinimo.Controls.Add(lbl, c + 1, i);
            }
            _tblAutomataMinimo.AutoSize = true;
            pnl_AutMinimo.Controls.Add(_tblAutomataMinimo);
        }
        private void btn_EvaluarCadena_Click(object sender, EventArgs e)
        {
            string cadena = tb_CadenaEvaluar.Text;
            _entradas = cadena.Split(",").ToList();
            List<string> lisAux = _entradas.Where(x => !_autFinDet._simbEntrada.Contains(x)).ToList();
            if (lisAux.Count > 0 && cadena.Length > 0)
            {
                MessageBox.Show("Algunas entradas no son válidas, por favor verifique e intente nuevamente."
                    , "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            lbl_Simbolo.Text = string.Empty;
            _recorrido = _autFinDet.evaluar(_entradas);
            btn_SiguientePaso.Enabled = true;
            btn_SiguientePaso.Text = "Empezar Recorrido";
            lbl_Simbolo.Text = string.Empty;
            lbl_EstActual.Text = string.Empty;
            lbl_EstAnterior.Text = string.Empty;
            crearTblPasoPaso();
            if (_recorrido[_recorrido.Count - 1]._esDeAceptacion)
            {
                if(cadena.Length > 0)
                {
                    MessageBox.Show("La cadena ingresada es de ACEPTACION."
                    , "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La cadena ingresada es la nula, la cual es de ACEPTACION"
                    , "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (cadena.Length > 0)
                {
                    MessageBox.Show("La cadena ingresada es de RECHAZO."
                    , "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("La cadena ingresada es la nula, la cual es de RECHAZO"
                    , "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btn_EditTransiciones_Click(object sender, EventArgs e)
        {
            pnl_IngrTransiciones.Enabled = true;
            btn_ValidarAutomata.Enabled = true;
            panel3.Enabled = false;
            btn_EditTransiciones.Enabled = false;
            panel6.Enabled = false;
        }
        private void btn_NuevoAutomata_Click(object sender, EventArgs e)
        {
            panel2.Enabled = false;
            tb_SimbEntrada.Text = string.Empty;
            tb_Estados.Text = string.Empty;
            tb_EstIniciales.Text = string.Empty;
            tb_EstDeAceptacion.Text = string.Empty;
            pnl_IngresarDatos.Enabled = true;
            btn_CrearAutomata.Enabled = true;
            tb_SimbEntrada.Focus();
            panel6.Enabled = false;
        }
        private void btn_EditAutomata_Click(object sender, EventArgs e)
        {
            pnl_IngresarDatos.Enabled = true;
            btn_CrearAutomata.Enabled = true;
            tb_SimbEntrada.Focus();
            panel2.Enabled = false;
            panel3.Enabled = false;
            panel6.Enabled = false;
            btn_EditAutomata.Enabled = false;
        }
        private void btn_SimpAutomata_Click(object sender, EventArgs e)
        {
            _autFinDet.simplificar();
            crerTblAutomataMinimo();
            lbl_NomAutomata.Text = "AFD Mínimo";
            btn_SimpAutomata.Enabled = false;
            btn_SiguientePaso.Enabled = false;
            tb_CadenaEvaluar.Text = string.Empty;
            pnl_PasoAPaso.Controls.Clear();
            panel6.Enabled = true;
            lbl_Simbolo.Text = string.Empty;
            lbl_EstActual.Text = string.Empty;
            lbl_EstAnterior.Text = string.Empty;
            MessageBox.Show("El AFD ha sido simplificado."
                    , "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btn_SiguientePaso_Click(object sender, EventArgs e)
        {
            if(((Button)sender).Text.Equals("Empezar Recorrido"))
            {
                _n = -1;
                _actual = null;
                lbl_Simbolo.Text = "¬";
                _simbolo = string.Empty;
                lbl_EstAnterior.Text = string.Empty;
                ((Button)sender).Text = "Siguiente";
            }
            _anterior = _actual;
            _n++;
            if (_n > 0)
            {
                _simbolo = _entradas[_n - 1];
                lbl_Simbolo.Text = _simbolo;
                lbl_EstAnterior.Text = _anterior._nombre;
            }
            _actual = _recorrido[_n];
            lbl_EstActual.Text = _actual._nombre;
            actualizarTablaPasoApaso();
            if(_n == (_recorrido.Count - 1))
            {
                ((Button)sender).Text = "Empezar Recorrido";
                ultimaEntrada();
            }
        }
        private void crearTblPasoPaso()
        {
            pnl_PasoAPaso.Controls.Clear();
            _tblPasoPaso = new TableLayoutPanel();
            _tblPasoPaso.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            int f = _autFinDet._estados.Count();
            int c = _autFinDet._simbEntrada.Count;

            int ancho = 80, alto = 25;
            Label lbl;
            TextBox txt;
            List<string> estados = _autFinDet._estados.Keys.ToList();
            int max = 11;
            foreach (string s in estados) if (s.Length > max) max = s.Length;
            ancho += (int)((max - 11) * 7.4);
            for (int i = 0; i <= c; i++)
            {
                lbl = new Label();
                if (i == 0) lbl.Text = "AFD";
                else lbl.Text = _autFinDet._simbEntrada[i - 1];
                //lbl.BorderStyle = BorderStyle.FixedSingle;
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                if (i == 0) lbl.Size = new Size(ancho + 15, alto);
                else lbl.Size = new Size(ancho, alto);
                _tblPasoPaso.Controls.Add(lbl, i, 0);
            }
            for (int i = 1; i <= f; i++)
            {
                for (int j = 0; j <= c; j++)
                {
                    if (j == 0)
                    {
                        lbl = new Label();
                        if (_autFinDet._estados[estados[i - 1]]._esInicial)
                        {
                            lbl.Text = "--> " + _autFinDet._estados[estados[i - 1]]._nombre;
                        }
                        else lbl.Text = _autFinDet._estados[estados[i - 1]]._nombre;
                        //lbl.BorderStyle = BorderStyle.FixedSingle;
                        lbl.TextAlign = ContentAlignment.MiddleCenter;
                        lbl.Size = new Size(ancho + 15, alto);
                        _tblPasoPaso.Controls.Add(lbl, j, i);
                    }
                    else
                    {
                        txt = new TextBox();
                        //txt.BorderStyle = BorderStyle.FixedSingle;
                        txt.TextAlign = HorizontalAlignment.Left;
                        txt.Size = new Size(ancho, alto);
                        string simbolo = _autFinDet._simbEntrada[j - 1];
                        Estado estado = _autFinDet._estados[estados[i - 1]];
                        txt.Text = estado._transiciones[simbolo]["0"]._nombre;
                        txt.Enabled = false;
                        _tblPasoPaso.Controls.Add(txt, j, i);
                    }
                }
            }
            for (int i = 0; i <= f; i++)
            {
                lbl = new Label();
                if (i == 0) lbl.Text = "  ";
                else
                {
                    if (_autFinDet._estados[estados[i - 1]]._esDeAceptacion) lbl.Text = "1";
                    else lbl.Text = "0";
                }
                //lbl.BorderStyle = BorderStyle.FixedSingle;
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.Size = new Size(ancho / 2, alto);
                _tblPasoPaso.Controls.Add(lbl, c + 1, i);
            }
            _tblPasoPaso.AutoSize = true;
            pnl_PasoAPaso.Controls.Add(_tblPasoPaso);
        }
        private void actualizarTablaPasoApaso()
        {
            foreach(Control ctrl in _tblPasoPaso.Controls)
            {
                ctrl.BackColor = Color.White;
            }
            int f = 0, c = 0;
            List<string> simbolos = _autFinDet._simbEntrada;
            List<string> estados = _autFinDet._estados.Keys.ToList();
            if (_anterior != null)
            {
                for (int i = 0; i < estados.Count; i++)
                {
                    if (estados[i].Equals(_anterior._nombre))
                    {
                        f = i;
                        break;
                    }
                }
                for (int i = 0; i < simbolos.Count; i++)
                {
                    if (simbolos[i].Equals(_simbolo))
                    {
                        c = i;
                        break;
                    }
                }
                _tblPasoPaso.GetControlFromPosition(c + 1, 0).BackColor = Color.LightBlue;
                _tblPasoPaso.GetControlFromPosition(0, f + 1).BackColor = Color.LightBlue;
                _tblPasoPaso.GetControlFromPosition(c + 1, f + 1).BackColor = Color.LightBlue;
            }
            for (int i = 0; i < estados.Count; i++)
            {
                if (estados[i].Equals(_actual._nombre))
                {
                    f = i;
                    break;
                }
            }
            for(int i = 0; i < (simbolos.Count + 2); i++)
            {
                _tblPasoPaso.GetControlFromPosition(i, f + 1).BackColor = Color.Orange;
            }
        }
        private void ultimaEntrada()
        {
            if (_actual._esDeAceptacion)
            {
                MessageBox.Show("Se ha ingresado el ultimo simbolo.\n" +
                    "El estado actual es de aceptacion por lo tanto la cadena ingresada es de ACEPTACION."
                    , "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Se ha ingresado el ultimo simbolo.\n" +
                    "El estado actual es de rechazo por lo tanto la cadena ingresada es de RECHAZO."
                    , "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
