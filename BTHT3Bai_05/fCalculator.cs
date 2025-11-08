using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BTHT3Bai_05
{
    public partial class fCalculator : Form
    {
        double result = 0;
        string operation = string.Empty;
        string fstNum, secNum; 
        bool enterValue = false;
        bool isCheck = false;
        double lastOperand = 0; 
        string lastOperation = string.Empty; 
        List<string> History_list = new List<string>();
        public fCalculator()
        {
            InitializeComponent();
            CreateEventBtnClick();
        }
        private void DisableButtonsExceptAllowed()
        {
            string[] allowedButtons = { "C", "CE", "=", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"};
            foreach (var item in tableLayoutPanel2.Controls)
            {
                if (item is Button btn)
                {
                    btn.Enabled = allowedButtons.Contains(btn.Text);
                }
            }
            foreach (var item in tableLayoutPanel3.Controls)
            {
                if (item is Button btn)
                {
                    btn.Enabled = false;
                }
            }
        }
        private void EnableButtonsExceptAllowed()
        {
            foreach (var item in tableLayoutPanel2.Controls)
            {
                if (item is Button btn)
                {
                    btn.Enabled = true;
                }
            }
            foreach (var item in tableLayoutPanel3.Controls)
            {
                if (item is Button btn)
                {
                    btn.Enabled = true;
                }
            }
        }
        private void BtnReset_Click(object sender, EventArgs e)
        {
            txt_DisplayResult1.Text = "0";
            txt_DisplayResult2.Text = string.Empty;
            operation = string.Empty;
            result = 0;
            fstNum = string.Empty;
            secNum = string.Empty;
            EnableButtonsExceptAllowed();
        }
        private void CreateEventBtnClick()
        {
            foreach (var item in tableLayoutPanel2.Controls)
            {
                if (item is Button btn)
                {
                    if(btn.Text == "7" || btn.Text == "8" || btn.Text == "9" || btn.Text == "6" || btn.Text == "5" || btn.Text == "4" || btn.Text == "3" || btn.Text == "2" || btn.Text == "1" || btn.Text == "0" || btn.Text == ".")
                    {
                        btn.Click += BtnNum_Click;
                    }
                    else if (btn.Text == "+" || btn.Text == "-" || btn.Text == "*" || btn.Text == "/")
                    {
                        btn.Click += BtnMathOperation_Click;
                    }
                    else if(btn.Text == "=")
                    {
                        btn.Click += BtnEqual_Click;
                    }
                    else if(btn.Text == "1/x"){
                        btn.Click += BtnDevision_Click;
                    }
                    else if(btn.Text == "sqrt")
                    {
                        btn.Click += Btnsqrt_Click;
                    }
                    else if(btn.Text == "+/-"){
                        btn.Click += BtnPlusMinus_Click;
                    }
                    else if((btn.Text == "%")){
                        btn.Click += Btnpercent_Click;
                    }
                }
            }
            foreach (var item in tableLayoutPanel1.Controls)
            {
                if(item is Button btn)
                {
                    if (btn.Text == "Backspace")
                    {
                        btn.Click += Btn_Backspace_Click;
                    }
                    else if (btn.Text == "C" || btn.Text == "CE")
                        {
                            btn.Click += BtnReset_Click;
                        }
                }
            }
        }
        private void Btn_Backspace_Click(object sender, EventArgs e)
        {
            if(txt_DisplayResult1.Text == "0" || txt_DisplayResult1.Text == "Cannot divide by zero" || txt_DisplayResult1.Text == "Invalid input" || txt_DisplayResult1.Text == "Error")
            {
                txt_DisplayResult1.Text = "0";
                return;
            }
            if (txt_DisplayResult1.Text.Length > 1) {
                txt_DisplayResult1.Text = txt_DisplayResult1.Text.Substring(0, txt_DisplayResult1.Text.Length - 1);
            }
            else 
            {
                txt_DisplayResult1.Text = "0";
            }
            
        }
        private void Btnpercent_Click(object sender, EventArgs e)
        {
            try
            {
                double currentNumber = double.Parse(txt_DisplayResult1.Text);
                double percentValue;
                if (!string.IsNullOrEmpty(operation))
                {
                    percentValue = currentNumber / 100.0;
                }
                else
                {
                    percentValue = currentNumber / 100.0;
                }
                txt_DisplayResult1.Text = percentValue.ToString("G");
                if (!string.IsNullOrEmpty(operation))
                {
                    txt_DisplayResult2.Text = $"{result} {operation} {percentValue}";

                }
                else
                {
                    txt_DisplayResult2.Text = $"{percentValue}";
                    string historyEntry = $"{currentNumber}% = {percentValue}";
                    History_list.Add(historyEntry);
                    History.Items.Add(historyEntry);
                }
                enterValue = true;
                isCheck = true;
            }
            catch
            {
                txt_DisplayResult1.Text = "Error";
            }
        }
        private void BtnPlusMinus_Click(object sender, EventArgs e)
        {
            try
            {
                double number = double.Parse(txt_DisplayResult1.Text);
                number = -number;
                txt_DisplayResult2.Text = $"({number})";  
                txt_DisplayResult1.Text = number.ToString();
                result = number;
            }
            catch
            {
                txt_DisplayResult1.Text = "Error";
            }
        }
        private void Btnsqrt_Click(object sender, EventArgs e)
        {
            try
            {
                double number = double.Parse(txt_DisplayResult1.Text);
                if(number < 0)
                {
                    txt_DisplayResult1.Text = "Invalid input";
                    txt_DisplayResult2.Text = $"√({number})";
                    result = 0;
                    operation = string.Empty;
                    DisableButtonsExceptAllowed();
                    return;
                }
                double sqrtValue = Math.Sqrt(number);
                txt_DisplayResult2.Text = $"√({number})";
                txt_DisplayResult1.Text = sqrtValue.ToString();
                result = sqrtValue;
                operation = string.Empty; 
                string historyEntry = $"√({number}) = {sqrtValue}"; 
                History_list.Add(historyEntry); 
                History.Items.Add(historyEntry);
            }
            catch {
                txt_DisplayResult1.Text = "Error";
            }
        }
        private void BtnDevision_Click(object sender, EventArgs e)
        {
            try
            {
                double number = double.Parse(txt_DisplayResult1.Text);
                if (number == 0)
                {
                    txt_DisplayResult1.Text = "Cannot divide by zero";
                    txt_DisplayResult2.Text = "1 / 0";
                    result = 0;
                    operation = string.Empty;
                    DisableButtonsExceptAllowed();
                    return;
                }
                double reciprocal = 1 / number;
                txt_DisplayResult2.Text = $"1 / ({number})";
                txt_DisplayResult1.Text = reciprocal.ToString();
                result = reciprocal;
                string history = $"1 / {number} = {reciprocal}";
                History_list.Add(history);
                History.Items.Add(history);
            }
            catch
            {
                txt_DisplayResult1.Text = "Error";
            }
        }
        private void BtnNum_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            EnableButtonsExceptAllowed();
            if (btn == null) return;
            if (txt_DisplayResult1.Text == "Cannot divide by zero" || txt_DisplayResult1.Text == "Invalid input")
            {
                txt_DisplayResult1.Text = "";
            }
            if (txt_DisplayResult1.Text == "0" || enterValue)
            {
                txt_DisplayResult1.Text = "";
                enterValue = false;
            }
            if (btn.Text == ".")
            {
                if (!txt_DisplayResult1.Text.Contains("."))
                {
                    txt_DisplayResult1.Text += ".";
                }
            }
            else
            {
                txt_DisplayResult1.Text += btn.Text;
            }
        }
        private void BtnMathOperation_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            string btnText = btn.Text;
            double currentNumber;
            if (string.IsNullOrEmpty(txt_DisplayResult1.Text))
            {
                currentNumber = result;
            }
            else
            {
                currentNumber = double.Parse(txt_DisplayResult1.Text);
            }
            if (!string.IsNullOrEmpty(operation))
            {
                double prevResult = result;
                switch (operation)
                {
                    case "+":
                        result += currentNumber;
                        break;
                    case "-":
                        result -= currentNumber;
                        break;
                    case "*":
                        result *= currentNumber;
                        break;
                    case "/":
                        if (currentNumber == 0)
                        {
                            txt_DisplayResult1.Text = "Cannot divide by zero";
                            DisableButtonsExceptAllowed();
                            txt_DisplayResult2.Text = $"{result} {operation} {currentNumber}";
                            operation = string.Empty;
                            return;
                        }
                        result /= currentNumber;
                        break;
                }
                string historyEntry = $"{prevResult} {operation} {currentNumber} = {result}";
                History_list.Add(historyEntry);
                History.Items.Add(historyEntry);
            }
            else
            {
                result = currentNumber;
            }
            operation = btnText;
            enterValue = true;
            txt_DisplayResult1.Text = result.ToString();
            txt_DisplayResult2.Text = $"{result} {operation}";
        }
        private void label2_Click(object sender, EventArgs e)
        {
            History_list.Clear();
            History.Items.Clear();
        }
        private void BtnEqual_Click(object sender, EventArgs e)
        {
            if (txt_DisplayResult1.Text == "Cannot divide by zero" || txt_DisplayResult1.Text == "Invalid input")
            {
                txt_DisplayResult1.Text = "0";
                txt_DisplayResult2.Text = string.Empty;
                EnableButtonsExceptAllowed();
                lastOperation = string.Empty;
                lastOperand = 0;
                return;
            }
            double currentDisplayValue = double.Parse(txt_DisplayResult1.Text);
            string opToUse;
            double operandToUse;
            if (!string.IsNullOrEmpty(operation)) 
            {
                lastOperation = operation;
                lastOperand = currentDisplayValue;
                opToUse = operation;
                operandToUse = currentDisplayValue;
            }
            else 
            {
                if (string.IsNullOrEmpty(lastOperation))
                {
                    txt_DisplayResult2.Text = $"{txt_DisplayResult1.Text} = ";
                    string historyEntry1 = $"{txt_DisplayResult2.Text} {txt_DisplayResult1.Text}";
                    History_list.Add(historyEntry1);
                    History.Items.Add(historyEntry1);
                    return;
                }
                opToUse = lastOperation;
                operandToUse = lastOperand;
            }
            txt_DisplayResult2.Text = $"{result} {opToUse} {operandToUse} = ";
            double newResult = result;
            switch (opToUse)
            {
                case "+":
                    newResult += operandToUse;
                    break;
                case "-":
                    newResult -= operandToUse;
                    break;
                case "*":
                    newResult *= operandToUse;
                    break;
                case "/":
                    if (operandToUse == 0)
                    {
                        txt_DisplayResult1.Text = "Cannot divide by zero";
                        result = 0;
                        operation = string.Empty;
                        lastOperation = string.Empty;
                        DisableButtonsExceptAllowed();
                        return;
                    }
                    else
                    {
                        newResult /= operandToUse;
                    }
                    break;
            }
            result = newResult;
            txt_DisplayResult1.Text = result.ToString();
            operation = string.Empty; 
            enterValue = true;
            string historyEntry = $"{txt_DisplayResult2.Text} {txt_DisplayResult1.Text}";
            History_list.Add(historyEntry);
            History.Items.Add(historyEntry);
        }
    }
}
