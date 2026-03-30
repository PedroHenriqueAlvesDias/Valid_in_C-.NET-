namespace WinFormsApp1
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
            btnVerificar = new Button();
            lstVerificar = new ListBox();
            txtPeso = new TextBox();
            txtAltura = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(86, 77);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(117, 31);
            btnVerificar.TabIndex = 0;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // lstVerificar
            // 
            lstVerificar.FormattingEnabled = true;
            lstVerificar.Location = new Point(57, 129);
            lstVerificar.Name = "lstVerificar";
            lstVerificar.Size = new Size(184, 244);
            lstVerificar.TabIndex = 1;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(34, 37);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 23);
            txtPeso.TabIndex = 2;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(167, 37);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 19);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 4;
            label1.Text = "Peso";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(167, 19);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Altura";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAltura);
            Controls.Add(txtPeso);
            Controls.Add(lstVerificar);
            Controls.Add(btnVerificar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVerificar;
        private ListBox lstVerificar;
        private TextBox txtPeso;
        private TextBox txtAltura;
        private Label label1;
        private Label label2;
    }
}
