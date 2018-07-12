Public Class addForm
    Public classMain As New DataTable
    Public class2 As New DataTable
    Public class3 As New DataTable
    Public class4 As New DataTable
    Public class5 As New DataTable

    Private Sub addForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        classificationSystemModule.Search_Table("0", "3", classMain)

        class2ComboBox.DataSource = classMain
        class2ComboBox.ValueMember = "class2"
        class2ComboBox.DisplayMember = "name1"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub class2ComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles class2ComboBox.SelectedIndexChanged
        classMain.Clear()
        classificationSystemModule.Search_Table("0", "4", classMain)


        ' ================ Filter ================
        For i As Integer = 0 To classMain.Rows.Count - 1
            If classMain.Rows(i).Item("class3") <> 0 Then
                class3.NewRow.Item("name1") = classMain.Rows(i).Item("name1")
                class3.NewRow.Item("class3") = classMain.Rows(i).Item("class3")
            End If
        Next
        ' ================ Filter ================
        If class3.Rows.Count > 1 Then
            class3ComboBox.DataSource = class3
            class3ComboBox.ValueMember = "class3"
            class3ComboBox.DisplayMember = "name1"

            class3ComboBox.Visible = True
            Label2.Visible = True
        Else
            class3ComboBox.Visible = False
            Label2.Visible = False
        End If
    End Sub

    Private Sub class3ComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles class3ComboBox.SelectedIndexChanged
        classMain.Clear()
        classificationSystemModule.Search_Table("0", "5", classMain)


        ' ================ Filter ================
        For i As Integer = 0 To classMain.Rows.Count - 1
            If classMain.Rows(i).Item("class4") <> 0 Then
                class4.NewRow("name1") = classMain.Rows(i).Item("name1")
                class4.NewRow("class4") = classMain.Rows(i).Item("class4")
            End If
        Next
        ' ================ Filter ================
        If class4.Rows.Count > 1 Then
            class4ComboBox.DataSource = class4
            class4ComboBox.ValueMember = "class4"
            class4ComboBox.DisplayMember = "name1"

            class4ComboBox.Visible = True
            Label3.Visible = True
        Else
            class4ComboBox.Visible = False
            Label3.Visible = False
        End If
    End Sub

    Private Sub class4ComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles class4ComboBox.SelectedIndexChanged
        classMain.Clear()
        classificationSystemModule.Search_Table("0", "6", classMain)


        ' ================ Filter ================
        For i As Integer = 0 To classMain.Rows.Count - 1
            If classMain.Rows(i).Item("class5") <> 0 Then
                class5.NewRow("name1") = classMain.Rows(i).Item("name1")
                class5.NewRow("class5") = classMain.Rows(i).Item("class5")
            End If
        Next
        ' ================ Filter ================
        If class5.Rows.Count > 1 Then
            class5ComboBox.DataSource = class5
            class5ComboBox.ValueMember = "class5"
            class5ComboBox.DisplayMember = "name1"

            class5ComboBox.Visible = True
            Label4.Visible = True
        Else
            class5ComboBox.Visible = False
            Label4.Visible = False
        End If
    End Sub

End Class