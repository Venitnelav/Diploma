using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Plugin.Calendar.Models;


namespace YourEmotionalHelper.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalendarPage : ContentPage
    {

        public List<notes> Notes { get; set; }
        public CalendarPage()
        {
            Notes = new List<notes>
            {
                new notes {MoodName="Чудово", Emotions="Радість, Натхнення", Activities="Малювання", ImagePath="awsome.png" },
                new notes {MoodName="Добре", Emotions="Задоволення", Activities="Робота", ImagePath="good.png" },
                
            };
  
            InitializeComponent();
            ListView listView = new ListView
            {
                HasUnevenRows = true,
                ItemsSource = Notes,
                // Определяем формат отображения данных
                ItemTemplate = new DataTemplate(() =>
                {
                    ImageCell imageCell = new ImageCell { TextColor = Color.Red, DetailColor = Color.Green };
                    imageCell.SetBinding(ImageCell.TextProperty, "MoodName");
                    Binding emBinding = new Binding { Path = "Emotions", StringFormat = "Флагман от компании {0}" };
                    imageCell.SetBinding(ImageCell.DetailProperty, emBinding);

                    imageCell.SetBinding(ImageCell.ImageSourceProperty, "ImagePath");
                    return imageCell;
                })
            };
        }
          
 
      
           
           
            
    public class notes
    {
        public string MoodName { get; set; }
        public string ImagePath { get; set; }
        public string Emotions { get; set; }
        public string Activities { get; set; }
    }
    }
}