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
using System.IO;

namespace 进制转换
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void Error()//发生异常时调用
        {
            TB1.Text = "";
            TB2.Text = "";
            TB3.Text = "";
            TB4.Text = "";
        }
        private void TB3_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TB3.IsFocused)
            {
                if (TB3.Text == "")
                {
                    TB1.Text = "";
                    TB2.Text = "";
                    TB4.Text = "";
                }
                else
                {
                    try
                    {
                        TB1.Text = Convert.ToString(Convert.ToInt32(TB3.Text), 2);
                        TB2.Text = Convert.ToString(Convert.ToInt32(TB3.Text), 8);
                        TB4.Text = Convert.ToString(Convert.ToInt32(TB3.Text), 16).ToUpper();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "\n请重新输入！", "输入有误！");
                        Error();
                    }
                }
            }
        }

        private void TB1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TB1.IsFocused)
            {
                if (TB1.Text == "")
                {
                    TB3.Text = "";
                    TB2.Text = "";
                    TB4.Text = "";
                }
                else
                {
                    try
                    {
                        TB3.Text = Convert.ToString(Convert.ToInt32(TB1.Text, 2));//先转换为十进制
                        TB2.Text = Convert.ToString(Convert.ToInt32(TB3.Text), 8);
                        TB4.Text = Convert.ToString(Convert.ToInt32(TB3.Text), 16).ToUpper();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "\n请重新输入！","输入有误！");
                        Error();
                    }

                }
            }
        }

        private void TB2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TB2.IsFocused)
            {
                if (TB2.Text == "")
                {
                    TB3.Text = "";
                    TB1.Text = "";
                    TB4.Text = "";
                }
                else
                {
                    try
                    {
                        TB3.Text = Convert.ToString(Convert.ToInt32(TB2.Text, 8));//先转换为十进制
                        TB1.Text = Convert.ToString(Convert.ToInt32(TB3.Text), 2);
                        TB4.Text = Convert.ToString(Convert.ToInt32(TB3.Text), 16).ToUpper();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "\n请重新输入！", "输入有误！");
                        Error();
                    }
                }
            }
        }

        private void TB4_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TB4.IsFocused)
            {
                if (TB4.Text == "")
                {
                    TB3.Text = "";
                    TB2.Text = "";
                    TB1.Text = "";
                }
                else
                {
                    try
                    {
                        TB3.Text = Convert.ToString(Convert.ToInt32(TB4.Text, 16));//先转换为十进制
                        TB2.Text = Convert.ToString(Convert.ToInt32(TB3.Text), 8);
                        TB1.Text = Convert.ToString(Convert.ToInt32(TB3.Text), 2);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "\n请重新输入！", "输入有误！");
                        Error();
                    }
                }
            }
        }
    }
}
