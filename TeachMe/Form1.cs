using System;
using System.Drawing;
using System.Windows.Forms;

namespace TeachMe
{
    public partial class TeachMe : Form
    {
        private XL xl;
        const string XLFile = "TeachMe.xls";
        const string GuessText = "Please Enter Your Guess";
        string[,] listForTest;
        int indexer = 0;
        public TeachMe()
        {
            InitializeComponent();
            // max/min size allowed for form to ensure adjustment of the window
            MaximumSize = Size;
            MinimumSize = Size;

            // greyed out text for guessing textbox
            TextGuess.Leave += new EventHandler(TextGuess_Leave);
            TextGuess.Enter += new EventHandler(TextGuess_Enter);
            TextWordGuess.Leave += TextWordGuess_Leave;
            TextWordGuess.Enter += TextWordGuess_Enter;
            TextGuess.Text = GuessText;
            TextGuess.ForeColor = Color.LightGray;

            // initialize excel
            xl = new XL(XLFile);
        }

        private void TextWordGuess_Enter(object sender, EventArgs e)
        {
            if (TextWordGuess.Text == GuessText)
            {
                TextWordGuess.Text = string.Empty;
                TextWordGuess.ForeColor = Color.Black;
            }
        }

        void TextWordGuess_Leave(object sender, EventArgs e)
        {
            if (TextWordGuess.Text.Length == 0)
            {
                TextWordGuess.Text = GuessText;
                TextWordGuess.ForeColor = Color.LightGray;
            }
        }

        private void TextGuess_Leave(object sender, EventArgs e)
        {
            if (TextGuess.Text.Length == 0)
            {
                TextGuess.Text = GuessText;
                TextGuess.ForeColor = Color.LightGray;
            }
        }

        private void TextGuess_Enter(object sender, EventArgs e)
        {
            if (TextGuess.Text == GuessText)
            {
                TextGuess.Text = string.Empty;
                TextGuess.ForeColor = Color.Black;
            }
        }

        private void ButtonInsert_Click(object sender, EventArgs e)
        {
            xl.AddWord(TextWordToInsert.Text, TextDefToInsert.Text);
            TextDefToInsert.Text = string.Empty;
            TextWordToInsert.Text = string.Empty;
            MessageBox.Show("Successfully added the new word!");
            TextWordToInsert.Focus();
        }

        private void ButtonStartTest_Click(object sender, EventArgs e)
        {
            if (TextDefTest.Text == string.Empty)
            {
                TextDefinition.Text = string.Empty;
                TextGuess.Text = string.Empty;
                TextGuess.Text = GuessText;
                TextGuess.ForeColor = Color.LightGray;
                indexer = 0;
                listForTest = xl.GetListForTest((int)NumericNumOfWords.Value);
                ScrambleList();
                LabelTotalWordsLeft.Text = ((listForTest.Length / 2) - 1).ToString();
                LabelWord.Text = listForTest[indexer, 0];
            }
            else
            {
                MessageBox.Show("Please end the test in the \"Test2\" Tab first.");
            }
        }
        private void CopyDimensionalArr(string[,] original, string[,] result)
        {
            int elements = (original.Length / 2);
            for (int i = 0; i < elements; i++)
            {
                result[i, 0] = original[i, 0];
                result[i, 1] = original[i, 1];
            }
        }
        private void ScrambleList()
        {
            int amountForRandom = (listForTest.Length / 2);
            string[,] holder = new string[amountForRandom, 2];
            CopyDimensionalArr(listForTest, holder);
            Random random = new Random();
            int index = 0;
            int randomNum = 0;
            
            if (amountForRandom < 2)
	        {
		        MessageBox.Show("Not enough elements for random");
	        }
            else
	        {
                while (amountForRandom != 0)
                {
                    randomNum = random.Next(0, amountForRandom);
                    listForTest[index, 0] = holder[randomNum, 0];
                    listForTest[index, 1] = holder[randomNum, 1];
                    holder[randomNum, 0] = holder[amountForRandom - 1, 0];
                    holder[randomNum, 1] = holder[amountForRandom - 1, 1];
                    index++;
                    amountForRandom--;
                }

	        }
        }

        private void ButtonReveal_Click(object sender, EventArgs e)
        {
            if (LabelWord.Text != "*WORD*")
            {
                if (indexer < (listForTest.Length / 2))
                {
                    TextDefinition.Text = listForTest[indexer, 1];
                    ButtonNext.Focus();
                }
                else
                {
                    indexer = 0;
                }
            }
            else
            {
                MessageBox.Show("Please start a test first!");

            }
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            if (LabelWord.Text != "*WORD*")
            {
                TextDefinition.Text = string.Empty;
                TextGuess.Text = string.Empty;
                TextGuess.Text = GuessText;
                TextGuess.ForeColor = Color.LightGray;
                indexer++;
                if (indexer < (listForTest.Length / 2))
                {
                    LabelWord.Text = listForTest[indexer, 0];
                    int value = (Convert.ToInt32(LabelTotalWordsLeft.Text)) - 1;
                    LabelTotalWordsLeft.Text = (value).ToString();
                    TextGuess.Focus();
                }
                else
                {
                    MessageBox.Show("No words left for the test.");
                    LabelWord.Text = "*WORD*";
                    indexer = 0;
                    ButtonStartTest.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please start a test first!");
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (LabelWord.Text != "*WORD*")
            {
                xl.DeleteWord(LabelWord.Text);
                MessageBox.Show("This word has been deleted.");
                ButtonNext.PerformClick();
            }
            else
            {
                MessageBox.Show("Please start a test first!");
            }
        }

        private void ButtonStartRevertTest_Click(object sender, EventArgs e)
        {
            if (LabelWord.Text == "*WORD*")
            {
                TextAnswerWord.Text = string.Empty;
                TextWordGuess.Text = string.Empty;
                TextWordGuess.Text = GuessText;
                TextWordGuess.ForeColor = Color.LightGray;
                indexer = 0;
                listForTest = xl.GetListForRevertTest((int)NumericRevertNumOfWords.Value);
                ScrambleList();
                TotalWordsLeftDef.Text = ((listForTest.Length / 2) - 1).ToString();
                TextDefTest.Text = listForTest[indexer, 0];
            }
            else
            {
                MessageBox.Show("Please end the test in the \"Test\" Tab first.");
            }
        }

        private void ButtonRevealWord_Click(object sender, EventArgs e)
        {
            if (TextDefTest.Text != string.Empty)
            {
                if (indexer < (listForTest.Length / 2))
                {
                    TextAnswerWord.Text = listForTest[indexer, 1];
                    ButtonNextDef.Focus();
                }
                else
                {
                    indexer = 0;
                }
            }
            else
            {
                MessageBox.Show("Please start a test first!");
            }
        }

        private void ButtonNextDef_Click(object sender, EventArgs e)
        {
            if (TextDefTest.Text != string.Empty)
            {
                TextAnswerWord.Text = string.Empty;
                TextWordGuess.Text = string.Empty;
                TextWordGuess.Text = GuessText;
                TextWordGuess.ForeColor = Color.LightGray;
                indexer++;
                if (indexer < (listForTest.Length / 2))
                {
                    TextDefTest.Text = listForTest[indexer, 0];
                    int value = (Convert.ToInt32(TotalWordsLeftDef.Text)) - 1;
                    TotalWordsLeftDef.Text = (value).ToString();
                    TextWordGuess.Focus();
                }
                else
                {
                    MessageBox.Show("No words left for the test.");
                    TextDefTest.Text = string.Empty;
                    indexer = 0;
                    ButtonStartRevertTest.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please start a test first!");
            }
        }

        private void ButtonDeleteWord_Click(object sender, EventArgs e)
        {
            if (TextDefTest.Text != string.Empty)
            {
                xl.DeleteWord(listForTest[indexer, 1]);
                MessageBox.Show("This word has been deleted.");
                ButtonNextDef.PerformClick();
            }
            else
            {
                MessageBox.Show("Please start a test first!");
            }
        }

        private void TeachMe_FormClosing(object sender, FormClosingEventArgs e)
        {
            xl.ReleaseObjects();
        }
    }
}
