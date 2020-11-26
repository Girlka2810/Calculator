using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        double _tmp;
        string _action = "";
        int _countDotsInExpression = 0;


        public MainForm()
        {
            InitializeComponent();
        }



        private void OnButtonNumberClick(object sender, EventArgs e)
        {
            if (resultBox.Text == "0")
            {
                resultBox.Text = "";
            }
            resultBox.Text += ((Button)sender).Text;
        }

        private void OnMathematicalActionButtonClick(object sender, EventArgs e)
        {
            if (resultBox.Text.Length != 0)
            {
                _tmp = Convert.ToDouble(resultBox.Text);
                _countDotsInExpression = 0;
                resultBox.Text = "";
                _action = ((Button)sender).Text;
            }
        }

        private void OnResultButtonClick(object sender, EventArgs e)
        {
            if(resultBox.Text.Length==0)
            {
                return;
            }
            switch(_action)
            {
                case "+":
                    resultBox.Text = _tmp + Convert.ToDouble(resultBox.Text) + "";
                    break;
                case "-":
                    resultBox.Text = _tmp - Convert.ToDouble(resultBox.Text) + "";
                    break;
                case "*":
                    resultBox.Text = _tmp * Convert.ToDouble(resultBox.Text) + "";
                    break;
                case "/":
                    if (Convert.ToInt32(resultBox.Text) != 0)
                    {
                        resultBox.Text = _tmp / Convert.ToDouble(resultBox.Text) + "";
                    }
                    else
                    {
                        ResetVariebles();
                        resultBox.Text = "";
                    }
                    break;
            }
            ResetVariebles();


        }



        private void OnPlusMinusButtonClick(object sender, EventArgs e)
        {
            if (resultBox.Text.Length != 0)
            {
                if (resultBox.Text.Contains("-"))
                {
                    resultBox.Text = resultBox.Text.Substring(1);
                }
                else
                {
                    resultBox.Text = "-" + resultBox.Text;
                }
            }
        }


        private void OnDoteButtonClick (object sender, EventArgs e)
        {
            if (_countDotsInExpression == 0)
            {
                if (resultBox.Text.Length == 0)
                {
                    resultBox.Text += "0,";
                }
                else
                {
                    resultBox.Text += ((Button)sender).Text;
                }
                _countDotsInExpression = 1;
            }
        }



        private void OnClearButtonClick(object sender, EventArgs e)
        {
            ResetVariebles();
            resultBox.Text = "";
        }


        private void OnBackSpaceButtonClick(object sender, EventArgs e)
        {
            if (resultBox.Text.Length != 0)
            {
                resultBox.Text = resultBox.Text.Substring(0, resultBox.Text.Length - 1);
            }
        }

        private void ResetVariebles()
        {
            _tmp = 0;
            _action = "";
            _countDotsInExpression = 0;
        }
    }
}
