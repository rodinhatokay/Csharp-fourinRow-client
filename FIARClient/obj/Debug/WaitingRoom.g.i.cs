﻿#pragma checksum "..\..\WaitingRoom.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4CBFF99234260238B5553FDE06C7E34A2F31AC0DCA34C339E4FA1E12BD808BD8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FIARClient;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace FIARClient {
    
    
    /// <summary>
    /// WaitingRoom
    /// </summary>
    public partial class WaitingRoom : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\WaitingRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MI_userName;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\WaitingRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MI_2players;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\WaitingRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MI_gamesEnded;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\WaitingRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MI_gamesOngoing;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\WaitingRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbWaitingRoom;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\WaitingRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid infoGrid;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\WaitingRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbWins;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\WaitingRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbLoses;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\WaitingRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbPercent;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\WaitingRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbScore;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\WaitingRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbInfo;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\WaitingRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_req;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/FIARClient;component/waitingroom.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WaitingRoom.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\WaitingRoom.xaml"
            ((FIARClient.WaitingRoom)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            
            #line 8 "..\..\WaitingRoom.xaml"
            ((FIARClient.WaitingRoom)(target)).Initialized += new System.EventHandler(this.Window_Initialized);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MI_userName = ((System.Windows.Controls.MenuItem)(target));
            
            #line 13 "..\..\WaitingRoom.xaml"
            this.MI_userName.Click += new System.Windows.RoutedEventHandler(this.btn_search_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.MI_2players = ((System.Windows.Controls.MenuItem)(target));
            
            #line 14 "..\..\WaitingRoom.xaml"
            this.MI_2players.Click += new System.Windows.RoutedEventHandler(this.MI_2players_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MI_gamesEnded = ((System.Windows.Controls.MenuItem)(target));
            
            #line 15 "..\..\WaitingRoom.xaml"
            this.MI_gamesEnded.Click += new System.Windows.RoutedEventHandler(this.MI_gamesEnded_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.MI_gamesOngoing = ((System.Windows.Controls.MenuItem)(target));
            
            #line 16 "..\..\WaitingRoom.xaml"
            this.MI_gamesOngoing.Click += new System.Windows.RoutedEventHandler(this.MI_gamesOngoing_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lbWaitingRoom = ((System.Windows.Controls.ListBox)(target));
            
            #line 30 "..\..\WaitingRoom.xaml"
            this.lbWaitingRoom.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lbWaitingRoom_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.infoGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 8:
            this.tbWins = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.tbLoses = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.tbPercent = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.tbScore = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.lbInfo = ((System.Windows.Controls.ListBox)(target));
            return;
            case 13:
            this.btn_req = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\WaitingRoom.xaml"
            this.btn_req.Click += new System.Windows.RoutedEventHandler(this.btn_req_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

