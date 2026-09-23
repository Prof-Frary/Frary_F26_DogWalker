namespace Frary_F26_DogWalker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumPerWeek.Clear();
            txtPetName.Clear();
            lstOut.Items.Clear();
            txtPetName.Focus();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string petName;
            int numPerWeek;
            decimal serviceCost = 20.0m;
            decimal weeklyCost;
            // input
            petName = txtPetName.Text.Trim();
            numPerWeek = int.Parse(txtNumPerWeek.Text);

            weeklyCost = numPerWeek * serviceCost;
            //output results to the list box
            lstOut.Items.Add("Pet Name is " + petName);
            lstOut.Items.Add("Number of Walks per Week is " + numPerWeek.ToString("N0"));
            lstOut.Items.Add("Cost per Serviceis " + serviceCost.ToString("C"));
            lstOut.Items.Add("Total Weekly Cost is " + weeklyCost.ToString("C"));
        }
    }
}
