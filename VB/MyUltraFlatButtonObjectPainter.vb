Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports DevExpress.Utils.Drawing

Namespace WindowsApplication18
    Friend Class MyUltraFlatButtonObjectPainter
        Inherits UltraFlatButtonObjectPainter

        Private ReadOnly STATE_NORMAL As Color = Color.Green
        Private ReadOnly STATE_HOTTRACK As Color = Color.Yellow
        Private ReadOnly STATE_PRESSED As Color = Color.Green
        Private ReadOnly STATE_DISABLED As Color = Color.Gray
        Private ReadOnly STATE_FOCUSED As Color = Color.Gold

        Protected Overrides Function GetHotBackBrush(ByVal e As ObjectInfoArgs, ByVal pressed As Boolean) As Brush
            If pressed Then
                Return New SolidBrush(STATE_PRESSED)
            End If
            Return New SolidBrush(STATE_HOTTRACK)
        End Function
        Protected Overrides Function GetHotBorderColor(ByVal e As ObjectInfoArgs, ByVal pressed As Boolean) As Color
            If pressed Then
                Return STATE_PRESSED
            End If
            Return STATE_HOTTRACK
        End Function
        Protected Overrides Sub DrawSelectedFrame(ByVal e As ObjectInfoArgs)
            If e.State = ObjectState.Selected Then
                MyBase.DrawSelectedFrame(e)
            End If
        End Sub

        Protected Overrides Function GetNormalBackBrush(ByVal e As ObjectInfoArgs) As Brush
            If e.State = ObjectState.Selected Then
                Return New SolidBrush(STATE_FOCUSED)
            End If
            If e.State = ObjectState.Disabled Then
                Return New SolidBrush(STATE_DISABLED)
            End If
            Return New SolidBrush(STATE_NORMAL)
        End Function

    End Class
End Namespace
