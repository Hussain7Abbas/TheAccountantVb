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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MajorPanel = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(263, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(223, 41)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "اضافة"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MajorPanel
        '
        Me.MajorPanel.Location = New System.Drawing.Point(12, 54)
        Me.MajorPanel.Name = "MajorPanel"
        Me.MajorPanel.Size = New System.Drawing.Size(725, 386)
        Me.MajorPanel.TabIndex = 2
        '
        'addForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 452)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MajorPanel)
        Me.Name = "addForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MajorPanel As System.Windows.Forms.Panel
End Class
