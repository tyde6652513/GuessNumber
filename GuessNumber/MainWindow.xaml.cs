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
using DefineNumber;

namespace GuessNumber
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>

    public partial class MainWindow : Window
    {
        int GuessTime = 0;
        private Number NewNumber = new Number();
        public delegate void D();
        public D HideDelegate;
        //AnsWindow Form;
        public MainWindow()
        {

            NewNumber.CreateAnswer();
            InitializeComponent();
            //Form = new AnsWindow();
            //this.Ans.Click += new System.Windows.RoutedEventHandler(this.Ans_Click);
            //Form.Closed +=  new System.EventHandler(this.Show);
        }



        private void Ans_Click(object sender, RoutedEventArgs e)
        {
    
            MessageBox.Show("答案是:\n  " + NewNumber.RightAnswer);
            //Form.Show();
            //Form.DisplayAnswer.Text = "  答案是:\n  " + NewNumber.RightAnswer;
            //Form.Closed += 
            //this.Hide();


            //this.Close();
            ///this.HideDelegate = new D(this.Hide);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            NewNumber.UserAnswer = AnsBox.Text;
            if (NewNumber.CheckFormat())
            {
                GuessTime++;
                Display.Items.Add(AnsBox.Text + "-->第" + GuessTime + "次猜測:  " + NewNumber.GetA() + "A" + NewNumber.GetB() + "B");
                if (NewNumber.GetA() == 4)
                {
                    MessageBox.Show("Bingo 答對了!");
                }
            }
            else
            {
                MessageBox.Show("輸入格式錯誤", "Error");
            }


        }

        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            NewNumber.CreateAnswer();
            AnsBox.Clear();
            Display.Items.Clear();            
        }
        
    }
}
