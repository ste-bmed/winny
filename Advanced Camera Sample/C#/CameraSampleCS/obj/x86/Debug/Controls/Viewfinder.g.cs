﻿#pragma checksum "C:\progetti\winmob\samples-ph8-1\Advanced Camera Sample\C#\CameraSampleCS\Controls\Viewfinder.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6E6B963EA281CA9C4A338C26C9775D8A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace CameraSampleCS.Controls {
    
    
    public partial class Viewfinder : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LivePreviewLayout;
        
        internal System.Windows.Media.Animation.Storyboard AutoFocusInProgress;
        
        internal System.Windows.Media.Animation.Storyboard AutoFocusLocked;
        
        internal System.Windows.Media.Animation.Storyboard PointFocusInProgress;
        
        internal System.Windows.Media.Animation.Storyboard PointFocusLocked;
        
        internal System.Windows.Shapes.Rectangle LivePreview;
        
        internal System.Windows.Media.CompositeTransform LivePreviewTransform;
        
        internal System.Windows.Controls.Grid PointFocusBrackets;
        
        internal System.Windows.Controls.Grid AutoFocusBrackets;
        
        internal System.Windows.Controls.Grid ChromeLayout;
        
        internal System.Windows.Media.Animation.Storyboard ShowArrowButton;
        
        internal System.Windows.Media.Animation.Storyboard HideArrowButton;
        
        internal System.Windows.Media.Animation.Storyboard RotateArrowButtonToLandscape;
        
        internal System.Windows.Media.Animation.Storyboard RotateArrowButtonToPortrait;
        
        internal System.Windows.Media.Animation.Storyboard DisplayStatus;
        
        internal System.Windows.Controls.Button LeftArrowButton;
        
        internal System.Windows.Controls.TextBlock StatusText;
        
        internal System.Windows.Controls.Grid ReviewLayout;
        
        internal System.Windows.Media.Animation.Storyboard ReviewImageSlideOff;
        
        internal System.Windows.Media.Animation.EasingDoubleKeyFrame ReviewImageSlideOffTranslateStart;
        
        internal System.Windows.Media.Animation.EasingDoubleKeyFrame ReviewImageSlideOffTranslateEnd;
        
        internal System.Windows.Shapes.Rectangle ReviewImage;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/CameraSampleCS;component/Controls/Viewfinder.xaml", System.UriKind.Relative));
            this.LivePreviewLayout = ((System.Windows.Controls.Grid)(this.FindName("LivePreviewLayout")));
            this.AutoFocusInProgress = ((System.Windows.Media.Animation.Storyboard)(this.FindName("AutoFocusInProgress")));
            this.AutoFocusLocked = ((System.Windows.Media.Animation.Storyboard)(this.FindName("AutoFocusLocked")));
            this.PointFocusInProgress = ((System.Windows.Media.Animation.Storyboard)(this.FindName("PointFocusInProgress")));
            this.PointFocusLocked = ((System.Windows.Media.Animation.Storyboard)(this.FindName("PointFocusLocked")));
            this.LivePreview = ((System.Windows.Shapes.Rectangle)(this.FindName("LivePreview")));
            this.LivePreviewTransform = ((System.Windows.Media.CompositeTransform)(this.FindName("LivePreviewTransform")));
            this.PointFocusBrackets = ((System.Windows.Controls.Grid)(this.FindName("PointFocusBrackets")));
            this.AutoFocusBrackets = ((System.Windows.Controls.Grid)(this.FindName("AutoFocusBrackets")));
            this.ChromeLayout = ((System.Windows.Controls.Grid)(this.FindName("ChromeLayout")));
            this.ShowArrowButton = ((System.Windows.Media.Animation.Storyboard)(this.FindName("ShowArrowButton")));
            this.HideArrowButton = ((System.Windows.Media.Animation.Storyboard)(this.FindName("HideArrowButton")));
            this.RotateArrowButtonToLandscape = ((System.Windows.Media.Animation.Storyboard)(this.FindName("RotateArrowButtonToLandscape")));
            this.RotateArrowButtonToPortrait = ((System.Windows.Media.Animation.Storyboard)(this.FindName("RotateArrowButtonToPortrait")));
            this.DisplayStatus = ((System.Windows.Media.Animation.Storyboard)(this.FindName("DisplayStatus")));
            this.LeftArrowButton = ((System.Windows.Controls.Button)(this.FindName("LeftArrowButton")));
            this.StatusText = ((System.Windows.Controls.TextBlock)(this.FindName("StatusText")));
            this.ReviewLayout = ((System.Windows.Controls.Grid)(this.FindName("ReviewLayout")));
            this.ReviewImageSlideOff = ((System.Windows.Media.Animation.Storyboard)(this.FindName("ReviewImageSlideOff")));
            this.ReviewImageSlideOffTranslateStart = ((System.Windows.Media.Animation.EasingDoubleKeyFrame)(this.FindName("ReviewImageSlideOffTranslateStart")));
            this.ReviewImageSlideOffTranslateEnd = ((System.Windows.Media.Animation.EasingDoubleKeyFrame)(this.FindName("ReviewImageSlideOffTranslateEnd")));
            this.ReviewImage = ((System.Windows.Shapes.Rectangle)(this.FindName("ReviewImage")));
        }
    }
}

