Public Class Form1
    Private mblntext_visible As Boolean

    Private mpntOutputTop As Point = New Point(50, 50)
    Private mpntOutputBottom As Point = New Point(300, 300)
    Private mpntContainerCenter As Point = New Point(180, 220)
    Private mblnIsCupVisible As Boolean = False
    Private msngSizeSelection As Single = 1
    Private mblnCup As Boolean = True
    Private mstrGroesse As String = "Extra Gross"
    Private mstrType As String = "er Becher"
    Private mstrGeschmack As String = " mit Schokoladeneis"
    Private mblnWhatsChanged() As Boolean = {False, False, False}

    'TODO: Rename Radiobuttons and Groupboxes!
    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        pnlSize.BorderStyle = BorderStyle.None
        cmbType.SelectedIndex = 0
        mblntext_visible = True
        toggleLables()
        rbtExtraGross.Select()
        lstGeschmack.SelectedIndex = 0
        cmbType.SelectedIndex = 1

    End Sub

    Private Sub lstGeschmack_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstGeschmack.SelectedIndexChanged
        mstrGeschmack = " mit " + lstGeschmack.SelectedItem.ToString + "eis."
        If lstGeschmack.SelectedIndex = 2 Then
            mstrGeschmack = " mit " + lstGeschmack.SelectedItem.ToString + "is." 'Erdbeereis
        ElseIf lstGeschmack.SelectedIndex = 0 Then
            mstrGeschmack = " mit " + lstGeschmack.SelectedItem.ToString + "neis." 'Schokoladeneis
        End If
        mblnWhatsChanged(2) = True
        AnimeOutputContainer(pnlOutputAll)
    End Sub


    Private Sub toggleLables()
        mblntext_visible = Not mblntext_visible
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

    Private Sub DrawCup(ByVal color As Color, ByRef pnl As Panel, ByVal blnAnimate As Boolean, Optional ByVal sngSizeMultiplier As Single = 1)
        Dim gr As Graphics = pnl.CreateGraphics
        'gr.Clear(Drawing.Color.WhiteSmoke)
        Dim sngHorizontalRadius As Single = 65 * sngSizeMultiplier
        Dim sngVerticalRaidus As Single = 20 * sngSizeMultiplier
        DrawEllipseInPanel(mpntContainerCenter, New Tuple(Of Integer, Integer)(sngHorizontalRadius, sngVerticalRaidus), pnl, color, True) 'Draw Top Opening
        'DrawElipseInPanel(pntCenterOpening, New Tuple(Of Integer, Integer)(1, 1), pnl, pen) ' Debug draw Centerpoint

        Dim rect As Rectangle = New Rectangle(mpntContainerCenter.X - 45 * sngSizeMultiplier, mpntContainerCenter.Y + 35 * sngSizeMultiplier, 90 * sngSizeMultiplier, 30 * sngSizeMultiplier)
        gr.DrawArc(New Pen(color), rect, 0, 179) ' Draw Bottom Arc
        gr.DrawLine(New Pen(color), New Point(mpntContainerCenter.X - 45 * sngSizeMultiplier, mpntContainerCenter.Y + 50 * sngSizeMultiplier), _
                    New Point(mpntContainerCenter.X - sngHorizontalRadius + 1, mpntContainerCenter.Y + 5 * sngSizeMultiplier)) ' Draw left Line
        gr.DrawLine(New Pen(color), New Point(mpntContainerCenter.X + 45 * sngSizeMultiplier, mpntContainerCenter.Y + 50 * sngSizeMultiplier), _
                    New Point(mpntContainerCenter.X + sngHorizontalRadius - 1, mpntContainerCenter.Y + 5 * sngSizeMultiplier)) ' Draw right Line
    End Sub

    Private Sub DrawCornet(ByVal pntCenterTop As Point, ByVal color As Color, ByRef pnl As Panel, ByVal blnAnimate As Boolean, Optional ByVal sngSizeMultiplier As Single = 1)
        Dim gr As Graphics = pnl.CreateGraphics
        'gr.Clear(Drawing.Color.WhiteSmoke)
        Dim sngHorizontalRadius As Single = 45 * sngSizeMultiplier
        Dim sngVerticalRaidus As Single = 17 * sngSizeMultiplier
        If sngSizeMultiplier > 0.99 Then
            sngHorizontalRadius = 45 * sngSizeMultiplier * 0.95
            sngVerticalRaidus = 17 * sngSizeMultiplier * 0.9
        End If


        Dim intDistanceFromBottom As Integer = 100
        DrawEllipseInPanel(pntCenterTop, New Tuple(Of Integer, Integer)(sngHorizontalRadius, sngVerticalRaidus), pnl, color, True) 'Draw Top Opening
        gr.DrawLine(New Pen(color), New Point(pntCenterTop.X - sngHorizontalRadius, pntCenterTop.Y), _
                    New Point(pntCenterTop.X, mpntOutputBottom.Y - 10 - intDistanceFromBottom * (1 - sngSizeMultiplier) ^ 3))
        gr.DrawLine(New Pen(color), New Point(pntCenterTop.X + sngHorizontalRadius, pntCenterTop.Y), _
                    New Point(pntCenterTop.X, mpntOutputBottom.Y - 10 - intDistanceFromBottom * (1 - sngSizeMultiplier) ^ 3))
    End Sub

    Private Sub DrawEllipseInPanel(ByVal pntCenter As Point, ByVal tplRadii As Tuple(Of Integer, Integer), ByRef pnl As Panel, ByVal color As Color, ByVal blnFill As Boolean)
        Dim gr As Graphics
        gr = pnl.CreateGraphics
        Dim rect As Rectangle = New Rectangle(pntCenter.X - tplRadii.Item1, pntCenter.Y - tplRadii.Item2, 2 * tplRadii.Item1, 2 * tplRadii.Item2)
        If blnFill Then
            gr.FillEllipse(New SolidBrush(color), rect)
        Else
            gr.DrawEllipse(New Pen(color), rect)
        End If
    End Sub

    Private Sub AnimeOutputContainer(ByRef pnl As Panel)
        lblSelection.Text = mstrGroesse + mstrType + mstrGeschmack
        Dim gr As Graphics = pnl.CreateGraphics
        gr.Clear(Color.WhiteSmoke)

        DrawOutput(mpntOutputTop, mpntOutputBottom, Color.Black, pnl)
        If mblnCup Then
            DrawCup(Color.Black, pnl, mblnWhatsChanged(0) Or mblnWhatsChanged(1), msngSizeSelection)
        Else
            DrawCornet(mpntContainerCenter, Color.Black, pnl, mblnWhatsChanged(0) Or mblnWhatsChanged(1), msngSizeSelection)
        End If
        pnl.Update()


    End Sub

    Private Function strToLower(ByVal str As String, ByVal intIndexOfCapital As Integer)
        Dim chrarray = str.ToCharArray
        For Int As Integer = 0 To chrarray.Length - 1
            chrarray(Int) = Char.ToLower(chrarray(Int))
        Next
        chrarray(intIndexOfCapital) = Char.ToUpper(chrarray(intIndexOfCapital))
        Return New String(chrarray)
    End Function

    Private Sub setButtonText(ByVal strText As String, ByVal sngNewSize As Single)
        msngSizeSelection = sngNewSize
        mstrGroesse = strToLower(strText, 0)
        mblnWhatsChanged(0) = True
    End Sub



    Private Sub pnlOutputAll_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles pnlOutputAll.Paint
        DrawOutput(mpntOutputTop, mpntOutputBottom, Color.Black, pnlOutputAll)
    End Sub

    Private Sub cmbType_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbType.SelectedIndexChanged
        mblnCup = CBool(cmbType.SelectedIndex)
        If mblnCup Then
            mstrType = "er " + cmbType.SelectedItem.ToString
        Else
            mstrType = "es " + cmbType.SelectedItem.ToString
        End If
        mblnWhatsChanged(1) = True
        AnimeOutputContainer(pnlOutputAll)
    End Sub

    Private Sub rbtExtraGross_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtExtraGross.CheckedChanged
        If rbtExtraGross.Checked Then
            setButtonText(rbtExtraGross.Text, 1)
        End If
        AnimeOutputContainer(pnlOutputAll)
    End Sub

    Private Sub rbtGross_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtGross.CheckedChanged
        If rbtGross.Checked Then
            setButtonText(rbtGross.Text, 0.8)
        End If
        AnimeOutputContainer(pnlOutputAll)
    End Sub

    Private Sub rbtMittel_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtMittel.CheckedChanged
        If rbtMittel.Checked Then
            setButtonText(rbtMittel.Text, 0.6)
        End If
        AnimeOutputContainer(pnlOutputAll)
    End Sub

    Private Sub rbtKlein_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtKlein.CheckedChanged
        If rbtKlein.Checked Then
            setButtonText(rbtKlein.Text, 0.4)
        End If
        AnimeOutputContainer(pnlOutputAll)
    End Sub

    Private Sub rbtSehrKlein_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtSehrKlein.CheckedChanged
        If rbtSehrKlein.Checked Then
            setButtonText(rbtSehrKlein.Text, 0.3)
        End If
        AnimeOutputContainer(pnlOutputAll)
    End Sub
End Class
