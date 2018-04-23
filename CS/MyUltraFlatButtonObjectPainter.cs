using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.Utils.Drawing;

namespace WindowsApplication18 {
    class MyUltraFlatButtonObjectPainter : UltraFlatButtonObjectPainter {

        readonly Color STATE_NORMAL = Color.Green;
        readonly Color STATE_HOTTRACK = Color.Yellow;
        readonly Color STATE_PRESSED = Color.Green;
        readonly Color STATE_DISABLED = Color.Gray;
        readonly Color STATE_FOCUSED = Color.Gold;

        protected override Brush GetHotBackBrush(ObjectInfoArgs e, bool pressed) {
            if(pressed) {
                return new SolidBrush(STATE_PRESSED);
            }
            return new SolidBrush(STATE_HOTTRACK);
        }
        protected override Color GetHotBorderColor(ObjectInfoArgs e, bool pressed) {
            if(pressed) {
                return STATE_PRESSED;
            }
            return STATE_HOTTRACK;
        }
        protected override void DrawSelectedFrame(ObjectInfoArgs e) {
            if(e.State == ObjectState.Selected) {
                base.DrawSelectedFrame(e);
            }
        }

        protected override Brush GetNormalBackBrush(ObjectInfoArgs e) {
            if(e.State == ObjectState.Selected) {
                return new SolidBrush(STATE_FOCUSED);
            }
            if(e.State == ObjectState.Disabled) {
                return new SolidBrush(STATE_DISABLED);
            }
            return new SolidBrush(STATE_NORMAL);
        }

    }
}
