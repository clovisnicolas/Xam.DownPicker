using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace Xam.DownPicker
{
	// @interface DownPicker : UIControl <UIPickerViewDelegate, UIPickerViewDataSource, UITextFieldDelegate>
	[BaseType(typeof(UIControl))]
	interface DownPicker : IUIPickerViewDelegate, IUIPickerViewDataSource, IUITextFieldDelegate
	{
		// @property (nonatomic) NSString * text;
		[Export("text")]
		string Text { get; set; }

		// @property (nonatomic) NSInteger selectedIndex;
		[Export("selectedIndex")]
		nint SelectedIndex { get; set; }

		// -(id)initWithTextField:(UITextField *)tf;
		[Export("initWithTextField:")]
		IntPtr Constructor(UITextField tf);

		// -(id)initWithTextField:(UITextField *)tf withData:(NSMutableArray *)data;
		[Export("initWithTextField:withData:")]
		IntPtr Constructor(UITextField tf, NSMutableArray data);

		// -(void)setArrowImage:(UIImage *)image;
		[Export("setArrowImage:")]
		void SetArrowImage(UIImage image);

		// -(void)setData:(NSMutableArray *)data;
		[Export("setData:")]
		void SetData(NSMutableArray data);

		// -(void)setPlaceholder:(NSString *)str;
		[Export("setPlaceholder:")]
		void SetPlaceholder(string str);

		// -(void)setPlaceholderWhileSelecting:(NSString *)str;
		[Export("setPlaceholderWhileSelecting:")]
		void SetPlaceholderWhileSelecting(string str);

		// -(void)setToolbarDoneButtonText:(NSString *)str;
		[Export("setToolbarDoneButtonText:")]
		void SetToolbarDoneButtonText(string str);

		// -(void)setToolbarCancelButtonText:(NSString *)str;
		[Export("setToolbarCancelButtonText:")]
		void SetToolbarCancelButtonText(string str);

		// -(void)setToolbarStyle:(UIBarStyle)style;
		[Export("setToolbarStyle:")]
		void SetToolbarStyle(UIBarStyle style);

		// -(void)showArrowImage:(BOOL)b;
		[Export("showArrowImage:")]
		void ShowArrowImage(bool b);

		// -(UIPickerView *)getPickerView;
		[Export("getPickerView")]
		UIPickerView PickerView { get; }

		// -(UITextField *)getTextField;
		[Export("getTextField")]
		UITextField TextField { get; }

		// -(NSString *)getValueAtIndex:(NSInteger)index;
		[Export("getValueAtIndex:")]
		string GetValueAtIndex(nint index);

		// -(void)setValueAtIndex:(NSInteger)index;
		[Export("setValueAtIndex:")]
		void SetValueAtIndex(nint index);
	}

	// @interface UIDownPicker : UITextField
	[BaseType(typeof(UITextField))]
	interface UIDownPicker
	{
		// @property (nonatomic, strong) DownPicker * DownPicker;
		[Export("DownPicker", ArgumentSemantic.Strong)]
		DownPicker DownPicker { get; set; }

		// -(id)initWithData:(NSMutableArray *)data;
		[Export("initWithData:")]
		IntPtr Constructor(NSMutableArray data);
	}
}
