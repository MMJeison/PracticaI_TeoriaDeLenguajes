
namespace AutomataAnalyzer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_CrearAutomata = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_EditAutomata = new System.Windows.Forms.Button();
            this.tbn_NuevoAutomata = new System.Windows.Forms.Button();
            this.pnl_IngresarDatos = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_EstDeAceptacion = new System.Windows.Forms.TextBox();
            this.tb_EstIniciales = new System.Windows.Forms.TextBox();
            this.tb_Estados = new System.Windows.Forms.TextBox();
            this.tb_SimbEntrada = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_EditTransiciones = new System.Windows.Forms.Button();
            this.btn_ValidarAutomata = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pnl_IngrTransiciones = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_SimpAutomata = new System.Windows.Forms.Button();
            this.lbl_NomAutomata = new System.Windows.Forms.Label();
            this.pnl_AutMinimo = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_EstAnterior = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_EstActual = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_Simbolo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_SiguientePaso = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_EvaluarCadena = new System.Windows.Forms.Button();
            this.tb_CadenaEvaluar = new System.Windows.Forms.TextBox();
            this.pnl_PasoAPaso = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnl_IngresarDatos.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_CrearAutomata
            // 
            this.btn_CrearAutomata.Location = new System.Drawing.Point(299, 210);
            this.btn_CrearAutomata.Name = "btn_CrearAutomata";
            this.btn_CrearAutomata.Size = new System.Drawing.Size(90, 25);
            this.btn_CrearAutomata.TabIndex = 0;
            this.btn_CrearAutomata.Text = "Crear";
            this.btn_CrearAutomata.UseVisualStyleBackColor = true;
            this.btn_CrearAutomata.Click += new System.EventHandler(this.btn_CrearAutomata_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_EditAutomata);
            this.panel1.Controls.Add(this.tbn_NuevoAutomata);
            this.panel1.Controls.Add(this.pnl_IngresarDatos);
            this.panel1.Controls.Add(this.btn_CrearAutomata);
            this.panel1.Location = new System.Drawing.Point(31, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 245);
            this.panel1.TabIndex = 1;
            // 
            // btn_EditAutomata
            // 
            this.btn_EditAutomata.Location = new System.Drawing.Point(181, 211);
            this.btn_EditAutomata.Name = "btn_EditAutomata";
            this.btn_EditAutomata.Size = new System.Drawing.Size(90, 25);
            this.btn_EditAutomata.TabIndex = 3;
            this.btn_EditAutomata.Text = "Editar";
            this.btn_EditAutomata.UseVisualStyleBackColor = true;
            this.btn_EditAutomata.Click += new System.EventHandler(this.btn_EditAutomata_Click);
            // 
            // tbn_NuevoAutomata
            // 
            this.tbn_NuevoAutomata.Location = new System.Drawing.Point(42, 211);
            this.tbn_NuevoAutomata.Name = "tbn_NuevoAutomata";
            this.tbn_NuevoAutomata.Size = new System.Drawing.Size(111, 23);
            this.tbn_NuevoAutomata.TabIndex = 2;
            this.tbn_NuevoAutomata.Text = "Nuevo Automata";
            this.tbn_NuevoAutomata.UseVisualStyleBackColor = true;
            this.tbn_NuevoAutomata.Click += new System.EventHandler(this.btn_NuevoAutomata_Click);
            // 
            // pnl_IngresarDatos
            // 
            this.pnl_IngresarDatos.Controls.Add(this.label5);
            this.pnl_IngresarDatos.Controls.Add(this.tb_EstDeAceptacion);
            this.pnl_IngresarDatos.Controls.Add(this.tb_EstIniciales);
            this.pnl_IngresarDatos.Controls.Add(this.tb_Estados);
            this.pnl_IngresarDatos.Controls.Add(this.tb_SimbEntrada);
            this.pnl_IngresarDatos.Controls.Add(this.label4);
            this.pnl_IngresarDatos.Controls.Add(this.label3);
            this.pnl_IngresarDatos.Controls.Add(this.label2);
            this.pnl_IngresarDatos.Controls.Add(this.label1);
            this.pnl_IngresarDatos.Location = new System.Drawing.Point(-1, -1);
            this.pnl_IngresarDatos.Name = "pnl_IngresarDatos";
            this.pnl_IngresarDatos.Size = new System.Drawing.Size(405, 205);
            this.pnl_IngresarDatos.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(26, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(362, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ingresar datos del Automata";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_EstDeAceptacion
            // 
            this.tb_EstDeAceptacion.Location = new System.Drawing.Point(117, 162);
            this.tb_EstDeAceptacion.Name = "tb_EstDeAceptacion";
            this.tb_EstDeAceptacion.Size = new System.Drawing.Size(271, 23);
            this.tb_EstDeAceptacion.TabIndex = 7;
            // 
            // tb_EstIniciales
            // 
            this.tb_EstIniciales.Location = new System.Drawing.Point(117, 127);
            this.tb_EstIniciales.Name = "tb_EstIniciales";
            this.tb_EstIniciales.Size = new System.Drawing.Size(271, 23);
            this.tb_EstIniciales.TabIndex = 6;
            // 
            // tb_Estados
            // 
            this.tb_Estados.Location = new System.Drawing.Point(117, 92);
            this.tb_Estados.Name = "tb_Estados";
            this.tb_Estados.Size = new System.Drawing.Size(271, 23);
            this.tb_Estados.TabIndex = 5;
            // 
            // tb_SimbEntrada
            // 
            this.tb_SimbEntrada.Location = new System.Drawing.Point(117, 57);
            this.tb_SimbEntrada.Name = "tb_SimbEntrada";
            this.tb_SimbEntrada.Size = new System.Drawing.Size(271, 23);
            this.tb_SimbEntrada.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(26, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estado(s) de Aceptacion:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(26, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado(s) Inicial(es):";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(26, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estados:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(26, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simbolos de entrada:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_EditTransiciones);
            this.panel2.Controls.Add(this.btn_ValidarAutomata);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.pnl_IngrTransiciones);
            this.panel2.Location = new System.Drawing.Point(444, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(603, 245);
            this.panel2.TabIndex = 2;
            // 
            // btn_EditTransiciones
            // 
            this.btn_EditTransiciones.Location = new System.Drawing.Point(502, 126);
            this.btn_EditTransiciones.Name = "btn_EditTransiciones";
            this.btn_EditTransiciones.Size = new System.Drawing.Size(90, 42);
            this.btn_EditTransiciones.TabIndex = 3;
            this.btn_EditTransiciones.Text = "Editar Transiciones";
            this.btn_EditTransiciones.UseVisualStyleBackColor = true;
            this.btn_EditTransiciones.Click += new System.EventHandler(this.btn_EditTransiciones_Click);
            // 
            // btn_ValidarAutomata
            // 
            this.btn_ValidarAutomata.Location = new System.Drawing.Point(502, 73);
            this.btn_ValidarAutomata.Name = "btn_ValidarAutomata";
            this.btn_ValidarAutomata.Size = new System.Drawing.Size(89, 23);
            this.btn_ValidarAutomata.TabIndex = 2;
            this.btn_ValidarAutomata.Text = "Validar";
            this.btn_ValidarAutomata.UseVisualStyleBackColor = true;
            this.btn_ValidarAutomata.Click += new System.EventHandler(this.btn_ValidarAutomata_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(500, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 45);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ingresar Transiciones";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_IngrTransiciones
            // 
            this.pnl_IngrTransiciones.AutoScroll = true;
            this.pnl_IngrTransiciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_IngrTransiciones.Location = new System.Drawing.Point(-1, -1);
            this.pnl_IngrTransiciones.Name = "pnl_IngrTransiciones";
            this.pnl_IngrTransiciones.Size = new System.Drawing.Size(495, 245);
            this.pnl_IngrTransiciones.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btn_SimpAutomata);
            this.panel3.Controls.Add(this.lbl_NomAutomata);
            this.panel3.Controls.Add(this.pnl_AutMinimo);
            this.panel3.Location = new System.Drawing.Point(31, 290);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(465, 359);
            this.panel3.TabIndex = 3;
            // 
            // btn_SimpAutomata
            // 
            this.btn_SimpAutomata.Location = new System.Drawing.Point(314, 8);
            this.btn_SimpAutomata.Name = "btn_SimpAutomata";
            this.btn_SimpAutomata.Size = new System.Drawing.Size(90, 25);
            this.btn_SimpAutomata.TabIndex = 2;
            this.btn_SimpAutomata.Text = "Simplificar";
            this.btn_SimpAutomata.UseVisualStyleBackColor = true;
            this.btn_SimpAutomata.Click += new System.EventHandler(this.btn_SimpAutomata_Click);
            // 
            // lbl_NomAutomata
            // 
            this.lbl_NomAutomata.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_NomAutomata.Location = new System.Drawing.Point(3, 8);
            this.lbl_NomAutomata.Name = "lbl_NomAutomata";
            this.lbl_NomAutomata.Size = new System.Drawing.Size(218, 29);
            this.lbl_NomAutomata.TabIndex = 1;
            this.lbl_NomAutomata.Text = "AFD";
            this.lbl_NomAutomata.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_AutMinimo
            // 
            this.pnl_AutMinimo.AutoScroll = true;
            this.pnl_AutMinimo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_AutMinimo.Location = new System.Drawing.Point(-1, 45);
            this.pnl_AutMinimo.Name = "pnl_AutMinimo";
            this.pnl_AutMinimo.Size = new System.Drawing.Size(465, 313);
            this.pnl_AutMinimo.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.lbl_EstAnterior);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.lbl_EstActual);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.lbl_Simbolo);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.btn_SiguientePaso);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.btn_EvaluarCadena);
            this.panel6.Controls.Add(this.tb_CadenaEvaluar);
            this.panel6.Controls.Add(this.pnl_PasoAPaso);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Location = new System.Drawing.Point(502, 291);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(545, 359);
            this.panel6.TabIndex = 4;
            // 
            // lbl_EstAnterior
            // 
            this.lbl_EstAnterior.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_EstAnterior.Location = new System.Drawing.Point(292, 71);
            this.lbl_EstAnterior.Name = "lbl_EstAnterior";
            this.lbl_EstAnterior.Size = new System.Drawing.Size(92, 20);
            this.lbl_EstAnterior.TabIndex = 12;
            this.lbl_EstAnterior.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(139, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Estado anterior:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_EstActual
            // 
            this.lbl_EstActual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_EstActual.Location = new System.Drawing.Point(292, 51);
            this.lbl_EstActual.Name = "lbl_EstActual";
            this.lbl_EstActual.Size = new System.Drawing.Size(92, 20);
            this.lbl_EstActual.TabIndex = 10;
            this.lbl_EstActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(139, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Estado actual:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Simbolo
            // 
            this.lbl_Simbolo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Simbolo.Location = new System.Drawing.Point(292, 30);
            this.lbl_Simbolo.Name = "lbl_Simbolo";
            this.lbl_Simbolo.Size = new System.Drawing.Size(92, 20);
            this.lbl_Simbolo.TabIndex = 8;
            this.lbl_Simbolo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(139, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Simbolo procesado:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_SiguientePaso
            // 
            this.btn_SiguientePaso.Location = new System.Drawing.Point(407, 50);
            this.btn_SiguientePaso.Name = "btn_SiguientePaso";
            this.btn_SiguientePaso.Size = new System.Drawing.Size(125, 25);
            this.btn_SiguientePaso.TabIndex = 6;
            this.btn_SiguientePaso.Text = "Empezar Recorrido";
            this.btn_SiguientePaso.UseVisualStyleBackColor = true;
            this.btn_SiguientePaso.Click += new System.EventHandler(this.btn_SiguientePaso_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(-1, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 61);
            this.label9.TabIndex = 5;
            this.label9.Text = "Reconocimiento paso a paso";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_EvaluarCadena
            // 
            this.btn_EvaluarCadena.Location = new System.Drawing.Point(442, 3);
            this.btn_EvaluarCadena.Name = "btn_EvaluarCadena";
            this.btn_EvaluarCadena.Size = new System.Drawing.Size(90, 25);
            this.btn_EvaluarCadena.TabIndex = 4;
            this.btn_EvaluarCadena.Text = "Evaluar";
            this.btn_EvaluarCadena.UseVisualStyleBackColor = true;
            this.btn_EvaluarCadena.Click += new System.EventHandler(this.btn_EvaluarCadena_Click);
            // 
            // tb_CadenaEvaluar
            // 
            this.tb_CadenaEvaluar.Location = new System.Drawing.Point(159, 4);
            this.tb_CadenaEvaluar.Name = "tb_CadenaEvaluar";
            this.tb_CadenaEvaluar.Size = new System.Drawing.Size(277, 23);
            this.tb_CadenaEvaluar.TabIndex = 3;
            // 
            // pnl_PasoAPaso
            // 
            this.pnl_PasoAPaso.AutoScroll = true;
            this.pnl_PasoAPaso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_PasoAPaso.Location = new System.Drawing.Point(-1, 97);
            this.pnl_PasoAPaso.Name = "pnl_PasoAPaso";
            this.pnl_PasoAPaso.Size = new System.Drawing.Size(545, 260);
            this.pnl_PasoAPaso.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(-1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 29);
            this.label8.TabIndex = 1;
            this.label8.Text = "Ingrese una cadena:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AutomataAnalyzer";
            this.panel1.ResumeLayout(false);
            this.pnl_IngresarDatos.ResumeLayout(false);
            this.pnl_IngresarDatos.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CrearAutomata;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_IngresarDatos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_IngrTransiciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_EstDeAceptacion;
        private System.Windows.Forms.TextBox tb_EstIniciales;
        private System.Windows.Forms.TextBox tb_Estados;
        private System.Windows.Forms.TextBox tb_SimbEntrada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_ValidarAutomata;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_NomAutomata;
        private System.Windows.Forms.Panel pnl_AutMinimo;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_EvaluarCadena;
        private System.Windows.Forms.TextBox tb_CadenaEvaluar;
        private System.Windows.Forms.Panel pnl_PasoAPaso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_SiguientePaso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_Simbolo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_EditTransiciones;
        private System.Windows.Forms.Button btn_EditAutomata;
        private System.Windows.Forms.Button tbn_NuevoAutomata;
        private System.Windows.Forms.Button btn_SimpAutomata;
        private System.Windows.Forms.Label lbl_EstAnterior;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_EstActual;
        private System.Windows.Forms.Label label11;
    }
}

