<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class orderedListForm
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
        Me.lstBox = New System.Windows.Forms.ListBox()
        Me.beginDate = New System.Windows.Forms.DateTimePicker()
        Me.endDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.backBtn = New System.Windows.Forms.Button()
        Me.dateBtn = New System.Windows.Forms.Button()
        Me.titleForm = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstBox
        '
        Me.lstBox.FormattingEnabled = True
        Me.lstBox.Location = New System.Drawing.Point(217, 84)
        Me.lstBox.Margin = New System.Windows.Forms.Padding(2)
        Me.lstBox.Name = "lstBox"
        Me.lstBox.Size = New System.Drawing.Size(308, 186)
        Me.lstBox.TabIndex = 0
        '
        'beginDate
        '
        Me.beginDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.beginDate.Location = New System.Drawing.Point(85, 96)
        Me.beginDate.Margin = New System.Windows.Forms.Padding(2)
        Me.beginDate.Name = "beginDate"
        Me.beginDate.Size = New System.Drawing.Size(101, 20)
        Me.beginDate.TabIndex = 1
        '
        'endDate
        '
        Me.endDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.endDate.Location = New System.Drawing.Point(85, 133)
        Me.endDate.Margin = New System.Windows.Forms.Padding(2)
        Me.endDate.Name = "endDate"
        Me.endDate.Size = New System.Drawing.Size(101, 20)
        Me.endDate.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 100)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Begin date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 136)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "End date:"
        '
        'backBtn
        '
        Me.backBtn.Location = New System.Drawing.Point(490, 290)
        Me.backBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(58, 32)
        Me.backBtn.TabIndex = 8
        Me.backBtn.Text = "Back"
        Me.backBtn.UseVisualStyleBackColor = True
        '
        'dateBtn
        '
        Me.dateBtn.Location = New System.Drawing.Point(71, 170)
        Me.dateBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.dateBtn.Name = "dateBtn"
        Me.dateBtn.Size = New System.Drawing.Size(58, 32)
        Me.dateBtn.TabIndex = 9
        Me.dateBtn.Text = "Search"
        Me.dateBtn.UseVisualStyleBackColor = True
        '
        'titleForm
        '
        Me.titleForm.AutoSize = True
        Me.titleForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleForm.Location = New System.Drawing.Point(13, 12)
        Me.titleForm.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.titleForm.Name = "titleForm"
        Me.titleForm.Size = New System.Drawing.Size(0, 26)
        Me.titleForm.TabIndex = 10
        '
        'orderedListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 333)
        Me.ControlBox = False
        Me.Controls.Add(Me.titleForm)
        Me.Controls.Add(Me.dateBtn)
        Me.Controls.Add(Me.backBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.endDate)
        Me.Controls.Add(Me.beginDate)
        Me.Controls.Add(Me.lstBox)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "orderedListForm"
        Me.Text = "Ordered list"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstBox As ListBox
    Friend WithEvents beginDate As DateTimePicker
    Friend WithEvents endDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents backBtn As Button
    Friend WithEvents dateBtn As Button
    Friend WithEvents titleForm As Label
End Class
