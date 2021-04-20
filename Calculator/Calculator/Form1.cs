using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private string[] valuearray = new string[2];

        
        private int flagplus = 0;
        private int flagminus = 0;
        private int flagmultiplicaton = 0;
        private int flagdevide = 0;
        private int flagequal = 0;
        private int flagdecimal = 0;
        private int PlusorMinus = 0;
        private int nooperators = 1;
        
        private int cannotdividebyzero = 0;

        private double internalvalue = 0;
        string filepath = "";

       

        public Form1()
        {
           
            InitializeComponent();
            filepath = Application.StartupPath; // will get the filepath where the programme is currently installed on.
            filepath += @"\logCalculator.txt";
            if (!File.Exists(filepath))
            {
                File.Create(filepath);
            }

            string str = File.ReadAllText(filepath);

            if(str.Contains("Black"))
            {
                BackColor = Color.Black;
                Darkmode.Text = "Light";
            }
            else if(str.Contains("White"))
            {
                BackColor = Color.White;
            }
         // Icon newicon = Icon.ExtractAssociatedIcon(@"E:\c# app\Calculator\Calculator\image1.bmp");
          //  Icon = newicon;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void MaskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(flagequal>=1)
            {
                ClearButton();
                
            }
            nooperators = 0;
            if (cannotdividebyzero == 1)
            {
                inputbox.Clear();
                inputboxinsider.Clear();
                enabledButton();
                cannotdividebyzero = 0;
                valuearray[0] = null;
            }
            double one = 1;
            inputbox.Text += Convert.ToString(one);
        } // 1

        private void Button2_Click(object sender, EventArgs e)
        {
            if (flagequal >= 1)
            {
                ClearButton();
              
            }
            nooperators = 0;
            if (cannotdividebyzero == 1)
            {
                inputbox.Clear();
                inputboxinsider.Clear();
                enabledButton();
                cannotdividebyzero = 0;
                valuearray[0] = null;
            }
            double two = 2;
            inputbox.Text += Convert.ToString(two);
        } // 2

        private void Button3_Click(object sender, EventArgs e)
        {
            if (flagequal >= 1)
            {
                ClearButton();
            }
            nooperators = 0;
            if (cannotdividebyzero == 1)
            {
                inputbox.Clear();
                inputboxinsider.Clear();
                enabledButton();
                cannotdividebyzero = 0;
                valuearray[0] = null;
            }
            double three = 3;
            inputbox.Text += Convert.ToString(three);
        }  // 3

        private void Button4_Click(object sender, EventArgs e)
        {
            if (flagequal >= 1)
            {
                ClearButton();
            }
            nooperators = 0;
            if (cannotdividebyzero == 1)
            {
                inputbox.Clear();
                inputboxinsider.Clear();
                enabledButton();
                cannotdividebyzero = 0;
                valuearray[0] = null;
            }
            double four = 4;
            inputbox.Text += Convert.ToString(four);
        } // 4

        private void Button5_Click(object sender, EventArgs e)
        {
            if (flagequal >= 1)
            {
                ClearButton();
            }
            nooperators = 0;
            if (cannotdividebyzero == 1)
            {
                inputbox.Clear();
                inputboxinsider.Clear();
                enabledButton();
                cannotdividebyzero = 0;
                valuearray[0] = null;
            }
            double five = 5;
            inputbox.Text += Convert.ToString(five);
        } // 5

        private void Button6_Click(object sender, EventArgs e)
        {
            if (flagequal >= 1)
            {
                ClearButton();
            }
            nooperators = 0;
            if (cannotdividebyzero == 1)
            {
                inputbox.Clear();
                inputboxinsider.Clear();
                enabledButton();
                cannotdividebyzero = 0;
                valuearray[0] = null;
            }
            double six = 6;
            inputbox.Text += Convert.ToString(six);
        } // 6

        private void Button7_Click(object sender, EventArgs e)
        {
            if (flagequal >= 1)
            {
                ClearButton();
            }
            nooperators = 0;
            if (cannotdividebyzero == 1)
            {
                inputbox.Clear();
                inputboxinsider.Clear();
                enabledButton();
                cannotdividebyzero = 0;
                valuearray[0] = null;
            }
            double seven = 7;
            inputbox.Text += Convert.ToString(seven);
        } // 7 

        private void Button8_Click(object sender, EventArgs e)
        {
            if (flagequal >= 1)
            {
                ClearButton();
            }
            nooperators = 0;
            if (cannotdividebyzero == 1)
            {
                inputbox.Clear();
                inputboxinsider.Clear();
                enabledButton();
                cannotdividebyzero = 0;
                valuearray[0] = null;
            }
            double eight = 8;
            inputbox.Text += Convert.ToString(eight);
        } // 8

        private void Button9_Click(object sender, EventArgs e)
        {
            if (flagequal >= 1)
            {
                ClearButton();
            }
            nooperators = 0;
            if (cannotdividebyzero == 1)
            {
                inputbox.Clear();
                inputboxinsider.Clear();
                enabledButton();
                cannotdividebyzero = 0;
                valuearray[0] = null;
            }
            double nine = 9;
            inputbox.Text += Convert.ToString(nine);
        } // 9 

        private void Button11_Click(object sender, EventArgs e)
        {
            if (flagequal >= 1)
            {
                ClearButton();
            }
            nooperators = 0;
            if (cannotdividebyzero == 1)
            {
                inputbox.Clear();
                inputboxinsider.Clear();
                enabledButton();
                cannotdividebyzero = 0;
                valuearray[0] = null;
            }
            double zero = 0;
            inputbox.Text += Convert.ToString(zero);
        } // 0

        private void Button13_Click(object sender, EventArgs e) // + button
        {
            
           if(nooperators==0)
            {
                // inputbox.Clear();
                flagplus += 1;
                incompletedecimal();
                flagdecimal = 0;
                if (valuearray[0] == null)
                {
                    valuearray[0] = inputbox.Text;
                    inputboxinsider.Text = inputbox.Text + "+";
                    inputbox.Clear();
                }
                else if (valuearray[0] != null && inputbox.Text != null && flagequal == 0 && flagplus > 1) // Countinius pressing +
                {

                    inputboxinsider.Text += inputbox.Text + "+";
                    internalvalue = Convert.ToDouble(inputbox.Text);
                    internalvalue += Convert.ToDouble(valuearray[0]);
                    valuearray[0] = Convert.ToString(internalvalue);
                    //flagplus = 0;
                    inputbox.Clear();
                }
                else if (valuearray[0] != null && inputbox.Text != null && flagminus > 0) // + after a -
                {
                    inputboxinsider.Text += inputbox.Text + "+";
                    internalvalue = Convert.ToDouble(inputbox.Text);
                    //internalvalue -= Convert.ToDouble(valuearray[0]);
                    internalvalue = Convert.ToDouble(valuearray[0]) - internalvalue;
                    valuearray[0] = Convert.ToString(internalvalue);
                    flagminus = 0;
                    inputbox.Clear();
                }
                else if (valuearray[0] != null && inputbox.Text != null && flagdevide > 0) // + after a /
                {
                    inputboxinsider.Text += inputbox.Text + "+";
                    internalvalue = Convert.ToDouble(inputbox.Text);
                    internalvalue = Convert.ToDouble(valuearray[0]) / internalvalue;
                    valuearray[0] = Convert.ToString(internalvalue);
                    flagdevide = 0;
                    inputbox.Clear();
                }
                else if (valuearray[0] != null && inputbox.Text != null && flagmultiplicaton > 0) // + after a *
                {
                    inputboxinsider.Text += inputbox.Text + "+";
                    internalvalue = Convert.ToDouble(inputbox.Text);
                    internalvalue *= Convert.ToDouble(valuearray[0]);
                    valuearray[0] = Convert.ToString(internalvalue);
                    flagmultiplicaton = 0;
                    inputbox.Clear();
                }
                else if (valuearray[0] != null && flagequal > 0) // doing + then = then + again
                {
                    ispressedEqual();
                }
            }
        }

        private void Button17_Click(object sender, EventArgs e) // = button
        {
            double value =0;
            flagequal += 1;
            incompletedecimal();
            flagdecimal = 0;
            if (valuearray[0]!=null && cannotdividebyzero==0)
            {
                value = Convert.ToDouble(valuearray[0]);
                Addition(value);
            }
            if(valuearray[0]!= null && cannotdividebyzero == 0)
            {
                value = Convert.ToDouble(valuearray[0]);
                subtraction(value);
            }
            if(valuearray[0] !=null && cannotdividebyzero == 0)
            {
                value = Convert.ToDouble(valuearray[0]);
                multiplication(value);
            }
            if(valuearray[0]!=null && cannotdividebyzero == 0)
            {
                value = Convert.ToDouble(valuearray[0]);
                devition(value);
            }
           else if (cannotdividebyzero == 1)
           {
                inputbox.Clear();
                inputboxinsider.Clear();
                enabledButton();
                cannotdividebyzero = 0;
                valuearray[0] = null;
           }
            
        }

        private void Button19_Click(object sender, EventArgs e) // clear button
        {
            ClearButton();
        }

        private void Button14_Click(object sender, EventArgs e)  // - button
        {
            if(nooperators==0)
            {
                flagminus += 1;
                incompletedecimal();
                flagdecimal = 0;
                if (valuearray[0] == null)
                {
                    valuearray[0] = inputbox.Text;
                    inputboxinsider.Text = inputbox.Text + "-";
                    inputbox.Clear();
                }
                else if (valuearray[0] != null && inputbox.Text != null && flagequal == 0 && flagminus > 1) //continuius -
                {
                    inputboxinsider.Text += inputbox.Text + "-";
                    internalvalue = Convert.ToDouble(inputbox.Text);
                    //internalvalue -= Convert.ToDouble(valuearray[0]);
                    internalvalue = Convert.ToDouble(valuearray[0]) - internalvalue;
                    valuearray[0] = Convert.ToString(internalvalue);

                    inputbox.Clear();


                }
                else if (valuearray[0] != null && inputbox.Text != null && flagplus > 0) // - after +
                {
                    inputboxinsider.Text += inputbox.Text + "-";
                    internalvalue = Convert.ToDouble(inputbox.Text);
                    internalvalue += Convert.ToDouble(valuearray[0]);
                    valuearray[0] = Convert.ToString(internalvalue);
                    flagplus = 0;
                    inputbox.Clear();
                }
                else if (valuearray[0] != null && inputbox.Text != null && flagmultiplicaton > 0) // - after *
                {
                    inputboxinsider.Text += inputbox.Text + "-";
                    internalvalue = Convert.ToDouble(inputbox.Text);
                    internalvalue *= Convert.ToDouble(valuearray[0]);
                    valuearray[0] = Convert.ToString(internalvalue);
                    flagmultiplicaton = 0;
                    inputbox.Clear();
                }
                else if (valuearray[0] != null && inputbox.Text != null && flagdevide > 0) // - after /
                {
                    inputboxinsider.Text += inputbox.Text + "-";
                    internalvalue = Convert.ToDouble(inputbox.Text);
                    //internalvalue /= Convert.ToDouble(valuearray[0]);
                    internalvalue = Convert.ToDouble(valuearray[0]) / internalvalue;
                    valuearray[0] = Convert.ToString(internalvalue);
                    flagdevide = 0;
                    inputbox.Clear();
                }
                else if (valuearray[0] != null && flagequal > 0)
                {
                    ispressedEqual();
                }
            }
        }

       
        private void Button15_Click(object sender, EventArgs e) // x button
        {
            if(nooperators==0)
            {
                flagmultiplicaton += 1;
                incompletedecimal();
                flagdecimal = 0;
                if (valuearray[0] == null && nooperators == 0)
                {
                    valuearray[0] = inputbox.Text;
                    inputboxinsider.Text = inputbox.Text + "x";
                    inputbox.Clear();
                }
                else if (valuearray[0] != null && inputbox.Text != null && flagequal == 0 && flagmultiplicaton > 1) // continius *
                {
                    inputboxinsider.Text += inputbox.Text + "x";
                    internalvalue = Convert.ToDouble(inputbox.Text);
                    internalvalue *= Convert.ToDouble(valuearray[0]);
                    valuearray[0] = Convert.ToString(internalvalue);

                    inputbox.Clear();


                }
                else if (valuearray[0] != null && inputbox.Text != null && flagplus > 0) // * after plus
                {
                    inputboxinsider.Text += inputbox.Text + "x";
                    internalvalue = Convert.ToDouble(inputbox.Text);
                    internalvalue += Convert.ToDouble(valuearray[0]);
                    valuearray[0] = Convert.ToString(internalvalue);
                    flagplus = 0;
                    inputbox.Clear();
                }
                else if (valuearray[0] != null && inputbox.Text != null && flagminus > 0) // * after -
                {
                    inputboxinsider.Text += inputbox.Text + "x";
                    internalvalue = Convert.ToDouble(inputbox.Text);
                    internalvalue = Convert.ToDouble(valuearray[0]) - internalvalue;
                    valuearray[0] = Convert.ToString(internalvalue);
                    flagminus = 0;
                    inputbox.Clear();
                }
                else if (valuearray[0] != null && inputbox.Text != null && flagdevide > 0) // * after /
                {
                    inputboxinsider.Text += inputbox.Text + "x";
                    internalvalue = Convert.ToDouble(inputbox.Text);
                    //internalvalue /= Convert.ToDouble(valuearray[0]);
                    internalvalue = Convert.ToDouble(valuearray[0]) / internalvalue;
                    valuearray[0] = Convert.ToString(internalvalue);
                    flagdevide = 0;
                    inputbox.Clear();
                }
                else if (valuearray[0] != null && flagequal > 0)
                {
                    ispressedEqual();
                }
            }
        }


        private void Button16_Click(object sender, EventArgs e) // / button
        {
           if(nooperators==0)
            {
                flagdevide += 1;
                incompletedecimal();
                flagdecimal = 0;
                if (valuearray[0] == null && nooperators == 0)
                {
                    valuearray[0] = inputbox.Text;
                    inputboxinsider.Text = inputbox.Text + "/";
                    inputbox.Clear();
                }
                else if (valuearray[0] != null && inputbox.Text != null && flagequal == 0 && flagdevide > 1) // continius /
                {
                    inputboxinsider.Text += inputbox.Text + "/";
                    internalvalue = Convert.ToDouble(inputbox.Text);
                    //internalvalue /= Convert.ToDouble(valuearray[0]);
                    internalvalue = Convert.ToDouble(valuearray[0]) / internalvalue;
                    valuearray[0] = Convert.ToString(internalvalue);

                    inputbox.Clear();


                }
                else if (valuearray[0] != null && inputbox.Text != null && flagplus > 0) // / after +
                {
                    inputboxinsider.Text += inputbox.Text + "/";
                    internalvalue = Convert.ToDouble(inputbox.Text);
                    internalvalue += Convert.ToDouble(valuearray[0]);
                    valuearray[0] = Convert.ToString(internalvalue);
                    flagplus = 0;
                    inputbox.Clear();
                }
                else if (valuearray[0] != null && inputbox.Text != null && flagminus > 0)  // / after -
                {
                    inputboxinsider.Text += inputbox.Text + "/";
                    internalvalue = Convert.ToDouble(inputbox.Text);
                    //internalvalue -= Convert.ToDouble(valuearray[0]);
                    internalvalue = Convert.ToDouble(valuearray[0]) - internalvalue;
                    valuearray[0] = Convert.ToString(internalvalue);
                    flagminus = 0;
                    inputbox.Clear();
                }
                else if (valuearray[0] != null && inputbox.Text != null && flagmultiplicaton > 0) // / after *
                {
                    inputboxinsider.Text += inputbox.Text + "/";
                    internalvalue = Convert.ToDouble(inputbox.Text);
                    internalvalue *= Convert.ToDouble(valuearray[0]);
                    valuearray[0] = Convert.ToString(internalvalue);
                    flagmultiplicaton = 0;
                    inputbox.Clear();
                }
                else if (valuearray[0] != null && flagequal > 0)
                {
                    ispressedEqual();
                }
            }
        }


        private void Addition(double value) // For doing addition
        {
            if (flagplus >= 1)
            {
                value += Convert.ToDouble(inputbox.Text);
                inputboxinsider.Text += inputbox.Text + "=";
                inputbox.Clear();
                inputbox.Text = Convert.ToString(value);
                valuearray[0] = Convert.ToString(value);
                flagplus = 0;
            }
        }

        private void subtraction(double value) // For doing subtraction
        {
            if (flagminus >= 1)
            {
                value -= Convert.ToDouble(inputbox.Text);
                inputboxinsider.Text += inputbox.Text + "=";
                inputbox.Clear();
                inputbox.Text = Convert.ToString(value);
                valuearray[0] = Convert.ToString(value);
                flagminus = 0;
            }
        }

        private void multiplication(double value) // For doing Multiplication
        {
            if (flagmultiplicaton >= 1)
            {
                value *= Convert.ToDouble(inputbox.Text);
                inputboxinsider.Text += inputbox.Text + "=";
                inputbox.Clear();
                inputbox.Text = Convert.ToString(value);
                valuearray[0] = Convert.ToString(value);
                flagmultiplicaton = 0;
            }
        }

        private void devition(double value)  // fOR doing Divition
        {
            if (flagdevide >= 1)
            {
                if(Convert.ToDouble(inputbox.Text)!=0)
                {
                    value /= Convert.ToDouble(inputbox.Text);
                    inputboxinsider.Text += inputbox.Text + "=";
                    inputbox.Clear();
                    inputbox.Text = Convert.ToString(value);
                    valuearray[0] = Convert.ToString(value);
                    flagdevide = 0;
                }
                else
                {
                    inputbox.Clear();
                    cannotdividebyzero = 1;
                    inputbox.ReadOnly = true;
                    inputbox.Text = "Can't Divide By Zero";
                    disabledButtons();
                    flagdevide = 0;
                    
                }
            }
        }

        private void ispressedEqual()
        {
            inputbox.Clear();
            inputboxinsider.Clear();
            if(flagplus>0)
            {
                inputboxinsider.Text = Convert.ToString(valuearray[0]) + "+";
            }
            else if(flagminus>0)
            {
                inputboxinsider.Text = Convert.ToString(valuearray[0]) + "-";
            }
            else if(flagdevide>0)
            {
                inputboxinsider.Text = Convert.ToString(valuearray[0]) + "/";
            }
            else if(flagmultiplicaton>0)
            {
                inputboxinsider.Text = Convert.ToString(valuearray[0]) + "*";
            }
            flagequal = 0;
        }


        private void disabledButtons()
        {
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            
        }
        private void enabledButton()
        {
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
        }

        private void Button12_Click(object sender, EventArgs e) // for .
        {
            if(flagdecimal==0)
            {
                inputbox.Text += ".";
                flagdecimal++;
            }
            
        }
        private void incompletedecimal()
        {
            //string str = inputbox.Text;
            if(inputbox.Text.EndsWith(".") && nooperators==0)
            {
                int index = inputbox.Text.IndexOf(".");

                string str = inputbox.Text.Remove(index,1);
                inputbox.Text = str;
            }
            
        }  // if the decimal no. dosen't have anything after .

        private void Darkmode_Click(object sender, EventArgs e)
        {
            
            if(Darkmode.Text == "Dark")
            {
                //Form1 myform = new Form1();
                BackColor = Color.Black;
                Darkmode.Text = "Light";


                //StreamWriter sw = new StreamWriter(@"E:\c# app\Calculator\log.txt");
                // sw.WriteLine("BackGround Color - " + BackColor.ToString());
                //sw.Close();

                File.Delete(filepath);
                File.WriteAllText(filepath, "Background Color - " + BackColor.ToString());
            }
            else
            {
                BackColor = Color.White;
                Darkmode.Text = "Dark";
                File.Delete(filepath);
                File.WriteAllText(filepath, "Background Color - " + BackColor.ToString());
            }
        }

        private void ClearButton()
        {
            inputbox.Clear();
            inputboxinsider.Clear();
            /*plusarray[0] = null;
            minusarray[0] = null;
            multiplicationarray[0] = null;
            devidearray[0] = null;
            */
            valuearray[0] = null;
            inputbox.ReadOnly = false;
            flagdecimal = 0;
            flagequal = 0;
            nooperators = 1;
            PlusorMinus = 0;
            if (cannotdividebyzero == 1)
            {
                enabledButton();
                cannotdividebyzero = 0;
            }
        } // for clearing the screen 

        private void PlusOrMinusbutton_Click(object sender, EventArgs e)
        {
           
            if(nooperators==0 && flagequal==0)
            {
                if(PlusorMinus==0)
                {
                    inputbox.Text = "-" + inputbox.Text;
                    PlusorMinus = 1;
                }
                else
                {
                    inputbox.Text = inputbox.Text.Remove(0, 1);
                    PlusorMinus = 0;
                }
            }
            else if(flagequal>=1 && inputbox.Text.Contains("-"))
            {
                inputbox.Text = inputbox.Text.Remove(0, 1);
                valuearray[0] = inputbox.Text;
            }
            else if(flagequal >= 1 && !inputbox.Text.Contains("-"))
            {
                inputbox.Text = "-" + inputbox.Text;
                valuearray[0] = inputbox.Text;
            }
        }
    }
}
