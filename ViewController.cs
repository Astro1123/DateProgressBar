using System;
using System.Timers;

using AppKit;
using Foundation;
using static System.Net.Mime.MediaTypeNames;

namespace ProgressBar
{
	public partial class ViewController : NSViewController
	{
		private Timer timer;

		public ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			// Do any additional setup after loading the view.
			timer = new Timer(100);
			timer.Elapsed += OnTimedEvent;
			timer.Enabled = true;

			YearText.Editable = false;
            MonthText.Editable = false;
			DayText.Editable = false;

            YearLabel.StringValue = "Year";
            MonthLabel.StringValue = "Month";
            DayLabel.StringValue = "Day";

            show();
		}

		private void show()
		{
            DateTime dt = DateTime.Now;
            TodayLabel.StringValue = dt.ToString("yyyy/MM/dd HH:mm:ss");

			int daysec = 60 * 60 * 24;
			int nowsec = 60 * 60 * dt.Hour + 60 * dt.Minute + dt.Second;
			double rateDay = (double)nowsec / (double)daysec * 100;
			ProgressDay.DoubleValue = rateDay;
			DayText.StringValue = $"{rateDay,3:F2}%";

			int monthLength = monthNum(dt.Year, dt.Month);
            double rateMonth = ((double)(dt.Day- 1) * 100 + rateDay) / (double)monthLength;
            ProgressMonth.DoubleValue = rateMonth;
            MonthText.StringValue = $"{rateMonth,3:F2}%";

            int yearLength = 365 + isLeap(dt.Year);
			int nowDay = dayNum(dt.Year, dt.Month, dt.Day);
            double rateYear = ((double)(dayNum(dt.Year, dt.Month, dt.Day) - 1) * 100 + rateMonth) / (double)yearLength;
            ProgressYear.DoubleValue = rateYear;
            YearText.StringValue = $"{rateYear,3:F2}%";
        }

		private int dayNum(int year, int month, int day)
        {
            day += (month > 11 ? 30 : 0);
            day += (month > 10 ? 31 : 0);
            day += (month > 9 ? 30 : 0);
            day += (month > 8 ? 31 : 0);
            day += (month > 7 ? 31 : 0);
            day += (month > 6 ? 30 : 0);
            day += (month > 5 ? 31 : 0);
            day += (month > 4 ? 30 : 0);
            day += (month > 3 ? 31 : 0);
            day += (month > 2 ? 28 + isLeap(year) : 0);
            day += (month > 1 ? 31 : 0);

            return day;
		}


        private int monthNum(int year, int month)
		{
			int res;
			switch (month)
			{
				case 2:
					res = 28 + isLeap(year);
					break;
				case 1:
				case 3:
				case 5:
				case 7:
				case 8:
				case 10:
				case 12:
					res = 31;
					break;
				default:
					res = 30;
					break;
			}
			return res;
		}


        private int isLeap(int year)
		{
			if (year % 400 == 0)
			{
				return 1;
			} else if (year % 100 == 0)
			{
				return 0;
			} else if (year % 4 == 0)
			{
				return 1;
			}
			else
			{
				return 0;
			}
		}


        public override NSObject RepresentedObject {
			get {
				return base.RepresentedObject;
			}
			set {
				base.RepresentedObject = value;
				// Update the view, if already loaded.
			}
		}

		partial void QuitBtn(Foundation.NSObject sender)
		{
            Environment.Exit(0);
		}

		private void OnTimedEvent(Object sender, ElapsedEventArgs e)
		{
            DateTime dt = DateTime.Now;
			InvokeOnMainThread(() =>
			{
				show();
			});
        }
    }
}
