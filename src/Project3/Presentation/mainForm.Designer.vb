<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.manageBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.concertBtn = New System.Windows.Forms.Button()
        Me.navigationButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(61, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SETLISTS"
        '
        'manageBtn
        '
        Me.manageBtn.Location = New System.Drawing.Point(30, 185)
        Me.manageBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.manageBtn.Name = "manageBtn"
        Me.manageBtn.Size = New System.Drawing.Size(111, 36)
        Me.manageBtn.TabIndex = 1
        Me.manageBtn.Text = "Manage setlists database"
        Me.manageBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 55)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(221, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Welcome to setlists, what do you want to do?"
        '
        'concertBtn
        '
        Me.concertBtn.Location = New System.Drawing.Point(30, 134)
        Me.concertBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.concertBtn.Name = "concertBtn"
        Me.concertBtn.Size = New System.Drawing.Size(111, 36)
        Me.concertBtn.TabIndex = 3
        Me.concertBtn.Text = "Manage concert and setlist"
        Me.concertBtn.UseVisualStyleBackColor = True
        '
        'navigationButton
        '
        Me.navigationButton.Location = New System.Drawing.Point(30, 81)
        Me.navigationButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.navigationButton.Name = "navigationButton"
        Me.navigationButton.Size = New System.Drawing.Size(111, 36)
        Me.navigationButton.TabIndex = 4
        Me.navigationButton.Text = "Navigation"
        Me.navigationButton.UseVisualStyleBackColor = True
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(474, 311)
        Me.Controls.Add(Me.navigationButton)
        Me.Controls.Add(Me.concertBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.manageBtn)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "mainForm"
        Me.Text = "Setlists"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents manageBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents concertBtn As Button
    Friend WithEvents navigationButton As Button
End Class
