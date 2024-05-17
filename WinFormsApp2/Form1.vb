Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text + "1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text + "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text + "3"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text + "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = TextBox1.Text + "5"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text + "6"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text + "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text + "8"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text + "9"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Label1.Text = TextBox1.Text
        Label2.Text = "+"
        TextBox1.Text = ""
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Label1.Text = TextBox1.Text
        Label2.Text = "-"
        TextBox1.Text = ""
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Label1.Text = TextBox1.Text
        Label2.Text = "/"
        TextBox1.Text = ""
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Label1.Text = TextBox1.Text
        Label2.Text = "*"
        TextBox1.Text = ""
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.Text = ""
        Label2.Text = ""
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click

        TextBox1.Text = ""
        Label2.Text = ""
        Label1.Text = ""
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim результат As Double
        Dim первоеЧисло As Double = Convert.ToDouble(Label1.Text)
        Dim второеЧисло As Double = Convert.ToDouble(TextBox1.Text)
        Dim операция As String = Label2.Text

        Select Case операция
            Case "+"
                результат = первоеЧисло + второеЧисло
            Case "-"
                результат = первоеЧисло - второеЧисло
            Case "*"
                результат = первоеЧисло * второеЧисло
            Case "/"
                If второеЧисло <> 0 Then
                    результат = первоеЧисло / второеЧисло
                Else
                    MessageBox.Show("Деление на ноль невозможно")
                    Exit Sub
                End If
            Case Else
                MessageBox.Show("Неизвестная операция")
                Exit Sub
        End Select

        TextBox1.Text = результат.ToString()
        Label1.Text = ""
        Label2.Text = ""
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TextBox1.Text = TextBox1.Text + ".36"
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        TextBox1.Text = TextBox1.Text + "0"
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        TextBox1.Text = TextBox1.Text + "00"
    End Sub
End Class
