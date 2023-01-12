// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace ProgressBar
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField DayLabel { get; set; }

		[Outlet]
		AppKit.NSTextField DayText { get; set; }

		[Outlet]
		AppKit.NSView Form { get; set; }

		[Outlet]
		AppKit.NSTextField MonthLabel { get; set; }

		[Outlet]
		AppKit.NSTextField MonthText { get; set; }

		[Outlet]
		AppKit.NSProgressIndicator ProgressDay { get; set; }

		[Outlet]
		AppKit.NSProgressIndicator ProgressMonth { get; set; }

		[Outlet]
		AppKit.NSProgressIndicator ProgressYear { get; set; }

		[Outlet]
		AppKit.NSTextField TodayLabel { get; set; }

		[Outlet]
		AppKit.NSTextField YearLabel { get; set; }

		[Outlet]
		AppKit.NSTextField YearText { get; set; }

		[Action ("QuitBtn:")]
		partial void QuitBtn (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (DayLabel != null) {
				DayLabel.Dispose ();
				DayLabel = null;
			}

			if (DayText != null) {
				DayText.Dispose ();
				DayText = null;
			}

			if (Form != null) {
				Form.Dispose ();
				Form = null;
			}

			if (MonthLabel != null) {
				MonthLabel.Dispose ();
				MonthLabel = null;
			}

			if (MonthText != null) {
				MonthText.Dispose ();
				MonthText = null;
			}

			if (ProgressDay != null) {
				ProgressDay.Dispose ();
				ProgressDay = null;
			}

			if (ProgressMonth != null) {
				ProgressMonth.Dispose ();
				ProgressMonth = null;
			}

			if (ProgressYear != null) {
				ProgressYear.Dispose ();
				ProgressYear = null;
			}

			if (TodayLabel != null) {
				TodayLabel.Dispose ();
				TodayLabel = null;
			}

			if (YearLabel != null) {
				YearLabel.Dispose ();
				YearLabel = null;
			}

			if (YearText != null) {
				YearText.Dispose ();
				YearText = null;
			}
		}
	}
}
