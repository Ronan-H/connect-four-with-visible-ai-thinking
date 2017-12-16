﻿#pragma checksum "C:\Users\borme\Documents\VisualStudioProjects\Connect Four with Visible AI Thinking\Connect Four with Visible AI Thinking\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9D504266F1EE10991B50F5B01C754839"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Connect_Four_with_Visible_AI_Thinking
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.rootPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 2:
                {
                    this.settingsPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 3:
                {
                    this.boardGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    #line 23 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)this.boardGrid).Tapped += this.OnBoardTapped;
                    #line default
                }
                break;
            case 4:
                {
                    this.SearchDepthSlider = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    #line 13 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Slider)this.SearchDepthSlider).ValueChanged += this.SearchDepthSlider_ValueChanged;
                    #line default
                }
                break;
            case 5:
                {
                    this.ShowThinkingCheckbox = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 14 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.ShowThinkingCheckbox).Checked += this.ShowThinkingCheckbox_Checked;
                    #line 14 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.ShowThinkingCheckbox).Unchecked += this.ShowThinkingCheckbox_Unchecked;
                    #line default
                }
                break;
            case 6:
                {
                    this.StateDelaySlider = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    #line 15 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Slider)this.StateDelaySlider).ValueChanged += this.StateDelaySlider_ValueChanged;
                    #line default
                }
                break;
            case 7:
                {
                    this.ShowColVals = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 16 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.ShowColVals).Checked += this.ShowColVals_Checked;
                    #line 16 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.ShowColVals).Unchecked += this.ShowColVals_Unchecked;
                    #line default
                }
                break;
            case 8:
                {
                    this.StatusText1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9:
                {
                    this.StatusText2 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

