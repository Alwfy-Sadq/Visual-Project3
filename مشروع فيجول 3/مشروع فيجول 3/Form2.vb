Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' زر تنفيذ العملية
        Dim num1 As Double
        Dim num2 As Double
        Dim result As Double

        If Not Double.TryParse(TextBox1.Text, num1) Then
            MessageBox.Show("الرجاء إدخال العدد الأول بشكل صحيح")
            Exit Sub
        End If

        ' بعض العمليات تحتاج رقمين مثل باقي القسمة والرفع للقوة
        If (RadioButton1.Checked Or RadioButton2.Checked) And Not Double.TryParse(TextBox2.Text, num2) Then
            MessageBox.Show("الرجاء إدخال العدد الثاني بشكل صحيح")
            Exit Sub
        End If

        If RadioButton1.Checked Then
            result = num1 Mod num2
        ElseIf RadioButton2.Checked Then
            result = num1 ^ num2
        ElseIf RadioButton3.Checked Then
            If num1 < 0 Then
                MessageBox.Show("لا يمكن حساب الجذر التربيعي لعدد سالب")
                Exit Sub
            End If
            result = Math.Sqrt(num1)
        ElseIf RadioButton4.Checked Then
            result = Math.Abs(num1)
        Else
            MessageBox.Show("الرجاء اختيار العملية")
            Exit Sub
        End If

        TextBox3.Text = result.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' الرجوع إلى الآلة البسيطة
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged

    End Sub
End Class