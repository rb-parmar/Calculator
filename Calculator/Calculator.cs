using System.Text;

namespace Calculator
{
    public partial class Calculator : Form
    {

        double storedOperand;
        double result = 0;
        string storedOperation = "";
        bool hasStoredOperation = false;

        public string operationBacklog { get; set; }
        public string HexadecimalFormatString { get; set; }
        public string BinaryString { get; set; }

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }


        #region Zero
        // Zero button
        private void Zero_Click(object sender, EventArgs e)
        {
            OperationInput.Text += 0;
            operationBacklog += 0;

        }

        private void Zero_MouseClick(object sender, MouseEventArgs e)
        {
            OperationInput.Text += 0;
            operationBacklog += 0;
        }

        private void Zero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0)
            {
                OperationInput.Text += 0;
                operationBacklog += 0;
            }
        }
        #endregion

        #region Decimal
        // Decimal button
        private void Decimal_Click(object sender, EventArgs e)
        {
            OperationInput.Text += ".";
            operationBacklog += ".";
        }

        private void Decimal_MouseClick(object sender, MouseEventArgs e)
        {
            OperationInput.Text += ".";
            operationBacklog += ".";
        }

        private void Decimal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Decimal || e.KeyCode == Keys.OemPeriod)
            {
                OperationInput.Text += ".";
                operationBacklog += ".";
            }
        }

        #endregion

        #region One
        // One button
        private void One_Click(object sender, EventArgs e)
        {
            OperationInput.Text += 1;
            operationBacklog += 1;
        }

        private void One_MouseClick(object sender, MouseEventArgs e)
        {
            OperationInput.Text += 1;
            operationBacklog += 1;
        }

        private void One_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                OperationInput.Text += 1;
                operationBacklog += 1;
            }
        }
        #endregion

        #region Two
        private void Two_Click(object sender, EventArgs e)
        {
            OperationInput.Text += 2;
            operationBacklog += 2;
        }

        private void Two_MouseClick(object sender, MouseEventArgs e)
        {
            OperationInput.Text += 2;
            operationBacklog += 2;
        }

        private void Two_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                OperationInput.Text += 2;
                operationBacklog += 2;
            }
        }
        #endregion

        #region Three
        private void Three_Click(object sender, EventArgs e)
        {
            OperationInput.Text += 3;
            operationBacklog += 3;
        }

        private void Three_MouseClick(object sender, MouseEventArgs e)
        {
            OperationInput.Text += 3;
            operationBacklog += 3;
        }

        private void Three_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                OperationInput.Text += 3;
                operationBacklog += 3;
            }
        }
        #endregion

        #region Four
        private void Four_Click(object sender, EventArgs e)
        {
            OperationInput.Text += 4;
            operationBacklog += 4;
        }

        private void Four_MouseClick(object sender, MouseEventArgs e)
        {
            OperationInput.Text += 4;
            operationBacklog += 4;
        }

        private void Four_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {
                OperationInput.Text += 4;
                operationBacklog += 4;
            }
        }
        #endregion

        #region Five
        private void Five_Click(object sender, EventArgs e)
        {
            OperationInput.Text += 5;
            operationBacklog += 5;
        }

        private void Five_MouseClick(object sender, MouseEventArgs e)
        {
            OperationInput.Text += 5;
            operationBacklog += 5;
        }

        private void Five_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
            {
                OperationInput.Text += 5;
                operationBacklog += 5;
            }
        }
        #endregion

        #region Six
        private void Six_Click(object sender, EventArgs e)
        {
            OperationInput.Text += 6;
            operationBacklog += 6;
        }

        private void Six_MouseClick(object sender, MouseEventArgs e)
        {
            OperationInput.Text += 6;
            operationBacklog += 6;
        }

        private void Six_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
            {
                OperationInput.Text += 6;
                operationBacklog += 6;
            }
        }
        #endregion

        #region Seven
        private void Seven_Click(object sender, EventArgs e)
        {
            OperationInput.Text += 7;
            operationBacklog += 7;
        }

        private void Seven_MouseClick(object sender, MouseEventArgs e)
        {
            OperationInput.Text += 7;
            operationBacklog += 7;
        }

        private void Seven_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
            {
                OperationInput.Text += 7;
                operationBacklog += 7;
            }
        }
        #endregion

        #region Eight
        private void Eight_Click(object sender, EventArgs e)
        {
            OperationInput.Text += 8;
            operationBacklog += 8;
        }

        private void Eight_MouseClick(object sender, MouseEventArgs e)
        {
            OperationInput.Text += 8;
            operationBacklog += 8;
        }

        private void Eight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
            {
                OperationInput.Text += 8;
                operationBacklog += 8;
            }
        }
        #endregion

        #region Nine 
        private void Nine_Click(object sender, EventArgs e)
        {
            OperationInput.Text += 9;
            operationBacklog += 9;
        }

        private void Nine_MouseClick(object sender, MouseEventArgs e)
        {
            OperationInput.Text += 9;
            operationBacklog += 9;
        }

        private void Nine_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
            {
                OperationInput.Text += 9;
                operationBacklog += 9;
            }
        }
        #endregion

        // Encoding methods for binary format and Hexadecimal format
        // extracted the conversion of the fractional parts from chat gpt
        // Hexadecimal Encoding method
        private string  HexaDecimalEncodingMethod(string result)
        {
            double decimalNumber = double.Parse(result);

            int intValue = (int)decimalNumber;

            HexadecimalFormatString = intValue.ToString("X");

            double fractionalPart = decimalNumber - intValue;

            string fractionalHexadecimal = FractionalToHexadecimal(fractionalPart);

            return HexadecimalFormatString + "." + fractionalHexadecimal;
        }

        static string FractionalToHexadecimal(double fractionalPart)
        {
            string hexFractional = "";
            const int precision = 6;

            for (int i = 0; i < precision; i++)
            {
                fractionalPart *= 16;
                int digit = (int)fractionalPart;
                hexFractional += digit.ToString("X");
                fractionalPart -= digit;
            }

            return hexFractional;
        }

        // Binary Encoding method
        private string BinaryEncodingMethod(string result)
        {
            double decimalNumber = double.Parse(result);
            int integerPart = (int)decimalNumber;
            double fractionalPart = decimalNumber - integerPart;

            string binaryIntegerPart = Convert.ToString(integerPart, 2);

            string binaryFractionalPart = ConvertFractionalPartToBinary(fractionalPart);

            string BinaryFormatString = binaryIntegerPart + "." + binaryFractionalPart;

            return BinaryFormatString;
        }
        
        private string ConvertFractionalPartToBinary(double fractionalPart)
        {
            string FractionalBinaryString = "";
            const int maxBits = 32; 

            while (fractionalPart > 0 && FractionalBinaryString.Length < maxBits)
            {
                fractionalPart *= 2;
                int bit = (int)fractionalPart;
                if (bit == 1)
                {
                    FractionalBinaryString += "1";
                    fractionalPart -= 1;
                }
                else
                {
                    FractionalBinaryString += "0";
                }
            }

            return FractionalBinaryString;
        }

        private void Button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Text == ".")
            {
                if (!ResultOutput.Text.Contains('.'))
                {
                    ResultOutput.Text += button.Text;
                }
            }
            else
            {
                ResultOutput.Text += button.Text;
            }

            hasStoredOperation = false;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            OperationInput.Text = "";
            ResultOutput.Text = "";
            operationBacklog = "";

            storedOperand = 0;
            result = 0;
            storedOperation = "";
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (ResultOutput.Text != "")
            {
                Equal.PerformClick();
                handleOperand(button);

                storedOperand = double.Parse(ResultOutput.Text);

                ResultOutput.Text = "";
                OperationInput.Text = storedOperand + " " + storedOperation;
            }
            else
            {
                handleOperand(button);
                OperationInput.Text = storedOperand + " " + storedOperation;
            }

        }

        private void handleOperand(Button button)
        {
            if (button.Text == "x")
            {
                storedOperation = "*";
                hasStoredOperation = true;
            }
            else if (button.Text == "➗")
            {
                storedOperation = "/";
                hasStoredOperation = true;
            }
            else
            {
                storedOperation = button.Text;
                hasStoredOperation = true;
            }
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            if (ResultOutput.Text != "")
            {
                switch (storedOperation)
                {
                    case "+":
                        ResultOutput.Text = (storedOperand + double.Parse(ResultOutput.Text)).ToString();
                        break;
                    case "-":
                        ResultOutput.Text = (storedOperand - double.Parse(ResultOutput.Text)).ToString();
                        break;
                    case "*":
                        ResultOutput.Text = (storedOperand * double.Parse(ResultOutput.Text)).ToString();
                        break;
                    case "/":
                        ResultOutput.Text = (storedOperand / double.Parse(ResultOutput.Text)).ToString();
                        break;
                    default:
                        break;
                }

                storedOperand = double.Parse(ResultOutput.Text);
                OperationInput.Text = storedOperand.ToString();
                storedOperation = "";
                hasStoredOperation = false;
            }
        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            if (ResultOutput.Text != "")
            {
                int length = ResultOutput.Text.Length;
                ResultOutput.Text = ResultOutput.Text.Remove(length - 1);
            }
        }

        private void ResultOutput_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ResultOutput.Text) && ResultOutput.Text.Length < 15 && (ResultOutput.Text.Last() != '.'))
            {
                string binaryFormat = BinaryEncodingMethod(ResultOutput.Text);
                string hexFormat = HexaDecimalEncodingMethod(ResultOutput.Text);
             
                if (binaryFormat.Length > 8)
                {
                    BinaryTextBox.Text = "OUT OF RNG";
                }
                else
                {
                    BinaryTextBox.Text = binaryFormat.PadLeft(8, '0');
                }

                if (hexFormat.Length > 8)
                {
                    HexadecimalTextBox.Text = "OUT OF RNG";
                } else
                {
                    HexadecimalTextBox.Text = hexFormat.PadLeft(8, '0');
                }

            } else
            {
                BinaryTextBox.Text = "";
                HexadecimalTextBox.Text = "";
            }
        }
    }
}