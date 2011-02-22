using System;
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

namespace EventOrganizer
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            using (EODbEntities db = new EODbEntities())
            {
                var query = from c in db.Starter.Include("StarterCompetition")
                            orderby c.Id
                            select c;

                starterDataGrid.DataContext = query;
            }
        }

        private void CloseMenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddStarterMenuItem_Click(object sender, RoutedEventArgs e)
        {
            EditStarterWindow ed = new EditStarterWindow(new Starter());
            ed.ShowDialog();
        }

        private void EditStarterButton_Click(object sender, RoutedEventArgs e)
        {
            if (starterDataGrid.SelectedItem is Starter)
            {
                EditStarterWindow ed = new EditStarterWindow((Starter)starterDataGrid.SelectedItem);
                ed.ShowDialog();
            }
        }

        private void starterDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            // search for the row on which the user performed the doubleclick
            DependencyObject dp = (DependencyObject)e.OriginalSource;
            while (dp != null && !(dp is DataGridRow))
            {
                dp = VisualTreeHelper.GetParent(dp);
            }

            // if the row is not found, the user did not perform a doublclick on a row
            if (dp is DataGridRow)
            {
                Starter starter = ((DataGridRow)dp).DataContext as Starter;
                if (starter != null)
                {
                    EditStarterWindow ed = new EditStarterWindow(starter);
                    ed.ShowDialog();
                }
            }
        }
    }
}
