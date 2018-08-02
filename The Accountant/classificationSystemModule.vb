Imports System.Data.OleDb
Module classificationSystemModule
    ' ========================================================= Variables =========================================================
    Public databaseName As String = "db1"
    Public tableName As String = "classificationTable"

    Public DataAdapter_Var As New OleDbDataAdapter
    Public DataTable_Var As New DataTable
    Public Save_Var As New OleDbCommandBuilder
    Public postion As Integer


    ' الاتصال بقاعدة بيانات اكسس 2003
    Public connAccess2003 As New OleDbConnection("provider=Microsoft.jet.OLEDB.4.0;" & "data source=" & Application.StartupPath & "\" & databaseName & ".mdb")

    ' ========================================================= Functions =========================================================

    Sub Load_Table(ByVal DataGridView_Name As Windows.Forms.DataGridView, Optional ByVal Table_Name As String = "")
        'كوداللود
        DataTable_Var.Clear()
        DataAdapter_Var = New OleDb.OleDbDataAdapter("select * from " & tableName & Table_Name, connAccess2003)
        DataAdapter_Var.Fill(DataTable_Var)
        DataGridView_Name.DataSource = DataTable_Var
    End Sub

    Sub Get_Table(ByVal TableVar As DataTable, Optional ByVal Table_Name As String = "")
        'كوداللود
        TableVar.Clear()
        DataAdapter_Var = New OleDb.OleDbDataAdapter("select * from " & tableName & Table_Name, connAccess2003)
        DataAdapter_Var.Fill(TableVar)
    End Sub

    Sub Save_Table()
        ' حفظ
        Save_Var = New OleDbCommandBuilder(DataAdapter_Var)
        DataAdapter_Var.Update(DataTable_Var)
        DataTable_Var.AcceptChanges()
    End Sub
    Public Sub Add_Row(ByVal Column_Name As String, ByVal The_Value As String)
        DataTable_Var.Rows(postion).Item(Column_Name) = The_Value
    End Sub
    Public Sub Edit_Row(ByVal Column_Name As String, ByVal The_Value As String)
        DataTable_Var.Rows(postion).Item(Column_Name) = The_Value
    End Sub
    Public Sub Load_Into_Control(ByVal Column_Name As String, ByVal Control_Name As Windows.Forms.Control)
        Control_Name.Text = DataTable_Var.Rows(postion).Item(Column_Name)
    End Sub
    Sub Delete_Row(ByVal Form_Name As Form, ByVal DataGridView_Name As Windows.Forms.DataGridView)
        MessageBox.Show("انت على وشك حذف هذه التسجيلة هل تريد الاستمرار؟", "حذف", System.Windows.Forms.MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If DialogResult.Yes Then
            postion = Form_Name.BindingContext(DataTable_Var).Position
            DataTable_Var.Rows(postion).Delete()
            Save_Table()
            Load_Table(DataGridView_Name)
            Form_Name.BindingContext(DataTable_Var).Position = postion
        ElseIf Not DialogResult.Yes Then

        End If
    End Sub
    Sub Search_Table(ByVal searchKeyWord As String _
                     , ByVal Class_No As String _
                     , ByVal dataTable As DataTable _
                     , Optional ByVal Table_Name As String = "")
        DataTable_Var.Clear()
        DataAdapter_Var = New OleDb.OleDbDataAdapter("select * from " & tableName & Table_Name & " where class" & Class_No & " like '%" & searchKeyWord & "%'", connAccess2003)
        DataAdapter_Var.Fill(dataTable)
    End Sub

    Public Sub Change_Column_Header(ByVal DataGridView_Name As Windows.Forms.DataGridView, ByVal Column_Name As String, ByVal Column_Header As String)
        DataGridView_Name.Columns(Column_Name).HeaderText = Column_Header
    End Sub
    Public Sub Change_Column_Width(ByVal DataGridView_Name As Windows.Forms.DataGridView, ByVal Column_Name As String, ByVal Width_Value As Byte)
        DataGridView_Name.Columns(Column_Name).Width = Width_Value
    End Sub
    Public Sub Change_Column_Visability(ByVal DataGridView_Name As Windows.Forms.DataGridView, ByVal Column_Name As String, ByVal Boolean_Value As Boolean)
        DataGridView_Name.Columns(Column_Name).Visible = Boolean_Value
    End Sub
End Module
