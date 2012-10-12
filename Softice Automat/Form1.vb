Public Class Form1
    Private text_visible As Boolean

    Private mpntOutputTop As Point = New Point(50, 50)
    Private mpntOutputBottom As Point = New Point(300, 300)
    Private mpntCupCenter As Point = New Point(180, 220)
    Private mblnIsCupVisible As Boolean = False

    'TODO: Rename Radiobuttons and Groupboxes!
    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        pnlSize.BorderStyle = BorderStyle.None
        cmbType.SelectedIndex = 0
        text_visible = True
        toggleLables()
        RadioButton1.Select()
        lstGeschmack.SelectedIndex = 0
        cmbType.SelectedIndex = 1
        DrawOutput(mpntOutputTop, mpntOutputBottom, Color.Black, pnlOutputAll)
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

    Private Sub pnlOutputAll_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles pnlOutputAll.MouseClick
        lblZuBezahlen.Text = "(" + CStr(e.Location.X) + ", " + CStr(e.Location.Y) + ")"
    End Sub



    Private Sub DrawOutput(ByVal pntTopLeft As Point, ByVal pntBottomRight As Point, ByVal color As Color, ByRef pnl As Panel)
        Dim intWidth As Integer = System.Math.Abs(pntBottomRight.X - pntTopLeft.X)
        Dim intHeight As Integer = System.Math.Abs(pntBottomRight.X - pntTopLeft.X)
        Dim pen As Pen = New Pen(color)
        Dim rect As Rectangle = New Rectangle(pntTopLeft.X, pntTopLeft.Y, intWidth, intHeight)
        Dim gr As Graphics = pnl.CreateGraphics
        gr.DrawRectangle(pen, rect)
        gr.DrawLine(pen, New Point(pntTopLeft.X + 1 / 3 * intWidth, pntBottomRight.Y - 1 / 3 * intHeight), New Point(pntTopLeft.X + 1 / 3 * intWidth, pntTopLeft.Y))
        gr.DrawLine(pen, New Point(pntTopLeft.X + 1 / 3 * intWidth, pntBottomRight.Y - 1 / 3 * intHeight), New Point(pntBottomRight.X, pntBottomRight.Y - 1 / 3 * intHeight))
    End Sub

    Private Sub DrawCup(ByVal pntCenterOpening As Point, ByVal color As Color, ByRef pnl As Panel)
        Dim gr As Graphics = pnl.CreateGraphics
        DrawElipseInPanel(pntCenterOpening, New Tuple(Of Integer, Integer)(65, 20), pnl, color) 'Draw Top Opening
        'DrawElipseInPanel(pntCenterOpening, New Tuple(Of Integer, Integer)(1, 1), pnl, pen) ' Debug draw Centerpoint

        Dim rect As Rectangle = New Rectangle(pntCenterOpening.X - 45, pntCenterOpening.Y + 35, 90, 30)
        gr.DrawArc(New Pen(color), rect, 0, 179) ' Draw Bottom Arc
        gr.DrawLine(New Pen(color), New Point(pntCenterOpening.X - 45, pntCenterOpening.Y + 50), New Point(pntCenterOpening.X - 64, pntCenterOpening.Y + 5)) ' Draw left Line
        gr.DrawLine(New Pen(color), New Point(pntCenterOpening.X + 45, pntCenterOpening.Y + 50), New Point(pntCenterOpening.X + 64, pntCenterOpening.Y + 5)) ' Draw right Line
    End Sub

    Private Sub DrawElipseInPanel(ByVal pntCenter As Point, ByVal tplRadii As Tuple(Of Integer, Integer), ByRef pnl As Panel, ByVal color As Color)
        Dim gr As Graphics
        gr = pnl.CreateGraphics
        Dim rect As Rectangle = New Rectangle(pntCenter.X - tplRadii.Item1, pntCenter.Y - tplRadii.Item2, 2 * tplRadii.Item1, 2 * tplRadii.Item2)
        gr.DrawEllipse(New Pen(color), rect)
        gr.FillEllipse(New SolidBrush(color), rect)
    End Sub

    Private Sub AnimateCup(ByRef pnl As Panel)

        Dim gr As Graphics = pnl.CreateGraphics
        If mblnIsCupVisible Then
            gr.Clear(Color.WhiteSmoke)
            DrawOutput(mpntOutputTop, mpntOutputBottom, Color.Black, pnlOutputAll)
        Else
            gr.Clear(Color.WhiteSmoke)
            DrawOutput(mpntOutputTop, mpntOutputBottom, Color.Black, pnlOutputAll)
            DrawCup(mpntCupCenter, Color.Black, pnlOutputAll)
        End If
        mblnIsCupVisible = Not mblnIsCupVisible
        pnl.Update()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        AnimateCup(pnlOutputAll)
    End Sub

End Class
