namespace TreballadorSalari
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBNom = new System.Windows.Forms.TextBox();
            this.CBSexo = new System.Windows.Forms.ComboBox();
            this.TBSalario = new System.Windows.Forms.TextBox();
            this.BTGuardar = new System.Windows.Forms.Button();
            this.BTMostrar = new System.Windows.Forms.Button();
            this.BTCalcSal = new System.Windows.Forms.Button();
            this.RTB1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sexo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salario";
            // 
            // TBNom
            // 
            this.TBNom.Location = new System.Drawing.Point(94, 26);
            this.TBNom.Name = "TBNom";
            this.TBNom.Size = new System.Drawing.Size(100, 20);
            this.TBNom.TabIndex = 3;
            // 
            // CBSexo
            // 
            this.CBSexo.FormattingEnabled = true;
            this.CBSexo.Items.AddRange(new object[] {
            "H",
            "D"});
            this.CBSexo.Location = new System.Drawing.Point(94, 88);
            this.CBSexo.Name = "CBSexo";
            this.CBSexo.Size = new System.Drawing.Size(48, 21);
            this.CBSexo.TabIndex = 4;
            // 
            // TBSalario
            // 
            this.TBSalario.Location = new System.Drawing.Point(94, 142);
            this.TBSalario.Name = "TBSalario";
            this.TBSalario.Size = new System.Drawing.Size(100, 20);
            this.TBSalario.TabIndex = 5;
            // 
            // BTGuardar
            // 
            this.BTGuardar.Location = new System.Drawing.Point(37, 205);
            this.BTGuardar.Name = "BTGuardar";
            this.BTGuardar.Size = new System.Drawing.Size(75, 23);
            this.BTGuardar.TabIndex = 6;
            this.BTGuardar.Text = "&Guardar";
            this.BTGuardar.UseVisualStyleBackColor = true;
            this.BTGuardar.Click += new System.EventHandler(this.BTGuardar_Click);
            // 
            // BTMostrar
            // 
            this.BTMostrar.Location = new System.Drawing.Point(164, 205);
            this.BTMostrar.Name = "BTMostrar";
            this.BTMostrar.Size = new System.Drawing.Size(75, 23);
            this.BTMostrar.TabIndex = 7;
            this.BTMostrar.Text = "&Mostrar";
            this.BTMostrar.UseVisualStyleBackColor = true;
            this.BTMostrar.Click += new System.EventHandler(this.BTMostrar_Click);
            // 
            // BTCalcSal
            // 
            this.BTCalcSal.Location = new System.Drawing.Point(94, 277);
            this.BTCalcSal.Name = "BTCalcSal";
            this.BTCalcSal.Size = new System.Drawing.Size(145, 23);
            this.BTCalcSal.TabIndex = 8;
            this.BTCalcSal.Text = "&Salario mas grande";
            this.BTCalcSal.UseVisualStyleBackColor = true;
            this.BTCalcSal.Click += new System.EventHandler(this.BTCalcSal_Click);
            // 
            // RTB1
            // 
            this.RTB1.Location = new System.Drawing.Point(288, 26);
            this.RTB1.Name = "RTB1";
            this.RTB1.Size = new System.Drawing.Size(228, 189);
            this.RTB1.TabIndex = 9;
            this.RTB1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 336);
            this.Controls.Add(this.RTB1);
            this.Controls.Add(this.BTCalcSal);
            this.Controls.Add(this.BTMostrar);
            this.Controls.Add(this.BTGuardar);
            this.Controls.Add(this.TBSalario);
            this.Controls.Add(this.CBSexo);
            this.Controls.Add(this.TBNom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBNom;
        private System.Windows.Forms.ComboBox CBSexo;
        private System.Windows.Forms.TextBox TBSalario;
        private System.Windows.Forms.Button BTGuardar;
        private System.Windows.Forms.Button BTMostrar;
        private System.Windows.Forms.Button BTCalcSal;
        private System.Windows.Forms.RichTextBox RTB1;
    }
}

