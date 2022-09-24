﻿using System;
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

namespace Template4438
{
    /// <summary>
    /// Логика взаимодействия для PageKhamidullin.xaml
    /// </summary>
    public partial class PageKhamidullin : Window
    {
        public PageKhamidullin()
        {
            InitializeComponent();
        }

        public static MainWindow mainWindow;

        private void Button_exit_Click(object sender, RoutedEventArgs e)
        {
            if (mainWindow != null)
                return;
            mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
