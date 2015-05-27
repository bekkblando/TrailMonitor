//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrailCamera {
    using Gadgeteer;
    using GTM = Gadgeteer.Modules;
    
    
    public partial class Program : Gadgeteer.Program {
        
        /// <summary>The MotionSensor module using socket 14 of the mainboard.</summary>
        private Gadgeteer.Modules.GregHolliday.MotionSensor motionSensor;
        
        /// <summary>The WiFi RS21 module using socket 9 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.WiFiRS21 wifi;
        
        /// <summary>The TempHumid SI70 module using socket 12 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.TempHumidSI70 tempHumid;
        
        /// <summary>The Multicolor LED module using socket * of networkStatusLED.</summary>
        private Gadgeteer.Modules.GHIElectronics.MulticolorLED errorStatusLED;
        
        /// <summary>The Multicolor LED module using socket 10 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.MulticolorLED networkStatusLED;
        
        /// <summary>The USB Client DP module using socket 1 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.USBClientDP usbClientDP;
        
        /// <summary>The Character Display module using socket 8 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.CharacterDisplay characterDisplay;
        
        /// <summary>The Button module using socket 6 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.Button scrollDown;
        
        /// <summary>The Button module using socket 4 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.Button scrollUp;
        
        /// <summary>The SD Card module using socket 5 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.SDCard sdCard;
        
        /// <summary>The Camera module using socket 3 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.Camera camera;
        
        /// <summary>This property provides access to the Mainboard API. This is normally not necessary for an end user program.</summary>
        protected new static GHIElectronics.Gadgeteer.FEZSpider Mainboard {
            get {
                return ((GHIElectronics.Gadgeteer.FEZSpider)(Gadgeteer.Program.Mainboard));
            }
            set {
                Gadgeteer.Program.Mainboard = value;
            }
        }
        
        /// <summary>This method runs automatically when the device is powered, and calls ProgramStarted.</summary>
        public static void Main() {
            // Important to initialize the Mainboard first
            Program.Mainboard = new GHIElectronics.Gadgeteer.FEZSpider();
            Program p = new Program();
            p.InitializeModules();
            p.ProgramStarted();
            // Starts Dispatcher
            p.Run();
        }
        
        private void InitializeModules() {
            this.motionSensor = new GTM.GregHolliday.MotionSensor(14);
            this.wifi = new GTM.GHIElectronics.WiFiRS21(9);
            this.tempHumid = new GTM.GHIElectronics.TempHumidSI70(12);
            this.networkStatusLED = new GTM.GHIElectronics.MulticolorLED(10);
            this.errorStatusLED = new GTM.GHIElectronics.MulticolorLED(this.networkStatusLED.DaisyLinkSocketNumber);
            this.usbClientDP = new GTM.GHIElectronics.USBClientDP(1);
            this.characterDisplay = new GTM.GHIElectronics.CharacterDisplay(8);
            this.scrollDown = new GTM.GHIElectronics.Button(6);
            this.scrollUp = new GTM.GHIElectronics.Button(4);
            this.sdCard = new GTM.GHIElectronics.SDCard(5);
            this.camera = new GTM.GHIElectronics.Camera(3);
        }
    }
}