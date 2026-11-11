namespace Frary_F26_DogWalker
{

    //next steps - make service cost properties
    //change hardcoded service costs in case statement based on properties
    // move case statement to own method that just sets service cost based on service type

    public partial class Form1 : Form
    {
        private string petServiceTransOutput = "TranactionOutput.txt";
        private string petServiceCFG   = "PetServicesCFG1.txt";
        private string serviceType;
        private const int LISTBOX = 1;
        private const int FILE = 2;
        private const int BOTH = 3;
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
            // uint is an unsigned int this means you
            // can't have negative numbers
            uint numPerWeek;
            decimal serviceCost = 20.0m;
            bool isNumWeekValid;
            bool isPetNameValid = true;
            StreamWriter sw;

            //input
            petName = txtPetName.Text.Trim();
            if (petName == "")
            {
                isPetNameValid = false;

            }
            // ************** name code *********************
            // you don't have to add this code but if you do you will have to change your properties
            // from name ( customer name, emplyee name ) to lastname and first name
            // here I will not do that part just give you the code to create both parts of the name
            string lastName, firstName;
            // finds the position of the space in the name
            int posOfSpace = petName.IndexOf(" ");
            if (posOfSpace > 0) // if there is a first and last name
            {
                firstName = petName.Substring(0, posOfSpace);
                lastName = petName.Substring(posOfSpace + 1).Trim();
            }
            else // if there is no last name
            {
                firstName = petName;
                lastName = "";
            }
            // you could also check if lastname is first, then you could check for a comma before you check for the space
            // then switch the code for lastname and first name

            //******** end of name code ***************

            // numPerWeek = uint.Parse(txtNumPerWeek.Text);
            //ICA 5
            // convert Parse to TRyParse
            isNumWeekValid = uint.TryParse(txtNumPerWeek.Text, out numPerWeek);
            // Regular Processing - what we have already done
            if (isNumWeekValid && isPetNameValid)
            {
                // Calculation is done in the class
                DogWalker dWalker2 = new DogWalker(petName, numPerWeek, serviceType);

                // output 
                outputMsg("************** Transaction Output at " + DateTime.Now.ToString("G") + " ****************",FILE);
                outputMsg(dWalker2.ToString(), BOTH);             
               
            }
            else
            {
                if (!isPetNameValid)
                {
                    outputMsg("Please enter a pet name.", LISTBOX);
                }
                if (!isNumWeekValid)
                {
                    outputMsg("Please enter a non-negative whole number of walks/services per week.", LISTBOX);
                }
            }

        }
        
        private void outputMsg (string msg, int type)
        {
            StreamWriter sw;
            if (type == FILE || type == BOTH)
            {
                sw = File.AppendText(petServiceTransOutput);
                sw.WriteLine(msg);
                sw.Close();
            }
            if (type == LISTBOX || type == BOTH)
            {
                // this allows the code to use the tostring output without multiple calls to ope the file
                string[] lines = msg.Split('\n');
                for (int i = 0; i < lines.Length; i++)
                {
                    lstOut.Items.Add(lines[i]);
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

        private void Form1_Load(object sender, EventArgs e)
        {
            rdoDogWalk.Checked = true;
            StreamReader sr;
            bool fileExists = false;
            int numTries = 0;
            const int MAX_TRIES = 3;
            do // post Test loop
            {
                try // try catch block to handle file not found exception
                {
                    numTries++;
                    sr = File.OpenText(petServiceCFG);
                    // if file exists the rest of this code runs 
                    fileExists = true;
                    string temp = sr.ReadLine();
                    DogWalker.WalkServiceCost = decimal.Parse(temp);
                    temp = sr.ReadLine();
                    DogWalker.ParkServiceCost = decimal.Parse(temp);
                    temp = sr.ReadLine();
                    DogWalker.SittingServiceCost = decimal.Parse(temp);
                    sr.Close();
                }
                catch (FileNotFoundException ex)
                {
                    // If the user tries to open the file more than a certain amount assume
                    // the file doesn't exist and populate the values with hardcoded values 
                    if (numTries <= MAX_TRIES) {
                        // need the message box otherwise the user might be confused why they are getting the 
                        // OPenFile Dialog box
                        MessageBox.Show("The configuration file " + petServiceCFG + " was not found. Please select the file. \n The message was " + ex.Message,
                            "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
                        openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                        openFileDialog1.ShowDialog();
                        petServiceCFG = openFileDialog1.FileName;
                    } else
                    {
                        DogWalker.WalkServiceCost = 25.0m;
                        DogWalker.ParkServiceCost = 30.0m;
                        DogWalker.SittingServiceCost = 35.0m;
                        fileExists = true;
                    }

                }
            } while (!fileExists);

        }

        private void rdoDogWalk_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDogWalk.Checked)
            {
                serviceType = DogWalker.DOG_WALK_TYPE;
            }
        }

        private void rdoDogPark_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDogPark.Checked)
            {
                serviceType = DogWalker.DOG_PARK_TYPE; ;
            }
        }

        private void rdoPetSitting_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoPetSitting.Checked)
            {
                serviceType = DogWalker.PET_SITTING_TYPE;
            }
        }
    }
}
