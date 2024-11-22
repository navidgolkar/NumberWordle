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
            txtDigit1.Text = string.Empty;
            txtDigit2.Text = string.Empty;
            txtDigit3.Text = string.Empty;
            txtDigit4.Text = string.Empty;
            txtDigit5.Text = string.Empty;
            txtDigit1.Focus();
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
            var feedback = GetFeedback(userGuess);
            //lstResults.Items.Add((feedback, attempts));
            lstResults.Items.Add(new Tuple<List<(char, Color)>, int>(feedback, attempts));
            // Check for win
            if (userGuess == secretNumber)
            {
                lblFeedback.Text = $"Congratulations! You guessed the number in {attempts} attempts.";
                DisableInput();
            }
            else
            {

            }
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            txtDigit1.Enabled = true;
            txtDigit2.Enabled = true;
            txtDigit3.Enabled = true;
            txtDigit4.Enabled = true;
            txtDigit5.Enabled = true;
            btnSubmit.Enabled = true;
            StartNewGame();
        }
        private void DisableInput()
        {
            txtDigit1.Enabled = false;
            txtDigit2.Enabled = false;
            txtDigit3.Enabled = false;
            txtDigit4.Enabled = false;
            txtDigit5.Enabled = false;
            btnSubmit.Enabled = false;
        }
        private List<(char, Color)> GetFeedback(string guess)
        {
            List<(char, Color)> feedback = new List<(char, Color)>();
            bool[] used = new bool[5];
            // Mark correct (green) digits
            for (int i = 0; i < 5; i++)
            {
                if (guess[i] == secretNumber[i])
                {
                    feedback.Add((guess[i], Color.Green)); // Green
                    used[i] = true;
                }
                else
                {
                    feedback.Add((guess[i], Color.Red)); // Default to Red, will update later if Yellow
                }
            }
            // Mark misplaced (yellow) digits
            for (int i = 0; i < 5; i++)
            {
                if (feedback[i].Item2 == Color.Green) continue;
                bool found = false;
                for (int j = 0; j < 5; j++)
                {
                    if (!used[j] && guess[i] == secretNumber[j])
                    {
                        feedback[i] = (guess[i], Color.Yellow); // Update to Yellow
                        used[j] = true;
                        found = true;
                        break;
                    }
                }
            }
            return feedback;
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
        private void lstResults_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.Graphics.FillRectangle(new SolidBrush(Color.Silver), e.Bounds);
            if (e.Index >= 0)
            {
                var item = (Tuple<List<(char, Color)>, int>)lstResults.Items[e.Index];
                var feedback = item.Item1;
                int attemptNumber = item.Item2;
                int x = e.Bounds.X;
                // Draw the feedback with colored digits
                foreach (var (digit, color) in feedback)
                {
                    using (Brush brush = new SolidBrush(color))
                    {
                        e.Graphics.DrawString(digit.ToString(), e.Font, brush, x, e.Bounds.Y);
                    }
                    // Move x to the right for the next digit
                    x += 20; // Adjust spacing as needed
                }
                // Draw the attempt number in black (default color)
                using (Brush brush = new SolidBrush(Color.Black))
                {
                    string attemptText = $"  (Attempt {attemptNumber})";
                    e.Graphics.DrawString(attemptText, e.Font, brush, x, e.Bounds.Y);
                }
            }
            e.DrawFocusRectangle();
        }
    }
}
