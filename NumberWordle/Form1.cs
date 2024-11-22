namespace NumberWordle
{
    public partial class Form1 : Form
    {
        private string secretNumber;
        private int attempts;
        public Form1()
        {
            InitializeComponent();

            // Attach KeyPress event handler to all digit TextBoxes
            txtDigit1.KeyPress += txtDigit_KeyPress;
            txtDigit2.KeyPress += txtDigit_KeyPress;
            txtDigit3.KeyPress += txtDigit_KeyPress;
            txtDigit4.KeyPress += txtDigit_KeyPress;
            txtDigit5.KeyPress += txtDigit_KeyPress;
            StartNewGame();
        }

        private void StartNewGame()
        {
            // Generate a random 5-digit number
            Random rand = new Random();
            secretNumber = rand.Next(10000, 100000).ToString();
            attempts = 0;

            // Reset UI
            lstResults.Items.Clear();
            lblFeedback.Text = "Guess the 5-digit number!";
            txtDigit1.Text = string.Empty;
            txtDigit2.Text = string.Empty;
            txtDigit3.Text = string.Empty;
            txtDigit4.Text = string.Empty;
            txtDigit5.Text = string.Empty;
            txtDigit1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string userGuess = txtDigit1.Text + txtDigit2.Text + txtDigit3.Text + txtDigit4.Text + txtDigit5.Text;

            // Validate input
            if (userGuess.Length != 5 || !userGuess.All(char.IsDigit))
            {
                lblFeedback.Text = "Enter a valid 5-digit number.";
                return;
            }
            attempts++;

            string feedback = GetFeedback(userGuess);
            lstResults.Items.Add($"Attempt {attempts}: {userGuess} - {feedback}");

            // Check for win
            if (userGuess == secretNumber)
            {
                lblFeedback.Text = $"Congratulations! You guessed the number in {attempts} attempts.";
                DisableInput();
            }
            else
            {
                lblFeedback.Text = "Try again!";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            txtDigit1.Enabled = txtDigit2.Enabled = txtDigit3.Enabled = txtDigit4.Enabled = txtDigit5.Enabled = true;
            btnSubmit.Enabled = true;
            StartNewGame();
        }
        private void DisableInput()
        {
            txtDigit1.Enabled = txtDigit2.Enabled = txtDigit3.Enabled = txtDigit4.Enabled = txtDigit5.Enabled = false;
            btnSubmit.Enabled = false;
        }
        private string GetFeedback(string guess)
        {
            char[] feedback = new char[5];
            bool[] used = new bool[5]; // Tracks used digits in the secret number

            // Mark correct (green) digits
            for (int i = 0; i < 5; i++)
            {
                if (guess[i] == secretNumber[i])
                {
                    feedback[i] = 'G'; // Green
                    used[i] = true;
                }
            }

            // Mark misplaced (yellow) and incorrect (red) digits
            for (int i = 0; i < 5; i++)
            {
                if (feedback[i] == 'G') continue;

                bool found = false;
                for (int j = 0; j < 5; j++)
                {
                    if (!used[j] && guess[i] == secretNumber[j])
                    {
                        feedback[i] = 'Y'; // Yellow
                        used[j] = true;
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    feedback[i] = 'R'; // Red
                }
            }

            return string.Join("", feedback);
        }
        private void txtDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox currentTextBox = sender as TextBox;

            if (char.IsDigit(e.KeyChar) && currentTextBox.Text.Length == 0)
            {
                e.Handled = false;
                // Move to the next textbox
                this.SelectNextControl(ActiveControl, true, true, true, true);
            }
            // Only allow digits 0-9 and control keys
            else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
