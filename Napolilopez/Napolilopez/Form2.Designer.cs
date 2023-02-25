namespace Napolilopez
{
    partial class Form2
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
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Nombreprecio = new System.Windows.Forms.TextBox();
            this.PreciotTextBox = new System.Windows.Forms.TextBox();
            this.CantidadTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(190, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(226, 73);
            this.button2.TabIndex = 0;
            this.button2.Text = "CALCULAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "PRECIO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "CANTIDAD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "NOMBRE DEL PRODUCTO";
            // 
            // Nombreprecio
            // 
            this.Nombreprecio.Location = new System.Drawing.Point(281, 54);
            this.Nombreprecio.Name = "Nombreprecio";
            this.Nombreprecio.Size = new System.Drawing.Size(100, 22);
            this.Nombreprecio.TabIndex = 4;
            // 
            // PreciotTextBox
            // 
            this.PreciotTextBox.Location = new System.Drawing.Point(281, 113);
            this.PreciotTextBox.Name = "PreciotTextBox";
            this.PreciotTextBox.Size = new System.Drawing.Size(100, 22);
            this.PreciotTextBox.TabIndex = 5;
            // 
            // CantidadTextBox
            // 
            this.CantidadTextBox.Location = new System.Drawing.Point(281, 176);
            this.CantidadTextBox.Name = "CantidadTextBox";
            this.CantidadTextBox.Size = new System.Drawing.Size(100, 22);
            this.CantidadTextBox.TabIndex = 6;
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(617, 459);
            this.Controls.Add(this.CantidadTextBox);
            this.Controls.Add(this.PreciotTextBox);
            this.Controls.Add(this.Nombreprecio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.HelpButton = true;
            this.Name = "Form2";
            this.Text = "EJERCICIO2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Nombreprecio;
        private System.Windows.Forms.TextBox PreciotTextBox;
        private System.Windows.Forms.TextBox CantidadTextBox;
    }
}