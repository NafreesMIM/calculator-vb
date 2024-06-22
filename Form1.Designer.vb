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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Addratio = New System.Windows.Forms.RadioButton()
        Me.subratio = New System.Windows.Forms.RadioButton()
        Me.Multiratio = New System.Windows.Forms.RadioButton()
        Me.Divratio = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(193, 45)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(157, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(193, 89)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(157, 20)
        Me.TextBox2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "1s No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(84, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "2nd No"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Divratio)
        Me.GroupBox1.Controls.Add(Me.Multiratio)
        Me.GroupBox1.Controls.Add(Me.subratio)
        Me.GroupBox1.Controls.Add(Me.Addratio)
        Me.GroupBox1.Location = New System.Drawing.Point(59, 128)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(115, 131)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operation"
        '
        'Addratio
        '
        Me.Addratio.AutoSize = True
        Me.Addratio.Location = New System.Drawing.Point(17, 26)
        Me.Addratio.Name = "Addratio"
        Me.Addratio.Size = New System.Drawing.Size(44, 17)
        Me.Addratio.TabIndex = 0
        Me.Addratio.TabStop = True
        Me.Addratio.Text = "Add"
        Me.Addratio.UseVisualStyleBackColor = True
        '
        'subratio
        '
        Me.subratio.AutoSize = True
        Me.subratio.Location = New System.Drawing.Point(18, 49)
        Me.subratio.Name = "subratio"
        Me.subratio.Size = New System.Drawing.Size(65, 17)
        Me.subratio.TabIndex = 1
        Me.subratio.TabStop = True
        Me.subratio.Text = "Subtract"
        Me.subratio.UseVisualStyleBackColor = True
        '
        'Multiratio
        '
        Me.Multiratio.AutoSize = True
        Me.Multiratio.Location = New System.Drawing.Point(18, 72)
        Me.Multiratio.Name = "Multiratio"
        Me.Multiratio.Size = New System.Drawing.Size(60, 17)
        Me.Multiratio.TabIndex = 2
        Me.Multiratio.TabStop = True
        Me.Multiratio.Text = "Multiply"
        Me.Multiratio.UseVisualStyleBackColor = True
        '
        'Divratio
        '
        Me.Divratio.AutoSize = True
        Me.Divratio.Location = New System.Drawing.Point(17, 95)
        Me.Divratio.Name = "Divratio"
        Me.Divratio.Size = New System.Drawing.Size(55, 17)
        Me.Divratio.TabIndex = 3
        Me.Divratio.TabStop = True
        Me.Divratio.Text = "Divide"
        Me.Divratio.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(59, 265)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 22)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Aswer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(106, 324)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 22)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(246, 324)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(115, 22)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Exite"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(193, 267)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(157, 20)
        Me.TextBox3.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 358)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Normal Cal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Divratio As RadioButton
    Friend WithEvents Multiratio As RadioButton
    Friend WithEvents subratio As RadioButton
    Friend WithEvents Addratio As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox3 As TextBox
End Class
