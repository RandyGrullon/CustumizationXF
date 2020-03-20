using Customization.Service;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Customization.ViewModels
{
    public class NotePageViewModel
    {
        public DelegateCommand RotationCommand { get; set; }
        public NotePageViewModel()
        {
            DependencyService.Get<IDependecyOrientationService>().GetOrientation();
        }
    }
}
