﻿// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace XamarinStarter
{
	[Register ("CourseViewController")]
	partial class CourseViewController
	{
		[Outlet]
		UIKit.UIButton buttonNext { get; set; }

		[Outlet]
		UIKit.UIButton buttonPrev { get; set; }

		[Outlet]
		UIKit.UILabel labelTitle { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (buttonPrev != null) {
				buttonPrev.Dispose ();
				buttonPrev = null;
			}

			if (labelTitle != null) {
				labelTitle.Dispose ();
				labelTitle = null;
			}

			if (buttonNext != null) {
				buttonNext.Dispose ();
				buttonNext = null;
			}
		}
	}
}
