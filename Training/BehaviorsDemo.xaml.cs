using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace Training
{
    public partial class BehaviorsDemo : ContentPage
    {
        public BehaviorsDemo()
        {
            InitializeComponent();

            GoToState(true);
        }

        private void GoToState(bool isValid)
        {
            string visualState = isValid ? "Valid" : "Invalid";
            VisualStateManager.GoToState(MainLayout, visualState);
        }

        void EntryPassword_TextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            bool isValid = Regex.IsMatch(e.NewTextValue, @"[A-Za-z0-9]{6,}");
            GoToState(isValid);
        }
    }
}
