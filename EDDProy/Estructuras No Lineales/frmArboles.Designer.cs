﻿
namespace EDDemo.Estructuras_No_Lineales
{
    partial class frmArboles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtArbol = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGrafica = new System.Windows.Forms.Button();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.lblDatos = new System.Windows.Forms.Label();
            this.btnCrearArbol = new System.Windows.Forms.Button();
            this.txtNodos = new System.Windows.Forms.NumericUpDown();
            this.rbOrientacion1 = new System.Windows.Forms.RadioButton();
            this.rbOrientacion2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRecorridoPreOrden = new System.Windows.Forms.Label();
            this.lblRecorridoInOrden = new System.Windows.Forms.Label();
            this.lblPreOrden = new System.Windows.Forms.Label();
            this.lblInOrden = new System.Windows.Forms.Label();
            this.lblRecorridoPostOrden = new System.Windows.Forms.Label();
            this.lblPostOrden = new System.Windows.Forms.Label();
            this.BotonBuscar = new System.Windows.Forms.Button();
            this.CajaDeBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EliminarText = new System.Windows.Forms.TextBox();
            this.EliminarBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Niveles = new System.Windows.Forms.Label();
            this.InfoArbol = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(57, 19);
            this.txtDato.Margin = new System.Windows.Forms.Padding(2);
            this.txtDato.Multiline = true;
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(68, 31);
            this.txtDato.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(138, 19);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(83, 29);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Insertar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtArbol
            // 
            this.txtArbol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArbol.Location = new System.Drawing.Point(21, 263);
            this.txtArbol.Margin = new System.Windows.Forms.Padding(2);
            this.txtArbol.Multiline = true;
            this.txtArbol.Name = "txtArbol";
            this.txtArbol.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtArbol.Size = new System.Drawing.Size(642, 325);
            this.txtArbol.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.Location = new System.Drawing.Point(232, 19);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(83, 29);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGrafica
            // 
            this.btnGrafica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrafica.Location = new System.Drawing.Point(328, 21);
            this.btnGrafica.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrafica.Name = "btnGrafica";
            this.btnGrafica.Size = new System.Drawing.Size(258, 29);
            this.btnGrafica.TabIndex = 3;
            this.btnGrafica.Text = "Grafica De Nodos";
            this.btnGrafica.UseVisualStyleBackColor = true;
            this.btnGrafica.Click += new System.EventHandler(this.btnGrafica_Click);
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.Location = new System.Drawing.Point(232, 60);
            this.btnRecorrer.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(83, 40);
            this.btnRecorrer.TabIndex = 4;
            this.btnRecorrer.Text = "Recorrido";
            this.btnRecorrer.UseVisualStyleBackColor = true;
            this.btnRecorrer.Click += new System.EventHandler(this.btnRecorrer_Click);
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(8, 26);
            this.lblDatos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(42, 16);
            this.lblDatos.TabIndex = 5;
            this.lblDatos.Text = "Dato :";
            // 
            // btnCrearArbol
            // 
            this.btnCrearArbol.Location = new System.Drawing.Point(138, 59);
            this.btnCrearArbol.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearArbol.Name = "btnCrearArbol";
            this.btnCrearArbol.Size = new System.Drawing.Size(83, 42);
            this.btnCrearArbol.TabIndex = 6;
            this.btnCrearArbol.Text = "Crear Arbol";
            this.btnCrearArbol.UseVisualStyleBackColor = true;
            this.btnCrearArbol.Click += new System.EventHandler(this.btnCrearArbol_Click);
            // 
            // txtNodos
            // 
            this.txtNodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNodos.Location = new System.Drawing.Point(54, 66);
            this.txtNodos.Margin = new System.Windows.Forms.Padding(2);
            this.txtNodos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNodos.Name = "txtNodos";
            this.txtNodos.Size = new System.Drawing.Size(80, 28);
            this.txtNodos.TabIndex = 8;
            this.txtNodos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rbOrientacion1
            // 
            this.rbOrientacion1.AutoSize = true;
            this.rbOrientacion1.Location = new System.Drawing.Point(590, 26);
            this.rbOrientacion1.Margin = new System.Windows.Forms.Padding(2);
            this.rbOrientacion1.Name = "rbOrientacion1";
            this.rbOrientacion1.Size = new System.Drawing.Size(73, 20);
            this.rbOrientacion1.TabIndex = 15;
            this.rbOrientacion1.TabStop = true;
            this.rbOrientacion1.Text = "Vertical";
            this.rbOrientacion1.UseVisualStyleBackColor = true;
            // 
            // rbOrientacion2
            // 
            this.rbOrientacion2.AutoSize = true;
            this.rbOrientacion2.Location = new System.Drawing.Point(590, 66);
            this.rbOrientacion2.Margin = new System.Windows.Forms.Padding(2);
            this.rbOrientacion2.Name = "rbOrientacion2";
            this.rbOrientacion2.Size = new System.Drawing.Size(88, 20);
            this.rbOrientacion2.TabIndex = 16;
            this.rbOrientacion2.TabStop = true;
            this.rbOrientacion2.Text = "Horizontal";
            this.rbOrientacion2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Niveles);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblRecorridoPreOrden);
            this.groupBox1.Controls.Add(this.lblRecorridoInOrden);
            this.groupBox1.Controls.Add(this.lblPreOrden);
            this.groupBox1.Controls.Add(this.lblInOrden);
            this.groupBox1.Controls.Add(this.lblRecorridoPostOrden);
            this.groupBox1.Controls.Add(this.lblPostOrden);
            this.groupBox1.Location = new System.Drawing.Point(232, 104);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(445, 155);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recorridos";
            // 
            // lblRecorridoPreOrden
            // 
            this.lblRecorridoPreOrden.AutoSize = true;
            this.lblRecorridoPreOrden.Location = new System.Drawing.Point(93, 30);
            this.lblRecorridoPreOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoPreOrden.Name = "lblRecorridoPreOrden";
            this.lblRecorridoPreOrden.Size = new System.Drawing.Size(16, 16);
            this.lblRecorridoPreOrden.TabIndex = 20;
            this.lblRecorridoPreOrden.Text = "...";
            // 
            // lblRecorridoInOrden
            // 
            this.lblRecorridoInOrden.AutoSize = true;
            this.lblRecorridoInOrden.Location = new System.Drawing.Point(93, 62);
            this.lblRecorridoInOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoInOrden.Name = "lblRecorridoInOrden";
            this.lblRecorridoInOrden.Size = new System.Drawing.Size(16, 16);
            this.lblRecorridoInOrden.TabIndex = 19;
            this.lblRecorridoInOrden.Text = "...";
            // 
            // lblPreOrden
            // 
            this.lblPreOrden.AutoSize = true;
            this.lblPreOrden.Location = new System.Drawing.Point(13, 30);
            this.lblPreOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreOrden.Name = "lblPreOrden";
            this.lblPreOrden.Size = new System.Drawing.Size(68, 16);
            this.lblPreOrden.TabIndex = 18;
            this.lblPreOrden.Text = "PreOrden:";
            // 
            // lblInOrden
            // 
            this.lblInOrden.AutoSize = true;
            this.lblInOrden.Location = new System.Drawing.Point(23, 62);
            this.lblInOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInOrden.Name = "lblInOrden";
            this.lblInOrden.Size = new System.Drawing.Size(57, 16);
            this.lblInOrden.TabIndex = 17;
            this.lblInOrden.Text = "InOrden:";
            // 
            // lblRecorridoPostOrden
            // 
            this.lblRecorridoPostOrden.AutoSize = true;
            this.lblRecorridoPostOrden.Location = new System.Drawing.Point(93, 92);
            this.lblRecorridoPostOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoPostOrden.Name = "lblRecorridoPostOrden";
            this.lblRecorridoPostOrden.Size = new System.Drawing.Size(16, 16);
            this.lblRecorridoPostOrden.TabIndex = 16;
            this.lblRecorridoPostOrden.Text = "...";
            // 
            // lblPostOrden
            // 
            this.lblPostOrden.AutoSize = true;
            this.lblPostOrden.Location = new System.Drawing.Point(9, 92);
            this.lblPostOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPostOrden.Name = "lblPostOrden";
            this.lblPostOrden.Size = new System.Drawing.Size(74, 16);
            this.lblPostOrden.TabIndex = 15;
            this.lblPostOrden.Text = "PostOrden:";
            // 
            // BotonBuscar
            // 
            this.BotonBuscar.Location = new System.Drawing.Point(138, 134);
            this.BotonBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.BotonBuscar.Name = "BotonBuscar";
            this.BotonBuscar.Size = new System.Drawing.Size(83, 29);
            this.BotonBuscar.TabIndex = 21;
            this.BotonBuscar.Text = "Buscar";
            this.BotonBuscar.UseVisualStyleBackColor = true;
            this.BotonBuscar.Click += new System.EventHandler(this.BotonBuscar_Click);
            // 
            // CajaDeBuscar
            // 
            this.CajaDeBuscar.Location = new System.Drawing.Point(57, 134);
            this.CajaDeBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.CajaDeBuscar.Multiline = true;
            this.CajaDeBuscar.Name = "CajaDeBuscar";
            this.CajaDeBuscar.Size = new System.Drawing.Size(68, 31);
            this.CajaDeBuscar.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Buscar Nodo";
            // 
            // EliminarText
            // 
            this.EliminarText.Location = new System.Drawing.Point(57, 212);
            this.EliminarText.Margin = new System.Windows.Forms.Padding(2);
            this.EliminarText.Multiline = true;
            this.EliminarText.Name = "EliminarText";
            this.EliminarText.Size = new System.Drawing.Size(68, 31);
            this.EliminarText.TabIndex = 24;
            // 
            // EliminarBtn
            // 
            this.EliminarBtn.Location = new System.Drawing.Point(138, 212);
            this.EliminarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.EliminarBtn.Name = "EliminarBtn";
            this.EliminarBtn.Size = new System.Drawing.Size(83, 29);
            this.EliminarBtn.TabIndex = 25;
            this.EliminarBtn.Text = "Eliminar";
            this.EliminarBtn.UseVisualStyleBackColor = true;
            this.EliminarBtn.Click += new System.EventHandler(this.EliminarBtn_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Por Niveles:";
            // 
            // Niveles
            // 
            this.Niveles.AutoSize = true;
            this.Niveles.Location = new System.Drawing.Point(93, 123);
            this.Niveles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Niveles.Name = "Niveles";
            this.Niveles.Size = new System.Drawing.Size(16, 16);
            this.Niveles.TabIndex = 22;
            this.Niveles.Text = "...";
            // 
            // InfoArbol
            // 
            this.InfoArbol.Location = new System.Drawing.Point(328, 60);
            this.InfoArbol.Margin = new System.Windows.Forms.Padding(2);
            this.InfoArbol.Name = "InfoArbol";
            this.InfoArbol.Size = new System.Drawing.Size(258, 41);
            this.InfoArbol.TabIndex = 26;
            this.InfoArbol.Text = "Informacion del Arbol";
            this.InfoArbol.UseVisualStyleBackColor = true;
            this.InfoArbol.Click += new System.EventHandler(this.InfoArbol_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Eliminar Nodo";
            // 
            // frmArboles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 620);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InfoArbol);
            this.Controls.Add(this.EliminarBtn);
            this.Controls.Add(this.EliminarText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CajaDeBuscar);
            this.Controls.Add(this.BotonBuscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbOrientacion2);
            this.Controls.Add(this.rbOrientacion1);
            this.Controls.Add(this.txtNodos);
            this.Controls.Add(this.btnCrearArbol);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.btnRecorrer);
            this.Controls.Add(this.btnGrafica);
            this.Controls.Add(this.txtArbol);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDato);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmArboles";
            this.Text = "frmArboles";
            this.Load += new System.EventHandler(this.frmArboles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtArbol;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGrafica;
        private System.Windows.Forms.Button btnRecorrer;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Button btnCrearArbol;
        private System.Windows.Forms.NumericUpDown txtNodos;
        private System.Windows.Forms.RadioButton rbOrientacion1;
        private System.Windows.Forms.RadioButton rbOrientacion2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRecorridoPreOrden;
        private System.Windows.Forms.Label lblRecorridoInOrden;
        private System.Windows.Forms.Label lblPreOrden;
        private System.Windows.Forms.Label lblInOrden;
        private System.Windows.Forms.Label lblRecorridoPostOrden;
        private System.Windows.Forms.Label lblPostOrden;
        private System.Windows.Forms.Button BotonBuscar;
        private System.Windows.Forms.TextBox CajaDeBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Niveles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EliminarText;
        private System.Windows.Forms.Button EliminarBtn;
        private System.Windows.Forms.Button InfoArbol;
        private System.Windows.Forms.Label label3;
    }
}