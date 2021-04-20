﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Telerik.Windows.Data;
using Telerik.Windows.Controls;
using System.Windows.Threading;
using System.Data;

namespace GridViewDataTable
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : UserControl
    {
        private bool refreshInProgress;

        public MainWindow()
        {
            InitializeComponent();

            var timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(20);
            timer.Start();
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            if (refreshInProgress == false)
            {
                refreshInProgress = true;
                int rowCount = (this.DataContext as MyViewModel).DataTable.Rows.Count;

                for (int i = 0; i < rowCount; i++)
                {
                    DataRow row = (this.DataContext as MyViewModel).DataTable.Rows[i];
                    row["City"] = random.Next(0, 500);
                    row["LastTimeUpdate"] = System.DateTime.Now;
                }
                refreshInProgress = false;
            }
        }
    }
}
