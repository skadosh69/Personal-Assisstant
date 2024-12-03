using Binarycalc;
using ChatGPTApp;

namespace Personal_Assisstance_1._3
{
    public partial class Personal_Assisstance : Form
    {
        public Personal_Assisstance()
        {
            InitializeComponent();
            Application.Run(new Binaray_Calculator());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Binaray_Calculator openbinaryconverter2 = Application.OpenForms.OfType<Binaray_Calculator>().FirstOrDefault();

            if (openbinaryconverter2 == null) // If the form is not open
            {
                openbinaryconverter2 = new Binaray_Calculator();
                openbinaryconverter2.Show();
            }
            else
            {
                openbinaryconverter2.BringToFront(); // Bring the form to the front if it is already open
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 openchatgpt = Application.OpenForms.OfType<Form2>().FirstOrDefault();

            if (openchatgpt == null) // If the form is not open
            {
                openchatgpt = new Form2();
                openchatgpt.Show();
            }
            else
            {
                openchatgpt.BringToFront(); // Bring the form to the front if it is already open
            }
        }
    }
}
