//Jeremy Mohan Kalawan ICA 5
using System.CodeDom;

namespace JeremyMProject_4
{
    public partial class Form1 : Form
    {
        private string GameGenre;
        const string RPG = "Role Playing Game (RPG)";
        const string FPS = "First Person Shooter (FPS)";
        const string Racing = "Racing";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            btnCalc.Focus();

            // Variables
            double GamePrice, totalGamePrice;
            int GameQuantity;
            bool PriceValid, QuantityValid;
            string GameName;
            double GameGenreDiscount = 0;

            // Input & Parsing
            // GamePrice = double.Parse(txtPrice.Text);
            // GameQuantity = int.Parse(txtQuantity.Text);
            GameName = txtGameName.Text;
            PriceValid = double.TryParse(txtPrice.Text, out GamePrice);
            QuantityValid = int.TryParse(txtQuantity.Text, out GameQuantity);
            if (PriceValid && QuantityValid)
            {
                // Switch
                switch (GameGenre)
                {
                    case RPG:
                        GameGenreDiscount = 0.25;
                        break;

                    case FPS:
                        GameGenreDiscount = 0.50;
                        break;
                    
                    case Racing:
                        GameGenreDiscount = 0.75;
                        break;

                    default:
                        lstOutput.Items.Add("This should never happen.");
                        break;
                }
                // Processing
                totalGamePrice = (GamePrice * GameGenreDiscount) * GameQuantity;

                // Output
                lstOutput.Items.Add("Your discount is " + GameGenreDiscount.ToString("P0"));
                lstOutput.Items.Add("The total price for " + GameName + " is " + totalGamePrice.ToString("C2"));
            }
            
            else
            {
                if (!PriceValid)
                    lstOutput.Items.Add("Please enter a numeric number for the price.");
                if (!QuantityValid)
                    lstOutput.Items.Add("Please enter a whole number for the quantity.");
            }

        }

        private void txtGame_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGameName.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            lstOutput.Items.Clear();
            txtGameName.Focus();
            txtPrice.Focus();
            txtQuantity.Focus();
            lstOutput.Items.Clear();
            radioButton1.Checked = true;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            // Brings up a pop up box when you click quit.
            DialogResult ButtonSelected;
            ButtonSelected = MessageBox.Show(
                "Do you really want to quit this program?", "Exiting Distributor...",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (ButtonSelected == DialogResult.Yes)
            {
                // Closes the program.
                this.Close();
            }

        }

        private void lstOutput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_Enter(object sender, EventArgs e)
        {
            txtPrice.BackColor = Color.White;
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            txtPrice.BackColor = Color.White;
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGameName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void RPG_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                GameGenre = RPG;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                GameGenre = FPS;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                GameGenre = Racing;
            }
        }
    }
}
