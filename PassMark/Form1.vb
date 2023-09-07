Public Class Form1
    Private Sub txtResults_Click(sender As Object, e As EventArgs) Handles txtResults.Click
        Dim Mark As Integer
        'Mark = txtMark.Text
        If (IsNumeric(txtMark.Text) = True) Then
            Mark = CInt(txtMark.Text)
            If (Mark < 0 And Mark > 100) Then
                MsgBox("invalid mark or mark out of bound")
            ElseIf (Mark < 50) Then
                MsgBox("You have failed this time around, work hard on your next assessment")
            ElseIf (Mark >= 50 And Mark < 75) Then
                MsgBox("You have passed but with average marks, do better next time")
            Else
                MsgBox("You have passed with distinction")
            End If
        Else
            MsgBox("You have entered a non-numeric mark try again with a  number or integer")
        End If
    End Sub
End Class

