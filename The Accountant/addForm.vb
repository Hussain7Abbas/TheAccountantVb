Public Class addForm

    Dim YAxis As Integer = -32 ' for adding TxtBoxPanel in new row
    Dim indexCount As Integer = 0

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim TxtBoxPanel As New Panel
        Dim LeftBox As New TextBox
        Dim CenterBox As New TextBox
        Dim RightBox As New TextBox

        'adding the textbox panel
        MajorPanel.Controls.Add(TxtBoxPanel)
        TxtBoxPanel.Name = ("txtBoxPanel" & indexCount)
        TxtBoxPanel.Size = New Size(610, 32)
        YAxis += 32
        TxtBoxPanel.Location = New Point(3, YAxis)

        'adding left box
        TxtBoxPanel.Controls.Add(LeftBox)
        LeftBox.Name = ("LeftBox" & indexCount)
        LeftBox.Text = (indexCount)
        LeftBox.Size = New Size(100, 20)
        LeftBox.Location = New Point(3, 3)

        'adding center box
        TxtBoxPanel.Controls.Add(CenterBox)
        CenterBox.Name = ("CenterBox" & indexCount)
        CenterBox.Text = (indexCount)
        CenterBox.Size = New Size(100, 20)
        CenterBox.Location = New Point(258, 3)

        'adding right box
        TxtBoxPanel.Controls.Add(RightBox)
        RightBox.Name = ("RightBox" & indexCount)
        RightBox.Size = New Size(100, 20)
        RightBox.Text = (indexCount)
        RightBox.Location = New Point(495, 3)

        indexCount += 1

    End Sub
End Class