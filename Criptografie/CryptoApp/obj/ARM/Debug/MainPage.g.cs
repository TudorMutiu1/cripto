﻿#pragma checksum "C:\Users\Simona\Desktop\cripto\Criptografie\CryptoApp\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "02C080FF673D2DB6F9E0CECDB4B810B8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CryptoApp
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 59
                {
                    this.cryptedTextBox = (global::Windows.UI.Xaml.Controls.RichEditBox)(target);
                }
                break;
            case 3: // MainPage.xaml line 53
                {
                    this.clearTextBox = (global::Windows.UI.Xaml.Controls.RichEditBox)(target);
                }
                break;
            case 4: // MainPage.xaml line 45
                {
                    this.CryptoButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.CryptoButton).Click += this.CryptoButton_Click;
                }
                break;
            case 5: // MainPage.xaml line 40
                {
                    this.pathTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6: // MainPage.xaml line 42
                {
                    this.FileButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.FileButton).Click += this.FileButton_Click;
                }
                break;
            case 7: // MainPage.xaml line 30
                {
                    this.defaultCipher = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.defaultCipher).Checked += this.RadioButton_Checked_EncryptionMode;
                }
                break;
            case 8: // MainPage.xaml line 31
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element8 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element8).Checked += this.RadioButton_Checked_EncryptionMode;
                }
                break;
            case 9: // MainPage.xaml line 32
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element9 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element9).Checked += this.RadioButton_Checked_EncryptionMode;
                }
                break;
            case 10: // MainPage.xaml line 33
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element10 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element10).Checked += this.RadioButton_Checked_EncryptionMode;
                }
                break;
            case 11: // MainPage.xaml line 34
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element11 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element11).Checked += this.RadioButton_Checked_EncryptionMode;
                }
                break;
            case 12: // MainPage.xaml line 19
                {
                    this.defaultAlgo = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.defaultAlgo).Checked += this.RadioButton_Checked_AlgorithmType;
                }
                break;
            case 13: // MainPage.xaml line 20
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element13 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element13).Checked += this.RadioButton_Checked_AlgorithmType;
                }
                break;
            case 14: // MainPage.xaml line 21
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element14 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element14).Checked += this.RadioButton_Checked_AlgorithmType;
                }
                break;
            case 15: // MainPage.xaml line 22
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element15 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element15).Checked += this.RadioButton_Checked_AlgorithmType;
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

