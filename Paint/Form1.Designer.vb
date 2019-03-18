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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.XBOX = New System.Windows.Forms.TextBox()
        Me.YBOX = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.circle = New System.Windows.Forms.RadioButton()
        Me.Squere = New System.Windows.Forms.RadioButton()
        Me.line = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.YBOX1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.XBOX1 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.filled = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.YBOX2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.XBOX2 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ColorDialog2 = New System.Windows.Forms.ColorDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(935, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(36, 33)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'XBOX
        '
        Me.XBOX.Location = New System.Drawing.Point(818, 620)
        Me.XBOX.Name = "XBOX"
        Me.XBOX.ReadOnly = True
        Me.XBOX.Size = New System.Drawing.Size(61, 20)
        Me.XBOX.TabIndex = 2
        Me.XBOX.Text = "0"
        Me.XBOX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'YBOX
        '
        Me.YBOX.Location = New System.Drawing.Point(910, 620)
        Me.YBOX.Name = "YBOX"
        Me.YBOX.ReadOnly = True
        Me.YBOX.Size = New System.Drawing.Size(61, 20)
        Me.YBOX.TabIndex = 5
        Me.YBOX.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(885, 620)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "X"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.circle)
        Me.GroupBox1.Controls.Add(Me.Squere)
        Me.GroupBox1.Controls.Add(Me.line)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(228, 279)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Панель инструментов"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Black
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Location = New System.Drawing.Point(142, 20)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(31, 30)
        Me.Button3.TabIndex = 9
        Me.Button3.UseVisualStyleBackColor = False
        '
        'circle
        '
        Me.circle.Appearance = System.Windows.Forms.Appearance.Button
        Me.circle.AutoSize = True
        Me.circle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.circle.Location = New System.Drawing.Point(93, 25)
        Me.circle.Name = "circle"
        Me.circle.Size = New System.Drawing.Size(48, 39)
        Me.circle.TabIndex = 9
        Me.circle.TabStop = True
        Me.circle.Text = "○"
        Me.circle.UseVisualStyleBackColor = True
        '
        'Squere
        '
        Me.Squere.Appearance = System.Windows.Forms.Appearance.Button
        Me.Squere.AutoSize = True
        Me.Squere.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Squere.Location = New System.Drawing.Point(48, 25)
        Me.Squere.Name = "Squere"
        Me.Squere.Size = New System.Drawing.Size(39, 39)
        Me.Squere.TabIndex = 8
        Me.Squere.TabStop = True
        Me.Squere.Text = "□"
        Me.Squere.UseVisualStyleBackColor = True
        '
        'line
        '
        Me.line.Appearance = System.Windows.Forms.Appearance.Button
        Me.line.AutoSize = True
        Me.line.Checked = True
        Me.line.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.line.Location = New System.Drawing.Point(11, 25)
        Me.line.Name = "line"
        Me.line.Size = New System.Drawing.Size(31, 39)
        Me.line.TabIndex = 0
        Me.line.TabStop = True
        Me.line.Text = "/"
        Me.line.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.YBOX1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.XBOX1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(6, 25)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(216, 46)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Первая точка"
        '
        'YBOX1
        '
        Me.YBOX1.Location = New System.Drawing.Point(115, 20)
        Me.YBOX1.Name = "YBOX1"
        Me.YBOX1.Size = New System.Drawing.Size(61, 22)
        Me.YBOX1.TabIndex = 7
        Me.YBOX1.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(90, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "X"
        '
        'XBOX1
        '
        Me.XBOX1.Location = New System.Drawing.Point(23, 20)
        Me.XBOX1.Name = "XBOX1"
        Me.XBOX1.Size = New System.Drawing.Size(61, 22)
        Me.XBOX1.TabIndex = 7
        Me.XBOX1.Text = "0"
        Me.XBOX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.filled)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 409)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(228, 205)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Свойства инструмента"
        '
        'filled
        '
        Me.filled.Appearance = System.Windows.Forms.Appearance.Button
        Me.filled.BackColor = System.Drawing.Color.White
        Me.filled.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.filled.Location = New System.Drawing.Point(29, 129)
        Me.filled.Name = "filled"
        Me.filled.Size = New System.Drawing.Size(152, 33)
        Me.filled.TabIndex = 9
        Me.filled.Text = "Залить цветом"
        Me.filled.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.YBOX2)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.XBOX2)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(6, 77)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(216, 46)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Вторая точка"
        '
        'YBOX2
        '
        Me.YBOX2.Location = New System.Drawing.Point(115, 20)
        Me.YBOX2.Name = "YBOX2"
        Me.YBOX2.Size = New System.Drawing.Size(61, 22)
        Me.YBOX2.TabIndex = 7
        Me.YBOX2.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(90, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "X"
        '
        'XBOX2
        '
        Me.XBOX2.Location = New System.Drawing.Point(23, 20)
        Me.XBOX2.Name = "XBOX2"
        Me.XBOX2.Size = New System.Drawing.Size(61, 22)
        Me.XBOX2.TabIndex = 7
        Me.XBOX2.Text = "0"
        Me.XBOX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(246, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(725, 563)
        Me.Panel1.TabIndex = 7
        Me.Panel1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button2.Location = New System.Drawing.Point(246, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 33)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Очистить"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.White
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.Button4)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.Button3)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(12, 297)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(228, 106)
        Me.GroupBox5.TabIndex = 10
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Цвета"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Цвет обводки"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Green
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Location = New System.Drawing.Point(142, 56)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(31, 30)
        Me.Button4.TabIndex = 12
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Цвет заливки"
        '
        'ColorDialog2
        '
        Me.ColorDialog2.Color = System.Drawing.Color.Green
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 645)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.YBOX)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.XBOX)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents XBOX As TextBox
    Friend WithEvents YBOX As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents YBOX1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents XBOX1 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents YBOX2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents XBOX2 As TextBox
    Friend WithEvents line As RadioButton
    Friend WithEvents Panel1 As PictureBox
    Friend WithEvents Squere As RadioButton
    Friend WithEvents circle As RadioButton
    Friend WithEvents Button2 As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents filled As CheckBox
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ColorDialog2 As ColorDialog
End Class
