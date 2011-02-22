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
using System.Windows.Shapes;

namespace EventOrganizer
{
    public partial class EditStarterWindow : Window
    {
        public Starter _starter;

        public EditStarterWindow(Starter starter)
        {
            InitializeComponent();

            _starter = starter;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _firstNameTextBox.Text = _starter.FirstName;
            _lastNameTextBox.Text = _starter.LastName;
            _clubTextBox.Text = _starter.Club;
            _ponyTextBox.Text = _starter.Pony;
            _commentTextBox.Text = _starter.Comment;

            _birthdateDatePicker.SelectedDate = _starter.Birthdate;

            // load competitions
            using (EODbEntities db = new EODbEntities())
            {
                var competitions = from c in db.Competition
                                   select new CheckedListItem<Competition>() { Item = c, Text = c.Caption };

                List<CheckedListItem<Competition>> list = competitions.ToList();
                foreach (var item in _starter.StarterCompetition)
                {
                    var s = list.Single(c => c.Item.Id == item.CompetitionId);
                    s.IsChecked = true;
                }

                _competitionListBox.DataContext = list;
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            using (EODbEntities db = new EODbEntities())
            {
                db.Attach(_starter);

                _starter.FirstName = _firstNameTextBox.Text;
                _starter.LastName = _lastNameTextBox.Text;
                _starter.Club = _clubTextBox.Text;
                _starter.Pony = _ponyTextBox.Text;
                _starter.Comment = _commentTextBox.Text;

                _starter.Birthdate = _birthdateDatePicker.SelectedDate;

                foreach (var item in (List<CheckedListItem<Competition>>)_competitionListBox.DataContext)
                {
                    bool itemExists = _starter.StarterCompetition.Any(c => c.CompetitionId == item.Item.Id);

                    if (item.IsChecked && !itemExists)
                    {
                        // if the item is not checked in the database
                        // and the user checked it now
                        // create a new item and add it to startercompetition collection

                        StarterCompetition sc = new StarterCompetition
                                                    {
                                                        CompetitionId = item.Item.Id,
                                                        StarterId = _starter.Id
                                                    };

                        _starter.StarterCompetition.Add(sc);
                    }
                    else if (!item.IsChecked && itemExists)
                    {
                        // if the item is checked in the database
                        // and the user unchecked it now
                        // delete the item and remove it from the startercompetition collection

                        var itemToDelete = _starter.StarterCompetition.Single(c => c.CompetitionId == item.Item.Id);
                        db.DeleteObject(itemToDelete);
                        _starter.StarterCompetition.Remove(itemToDelete);
                    }
                    else
                    {
                        // if the item state has not changed
                        // do nothing
                    }
                }

                db.SaveChanges();
            }

            this.DialogResult = true;
            this.Close();
        }
    }
}
