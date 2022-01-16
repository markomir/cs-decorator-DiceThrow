﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Die Elementvorlage "Leere Seite" wird unter https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x407 dokumentiert.

namespace DecoratorPatternProject
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        
        public MainPage()
        {
            this.InitializeComponent();
            
        }

        public void ThrowDice_Click(object sender, RoutedEventArgs e)
        {
            DiceInterface dice = new Dice();
            
            string dicethrown = "";
            if(Ability.IsEnabled)
            {
                string abil = AbilityText.Text;
                DiceInterface dice2 = new BonusDice(dice, abil);
                
                dicethrown = dice2.ThrowDice();
                this.tb.Text = dicethrown + "+ " + abil;
            }
            else if(Proficiency.IsEnabled)
            {
                
            }
            
            
            
        }

    }
}
