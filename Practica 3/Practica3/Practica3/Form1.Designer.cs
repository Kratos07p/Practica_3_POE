namespace Practica3
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
            tbNum = new TextBox();
            tbLetraOCaracter = new TextBox();
            validación = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(48, 26);
            label1.Name = "label1";
            label1.Size = new Size(209, 24);
            label1.TabIndex = 0;
            label1.Text = "Escriba un numero:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(12, 116);
            label2.Name = "label2";
            label2.Size = new Size(295, 24);
            label2.TabIndex = 1;
            label2.Text = "Escriba una letra o caracter:";
            // 
            // tbNum
            // 
            tbNum.BackColor = Color.FromArgb(192, 0, 192);
            tbNum.Location = new Point(48, 68);
            tbNum.Multiline = true;
            tbNum.Name = "tbNum";
            tbNum.Size = new Size(209, 23);
            tbNum.TabIndex = 2;
            // 
            // tbLetraOCaracter
            // 
            tbLetraOCaracter.BackColor = Color.FromArgb(192, 0, 192);
            tbLetraOCaracter.Location = new Point(48, 159);
            tbLetraOCaracter.Multiline = true;
            tbLetraOCaracter.Name = "tbLetraOCaracter";
            tbLetraOCaracter.Size = new Size(209, 23);
            tbLetraOCaracter.TabIndex = 3;
            // 
            // validación
            // 
            validación.BackColor = Color.FromArgb(0, 192, 0);
            validación.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            validación.Location = new Point(48, 215);
            validación.Name = "validación";
            validación.Size = new Size(190, 30);
            validación.TabIndex = 4;
            validación.Text = "Validar";
            validación.UseVisualStyleBackColor = false;
            validación.Click += validación_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(334, 450);
            Controls.Add(validación);
            Controls.Add(tbLetraOCaracter);
            Controls.Add(tbNum);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbNum;
        private TextBox tbLetraOCaracter;
        private Button validación;
    }
}