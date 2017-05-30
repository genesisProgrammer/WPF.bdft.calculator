using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace bdft.calc
{
    /// <summary>
    /// 1.0 complete!
    /// 2.0 - Ability to delete item, total cost (may need to modify output variable so cost can be calculated independently), default text in input boxes after submit
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
                    
            InitializeComponent();

            Species_ComboBox.Items.Add("Walnut");
            Species_ComboBox.Items.Add("Maple");
            Species_ComboBox.Items.Add("Cherry");


            Board_Thickness.Items.Add("3/4");
            Board_Thickness.Items.Add("4/4");
            Board_Thickness.Items.Add("5/4");
            Board_Thickness.Items.Add("6/4");
            Board_Thickness.Items.Add("8/4");
            Board_Thickness.Items.Add("12/4");

            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //shitty way to validate, change on 2.0
            //look into IDataErrorInfo for validations that follow business rules
            int comboBoxValidate = 0;
            double width = 0;
            double length = 0;
            double result = 0;
            double cost = 0;

            if(Species_ComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select wood species", "Error");
                //some red "required" text next to the drop down might be better [2.0]
            }
                else
                {
                    comboBoxValidate++;
                }

            if (Board_Thickness.SelectedIndex == -1)
            {
                MessageBox.Show("Please select board thickness", "Error");
            }
            else
            {
                comboBoxValidate++;
            }

            if (Double.TryParse(cost_textBox.Text, out cost))
            {
                comboBoxValidate++;
            }
            else
            {
                MessageBox.Show("Please enter numeric value only");
            }

            if (Double.TryParse(length_textBox.Text, out length)){
                comboBoxValidate++;
            }
            else
            {
                MessageBox.Show("Please enter numeric value only");
            }

            if (Double.TryParse(width_textBox.Text, out width))
            {
                comboBoxValidate++;
            }
            else
            {
                MessageBox.Show("Please enter numeric value only");
            }

            if (comboBoxValidate == 5)
            {
                result = ((length*width)/144) * thicknessToDouble(Board_Thickness.SelectedIndex) * (Convert.ToDouble(cost_textBox.Text));
                
                
                list_total.Items.Add(Species_ComboBox.Items.GetItemAt(Species_ComboBox.SelectedIndex) +"           " + String.Format("{0:C}", result));
                    
            }
        }

        
        //clears textbox on focus
        private void textBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
        }

        //checks textbox on losing focus
        private void textBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            
            if (tb.Text.Trim().Equals(string.Empty))
            {
                tb.Text = "Feild Required"; //make red in code or xaml??
                
            }
        }

        //Index change event to grab which index select for thickness
        private void Board_Thickness_SelectedIndexChanged(object sender, EventArgs e)
        {
            double board_thickness_Index = Board_Thickness.SelectedIndex;
        }

        //Board thickness index to double conversion
        public double thicknessToDouble(double board_thickness_Index)
        {
            double thicknessCalc; 

            switch (Board_Thickness.SelectedIndex)
            {

                case 0:
                    thicknessCalc = .75;
                    break;
                case 1:
                    thicknessCalc = 1;
                    break;
                case 2:
                    thicknessCalc = 1.25;
                    break;
                case 3:
                    thicknessCalc = 1.5;
                    break;
                case 4:
                    thicknessCalc = 2;
                    break;
                case 5:
                    thicknessCalc = 3;
                    break;
                default:
                    thicknessCalc = 0;
                    break; 
            }

            return thicknessCalc;
        }

               
    }
}
