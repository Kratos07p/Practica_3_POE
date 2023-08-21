namespace Practica3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void validación_Click(object sender, EventArgs e)
        {
            string numero = tbNum.Text;
            string letra = tbLetraOCaracter.Text;

            if (string.IsNullOrEmpty(letra) || string.IsNullOrWhiteSpace(letra))
            {
                MessageBox.Show("Escribe un texto");
            }
            else
            {
                MessageBox.Show("Waos, Si es un texto valido!!");
            }

            if (int.TryParse(numero, out int n))
            {
                MessageBox.Show("Es un numero!!");
            }
            else
            {
                MessageBox.Show("No es un numero, escriba bien pendejo");
            }
        }
    }
}