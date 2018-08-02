Public Class addForm
    Public classMain As New DataTable
    Public class2 As New DataTable
    Public class3 As New DataTable
    Public class4 As New DataTable
    Public class5 As New DataTable
    Dim selectedValue As String
    Dim theComboboxNo As Integer



    Private Sub addForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        classificationSystemModule.Get_Table(classMain)

        class2 = classMain.Clone()
        For i As Integer = 0 To classMain.Rows.Count - 1
            If classMain.Rows(i).Item("decClass").ToString.Length = 2 Then
                class2.ImportRow(classMain.Rows(i))
                classMain.Rows(i).Delete()
                class2.Rows(class2.Rows.Count - 1).Item("name1") = class2.Rows(class2.Rows.Count - 1).Item("name1") & " ( " & class2.Rows(class2.Rows.Count - 1).Item("decClass") & " ) "
            End If
        Next
        classMain.AcceptChanges()


        class3 = classMain.Clone()
        For i As Integer = 0 To classMain.Rows.Count - 1
            If classMain.Rows(i).Item("decClass").ToString.Length = 3 Then
                class3.ImportRow(classMain.Rows(i))
                classMain.Rows(i).Delete()
            End If
        Next
        classMain.AcceptChanges()



        class4 = classMain.Clone()
        For i As Integer = 0 To classMain.Rows.Count - 1
            If classMain.Rows(i).Item("decClass").ToString.Length = 4 Then
                class4.ImportRow(classMain.Rows(i))
                classMain.Rows(i).Delete()
            End If
        Next
        classMain.AcceptChanges()



        class5 = classMain.Clone()
        For i As Integer = 0 To classMain.Rows.Count - 1
            If classMain.Rows(i).Item("decClass").ToString.Length = 5 Then
                class5.ImportRow(classMain.Rows(i))
                classMain.Rows(i).Delete()
            End If
        Next
        classMain.AcceptChanges()



        class2ComboBox.DataSource = class2
        class2ComboBox.ValueMember = "decClass"
        class2ComboBox.DisplayMember = "name1"

    End Sub

    Private Sub class2ComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles class2ComboBox.SelectedIndexChanged
        Timer1.Start()
        theComboboxNo = 2
    End Sub

    Private Sub class3ComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles class3ComboBox.SelectedIndexChanged
        Timer1.Start()
        theComboboxNo = 3
    End Sub

    Private Sub class4ComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles class4ComboBox.SelectedIndexChanged
        Timer1.Start()
        theComboboxNo = 4
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()

        Select Case theComboboxNo
            Case Is = 2
                comboBoxQuery(class3, 2, class2ComboBox, class3ComboBox, Label3)
            Case Is = 3
                comboBoxQuery(class4, 3, class3ComboBox, class4ComboBox, Label4)
            Case Is = 4
                comboBoxQuery(class5, 4, class4ComboBox, class5ComboBox, Label5)
        End Select
    End Sub

    Public Sub comboBoxQuery(ByVal theClass As DataTable, ByVal countOfDec As Integer, ByVal theCurrentComboBox As Windows.Forms.ComboBox, ByVal theComboBox As Windows.Forms.ComboBox, ByVal theLabel As Windows.Forms.Label)
        ' ================ Filter ================
        selectedValue = theCurrentComboBox.SelectedValue.ToString()
        Dim classQuery As DataTable = theClass.Clone()
        For i As Integer = 0 To theClass.Rows.Count - 1
            Dim decClass_Var As String = theClass.Rows(i).Item("decClass").ToString.Substring(0, countOfDec)
            If decClass_Var = selectedValue Then
                classQuery.ImportRow(theClass.Rows(i))
                classQuery.Rows(classQuery.Rows.Count - 1).Item("name1") = classQuery.Rows(classQuery.Rows.Count - 1).Item("name1") & " ( " & classQuery.Rows(classQuery.Rows.Count - 1).Item("decClass") & " ) "
            End If
        Next
        ' ================ Filter ================

        If classQuery.Rows.Count > 1 Then
            theComboBox.Visible = True
            theLabel.Visible = True
            theComboBox.DataSource = classQuery
            theComboBox.ValueMember = "decClass"
            theComboBox.DisplayMember = "name1"
            theComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            theComboBox.AutoCompleteSource = AutoCompleteSource.ListItems
        Else
            theComboBox.Visible = False
            theLabel.Visible = False
            If class4ComboBox.Visible = False Then
                class5ComboBox.Visible = False
                Label5.Visible = False
            End If
        End If
    End Sub

    Private Sub canceButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles canceButton.Click
        Close()
    End Sub

    Private Sub saveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saveButton.Click
        Close()
    End Sub
End Class