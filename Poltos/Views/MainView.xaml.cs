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
using System.Windows.Shapes;
using System.Runtime.InteropServices;
using System.Runtime;
using System.Windows.Interop;
using FontAwesome.WPF;

namespace Poltos.Views
{
    /// <summary>
    /// Логика взаимодействия для MainView.xaml
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
         
        }

        private void sidebarButton_Checked(object sender, RoutedEventArgs e)
        {
            // а тут я меняю заголовок
            RadioButton radioButton = sender as RadioButton;
   
                StackPanel stackPanel = radioButton.Content as StackPanel;
                if (stackPanel != null)
                {
                    foreach (var originChild in stackPanel.Children)
                    {
                        if (originChild is TextBlock)
                        {
                            TextBlock textBlock = originChild as TextBlock;
                            foreach (var destinationChild in pageHeader.Children)
                            {
                                if (destinationChild is TextBlock)
                                {
                                    TextBlock textBlock2 = destinationChild as TextBlock;
                                    textBlock2.Text = textBlock.Text;
                                }
                            }
                        }
                        if (originChild is ImageAwesome)
                        {
                            ImageAwesome imageAwesome = originChild as ImageAwesome;
                            foreach (var destinationChild in pageHeader.Children)
                            {
                                if (destinationChild is ImageAwesome)
                                {
                                    ImageAwesome imageAwesome2 = destinationChild as ImageAwesome;
                                    imageAwesome2.Icon = imageAwesome.Icon;
                                }
                            }
                        }
                    }
                }

                // тут я буду менять странички
            
        }


        /// <summary>
        /// Event Handlers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

    }
}
