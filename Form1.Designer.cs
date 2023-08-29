namespace Sem02_Ejemplo_09
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
            btnBuscar = new Button();
            btnLimpiar = new Button();
            txtTítulo = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtPrimero = new TextBox();
            txtSegundo = new TextBox();
            txtTercero = new TextBox();
            txtMayor = new TextBox();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(181, 229);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(298, 229);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtTítulo
            // 
            txtTítulo.AutoSize = true;
            txtTítulo.BorderStyle = BorderStyle.FixedSingle;
            txtTítulo.Font = new Font("Roboto Slab", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtTítulo.Location = new Point(86, 9);
            txtTítulo.Name = "txtTítulo";
            txtTítulo.Size = new Size(420, 23);
            txtTítulo.TabIndex = 2;
            txtTítulo.Text = "Programa para hallar el mayor de tres números";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 54);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 3;
            label2.Text = "Primer número:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(165, 95);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 4;
            label3.Text = "Segundo número:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(181, 133);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 5;
            label4.Text = "Tercer número:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(198, 168);
            label5.Name = "label5";
            label5.Size = new Size(151, 20);
            label5.TabIndex = 6;
            label5.Text = " El número mayor es: ";
            // 
            // txtPrimero
            // 
            txtPrimero.Location = new Point(273, 51);
            txtPrimero.Name = "txtPrimero";
            txtPrimero.Size = new Size(100, 23);
            txtPrimero.TabIndex = 7;
            // 
            // txtSegundo
            // 
            txtSegundo.Location = new Point(273, 92);
            txtSegundo.Name = "txtSegundo";
            txtSegundo.Size = new Size(100, 23);
            txtSegundo.TabIndex = 8;
            // 
            // txtTercero
            // 
            txtTercero.Location = new Point(273, 130);
            txtTercero.Name = "txtTercero";
            txtTercero.Size = new Size(100, 23);
            txtTercero.TabIndex = 9;
            // 
            // txtMayor
            // 
            txtMayor.Location = new Point(223, 191);
            txtMayor.Name = "txtMayor";
            txtMayor.Size = new Size(100, 23);
            txtMayor.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 264);
            Controls.Add(txtMayor);
            Controls.Add(txtTercero);
            Controls.Add(txtSegundo);
            Controls.Add(txtPrimero);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTítulo);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBuscar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private Button btnLimpiar;
        private Label txtTítulo;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtPrimero;
        private TextBox txtSegundo;
        private TextBox txtTercero;
        private TextBox txtMayor;
    }
}