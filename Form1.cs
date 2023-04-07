using System.Diagnostics.Eventing.Reader;
using System.IO;
namespace Att2
{
    public partial class Form1 : Form
    {
        private Bitmap[] hangImages = {Att2.Properties.Resources.hang0,Att2.Properties.Resources.hang1,Att2.Properties.Resources.hang2,Att2.Properties.Resources.hang3,
                                        Att2.Properties.Resources.hang4,Att2.Properties.Resources.hang5,Att2.Properties.Resources.hang6,Att2.Properties.Resources.hang7};
        private int greseli = 0;
        private string act = "";
        private string desAct = "";
        private string copyAct = "";
        private string[] cuv;
        private string[] det;
        public Form1()
        {
            InitializeComponent();
        }

        private void loadwords()
        {
            string[] citire = File.ReadAllLines("cuv.csv");
            cuv = new string[citire.Length];
            det = new string[citire.Length];
            int i = 0;
            foreach (string s in citire)
            {
                string[] lin = s.Split('.');
                cuv[i] = lin[1];
                det[i++] = lin[2];
            }
        }
        private void setUpWordChoice()
        {
            greseli = 0;
            hangPost.Image = hangImages[greseli];
            int guessInd = (new Random()).Next(cuv.Length);
            act = cuv[guessInd];
            copyAct = "";
            for (int i = 0; i < act.Length; i++)
            {
                copyAct += "_";
            }
            desAct = det[guessInd];
            displayCopy();

        }
        private void displayCopy()
        {
            lblShowWord.Text = "";
            for (int i = 0; i < act.Length; i++)
            {
                lblShowWord.Text += copyAct.Substring(i, 1);
                lblShowWord.Text += " ";
            }
            lblHint.Text = desAct;

        }

        private void GuessClick(object sender, EventArgs e)
        {
            Button choice = sender as Button;
            choice.Enabled = false;
            if (act.Contains(choice.Text))
            {
                char[] temp = copyAct.ToCharArray();
                char[] find = act.ToCharArray();
                char guessChar = choice.Text.ElementAt(0);
                for (int i = 0; i < find.Length; i++)
                {
                    if (find[i] == guessChar)
                    {
                        temp[i] = guessChar;
                    }

                }
                copyAct = new string(temp);
                displayCopy();
            }
            else
            {
                greseli++;
            }
            if (greseli < 7)
            {
                hangPost.Image = hangImages[greseli];
            }
            else
            {
                hangPost.Image = hangImages[greseli];
                labelRez.Text = "You lose!!";
                button1.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = false;
                button2.Enabled = false;
                button23.Enabled = false;
                button25.Enabled = false;
                button26.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button22.Enabled = false;
                CommA.Enabled = false;
            }
            if (copyAct.Equals(act))
            {
                labelRez.Text = "You win!!";
                button1.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = false;
                button2.Enabled = false;
                button23.Enabled = false;
                button25.Enabled = false;
                button26.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button22.Enabled = false;
                CommA.Enabled = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadwords();
            setUpWordChoice();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            CommA.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
            button25.Enabled = true;
            button26.Enabled = true;
            setUpWordChoice();
        }
    }
}