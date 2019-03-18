Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub
    Dim GraphicsFun As Graphics
    Dim colorfill, colorrer As Color

    Dim x, y As Int32
    Dim ifer As Boolean = True
    Private Sub Panel1_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel1.MouseClick
        GraphicsFun = Panel1.CreateGraphics
        Dim paned As New Pen(colorrer)
        If ifer = True Then
            XBOX1.Text = e.X
            YBOX1.Text = e.Y
            ifer = False
        Else
            XBOX2.Text = e.X
            YBOX2.Text = e.Y
            ifer = True
            If line.Checked = True Then GraphicsFun.DrawLine(paned, Convert.ToInt32(XBOX1.Text), Convert.ToInt32(YBOX1.Text), e.X, e.Y)
            If Squere.Checked = True Then Call drawingsquere(Convert.ToInt32(XBOX1.Text), Convert.ToInt32(YBOX1.Text), e.X, e.Y)
            If circle.Checked = True Then Call drawingcircle(Convert.ToInt32(XBOX1.Text), Convert.ToInt32(YBOX1.Text), e.X, e.Y)
        End If
    End Sub

    Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        XBOX.Text = e.X
        YBOX.Text = e.Y
    End Sub

    Sub drawingsquere(x1, y1, x2, y2)
        Dim paned As New Pen(colorrer)
        If x1 < x2 Then
            x = x2 - x1
        Else
            x = x1 - x2
        End If
        If y1 < y2 Then
            y = y2 - y1
            If filled.Checked = False Then
                GraphicsFun.DrawRectangle(paned, x1, y1, x, y)
            Else
                Dim brashed As New SolidBrush(colorfill)
                GraphicsFun.DrawRectangle(paned, x1, y1, x, y)
                GraphicsFun.FillRectangle(brashed, x1, y1, x, y)
            End If
        Else
            y = y1 - y2
            If filled.Checked = False Then
                GraphicsFun.DrawRectangle(paned, x2, y2, x, y)
            Else
                Dim brashed As New SolidBrush(colorfill)
                GraphicsFun.DrawRectangle(paned, x2, y2, x, y)
                GraphicsFun.FillRectangle(brashed, x2, y2, x, y)
            End If
        End If
    End Sub

    Sub drawingcircle(x1, y1, x2, y2)
        Dim paned As New Pen(colorrer)
        x = x2 - x1
        y = y2 - y1
        If filled.Checked = False Then
            GraphicsFun.DrawEllipse(paned, x1, y1, x, y)
        Else
            Dim brashed As New SolidBrush(colorfill)
            GraphicsFun.DrawEllipse(paned, x1, y1, x, y)
            GraphicsFun.FillEllipse(brashed, x1, y1, x, y)
        End If
    End Sub

    Sub xandy(x1 As Integer, y1 As Integer, x2 As Integer, y2 As Integer)
        If x1 < x2 Then
            x = x2 - x1
        Else
            x = x1 - x2
        End If
        If y1 < y2 Then
            y = y2 - y1
        Else
            y = y1 - y2
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            colorrer = ColorDialog1.Color
            Button3.BackColor = colorrer
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        colorfill = Color.Green
        colorrer = Color.Black
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ColorDialog2.ShowDialog() = DialogResult.OK Then
            colorfill = ColorDialog2.Color
            Button4.BackColor = colorfill
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GraphicsFun = Panel1.CreateGraphics
        GraphicsFun.Clear(Color.White)
    End Sub
End Class
