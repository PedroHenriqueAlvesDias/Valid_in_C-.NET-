namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            decimal alt, pes, imc;

            // Limpa lista
            lstVerificar.Items.Clear();

            // Validação altura
            if (!decimal.TryParse(txtAltura.Text, out alt))
            {
                lstVerificar.Items.Add("Altura inválida!");
                return;
            }

            // Validação peso
            if (!decimal.TryParse(txtPeso.Text, out pes))
            {
                lstVerificar.Items.Add("Peso inválido!");
                return;
            }

            // Converter cm para metros (se necessário)
            if (alt > 3)
            {
                alt = alt / 100;
            }

            // Validação de valores absurdos
            if (alt <= 0 || pes <= 0)
            {
                lstVerificar.Items.Add("Valores devem ser maiores que zero!");
                return;
            }

            // Cálculo do IMC
            imc = pes / (alt * alt);

            // Classificação
            string clsf;

            if (imc < 18.5m)
                clsf = "Magreza";
            else if (imc < 25m)
                clsf = "Normal";
            else if (imc < 30m)
                clsf = "Sobrepeso";
            else if (imc < 40m)
                clsf = "Obesidade";
            else
                clsf = "Obesidade grave";

            // Exibição
            lstVerificar.Items.Add("Altura: " + alt.ToString("F2") + " m");
            lstVerificar.Items.Add("Peso: " + pes + " kg");
            lstVerificar.Items.Add("IMC: " + imc.ToString("F2"));
            lstVerificar.Items.Add("Classificação: " + clsf);
        }
    }
}
