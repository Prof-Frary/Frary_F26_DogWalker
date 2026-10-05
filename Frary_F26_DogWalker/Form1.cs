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
              string petName;
            // unsigned int means you can't have negative numbers
              uint numPerWeek;
            decimal serviceCost = 20.0m;
            decimal weeklyCost;
            //input
            petName = txtPetName.Text.Trim();
            numPerWeek = uint.Parse(txtNumPerWeek.Text);

            // Two ways to create an object of the DogWalker class
            // 1. Using the constructor without parameters
            // You will need to sett all necessary properties before calling the
            // CalculateWeeklyCost method 

            DogWalker dWalker1 = new DogWalker();
            dWalker1.PetName = petName;
            dWalker1.NumberPerWeek = numPerWeek;
            dWalker1.ServiceCost = serviceCost;
            dWalker1.CalculateWeeklyCost();

            //2. Using the constructor with parameters
            DogWalker dWalker2 = new DogWalker(petName, numPerWeek, serviceCost);

            //weeklyCost = numPerWeek * serviceCost;
            //output results to the list box
            lstOut.Items.Add("Pet name is " + dWalker2.PetName);
            lstOut.Items.Add("Number of walks/services per week is " + dWalker2.NumberPerWeek.ToString("N0"));
            lstOut.Items.Add("Cost per service is " + dWalker2.ServiceCost.ToString("C"));
            lstOut.Items.Add("Total weekly cost is " + dWalker2.WeeklyCost.ToString("C"));
        
            // For ICA 3 You only need to implement one of the objects above.  
            // You should, however, implement as least 2 constructors
            // in your calculation class.

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
