<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addForm
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.saveButton = New System.Windows.Forms.Button()
        Me.canceButton = New System.Windows.Forms.Button()
        Me.class2ComboBox = New System.Windows.Forms.ComboBox()
        Me.class3ComboBox = New System.Windows.Forms.ComboBox()
        Me.class4ComboBox = New System.Windows.Forms.ComboBox()
        Me.class5ComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Navy
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tajawal", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(465, 47)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "اضافة سند صرف جديد"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'saveButton
        '
        Me.saveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.saveButton.BackColor = System.Drawing.Color.White
        Me.saveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.saveButton.FlatAppearance.BorderSize = 2
        Me.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.saveButton.Font = New System.Drawing.Font("Tajawal", 12.0!, System.Drawing.FontStyle.Bold)
        Me.saveButton.ForeColor = System.Drawing.Color.Black
        Me.saveButton.Location = New System.Drawing.Point(375, 3)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(87, 41)
        Me.saveButton.TabIndex = 12
        Me.saveButton.Text = "حفظ"
        Me.saveButton.UseVisualStyleBackColor = False
        '
        'canceButton
        '
        Me.canceButton.BackColor = System.Drawing.Color.White
        Me.canceButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.canceButton.FlatAppearance.BorderSize = 2
        Me.canceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.canceButton.Font = New System.Drawing.Font("Tajawal", 12.0!, System.Drawing.FontStyle.Bold)
        Me.canceButton.ForeColor = System.Drawing.Color.Black
        Me.canceButton.Location = New System.Drawing.Point(4, 3)
        Me.canceButton.Name = "canceButton"
        Me.canceButton.Size = New System.Drawing.Size(87, 41)
        Me.canceButton.TabIndex = 13
        Me.canceButton.Text = "الغاء"
        Me.canceButton.UseVisualStyleBackColor = False
        '
        'class2ComboBox
        '
        Me.class2ComboBox.FormattingEnabled = True
        Me.class2ComboBox.Location = New System.Drawing.Point(99, 66)
        Me.class2ComboBox.Name = "class2ComboBox"
        Me.class2ComboBox.Size = New System.Drawing.Size(354, 32)
        Me.class2ComboBox.TabIndex = 14
        '
        'class3ComboBox
        '
        Me.class3ComboBox.FormattingEnabled = True
        Me.class3ComboBox.Location = New System.Drawing.Point(99, 104)
        Me.class3ComboBox.Name = "class3ComboBox"
        Me.class3ComboBox.Size = New System.Drawing.Size(354, 32)
        Me.class3ComboBox.TabIndex = 15
        Me.class3ComboBox.Visible = False
        '
        'class4ComboBox
        '
        Me.class4ComboBox.FormattingEnabled = True
        Me.class4ComboBox.Location = New System.Drawing.Point(99, 142)
        Me.class4ComboBox.Name = "class4ComboBox"
        Me.class4ComboBox.Size = New System.Drawing.Size(354, 32)
        Me.class4ComboBox.TabIndex = 16
        Me.class4ComboBox.Visible = False
        '
        'class5ComboBox
        '
        Me.class5ComboBox.FormattingEnabled = True
        Me.class5ComboBox.Location = New System.Drawing.Point(99, 180)
        Me.class5ComboBox.Name = "class5ComboBox"
        Me.class5ComboBox.Size = New System.Drawing.Size(354, 32)
        Me.class5ComboBox.TabIndex = 17
        Me.class5ComboBox.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 24)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "الثنائي"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 24)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "الثلاثي"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 24)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "الرباعي"
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 24)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "الخماسي"
        Me.Label5.Visible = False
        '
        'Timer1
        '
        '
        'addForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(465, 514)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.class5ComboBox)
        Me.Controls.Add(Me.class4ComboBox)
        Me.Controls.Add(Me.class3ComboBox)
        Me.Controls.Add(Me.class2ComboBox)
        Me.Controls.Add(Me.canceButton)
        Me.Controls.Add(Me.saveButton)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tajawal", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "addForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "اضافة سند صرف جديد"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents saveButton As System.Windows.Forms.Button
    Friend WithEvents canceButton As System.Windows.Forms.Button
    Friend WithEvents class2ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents class3ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents class4ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents class5ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
