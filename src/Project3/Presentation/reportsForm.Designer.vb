<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reportsForm
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reportsForm))
        Me.backBtn = New System.Windows.Forms.Button()
        Me.listartistBtn = New System.Windows.Forms.Button()
        Me.mostcountriesBtn = New System.Windows.Forms.Button()
        Me.mostconcertBtn = New System.Windows.Forms.Button()
        Me.songplayedseverBtn = New System.Windows.Forms.Button()
        Me.mostplayedalbumBtn = New System.Windows.Forms.Button()
        Me.mostplayedsongBtn = New System.Windows.Forms.Button()
        Me.lstBox = New System.Windows.Forms.ListBox()
        Me.LblWelcome = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'backBtn
        '
        Me.backBtn.Location = New System.Drawing.Point(533, 377)
        Me.backBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(66, 36)
        Me.backBtn.TabIndex = 0
        Me.backBtn.Text = "Back"
        Me.backBtn.UseVisualStyleBackColor = True
        '
        'listartistBtn
        '
        Me.listartistBtn.Location = New System.Drawing.Point(25, 71)
        Me.listartistBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.listartistBtn.Name = "listartistBtn"
        Me.listartistBtn.Size = New System.Drawing.Size(184, 50)
        Me.listartistBtn.TabIndex = 14
        Me.listartistBtn.Text = "Artists who have ever performed a complete album in a concert"
        Me.listartistBtn.UseVisualStyleBackColor = True
        '
        'mostcountriesBtn
        '
        Me.mostcountriesBtn.Location = New System.Drawing.Point(25, 180)
        Me.mostcountriesBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.mostcountriesBtn.Name = "mostcountriesBtn"
        Me.mostcountriesBtn.Size = New System.Drawing.Size(184, 50)
        Me.mostcountriesBtn.TabIndex = 13
        Me.mostcountriesBtn.Text = "Countries in which there have been more concerts"
        Me.mostcountriesBtn.UseVisualStyleBackColor = True
        '
        'mostconcertBtn
        '
        Me.mostconcertBtn.Location = New System.Drawing.Point(26, 125)
        Me.mostconcertBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.mostconcertBtn.Name = "mostconcertBtn"
        Me.mostconcertBtn.Size = New System.Drawing.Size(183, 50)
        Me.mostconcertBtn.TabIndex = 12
        Me.mostconcertBtn.Text = "Artists who have performed the most concerts"
        Me.mostconcertBtn.UseVisualStyleBackColor = True
        '
        'songplayedseverBtn
        '
        Me.songplayedseverBtn.Location = New System.Drawing.Point(25, 353)
        Me.songplayedseverBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.songplayedseverBtn.Name = "songplayedseverBtn"
        Me.songplayedseverBtn.Size = New System.Drawing.Size(184, 46)
        Me.songplayedseverBtn.TabIndex = 11
        Me.songplayedseverBtn.Text = "Songs played several times"
        Me.songplayedseverBtn.UseVisualStyleBackColor = True
        '
        'mostplayedalbumBtn
        '
        Me.mostplayedalbumBtn.Location = New System.Drawing.Point(25, 251)
        Me.mostplayedalbumBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.mostplayedalbumBtn.Name = "mostplayedalbumBtn"
        Me.mostplayedalbumBtn.Size = New System.Drawing.Size(184, 47)
        Me.mostplayedalbumBtn.TabIndex = 10
        Me.mostplayedalbumBtn.Text = "Most played albums by an Artist"
        Me.mostplayedalbumBtn.UseVisualStyleBackColor = True
        '
        'mostplayedsongBtn
        '
        Me.mostplayedsongBtn.Location = New System.Drawing.Point(25, 302)
        Me.mostplayedsongBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.mostplayedsongBtn.Name = "mostplayedsongBtn"
        Me.mostplayedsongBtn.Size = New System.Drawing.Size(184, 46)
        Me.mostplayedsongBtn.TabIndex = 9
        Me.mostplayedsongBtn.Text = "Most played songs in all Concerts"
        Me.mostplayedsongBtn.UseVisualStyleBackColor = True
        '
        'lstBox
        '
        Me.lstBox.FormattingEnabled = True
        Me.lstBox.Location = New System.Drawing.Point(242, 97)
        Me.lstBox.Margin = New System.Windows.Forms.Padding(2)
        Me.lstBox.Name = "lstBox"
        Me.lstBox.Size = New System.Drawing.Size(332, 238)
        Me.lstBox.TabIndex = 15
        '
        'LblWelcome
        '
        Me.LblWelcome.AutoSize = True
        Me.LblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWelcome.Location = New System.Drawing.Point(19, 13)
        Me.LblWelcome.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblWelcome.Name = "LblWelcome"
        Me.LblWelcome.Size = New System.Drawing.Size(136, 39)
        Me.LblWelcome.TabIndex = 24
        Me.LblWelcome.Text = "Reports" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(242, 71)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(332, 21)
        Me.ComboBox1.TabIndex = 25
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(355, -2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 67)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'reportsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 426)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.LblWelcome)
        Me.Controls.Add(Me.lstBox)
        Me.Controls.Add(Me.listartistBtn)
        Me.Controls.Add(Me.mostcountriesBtn)
        Me.Controls.Add(Me.mostconcertBtn)
        Me.Controls.Add(Me.songplayedseverBtn)
        Me.Controls.Add(Me.mostplayedalbumBtn)
        Me.Controls.Add(Me.mostplayedsongBtn)
        Me.Controls.Add(Me.backBtn)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "reportsForm"
        Me.Text = "Reports"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents backBtn As Button
    Friend WithEvents listartistBtn As Button
    Friend WithEvents mostcountriesBtn As Button
    Friend WithEvents mostconcertBtn As Button
    Friend WithEvents songplayedseverBtn As Button
    Friend WithEvents mostplayedalbumBtn As Button
    Friend WithEvents mostplayedsongBtn As Button
    Friend WithEvents lstBox As ListBox
    Friend WithEvents LblWelcome As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
