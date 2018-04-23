Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Reflection
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.LookAndFeel

Namespace WindowsApplication18
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            SetMyUltraFlatPainter()
            InitializeComponent()
        End Sub

        Private Sub SetMyUltraFlatPainter()
            Dim type As Type = GetType(DevExpress.LookAndFeel.LookAndFeelPainterHelper)
            Dim fi As FieldInfo = type.GetField("painters", BindingFlags.Static Or BindingFlags.NonPublic)
            Dim painters() As BaseLookAndFeelPainters = DirectCast(fi.GetValue(Nothing), BaseLookAndFeelPainters())
            painters(CInt((ActiveLookAndFeelStyle.UltraFlat))) = New MyUltraFlatLookAndFeelPainters(Nothing)
        End Sub
    End Class
End Namespace