﻿using Uno.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	public partial class Control
	{
		public Control() : this("div") { }

		internal Control(string htmlTag) : base(htmlTag)
		{
			InitializeControl();
		}

		partial void OnIsFocusableChanged()
		{
			var isFocusable = IsFocusable && !IsDelegatingFocusToTemplateChild();

			WindowManagerInterop.SetIsFocusable(HtmlId, isFocusable);
		}
	}
}
