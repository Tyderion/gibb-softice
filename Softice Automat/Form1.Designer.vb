<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.grpGeschmack = New System.Windows.Forms.GroupBox()
        Me.lstGeschmack = New System.Windows.Forms.ListBox()
        Me.optSehrKlein = New System.Windows.Forms.RadioButton()
        Me.optKlein = New System.Windows.Forms.RadioButton()
        Me.optMittel = New System.Windows.Forms.RadioButton()
        Me.optGross = New System.Windows.Forms.RadioButton()
        Me.optExtraGross = New System.Windows.Forms.RadioButton()
        Me.grpTypGroesse = New System.Windows.Forms.GroupBox()
        Me.pnlSize = New System.Windows.Forms.Panel()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.lblPreis = New System.Windows.Forms.Label()
        Me.lblPreisFr = New System.Windows.Forms.Label()
        Me.lblBezahltFr = New System.Windows.Forms.Label()
        Me.lblZuBezahlenFr = New System.Windows.Forms.Label()
        Me.lblBezahlt = New System.Windows.Forms.Label()
        Me.lblZuBezahlen = New System.Windows.Forms.Label()
        Me.btnBestaetigen = New System.Windows.Forms.Button()
        Me.pnlPreis = New System.Windows.Forms.Panel()
        Me.lblSelection = New System.Windows.Forms.Label()
        Me.lblGeldschlitz = New System.Windows.Forms.Label()
        Me.pnlOutputAll = New System.Windows.Forms.Panel()
        Me.pnlGeldschlitz = New System.Windows.Forms.Panel()
        Me.pnlGeld = New System.Windows.Forms.Panel()
        Me.pic10rp = New System.Windows.Forms.PictureBox()
        Me.pic5Fr = New System.Windows.Forms.PictureBox()
        Me.pic2Fr = New System.Windows.Forms.PictureBox()
        Me.pic50rp = New System.Windows.Forms.PictureBox()
        Me.pic1Fr = New System.Windows.Forms.PictureBox()
        Me.pic20rp = New System.Windows.Forms.PictureBox()
        Me.pnlContainer = New System.Windows.Forms.Panel()
        Me.tmrContainerAnimation = New System.Windows.Forms.Timer(Me.components)
        Me.btnGeldZuerueck = New System.Windows.Forms.Button()
        Me.pnlGeldAusgabe = New System.Windows.Forms.Panel()
        Me.lblError = New System.Windows.Forms.Label()
        Me.tmrSoftice = New System.Windows.Forms.Timer(Me.components)
        Me.pnlIceAnimation = New System.Windows.Forms.Panel()
        Me.picVanile = New System.Windows.Forms.PictureBox()
        Me.mpicSchoko = New System.Windows.Forms.PictureBox()
        Me.picErdbeere = New System.Windows.Forms.PictureBox()
        Me.grpGeschmack.SuspendLayout()
        Me.grpTypGroesse.SuspendLayout()
        Me.pnlSize.SuspendLayout()
        Me.pnlPreis.SuspendLayout()
        Me.pnlGeldschlitz.SuspendLayout()
        Me.pnlGeld.SuspendLayout()
        CType(Me.pic10rp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic5Fr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2Fr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic50rp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic1Fr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic20rp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVanile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mpicSchoko, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picErdbeere, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpGeschmack
        '
        Me.grpGeschmack.Controls.Add(Me.lstGeschmack)
        Me.grpGeschmack.Location = New System.Drawing.Point(27, 79)
        Me.grpGeschmack.Name = "grpGeschmack"
        Me.grpGeschmack.Size = New System.Drawing.Size(132, 191)
        Me.grpGeschmack.TabIndex = 0
        Me.grpGeschmack.TabStop = False
        Me.grpGeschmack.Text = "Geschmack"
        '
        'lstGeschmack
        '
        Me.lstGeschmack.BackColor = System.Drawing.Color.Silver
        Me.lstGeschmack.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstGeschmack.FormattingEnabled = True
        Me.lstGeschmack.Items.AddRange(New Object() {"Schokolade", "Erdbeere", "Vanille"})
        Me.lstGeschmack.Location = New System.Drawing.Point(6, 19)
        Me.lstGeschmack.Name = "lstGeschmack"
        Me.lstGeschmack.Size = New System.Drawing.Size(120, 143)
        Me.lstGeschmack.TabIndex = 0
        '
        'optSehrKlein
        '
        Me.optSehrKlein.AutoSize = True
        Me.optSehrKlein.Location = New System.Drawing.Point(3, 95)
        Me.optSehrKlein.Name = "optSehrKlein"
        Me.optSehrKlein.Size = New System.Drawing.Size(73, 17)
        Me.optSehrKlein.TabIndex = 4
        Me.optSehrKlein.TabStop = True
        Me.optSehrKlein.Tag = ".3"
        Me.optSehrKlein.Text = "Sehr Klein"
        Me.optSehrKlein.UseVisualStyleBackColor = True
        '
        'optKlein
        '
        Me.optKlein.AutoSize = True
        Me.optKlein.Location = New System.Drawing.Point(3, 72)
        Me.optKlein.Name = "optKlein"
        Me.optKlein.Size = New System.Drawing.Size(48, 17)
        Me.optKlein.TabIndex = 3
        Me.optKlein.TabStop = True
        Me.optKlein.Tag = ".4"
        Me.optKlein.Text = "Klein"
        Me.optKlein.UseVisualStyleBackColor = True
        '
        'optMittel
        '
        Me.optMittel.AutoSize = True
        Me.optMittel.Location = New System.Drawing.Point(3, 49)
        Me.optMittel.Name = "optMittel"
        Me.optMittel.Size = New System.Drawing.Size(80, 17)
        Me.optMittel.TabIndex = 2
        Me.optMittel.TabStop = True
        Me.optMittel.Tag = ".6"
        Me.optMittel.Text = "Mittel Gross"
        Me.optMittel.UseVisualStyleBackColor = True
        '
        'optGross
        '
        Me.optGross.AutoSize = True
        Me.optGross.Location = New System.Drawing.Point(3, 26)
        Me.optGross.Name = "optGross"
        Me.optGross.Size = New System.Drawing.Size(52, 17)
        Me.optGross.TabIndex = 1
        Me.optGross.TabStop = True
        Me.optGross.Tag = ".8"
        Me.optGross.Text = "Gross"
        Me.optGross.UseVisualStyleBackColor = True
        '
        'optExtraGross
        '
        Me.optExtraGross.AutoSize = True
        Me.optExtraGross.Location = New System.Drawing.Point(3, 3)
        Me.optExtraGross.Name = "optExtraGross"
        Me.optExtraGross.Size = New System.Drawing.Size(79, 17)
        Me.optExtraGross.TabIndex = 0
        Me.optExtraGross.TabStop = True
        Me.optExtraGross.Tag = "1"
        Me.optExtraGross.Text = "Extra Gross"
        Me.optExtraGross.UseVisualStyleBackColor = True
        '
        'grpTypGroesse
        '
        Me.grpTypGroesse.Controls.Add(Me.pnlSize)
        Me.grpTypGroesse.Controls.Add(Me.cmbType)
        Me.grpTypGroesse.Location = New System.Drawing.Point(178, 79)
        Me.grpTypGroesse.Name = "grpTypGroesse"
        Me.grpTypGroesse.Size = New System.Drawing.Size(132, 191)
        Me.grpTypGroesse.TabIndex = 1
        Me.grpTypGroesse.TabStop = False
        Me.grpTypGroesse.Text = "Typ && Grösse"
        '
        'pnlSize
        '
        Me.pnlSize.Controls.Add(Me.optSehrKlein)
        Me.pnlSize.Controls.Add(Me.optExtraGross)
        Me.pnlSize.Controls.Add(Me.optKlein)
        Me.pnlSize.Controls.Add(Me.optGross)
        Me.pnlSize.Controls.Add(Me.optMittel)
        Me.pnlSize.Location = New System.Drawing.Point(7, 46)
        Me.pnlSize.Name = "pnlSize"
        Me.pnlSize.Size = New System.Drawing.Size(109, 131)
        Me.pnlSize.TabIndex = 1
        '
        'cmbType
        '
        Me.cmbType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"Cornet", "Becher"})
        Me.cmbType.Location = New System.Drawing.Point(7, 19)
        Me.cmbType.MaxDropDownItems = 2
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(121, 21)
        Me.cmbType.TabIndex = 0
        '
        'lblPreis
        '
        Me.lblPreis.AutoSize = True
        Me.lblPreis.Location = New System.Drawing.Point(8, 8)
        Me.lblPreis.Name = "lblPreis"
        Me.lblPreis.Size = New System.Drawing.Size(36, 13)
        Me.lblPreis.TabIndex = 7
        Me.lblPreis.Text = "Preis: "
        '
        'lblPreisFr
        '
        Me.lblPreisFr.AutoSize = True
        Me.lblPreisFr.Location = New System.Drawing.Point(81, 8)
        Me.lblPreisFr.Name = "lblPreisFr"
        Me.lblPreisFr.Size = New System.Drawing.Size(28, 13)
        Me.lblPreisFr.TabIndex = 8
        Me.lblPreisFr.Text = "2.00"
        '
        'lblBezahltFr
        '
        Me.lblBezahltFr.AutoSize = True
        Me.lblBezahltFr.Location = New System.Drawing.Point(81, 21)
        Me.lblBezahltFr.Name = "lblBezahltFr"
        Me.lblBezahltFr.Size = New System.Drawing.Size(28, 13)
        Me.lblBezahltFr.TabIndex = 16
        Me.lblBezahltFr.Text = "0.00"
        '
        'lblZuBezahlenFr
        '
        Me.lblZuBezahlenFr.AutoSize = True
        Me.lblZuBezahlenFr.Location = New System.Drawing.Point(81, 34)
        Me.lblZuBezahlenFr.Name = "lblZuBezahlenFr"
        Me.lblZuBezahlenFr.Size = New System.Drawing.Size(28, 13)
        Me.lblZuBezahlenFr.TabIndex = 17
        Me.lblZuBezahlenFr.Text = "2.00"
        '
        'lblBezahlt
        '
        Me.lblBezahlt.AutoSize = True
        Me.lblBezahlt.Location = New System.Drawing.Point(8, 21)
        Me.lblBezahlt.Name = "lblBezahlt"
        Me.lblBezahlt.Size = New System.Drawing.Size(44, 13)
        Me.lblBezahlt.TabIndex = 18
        Me.lblBezahlt.Text = "bezahlt:"
        '
        'lblZuBezahlen
        '
        Me.lblZuBezahlen.AutoSize = True
        Me.lblZuBezahlen.Location = New System.Drawing.Point(8, 34)
        Me.lblZuBezahlen.Name = "lblZuBezahlen"
        Me.lblZuBezahlen.Size = New System.Drawing.Size(67, 13)
        Me.lblZuBezahlen.TabIndex = 19
        Me.lblZuBezahlen.Text = "zu bezahlen:"
        '
        'btnBestaetigen
        '
        Me.btnBestaetigen.Location = New System.Drawing.Point(316, 220)
        Me.btnBestaetigen.Name = "btnBestaetigen"
        Me.btnBestaetigen.Size = New System.Drawing.Size(100, 49)
        Me.btnBestaetigen.TabIndex = 20
        Me.btnBestaetigen.Text = "Wahl bestätigen"
        Me.btnBestaetigen.UseVisualStyleBackColor = True
        '
        'pnlPreis
        '
        Me.pnlPreis.Controls.Add(Me.lblZuBezahlen)
        Me.pnlPreis.Controls.Add(Me.lblPreis)
        Me.pnlPreis.Controls.Add(Me.lblPreisFr)
        Me.pnlPreis.Controls.Add(Me.lblBezahltFr)
        Me.pnlPreis.Controls.Add(Me.lblBezahlt)
        Me.pnlPreis.Controls.Add(Me.lblZuBezahlenFr)
        Me.pnlPreis.Location = New System.Drawing.Point(322, 19)
        Me.pnlPreis.Name = "pnlPreis"
        Me.pnlPreis.Size = New System.Drawing.Size(169, 54)
        Me.pnlPreis.TabIndex = 22
        '
        'lblSelection
        '
        Me.lblSelection.AutoSize = True
        Me.lblSelection.Location = New System.Drawing.Point(30, 19)
        Me.lblSelection.Name = "lblSelection"
        Me.lblSelection.Size = New System.Drawing.Size(200, 13)
        Me.lblSelection.TabIndex = 23
        Me.lblSelection.Text = "Extra grosser Becher mit Schokoladeneis"
        '
        'lblGeldschlitz
        '
        Me.lblGeldschlitz.AutoSize = True
        Me.lblGeldschlitz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGeldschlitz.Location = New System.Drawing.Point(22, 13)
        Me.lblGeldschlitz.Name = "lblGeldschlitz"
        Me.lblGeldschlitz.Size = New System.Drawing.Size(117, 15)
        Me.lblGeldschlitz.TabIndex = 24
        Me.lblGeldschlitz.Text = "                                    "
        '
        'pnlOutputAll
        '
        Me.pnlOutputAll.Location = New System.Drawing.Point(214, 276)
        Me.pnlOutputAll.Name = "pnlOutputAll"
        Me.pnlOutputAll.Size = New System.Drawing.Size(354, 336)
        Me.pnlOutputAll.TabIndex = 29
        '
        'pnlGeldschlitz
        '
        Me.pnlGeldschlitz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlGeldschlitz.Controls.Add(Me.lblGeldschlitz)
        Me.pnlGeldschlitz.Location = New System.Drawing.Point(523, 20)
        Me.pnlGeldschlitz.Name = "pnlGeldschlitz"
        Me.pnlGeldschlitz.Size = New System.Drawing.Size(160, 46)
        Me.pnlGeldschlitz.TabIndex = 30
        '
        'pnlGeld
        '
        Me.pnlGeld.Controls.Add(Me.pic10rp)
        Me.pnlGeld.Controls.Add(Me.pic5Fr)
        Me.pnlGeld.Controls.Add(Me.pic2Fr)
        Me.pnlGeld.Controls.Add(Me.pic50rp)
        Me.pnlGeld.Controls.Add(Me.pic1Fr)
        Me.pnlGeld.Controls.Add(Me.pic20rp)
        Me.pnlGeld.Location = New System.Drawing.Point(506, 100)
        Me.pnlGeld.Name = "pnlGeld"
        Me.pnlGeld.Size = New System.Drawing.Size(230, 170)
        Me.pnlGeld.TabIndex = 31
        '
        'pic10rp
        '
        Me.pic10rp.Image = Global.Softice_Automat.My.Resources.Resources._10Rp_front
        Me.pic10rp.Location = New System.Drawing.Point(147, 92)
        Me.pic10rp.Name = "pic10rp"
        Me.pic10rp.Size = New System.Drawing.Size(68, 63)
        Me.pic10rp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic10rp.TabIndex = 14
        Me.pic10rp.TabStop = False
        Me.pic10rp.Tag = ".1"
        '
        'pic5Fr
        '
        Me.pic5Fr.Image = Global.Softice_Automat.My.Resources.Resources._5Fr_front
        Me.pic5Fr.Location = New System.Drawing.Point(12, 13)
        Me.pic5Fr.Name = "pic5Fr"
        Me.pic5Fr.Size = New System.Drawing.Size(65, 73)
        Me.pic5Fr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic5Fr.TabIndex = 9
        Me.pic5Fr.TabStop = False
        Me.pic5Fr.Tag = "5"
        '
        'pic2Fr
        '
        Me.pic2Fr.Image = Global.Softice_Automat.My.Resources.Resources._2Fr_front
        Me.pic2Fr.Location = New System.Drawing.Point(83, 13)
        Me.pic2Fr.Name = "pic2Fr"
        Me.pic2Fr.Size = New System.Drawing.Size(58, 73)
        Me.pic2Fr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic2Fr.TabIndex = 10
        Me.pic2Fr.TabStop = False
        Me.pic2Fr.Tag = "2"
        '
        'pic50rp
        '
        Me.pic50rp.Image = Global.Softice_Automat.My.Resources.Resources._50Rp_front
        Me.pic50rp.Location = New System.Drawing.Point(12, 92)
        Me.pic50rp.Name = "pic50rp"
        Me.pic50rp.Size = New System.Drawing.Size(65, 63)
        Me.pic50rp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic50rp.TabIndex = 11
        Me.pic50rp.TabStop = False
        Me.pic50rp.Tag = ".5"
        '
        'pic1Fr
        '
        Me.pic1Fr.Image = Global.Softice_Automat.My.Resources.Resources._1Fr_front
        Me.pic1Fr.Location = New System.Drawing.Point(147, 13)
        Me.pic1Fr.Name = "pic1Fr"
        Me.pic1Fr.Size = New System.Drawing.Size(68, 72)
        Me.pic1Fr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic1Fr.TabIndex = 12
        Me.pic1Fr.TabStop = False
        Me.pic1Fr.Tag = "1"
        '
        'pic20rp
        '
        Me.pic20rp.Image = Global.Softice_Automat.My.Resources.Resources._20Rp_front
        Me.pic20rp.Location = New System.Drawing.Point(83, 92)
        Me.pic20rp.Name = "pic20rp"
        Me.pic20rp.Size = New System.Drawing.Size(58, 63)
        Me.pic20rp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic20rp.TabIndex = 13
        Me.pic20rp.TabStop = False
        Me.pic20rp.Tag = ".2"
        '
        'pnlContainer
        '
        Me.pnlContainer.BackColor = System.Drawing.Color.Transparent
        Me.pnlContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlContainer.ForeColor = System.Drawing.Color.Transparent
        Me.pnlContainer.Location = New System.Drawing.Point(12, 382)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Size = New System.Drawing.Size(196, 174)
        Me.pnlContainer.TabIndex = 0
        '
        'tmrContainerAnimation
        '
        Me.tmrContainerAnimation.Interval = 50
        '
        'btnGeldZuerueck
        '
        Me.btnGeldZuerueck.Location = New System.Drawing.Point(422, 220)
        Me.btnGeldZuerueck.Name = "btnGeldZuerueck"
        Me.btnGeldZuerueck.Size = New System.Drawing.Size(75, 49)
        Me.btnGeldZuerueck.TabIndex = 32
        Me.btnGeldZuerueck.Text = "Geld Zurück"
        Me.btnGeldZuerueck.UseVisualStyleBackColor = True
        '
        'pnlGeldAusgabe
        '
        Me.pnlGeldAusgabe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlGeldAusgabe.Location = New System.Drawing.Point(234, 618)
        Me.pnlGeldAusgabe.Name = "pnlGeldAusgabe"
        Me.pnlGeldAusgabe.Size = New System.Drawing.Size(280, 95)
        Me.pnlGeldAusgabe.TabIndex = 33
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(330, 79)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 13)
        Me.lblError.TabIndex = 34
        '
        'tmrSoftice
        '
        '
        'pnlIceAnimation
        '
        Me.pnlIceAnimation.ForeColor = System.Drawing.Color.Silver
        Me.pnlIceAnimation.Location = New System.Drawing.Point(27, 287)
        Me.pnlIceAnimation.Name = "pnlIceAnimation"
        Me.pnlIceAnimation.Size = New System.Drawing.Size(200, 100)
        Me.pnlIceAnimation.TabIndex = 38
        '
        'picVanile
        '
        Me.picVanile.BackColor = System.Drawing.Color.Transparent
        Me.picVanile.Image = CType(resources.GetObject("picVanile.Image"), System.Drawing.Image)
        Me.picVanile.Location = New System.Drawing.Point(621, 443)
        Me.picVanile.Name = "picVanile"
        Me.picVanile.Size = New System.Drawing.Size(100, 50)
        Me.picVanile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picVanile.TabIndex = 37
        Me.picVanile.TabStop = False
        Me.picVanile.Visible = False
        '
        'mpicSchoko
        '
        Me.mpicSchoko.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.mpicSchoko.BackColor = System.Drawing.Color.Transparent
        Me.mpicSchoko.Image = Global.Softice_Automat.My.Resources.Resources.schoko
        Me.mpicSchoko.Location = New System.Drawing.Point(611, 298)
        Me.mpicSchoko.Name = "mpicSchoko"
        Me.mpicSchoko.Size = New System.Drawing.Size(100, 50)
        Me.mpicSchoko.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mpicSchoko.TabIndex = 35
        Me.mpicSchoko.TabStop = False
        Me.mpicSchoko.Visible = False
        '
        'picErdbeere
        '
        Me.picErdbeere.Image = Global.Softice_Automat.My.Resources.Resources.erdbeere
        Me.picErdbeere.Location = New System.Drawing.Point(621, 365)
        Me.picErdbeere.Name = "picErdbeere"
        Me.picErdbeere.Size = New System.Drawing.Size(100, 50)
        Me.picErdbeere.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picErdbeere.TabIndex = 36
        Me.picErdbeere.TabStop = False
        Me.picErdbeere.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(771, 719)
        Me.Controls.Add(Me.pnlIceAnimation)
        Me.Controls.Add(Me.picVanile)
        Me.Controls.Add(Me.mpicSchoko)
        Me.Controls.Add(Me.picErdbeere)
        Me.Controls.Add(Me.pnlContainer)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.pnlGeldAusgabe)
        Me.Controls.Add(Me.btnGeldZuerueck)
        Me.Controls.Add(Me.pnlGeld)
        Me.Controls.Add(Me.pnlGeldschlitz)
        Me.Controls.Add(Me.pnlOutputAll)
        Me.Controls.Add(Me.lblSelection)
        Me.Controls.Add(Me.pnlPreis)
        Me.Controls.Add(Me.btnBestaetigen)
        Me.Controls.Add(Me.grpTypGroesse)
        Me.Controls.Add(Me.grpGeschmack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMain"
        Me.Text = "Ice-O-Matic"
        Me.grpGeschmack.ResumeLayout(False)
        Me.grpTypGroesse.ResumeLayout(False)
        Me.pnlSize.ResumeLayout(False)
        Me.pnlSize.PerformLayout()
        Me.pnlPreis.ResumeLayout(False)
        Me.pnlPreis.PerformLayout()
        Me.pnlGeldschlitz.ResumeLayout(False)
        Me.pnlGeldschlitz.PerformLayout()
        Me.pnlGeld.ResumeLayout(False)
        CType(Me.pic10rp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic5Fr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic2Fr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic50rp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic1Fr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic20rp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVanile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mpicSchoko, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picErdbeere, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpGeschmack As System.Windows.Forms.GroupBox
    Friend WithEvents lstGeschmack As System.Windows.Forms.ListBox
    Friend WithEvents optSehrKlein As System.Windows.Forms.RadioButton
    Friend WithEvents optKlein As System.Windows.Forms.RadioButton
    Friend WithEvents optMittel As System.Windows.Forms.RadioButton
    Friend WithEvents optGross As System.Windows.Forms.RadioButton
    Friend WithEvents optExtraGross As System.Windows.Forms.RadioButton
    Friend WithEvents grpTypGroesse As System.Windows.Forms.GroupBox
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents pnlSize As System.Windows.Forms.Panel
    Friend WithEvents lblPreis As System.Windows.Forms.Label
    Friend WithEvents lblPreisFr As System.Windows.Forms.Label
    Friend WithEvents pic5Fr As System.Windows.Forms.PictureBox
    Friend WithEvents pic2Fr As System.Windows.Forms.PictureBox
    Friend WithEvents pic50rp As System.Windows.Forms.PictureBox
    Friend WithEvents pic1Fr As System.Windows.Forms.PictureBox
    Friend WithEvents pic20rp As System.Windows.Forms.PictureBox
    Friend WithEvents pic10rp As System.Windows.Forms.PictureBox
    Friend WithEvents lblBezahltFr As System.Windows.Forms.Label
    Friend WithEvents lblZuBezahlenFr As System.Windows.Forms.Label
    Friend WithEvents lblBezahlt As System.Windows.Forms.Label
    Friend WithEvents lblZuBezahlen As System.Windows.Forms.Label
    Friend WithEvents btnBestaetigen As System.Windows.Forms.Button
    Friend WithEvents pnlPreis As System.Windows.Forms.Panel
    Friend WithEvents lblSelection As System.Windows.Forms.Label
    Friend WithEvents lblGeldschlitz As System.Windows.Forms.Label
    Friend WithEvents pnlOutputAll As System.Windows.Forms.Panel
    Friend WithEvents pnlGeldschlitz As System.Windows.Forms.Panel
    Friend WithEvents pnlGeld As System.Windows.Forms.Panel
    Friend WithEvents pnlContainer As System.Windows.Forms.Panel
    Friend WithEvents tmrContainerAnimation As System.Windows.Forms.Timer
    Friend WithEvents btnGeldZuerueck As System.Windows.Forms.Button
    Friend WithEvents pnlGeldAusgabe As System.Windows.Forms.Panel
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents mpicSchoko As System.Windows.Forms.PictureBox
    Friend WithEvents picErdbeere As System.Windows.Forms.PictureBox
    Friend WithEvents picVanile As System.Windows.Forms.PictureBox
    Friend WithEvents tmrSoftice As System.Windows.Forms.Timer
    Friend WithEvents pnlIceAnimation As System.Windows.Forms.Panel

End Class
