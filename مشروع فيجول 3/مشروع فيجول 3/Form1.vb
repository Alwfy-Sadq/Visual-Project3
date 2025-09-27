Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' زر تنفيذ العملية
        Dim num1 As Double
        Dim num2 As Double
        Dim result As Double

        If Not Double.TryParse(TextBox1.Text, num1) Or Not Double.TryParse(TextBox2.Text, num2) Then
            MessageBox.Show("الرجاء إدخال أرقام صحيحة")
            Exit Sub
        End If

        If RadioButton1.Checked Then
            result = num1 + num2
        ElseIf RadioButton2.Checked Then
            result = num1 - num2
        ElseIf RadioButton3.Checked Then
            result = num1 * num2
        ElseIf RadioButton4.Checked Then
            If num2 = 0 Then
                MessageBox.Show("لا يمكن القسمة على صفر")
                Exit Sub
            End If
            result = num1 / num2
        Else
            MessageBox.Show("الرجاء اختيار العملية")
            Exit Sub
        End If

        TextBox3.Text = result.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' الانتقال إلى الآلة المتقدمة
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' زر الخروج
        Application.Exit()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class