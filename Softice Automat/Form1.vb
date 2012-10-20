Public Class frmMain
    ' Global Settings
    Private mcolBackgroundColor As Color = Color.Silver

    ' Variables defining the output section
    Private mpntOutputTop As Point = New Point(20, 50)
    Private mpntOutputBottom As Point = New Point(300, 300)

    ' Variables for the Animation
    Private mblnRedrawChangeHappened = False
    Private msngContainerHeight As Single
    Private msngTimerConainerHeight As Single = 1
    Private msngAnimationSpeed = 5 '1.3

    ' Variables for the Cup
    Private mintCupHorizontalRadius As Integer = 65
    Private mintCupVerticalRadius As Integer = 18


    ' Variables for the Cornet
    Private mintCornetHorizontalRadius As Integer = 45
    Private mintCornetVerticalRadius As Integer = 17
    Private mintCornetHeight As Integer = 100


    ' Variables representing the selection
    Private mblnIsCupVisible As Boolean = False
    Private msngSizeSelection As Single = 1
    Private mblnCupSelected As Boolean = True
    Private mintIceHeight As Integer = 2


    ' Strings to represent the selection
    Private mstrGroesse As String = "Extra Gross"
    Private mstrType As String = "er Becher"
    Private mstrGeschmack As String = " mit Schokoladeneis"


    ' Variables to track how much it costs and how much ahs been paid
    Private msngPreis As Single
    Private msngBezahlt As Single = 0
    Private Const intMaximumPrice = 10

    ' Variables for the coin values, images and signs
    Private msngCoinValues() As Single = {5, 2, 1, 0.5, 0.2, 0.1}
    Private mimgCoinImages() As Image
    Private msngCoinSizes() As Single = {1, 0.8, 0.65, 0.45, 0.54, 0.43}

    ' Variables for the Animation of the ice itself
    Private mpntRealTopCenter As Point
    Private msngRealRadii As Integer()
    Private msngHeight As Single = 120
    Private mclrSchoko As Color = Color.FromArgb(255, 100, 39, 11)
    Private mclrVanille As Color = Color.FromArgb(255, 244, 245, 249)
    Private mclrErdbeere As Color = Color.FromArgb(255, 251, 221, 229)
    Private mpicChosenGeschmack As PictureBox
    Private mclrChosenColor As Color
    Private mblnFirst As Boolean = True


    Private Sub AnimateOutputContainer(ByRef pnl As Panel)
        ' Draw Output area and the cup or cornet animation

        updateText()
        If mblnRedrawChangeHappened Then
            msngTimerConainerHeight = mintIceHeight ' Start Animation anew
            'tmrContainerAnimation.Stop() ' Stop the Animation
            mblnRedrawChangeHappened = False ' Change is done
            tmrContainerAnimation.Start() ' Start the Animation
        End If

        DrawOutput(Color.Black, pnl) ' Draw Output first

    End Sub

    Private Sub DrawOutputContainer(ByVal clrFillColor As Color, Optional ByVal blnForceRedraw As Boolean = False)
        If mblnCupSelected Then
            mpntRealTopCenter = DrawCup(Color.Black, pnlContainer, blnForceRedraw Or mblnRedrawChangeHappened, clrFillColor, msngSizeSelection)
        Else
            mpntRealTopCenter = DrawCornet(Color.Black, pnlContainer, blnForceRedraw Or mblnRedrawChangeHappened, msngSizeSelection)
        End If
    End Sub

    Private Sub tmrContainerAnimation_Tick(sender As Object, e As EventArgs) Handles tmrContainerAnimation.Tick
        ' Slowly Move the Container upwards and make it get more visible with time
        pnlContainer.Height = msngTimerConainerHeight ' Height is timer variable
        ' The new Location is dependant on the size of the output panel as well as the Location and the sizeMultiplier
        Dim intOffset As Integer = If(mblnCupSelected, 80, 10)
        pnlContainer.Location = New Point(pnlOutputAll.Width / 2 - 50 * msngSizeSelection + pnlOutputAll.Location.X, _
                                          (pnlOutputAll.Height - 50 - intOffset * (1 - msngSizeSelection)) - msngTimerConainerHeight + pnlOutputAll.Location.Y)
        ' The next time the container height will bi by AnimationSpeed bigger
        msngTimerConainerHeight += msngAnimationSpeed
        DrawOutputContainer(Color.Black)

        ' If the Container is fully visible, stop the timer
        If msngTimerConainerHeight >= msngContainerHeight Then
            msngTimerConainerHeight = mintIceHeight
            tmrContainerAnimation.Stop()
        End If
        DrawOutput(Color.Black, pnlOutputAll)
    End Sub


    Private Sub pnlOutputAll_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles pnlOutputAll.Paint
        DrawOutput(Color.Black, pnlOutputAll) ' Draw Output Area when program starts
    End Sub

    ' Visual Functions (Drawing Stuff)

    Private Sub tmrSoftice_Tick(sender As Object, e As EventArgs) Handles tmrSoftice.Tick
        ' Slowly Move the Container upwards and make it get more visible with time

        If mblnFirst Then
            tmrSoftice.Stop()
            DrawOutputContainer(mclrChosenColor, True)
            mblnFirst = False
            tmrSoftice.Start()
        End If

        If mblnCupSelected Then
            pnlIceAnimation.BringToFront()
            mpicChosenGeschmack.Visible = True
            pnlIceAnimation.Height = (mpicChosenGeschmack.Location.Y - (mpntOutputTop.Y + pnlOutputAll.Location.Y + 2)) + msngTimerIceHeight ' Height is timer variable
            pnlIceAnimation.Width = mpicChosenGeschmack.Width
            pnlIceAnimation.Location = New Point(mpicChosenGeschmack.Location.X, _
                                              mpntOutputTop.Y + pnlOutputAll.Location.Y + 2) '(pnlOutputAll.Height - 350 - 30 * (1 - msngSizeSelection)) - msngTimerConainerHeight + pnlOutputAll.Location.Y)
            msngTimerIceHeight -= msngAnimationSpeed

        Else
            ' TODO Implement Cornet
        End If

        pnlIceAnimation.BringToFront()
        If pnlIceAnimation.Height <= 0 Then
            msngTimerIceHeight = 0
            tmrSoftice.Stop()
            mblnFirst = True
        End If

        DrawOutput(Color.Black, pnlOutputAll)

    End Sub



    Private Sub CreateSoftIce()
        ' Todo: Create Softice
        ' Select pic depending on Geschmack
        If lstGeschmack.SelectedIndex = 0 Then
            mpicChosenGeschmack = mpicSchoko
            mclrChosenColor = mclrSchoko
        ElseIf lstGeschmack.SelectedIndex = 1 Then
            mpicChosenGeschmack = picErdbeere
            mclrChosenColor = mclrErdbeere
        ElseIf lstGeschmack.SelectedIndex = 2 Then
            mpicChosenGeschmack = picVanile
            mclrChosenColor = mclrVanille
        End If

        'MessageBox.Show("Schoko Dims: " + mpicSchoko.Location.ToString + " and selection: " + mpicChosenGeschmack.Location.ToString)
        If mblnCupSelected Then
            mpicChosenGeschmack.Height = msngHeight * msngSizeSelection
            mpicChosenGeschmack.Width = pnlContainer.Width

            mpicChosenGeschmack.Location = New Point(pnlOutputAll.Location.X + pnlOutputAll.Width / 2 - pnlContainer.Width / 2 + 18 * msngSizeSelection, _
                                           pnlContainer.Location.Y + mpntRealTopCenter.Y - mpicChosenGeschmack.Height)
            DrawOutput(Color.Black, pnlOutputAll)
            msngTimerIceHeight = mpicChosenGeschmack.Height - msngRealRadii(1)

            pnlIceAnimation.Height = mpicChosenGeschmack.Height
            pnlIceAnimation.Width = mpicChosenGeschmack.Width
        End If

        mpicChosenGeschmack.BringToFront()
        'pnlIceAnimation.BringToFront()

        pnlOutputAll.Update()
        tmrSoftice.Start()
        mblnRedrawChangeHappened = True
        'picSchoko.Visible = True
    End Sub

    Private Sub DrawOutput(ByVal color As Color, ByRef pnl As Panel)
        ' Compute Size
        Dim intWidth As Integer = System.Math.Abs(mpntOutputBottom.X - mpntOutputTop.X)
        Dim intHeight As Integer = System.Math.Abs(mpntOutputBottom.X - mpntOutputTop.X)
        Dim pen As Pen = New Pen(color)
        Dim rect As Rectangle = New Rectangle(mpntOutputTop.X, mpntOutputTop.Y, intWidth, intHeight)
        Dim gr As Graphics = pnl.CreateGraphics
        gr.DrawRectangle(pen, rect) ' Draw Front Rectangle
        gr.DrawLine(pen, New Point(mpntOutputTop.X + 1 / 3 * intWidth, mpntOutputBottom.Y - 1 / 3 * intHeight), _
                   New Point(mpntOutputTop.X + 1 / 3 * intWidth, mpntOutputTop.Y)) ' Draw Vertical Line
        gr.DrawLine(pen, New Point(mpntOutputTop.X + 1 / 3 * intWidth, mpntOutputBottom.Y - 1 / 3 * intHeight), _
                    New Point(mpntOutputBottom.X, mpntOutputBottom.Y - 1 / 3 * intHeight)) ' Draw Horizontal line
    End Sub

    Private Function DrawCup(ByVal color As Color, ByRef pnlOutput As Panel, ByVal blnAnimate As Boolean, ByVal clrFill As Color, Optional ByVal sngSizeMultiplier As Single = 1)
        ' Draw the Cup
        Dim gr As Graphics = getClearedGraphics(pnlOutput)
        pnlOutput.BackColor = Drawing.Color.Transparent
        ' Multiply Radii with sizemultiplier
        Dim sngHorizontalRadius As Single = mintCupHorizontalRadius * sngSizeMultiplier
        Dim sngVerticalRaidus As Single = mintCupVerticalRadius * sngSizeMultiplier
        msngRealRadii = {sngHorizontalRadius, sngVerticalRaidus}
        Dim pntCenterTop As Point = New Point(sngHorizontalRadius, sngVerticalRaidus + mintIceHeight) ' Set top so that ellipse is completely visible
        ' Set Height to the sum of all elements
        msngContainerHeight = 2 * sngVerticalRaidus + (pntCenterTop.Y + 50 * sngSizeMultiplier) - (pntCenterTop.Y + 5 * sngSizeMultiplier) + 30 * sngSizeMultiplier * 0.3 + mintIceHeight
        pnlOutput.Width = 2 * sngHorizontalRadius + 2 ' Width is 2*Radius plus a bit
        pnlOutput.Update() ' Update (Size)

        DrawEllipseInPanel(pntCenterTop, New Tuple(Of Integer, Integer)(sngHorizontalRadius, sngVerticalRaidus), pnlOutput, clrFill, True) 'Draw Top Opening

        Dim rect As Rectangle = New Rectangle(pntCenterTop.X - 45 * sngSizeMultiplier, pntCenterTop.Y + 35 * sngSizeMultiplier, 90 * sngSizeMultiplier, 30 * sngSizeMultiplier)
        gr.DrawArc(New Pen(color), rect, 0, 179) ' Draw Bottom Arc
        gr.DrawLine(New Pen(color), New Point(pntCenterTop.X - 45 * sngSizeMultiplier, pntCenterTop.Y + 50 * sngSizeMultiplier), _
                    New Point(pntCenterTop.X - sngHorizontalRadius + 1, pntCenterTop.Y + 5 * sngSizeMultiplier)) ' Draw left Line
        gr.DrawLine(New Pen(color), New Point(pntCenterTop.X + 45 * sngSizeMultiplier, pntCenterTop.Y + 50 * sngSizeMultiplier), _
                    New Point(pntCenterTop.X + sngHorizontalRadius - 1, pntCenterTop.Y + 5 * sngSizeMultiplier)) ' Draw right Line
        Return pntCenterTop
    End Function

    Private Function getClearedGraphics(ByVal pnlPanel As Panel) As Graphics
        Dim gr As Graphics = pnlPanel.CreateGraphics
        gr.Clear(mcolBackgroundColor)
        Return gr
    End Function

    Private Function DrawCornet(ByVal color As Color, ByRef pnlOutput As Panel, ByVal blnAnimate As Boolean, Optional ByVal sngSizeMultiplier As Single = 1)
        ' Draw the Cornet
        Dim gr As Graphics = getClearedGraphics(pnlOutput)
        ' Radii get multiplied by the sizeMultiplier
        Dim sngHorizontalRadius As Single = mintCornetHorizontalRadius * sngSizeMultiplier
        Dim sngVerticalRaidus As Single = mintCornetVerticalRadius * sngSizeMultiplier
        If sngSizeMultiplier > 0.99 Then
            sngHorizontalRadius *= 0.95
            sngVerticalRaidus *= 0.9
        End If
        ' CenterTop point is at (X-Radius, Y-Radius) so that everything is visible
        Dim pntCenterTop As Point = New Point(sngHorizontalRadius, sngVerticalRaidus)
        msngRealRadii = {sngHorizontalRadius, sngVerticalRaidus}
        ' Set the container size
        msngContainerHeight = 2 * sngVerticalRaidus + Math.Abs(pntCenterTop.Y - (pntCenterTop.Y + mintCornetHeight * sngSizeMultiplier))
        pnlOutput.Width = 2 * sngHorizontalRadius + 8
        pnlOutput.Update() ' Update after changing the size to make everything appear correctly
        ' Draw the Top Ellipse
        DrawEllipseInPanel(pntCenterTop, New Tuple(Of Integer, Integer)(sngHorizontalRadius, sngVerticalRaidus), pnlOutput, color, True) 'Draw Top Opening
        ' Draw the 2 lines at the side
        gr.DrawLine(New Pen(color), New Point(pntCenterTop.X - sngHorizontalRadius, pntCenterTop.Y), _
                    New Point(pntCenterTop.X, pntCenterTop.Y + mintCornetHeight * sngSizeMultiplier))
        gr.DrawLine(New Pen(color), New Point(pntCenterTop.X + sngHorizontalRadius, pntCenterTop.Y), _
                    New Point(pntCenterTop.X, pntCenterTop.Y + mintCornetHeight * sngSizeMultiplier))
        Return pntCenterTop
    End Function

    Private Sub DrawEllipseInPanel(ByVal pntCenter As Point, ByVal tplRadii As Tuple(Of Integer, Integer), ByRef pnl As Panel, ByVal color As Color, ByVal blnFill As Boolean)
        ' Draw an ellipse with the radii tplRadii and the center pntCenter in the panel pnl and the color color.
        Dim gr As Graphics = pnl.CreateGraphics
        Dim rect As Rectangle = New Rectangle(pntCenter.X - tplRadii.Item1, pntCenter.Y - tplRadii.Item2, 2 * tplRadii.Item1, 2 * tplRadii.Item2)
        If blnFill Then
            gr.FillEllipse(New SolidBrush(color), rect)
        Else
            gr.DrawEllipse(New Pen(color), rect)
        End If
    End Sub

    ' Routines Concerning Selection

    'TODO: Rename Radiobuttons and Groupboxes!
    Private Sub frmMain_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        pnlSize.BorderStyle = BorderStyle.None
        cmbType.SelectedIndex = 0
        rbtExtraGross.Select() ' Set "Extra Gross" as default
        lstGeschmack.SelectedIndex = 0 ' Set Schokolade
        cmbType.SelectedIndex = 1 ' Set Becher as default 
        pnlContainer.BringToFront() ' Container is frontmost
        mimgCoinImages = {pic5Fr.Image, pic2Fr.Image, pic1Fr.Image, pic50rp.Image, pic20rp.Image, pic10rp.Image}
    End Sub

    Private Sub lstGeschmack_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstGeschmack.SelectedIndexChanged
        mstrGeschmack = " mit " + lstGeschmack.SelectedItem.ToString + "eis."
        If lstGeschmack.SelectedIndex = 2 Then
            mstrGeschmack = " mit " + lstGeschmack.SelectedItem.ToString + "is." 'Erdbeereis
        ElseIf lstGeschmack.SelectedIndex = 0 Then
            mstrGeschmack = " mit " + lstGeschmack.SelectedItem.ToString + "neis." 'Schokoladeneis
        End If
        AnimateOutputContainer(pnlOutputAll)
    End Sub

    Private Sub updateText()
        lblPreisFr.Text = "CHF " + sngRealCost(msngPreis).ToString("F")
        lblBezahltFr.Text = "CHF " + msngBezahlt.ToString("F")
        lblZuBezahlenFr.Text = "CHF " + (sngRealCost(msngPreis) - msngBezahlt).ToString("F")
        lblError.Text = ""
        lblSelection.Text = mstrGroesse + mstrType + mstrGeschmack
        geldAusgabe(0)
        If mpicChosenGeschmack IsNot Nothing Then
            mpicChosenGeschmack.Visible = False
        End If
        mblnFirst = True

        tmrSoftice.Stop()

    End Sub

    Private Sub cmbType_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbType.SelectedIndexChanged
        mblnCupSelected = CBool(cmbType.SelectedIndex)
        If mblnCupSelected Then
            mstrType = "er " + cmbType.SelectedItem.ToString  ' gross[er Becher]
        Else
            mstrType = "es " + cmbType.SelectedItem.ToString  ' gross[es Cornet]
        End If
        mblnRedrawChangeHappened = True ' Redraw Container (Type Changed)
        AnimateOutputContainer(pnlOutputAll)
    End Sub

    Private Sub optSizeSelection_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtExtraGross.CheckedChanged, rbtGross.CheckedChanged, rbtKlein.CheckedChanged, rbtMittel.CheckedChanged, rbtSehrKlein.CheckedChanged
        Dim rbtButton = CType(sender, RadioButton)
        If rbtButton.Checked Then
            msngSizeSelection = CSng(rbtButton.Tag)
            mstrGroesse = strToLowerWithUpperLetter(rbtButton.Text, 0)
            msngPreis = msngSizeSelection * intMaximumPrice
            mblnRedrawChangeHappened = True ' Redraw Container (Size Changed)
            AnimateOutputContainer(pnlOutputAll)
        End If
    End Sub




    ' Routines for Money and Rückgeld
    Private Sub geldAusgabe(ByVal sngAmount As Single)
        ' Computes a distribution of coin which make up sngAmount and puts the needed coins in the coinoutput area
        Dim gr As Graphics = getClearedGraphics(pnlGeldAusgabe)
        Dim intaMoneyBack() As Integer = splitmoney(sngAmount)
        For intCurrentCoin As Integer = 0 To intaMoneyBack.Length - 1
            Dim intCoinAmount As Integer = intaMoneyBack(intCurrentCoin)
            For intCoinCounter As Integer = 1 To intCoinAmount
                Dim sngMultiplier As Single = msngCoinSizes(intCurrentCoin)
                gr.DrawImage(mimgCoinImages(intCurrentCoin), New Rectangle( _
                             New Point(intCurrentCoin * 40 + intCoinCounter * 10, 95 - 95 * sngMultiplier), _
                             New Size(95 * sngMultiplier, 95 * sngMultiplier)))
            Next

        Next
    End Sub

    Private Sub picCoins_Click(sender As Object, e As EventArgs) Handles pic5Fr.Click, pic2Fr.Click, pic1Fr.Click, pic50rp.Click, pic20rp.Click, pic10rp.Click
        msngBezahlt += CSng(sender.Tag)
        updateText()
        AnimateOutputContainer(pnlOutputAll)
    End Sub

    Private Sub btnGeldZuerueck_Click(sender As Object, e As EventArgs) Handles btnGeldZuerueck.Click
        updateText()
        geldAusgabe(msngBezahlt)
        msngBezahlt = 0
        updateText()
    End Sub

    Private Sub btnBestaetigen_Click(sender As Object, e As EventArgs) Handles btnBestaetigen.Click
        updateText()
        If sngRealCost(msngPreis) > msngBezahlt Then
            lblError.Text = "Noch nicht genug Geld. Es fehlen: " + lblZuBezahlenFr.Text
        Else
            If tmrContainerAnimation.Enabled Then
                lblError.Text = "Bitte warten bis der Behälter ganz da ist"
            Else
                lblError.Text = ""
                geldAusgabe(Math.Abs(sngRealCost(msngPreis) - msngBezahlt))
                msngBezahlt = 0
                CreateSoftIce()
            End If

        End If

    End Sub

    ' Functions

    Private Function strToLowerWithUpperLetter(ByVal str As String, Optional ByVal intIndexOfCapital As Integer = 0) As String
        ' Transforms a string to lowercase with one optional letter as capital
        Dim chrarray = str.ToCharArray
        For Int As Integer = 0 To chrarray.Length - 1
            chrarray(Int) = Char.ToLower(chrarray(Int))
        Next
        If intIndexOfCapital >= 0 Then
            chrarray(intIndexOfCapital) = Char.ToUpper(chrarray(intIndexOfCapital))
        End If
        Return New String(chrarray)
    End Function

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

    Private Function sngRealCost(ByRef sngValue As Single) As Single
        Return sngValue * If(mblnCupSelected, 0.8, 1.0)
    End Function

    Private msngTimerIceHeight As Single = 1


    Private Sub mpicSchoko_Click(sender As Object, e As EventArgs) Handles mpicSchoko.Click

    End Sub
End Class
