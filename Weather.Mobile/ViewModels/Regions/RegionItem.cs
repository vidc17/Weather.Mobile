using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Mobile.ViewModels.Regions
{
    public partial class RegionItem : ObservableObject
    {
        public string Name { get; set; }
        public string URL { get; set; }

        public bool IsCountry { get; set; }

        [ObservableProperty]
        private bool _isOpenInProgress;
    }
}
