Public Class Form1
    Dim text_visible As Boolean


    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        pnlSize.BorderStyle = BorderStyle.None
        cmbType.SelectedIndex = 0
        text_visible = True
        toggleLables()
        RadioButton1.Select()
        lstGeschmack.SelectedIndex = 0
        cmbType.SelectedIndex = 1
    End Sub

    Private Sub lstGeschmack_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstGeschmack.SelectedIndexChanged
        'lbl_geschmack.Text = CStr(lstGeschmack.SelectedItem)
        'lbl_size.Text =
    End Sub


    Private Sub toggleLables()
        text_visible = Not text_visible
        'lbl_geschmack.Visible = text_visible
        'lbl_size.Visible = text_visible
        'lbl_spacer.Visible = text_visible
        'lbl_type.Visible = text_visible
    End Sub

End Class
