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
            //declarations
          //  string petName;
           // int numPerWeek;
            //decimal serviceCost = 20.0m;
            decimal weeklyCost;

            //create the DogWalker object
           DogWalker dWalker = new DogWalker();

            // input
            dWalker.PetName = txtPetName.Text.Trim();
            dWalker.NumberPerWeek = uint.Parse(txtNumPerWeek.Text);
            weeklyCost = dWalker.CalculateWeeklyCost();

            //weeklyCost = numPerWeek * serviceCost;
            //output results to the list box
            lstOut.Items.Add("Pet name is " + dWalker.PetName);
            lstOut.Items.Add("Number of walks/services per week is " + dWalker.NumberPerWeek.ToString("N0"));
            lstOut.Items.Add("Cost per service is " + dWalker.ServiceCost.ToString("C"));
            lstOut.Items.Add("Total weekly cost is " + weeklyCost.ToString("C"));
        }

        private void txtPetName_Enter(object sender, EventArgs e)
        {
            txtPetName.BackColor = Color.LightYellow;
        }

        private void txtPetName_Leave(object sender, EventArgs e)
        {
            txtPetName.BackColor = SystemColors.Window;
        }

        private void txtNumPerWeek_Enter(object sender, EventArgs e)
        {
            txtNumPerWeek.BackColor = Color.LightYellow;
        }

        private void txtNumPerWeek_Leave(object sender, EventArgs e)
        {
            txtNumPerWeek.BackColor = SystemColors.Window;
        }
    }
}
