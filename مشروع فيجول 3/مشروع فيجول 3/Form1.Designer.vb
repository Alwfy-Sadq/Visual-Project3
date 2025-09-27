<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(422, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ادخل العدد الأول"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AllowDrop = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(422, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ادخل العدد الثاني"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(422, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 27)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "الناتج"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(179, 192)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "العمليات الحسابية"
        '
        'RadioButton3
        '
        Me.RadioButton3.BackColor = System.Drawing.Color.LightSeaGreen
        Me.RadioButton3.Location = New System.Drawing.Point(31, 103)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadioButton3.Size = New System.Drawing.Size(113, 28)
        Me.RadioButton3.TabIndex = 9
        Me.RadioButton3.Text = "(*) الضرب"
        Me.RadioButton3.UseVisualStyleBackColor = False
        '
        'RadioButton4
        '
        Me.RadioButton4.BackColor = System.Drawing.Color.LightSeaGreen
        Me.RadioButton4.Location = New System.Drawing.Point(31, 147)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadioButton4.Size = New System.Drawing.Size(113, 28)
        Me.RadioButton4.TabIndex = 10
        Me.RadioButton4.Text = "(/) القسمة"
        Me.RadioButton4.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.RadioButton2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.RadioButton2.Location = New System.Drawing.Point(31, 64)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadioButton2.Size = New System.Drawing.Size(113, 28)
        Me.RadioButton2.TabIndex = 8
        Me.RadioButton2.Text = "(-) الطرح"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'RadioButton1
        '
        Me.RadioButton1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.RadioButton1.Location = New System.Drawing.Point(31, 24)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadioButton1.Size = New System.Drawing.Size(113, 28)
        Me.RadioButton1.TabIndex = 7
        Me.RadioButton1.Text = "(+) الجمع"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(291, 36)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(120, 24)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(291, 76)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(120, 24)
        Me.TextBox2.TabIndex = 5
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(291, 119)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(120, 24)
        Me.TextBox3.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(425, 170)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 27)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "تنفيذ العملية"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(291, 170)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 27)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "آلة حاسبة متقدمة"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(362, 213)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(120, 27)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "الخروج"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(564, 265)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents Label2 As Label
End Class
