using System;
using System.Text;  
using System.Collections;  
using System.Windows.Forms;

namespace GuessTheWord
{
    public partial class Form1 : Form
    {
        private string wordToGuess = "BISCUIT";
        private StringBuilder maskedWord;
        private ArrayList wrongGuesses;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            maskedWord = new StringBuilder(wordToGuess.Length);
            for (int i = 0; i < wordToGuess.Length; i++)
            {
                if (i == 0 || i == wordToGuess.Length - 1)
                {
                    maskedWord.Append(wordToGuess[i]);
                }
                else
                {
                    maskedWord.Append('?');
                }
            }


            label2.Text = maskedWord.ToString();


            wrongGuesses = new ArrayList();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userGuess = textBox1.Text.Trim().ToUpper();

            if (string.IsNullOrEmpty(userGuess))
            {
                MessageBox.Show("Please enter a guess!");
                return;
            }

            if (userGuess == wordToGuess) 
            {
                label2.Text = "Correct! The word is: " + wordToGuess;
                label2.Text = wordToGuess.ToUpper();
                MessageBox.Show("You guessed the word!");
            }
            else
            {
                wrongGuesses.Add(userGuess);
                listBox1.Items.Add(userGuess);
                MessageBox.Show("Wrong guess! Try again.");
            }


            textBox1.Clear();
            textBox1.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
