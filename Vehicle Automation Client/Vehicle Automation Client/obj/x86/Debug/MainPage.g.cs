﻿#pragma checksum "C:\Users\HP\Desktop\Project\Vehicle Automation Client\Vehicle Automation Client\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8918EACD32FD1F30E65BB45B32FF2FAF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vehicle_Automation_Client
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1: // MainPage.xaml line 11
                {
                    this.RecieveMessageStatus = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 2: // MainPage.xaml line 29
                {
                    global::Windows.UI.Xaml.Controls.Button element2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element2).Click += this.onClick;
                }
                break;
            case 3: // MainPage.xaml line 27
                {
                    this.status = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4: // MainPage.xaml line 22
                {
                    this.button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.button).Click += this.button_Click;
                }
                break;
            case 5: // MainPage.xaml line 14
                {
                    this.PreviewCanvas = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            case 6: // MainPage.xaml line 17
                {
                    this.VisualizationCanvas = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            case 7: // MainPage.xaml line 18
                {
                    this.captureImage = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 8: // MainPage.xaml line 15
                {
                    this.previewElement = (global::Windows.UI.Xaml.Controls.CaptureElement)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

