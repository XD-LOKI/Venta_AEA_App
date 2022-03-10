using System;
using System.Collections.Generic;
using System.Text;
using Venta_AEA_App.ViewModels;

namespace Venta_AEA_App.Infrastructure
{
    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }
        public InstanceLocator()
        {
            Main = new MainViewModel();
        }
    }
}
