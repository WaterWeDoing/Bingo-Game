using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BingoGame
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        TimeSpan seconds = new TimeSpan();

        private List<int> Bnumbs = new List<int>();
        private List<int> Inumbs = new List<int>();
        private List<int> Nnumbs = new List<int>();
        private List<int> Gnumbs = new List<int>();
        private List<int> Onumbs = new List<int>();

        Stack<int> selectedNumbers = new Stack<int>();
        List<string> calledNumbers = new List<string>();


        int _timesClicked = 0;


        public Form1()
        {
            InitializeComponent();
        }

        public void BColNumberLoader()
        {
            for (int i = 0; i < 5; i++)
            {
                int num = random.Next(1, 15);

                if (Bnumbs.Contains(num))
                {
                    i--;
                }
                else
                {
                    Bnumbs.Add(num);
                }


            }

            b1.Text = Bnumbs[0].ToString();
            b2.Text = Bnumbs[1].ToString();
            b3.Text = Bnumbs[2].ToString();
            b4.Text = Bnumbs[3].ToString();
            b5.Text = Bnumbs[4].ToString();

        }

        public void IColNumberLoader()
        {
            for (int i = 0; i < 5; i++)
            {
                int num = random.Next(16, 30);

                if (Inumbs.Contains(num))
                {
                    i--;
                }
                else
                {
                    Inumbs.Add(num);
                }


            }

            i1.Text = Inumbs[0].ToString();
            i2.Text = Inumbs[1].ToString();
            i3.Text = Inumbs[2].ToString();
            i4.Text = Inumbs[3].ToString();
            i5.Text = Inumbs[4].ToString();

        }

        public void NColNumberLoader()
        {
            for (int i = 0; i < 4; i++)
            {
                int num = random.Next(31, 45);

                if (Nnumbs.Contains(num))
                {
                    i--;
                }
                else
                {
                    Nnumbs.Add(num);
                }


            }

            n1.Text = Nnumbs[0].ToString();
            n2.Text = Nnumbs[1].ToString();
            n4.Text = Nnumbs[2].ToString();
            n5.Text = Nnumbs[3].ToString();

        }

        public void GColNumberLoader()
        {
            for (int i = 0; i < 5; i++)
            {
                int num = random.Next(46, 60);

                if (Gnumbs.Contains(num))
                {
                    i--;
                }
                else
                {
                    Gnumbs.Add(num);
                }


            }

            g1.Text = Gnumbs[0].ToString();
            g2.Text = Gnumbs[1].ToString();
            g3.Text = Gnumbs[2].ToString();
            g4.Text = Gnumbs[3].ToString();
            g5.Text = Gnumbs[4].ToString();

        }

        public void OColNumberLoader()
        {
            for (int i = 0; i < 5; i++)
            {
                int num = random.Next(61, 75);

                if (Onumbs.Contains(num))
                {
                    i--;
                }
                else
                {
                    Onumbs.Add(num);
                }


            }

            o1.Text = Onumbs[0].ToString();
            o2.Text = Onumbs[1].ToString();
            o3.Text = Onumbs[2].ToString();
            o4.Text = Onumbs[3].ToString();
            o5.Text = Onumbs[4].ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (b1.BackColor == Color.SlateGray)
            {
                b1.BackColor = Color.White;
            }
            else if (b1.BackColor == Color.White)
            {
                b1.BackColor = Color.SlateGray;
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (b2.BackColor == Color.SlateGray)
            {
                b2.BackColor = Color.White;
            }
            else if (b2.BackColor == Color.White)
            {
                b2.BackColor = Color.SlateGray;
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (b3.BackColor == Color.SlateGray)
            {
                b3.BackColor = Color.White;
            }
            else if (b3.BackColor == Color.White)
            {
                b3.BackColor = Color.SlateGray;
            }
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (b4.BackColor == Color.SlateGray)
            {
                b4.BackColor = Color.White;
            }
            else if (b4.BackColor == Color.White)
            {
                b4.BackColor = Color.SlateGray;
            }
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (b5.BackColor == Color.SlateGray)
            {
                b5.BackColor = Color.White;
            }
            else if (b5.BackColor == Color.White)
            {
                b5.BackColor = Color.SlateGray;
            }
        }

        private void i1_Click(object sender, EventArgs e)
        {
            if (i1.BackColor == Color.SlateGray)
            {
                i1.BackColor = Color.White;
            }
            else if (i1.BackColor == Color.White)
            {
                i1.BackColor = Color.SlateGray;
            }
        }

        private void i2_Click(object sender, EventArgs e)
        {
            if (i2.BackColor == Color.SlateGray)
            {
                i2.BackColor = Color.White;
            }
            else if (i2.BackColor == Color.White)
            {
                i2.BackColor = Color.SlateGray;
            }
        }

        private void i3_Click(object sender, EventArgs e)
        {
            if (i3.BackColor == Color.SlateGray)
            {
                i3.BackColor = Color.White;
            }
            else if (i3.BackColor == Color.White)
            {
                i3.BackColor = Color.SlateGray;
            }
        }

        private void i4_Click(object sender, EventArgs e)
        {
            if (i4.BackColor == Color.SlateGray)
            {
                i4.BackColor = Color.White;
            }
            else if (i4.BackColor == Color.White)
            {
                i4.BackColor = Color.SlateGray;
            }
        }

        private void i5_Click(object sender, EventArgs e)
        {
            if (i5.BackColor == Color.SlateGray)
            {
                i5.BackColor = Color.White;
            }
            else if (i5.BackColor == Color.White)
            {
                i5.BackColor = Color.SlateGray;
            }
        }

        private void n1_Click(object sender, EventArgs e)
        {
            if (n1.BackColor == Color.SlateGray)
            {
                n1.BackColor = Color.White;
            }
            else if (n1.BackColor == Color.White)
            {
                n1.BackColor = Color.SlateGray;
            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (n2.BackColor == Color.SlateGray)
            {
                n2.BackColor = Color.White;
            }
            else if (n2.BackColor == Color.White)
            {
                n2.BackColor = Color.SlateGray;
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (n3.BackColor == Color.SlateGray)
            {
                n3.BackColor = Color.White;
            }
            else if (n3.BackColor == Color.White)
            {
                n3.BackColor = Color.SlateGray;
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (n4.BackColor == Color.SlateGray)
            {
                n4.BackColor = Color.White;
            }
            else if (n4.BackColor == Color.White)
            {
                n4.BackColor = Color.SlateGray;
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (n5.BackColor == Color.SlateGray)
            {
                n5.BackColor = Color.White;
            }
            else if (n5.BackColor == Color.White)
            {
                n5.BackColor = Color.SlateGray;
            }
        }

        private void g1_Click(object sender, EventArgs e)
        {
            if (g1.BackColor == Color.SlateGray)
            {
                g1.BackColor = Color.White;
            }
            else if (g1.BackColor == Color.White)
            {
                g1.BackColor = Color.SlateGray;
            }
        }

        private void g2_Click(object sender, EventArgs e)
        {
            if (g2.BackColor == Color.SlateGray)
            {
                g2.BackColor = Color.White;
            }
            else if (g2.BackColor == Color.White)
            {
                g2.BackColor = Color.SlateGray;
            }
        }

        private void g3_Click(object sender, EventArgs e)
        {
            if (g3.BackColor == Color.SlateGray)
            {
                g3.BackColor = Color.White;
            }
            else if (g3.BackColor == Color.White)
            {
                g3.BackColor = Color.SlateGray;
            }
        }

        private void g4_Click(object sender, EventArgs e)
        {
            if (g4.BackColor == Color.SlateGray)
            {
                g4.BackColor = Color.White;
            }
            else if (g4.BackColor == Color.White)
            {
                g4.BackColor = Color.SlateGray;
            }
        }

        private void g5_Click(object sender, EventArgs e)
        {
            if (g5.BackColor == Color.SlateGray)
            {
                g5.BackColor = Color.White;
            }
            else if (g5.BackColor == Color.White)
            {
                g5.BackColor = Color.SlateGray;
            }
        }

        private void o1_Click(object sender, EventArgs e)
        {
            if (o1.BackColor == Color.SlateGray)
            {
                o1.BackColor = Color.White;
            }
            else if (o1.BackColor == Color.White)
            {
                o1.BackColor = Color.SlateGray;
            }
        }

        private void o2_Click(object sender, EventArgs e)
        {
            if (o2.BackColor == Color.SlateGray)
            {
                o2.BackColor = Color.White;
            }
            else if (o2.BackColor == Color.White)
            {
                o2.BackColor = Color.SlateGray;
            }
        }

        private void o3_Click(object sender, EventArgs e)
        {
            if (o3.BackColor == Color.SlateGray)
            {
                o3.BackColor = Color.White;
            }
            else if (o3.BackColor == Color.White)
            {
                o3.BackColor = Color.SlateGray;
            }
        }

        private void o4_Click(object sender, EventArgs e)
        {
            if (o4.BackColor == Color.SlateGray)
            {
                o4.BackColor = Color.White;
            }
            else if (o4.BackColor == Color.White)
            {
                o4.BackColor = Color.SlateGray;
            }
        }

        private void o5_Click(object sender, EventArgs e)
        {
            if (o5.BackColor == Color.SlateGray)
            {
                o5.BackColor = Color.White;
            }
            else if (o5.BackColor == Color.White)
            {
                o5.BackColor = Color.SlateGray;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string messageTitle = "Game Already Started!";
            string message = "The game has already been started!\nDo you want to Exit the Application?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;


            if (_timesClicked > 0)
            {
                DialogResult result = MessageBox.Show(message, messageTitle, buttons);

                if (result == DialogResult.Yes)
                {
                    this.Close();
                    System.Environment.Exit(1);
                }
            }
            else
            {
                _timesClicked++;
                BColNumberLoader();
                IColNumberLoader();
                NColNumberLoader();
                GColNumberLoader();
                OColNumberLoader();
                bingoNumberGenerator();
            }
        }

        private void BingoCaller()
        {



        }

        private void bingo_Click(object sender, EventArgs e)
        {
            string messageTitle = "Game Over!";
            string messageWon = "You Won!";
            string noBingoTitle = "Invalid Bingo!";
            string messageNoBingo = "You do not have a bingo!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;

            //Vertical wins starts here: 
            if (calledNumbers.Contains(b1.Text) & calledNumbers.Contains(b2.Text) & calledNumbers.Contains(b3.Text) & calledNumbers.Contains(b4.Text) & calledNumbers.Contains(b5.Text))
            {
                DialogResult result = MessageBox.Show(messageWon, messageTitle, buttons);

                if (result == DialogResult.OK)
                {
                    this.Close();
                    System.Environment.Exit(1);
                }
            }
            else if (calledNumbers.Contains(i1.Text) & calledNumbers.Contains(i2.Text) & calledNumbers.Contains(i3.Text) & calledNumbers.Contains(i4.Text) & calledNumbers.Contains(i5.Text))
            {
                DialogResult result = MessageBox.Show(messageWon, messageTitle, buttons);

                if (result == DialogResult.OK)
                {
                    this.Close();
                    System.Environment.Exit(1);
                }
            }
            else if (calledNumbers.Contains(n1.Text) & calledNumbers.Contains(n2.Text) & calledNumbers.Contains(n3.Text) & calledNumbers.Contains(n4.Text) & calledNumbers.Contains(n5.Text))
            {
                DialogResult result = MessageBox.Show(messageWon, messageTitle, buttons);

                if (result == DialogResult.OK)
                {
                    this.Close();
                    System.Environment.Exit(1);
                }
            }
            else if (calledNumbers.Contains(g1.Text) & calledNumbers.Contains(g2.Text) & calledNumbers.Contains(g3.Text) & calledNumbers.Contains(g4.Text) & calledNumbers.Contains(g5.Text))
            {
                DialogResult result = MessageBox.Show(messageWon, messageTitle, buttons);

                if (result == DialogResult.OK)
                {
                    this.Close();
                    System.Environment.Exit(1);
                }
            }
            else if (calledNumbers.Contains(o1.Text) & calledNumbers.Contains(o2.Text) & calledNumbers.Contains(o3.Text) & calledNumbers.Contains(o4.Text) & calledNumbers.Contains(o5.Text))
            {
                DialogResult result = MessageBox.Show(messageWon, messageTitle, buttons);

                if (result == DialogResult.OK)
                {
                    this.Close();
                    System.Environment.Exit(1);
                }
            }
            //Horizontal wins starts here: 
            else if (calledNumbers.Contains(b1.Text) & calledNumbers.Contains(i1.Text) & calledNumbers.Contains(n1.Text) & calledNumbers.Contains(g1.Text) & calledNumbers.Contains(o1.Text))
            {
                DialogResult result = MessageBox.Show(messageWon, messageTitle, buttons);

                if (result == DialogResult.OK)
                {
                    this.Close();
                    System.Environment.Exit(1);
                }
            }
            else if (calledNumbers.Contains(b2.Text) & calledNumbers.Contains(i2.Text) & calledNumbers.Contains(n2.Text) & calledNumbers.Contains(g2.Text) & calledNumbers.Contains(o2.Text))
            {
                DialogResult result = MessageBox.Show(messageWon, messageTitle, buttons);

                if (result == DialogResult.OK)
                {
                    this.Close();
                    System.Environment.Exit(1);
                }
            }
            else if (calledNumbers.Contains(b3.Text) & calledNumbers.Contains(i3.Text) & calledNumbers.Contains(n3.Text) & calledNumbers.Contains(g3.Text) & calledNumbers.Contains(o3.Text))
            {
                DialogResult result = MessageBox.Show(messageWon, messageTitle, buttons);

                if (result == DialogResult.OK)
                {
                    this.Close();
                    System.Environment.Exit(1);
                }
            }
            else if (calledNumbers.Contains(b4.Text) & calledNumbers.Contains(i4.Text) & calledNumbers.Contains(n4.Text) & calledNumbers.Contains(g4.Text) & calledNumbers.Contains(o4.Text))
            {
                DialogResult result = MessageBox.Show(messageWon, messageTitle, buttons);

                if (result == DialogResult.OK)
                {
                    this.Close();
                    System.Environment.Exit(1);
                }
            }
            else if (calledNumbers.Contains(b5.Text) & calledNumbers.Contains(i5.Text) & calledNumbers.Contains(n5.Text) & calledNumbers.Contains(g5.Text) & calledNumbers.Contains(o5.Text))
            {
                DialogResult result = MessageBox.Show(messageWon, messageTitle, buttons);

                if (result == DialogResult.OK)
                {
                    this.Close();
                    System.Environment.Exit(1);
                }
            }
            //Diagonal wins starts here: 
            else if (calledNumbers.Contains(b1.Text) & calledNumbers.Contains(i2.Text) & calledNumbers.Contains(n3.Text) & calledNumbers.Contains(g4.Text) & calledNumbers.Contains(o5.Text))
            {
                DialogResult result = MessageBox.Show(messageWon, messageTitle, buttons);

                if (result == DialogResult.OK)
                {
                    this.Close();
                    System.Environment.Exit(1);
                }
            }
            else if (calledNumbers.Contains(b5.Text) & calledNumbers.Contains(i4.Text) & calledNumbers.Contains(n3.Text) & calledNumbers.Contains(g2.Text) & calledNumbers.Contains(o1.Text))
            {
                DialogResult result = MessageBox.Show(messageWon, messageTitle, buttons);

                if (result == DialogResult.OK)
                {
                    this.Close();
                    System.Environment.Exit(1);
                }
            }
            else
            {
                DialogResult result = MessageBox.Show(messageNoBingo, noBingoTitle, buttons);

            }
        }

        private void currentNumber_Click(object sender, EventArgs e)
        {
            string nextNumber;
            int i = 1;


            if (selectedNumbers.Count > 0)
            {
                if (selectedNumbers.Peek() <= 15)
                {
                    nextNumber = selectedNumbers.Peek().ToString();
                    calledNumbers.Add(nextNumber);
                    CurrentDisplayedNumber.Text = $"B - {nextNumber}";
                    selectedNumbers.Pop();
                }
                else if (selectedNumbers.Peek() >= 16 & selectedNumbers.Peek() <= 30)
                {
                    nextNumber = selectedNumbers.Peek().ToString();
                    calledNumbers.Add(nextNumber);
                    CurrentDisplayedNumber.Text = $"I - {nextNumber}";
                    selectedNumbers.Pop();
                }
                else if (selectedNumbers.Peek() >= 31 & selectedNumbers.Peek() <= 45)
                {
                    nextNumber = selectedNumbers.Peek().ToString();
                    calledNumbers.Add(nextNumber);
                    CurrentDisplayedNumber.Text = $"N - {nextNumber}";
                    selectedNumbers.Pop();
                }
                else if (selectedNumbers.Peek() >= 46 & selectedNumbers.Peek() <= 60)
                {
                    nextNumber = selectedNumbers.Peek().ToString();
                    calledNumbers.Add(nextNumber);
                    CurrentDisplayedNumber.Text = $"G - {nextNumber}";
                    selectedNumbers.Pop();
                }
                else
                {
                    nextNumber = selectedNumbers.Peek().ToString();
                    calledNumbers.Add(nextNumber);
                    CurrentDisplayedNumber.Text = $"O - {nextNumber}";
                    selectedNumbers.Pop();
                }


                PreviousDisplayedNumbers.ResetText();
                calledNumbers.Remove(n3.Text);

                foreach (var calledNumber in calledNumbers)
                {
                    if (calledNumbers.Count == 1)
                    {
                        if (int.Parse(calledNumber) <= 15)
                        {
                            PreviousDisplayedNumbers.Text += $"{i}. B - {calledNumber}";
                        }
                        else if (int.Parse(calledNumber) >= 16 & int.Parse(calledNumber) <= 30)
                        {
                            PreviousDisplayedNumbers.Text += $"{i}. I - {calledNumber}";
                        }
                        else if (int.Parse(calledNumber) >= 31 & int.Parse(calledNumber) <= 45)
                        {
                            PreviousDisplayedNumbers.Text += $"{i}. N - {calledNumber}";
                        }
                        else if (int.Parse(calledNumber) >= 46 & int.Parse(calledNumber) <= 60)
                        {
                            PreviousDisplayedNumbers.Text += $"{i}. G - {calledNumber}";
                        }
                        else
                        {
                            PreviousDisplayedNumbers.Text += $"{i}. O - {calledNumber}";
                        }
                    }
                    else
                    {
                        if (int.Parse(calledNumber) <= 15)
                        {
                            PreviousDisplayedNumbers.Text += $"\r\n{i}. B - {calledNumber}";
                        }
                        else if (int.Parse(calledNumber) >= 16 & int.Parse(calledNumber) <= 30)
                        {
                            PreviousDisplayedNumbers.Text += $"\r\n{i}. I - {calledNumber}";
                        }
                        else if (int.Parse(calledNumber) >= 31 & int.Parse(calledNumber) <= 45)
                        {
                            PreviousDisplayedNumbers.Text += $"\r\n{i}. N - {calledNumber}";
                        }
                        else if (int.Parse(calledNumber) >= 46 & int.Parse(calledNumber) <= 60)
                        {
                            PreviousDisplayedNumbers.Text += $"\r\n{i}. G - {calledNumber}";
                        }
                        else
                        {
                            PreviousDisplayedNumbers.Text += $"\r\n{i}. O - {calledNumber}";
                        }
                    }

                    PreviousDisplayedNumbers.Text = PreviousDisplayedNumbers.Text.TrimStart();

                    i++;
                }
                calledNumbers.Add(n3.Text);

                

                
            }
            else
            {
                if (_timesClicked != 0)
                {
                    string messageTitle = "Game Over!";
                    string message = "You lost!";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;

                    DialogResult result = MessageBox.Show(message, messageTitle, buttons);

                    if (result == DialogResult.OK)
                    {
                        this.Close();
                        Environment.Exit(1);
                    }
                }
                else
                {
                    string messageTitle = "Game Not Yet Started!";
                    string message = "Press 'Start' to begin!";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;

                    DialogResult result = MessageBox.Show(message, messageTitle, buttons);
                }
            }

           


        }

        private void bingoNumberGenerator()
        {
            //free space added in automatically
            calledNumbers.Add(n3.Text);

            for (int i = 0; i < 51; i++)
            {
                int number = random.Next(1, 75);

                if (selectedNumbers.Contains(number))
                {
                    i--;
                }
                else
                {
                    selectedNumbers.Push(number);
                }
            }
        }


        private void label6_Click(object sender, EventArgs e)
        {



        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            


        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }

        private void PreviousDisplayedNumbers_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalledNumbersLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
