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
            //Declaração das variavéis
            decimal alt, pes, imc;

            // Limpa lista(para nao ficar adicionando infinito)
            lstVerificar.Items.Clear();
            
            //Se NÃO for possível converter o texto de txtAltura para decimal(caso consiga, armazene na variavel alt).
            if (!decimal.TryParse(txtAltura.Text, out alt))
            {
                //então mostre ‘Altura inválida!’ e pare a execução.
                lstVerificar.Items.Add("Altura inválida!");
                return;
            }

            //Se NÃO for possível converter o texto de txtPeso para decimal(caso consiga, armazene na variavel pes).
            if (!decimal.TryParse(txtPeso.Text, out pes))
            {
                //então mostre ‘Peso inválido!’ e pare a execução.
                lstVerificar.Items.Add("Peso inválido!");
                return;
            }

            // Converção: cm para metros (se necessário)
            if (alt > 3)
            {
                alt = alt / 100;
            }

            // Validação de valores irreais
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

            // Exibição dos valores inseridos
            lstVerificar.Items.Add("Altura: " + alt.ToString("F2") + " m");
            lstVerificar.Items.Add("Peso: " + pes + " kg");
            lstVerificar.Items.Add("IMC: " + imc.ToString("F2"));
            lstVerificar.Items.Add("Classificação: " + clsf);
        }
    }
}
