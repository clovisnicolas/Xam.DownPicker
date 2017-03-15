# Xam.DownPicker
Xamarin.iOS Bindings for [DownPicker Objective-C Library](https://github.com/Darkseal/DownPicker)

# Install
Available on NuGet

[![NuGet](https://img.shields.io/nuget/v/Xam.DownPicker.svg?label=NuGet)](https://www.nuget.org/packages/Xam.DownPicker/)

## Quickstart
```csharp
//Data
NSMutableArray array = new NSMutableArray();
array.Add(new NSString("First"));
array.Add(new NSString("Second"));
array.Add(new NSString("Third"));

//Picker
UIDownPicker picker = new UIDownPicker(array);
picker.Frame = this.View.Bounds;

this.View.AddSubview(picker);      
```

## License
MIT © Clovis Nicolas
