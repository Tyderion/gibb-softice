﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstGeschmack = New System.Windows.Forms.ListBox()
        Me.rbtSehrKlein = New System.Windows.Forms.RadioButton()
        Me.rbtKlein = New System.Windows.Forms.RadioButton()
        Me.rbtMittel = New System.Windows.Forms.RadioButton()
        Me.rbtGross = New System.Windows.Forms.RadioButton()
        Me.rbtExtraGross = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
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
        Me.pic10rp = New System.Windows.Forms.PictureBox()
        Me.pic20rp = New System.Windows.Forms.PictureBox()
        Me.pi1Fr = New System.Windows.Forms.PictureBox()
        Me.pic50rp = New System.Windows.Forms.PictureBox()
        Me.pic2Fr = New System.Windows.Forms.PictureBox()
        Me.pic5Fr = New System.Windows.Forms.PictureBox()
        Me.lblGeldschlitz = New System.Windows.Forms.Label()
        Me.pnlOutputAll = New System.Windows.Forms.Panel()
        Me.pnlGeldschlitz = New System.Windows.Forms.Panel()
        Me.pnlGeld = New System.Windows.Forms.Panel()
        Me.pnlContainer = New System.Windows.Forms.Panel()
        Me.tmrContainerAnimation = New System.Windows.Forms.Timer(Me.components)
        Me.btnGeldZuerueck = New System.Windows.Forms.Button()
        Me.pnlGeldAusgabe = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.pnlSize.SuspendLayout()
        Me.pnlPreis.SuspendLayout()
        CType(Me.pic10rp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic20rp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pi1Fr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic50rp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2Fr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic5Fr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGeldschlitz.SuspendLayout()
        Me.pnlGeld.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstGeschmack)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(132, 191)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Geschmack"
        '
        'lstGeschmack
        '
        Me.lstGeschmack.FormattingEnabled = True
        Me.lstGeschmack.Items.AddRange(New Object() {"Schokolade", "Stracciatella", "Erdbeere", "Vanille", "Mokka"})
        Me.lstGeschmack.Location = New System.Drawing.Point(6, 19)
        Me.lstGeschmack.Name = "lstGeschmack"
        Me.lstGeschmack.Size = New System.Drawing.Size(120, 147)
        Me.lstGeschmack.TabIndex = 0
        '
        'rbtSehrKlein
        '
        Me.rbtSehrKlein.AutoSize = True
        Me.rbtSehrKlein.Location = New System.Drawing.Point(3, 95)
        Me.rbtSehrKlein.Name = "rbtSehrKlein"
        Me.rbtSehrKlein.Size = New System.Drawing.Size(73, 17)
        Me.rbtSehrKlein.TabIndex = 4
        Me.rbtSehrKlein.TabStop = True
        Me.rbtSehrKlein.Text = "Sehr Klein"
        Me.rbtSehrKlein.UseVisualStyleBackColor = True
        '
        'rbtKlein
        '
        Me.rbtKlein.AutoSize = True
        Me.rbtKlein.Location = New System.Drawing.Point(3, 72)
        Me.rbtKlein.Name = "rbtKlein"
        Me.rbtKlein.Size = New System.Drawing.Size(48, 17)
        Me.rbtKlein.TabIndex = 3
        Me.rbtKlein.TabStop = True
        Me.rbtKlein.Text = "Klein"
        Me.rbtKlein.UseVisualStyleBackColor = True
        '
        'rbtMittel
        '
        Me.rbtMittel.AutoSize = True
        Me.rbtMittel.Location = New System.Drawing.Point(3, 49)
        Me.rbtMittel.Name = "rbtMittel"
        Me.rbtMittel.Size = New System.Drawing.Size(80, 17)
        Me.rbtMittel.TabIndex = 2
        Me.rbtMittel.TabStop = True
        Me.rbtMittel.Text = "Mittel Gross"
        Me.rbtMittel.UseVisualStyleBackColor = True
        '
        'rbtGross
        '
        Me.rbtGross.AutoSize = True
        Me.rbtGross.Location = New System.Drawing.Point(3, 26)
        Me.rbtGross.Name = "rbtGross"
        Me.rbtGross.Size = New System.Drawing.Size(52, 17)
        Me.rbtGross.TabIndex = 1
        Me.rbtGross.TabStop = True
        Me.rbtGross.Text = "Gross"
        Me.rbtGross.UseVisualStyleBackColor = True
        '
        'rbtExtraGross
        '
        Me.rbtExtraGross.AutoSize = True
        Me.rbtExtraGross.Location = New System.Drawing.Point(3, 3)
        Me.rbtExtraGross.Name = "rbtExtraGross"
        Me.rbtExtraGross.Size = New System.Drawing.Size(79, 17)
        Me.rbtExtraGross.TabIndex = 0
        Me.rbtExtraGross.TabStop = True
        Me.rbtExtraGross.Text = "Extra Gross"
        Me.rbtExtraGross.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.pnlSize)
        Me.GroupBox2.Controls.Add(Me.cmbType)
        Me.GroupBox2.Location = New System.Drawing.Point(178, 79)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(132, 191)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Typ && Grösse"
        '
        'pnlSize
        '
        Me.pnlSize.Controls.Add(Me.rbtSehrKlein)
        Me.pnlSize.Controls.Add(Me.rbtExtraGross)
        Me.pnlSize.Controls.Add(Me.rbtKlein)
        Me.pnlSize.Controls.Add(Me.rbtGross)
        Me.pnlSize.Controls.Add(Me.rbtMittel)
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
        'pic10rp
        '
        Me.pic10rp.Image = Global.Softice_Automat.My.Resources.Resources._10Rp_front
        Me.pic10rp.Location = New System.Drawing.Point(147, 92)
        Me.pic10rp.Name = "pic10rp"
        Me.pic10rp.Size = New System.Drawing.Size(68, 63)
        Me.pic10rp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic10rp.TabIndex = 14
        Me.pic10rp.TabStop = False
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
        '
        'pi1Fr
        '
        Me.pi1Fr.Image = Global.Softice_Automat.My.Resources.Resources._1Fr_front
        Me.pi1Fr.Location = New System.Drawing.Point(147, 13)
        Me.pi1Fr.Name = "pi1Fr"
        Me.pi1Fr.Size = New System.Drawing.Size(68, 72)
        Me.pi1Fr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pi1Fr.TabIndex = 12
        Me.pi1Fr.TabStop = False
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
        Me.pnlGeld.Controls.Add(Me.pi1Fr)
        Me.pnlGeld.Controls.Add(Me.pic20rp)
        Me.pnlGeld.Location = New System.Drawing.Point(506, 100)
        Me.pnlGeld.Name = "pnlGeld"
        Me.pnlGeld.Size = New System.Drawing.Size(230, 170)
        Me.pnlGeld.TabIndex = 31
        '
        'pnlContainer
        '
        Me.pnlContainer.BackColor = System.Drawing.Color.Transparent
        Me.pnlContainer.Location = New System.Drawing.Point(12, 384)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Size = New System.Drawing.Size(196, 171)
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
        Me.pnlGeldAusgabe.Location = New System.Drawing.Point(589, 440)
        Me.pnlGeldAusgabe.Name = "pnlGeldAusgabe"
        Me.pnlGeldAusgabe.Size = New System.Drawing.Size(132, 106)
        Me.pnlGeldAusgabe.TabIndex = 33
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(771, 666)
        Me.Controls.Add(Me.pnlGeldAusgabe)
        Me.Controls.Add(Me.btnGeldZuerueck)
        Me.Controls.Add(Me.pnlContainer)
        Me.Controls.Add(Me.pnlGeld)
        Me.Controls.Add(Me.pnlGeldschlitz)
        Me.Controls.Add(Me.pnlOutputAll)
        Me.Controls.Add(Me.lblSelection)
        Me.Controls.Add(Me.pnlPreis)
        Me.Controls.Add(Me.btnBestaetigen)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Ice-O-Matic"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.pnlSize.ResumeLayout(False)
        Me.pnlSize.PerformLayout()
        Me.pnlPreis.ResumeLayout(False)
        Me.pnlPreis.PerformLayout()
        CType(Me.pic10rp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic20rp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pi1Fr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic50rp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic2Fr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic5Fr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGeldschlitz.ResumeLayout(False)
        Me.pnlGeldschlitz.PerformLayout()
        Me.pnlGeld.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstGeschmack As System.Windows.Forms.ListBox
    Friend WithEvents rbtSehrKlein As System.Windows.Forms.RadioButton
    Friend WithEvents rbtKlein As System.Windows.Forms.RadioButton
    Friend WithEvents rbtMittel As System.Windows.Forms.RadioButton
    Friend WithEvents rbtGross As System.Windows.Forms.RadioButton
    Friend WithEvents rbtExtraGross As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents pnlSize As System.Windows.Forms.Panel
    Friend WithEvents lblPreis As System.Windows.Forms.Label
    Friend WithEvents lblPreisFr As System.Windows.Forms.Label
    Friend WithEvents pic5Fr As System.Windows.Forms.PictureBox
    Friend WithEvents pic2Fr As System.Windows.Forms.PictureBox
    Friend WithEvents pic50rp As System.Windows.Forms.PictureBox
    Friend WithEvents pi1Fr As System.Windows.Forms.PictureBox
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

End Class
