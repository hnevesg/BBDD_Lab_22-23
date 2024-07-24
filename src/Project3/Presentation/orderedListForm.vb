Public Class orderedListForm
    Private beginFlag As Boolean
    Private endFlag As Boolean
    Private t As Integer

    Public Sub New(typeForm As Integer)
        InitializeComponent()
        t = typeForm

        Select Case t
            Case 2          ' most concert
                titleForm.Text() = "Ordered list of Artists who have performed" & vbCrLf & "the most concerts between 2 specific dates"
            Case 3          ' most country
                titleForm.Text() = "Ordered list of Countries in which there have been" & vbCrLf & "more concerts between 2 specific dates"
            Case Else
                MessageBox.Show("Type not valid")
        End Select
    End Sub

    Private Sub dateBtn_Click(sender As Object, e As EventArgs) Handles dateBtn.Click
        lstBox.Items.Clear()

        Select Case t
            Case 2          ' most concert
                dateClickMostConcert()
            Case 3          ' most country
                dateClickMostCountry()
            Case Else
                MessageBox.Show("Type not valid")
        End Select
    End Sub

    Private Sub dateClickMostConcert()
        Dim begin, final As Date
        Dim artistname As String
        Dim performances As Integer

        begin = beginDate.Value
        final = endDate.Value

        If begin > final Then
            MessageBox.Show("The begin date must be prior to the end date", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim col, aux As Collection
        col = DBBroker.GetBroker().Read("SELECT a.artistname, COUNT(*) FROM concerts c, artists a
                                            where c.Artist = a.idArtist and c.ConcertDate BETWEEN '" & begin.ToString("yyyy-MM-dd") & "' AND '" & final.ToString("yyyy-MM-dd") & "'
                                            GROUP BY a.idartist
                                            ORDER BY COUNT(*) DESC, a.artistname;")
        If col.Count = 0 Then
            MessageBox.Show("No concerts between these dates", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            For Each aux In col
                artistname = aux(1).ToString
                performances = Convert.ToInt32(aux(2).ToString)
                lstBox.Items.Add(artistname & ", concerts performed: " & performances)
            Next
        End If

    End Sub

    Private Sub dateClickMostCountry()
        ' country con piu concerti tra due date
        Dim countryname As String
        Dim performances As Integer
        Dim begin, final As Date

        begin = beginDate.Value
        final = endDate.Value

        If begin > final Then
            MessageBox.Show("The begin date must be prior to the end date", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim col, aux As Collection
        col = DBBroker.GetBroker().Read("SELECT ctr.countryname, COUNT(*) FROM concerts c, country ctr, venues v
                                                 where c.venue = v.idvenue and v.venuecountry = ctr.idcountry and c.ConcertDate BETWEEN '" & begin.ToString("yyyy-MM-dd") & "' AND '" & final.ToString("yyyy-MM-dd") & "'
                                                 GROUP BY ctr.idcountry
                                                 ORDER BY COUNT(*) DESC;")

        If col.Count = 0 Then
            MessageBox.Show("No concerts between these dates", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            For Each aux In col
                countryname = aux(1).ToString
                performances = Convert.ToInt32(aux(2).ToString)
                lstBox.Items.Add(countryname & ", concerts performed: " & performances)
            Next
        End If
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        reportsForm.Show()
        Me.Close()
    End Sub
End Class

