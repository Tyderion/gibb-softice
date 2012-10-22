Public Class frmMain
    ' Global Settings
    Private ReadOnly mcolBackgroundColor As Color = Color.Silver
    Private ReadOnly clrDrawingColor As Color = Color.Black

    ' Variables defining the output section
    Private mpntOutputTop As Point = New Point(20, 50)
    Private mpntOutputBottom As Point = New Point(300, 300)

    ' Variables for the Animation
    Private mblnRedrawChangeHappened = False
    Private msngContainerHeight As Single
    Private msngTimerConainerHeight As Single = 1
    Private Const msngAnimationSpeed = 5

    ' Variables for the Cup
    Private Const mintCupHorizontalRadius As Integer = 65
    Private Const mintCupVerticalRadius As Integer = 18


    ' Variables for the Cornet
    Private Const mintCornetHorizontalRadius As Integer = 45
    Private Const mintCornetVerticalRadius As Integer = 17
    Private Const mintCornetHeight As Integer = 100


    ' Variables representing the selection
    Private msngSizeSelection As Single = 1
    Private mblnCupSelected As Boolean = True


    ' Strings to represent the selection
    Private mstrGroesse As String = "Extra Gross"
    Private mstrType As String = "er Becher"
    Private mstrGeschmack As String = " mit Schokoladeneis"


    ' Variables to track how much it costs and how much ahs been paid
    Private msngPreis As Single
    Private msngBezahlt As Single = 0
    Private Const mintMaximumPrice = 10

    ' Variables for the coin values, images and signs
    Private ReadOnly msngCoinValues() As Single = {5, 2, 1, 0.5, 0.2, 0.1}
    Private mimgCoinImages() As Image
    Private ReadOnly msngCoinSizes() As Single = {1, 0.8, 0.65, 0.45, 0.54, 0.43}

    ' Variables for the *Animation* of the ice itself
    Private mpntRealTopCenter As Point
    Private msngRealRadii As Integer()
    Private Const msngHeight As Single = 120
    Private ReadOnly mclrSchoko As Color = Color.FromArgb(255, 100, 39, 11)
    Private ReadOnly mclrVanille As Color = Color.FromArgb(255, 244, 245, 249)
    Private ReadOnly mclrErdbeere As Color = Color.FromArgb(255, 251, 221, 229)
    Private mpicChosenGeschmack As PictureBox
    Private mclrChosenColor As Color
    Private mblnFirst As Boolean = True
    Private msngTimerIceHeight As Single = 1


    ' Load Function
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        pnlSize.BorderStyle = BorderStyle.None
        cmbType.SelectedIndex = 0
        optExtraGross.Select()
        ' Set default selections
        lstGeschmack.SelectedIndex = 0
        cmbType.SelectedIndex = 1
        pnlContainer.BringToFront()
        ' Images for output
        mimgCoinImages = {pic5Fr.Image, pic2Fr.Image, pic1Fr.Image, pic50rp.Image, pic20rp.Image, pic10rp.Image}
    End Sub

    'Timers
    Private Sub tmrContainerAnimation_Tick(sender As Object, e As EventArgs) Handles tmrContainerAnimation.Tick
        ' Slowly Move the Container upwards and make it get more visible with time
        pnlContainer.Height = msngTimerConainerHeight
        ' Height is timer variable
        ' A smaller offset for the cornet because it is higher
        Dim intOffset As Integer = If(mblnCupSelected, 80, 60)
        pnlContainer.Location = New Point(pnlOutputAll.Width / 2 + pnlOutputAll.Location.X - 50 * msngSizeSelection,
                                          pnlOutputAll.Height + pnlOutputAll.Location.Y -
                                          50 - msngTimerConainerHeight - intOffset * (1 - msngSizeSelection))
        ' The next time the container height will one AnimationSpeed bigger
        msngTimerConainerHeight += msngAnimationSpeed
        DrawOutputContainer(clrDrawingColor)

        ' If the Container is fully visible, stop the timer
        If msngTimerConainerHeight >= msngContainerHeight Then
            msngTimerConainerHeight = 0
            tmrContainerAnimation.Stop()
        End If
        DrawOutput(clrDrawingColor, pnlOutputAll)
    End Sub


    Private Sub tmrSoftice_Tick(sender As Object, e As EventArgs) Handles tmrSoftice.Tick
        ' Slowly Move the Container upwards and make it get more visible with time

        If mblnFirst Then
            ' Make sure this only runs once by stopping the timer while changing the variable
            tmrSoftice.Stop()
            drawOutputContainer(mclrChosenColor, True)
            mblnFirst = False
            tmrSoftice.Start()
        End If
        pnlIceAnimation.Width = mpicChosenGeschmack.Width
        pnlIceAnimation.BringToFront()
        ' Make the ice visible just now, else it shows up earlier than the panel on top of it
        mpicChosenGeschmack.Visible = True
        pnlIceAnimation.Height = mpicChosenGeschmack.Location.Y - (mpntOutputTop.Y + pnlOutputAll.Location.Y + 2) + msngTimerIceHeight
        ' Height is timer variable
        pnlIceAnimation.Location = New Point(mpicChosenGeschmack.Location.X,
                                             mpntOutputTop.Y + pnlOutputAll.Location.Y + 2)
        ' Panel gets shorter
        msngTimerIceHeight -= msngAnimationSpeed
        pnlIceAnimation.BringToFront()
        If pnlIceAnimation.Height <= 0 Then
            msngTimerIceHeight = 0
            tmrSoftice.Stop()
            mblnFirst = True
        End If

        DrawOutput(clrDrawingColor, pnlOutputAll)
    End Sub
    ' Animation Functions (Drawing Stuff)
    Private Sub animateOutputContainer(ByRef pnl As Panel)
        ' Draw Output area and the cup or cornet animation
        updateText()
        If mblnRedrawChangeHappened Then
            ' Start Animation anew
            msngTimerConainerHeight = 0
            ' We reset the height so the redraw will happen
            mblnRedrawChangeHappened = False
            ' Start the Animation
            tmrContainerAnimation.Start()
        End If
        drawOutput(clrDrawingColor, pnl)
    End Sub

    ' Draw Functions
    Private Sub pnlOutputAll_Paint(sender As Object, e As PaintEventArgs) Handles pnlOutputAll.Paint
        ' Draw Output Area when program starts
        drawOutput(clrDrawingColor, pnlOutputAll)
    End Sub

    Private Sub createSoftIce()
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

        ' Adjust the height depending on the size
        mpicChosenGeschmack.Height = msngHeight*msngSizeSelection
        mpicChosenGeschmack.Width = 2*msngRealRadii(0)
        pnlIceAnimation.Height = mpicChosenGeschmack.Height
        pnlIceAnimation.Width = mpicChosenGeschmack.Width
        ' Set the location for a cornet
        mpicChosenGeschmack.Location = New Point(pnlOutputAll.Location.X + pnlOutputAll.Width / 2 - pnlContainer.Width / 2,
                                                 pnlContainer.Location.Y + mpntRealTopCenter.Y - mpicChosenGeschmack.Height)
        ' Adjust if it is a cup
        If mblnCupSelected Then
            mpicChosenGeschmack.Location = New Point(pnlOutputAll.Location.X + pnlOutputAll.Width / 2 - pnlContainer.Width / 2 + 18 * msngSizeSelection,
                                                     pnlContainer.Location.Y + mpntRealTopCenter.Y - mpicChosenGeschmack.Height)
        End If
        drawOutput(clrDrawingColor, pnlOutputAll)
        ' Set the Ice Height to the height of the pic minus the vertical radius
        msngTimerIceHeight = mpicChosenGeschmack.Height - msngRealRadii(1)
        mpicChosenGeschmack.BringToFront()

        'Start the timer
        tmrSoftice.Start()
        mblnRedrawChangeHappened = True
    End Sub

    Private Sub drawOutput(ByVal color As Color, ByRef pnl As Panel)
        ' Compute Size
        Dim intWidth As Integer = Math.Abs(mpntOutputBottom.X - mpntOutputTop.X)
        Dim intHeight As Integer = Math.Abs(mpntOutputBottom.X - mpntOutputTop.X)
        Dim pen As Pen = New Pen(color)
        Dim rect As Rectangle = New Rectangle(mpntOutputTop.X, mpntOutputTop.Y, intWidth, intHeight)
        Dim gr As Graphics = pnl.CreateGraphics
        gr.DrawRectangle(pen, rect)
        ' Draw Front Rectangle
        gr.DrawLine(pen, New Point(mpntOutputTop.X + 1/3*intWidth, mpntOutputBottom.Y - 1/3*intHeight),
                    New Point(mpntOutputTop.X + 1/3*intWidth, mpntOutputTop.Y))
        ' Draw Vertical Line
        gr.DrawLine(pen, New Point(mpntOutputTop.X + 1/3*intWidth, mpntOutputBottom.Y - 1/3*intHeight),
                    New Point(mpntOutputBottom.X, mpntOutputBottom.Y - 1/3*intHeight))
        ' Draw Horizontal line
    End Sub

    Private Sub drawOutputContainer(ByVal clrFillColor As Color, Optional ByVal blnForceRedraw As Boolean = False)
        ' Draw the Container and set the realTop variable to its center
        If mblnCupSelected Then
            mpntRealTopCenter = drawCup(clrDrawingColor, pnlContainer, blnForceRedraw Or mblnRedrawChangeHappened,
                                        clrFillColor, msngSizeSelection)
        Else
            mpntRealTopCenter = drawCornet(clrDrawingColor, pnlContainer, blnForceRedraw Or mblnRedrawChangeHappened,
                                           clrFillColor, msngSizeSelection)
        End If
    End Sub

    Private Function drawCup(ByVal color As Color, ByRef pnlOutput As Panel, ByVal blnAnimate As Boolean,
                             ByVal clrFill As Color, Optional ByVal sngSizeMultiplier As Single = 1)
        ' Draw the Cup
        Dim gr As Graphics = getClearedGraphics(pnlOutput)
        pnlOutput.BackColor = color.Transparent
        ' Multiply Radii with sizemultiplier
        Dim sngHorizontalRadius As Single = mintCupHorizontalRadius * sngSizeMultiplier
        Dim sngVerticalRaidus As Single = mintCupVerticalRadius * sngSizeMultiplier
        msngRealRadii = {sngHorizontalRadius, sngVerticalRaidus}
        Dim pntCenterTop As Point = New Point(sngHorizontalRadius, sngVerticalRaidus)
        ' Set top so that ellipse is completely visible
        ' Set Height to the sum of all elements
        msngContainerHeight = 2 * sngVerticalRaidus + (pntCenterTop.Y + 50 * sngSizeMultiplier) -
                              (pntCenterTop.Y + 5 * sngSizeMultiplier) + 30 * sngSizeMultiplier * 0.3
        pnlOutput.Width = 2 * sngHorizontalRadius + 2

        ' Update (Size)
        pnlOutput.Update()

        'Draw Top Opening
        drawEllipseInPanel(pntCenterTop, {sngHorizontalRadius, sngVerticalRaidus}, pnlOutput, clrFill, True)


        Dim rect As Rectangle = New Rectangle(pntCenterTop.X - 45 * sngSizeMultiplier,
                                              pntCenterTop.Y + 35 * sngSizeMultiplier,
                                              90 * sngSizeMultiplier,
                                              30 * sngSizeMultiplier)
        gr.DrawArc(New Pen(color), rect, 0, 179)
        ' Draw Bottom Arc
        gr.DrawLine(New Pen(color),
                    New Point(pntCenterTop.X - 45 * sngSizeMultiplier,
                              pntCenterTop.Y + 50 * sngSizeMultiplier),
                    New Point(pntCenterTop.X - sngHorizontalRadius + 1,
                              pntCenterTop.Y + 5 * sngSizeMultiplier))
        ' Draw left Line
        gr.DrawLine(New Pen(color),
                    New Point(pntCenterTop.X + 45 * sngSizeMultiplier,
                              pntCenterTop.Y + 50 * sngSizeMultiplier),
                    New Point(pntCenterTop.X + sngHorizontalRadius - 1,
                              pntCenterTop.Y + 5 * sngSizeMultiplier))
        ' Draw right Line
        Return pntCenterTop
    End Function



    Private Function drawCornet(ByVal clrMain As Color, ByRef pnlOutput As Panel, ByVal blnAnimate As Boolean,
                                ByVal clrFill As Color, Optional ByVal sngSizeMultiplier As Single = 1)
        Dim gr As Graphics = getClearedGraphics(pnlOutput)
        ' Radii get multiplied by the sizeMultiplier
        Dim sngHorizontalRadius As Single = mintCornetHorizontalRadius*sngSizeMultiplier
        Dim sngVerticalRaidus As Single = mintCornetVerticalRadius * sngSizeMultiplier
        'Biggest is a bit smaller than the cup
        If sngSizeMultiplier > 0.99 Then
            sngHorizontalRadius *= 0.95
            sngVerticalRaidus *= 0.9
        End If
        ' CenterTop point is at (X-Radius, Y-Radius) so that everything is visible
        Dim pntCenterTop As Point = New Point(sngHorizontalRadius, sngVerticalRaidus)
        msngRealRadii = {sngHorizontalRadius, sngVerticalRaidus}
        ' Set the container size
        msngContainerHeight = 2 * sngVerticalRaidus + mintCornetHeight * sngSizeMultiplier
        pnlOutput.Width = 2*sngHorizontalRadius + 8

        ' Update after changing the size to make everything appear correctly 
        pnlOutput.Update()
        ' Draw the Top Ellipse
        drawEllipseInPanel(pntCenterTop, {sngHorizontalRadius, sngVerticalRaidus}, pnlOutput, clrFill, True)
        'Draw Top Opening
        ' Draw the 2 lines at the side
        gr.DrawLine(New Pen(clrMain),
                    New Point(pntCenterTop.X - sngHorizontalRadius,
                              pntCenterTop.Y),
                    New Point(pntCenterTop.X,
                              pntCenterTop.Y + mintCornetHeight * sngSizeMultiplier))
        gr.DrawLine(New Pen(clrMain),
                    New Point(pntCenterTop.X + sngHorizontalRadius,
                              pntCenterTop.Y),
                    New Point(pntCenterTop.X,
                              pntCenterTop.Y + mintCornetHeight * sngSizeMultiplier))
        Return pntCenterTop
    End Function


    ' Graphical Helpers
    Private Shared Sub drawEllipseInPanel(ByVal pntCenter As Point, ByVal intRadii As Integer(),
                                          ByRef pnl As Panel, ByVal color As Color, ByVal blnFill As Boolean)
        ' Draw an ellipse with the radii tplRadii and the center pntCenter in the panel pnl and the color color.
        Dim gr As Graphics = pnl.CreateGraphics
        Dim rect As Rectangle = New Rectangle(pntCenter.X - intRadii(0), pntCenter.Y - intRadii(1),
                                              2 * intRadii(0), 2 * intRadii(1))
        If blnFill Then
            gr.FillEllipse(New SolidBrush(color), rect)
        Else
            gr.DrawEllipse(New Pen(color), rect)
        End If
    End Sub

    Private Function getClearedGraphics(ByVal pnlPanel As Panel) As Graphics
        Dim gr As Graphics = pnlPanel.CreateGraphics
        gr.Clear(mcolBackgroundColor)
        Return gr
    End Function

    ' Routines Concerning Selection
    Private Sub updateText()
        lblPreisFr.Text = "CHF " + sngRealCost().ToString("F")
        lblBezahltFr.Text = "CHF " + msngBezahlt.ToString("F")
        lblZuBezahlenFr.Text = "CHF " + (sngRealCost() - msngBezahlt).ToString("F")
        lblError.Text = ""
        lblSelection.Text = mstrGroesse + mstrType + mstrGeschmack
        If mblnCupSelected Then
            ' "[er] Becher"
            mstrType = "er " + cmbType.SelectedItem.ToString
        Else
            ' "[es] Cornet"
            mstrType = "es " + cmbType.SelectedItem.ToString
        End If
        ' Clear the Money Output
        geldAusgabe(0)
        ' Avoiding NullPointerExeption
        If mpicChosenGeschmack IsNot Nothing Then
            mpicChosenGeschmack.Visible = False
        End If
        ' This is the first run of the ice timer for this ice
        mblnFirst = True
        tmrSoftice.Stop()
    End Sub

    Private Sub lstGeschmack_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles lstGeschmack.SelectedIndexChanged
        mstrGeschmack = " mit " + lstGeschmack.SelectedItem.ToString + "eis."
        If lstGeschmack.SelectedIndex = 2 Then
            mstrGeschmack = " mit " + lstGeschmack.SelectedItem.ToString + "is."
            'Erdbeereis
        ElseIf lstGeschmack.SelectedIndex = 0 Then
            mstrGeschmack = " mit " + lstGeschmack.SelectedItem.ToString + "neis."
            'Schokoladeneis
        End If
        animateOutputContainer(pnlOutputAll)
    End Sub

    ' Selection of the type of container (cornet or becher)
    Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged
        mblnCupSelected = CBool(cmbType.SelectedIndex)

        ' Redraw Container (Type Changed)
        mblnRedrawChangeHappened = True
        animateOutputContainer(pnlOutputAll)
    End Sub

    Private Sub optSizeSelection_CheckedChanged(sender As Object, e As EventArgs) _
        Handles optExtraGross.CheckedChanged, optGross.CheckedChanged, optKlein.CheckedChanged, optMittel.CheckedChanged,
                optSehrKlein.CheckedChanged
        Dim rbtButton = CType(sender, RadioButton)
        If rbtButton.Checked Then
            msngSizeSelection = CSng(rbtButton.Tag)
            mstrGroesse = strToLowerWithUpperLetter(rbtButton.Text, 0)
            msngPreis = msngSizeSelection*mintMaximumPrice
            ' Redraw Container (Size Changed)
            mblnRedrawChangeHappened = True
            AnimateOutputContainer(pnlOutputAll)
        End If
    End Sub

    Private Shared Function strToLowerWithUpperLetter(ByVal str As String,
                                                  Optional ByVal intIndexOfCapital As Integer = 0) As String
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


    ' Routines for Money and Rückgeld
    Private Sub geldAusgabe(ByVal sngAmount As Single)
        ' Computes a distribution of coin which make up sngAmount and puts the needed coins in the coinoutput area
        Dim gr As Graphics = GetClearedGraphics(pnlGeldAusgabe)
        Dim intaMoneyBack() As Integer = splitmoney(sngAmount)
        For intCurrentCoin As Integer = 0 To intaMoneyBack.Length - 1
            Dim intCoinAmount As Integer = intaMoneyBack(intCurrentCoin)
            For intCoinCounter As Integer = 1 To intCoinAmount
                Dim sngMultiplier As Single = msngCoinSizes(intCurrentCoin)
                ' Draw coins, each horizontally a bit displaced, works only up to so-many coins
                gr.DrawImage(mimgCoinImages(intCurrentCoin), New Rectangle(
                    New Point(intCurrentCoin*40 + intCoinCounter*10, 95 - 95*sngMultiplier),
                    New Size(95*sngMultiplier, 95*sngMultiplier)))
            Next

        Next
    End Sub

    Private Function splitmoney(ByVal sngMoney As Double) As Integer()
        'Returns an array containing an amount for the different coins which make up sngMoney. 
        ' Could also be done with a for loop over the array instead of a "recursive" version
        If (sngMoney <= 0.05) Then
            Return {0, 0, 0, 0, 0, 0}
        End If

        For intIndex As Integer = 0 To 5
            If sngMoney >= msngCoinValues(intIndex) - 0.05 Then '-0.05 Because of Double precision problems :)
                Dim intMoneyBack As Integer()
                If intIndex = 0 Then
                    ' Use the biggest coins for most of the amount. This makes stack-overflows impossible
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

    Private Function sngRealCost() As Single
        Return msngPreis * If(mblnCupSelected, 0.8, 1.0)
    End Function

    ' Handlers for coins and buy/cancel buttons

    Private Sub picCoins_Click(sender As Object, e As EventArgs) _
        Handles pic5Fr.Click, pic2Fr.Click, pic1Fr.Click, pic50rp.Click, pic20rp.Click, pic10rp.Click
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
        If sngRealCost() > msngBezahlt Then
            lblError.Text = "Noch nicht genug Geld. Es fehlen: " + lblZuBezahlenFr.Text
        Else
            If tmrContainerAnimation.Enabled Then
                lblError.Text = "Bitte warten bis der Behälter ganz da ist"
            Else
                lblError.Text = ""
                geldAusgabe(Math.Abs(sngRealCost() - msngBezahlt))
                msngBezahlt = 0
                createSoftIce()
            End If

        End If
    End Sub

End Class
