<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class manageForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnArtist = New System.Windows.Forms.Button()
        Me.BtnAlbum = New System.Windows.Forms.Button()
        Me.BtnSong = New System.Windows.Forms.Button()
        Me.BtnVenue = New System.Windows.Forms.Button()
        Me.BtnCountry = New System.Windows.Forms.Button()
        Me.BtnInsert = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.nameTxt = New System.Windows.Forms.TextBox()
        Me.secondLabel = New System.Windows.Forms.Label()
        Me.secondTxt = New System.Windows.Forms.TextBox()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.objList = New System.Windows.Forms.ListBox()
        Me.LblWelcome = New System.Windows.Forms.Label()
        Me.typesCurtain = New System.Windows.Forms.ComboBox()
        Me.typeLabel = New System.Windows.Forms.Label()
        Me.hiddenLabel = New System.Windows.Forms.Label()
        Me.backBtn = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.year_length = New System.Windows.Forms.Label()
        Me.order = New System.Windows.Forms.Label()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnArtist
        '
        Me.BtnArtist.Location = New System.Drawing.Point(21, 67)
        Me.BtnArtist.Name = "BtnArtist"
        Me.BtnArtist.Size = New System.Drawing.Size(113, 39)
        Me.BtnArtist.TabIndex = 1
        Me.BtnArtist.Text = "Manage artists"
        Me.BtnArtist.UseVisualStyleBackColor = True
        '
        'BtnAlbum
        '
        Me.BtnAlbum.Location = New System.Drawing.Point(21, 113)
        Me.BtnAlbum.Name = "BtnAlbum"
        Me.BtnAlbum.Size = New System.Drawing.Size(113, 39)
        Me.BtnAlbum.TabIndex = 2
        Me.BtnAlbum.Text = "Manage albums"
        Me.BtnAlbum.UseVisualStyleBackColor = True
        '
        'BtnSong
        '
        Me.BtnSong.Location = New System.Drawing.Point(21, 163)
        Me.BtnSong.Name = "BtnSong"
        Me.BtnSong.Size = New System.Drawing.Size(113, 39)
        Me.BtnSong.TabIndex = 3
        Me.BtnSong.Text = "Manage songs"
        Me.BtnSong.UseVisualStyleBackColor = True
        '
        'BtnVenue
        '
        Me.BtnVenue.Location = New System.Drawing.Point(21, 209)
        Me.BtnVenue.Name = "BtnVenue"
        Me.BtnVenue.Size = New System.Drawing.Size(113, 39)
        Me.BtnVenue.TabIndex = 5
        Me.BtnVenue.Text = "Manage venues"
        Me.BtnVenue.UseVisualStyleBackColor = True
        '
        'BtnCountry
        '
        Me.BtnCountry.Location = New System.Drawing.Point(21, 258)
        Me.BtnCountry.Name = "BtnCountry"
        Me.BtnCountry.Size = New System.Drawing.Size(113, 39)
        Me.BtnCountry.TabIndex = 6
        Me.BtnCountry.Text = "Manage countries"
        Me.BtnCountry.UseVisualStyleBackColor = True
        '
        'BtnInsert
        '
        Me.BtnInsert.Location = New System.Drawing.Point(468, 280)
        Me.BtnInsert.Name = "BtnInsert"
        Me.BtnInsert.Size = New System.Drawing.Size(75, 23)
        Me.BtnInsert.TabIndex = 8
        Me.BtnInsert.Text = "Insert"
        Me.BtnInsert.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(468, 309)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.BtnUpdate.TabIndex = 9
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(468, 338)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 23)
        Me.BtnDelete.TabIndex = 10
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Location = New System.Drawing.Point(160, 289)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(59, 13)
        Me.nameLabel.TabIndex = 13
        Me.nameLabel.Text = "nameLabel"
        Me.nameLabel.Visible = False
        '
        'nameTxt
        '
        Me.nameTxt.Location = New System.Drawing.Point(241, 285)
        Me.nameTxt.Name = "nameTxt"
        Me.nameTxt.Size = New System.Drawing.Size(197, 20)
        Me.nameTxt.TabIndex = 15
        Me.nameTxt.Visible = False
        '
        'secondLabel
        '
        Me.secondLabel.AutoSize = True
        Me.secondLabel.Location = New System.Drawing.Point(160, 257)
        Me.secondLabel.Name = "secondLabel"
        Me.secondLabel.Size = New System.Drawing.Size(68, 13)
        Me.secondLabel.TabIndex = 16
        Me.secondLabel.Text = "secondLabel"
        Me.secondLabel.Visible = False
        '
        'secondTxt
        '
        Me.secondTxt.Location = New System.Drawing.Point(241, 317)
        Me.secondTxt.Name = "secondTxt"
        Me.secondTxt.Size = New System.Drawing.Size(169, 20)
        Me.secondTxt.TabIndex = 18
        Me.secondTxt.Visible = False
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(549, 280)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(43, 81)
        Me.BtnClear.TabIndex = 20
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'objList
        '
        Me.objList.BackColor = System.Drawing.SystemColors.Info
        Me.objList.FormattingEnabled = True
        Me.objList.Location = New System.Drawing.Point(158, 113)
        Me.objList.Name = "objList"
        Me.objList.Size = New System.Drawing.Size(441, 121)
        Me.objList.TabIndex = 22
        '
        'LblWelcome
        '
        Me.LblWelcome.AutoSize = True
        Me.LblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWelcome.Location = New System.Drawing.Point(14, 9)
        Me.LblWelcome.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblWelcome.Name = "LblWelcome"
        Me.LblWelcome.Size = New System.Drawing.Size(370, 39)
        Me.LblWelcome.TabIndex = 23
        Me.LblWelcome.Text = "Database management"
        '
        'typesCurtain
        '
        Me.typesCurtain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.typesCurtain.FormattingEnabled = True
        Me.typesCurtain.Location = New System.Drawing.Point(241, 317)
        Me.typesCurtain.Margin = New System.Windows.Forms.Padding(2)
        Me.typesCurtain.Name = "typesCurtain"
        Me.typesCurtain.Size = New System.Drawing.Size(197, 21)
        Me.typesCurtain.TabIndex = 24
        Me.typesCurtain.Visible = False
        '
        'typeLabel
        '
        Me.typeLabel.AutoSize = True
        Me.typeLabel.Location = New System.Drawing.Point(160, 321)
        Me.typeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.typeLabel.Name = "typeLabel"
        Me.typeLabel.Size = New System.Drawing.Size(53, 13)
        Me.typeLabel.TabIndex = 25
        Me.typeLabel.Text = "typeLabel"
        Me.typeLabel.Visible = False
        '
        'hiddenLabel
        '
        Me.hiddenLabel.AutoSize = True
        Me.hiddenLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hiddenLabel.Location = New System.Drawing.Point(159, 73)
        Me.hiddenLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.hiddenLabel.Name = "hiddenLabel"
        Me.hiddenLabel.Size = New System.Drawing.Size(0, 24)
        Me.hiddenLabel.TabIndex = 28
        '
        'backBtn
        '
        Me.backBtn.Location = New System.Drawing.Point(556, 404)
        Me.backBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(66, 33)
        Me.backBtn.TabIndex = 29
        Me.backBtn.Text = "Back"
        Me.backBtn.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(241, 253)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(197, 21)
        Me.ComboBox1.TabIndex = 30
        Me.ComboBox1.Visible = False
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(241, 349)
        Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(2)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {2999, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(197, 20)
        Me.NumericUpDown1.TabIndex = 31
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Visible = False
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(241, 378)
        Me.NumericUpDown2.Margin = New System.Windows.Forms.Padding(2)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {2999, 0, 0, 0})
        Me.NumericUpDown2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(196, 20)
        Me.NumericUpDown2.TabIndex = 32
        Me.NumericUpDown2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown2.Visible = False
        '
        'year_length
        '
        Me.year_length.AutoSize = True
        Me.year_length.Location = New System.Drawing.Point(160, 353)
        Me.year_length.Name = "year_length"
        Me.year_length.Size = New System.Drawing.Size(61, 13)
        Me.year_length.TabIndex = 33
        Me.year_length.Text = "year/length"
        Me.year_length.Visible = False
        '
        'order
        '
        Me.order.AutoSize = True
        Me.order.Location = New System.Drawing.Point(160, 382)
        Me.order.Name = "order"
        Me.order.Size = New System.Drawing.Size(31, 13)
        Me.order.TabIndex = 34
        Me.order.Text = "order"
        Me.order.Visible = False
        '
        'manageForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 451)
        Me.ControlBox = False
        Me.Controls.Add(Me.order)
        Me.Controls.Add(Me.year_length)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.backBtn)
        Me.Controls.Add(Me.hiddenLabel)
        Me.Controls.Add(Me.typeLabel)
        Me.Controls.Add(Me.typesCurtain)
        Me.Controls.Add(Me.LblWelcome)
        Me.Controls.Add(Me.objList)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.secondTxt)
        Me.Controls.Add(Me.secondLabel)
        Me.Controls.Add(Me.nameTxt)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnInsert)
        Me.Controls.Add(Me.BtnCountry)
        Me.Controls.Add(Me.BtnVenue)
        Me.Controls.Add(Me.BtnSong)
        Me.Controls.Add(Me.BtnAlbum)
        Me.Controls.Add(Me.BtnArtist)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "manageForm"
        Me.Text = "Database management"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnArtist As Button
    Friend WithEvents BtnAlbum As Button
    Friend WithEvents BtnSong As Button
    Friend WithEvents BtnVenue As Button
    Friend WithEvents BtnCountry As Button
    Friend WithEvents BtnInsert As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents nameLabel As Label
    Friend WithEvents nameTxt As TextBox
    Friend WithEvents secondLabel As Label
    Friend WithEvents secondTxt As TextBox
    Friend WithEvents BtnClear As Button
    Friend WithEvents objList As ListBox
    Friend WithEvents LblWelcome As Label
    Friend WithEvents typesCurtain As ComboBox
    Friend WithEvents typeLabel As Label
    Friend WithEvents hiddenLabel As Label
    Friend WithEvents backBtn As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents year_length As Label
    Friend WithEvents order As Label
End Class
