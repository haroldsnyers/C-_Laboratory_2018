using computer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorViewer
{
    public partial class Form1 : Form
    {   
        // Initialization dictionnary -> before else, can be accessed everywhere 
        Dictionary<String, String> compute = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
            // stores every line of the config file in an array
            string[] lines = System.IO.File.ReadAllLines(@"..\..\Config.txt");

            // go through each line and add elem to dictionnary
            // key is operation symbol and value is PATH to dll of that operation
            foreach (String elem in lines)
            {
                string[] dll = elem.Split(' ');
                compute[dll.First()] = dll.Last();
            }
        }

        // This part needs some improvement if we want to do an operation with more than 2 numbers
        // first thing we could do is to make a list of each number
        // then apply polonees method of calculator to do the operations
        private void Compute_Click(object sender, EventArgs e)
        {
            // precondition : between every operation symbol and number --> space
            string[] data = textBox1.Text.Split(' ');
            foreach(String elem in data)
            {
                // takes the elem of data that is the operant
                if (compute.ContainsKey(elem))
                {
                    // loading file from path
                    Assembly dll = Assembly.LoadFile(compute[elem]);
                    Type type = dll.GetExportedTypes()[0];

                    // creates instances for the specific operation
                    Computer o = (Computer)Activator.CreateInstance(type);
                    double A = Convert.ToDouble(data.First());
                    double B = Convert.ToDouble(data.Last());

                    double result = o.Compute(A, B);
                    string resultS = result.ToString();
                    label1.Text = label1.Text + ">> " + textBox1.Text + "\n" + resultS + "\n";
                } 
            }
            textBox1.Text = String.Empty;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
