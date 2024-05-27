using System;
using Microsoft.Maui.Controls;

namespace WorkbookMaui.CustomControls
{
	public partial class MyDatePicker : ContentView
	{
		public static readonly BindableProperty LabelTextProperty =
			BindableProperty.Create(nameof(LabelText), typeof(string), typeof(MyDatePicker), 
				default(string), propertyChanged: (bindable, oldValue, newValue) =>
				{
					var control = (MyDatePicker)bindable;
					control.LabelPart.Text = (string)newValue;
				});
		
		public static readonly BindableProperty SelectedDateProperty =
			BindableProperty.Create(nameof(SelectedDate), typeof(DateTime), typeof(MyDatePicker), DateTime.Today, BindingMode.TwoWay);


		public DateTime SelectedDate
		{
			get => (DateTime)GetValue(SelectedDateProperty);
			set => SetValue(SelectedDateProperty, value);
		}
        
		public string LabelText
		{
			get => (string)GetValue(LabelTextProperty);
			set => SetValue(LabelTextProperty, value);
		}

		public MyDatePicker()
		{
			InitializeComponent();

			/*DatePickerPart.DateSelected += (s, e) => SelectedDate = e.NewDate;

			var labelBinding = new Binding
			{
				Source = this,
				Path = nameof(LabelText)
			};
			LabelPart.SetBinding(Label.TextProperty, labelBinding);

			var dateBinding = new Binding
			{
				Source = this,
				Path = nameof(SelectedDate)
			};
			DatePickerPart.SetBinding(DatePicker.DateProperty, dateBinding);*/
		}
	}
}