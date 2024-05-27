using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkbookMaui.CustomControls;

public partial class MyTextInput : ContentView
{
	public static readonly BindableProperty LabelTextProperty =
		BindableProperty.Create(nameof(LabelText), typeof(string), typeof(MyTextInput), 
			default(string), propertyChanged: (bindable, oldValue, newValue) =>
			{
				var control = (MyTextInput)bindable;
				control.LabelPart.Text = (string)newValue;
			});

	public string LabelText
	{
		get => GetValue(LabelTextProperty) as string;
		set => SetValue(LabelTextProperty, value);
	}
    
	public static readonly BindableProperty EntryTextProperty =
		BindableProperty.Create(nameof(EntryText), typeof(string), typeof(MyTextInput), 
			default(string), BindingMode.TwoWay, propertyChanged: (bindable, oldValue, newValue) =>
			{
				var control = (MyTextInput)bindable;
				control.EntryPart.Text = (string)newValue;
			});

	public string EntryText
	{
		get => GetValue(EntryTextProperty) as string;
		set => SetValue(EntryTextProperty, value);
	}
    
	public MyTextInput()
	{
		InitializeComponent();
	}
}