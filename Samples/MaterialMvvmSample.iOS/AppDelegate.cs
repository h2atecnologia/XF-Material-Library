﻿using Foundation;
using MaterialMvvmSample.iOS.Core;
using UIKit;

namespace MaterialMvvmSample.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication uiApplication, NSDictionary launchOptions)
        {
            Rg.Plugins.Popup.Popup.Init();
            Xamarin.Forms.Forms.Init();
            XF.Material.iOS.Material.Init();

            var appContainer = new PlatformContainer();
            appContainer.Setup();

            LoadApplication(CommonServiceLocator.ServiceLocator.Current.GetInstance<App>());

            return base.FinishedLaunching(uiApplication, launchOptions);
        }
    }
}
