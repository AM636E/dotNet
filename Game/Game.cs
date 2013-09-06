using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Game
{
    public partial class Game : Form
    {
        private List<Button> buttons;
        struct ClickedButton
        {
            public int value;
            public int prevValue;
            public bool isPrevClicked;
        };
        private ClickedButton clickedButton;
        private int buttonsDisabled;
        private int maxValue;

        public Game()
        {
            InitializeComponent();
            buttons = new List<Button>(16);
            buttons.Add(this.button1 );
            buttons.Add(this.button2 );
            buttons.Add(this.button3 );
            buttons.Add(this.button4 );
            buttons.Add(this.button5 );
            buttons.Add(this.button6 );
            buttons.Add(this.button7 );
            buttons.Add(this.button8 );
            buttons.Add(this.button9 );
            buttons.Add(this.button10);
            buttons.Add(this.button11);
            buttons.Add(this.button12);
            buttons.Add(this.button13);
            buttons.Add(this.button14);
            buttons.Add(this.button15);
            buttons.Add(this.button16);

            GenerateNumbersOnButtons();
            SetButtonHandlers();
            buttonsDisabled = 1;

            this.trackBar1.Maximum = 16;

            this.toolTip1.ToolTipTitle = "Start the game";
            this.numericUpDown1.Maximum = 1000000;

            DisableButtons();            
        }

        public void GenerateNumbersOnButtons()
        {
            Random rnd = new Random();
            int tmp = 0;
            maxValue = 0;
            foreach (Button button in buttons)
            {
                tmp = rnd.Next(0, 100);
                button.Text = tmp.ToString();

                if (tmp > maxValue)
                {
                    maxValue = tmp;
                }
            }
        }

        public void SetButtonHandlers()
        {
            foreach (Button button in buttons)
            {
                button.Click += delegate(Object sender, EventArgs args)
                {
                    Button b = sender as Button;

                    if (buttonsDisabled > 15 )// || b.Text == maxValue.ToString())
                    {
                        EndGame();
                        return;x
                    }

                    if (clickedButton.isPrevClicked == true)
                    {
                        Int32.TryParse(b.Text, out clickedButton.value);

                     //   if (clickedButton.value >= clickedButton.prevValue)
                     //   {
                            this.listBox1.Items.Add(clickedButton.value);
                            clickedButton.prevValue = clickedButton.value;
                            b.Enabled = false;
                            buttonsDisabled++;

                            this.trackBar1.Value++;
                            this.progressBar1.Value = ( buttonsDisabled * 100 ) / 16 ;
                      //  }
                    }
                    if (!clickedButton.isPrevClicked)
                    {
                        Int32.TryParse(b.Text, out clickedButton.prevValue);
                        clickedButton.isPrevClicked = true;
                        b.Enabled = false;
                        this.trackBar1.Value++;
                    }                    
                };
            }
        }

        public void SetButtonsEnabled(bool value)
        {
            foreach (Button button in buttons)
            {
                button.Enabled = value;
            }
        }

        public void DisableButtons() { SetButtonsEnabled(false); }
        public void EnableButtons() { SetButtonsEnabled(true); }

        public void EndGame()
        {
            DisableButtons();
            ShowStatistics();
        }

        public void ShowStatistics()
        {
            int percentOK = (buttonsDisabled * 100) / 16;

            this.label1.Text = "OK " + percentOK + " %";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            EnableButtons();
            this.button18.Enabled = false;
        }
    }
}
