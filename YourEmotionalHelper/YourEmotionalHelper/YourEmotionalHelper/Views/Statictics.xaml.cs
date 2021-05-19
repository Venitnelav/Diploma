using Microcharts;
using SkiaSharp;
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
    public partial class Statictics : ContentPage
    {
        public Statictics()
        {
            //var entries = new List<ChartEntry>();
            //var notes = App.database.GetNotesItems();
            //var MoodsList = App.database.GetMoodItems();
            //foreach (Mood mood in MoodsList)
            //{
            //    int count = notes.Where(x => x.curMood == mood.Id).Count();
            //    var ce = new ChartEntry(count);
            //    ce.Label = mood.MoodName;
            //    ce.ValueLabel = count.ToString();
            //    ce.Color = SKColor.Parse(mood.MoodColor);
            //    entries.Add(ce);

            //}
            var entries = new[]
{
    new ChartEntry(4)
    {
        Label = "Добре",
        ValueLabel = "4",
        Color = SKColor.Parse("#96d1ff")
    },
    new ChartEntry(5)
    {
        Label = "Чудово",
        ValueLabel = "5",
        Color = SKColor.Parse("#77d065")
    },
    new ChartEntry(1)
    {
        Label = "1",
        ValueLabel = "1",
        Color = SKColor.Parse("#f896ff")
    },
    new ChartEntry(1)
    {
        Label = "Нормально",
        ValueLabel = "1",
        Color = SKColor.Parse("#ffc496")
    },
    new ChartEntry(2)
    {
        Label = "Нормально",
        ValueLabel = "2",
        Color = SKColor.Parse("#9cff96")
    }
};
            var chart = new PieChart { Entries = entries };
            InitializeComponent();
            chartView.Chart = chart;
        }
    }
}