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
            DialogResult buttonSelected;
            buttonSelected = MessageBox.Show("Are you sure you want to quit?", "Quitting...",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (buttonSelected == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declarations
            string petName;
            // unsigned int means you can't have negative numbers
            uint numPerWeek;
            decimal serviceCost = 20.0m;
            decimal weeklyCost;
            bool isNumWeekValid;
            bool isPetNameValid = true;
            //input
            petName = txtPetName.Text.Trim();
            if (petName == "")
            {
                isPetNameValid = false;

            }

            // numPerWeek = uint.Parse(txtNumPerWeek.Text);
            //ICA 5
            // convert Parse to TRyParse
            isNumWeekValid = uint.TryParse(txtNumPerWeek.Text, out numPerWeek);
            // Regular Processing - what we have already done
            if (isNumWeekValid && isPetNameValid)
            {

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

                // Demonstrate the ToString and GetType methods
                lstOut.Items.Add("The ToString will give me " + dWalker2.ToString());
                lstOut.Items.Add("The getType will give me " + dWalker2.GetType().ToString());
                // For ICA 3 You only need to implement one of the objects above.  
                // You should, however, implement as least 2 constructors
                // in your calculation class.
            }
            else
            {
                if (!isPetNameValid)
                {
                    lstOut.Items.Add("Please enter a pet name.");
                }
                if (!isNumWeekValid)
                {
                    lstOut.Items.Add("Please enter a non-negative whole number of walks/services per week.");
                }
            }

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
