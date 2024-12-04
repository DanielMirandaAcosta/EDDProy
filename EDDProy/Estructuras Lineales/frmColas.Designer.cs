namespace EDDemo.Estructuras_lineales
{
    partial class frmColas
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.btnDeque = new System.Windows.Forms.Button();
            this.listCola = new System.Windows.Forms.ListBox();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnQueue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 255);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Dato:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(406, 251);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(148, 22);
            this.txtBuscar.TabIndex = 18;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(423, 283);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 28);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Dato:";
            // 
            // btnVaciar
            // 
            this.btnVaciar.Location = new System.Drawing.Point(418, 128);
            this.btnVaciar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(112, 28);
            this.btnVaciar.TabIndex = 15;
            this.btnVaciar.Text = "Vaciar";
            this.btnVaciar.UseVisualStyleBackColor = true;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // btnDeque
            // 
            this.btnDeque.Location = new System.Drawing.Point(418, 92);
            this.btnDeque.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeque.Name = "btnDeque";
            this.btnDeque.Size = new System.Drawing.Size(112, 28);
            this.btnDeque.TabIndex = 14;
            this.btnDeque.Text = "Deque";
            this.btnDeque.UseVisualStyleBackColor = true;
            this.btnDeque.Click += new System.EventHandler(this.btnDeque_Click);
            // 
            // listCola
            // 
            this.listCola.FormattingEnabled = true;
            this.listCola.ItemHeight = 16;
            this.listCola.Location = new System.Drawing.Point(62, 188);
            this.listCola.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listCola.Name = "listCola";
            this.listCola.Size = new System.Drawing.Size(219, 196);
            this.listCola.TabIndex = 13;
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(116, 101);
            this.txtDato.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(148, 22);
            this.txtDato.TabIndex = 12;
            // 
            // btnQueue
            // 
            this.btnQueue.Location = new System.Drawing.Point(132, 133);
            this.btnQueue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQueue.Name = "btnQueue";
            this.btnQueue.Size = new System.Drawing.Size(112, 28);
            this.btnQueue.TabIndex = 11;
            this.btnQueue.Text = "Queue";
            this.btnQueue.UseVisualStyleBackColor = true;
            this.btnQueue.Click += new System.EventHandler(this.btnQueue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Colas";
            // 
            // frmColas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EDDemo.Properties.Resources.unnamed;
            this.ClientSize = new System.Drawing.Size(585, 432);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.btnDeque);
            this.Controls.Add(this.listCola);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.btnQueue);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmColas";
            this.Text = "frmColas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.Button btnDeque;
        private System.Windows.Forms.ListBox listCola;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnQueue;
        private System.Windows.Forms.Label label1;
    }
}