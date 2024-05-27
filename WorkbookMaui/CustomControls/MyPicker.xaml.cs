using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkbookMaui.CustomControls;

public partial class MyPicker : ContentView
{
	public static readonly BindableProperty LabelTextProperty =
		BindableProperty.Create(nameof(LabelText), typeof(string), typeof(MyPicker), 
			default(string), propertyChanged: (bindable, oldValue, newValue) =>
			{
				var control = (MyPicker)bindable;
				control.LabelPart.Text = (string)newValue;
			});

	public string LabelText
	{
		get => (string)GetValue(LabelTextProperty);
		set => SetValue(LabelTextProperty, value);
	}

	public static readonly BindableProperty PickerItemsProperty =
		BindableProperty.Create(nameof(PickerItems), typeof(IList), typeof(MyPicker), 
			default(IList), BindingMode.TwoWay, propertyChanged: (bindable, oldValue, newValue) =>
			{
				var control = (MyPicker)bindable;
				control.PickerPart.ItemsSource = (IList)newValue;
			});
	
	public static readonly BindableProperty SelectedItemProperty =
		BindableProperty.Create(nameof(SelectedItem), typeof(object), typeof(MyPicker),
			default(object), BindingMode.TwoWay,
			propertyChanged: (bindable, oldvalue, newvalue) =>
			{
				var control = (MyPicker)bindable;
				control.PickerPart.SelectedItem = newvalue;
			});
	
	public object SelectedItem
	{
		get => GetValue(SelectedItemProperty);
		set => SetValue(SelectedItemProperty, value);
	}

	public IList PickerItems
	{
		get => (IList)GetValue(PickerItemsProperty);
		set => SetValue(PickerItemsProperty, value);
	}

	public MyPicker()
	{
		InitializeComponent();
		
	}
}