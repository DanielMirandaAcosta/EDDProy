namespace Algoritmos_recursividad
{
    partial class HanoiForm
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
            this.back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.diskNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Movimientos = new System.Windows.Forms.ListBox();
            this.Clear = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Label();
            this.complex = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.diskNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Red;
            this.back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.back.Location = new System.Drawing.Point(640, 374);
            this.back.Margin = new System.Windows.Forms.Padding(0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(121, 40);
            this.back.TabIndex = 10;
            this.back.Text = "Regresar";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(10, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 36);
            this.label1.TabIndex = 11;
            this.label1.Text = "Torre de Hanoi";
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.SeaGreen;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.start.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(58, 270);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(139, 42);
            this.start.TabIndex = 16;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // diskNumeric
            // 
            this.diskNumeric.Location = new System.Drawing.Point(65, 200);
            this.diskNumeric.Name = "diskNumeric";
            this.diskNumeric.Size = new System.Drawing.Size(120, 20);
            this.diskNumeric.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(26, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ingrese el número de discos";
            // 
            // Movimientos
            // 
            this.Movimientos.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Movimientos.FormattingEnabled = true;
            this.Movimientos.ItemHeight = 12;
            this.Movimientos.Location = new System.Drawing.Point(458, 135);
            this.Movimientos.Name = "Movimientos";
            this.Movimientos.Size = new System.Drawing.Size(320, 100);
            this.Movimientos.TabIndex = 19;
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.SeaGreen;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clear.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(551, 270);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(139, 42);
            this.Clear.TabIndex = 20;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.time.Location = new System.Drawing.Point(473, 338);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(0, 13);
            this.time.TabIndex = 21;
            // 
            // complex
            // 
            this.complex.AutoSize = true;
            this.complex.BackColor = System.Drawing.Color.Transparent;
            this.complex.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complex.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.complex.Location = new System.Drawing.Point(508, 24);
            this.complex.Name = "complex";
            this.complex.Size = new System.Drawing.Size(287, 13);
            this.complex.TabIndex = 22;
            this.complex.Text = "La complejidad del algoritmo es de O(2^n)";
            // 
            // HanoiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Algoritmos_recursividad.Properties.Resources.unnamed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.complex);
            this.Controls.Add(this.time);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Movimientos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.diskNumeric);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Name = "HanoiForm";
            this.Text = "HanoiForm";
            ((System.ComponentModel.ISupportInitialize)(this.diskNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.NumericUpDown diskNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox Movimientos;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label complex;
    }
}