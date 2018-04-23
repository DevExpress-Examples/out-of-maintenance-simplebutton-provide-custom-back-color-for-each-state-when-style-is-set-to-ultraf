using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Controls;
using DevExpress.LookAndFeel;

namespace WindowsApplication18 {
    public partial class Form1 : Form {
        public Form1() {
            SetMyUltraFlatPainter();
            InitializeComponent();
        }

        void SetMyUltraFlatPainter() {
            Type type = typeof(DevExpress.LookAndFeel.LookAndFeelPainterHelper);
            FieldInfo fi = type.GetField("painters", BindingFlags.Static | BindingFlags.NonPublic);
            BaseLookAndFeelPainters[] painters = (BaseLookAndFeelPainters[])fi.GetValue(null);
            painters[(int)ActiveLookAndFeelStyle.UltraFlat] = new MyUltraFlatLookAndFeelPainters(null);
        }
    } 
}