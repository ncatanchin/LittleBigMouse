﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace LittleBigMouse_Control.Plugins.Vcp
{
    /// <summary>
    /// Logique d'interaction pour ScreenGuiSizer.xaml
    /// </summary>
    public partial class VcpScreenView : UserControl
    {
        private VcpScreenViewModel ViewModel => (DataContext as VcpScreenViewModel);

        public VcpScreenView()
        {
            InitializeComponent();
        }

    private void ButtonOff_OnClick(object sender, RoutedEventArgs e)
    {
        if (ViewModel?.Vcp == null) return;
            ViewModel.Vcp.Power = false;
        }
        private void WakeUp_OnClick(object sender, RoutedEventArgs e)
        {
        if (ViewModel?.Vcp == null) return;
            ViewModel.Vcp.Power = true;
        }
        //private void ButtonOn_OnClick(object sender, RoutedEventArgs e)
        //{
        //    uint code = Convert.ToUInt32(txtCode.Text, 16);
        //    uint value = Convert.ToUInt32(txtValue.Text, 16);

        //    uint pvct;
        //    uint current;
        //    uint max;

        //    Dxva2.GetVCPFeatureAndVCPFeatureReply(ScreenGui.Screen.HPhysical, code, out pvct, out current, out max);

        //    Debug.Print(pvct.ToString() + ":" + current.ToString() + "<" + max.ToString());

        //    Dxva2.SetVCPFeature(ScreenGui.Screen.HPhysical, code, value);
        //    //for (uint i = 0; i < max; i++)
        //    //{
        //    //    if (i==5 && code==0xD6) continue; 
        //    //    bool result = Dxva2.SetVCPFeature(Screen.HPhysical, code, i);
        //    //    Debug.Print(i.ToString() + (result?":O":"X"));
        //    //}

        //    //IntPtr desk = User32.GetDesktopWindow();
        //    //IntPtr win = User32.FindWindowEx(IntPtr.Zero, IntPtr.Zero, null, null);

        //    //User32.SendMessage(-1, User32.WM_SYSCOMMAND, User32.SC_MONITORPOWER, 2);
        //    //User32.SendMessage(-1, User32.WM_SYSCOMMAND, User32.SC_MONITORPOWER, -1);
        //}

        private void ProbeLowLuminance_OnClick(object sender, RoutedEventArgs e)
        {
            ViewModel?.ProbeLowLuminance();
         }
        private void ProbeLuminance_OnClick(object sender, RoutedEventArgs e)
        {
            ViewModel?.ProbeLowLuminance();
        }

 
        private void Probe_OnClick(object sender, RoutedEventArgs e)
        {
            ViewModel?.Probe();
        }

        private void Tune_OnClick(object sender, RoutedEventArgs e)
        {
            ViewModel?.Tune();
        }


        private void UIElement_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
        }

        private void Save_OnClick(object sender, RoutedEventArgs e)
        {
            ViewModel?.Save();
        }
    }
}