﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {

        private string _commandText;
        public string CommandText
        {
            get => _commandText;
            set
            {
                _commandText = value;
            }
        }

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_C_Clicked(object sender, EventArgs e)
        {
            CommandText = "Finish";
            DisplayPromptAsync("Question 1", "What's your name?");
        }
    }
}
