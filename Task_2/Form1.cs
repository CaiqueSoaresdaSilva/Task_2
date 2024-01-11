using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DateTime dataNasc;
        private DateTime dataFinal;

        private void btnValidaData_Click(object sender, EventArgs e)
        {

            if (ValidaData())
            {
                int meses = ((dataFinal.Year - dataNasc.Year) * 12) + dataFinal.Month - dataNasc.Month;
                int anos = meses / 12;
                if(anos == 1 ) 
                {
                    lblResultado.Text = anos +" Ano";
                }
                else
                {
                    lblResultado.Text = anos + " Anos";
                }
            }
        }

        private bool ValidaData() { 
        
            DateTime data = DateTime.Parse("01/01/2015");
            dataNasc = dtNasc.Value;
            dataFinal = dtFinal.Value;
            
            if (dataNasc >= data || dataNasc >= data)
            {
                MessageBox.Show("Datas acima de 01/01/2015 são invalidas");
                return false;
            }

            return true;

        }
    }
}
