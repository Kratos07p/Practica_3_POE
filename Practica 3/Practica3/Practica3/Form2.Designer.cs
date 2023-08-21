namespace Practica3
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
            btnIniciar = new Button();
            tbNum1 = new TextBox();
            tbNum2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.Font = new Font("Arial Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnIniciar.Location = new Point(145, 295);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(241, 67);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // tbNum1
            // 
            tbNum1.Location = new Point(209, 86);
            tbNum1.Name = "tbNum1";
            tbNum1.Size = new Size(100, 23);
            tbNum1.TabIndex = 1;
            tbNum1.TextChanged += tbNum1_TextChanged;
            // 
            // tbNum2
            // 
            tbNum2.Location = new Point(209, 187);
            tbNum2.Name = "tbNum2";
            tbNum2.Size = new Size(100, 23);
            tbNum2.TabIndex = 2;
            tbNum2.TextChanged += tbNum2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlText;
            label1.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(168, 57);
            label1.Name = "label1";
            label1.Size = new Size(185, 26);
            label1.TabIndex = 3;
            label1.Text = "Escriba el Numero 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlText;
            label2.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.CornflowerBlue;
            label2.Location = new Point(168, 158);
            label2.Name = "label2";
            label2.Size = new Size(185, 26);
            label2.TabIndex = 4;
            label2.Text = "Escriba el Numero 2";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbNum2);
            Controls.Add(tbNum1);
            Controls.Add(btnIniciar);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciar;
        private TextBox tbNum1;
        private TextBox tbNum2;
        private Label label1;
        private Label label2;
    }
}