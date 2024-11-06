//Jeremy Mohan Kalawan ICA 6
using Microsoft.VisualBasic;
using System.CodeDom;
using System.Windows.Forms;

namespace JeremyMProject_4
{
    public partial class Form1 : Form
    {
        private string GameGenre;
        const string RPG = "Role Playing Game (RPG)";
        const string FPS = "First Person Shooter (FPS)";
        const string Racing = "Racing";

        private double rpgDiscount;
        private double fpsDiscount;
        private double racingDiscount;
        private string GameConfig = "GameConfig.txt";

        public double RPGDiscount
        {
            get { return rpgDiscount; }
            set { rpgDiscount = value; }
        }

        public double FPSDiscount
        {
            get { return fpsDiscount; }
            set { fpsDiscount = value; }
        }

        public double RacingDiscount
        {
            get { return racingDiscount;}
            set { racingDiscount = value; }
        }
          
    
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            btnCalc.Focus();

            // Variables
            double GamePrice, totalGamePrice, discountedGamePrice, GameGenreDiscount;
            int GameQuantity;
            bool PriceValid, QuantityValid;
            string GameName;
          

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
                        GameGenreDiscount = RPGDiscount;
                        break;

                    case FPS:
                        GameGenreDiscount = FPSDiscount;
                        break;

                    case Racing:
                        GameGenreDiscount = RacingDiscount;
                        break;

                    default:
                        lstOutput.Items.Add("This should never happen.");
                        break;
                }
                // Processing
                discountedGamePrice = GamePrice - (GamePrice * GameGenreDiscount);
                totalGamePrice = discountedGamePrice * GameQuantity;

                // Output
                lstOutput.Items.Add("GamePrice: " + GamePrice.ToString("C2"));
                lstOutput.Items.Add("Quantity: " + GameQuantity);
                lstOutput.Items.Add("Your discount is " + GameGenreDiscount.ToString("P0"));
                lstOutput.Items.Add("Discounted Game Price: " + discountedGamePrice.ToString("C2"));
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
            StreamReader reader;
            bool valValid;
            bool valNotValid = true;
            double tempValue;
            do
            {
                try
                {
                    reader = File.OpenText(GameConfig);
                    valNotValid = false;
                    valValid = double.TryParse(reader.ReadLine(), out tempValue);
                    RPGDiscount = tempValue;

                    valValid = double.TryParse(reader.ReadLine(), out tempValue);
                    FPSDiscount = tempValue;

                    valValid = double.TryParse(reader.ReadLine(), out tempValue);
                    RacingDiscount = tempValue;

                    reader.Close();
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show("The configuration file was not found. Please select a different file. \n Error message was: " +
                        ex.Message
                        );
                    openFileDialog1.InitialDirectory = Application.StartupPath;
                    openFileDialog1.ShowDialog();
                    GameConfig = openFileDialog1.FileName;
                }
            } while (valNotValid);



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

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
