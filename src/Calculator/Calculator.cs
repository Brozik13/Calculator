/**
 * @file Calculator.cs
 * @author Ondřej Broža
 * @author Lucia Cengelová
 * 
 * @brief Soubor implementuje namespace Calculator.
 */

using System.Diagnostics;

/**
 * @brief Namespace, který implementuje třídu Calculator.
 */
namespace Calculator
{
    /**
     * @brief Třída,která implementuje funkce starající se o komunikaci s uživatelským rozhraním.
     */
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            tooltip();
        }
        //----------Number Buttons START -------------------
        //----------Button1 START -------
        private void button1_Click(object sender, EventArgs e)
        {
            Workplace.Text = Workplace.Text + "1";

        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(6, 82, 221);
            button1.Size = new Size(100, 100);
            //         button1.Location = new Point(36, 181);
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(140, 122, 230);
            button1.Size = new Size(102, 102);
            //        button1.Location = new Point(35, 180);
        }
        //----------Button1 END -------
        //----------Button2 START -------
        private void button2_Click(object sender, EventArgs e)
        {
            Workplace.Text = Workplace.Text + "2";
        }
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(6, 82, 221);
            button2.Size = new Size(100, 100);
            //       button2.Location = new Point(156, 181);
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(140, 122, 230);
            button2.Size = new Size(102, 102);
            //      button2.Location = new Point(155, 180);
        }
        //----------Button2 END -------
        //----------Button3 START -------
        private void button3_Click(object sender, EventArgs e)
        {
            Workplace.Text = Workplace.Text + "3";
        }
        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(6, 82, 221);
            button3.Size = new Size(100, 100);
            //       button3.Location = new Point(276, 181);
        }
        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(140, 122, 230);
            button3.Size = new Size(102, 102);
            //      button3.Location = new Point(275, 180);
        }
        //----------Button3 END -------
        //----------Button4 START -------
        private void button4_Click(object sender, EventArgs e)
        {
            Workplace.Text = Workplace.Text + "4";
        }
        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(6, 82, 221);
            button4.Size = new Size(100, 100);
            //     button4.Location = new Point(36, 301);
        }
        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(140, 122, 230);
            button4.Size = new Size(102, 102);
            //     button4.Location = new Point(35, 300);
        }
        //----------Button4 END -------
        //----------Button5 START -------
        private void button5_Click(object sender, EventArgs e)
        {
            Workplace.Text = Workplace.Text + "5";
        }
        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(6, 82, 221);
            button5.Size = new Size(100, 100);
            //     button5.Location = new Point(156, 301);
        }
        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(140, 122, 230);
            button5.Size = new Size(102, 102);
            //     button5.Location = new Point(155, 300);
        }
        //----------Button5 END -------
        //----------Button6 START -------
        private void button6_Click(object sender, EventArgs e)
        {
            Workplace.Text = Workplace.Text + "6";
        }
        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.BackColor = Color.FromArgb(6, 82, 221);
            button6.Size = new Size(100, 100);
            //      button6.Location = new Point(276, 301);
        }
        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.FromArgb(140, 122, 230);
            button6.Size = new Size(102, 102);
            //      button6.Location = new Point(275, 300);
        }
        //----------Button6 END -------
        //----------Button7 START -------
        private void button7_Click(object sender, EventArgs e)
        {
            Workplace.Text = Workplace.Text + "7";
        }
        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button7.BackColor = Color.FromArgb(6, 82, 221);
            button7.Size = new Size(100, 100);
            //      button7.Location = new Point(36, 421);
        }
        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = Color.FromArgb(140, 122, 230);
            button7.Size = new Size(102, 102);
            //       button7.Location = new Point(35, 420);
        }
        //----------Button7 END -------
        //----------Button8 START -------
        private void button8_Click(object sender, EventArgs e)
        {
            Workplace.Text = Workplace.Text + "8";
        }
        private void button8_MouseEnter(object sender, EventArgs e)
        {
            button8.BackColor = Color.FromArgb(6, 82, 221);
            button8.Size = new Size(100, 100);
            //       button8.Location = new Point(156, 421);
        }
        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.BackColor = Color.FromArgb(140, 122, 230);
            button8.Size = new Size(102, 102);
            //       button8.Location = new Point(155, 420);
        }
        //----------Button8 END -------
        //----------Button9 START -------
        private void button9_Click(object sender, EventArgs e)
        {
            Workplace.Text = Workplace.Text + "9";
        }
        private void button9_MouseEnter(object sender, EventArgs e)
        {
            button9.BackColor = Color.FromArgb(6, 82, 221);
            button9.Size = new Size(100, 100);
            //       button9.Location = new Point(276, 421);
        }
        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.BackColor = Color.FromArgb(140, 122, 230);
            button9.Size = new Size(102, 102);
            //       button9.Location = new Point(275, 420);
        }
        //----------Button9 END -------
        //----------Button10 START -------
        private void button10_Click(object sender, EventArgs e)
        {
            Workplace.Text = Workplace.Text + "0";
        }
        private void button10_MouseEnter(object sender, EventArgs e)
        {
            button10.BackColor = Color.FromArgb(6, 82, 221);
            button10.Size = new Size(220, 100);
            //      button10.Location = new Point(36, 541);
        }
        private void button10_MouseLeave(object sender, EventArgs e)
        {
            button10.BackColor = Color.FromArgb(140, 122, 230);
            button10.Size = new Size(222, 102);
            //     button10.Location = new Point(35, 540);
        }
        //----------Button10 END -------
        //----------Separator START -------
        private void Separator_Click(object sender, EventArgs e)
        {
            Workplace.Text = Workplace.Text + ",";
        }
        private void Separator_MouseEnter(object sender, EventArgs e)
        {
            Separator.BackColor = Color.FromArgb(6, 82, 221);
            Separator.Size = new Size(100, 100);
            //    Separator.Location = new Point(276, 541);

        }
        private void Separator_MouseLeave(object sender, EventArgs e)
        {
            Separator.BackColor = Color.FromArgb(140, 122, 230);
            Separator.Size = new Size(102, 102);
            //    Separator.Location = new Point(275, 540);
        }
        //----------Separator END -------
        //----------Number Buttons END -------------------



        //---------------Options START--------------------
        private void Help_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            Process.Start("notepad.exe", "Users_guide.txt");
        }

        private void Addition_Click(object sender, EventArgs e)
        {
            Workplace.Text = Workplace.Text + "+";
        }

        private void Subtraction_Click(object sender, EventArgs e)
        {
            Workplace.Text = Workplace.Text + "-";
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            Workplace.Text = Workplace.Text + "*";
        }

        private void Division_Click(object sender, EventArgs e)
        {
            Workplace.Text = Workplace.Text + "/";
        }

        private void Factorial_Click(object sender, EventArgs e)
        {
            Workplace.Text = Workplace.Text + "!";
        }

        private void Power_Click(object sender, EventArgs e)
        {
            Workplace.Text = Workplace.Text + "^(";
        }

        private void Root_Click(object sender, EventArgs e)
        {
            Workplace.Text = Workplace.Text + "r(";
        }

        private void Logarithm_Click(object sender, EventArgs e)
        {
            Workplace.Text = Workplace.Text + "l(";
        }

        private void BracketLeft_Click(object sender, EventArgs e)
        {
            Workplace.Text = Workplace.Text + "(";
        }

        private void BracketRight_Click(object sender, EventArgs e)
        {
            Workplace.Text = Workplace.Text + ")";
        }



        private void Addition_MouseEnter(object sender, EventArgs e)
        {
            Addition.BackColor = Color.FromArgb(53, 111, 137);
            Addition.Size = new Size(100, 100);
        }

        private void Addition_MouseLeave(object sender, EventArgs e)
        {
            Addition.BackColor = Color.FromArgb(72, 126, 176);
            Addition.Size = new Size(102, 102);
        }

        private void Multiplication_MouseEnter(object sender, EventArgs e)
        {
            Multiplication.BackColor = Color.FromArgb(53, 111, 137);
            Multiplication.Size = new Size(100, 100);
        }

        private void Multiplication_MouseLeave(object sender, EventArgs e)
        {
            Multiplication.BackColor = Color.FromArgb(72, 126, 176);
            Multiplication.Size = new Size(102, 102);
        }

        private void Subtraction_MouseEnter(object sender, EventArgs e)
        {
            Subtraction.BackColor = Color.FromArgb(53, 111, 137);
            Subtraction.Size = new Size(100, 100);
        }

        private void Subtraction_MouseLeave(object sender, EventArgs e)
        {
            Subtraction.BackColor = Color.FromArgb(72, 126, 176);
            Subtraction.Size = new Size(102, 102);
        }

        private void Division_MouseEnter(object sender, EventArgs e)
        {
            Division.BackColor = Color.FromArgb(53, 111, 137);
            Division.Size = new Size(100, 100);
        }

        private void Division_MouseLeave(object sender, EventArgs e)
        {
            Division.BackColor = Color.FromArgb(72, 126, 176);
            Division.Size = new Size(102, 102);
        }

        private void BracketRight_MouseEnter(object sender, EventArgs e)
        {
            BracketRight.BackColor = Color.FromArgb(53, 111, 137);
            BracketRight.Size = new Size(100, 100);
        }

        private void BracketRight_MouseLeave(object sender, EventArgs e)
        {
            BracketRight.BackColor = Color.FromArgb(72, 126, 176);
            BracketRight.Size = new Size(102, 102);
        }

        private void BracketLeft_MouseEnter(object sender, EventArgs e)
        {
            BracketLeft.BackColor = Color.FromArgb(53, 111, 137);
            BracketLeft.Size = new Size(100, 100);
        }

        private void BracketLeft_MouseLeave(object sender, EventArgs e)
        {
            BracketLeft.BackColor = Color.FromArgb(72, 126, 176);
            BracketLeft.Size = new Size(102, 102);
        }

        private void Logarithm_MouseEnter(object sender, EventArgs e)
        {
            Logarithm.BackColor = Color.FromArgb(53, 111, 137);
            Logarithm.Size = new Size(220, 100);
        }

        private void Logarithm_MouseLeave(object sender, EventArgs e)
        {
            Logarithm.BackColor = Color.FromArgb(72, 126, 176);
            Logarithm.Size = new Size(222, 102);
        }

        private void Power_MouseEnter(object sender, EventArgs e)
        {
            Power.BackColor = Color.FromArgb(53, 111, 137);
            Power.Size = new Size(100, 100);
        }

        private void Power_MouseLeave(object sender, EventArgs e)
        {
            Power.BackColor = Color.FromArgb(72, 126, 176);
            Power.Size = new Size(102, 102);
        }

        private void Root_MouseEnter(object sender, EventArgs e)
        {
            Root.BackColor = Color.FromArgb(53, 111, 137);
            Root.Size = new Size(100, 100);
        }

        private void Root_MouseLeave(object sender, EventArgs e)
        {
            Root.BackColor = Color.FromArgb(72, 126, 176);
            Root.Size = new Size(102, 102);
        }

        private void Factorial_MouseEnter(object sender, EventArgs e)
        {
            Factorial.BackColor = Color.FromArgb(53, 111, 137);
            Factorial.Size = new Size(100, 100);
        }

        private void Factorial_MouseLeave(object sender, EventArgs e)
        {
            Factorial.BackColor = Color.FromArgb(72, 126, 176);
            Factorial.Size = new Size(102, 102);
        }


        //---------------Options END------------------------

        //---------Workplace Management START---------------
        private void StepBack_Click(object sender, EventArgs e)
        {
            fnc_stepback();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            fnc_clear();
        }

        private void StartTyping_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            fnc_submit();
        }

        private void StepBack_MouseEnter(object sender, EventArgs e)
        {
            StepBack.BackColor = Color.FromArgb(216, 44, 0);
            StepBack.Size = new Size(220, 100);
        }

        private void StepBack_MouseLeave(object sender, EventArgs e)
        {
            StepBack.BackColor = Color.FromArgb(232, 65, 24);
            StepBack.Size = new Size(222, 102);
        }

        private void Clear_MouseEnter(object sender, EventArgs e)
        {
            Clear.BackColor = Color.FromArgb(216, 44, 0);
            Clear.Size = new Size(100, 100);
        }

        private void Clear_MouseLeave(object sender, EventArgs e)
        {
            Clear.BackColor = Color.FromArgb(232, 65, 24);
            Clear.Size = new Size(102, 102);
        }

        private void Submit_MouseEnter(object sender, EventArgs e)
        {
            Submit.BackColor = Color.FromArgb(175, 180, 43);
            Submit.Size = new Size(100, 220);
        }

        private void Submit_MouseLeave(object sender, EventArgs e)
        {
            Submit.BackColor = Color.FromArgb(251, 197, 49);
            Submit.Size = new Size(102, 222);
        }

























        private void Workplace_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Int32)Keys.Enter)
            {
                fnc_submit();
            }
            if (e.KeyChar == (Int32)Keys.Back)
            {
                fnc_stepback();
            }
            if (e.KeyChar == (Int32)Keys.Escape)
            {
                fnc_clear();
            }

            char input = (char)e.KeyChar;
            bool correctinput = (input == '0') || (input == '1') || (input == '2') ||
                                (input == '3') || (input == '4') || (input == '5') ||
                                (input == '6') || (input == '7') || (input == '8') || (input == '9') ||
                                (input == '+') || (input == '-') || (input == '*') || (input == '/') ||
                                (input == '(') || (input == ')') || (input == '^') ||
                                (input == '!') || (input == ',') || (input == 'r') || (input == 'l')
                                ;

            if (correctinput)
            {
                e.Handled = true;
                string inputstr = char.ToString(input);
                Workplace.Text = Workplace.Text + inputstr;
            }
            else
            {
                e.Handled = false;
            }
        }
        //---------Workplace Management END---------------

        //--------------------Funtions START--------------------
        void fnc_submit()
        {

            Workplace.Text = ("" + Compiler.Compiler.Compile(Workplace.Text) + "");



        }
        void fnc_stepback()
        {
            if (Workplace.Text.Length > 0)
            {
                Workplace.Text = Workplace.Text.Remove(Workplace.Text.Length - 1, 1);

            }
        }
        void fnc_clear()
        {
            Workplace.Clear();
        }
        //--------------------Funtions END--------------------


        //--------------------ToolTips START--------------------

        private void tooltip()
        {
            ToolTip TipSeparator = toolTipSeparator;
            TipSeparator.SetToolTip(Separator, "Syntax:  10,25" + "\nPress F1 for more info");
            ToolTip TipAddition = toolTipAddition;
            TipAddition.SetToolTip(Addition, "Syntax:  2+2" + "\nPress F1 for more info");
            ToolTip TipSubtraction = toolTipSubtraction;
            TipSubtraction.SetToolTip(Subtraction, "Syntax:  2-2" + "\nPress F1 for more info");
            ToolTip TipDivision = toolTipDivision;
            TipDivision.SetToolTip(Division, "Syntax:  2/2" + "\nPress F1 for more info");
            ToolTip TipMultiplication = toolTipMultiplication;
            TipMultiplication.SetToolTip(Multiplication, "Syntax:  2*3" + "\nPress F1 for more info");
            ToolTip TipBracketLeft = toolTipBracketLeft;
            TipBracketLeft.SetToolTip(BracketLeft, "Syntax:  (2+2)" + "\nPress F1 for more info");
            ToolTip TipBracketRight = toolTipBracketRight;
            TipBracketRight.SetToolTip(BracketRight, "Syntax:  (2+2)" + "\nPress F1 for more info");
            ToolTip TipPower = toolTipPower;
            TipPower.SetToolTip(Power, "Syntax:  2^(3) -> 8" + "\nPress F1 for more info");
            ToolTip TipRoot = toolTipRoot;
            TipRoot.SetToolTip(Root, "Syntax:  2r(9) -> 3" + "\nPress F1 for more info");
            ToolTip TipLogarithm = toolTipLogarithm;
            TipLogarithm.SetToolTip(Logarithm, "Syntax:  10l(100) -> 2" + "\nPress F1 for more info");
            ToolTip TipFactorial = toolTipFactorial;
            TipFactorial.SetToolTip(Factorial, "Syntax: 5!" + "\nPress F1 for more info");
            ToolTip TipStepBack = toolTipStepBack;
            TipStepBack.SetToolTip(StepBack, "Deletes last character" + "\nPress F1 for more info");
            ToolTip TipClear = toolTipClear;
            TipClear.SetToolTip(Clear, "Deletes everything from workplace" + "\nPress F1 for more info");
            ToolTip TipSubmit = toolTipSubmit;
            TipSubmit.SetToolTip(Submit, "Gives result" + "\nPress F1 for more info");
            ToolTip TipHelp = toolTipHelp;
            TipHelp.SetToolTip(Help, "Click to access full guide");

        }


    }
}