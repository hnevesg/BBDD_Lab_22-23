<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class concertForm
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
        Me.lstBoxConcerts = New System.Windows.Forms.ListBox()
        Me.lblSong = New System.Windows.Forms.Label()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnInsert = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSetlits = New System.Windows.Forms.Label()
        Me.backBtn = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblVenue = New System.Windows.Forms.Label()
        Me.lblArtist = New System.Windows.Forms.Label()
        Me.lblConcerts = New System.Windows.Forms.Label()
        Me.lstBoxSetlists = New System.Windows.Forms.ListBox()
        Me.CBDate = New System.Windows.Forms.DateTimePicker()
        Me.CBArtist = New System.Windows.Forms.ComboBox()
        Me.CBVenue = New System.Windows.Forms.ComboBox()
        Me.CBSong = New System.Windows.Forms.ComboBox()
        Me.UpArrow = New System.Windows.Forms.Button()
        Me.DownArrow = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstBoxConcerts
        '
        Me.lstBoxConcerts.FormattingEnabled = True
        Me.lstBoxConcerts.Location = New System.Drawing.Point(24, 94)
        Me.lstBoxConcerts.Margin = New System.Windows.Forms.Padding(2)
        Me.lstBoxConcerts.Name = "lstBoxConcerts"
        Me.lstBoxConcerts.Size = New System.Drawing.Size(389, 134)
        Me.lstBoxConcerts.TabIndex = 10
        '
        'lblSong
        '
        Me.lblSong.AutoSize = True
        Me.lblSong.Location = New System.Drawing.Point(43, 359)
        Me.lblSong.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSong.Name = "lblSong"
        Me.lblSong.Size = New System.Drawing.Size(32, 13)
        Me.lblSong.TabIndex = 7
        Me.lblSong.Text = "Song"
        Me.lblSong.Visible = False
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(554, 280)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(41, 81)
        Me.BtnClear.TabIndex = 24
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(473, 338)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 23)
        Me.BtnDelete.TabIndex = 23
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(473, 309)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.BtnUpdate.TabIndex = 22
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnInsert
        '
        Me.BtnInsert.Location = New System.Drawing.Point(473, 280)
        Me.BtnInsert.Name = "BtnInsert"
        Me.BtnInsert.Size = New System.Drawing.Size(75, 23)
        Me.BtnInsert.TabIndex = 21
        Me.BtnInsert.Text = "Insert"
        Me.BtnInsert.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(511, 39)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Concert and Setlist management"
        '
        'lblSetlits
        '
        Me.lblSetlits.AutoSize = True
        Me.lblSetlits.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSetlits.Location = New System.Drawing.Point(430, 69)
        Me.lblSetlits.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSetlits.Name = "lblSetlits"
        Me.lblSetlits.Size = New System.Drawing.Size(57, 20)
        Me.lblSetlits.TabIndex = 26
        Me.lblSetlits.Text = "Setlist:"
        '
        'backBtn
        '
        Me.backBtn.Location = New System.Drawing.Point(795, 363)
        Me.backBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(70, 41)
        Me.backBtn.TabIndex = 27
        Me.backBtn.Text = "Back"
        Me.backBtn.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.Location = New System.Drawing.Point(19, 324)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(78, 35)
        Me.lblDate.TabIndex = 30
        Me.lblDate.Text = "Date (dd/mm/yyyy)"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblDate.Visible = False
        '
        'lblVenue
        '
        Me.lblVenue.AutoSize = True
        Me.lblVenue.Location = New System.Drawing.Point(43, 293)
        Me.lblVenue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblVenue.Name = "lblVenue"
        Me.lblVenue.Size = New System.Drawing.Size(38, 13)
        Me.lblVenue.TabIndex = 29
        Me.lblVenue.Text = "Venue"
        Me.lblVenue.Visible = False
        '
        'lblArtist
        '
        Me.lblArtist.AutoSize = True
        Me.lblArtist.Location = New System.Drawing.Point(43, 262)
        Me.lblArtist.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblArtist.Name = "lblArtist"
        Me.lblArtist.Size = New System.Drawing.Size(30, 13)
        Me.lblArtist.TabIndex = 28
        Me.lblArtist.Text = "Artist"
        Me.lblArtist.Visible = False
        '
        'lblConcerts
        '
        Me.lblConcerts.AutoSize = True
        Me.lblConcerts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConcerts.Location = New System.Drawing.Point(20, 69)
        Me.lblConcerts.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblConcerts.Name = "lblConcerts"
        Me.lblConcerts.Size = New System.Drawing.Size(77, 20)
        Me.lblConcerts.TabIndex = 36
        Me.lblConcerts.Text = "Concerts:"
        '
        'lstBoxSetlists
        '
        Me.lstBoxSetlists.FormattingEnabled = True
        Me.lstBoxSetlists.Location = New System.Drawing.Point(433, 94)
        Me.lstBoxSetlists.Margin = New System.Windows.Forms.Padding(2)
        Me.lstBoxSetlists.Name = "lstBoxSetlists"
        Me.lstBoxSetlists.Size = New System.Drawing.Size(389, 134)
        Me.lstBoxSetlists.TabIndex = 39
        '
        'CBDate
        '
        Me.CBDate.CustomFormat = "dd-MM-yyyy"
        Me.CBDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.CBDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CBDate.Location = New System.Drawing.Point(97, 324)
        Me.CBDate.Margin = New System.Windows.Forms.Padding(2)
        Me.CBDate.Name = "CBDate"
        Me.CBDate.Size = New System.Drawing.Size(347, 20)
        Me.CBDate.TabIndex = 42
        Me.CBDate.Visible = False
        '
        'CBArtist
        '
        Me.CBArtist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBArtist.FormattingEnabled = True
        Me.CBArtist.Location = New System.Drawing.Point(97, 260)
        Me.CBArtist.Margin = New System.Windows.Forms.Padding(2)
        Me.CBArtist.Name = "CBArtist"
        Me.CBArtist.Size = New System.Drawing.Size(347, 21)
        Me.CBArtist.TabIndex = 43
        '
        'CBVenue
        '
        Me.CBVenue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBVenue.FormattingEnabled = True
        Me.CBVenue.Location = New System.Drawing.Point(97, 291)
        Me.CBVenue.Margin = New System.Windows.Forms.Padding(2)
        Me.CBVenue.Name = "CBVenue"
        Me.CBVenue.Size = New System.Drawing.Size(347, 21)
        Me.CBVenue.TabIndex = 44
        '
        'CBSong
        '
        Me.CBSong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBSong.FormattingEnabled = True
        Me.CBSong.Location = New System.Drawing.Point(97, 356)
        Me.CBSong.Margin = New System.Windows.Forms.Padding(2)
        Me.CBSong.Name = "CBSong"
        Me.CBSong.Size = New System.Drawing.Size(347, 21)
        Me.CBSong.TabIndex = 46
        '
        'UpArrow
        '
        Me.UpArrow.Location = New System.Drawing.Point(826, 117)
        Me.UpArrow.Margin = New System.Windows.Forms.Padding(2)
        Me.UpArrow.Name = "UpArrow"
        Me.UpArrow.Size = New System.Drawing.Size(28, 33)
        Me.UpArrow.TabIndex = 47
        Me.UpArrow.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.UpArrow.UseVisualStyleBackColor = True
        Me.UpArrow.Visible = False
        '
        'DownArrow
        '
        Me.DownArrow.Location = New System.Drawing.Point(826, 167)
        Me.DownArrow.Margin = New System.Windows.Forms.Padding(2)
        Me.DownArrow.Name = "DownArrow"
        Me.DownArrow.Size = New System.Drawing.Size(28, 33)
        Me.DownArrow.TabIndex = 48
        Me.DownArrow.UseVisualStyleBackColor = True
        Me.DownArrow.Visible = False
        '
        'concertForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 415)
        Me.ControlBox = False
        Me.Controls.Add(Me.DownArrow)
        Me.Controls.Add(Me.UpArrow)
        Me.Controls.Add(Me.CBSong)
        Me.Controls.Add(Me.CBVenue)
        Me.Controls.Add(Me.CBArtist)
        Me.Controls.Add(Me.CBDate)
        Me.Controls.Add(Me.lstBoxSetlists)
        Me.Controls.Add(Me.lblConcerts)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblVenue)
        Me.Controls.Add(Me.lblArtist)
        Me.Controls.Add(Me.backBtn)
        Me.Controls.Add(Me.lblSetlits)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnInsert)
        Me.Controls.Add(Me.lstBoxConcerts)
        Me.Controls.Add(Me.lblSong)
        Me.Name = "concertForm"
        Me.Text = "Concert management"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstBoxConcerts As ListBox
    Friend WithEvents lblSong As Label
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnInsert As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSetlits As Label
    Friend WithEvents backBtn As Button
    Friend WithEvents lblDate As Label
    Friend WithEvents lblVenue As Label
    Friend WithEvents lblArtist As Label
    Friend WithEvents lblConcerts As Label
    Friend WithEvents lstBoxSetlists As ListBox
    Friend WithEvents CBDate As DateTimePicker
    Friend WithEvents CBArtist As ComboBox
    Friend WithEvents CBVenue As ComboBox
    Friend WithEvents CBSong As ComboBox
    Friend WithEvents UpArrow As Button
    Friend WithEvents DownArrow As Button
End Class
