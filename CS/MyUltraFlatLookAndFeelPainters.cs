using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.LookAndFeel;
using DevExpress.Utils.Drawing;

namespace WindowsApplication18 {
    class MyUltraFlatLookAndFeelPainters : UltraFlatLookAndFeelPainters {
        public MyUltraFlatLookAndFeelPainters(UserLookAndFeel owner)
            : base(owner) {
        }
        protected override ObjectPainter CreateButtonPainter() {
            return new MyUltraFlatButtonObjectPainter();
        }
    }
}
