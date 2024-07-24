<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class navigationForm
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(navigationForm))
        Me.byArtistBtn = New System.Windows.Forms.Button()
        Me.byVenueBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.navigationBox = New System.Windows.Forms.ListBox()
        Me.backBtn = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ReportBtn = New System.Windows.Forms.Button()
        Me.setlistBox = New System.Windows.Forms.ListBox()
        Me.setlistLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.lblCntr = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'byArtistBtn
        '
        Me.byArtistBtn.Location = New System.Drawing.Point(26, 84)
        Me.byArtistBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.byArtistBtn.Name = "byArtistBtn"
        Me.byArtistBtn.Size = New System.Drawing.Size(113, 50)
        Me.byArtistBtn.TabIndex = 0
        Me.byArtistBtn.Text = "By Artist"
        Me.byArtistBtn.UseVisualStyleBackColor = True
        '
        'byVenueBtn
        '
        Me.byVenueBtn.Location = New System.Drawing.Point(26, 139)
        Me.byVenueBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.byVenueBtn.Name = "byVenueBtn"
        Me.byVenueBtn.Size = New System.Drawing.Size(113, 50)
        Me.byVenueBtn.TabIndex = 1
        Me.byVenueBtn.Text = "By Venue"
        Me.byVenueBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 39)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Navigation "
        '
        'navigationBox
        '
        Me.navigationBox.FormattingEnabled = True
        Me.navigationBox.Location = New System.Drawing.Point(171, 84)
        Me.navigationBox.Margin = New System.Windows.Forms.Padding(2)
        Me.navigationBox.Name = "navigationBox"
        Me.navigationBox.Size = New System.Drawing.Size(428, 160)
        Me.navigationBox.TabIndex = 9
        '
        'backBtn
        '
        Me.backBtn.Location = New System.Drawing.Point(566, 420)
        Me.backBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(58, 32)
        Me.backBtn.TabIndex = 10
        Me.backBtn.Text = "Back"
        Me.backBtn.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(171, 60)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(197, 21)
        Me.ComboBox1.TabIndex = 11
        '
        'ReportBtn
        '
        Me.ReportBtn.Location = New System.Drawing.Point(26, 214)
        Me.ReportBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.ReportBtn.Name = "ReportBtn"
        Me.ReportBtn.Size = New System.Drawing.Size(113, 50)
        Me.ReportBtn.TabIndex = 12
        Me.ReportBtn.Text = "Reports"
        Me.ReportBtn.UseVisualStyleBackColor = True
        '
        'setlistBox
        '
        Me.setlistBox.FormattingEnabled = True
        Me.setlistBox.Location = New System.Drawing.Point(171, 277)
        Me.setlistBox.Margin = New System.Windows.Forms.Padding(2)
        Me.setlistBox.Name = "setlistBox"
        Me.setlistBox.Size = New System.Drawing.Size(428, 121)
        Me.setlistBox.TabIndex = 13
        '
        'setlistLabel
        '
        Me.setlistLabel.AutoSize = True
        Me.setlistLabel.Location = New System.Drawing.Point(168, 258)
        Me.setlistLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.setlistLabel.Name = "setlistLabel"
        Me.setlistLabel.Size = New System.Drawing.Size(42, 13)
        Me.setlistLabel.TabIndex = 14
        Me.setlistLabel.Text = "SetList:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(225, -12)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 67)
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(13, 330)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox2.TabIndex = 28
        Me.ComboBox2.Visible = False
        '
        'lblCntr
        '
        Me.lblCntr.AutoSize = True
        Me.lblCntr.Location = New System.Drawing.Point(12, 310)
        Me.lblCntr.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCntr.Name = "lblCntr"
        Me.lblCntr.Size = New System.Drawing.Size(146, 13)
        Me.lblCntr.TabIndex = 29
        Me.lblCntr.Text = "You can also filter by country:"
        Me.lblCntr.Visible = False
        '
        'navigationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 463)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblCntr)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.setlistLabel)
        Me.Controls.Add(Me.setlistBox)
        Me.Controls.Add(Me.ReportBtn)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.backBtn)
        Me.Controls.Add(Me.navigationBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.byVenueBtn)
        Me.Controls.Add(Me.byArtistBtn)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "navigationForm"
        Me.Text = "Navigation"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents byArtistBtn As Button
    Friend WithEvents byVenueBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents navigationBox As ListBox
    Friend WithEvents backBtn As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ReportBtn As Button
    Friend WithEvents setlistBox As ListBox
    Friend WithEvents setlistLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents lblCntr As Label
End Class
