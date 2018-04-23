Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.LookAndFeel
Imports DevExpress.Utils.Drawing

Namespace WindowsApplication18
    Friend Class MyUltraFlatLookAndFeelPainters
        Inherits UltraFlatLookAndFeelPainters

        Public Sub New(ByVal owner As UserLookAndFeel)
            MyBase.New(owner)
        End Sub
        Protected Overrides Function CreateButtonPainter() As ObjectPainter
            Return New MyUltraFlatButtonObjectPainter()
        End Function
    End Class
End Namespace
