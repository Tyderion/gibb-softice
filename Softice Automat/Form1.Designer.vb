<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstGeschmack = New System.Windows.Forms.ListBox()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.pnlSize = New System.Windows.Forms.Panel()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pnlPreis = New System.Windows.Forms.Panel()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.lblSelection = New System.Windows.Forms.Label()
        Me.picGeldSchlitz = New System.Windows.Forms.PictureBox()
        Me.pic10rp = New System.Windows.Forms.PictureBox()
        Me.pic20rp = New System.Windows.Forms.PictureBox()
        Me.pi1Fr = New System.Windows.Forms.PictureBox()
        Me.pic50rp = New System.Windows.Forms.PictureBox()
        Me.pic2Fr = New System.Windows.Forms.PictureBox()
        Me.pic5Fr = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.pnlSize.SuspendLayout()
        Me.pnlPreis.SuspendLayout()
        CType(Me.picGeldSchlitz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic10rp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic20rp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pi1Fr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic50rp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2Fr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic5Fr, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(3, 95)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(73, 17)
        Me.RadioButton5.TabIndex = 4
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Sehr Klein"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(3, 72)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(48, 17)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Klein"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(3, 49)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(50, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Mittel"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(3, 26)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(52, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Gross"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(3, 3)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(79, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Extra Gross"
        Me.RadioButton1.UseVisualStyleBackColor = True
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
        Me.pnlSize.Controls.Add(Me.Splitter1)
        Me.pnlSize.Controls.Add(Me.RadioButton5)
        Me.pnlSize.Controls.Add(Me.RadioButton1)
        Me.pnlSize.Controls.Add(Me.RadioButton4)
        Me.pnlSize.Controls.Add(Me.RadioButton2)
        Me.pnlSize.Controls.Add(Me.RadioButton3)
        Me.pnlSize.Location = New System.Drawing.Point(7, 46)
        Me.pnlSize.Name = "pnlSize"
        Me.pnlSize.Size = New System.Drawing.Size(109, 131)
        Me.pnlSize.TabIndex = 1
        '
        'cmbType
        '
        Me.cmbType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"Cornet", "Becher"})
        Me.cmbType.Location = New System.Drawing.Point(7, 19)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(121, 21)
        Me.cmbType.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Preis: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(81, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "2.00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(81, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "0.00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(81, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "2.00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "bezahlt:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "zu bezahlen:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(316, 220)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 49)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Wahl bestätigen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pnlPreis
        '
        Me.pnlPreis.Controls.Add(Me.Label6)
        Me.pnlPreis.Controls.Add(Me.Label1)
        Me.pnlPreis.Controls.Add(Me.Label2)
        Me.pnlPreis.Controls.Add(Me.Label3)
        Me.pnlPreis.Controls.Add(Me.Label5)
        Me.pnlPreis.Controls.Add(Me.Label4)
        Me.pnlPreis.Location = New System.Drawing.Point(316, 12)
        Me.pnlPreis.Name = "pnlPreis"
        Me.pnlPreis.Size = New System.Drawing.Size(169, 54)
        Me.pnlPreis.TabIndex = 22
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 131)
        Me.Splitter1.TabIndex = 5
        Me.Splitter1.TabStop = False
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
        'picGeldSchlitz
        '
        Me.picGeldSchlitz.Location = New System.Drawing.Point(316, 79)
        Me.picGeldSchlitz.Name = "picGeldSchlitz"
        Me.picGeldSchlitz.Size = New System.Drawing.Size(160, 62)
        Me.picGeldSchlitz.TabIndex = 21
        Me.picGeldSchlitz.TabStop = False
        '
        'pic10rp
        '
        Me.pic10rp.Image = Global.Softice_Automat.My.Resources.Resources._10Rp_front
        Me.pic10rp.Location = New System.Drawing.Point(630, 207)
        Me.pic10rp.Name = "pic10rp"
        Me.pic10rp.Size = New System.Drawing.Size(68, 63)
        Me.pic10rp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic10rp.TabIndex = 14
        Me.pic10rp.TabStop = False
        '
        'pic20rp
        '
        Me.pic20rp.Image = Global.Softice_Automat.My.Resources.Resources._20Rp_front
        Me.pic20rp.Location = New System.Drawing.Point(566, 207)
        Me.pic20rp.Name = "pic20rp"
        Me.pic20rp.Size = New System.Drawing.Size(58, 63)
        Me.pic20rp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic20rp.TabIndex = 13
        Me.pic20rp.TabStop = False
        '
        'pi1Fr
        '
        Me.pi1Fr.Image = Global.Softice_Automat.My.Resources.Resources._1Fr_front
        Me.pi1Fr.Location = New System.Drawing.Point(630, 128)
        Me.pi1Fr.Name = "pi1Fr"
        Me.pi1Fr.Size = New System.Drawing.Size(68, 72)
        Me.pi1Fr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pi1Fr.TabIndex = 12
        Me.pi1Fr.TabStop = False
        '
        'pic50rp
        '
        Me.pic50rp.Image = Global.Softice_Automat.My.Resources.Resources._50Rp_front
        Me.pic50rp.Location = New System.Drawing.Point(495, 207)
        Me.pic50rp.Name = "pic50rp"
        Me.pic50rp.Size = New System.Drawing.Size(65, 63)
        Me.pic50rp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic50rp.TabIndex = 11
        Me.pic50rp.TabStop = False
        '
        'pic2Fr
        '
        Me.pic2Fr.Image = Global.Softice_Automat.My.Resources.Resources._2Fr_front
        Me.pic2Fr.Location = New System.Drawing.Point(566, 128)
        Me.pic2Fr.Name = "pic2Fr"
        Me.pic2Fr.Size = New System.Drawing.Size(58, 73)
        Me.pic2Fr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic2Fr.TabIndex = 10
        Me.pic2Fr.TabStop = False
        '
        'pic5Fr
        '
        Me.pic5Fr.Image = Global.Softice_Automat.My.Resources.Resources._5Fr_front
        Me.pic5Fr.Location = New System.Drawing.Point(495, 128)
        Me.pic5Fr.Name = "pic5Fr"
        Me.pic5Fr.Size = New System.Drawing.Size(65, 73)
        Me.pic5Fr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic5Fr.TabIndex = 9
        Me.pic5Fr.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(345, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 15)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "                                    "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 434)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblSelection)
        Me.Controls.Add(Me.pnlPreis)
        Me.Controls.Add(Me.picGeldSchlitz)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pic10rp)
        Me.Controls.Add(Me.pic20rp)
        Me.Controls.Add(Me.pi1Fr)
        Me.Controls.Add(Me.pic50rp)
        Me.Controls.Add(Me.pic2Fr)
        Me.Controls.Add(Me.pic5Fr)
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
        CType(Me.picGeldSchlitz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic10rp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic20rp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pi1Fr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic50rp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic2Fr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic5Fr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstGeschmack As System.Windows.Forms.ListBox
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents pnlSize As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pic5Fr As System.Windows.Forms.PictureBox
    Friend WithEvents pic2Fr As System.Windows.Forms.PictureBox
    Friend WithEvents pic50rp As System.Windows.Forms.PictureBox
    Friend WithEvents pi1Fr As System.Windows.Forms.PictureBox
    Friend WithEvents pic20rp As System.Windows.Forms.PictureBox
    Friend WithEvents pic10rp As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents picGeldSchlitz As System.Windows.Forms.PictureBox
    Friend WithEvents pnlPreis As System.Windows.Forms.Panel
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents lblSelection As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
