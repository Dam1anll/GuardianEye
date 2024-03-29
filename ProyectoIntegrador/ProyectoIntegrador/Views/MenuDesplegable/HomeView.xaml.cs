﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcharts;
using Microcharts.Forms;
using SkiaSharp;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoIntegrador.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomeView : ContentPage
	{
		public HomeView ()
		{
			InitializeComponent ();
            NavigationPage.SetHasBackButton(this, false);

            var entries = new List<ChartEntry>
            {
                new ChartEntry(200)
                {
                    Label = "12:00am",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#861B2D"),
                    ValueLabelColor = SKColor.Parse("#FFFFFF"),
                },
                new ChartEntry(100)
                {
                    Label = "11:00am",
                    ValueLabel = "100",
                    Color = SKColor.Parse("#7252AA"),
                    ValueLabelColor = SKColor.Parse("#FFFFFF")
                },
                new ChartEntry(150)
                {
                    Label = "05:00pm",
                    ValueLabel = "150",
                    Color = SKColor.Parse("#107C10"),
                    ValueLabelColor = SKColor.Parse("#FFFFFF")
                },
                new ChartEntry(70)
                {
                    Label = "03:30pm",
                    ValueLabel = "70",
                    Color = SKColor.Parse("#EF83EF"),
                    ValueLabelColor = SKColor.Parse("#FFFFFF")
                },
                new ChartEntry(300)
                {
                    Label = "01:00am",
                    ValueLabel = "300",
                    Color = SKColor.Parse("#1da1f2"),
                    ValueLabelColor = SKColor.Parse("#FFFFFF")
                }
            };

            var chart = new LineChart() 
            {   Entries = entries, 
                BackgroundColor = SKColor.Parse("#141414"),
                LineMode = LineMode.Straight,
                LineSize = 10,
                PointMode = PointMode.Square,
                PointSize = 20,
                LabelOrientation = Microcharts.Orientation.Horizontal,
                ValueLabelOrientation = Microcharts.Orientation.Horizontal,
                LabelTextSize = 30
            };

            notificationChart.Chart = chart;
        }
    }
}