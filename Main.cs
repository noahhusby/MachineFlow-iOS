using System;
using System.Drawing;

using CoreGraphics;
using Foundation;
using UIKit;

namespace MachineFlow_iOS
{
    [Register("Main")]
    public class Main : UIView
    {
        public Main()
        {
            Initialize();
        }

        public Main(RectangleF bounds) : base(bounds)
        {
            Initialize();
        }

        void Initialize()
        {
            BackgroundColor = UIColor.Red;
        }
    }
}