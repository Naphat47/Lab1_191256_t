namespace Lab1_191256_2
{
    public partial class answer1 : Form
    {
        //class variable
        double input1 = 0;
        string paretion = "";
        public answer1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // assign string value to textbox

            string number1 = this.num1.Text;
            string number2 = this.num2.Text;
            double dnumber1 = 0.0;
            double dnumber2 = 0.0;

            //convert string to double

            dnumber1 = Double.Parse(number1);
            dnumber2 = Double.Parse(number2);

            double result = (dnumber1 + dnumber2);
            this.answer.Text = result.ToString();

        }
        private void ans_TextChanged(object sender, EventArgs e)
        {

        }

        private void answer1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.tb_Input.Text = this.tb_Input.Text + "9";
            this.Process.Text = this.Process.Text + "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.tb_Input.Text = this.tb_Input.Text + "8";
            this.Process.Text = this.Process.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.tb_Input.Text = this.tb_Input.Text + "7";
            this.Process.Text = this.Process.Text + "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.tb_Input.Text = this.tb_Input.Text + "6";
            this.Process.Text = this.Process.Text + "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.tb_Input.Text = this.tb_Input.Text + "5";
            this.Process.Text = this.Process.Text + "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.tb_Input.Text = this.tb_Input.Text + "4";
            this.Process.Text = this.Process.Text + "4";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.tb_Input.Text = this.tb_Input.Text + "3";
            this.Process.Text = this.Process.Text + "3";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.tb_Input.Text = this.tb_Input.Text + "2";
            this.Process.Text = this.Process.Text + "2";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.tb_Input.Text = this.tb_Input.Text + "1";
            this.Process.Text = this.Process.Text + "1";
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            this.tb_Input.Text = this.tb_Input.Text + "0";
            this.Process.Text = this.Process.Text + "0";

        }

        private void button17_Click(object sender, EventArgs e)
        {
            //assign value to class variable
            this.input1 = double.Parse(this.tb_Input.Text);
            //clear input.Text 
            this.tb_Input.Text = "";
            this.paretion = "+";
            this.Process.Text = this.Process.Text + " +";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double input2 = Double.Parse(this.tb_Input.Text);
            double result = 0;
            if (this.paretion == "+")
            {
                result = input1 + input2;
            }
            else if(this.paretion == "-")
            {
                result = input1 - input2;
            }
            else if (this.paretion == "*")
            {
                result = input1 * input2;
            }
            else if (this.paretion == "/")
            {
                result = input1 / input2;
            }
            this.tb_Input.Text = result.ToString();
            this.Process.Text = this.Process.Text + " =";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.input1 = double.Parse(this.tb_Input.Text);
            this.tb_Input.Text = "";
            this.paretion = "-";
            this.Process.Text = this.Process.Text + " -";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.input1 = double.Parse(this.tb_Input.Text);
            this.tb_Input.Text = "";
            this.paretion = "*";
            this.Process.Text = this.Process.Text + " *";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.input1 = double.Parse(this.tb_Input.Text);
            this.tb_Input.Text = "";
            this.paretion = "/";
            this.Process.Text = this.Process.Text + " /";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tb_Input.Text = "";
            this.Process.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.tb_Input.Text = this.tb_Input.Text + ".";
            this.Process.Text = this.Process.Text + ".";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.tb_Input.Text = this.tb_Input.Text + ",";
            this.Process.Text = this.Process.Text + ",";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.tb_Input.Text = this.tb_Input.Text + " ";
            this.Process.Text = this.Process.Text + " ";
        }
    }
}
