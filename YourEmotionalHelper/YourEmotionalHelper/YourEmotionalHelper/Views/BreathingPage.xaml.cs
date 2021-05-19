using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace YourEmotionalHelper.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BreathingPage : ContentPage
    {
        private double _scale = 0;
        private uint breathin = 0;
        private uint breathout = 0;
        private uint hold = 0;
        private uint hold2 = 0;
        private uint ntimes = 0;
        public BreathingPage()
        {

            InitializeComponent();
            breathin = 4 * 1000;
            breathout = 8 * 1000;
            hold = 7 * 1000;
            hold2 = 0;
            _scale = box.Scale;
            ntimes = 5;

            
        }
        protected override void OnAppearing()
        {
            box.ScaleTo(_scale / 3, 1);

        }
        //private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        //{
        //    //await Icon.ScaleTo(_scale * 3, breathin);
        //    //await Icon.ScaleTo(_scale *3 , hold);
        //    //await Icon.ScaleTo(_scale, hold);
        //    txt.Text = "Глибоко вдихни";
        //    txt.Opacity = 0;
        //}

        private async void Button_Clicked(object sender, EventArgs e)
        {

            await title.FadeTo(0, 1000);
            await txt.FadeTo(100, 100);
            await txt.FadeTo(100, breathin - 200);
            await txt.FadeTo(0, 100);
            //await Icon.ScaleTo(_scale * 2, breathin);
            //await Icon.ScaleTo(_scale * 2, hold);
            //await Icon.ScaleTo(_scale, hold);
        }

        private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            await title.FadeTo(0, 1000);
            for (int i= 0; i<ntimes;++i)
            { 
           
            
            text();
            numbers(); 

            await box.ScaleTo(_scale, breathin);
            await box.ScaleTo(_scale, hold);
            await box.ScaleTo(_scale/3, breathout);
            }
        }
        private async void numbers()
        {
            for (int i=0; i< breathin/1000;i++)
            {
                num.Opacity = 100;
                num.Text = (i + 1).ToString();
                await num.FadeTo(100, 800);
                await num.FadeTo(0, 200);
            }
            for (int i = 0; i < hold/1000; i++)
            {
                num.Opacity = 100;
                num.Text = (i + 1).ToString();
                await num.FadeTo(100, 800);
                await num.FadeTo(0, 200);
            }
            for (int i = 0; i < breathout/1000; i++)
            {
                num.Opacity = 100;
                num.Text = (i + 1).ToString();
                await num.FadeTo(100, 800);
                await num.FadeTo(0, 200);
            }
            num.Opacity = 0;
        }
            private async void text()
        {
            txt.Text = "Глибоко вдихни";
            txt.Opacity = 0;
            
            await txt.FadeTo(100, 400);
            await txt.FadeTo(100, breathin - 600);
            await txt.FadeTo(0, 200);
            txt.Text = "Затримай";

            await txt.FadeTo(100, 400);
            await txt.FadeTo(100, hold - 600);
            await txt.FadeTo(0, 200);
            txt.Text = "Видихай";
            txt.Opacity = 0;
            await txt.FadeTo(100, 400);
            await txt.FadeTo(100, breathout - 600);
            await txt.FadeTo(0, 200);
            
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Сторінка дихальної техніки", " Дихальні техніки є дуже дієвим інструментом керування емоціями в ситуаціях стресу і тривоги,інструментом регуляції злості чи стишення в часі фізичного або емоційного збудження. Процес можна змінити в налаштування. Детальніше про техніки https://life.liga.net/porady/news/dyhatelnye-tehniki-dlya-snyatiya-stressa-i-krepkogo-sna", "ok");

        }
    }
}