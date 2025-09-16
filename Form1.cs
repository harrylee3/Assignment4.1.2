namespace Assignment4._1._2
{
    public partial class Form1 : Form
    {
        int firstNumber;
        int secondNumber;
        string? operation;
        public Form1()
        {
            InitializeComponent();
        }
        // Append the corresponding digit to the TextBox.Text property.
        private void NumberButtonClicked(object sender, EventArgs e)
        {
            // This code will be executed when any of the subscribed buttons are clicked.
            Button? clickedButton = sender as Button; // Cast sender to Button to identify which button was clicked

            if (string.IsNullOrEmpty(resultTextBox.Text))
            {
                resultTextBox.Text = clickedButton.Text;
            }
            else
            {
                resultTextBox.Text += clickedButton.Text;
            }
        }
        // Store the first number and the selected operator, then clear the display for the second number.
        private void OperationButtonClicked(object sender, EventArgs e)
        {
            // This code will be executed when any of the subscribed buttons are clicked.
            Button? clickedButton = sender as Button; // Cast sender to Button to identify which button was clicked

            operation = clickedButton.Text;
            firstNumber = Convert.ToInt32(resultTextBox.Text);
            resultTextBox.Text = string.Empty;
        }
        // Retrieve the second number, perform the calculation based on
        // the stored operator, and display the result in the TextBox.
        private void EqualsButtonClicked(object sender, EventArgs e)
        {
            secondNumber = Convert.ToInt32(resultTextBox.Text);
            CalcMethods calculation = new CalcMethods();
            double result = 0;
            switch (operation)
            {
                case "+":
                    result = calculation.Add(firstNumber, secondNumber);
                    break;
                case "-":
                    result = calculation.Subtract(firstNumber, secondNumber);
                    break;
                case "x":
                    result = calculation.Multiply(firstNumber, secondNumber);
                    break;
                case "/":
                    result = calculation.Divide(firstNumber, secondNumber);
                    break;
                default:
                    MessageBox.Show("Please select an operation.");
                    break;
            }
            resultTextBox.Text = $"{firstNumber} {operation} {secondNumber} = {result}";
        }
        // Clear the TextBox and reset stored values.
        private void ClearButtonClicked(object sender, EventArgs e)
        {
            resultTextBox.Text = string.Empty;
            firstNumber = 0;
            secondNumber = 0;
            operation = string.Empty;
        }
    }
}
