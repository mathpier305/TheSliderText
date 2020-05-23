using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TheSliderText
{
    public partial class TheSliderPage : ContentPage
    {
        string[] listOfSentences = {
            " Sentence # 1 ",
            " Sentence # 2",
            " Sentence # 3",
            " Sentence # 4"
        };
        int count = 0;
        public TheSliderPage()
        {
            InitializeComponent();

            slider.Minimum = 16;
            adesc.Text = listOfSentences[0];
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            count += 1;
            count %= listOfSentences.Length;
            adesc.Text = listOfSentences[count];
        }
     
    }
}
