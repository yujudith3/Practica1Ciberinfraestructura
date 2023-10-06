namespace formularioJN
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
            label1 = new Label();
            label2 = new Label();
            txtcontrasenauno = new TextBox();
            txtcontrasenados = new TextBox();
            btnvalidar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(44, 45);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingresa contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(31, 86);
            label2.Name = "label2";
            label2.Size = new Size(164, 20);
            label2.TabIndex = 1;
            label2.Text = "Confirma contraseña";
            // 
            // txtcontrasenauno
            // 
            txtcontrasenauno.BackColor = SystemColors.ScrollBar;
            txtcontrasenauno.Location = new Point(208, 42);
            txtcontrasenauno.Name = "txtcontrasenauno";
            txtcontrasenauno.Size = new Size(125, 27);
            txtcontrasenauno.TabIndex = 2;
            // 
            // txtcontrasenados
            // 
            txtcontrasenados.BackColor = SystemColors.ScrollBar;
            txtcontrasenados.Location = new Point(208, 79);
            txtcontrasenados.Name = "txtcontrasenados";
            txtcontrasenados.Size = new Size(125, 27);
            txtcontrasenados.TabIndex = 3;
            // 
            // btnvalidar
            // 
            btnvalidar.BackColor = SystemColors.GrayText;
            btnvalidar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnvalidar.ForeColor = SystemColors.Control;
            btnvalidar.Location = new Point(239, 125);
            btnvalidar.Name = "btnvalidar";
            btnvalidar.Size = new Size(94, 29);
            btnvalidar.TabIndex = 4;
            btnvalidar.Text = "validar";
            btnvalidar.UseVisualStyleBackColor = false;
            btnvalidar.Click += btnvalidar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(395, 210);
            Controls.Add(btnvalidar);
            Controls.Add(txtcontrasenados);
            Controls.Add(txtcontrasenauno);
            Controls.Add(label2);
            Controls.Add(label1);
            Cursor = Cursors.Hand;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtcontrasenauno;
        private TextBox txtcontrasenados;
        private Button btnvalidar;
    }
}