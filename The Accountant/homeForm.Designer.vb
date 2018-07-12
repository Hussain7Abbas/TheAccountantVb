<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class homeForm
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
        Me.cashingDataGridView = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.newButton = New System.Windows.Forms.Button()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.editButton = New System.Windows.Forms.Button()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.constraintSortTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cashingSortTextBox = New System.Windows.Forms.TextBox()
        Me.constraintDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ادواتالتحكمToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.حولالبرنامجToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.اتصلبناToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.معلوماتحولالبرنامجToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.الابلاغعنمشكلةToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.اضافةسندصرفToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.حذفToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.تعديلToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.بحثToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.cashingDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.constraintDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cashingDataGridView
        '
        Me.cashingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.cashingDataGridView.Dock = System.Windows.Forms.DockStyle.Left
        Me.cashingDataGridView.Location = New System.Drawing.Point(0, 213)
        Me.cashingDataGridView.Name = "cashingDataGridView"
        Me.cashingDataGridView.Size = New System.Drawing.Size(619, 399)
        Me.cashingDataGridView.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.constraintSortTextBox)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cashingSortTextBox)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Tajawal", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1244, 213)
        Me.Panel1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.newButton)
        Me.GroupBox1.Controls.Add(Me.deleteButton)
        Me.GroupBox1.Controls.Add(Me.editButton)
        Me.GroupBox1.Controls.Add(Me.searchButton)
        Me.GroupBox1.Location = New System.Drawing.Point(625, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(607, 92)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ادوات التحكم"
        '
        'newButton
        '
        Me.newButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.newButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.newButton.FlatAppearance.BorderSize = 2
        Me.newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.newButton.Font = New System.Drawing.Font("Tajawal", 12.0!, System.Drawing.FontStyle.Bold)
        Me.newButton.ForeColor = System.Drawing.Color.Black
        Me.newButton.Location = New System.Drawing.Point(451, 30)
        Me.newButton.Name = "newButton"
        Me.newButton.Size = New System.Drawing.Size(149, 41)
        Me.newButton.TabIndex = 0
        Me.newButton.Text = "اضافة سند صرف"
        Me.newButton.UseVisualStyleBackColor = False
        '
        'deleteButton
        '
        Me.deleteButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.deleteButton.FlatAppearance.BorderSize = 2
        Me.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deleteButton.Font = New System.Drawing.Font("Tajawal", 12.0!, System.Drawing.FontStyle.Bold)
        Me.deleteButton.ForeColor = System.Drawing.Color.Black
        Me.deleteButton.Location = New System.Drawing.Point(306, 30)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(139, 41)
        Me.deleteButton.TabIndex = 2
        Me.deleteButton.Text = "حذف"
        Me.deleteButton.UseVisualStyleBackColor = False
        '
        'editButton
        '
        Me.editButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.editButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.editButton.FlatAppearance.BorderSize = 2
        Me.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.editButton.Font = New System.Drawing.Font("Tajawal", 12.0!, System.Drawing.FontStyle.Bold)
        Me.editButton.ForeColor = System.Drawing.Color.Black
        Me.editButton.Location = New System.Drawing.Point(161, 30)
        Me.editButton.Name = "editButton"
        Me.editButton.Size = New System.Drawing.Size(139, 41)
        Me.editButton.TabIndex = 3
        Me.editButton.Text = "تعديل"
        Me.editButton.UseVisualStyleBackColor = False
        '
        'searchButton
        '
        Me.searchButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.searchButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.searchButton.FlatAppearance.BorderSize = 2
        Me.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchButton.Font = New System.Drawing.Font("Tajawal", 12.0!, System.Drawing.FontStyle.Bold)
        Me.searchButton.ForeColor = System.Drawing.Color.Black
        Me.searchButton.Location = New System.Drawing.Point(16, 30)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(139, 41)
        Me.searchButton.TabIndex = 4
        Me.searchButton.Text = "بحث"
        Me.searchButton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(472, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 24)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "فرز برقم المستند:"
        '
        'constraintSortTextBox
        '
        Me.constraintSortTextBox.Location = New System.Drawing.Point(395, 179)
        Me.constraintSortTextBox.Name = "constraintSortTextBox"
        Me.constraintSortTextBox.Size = New System.Drawing.Size(71, 31)
        Me.constraintSortTextBox.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1094, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "فرز برقم المستند:"
        '
        'cashingSortTextBox
        '
        Me.cashingSortTextBox.Location = New System.Drawing.Point(1017, 179)
        Me.cashingSortTextBox.Name = "cashingSortTextBox"
        Me.cashingSortTextBox.Size = New System.Drawing.Size(71, 31)
        Me.cashingSortTextBox.TabIndex = 5
        '
        'constraintDataGridView
        '
        Me.constraintDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.constraintDataGridView.Dock = System.Windows.Forms.DockStyle.Right
        Me.constraintDataGridView.Location = New System.Drawing.Point(625, 213)
        Me.constraintDataGridView.Name = "constraintDataGridView"
        Me.constraintDataGridView.Size = New System.Drawing.Size(619, 399)
        Me.constraintDataGridView.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Navy
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Tajawal", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1244, 47)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "الرئيسية"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Navy
        Me.MenuStrip1.Font = New System.Drawing.Font("Tajawal", 10.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ادواتالتحكمToolStripMenuItem, Me.حولالبرنامجToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1244, 29)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ادواتالتحكمToolStripMenuItem
        '
        Me.ادواتالتحكمToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.اضافةسندصرفToolStripMenuItem, Me.حذفToolStripMenuItem, Me.تعديلToolStripMenuItem, Me.بحثToolStripMenuItem})
        Me.ادواتالتحكمToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ادواتالتحكمToolStripMenuItem.Name = "ادواتالتحكمToolStripMenuItem"
        Me.ادواتالتحكمToolStripMenuItem.Size = New System.Drawing.Size(100, 25)
        Me.ادواتالتحكمToolStripMenuItem.Text = "ادوات التحكم"
        '
        'حولالبرنامجToolStripMenuItem
        '
        Me.حولالبرنامجToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.اتصلبناToolStripMenuItem, Me.معلوماتحولالبرنامجToolStripMenuItem, Me.الابلاغعنمشكلةToolStripMenuItem})
        Me.حولالبرنامجToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.حولالبرنامجToolStripMenuItem.Name = "حولالبرنامجToolStripMenuItem"
        Me.حولالبرنامجToolStripMenuItem.Size = New System.Drawing.Size(98, 25)
        Me.حولالبرنامجToolStripMenuItem.Text = "حول البرنامج"
        '
        'اتصلبناToolStripMenuItem
        '
        Me.اتصلبناToolStripMenuItem.Name = "اتصلبناToolStripMenuItem"
        Me.اتصلبناToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.اتصلبناToolStripMenuItem.Text = "اتصل بنا"
        '
        'معلوماتحولالبرنامجToolStripMenuItem
        '
        Me.معلوماتحولالبرنامجToolStripMenuItem.Name = "معلوماتحولالبرنامجToolStripMenuItem"
        Me.معلوماتحولالبرنامجToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.معلوماتحولالبرنامجToolStripMenuItem.Text = "معلومات حول البرنامج"
        '
        'الابلاغعنمشكلةToolStripMenuItem
        '
        Me.الابلاغعنمشكلةToolStripMenuItem.Name = "الابلاغعنمشكلةToolStripMenuItem"
        Me.الابلاغعنمشكلةToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.الابلاغعنمشكلةToolStripMenuItem.Text = "الابلاغ عن مشكلة"
        '
        'اضافةسندصرفToolStripMenuItem
        '
        Me.اضافةسندصرفToolStripMenuItem.Name = "اضافةسندصرفToolStripMenuItem"
        Me.اضافةسندصرفToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.اضافةسندصرفToolStripMenuItem.Text = "اضافة سند صرف"
        '
        'حذفToolStripMenuItem
        '
        Me.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem"
        Me.حذفToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.حذفToolStripMenuItem.Text = "حذف"
        '
        'تعديلToolStripMenuItem
        '
        Me.تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem"
        Me.تعديلToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.تعديلToolStripMenuItem.Text = "تعديل"
        '
        'بحثToolStripMenuItem
        '
        Me.بحثToolStripMenuItem.Name = "بحثToolStripMenuItem"
        Me.بحثToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.بحثToolStripMenuItem.Text = "بحث"
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Location = New System.Drawing.Point(0, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1244, 1)
        Me.Label4.TabIndex = 12
        '
        'homeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1244, 612)
        Me.Controls.Add(Me.constraintDataGridView)
        Me.Controls.Add(Me.cashingDataGridView)
        Me.Controls.Add(Me.Panel1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "homeForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ادارة حسابات دائرة الكهرباء في الديوانية"
        CType(Me.cashingDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.constraintDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cashingDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents constraintDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents newButton As System.Windows.Forms.Button
    Friend WithEvents searchButton As System.Windows.Forms.Button
    Friend WithEvents editButton As System.Windows.Forms.Button
    Friend WithEvents deleteButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cashingSortTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents constraintSortTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ادواتالتحكمToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents اضافةسندصرفToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents حذفToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents تعديلToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents بحثToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents حولالبرنامجToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents اتصلبناToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents معلوماتحولالبرنامجToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents الابلاغعنمشكلةToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
