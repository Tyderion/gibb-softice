Public Class Form1
    Private mblntext_visible As Boolean


    ' Variables defining the output section
    Private mpntOutputTop As Point = New Point(20, 50)
    Private mpntOutputBottom As Point = New Point(300, 300)
    ' Variables for the Animation
    Private mblnRedrawChangeHappened = False
    Private msngContainerHeight As Single
    Private msngHeightTimer As Single = 1

    ' Variables representing the selection
    Private mblnIsCupVisible As Boolean = False
    Private msngSizeSelection As Single = 1
    Private mblnCup As Boolean = True


    ' Strings to represent the selection
    Private mstrGroesse As String = "Extra Gross"
    Private mstrType As String = "er Becher"
    Private mstrGeschmack As String = " mit Schokoladeneis"


    ' Variables to track how much it costs and how much ahs been paid
    Private msngPreis As Single
    Private msngBezahlt As Single = 0

    ' Variables for the coin values, images and signs
    Private msngCoinValues() As Single = {5, 2, 1, 0.5, 0.2, 0.1}
    Private mimgCoinImages() As Image
    Private msngCoinSizes() As Single = {1, 0.8, 0.65, 0.45, 0.54, 0.43}

    'TODO: Rename Radiobuttons and Groupboxes!
    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        pnlSize.BorderStyle = BorderStyle.None
        cmbType.SelectedIndex = 0
        mblntext_visible = True
        toggleLables()
        rbtExtraGross.Select()
        lstGeschmack.SelectedIndex = 0
        cmbType.SelectedIndex = 1
        pnlContainer.BringToFront()
        mimgCoinImages = {pic5Fr.Image, pic2Fr.Image, pic1Fr.Image, pic50rp.Image, pic20rp.Image, pic10rp.Image}
    End Sub

    Private Sub lstGeschmack_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstGeschmack.SelectedIndexChanged
        mstrGeschmack = " mit " + lstGeschmack.SelectedItem.ToString + "eis."
        If lstGeschmack.SelectedIndex = 2 Then
            mstrGeschmack = " mit " + lstGeschmack.SelectedItem.ToString + "is." 'Erdbeereis
        ElseIf lstGeschmack.SelectedIndex = 0 Then
            mstrGeschmack = " mit " + lstGeschmack.SelectedItem.ToString + "neis." 'Schokoladeneis
        End If
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

    Private Sub DrawCup(ByVal color As Color, ByRef pnlOutput As Panel, ByVal blnAnimate As Boolean, Optional ByVal sngSizeMultiplier As Single = 1)
        Dim gr As Graphics = pnlOutput.CreateGraphics
        gr.Clear(Drawing.Color.WhiteSmoke)

        Dim sngHorizontalRadius As Single = 65 * sngSizeMultiplier
        Dim sngVerticalRaidus As Single = 20 * sngSizeMultiplier
        Dim pntCenterTop As Point = New Point(sngHorizontalRadius, sngVerticalRaidus)
        pnlOutput.Dock = DockStyle.None

        msngContainerHeight = 2 * sngVerticalRaidus + (pntCenterTop.Y + 50 * sngSizeMultiplier) - (pntCenterTop.Y + 5 * sngSizeMultiplier) + 30 * sngSizeMultiplier * 0.3
        pnlOutput.Width = 2 * sngHorizontalRadius + 2
        pnlOutput.Update()
        DrawEllipseInPanel(pntCenterTop, New Tuple(Of Integer, Integer)(sngHorizontalRadius, sngVerticalRaidus), pnlOutput, color, True) 'Draw Top Opening

        Dim rect As Rectangle = New Rectangle(pntCenterTop.X - 45 * sngSizeMultiplier, pntCenterTop.Y + 35 * sngSizeMultiplier, 90 * sngSizeMultiplier, 30 * sngSizeMultiplier)
        gr.DrawArc(New Pen(color), rect, 0, 179) ' Draw Bottom Arc
        gr.DrawLine(New Pen(color), New Point(pntCenterTop.X - 45 * sngSizeMultiplier, pntCenterTop.Y + 50 * sngSizeMultiplier), _
                    New Point(pntCenterTop.X - sngHorizontalRadius + 1, pntCenterTop.Y + 5 * sngSizeMultiplier)) ' Draw left Line
        gr.DrawLine(New Pen(color), New Point(pntCenterTop.X + 45 * sngSizeMultiplier, pntCenterTop.Y + 50 * sngSizeMultiplier), _
                    New Point(pntCenterTop.X + sngHorizontalRadius - 1, pntCenterTop.Y + 5 * sngSizeMultiplier)) ' Draw right Line

    End Sub

    Private Sub DrawCornet(ByVal color As Color, ByRef pnlOutput As Panel, ByVal blnAnimate As Boolean, Optional ByVal sngSizeMultiplier As Single = 1)
        Dim gr As Graphics = pnlOutput.CreateGraphics
        gr.Clear(Drawing.Color.WhiteSmoke)
        Dim sngHorizontalRadius As Single = 45 * sngSizeMultiplier
        Dim sngVerticalRaidus As Single = 17 * sngSizeMultiplier
        Dim intHeight As Integer = 100
        Dim pntCenterTop As Point = New Point(sngHorizontalRadius, sngVerticalRaidus)
        If sngSizeMultiplier > 0.99 Then
            sngHorizontalRadius = 45 * sngSizeMultiplier * 0.95
            sngVerticalRaidus = 17 * sngSizeMultiplier * 0.9
        End If

        msngContainerHeight = 2 * sngVerticalRaidus + Math.Abs(pntCenterTop.Y - (pntCenterTop.Y + intHeight * sngSizeMultiplier))
        pnlOutput.Width = 2 * sngHorizontalRadius + 8
        pnlOutput.Update()
        DrawEllipseInPanel(pntCenterTop, New Tuple(Of Integer, Integer)(sngHorizontalRadius, sngVerticalRaidus), pnlOutput, color, True) 'Draw Top Opening
        gr.DrawLine(New Pen(color), New Point(pntCenterTop.X - sngHorizontalRadius, pntCenterTop.Y), _
                    New Point(pntCenterTop.X, pntCenterTop.Y + intHeight * sngSizeMultiplier))
        gr.DrawLine(New Pen(color), New Point(pntCenterTop.X + sngHorizontalRadius, pntCenterTop.Y), _
                    New Point(pntCenterTop.X, pntCenterTop.Y + intHeight * sngSizeMultiplier))

    End Sub

    Private Sub DrawEllipseInPanel(ByVal pntCenter As Point, ByVal tplRadii As Tuple(Of Integer, Integer), ByRef pnl As Panel, ByVal color As Color, ByVal blnFill As Boolean)
        Dim gr As Graphics = pnl.CreateGraphics
        Dim rect As Rectangle = New Rectangle(pntCenter.X - tplRadii.Item1, pntCenter.Y - tplRadii.Item2, 2 * tplRadii.Item1, 2 * tplRadii.Item2)
        If blnFill Then
            gr.FillEllipse(New SolidBrush(color), rect)
        Else
            gr.DrawEllipse(New Pen(color), rect)
        End If
    End Sub


    Private Sub tmrContainerAnimation_Tick(sender As Object, e As EventArgs) Handles tmrContainerAnimation.Tick
        pnlContainer.Height = msngHeightTimer
        pnlContainer.Location = New Point(pnlOutputAll.Width / 2 - 20 - 50 * msngSizeSelection + pnlOutputAll.Location.X, _
                                          (pnlOutputAll.Height - 50 - 30 * (1 - msngSizeSelection)) - msngHeightTimer + pnlOutputAll.Location.Y)
        msngHeightTimer += 0.8
        If mblnCup Then
            DrawCup(Color.Black, pnlContainer, mblnRedrawChangeHappened, msngSizeSelection)

        Else
            DrawCornet(Color.Black, pnlContainer, mblnRedrawChangeHappened, msngSizeSelection)
        End If
        If msngHeightTimer >= msngContainerHeight Then
            msngHeightTimer = 1
            tmrContainerAnimation.Stop()
        End If

    End Sub

    Private Function sngRealCost() As Single
        Return msngPreis * If(mblnCup, 0.8, 1.0)
    End Function
    Private Sub updatePreis()
        lblPreisFr.Text = "CHF " + sngRealCost().ToString("F")
        lblBezahltFr.Text = "CHF " + msngBezahlt.ToString("F")
        lblZuBezahlenFr.Text = "CHF " + (sngRealCost() - msngBezahlt).ToString("F")
        lblError.Text = ""

    End Sub




    Private Sub AnimeOutputContainer(ByRef pnl As Panel)
        If mblnRedrawChangeHappened Then
            msngHeightTimer = 1
            tmrContainerAnimation.Stop()
            mblnRedrawChangeHappened = False
        End If

        lblSelection.Text = mstrGroesse + mstrType + mstrGeschmack
        updatePreis()

        Dim gr As Graphics = pnl.CreateGraphics
        gr.Clear(Color.WhiteSmoke)

        DrawOutput(mpntOutputTop, mpntOutputBottom, Color.Black, pnl)
        tmrContainerAnimation.Start()
        'DrawCornet(Color.Black, pnlContainer, mblnWhatsChanged(0) Or mblnWhatsChanged(1), msngSizeSelection)
        'If mblnCup Then
        '    'DrawCup(Color.Black, pnlContainer, mblnWhatsChanged(0) Or mblnWhatsChanged(1), msngSizeSelection)
        '    'DrawCup(Color.Black, pnlContainer, mblnWhatsChanged(0) Or mblnWhatsChanged(1), msngSizeSelection)
        '    'pnlContainer.Height = 25
        'Else
        '    DrawCornet(mpntContainerCenter, Color.Black, pnl, mblnWhatsChanged(0) Or mblnWhatsChanged(1), msngSizeSelection)
        'End If

    End Sub

    Private Sub CreateSoftIce()
        'Todo: Create Softice
    End Sub

    Private Function strToLower(ByVal str As String, ByVal intIndexOfCapital As Integer) As String
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
        msngPreis = sngNewSize * 10
        mblnRedrawChangeHappened = True
        AnimeOutputContainer(pnlOutputAll)
    End Sub


    Private Sub geldAusgabe(ByVal sngAmount As Single)
        Dim gr As Graphics = pnlGeldAusgabe.CreateGraphics
        gr.Clear(Color.WhiteSmoke)
        Dim intaMoneyBack() As Integer = splitmoney(msngBezahlt)
        For intCurrentCoin As Integer = 0 To intaMoneyBack.Length - 1
            Dim intCoinAmount As Integer = intaMoneyBack(intCurrentCoin)
            For intCoinCounter As Integer = 1 To intCoinAmount
                Dim sngMultiplier As Single = msngCoinSizes(intCurrentCoin)
                gr.DrawImage(mimgCoinImages(intCurrentCoin), New Rectangle( _
                             New Point(intCurrentCoin * 40 + intCoinCounter * 10, 95 - 95 * sngMultiplier), _
                             New Size(95 * sngMultiplier, 95 * sngMultiplier)))
            Next

        Next
        'lblSelection.Text = "Geld zurück: " + msngBezahlt.ToString + ": "
        'Dim intSum As Single = 0
        'For i = 0 To 5
        '    lblSelection.Text += ", " + intaMoneyBack(i).ToString + "*" + msngCoinValues(i).ToString
        '    intSum += intaMoneyBack(i) * msngCoinValues(i)
        'Next
        'lblSelection.Text += " = " + intSum.ToString
    End Sub


    Private Function splitmoney(ByVal sngMoney As Double) As Integer()
        'Returns an array containing an amount for the different coins which make up sngMoney. 
        If (sngMoney <= 0.05) Then
            Return {0, 0, 0, 0, 0, 0}
        End If

        For intIndex As Integer = 0 To 5
            If sngMoney >= msngCoinValues(intIndex) - 0.05 Then '-0.05 Because of Double precision problems :)
                Dim intMoneyBack As Integer()
                If intIndex = 0 Then
                    intMoneyBack = splitmoney(sngMoney Mod msngCoinValues(intIndex))
                    intMoneyBack(intIndex) += sngMoney \ msngCoinValues(intIndex)
                Else
                    intMoneyBack = splitmoney(sngMoney - msngCoinValues(intIndex))
                    intMoneyBack(intIndex) += 1
                End If
                Return intMoneyBack
            End If
        Next
        Return {0, 0, 0, 0, 0, 0}

    End Function


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
        mblnRedrawChangeHappened = True
        AnimeOutputContainer(pnlOutputAll)
    End Sub

    Private Sub rbtExtraGross_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtExtraGross.CheckedChanged
        If rbtExtraGross.Checked Then
            setButtonText(rbtExtraGross.Text, 1)
        End If

    End Sub

    Private Sub rbtGross_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtGross.CheckedChanged
        If rbtGross.Checked Then
            setButtonText(rbtGross.Text, 0.8)
        End If
    End Sub

    Private Sub rbtMittel_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtMittel.CheckedChanged
        If rbtMittel.Checked Then
            setButtonText(rbtMittel.Text, 0.6)
        End If
    End Sub

    Private Sub rbtKlein_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtKlein.CheckedChanged
        If rbtKlein.Checked Then
            setButtonText(rbtKlein.Text, 0.4)
        End If
    End Sub

    Private Sub rbtSehrKlein_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtSehrKlein.CheckedChanged
        If rbtSehrKlein.Checked Then
            setButtonText(rbtSehrKlein.Text, 0.3)
        End If
    End Sub


    Private Sub pic5Fr_Click(sender As Object, e As EventArgs) Handles pic5Fr.Click
        msngBezahlt += 5
        updatePreis()
    End Sub

    Private Sub pic2Fr_Click(sender As Object, e As EventArgs) Handles pic2Fr.Click
        msngBezahlt += 2
        updatePreis()
    End Sub

    Private Sub pi1Fr_Click(sender As Object, e As EventArgs) Handles pic1Fr.Click
        msngBezahlt += 1
        updatePreis()
    End Sub

    Private Sub pic50rp_Click(sender As Object, e As EventArgs) Handles pic50rp.Click
        msngBezahlt += 0.5
        updatePreis()
    End Sub

    Private Sub pic20rp_Click(sender As Object, e As EventArgs) Handles pic20rp.Click
        msngBezahlt += 0.2
        updatePreis()
    End Sub

    Private Sub pic10rp_Click(sender As Object, e As EventArgs) Handles pic10rp.Click
        msngBezahlt += 0.1
        updatePreis()
    End Sub


    Private Sub btnGeldZuerueck_Click(sender As Object, e As EventArgs) Handles btnGeldZuerueck.Click
        updatePreis()
        geldAusgabe(msngBezahlt)
        msngBezahlt = 0
        updatePreis()
    End Sub

    Private Sub btnBestaetigen_Click(sender As Object, e As EventArgs) Handles btnBestaetigen.Click
        updatePreis()
        If sngRealCost() > msngBezahlt Then
            lblError.Text = "Noch nicht genug Geld. Es fehlen: " + lblZuBezahlenFr.Text
        Else
            lblError.Text = ""
            geldAusgabe(sngRealCost() - msngBezahlt)
            msngBezahlt = 0
            CreateSoftIce()
        End If

    End Sub
End Class
