using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ScatterSlotSimulator
{
    public partial class Form1 : Form
    {

        Random random = new Random();
        int balance = 100;
        int developerBalance = 0;

        string[] slotImages = {
            @"C:\Users\Lana de Guzman\Desktop\Integrative Programming\Laboratory Exercise\05\ScatterSlotSimulator\ScatterSlotSimulator\Images\daisy.png",
            @"C:\Users\Lana de Guzman\Desktop\Integrative Programming\Laboratory Exercise\05\ScatterSlotSimulator\ScatterSlotSimulator\Images\rose.png",
            @"C:\Users\Lana de Guzman\Desktop\Integrative Programming\Laboratory Exercise\05\ScatterSlotSimulator\ScatterSlotSimulator\Images\tulip.png",
            @"C:\Users\Lana de Guzman\Desktop\Integrative Programming\Laboratory Exercise\05\ScatterSlotSimulator\ScatterSlotSimulator\Images\lotus.png",
        };

        public Form1()
        {
            InitializeComponent();
            balanceText.Text = "Balance: " + balance;
        }

        private void spinButton_Click(object sender, EventArgs e)
        {
            if (balance < 10)
            {
                resultText.Text = "Not enough money!";
                return;
            }

            balance -= 10;

            int spin1 = random.Next(slotImages.Length);
            int spin2 = random.Next(slotImages.Length);
            int spin3 = random.Next(slotImages.Length);

            pictureBox1.Image = Image.FromFile(slotImages[spin1]);
            pictureBox2.Image = Image.FromFile(slotImages[spin2]);
            pictureBox3.Image = Image.FromFile(slotImages[spin3]);

            if (spin1 == spin2 && spin2 == spin3)
            {
                balance += 20;
                developerBalance -= 20;
                resultText.Text = "You won 30 coins!";
            }
            else if (spin1 == spin2 || spin2 == spin3 || spin1 == spin3)
            {
                balance += 5;
                developerBalance -= 5;
                resultText.Text = "You won 10 coins!";
            }
            else
            {
                balance -= 20;
                developerBalance += 20;
                resultText.Text = "You lost!";
            }

            balanceText.Text = "Balance: " + balance;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            balance = 100;
            balanceText.Text = "Balance: " + balance;
            resultText.Text = "";

            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developer's balance: " + developerBalance);
            Application.Exit();
        }
    }
}
