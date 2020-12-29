using System;
using System.Globalization;
using Xamarin.Forms;

namespace Training.Converters
{
    public class LevelConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int level = (int)value;
            string levelText = String.Empty;
            switch (level)
            {
                case 100: levelText = "Beginner"; break;
                case 200: levelText = "Intermediate"; break;
                case 300: levelText = "Advanced"; break;
            }
            return levelText;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string levelText = value.ToString();
            int level = 0;
            switch (levelText)
            {
                case "Beginner": level = 100; break;
                case "Intermediate": level = 200; break;
                case "Advanced": level = 300; break;
            }
            return level;
        }
    }
}
