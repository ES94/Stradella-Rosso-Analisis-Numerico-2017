﻿#pragma checksum "..\..\ChartWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "60B20D0519DE27F1827376A18D5BCC05"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using AnalisisNumerico.UI;
using DynamicDataDisplay.Markers;
using DynamicDataDisplay.Markers.MarkerGenerators;
using Microsoft.Research.DynamicDataDisplay;
using Microsoft.Research.DynamicDataDisplay.Charts;
using Microsoft.Research.DynamicDataDisplay.Charts.Axes;
using Microsoft.Research.DynamicDataDisplay.Charts.Axes.Numeric;
using Microsoft.Research.DynamicDataDisplay.Charts.Isolines;
using Microsoft.Research.DynamicDataDisplay.Charts.Maps;
using Microsoft.Research.DynamicDataDisplay.Charts.Maps.Network;
using Microsoft.Research.DynamicDataDisplay.Charts.Navigation;
using Microsoft.Research.DynamicDataDisplay.Charts.NewLine;
using Microsoft.Research.DynamicDataDisplay.Charts.Selectors;
using Microsoft.Research.DynamicDataDisplay.Charts.Shapes;
using Microsoft.Research.DynamicDataDisplay.Common.Palettes;
using Microsoft.Research.DynamicDataDisplay.Converters;
using Microsoft.Research.DynamicDataDisplay.DataSources;
using Microsoft.Research.DynamicDataDisplay.Maps.Charts;
using Microsoft.Research.DynamicDataDisplay.Maps.Charts.TiledRendering;
using Microsoft.Research.DynamicDataDisplay.Maps.Charts.VectorFields.Streamlines;
using Microsoft.Research.DynamicDataDisplay.Maps.DeepZoom;
using Microsoft.Research.DynamicDataDisplay.Maps.Servers;
using Microsoft.Research.DynamicDataDisplay.Maps.Servers.FileServers;
using Microsoft.Research.DynamicDataDisplay.Maps.Servers.Network;
using Microsoft.Research.DynamicDataDisplay.Markers.MarkerGenerators.Rendering;
using Microsoft.Research.DynamicDataDisplay.MarkupExtensions;
using Microsoft.Research.DynamicDataDisplay.Navigation;
using Microsoft.Research.DynamicDataDisplay.PointMarkers;
using Microsoft.Research.DynamicDataDisplay.ViewportConstraints;
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


namespace AnalisisNumerico.UI {
    
    
    /// <summary>
    /// ChartWindow
    /// </summary>
    public partial class ChartWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\ChartWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal AnalisisNumerico.UI.ChartWindow winChart;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\ChartWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Research.DynamicDataDisplay.ChartPlotter cplGrafica;
        
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
            System.Uri resourceLocater = new System.Uri("/AnalisisNumerico.UI;component/chartwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ChartWindow.xaml"
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
            this.winChart = ((AnalisisNumerico.UI.ChartWindow)(target));
            return;
            case 2:
            this.cplGrafica = ((Microsoft.Research.DynamicDataDisplay.ChartPlotter)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

