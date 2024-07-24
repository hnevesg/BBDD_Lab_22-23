Public Class concertForm
    Private c As Concert
    Private song As Song
    Private art As Artist
    Private ven As Venue
    Private alb As Album

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBoxConcerts.SelectedIndexChanged
        lstBoxSetlists.Items.Clear()
        CBSong.Items.Clear() : CBSong.Text = ""

        Dim itemAlb, itemSetl As Song
        Dim lsAlb As Album

        If lstBoxConcerts.SelectedItem IsNot Nothing Then
            Dim cAux As Concert = DirectCast(lstBoxConcerts.SelectedItem, Concert)

            CBArtist.ValueMember = "idArtist"
            CBArtist.DisplayMember = "artistName"
            CBArtist.SelectedValue = cAux.artist.idArtist

            CBVenue.ValueMember = "idVenue"
            CBVenue.DisplayMember = "venueName"
            CBVenue.SelectedValue = cAux.venue.idVenue

            CBDate.Text = cAux.concertDate.Date.ToString

            'to fill the combobox with all songs from the artist
            For Each lsAlb In cAux.artist.albums
                For Each itemAlb In lsAlb.songs
                    CBSong.Items.Add(itemAlb)
                Next
            Next

            If cAux.setlist IsNot Nothing Then
                Dim lConc As New List(Of Song)
                lConc = cAux.setlist.OrderBy(Function(s) s.songOrder).ToList()

                For Each itemSetl In lConc
                    lstBoxSetlists.Items.Add(itemSetl)
                Next
            End If
        End If

    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        mainForm.Show()
        Me.Close()
    End Sub

    Private Sub BtnInsert_Click(sender As Object, e As EventArgs) Handles BtnInsert.Click
        Dim sAux As Song : Dim lsArt As Artist : Dim lscon As Concert : Dim lsVen As Venue
        Dim flag = False
        If CBSong.Text = "" And CBArtist.Text <> "" And CBVenue.Text <> "" Then
            c = New Concert()

            lsArt = DirectCast(CBArtist.SelectedItem, Artist)
            c.artist = lsArt

            lsVen = DirectCast(CBVenue.SelectedItem, Venue)
            c.venue = lsVen

            c.concertDate = CBDate.Value.Date

            For Each temp As Concert In lstBoxConcerts.Items
                If (temp.concertDate = c.concertDate And temp.venue.idVenue = c.venue.idVenue And temp.artist.idArtist = c.artist.idArtist) Then
                    flag = True
                    Exit For
                End If
            Next

            If flag Then
                MessageBox.Show("Concert already present", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                Try
                    c.InsertConcert()
                    lscon = New Concert : lscon.ReadAllConcerts()
                    For Each conc As Concert In lscon.ConcertDAO.Concerts
                        If conc.artist.idArtist = c.artist.idArtist And conc.concertDate = c.concertDate And conc.venue.idVenue = c.venue.idVenue Then
                            c = conc
                        End If
                    Next
                    lstBoxConcerts.Items.Add(c)
                    MessageBox.Show("Concert entered correctly", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
                End Try
            End If

        ElseIf CBSong.Text <> "" Then
            lscon = DirectCast(lstBoxConcerts.SelectedItem, Concert)
            sAux = DirectCast(CBSong.SelectedItem, Song)
            sAux.songOrder = lstBoxSetlists.Items.Count + 1

            For Each lsSong As Song In lstBoxSetlists.Items
                If lsSong.idSong = sAux.idSong Then
                    flag = True
                    Exit For
                End If
            Next

            If flag Then
                MessageBox.Show("Song already present", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                Try
                    lscon.insertSetlist(sAux)
                    lstBoxSetlists.Items.Add(sAux)
                    MessageBox.Show("Song entered correctly in the setlist ", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
            End If
        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim lsCon As Concert

        If lstBoxSetlists.SelectedItem Is Nothing Then
            If lstBoxConcerts.SelectedItem Is Nothing Then
                MessageBox.Show("Please select an existing concert from the list", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            lsCon = DirectCast(lstBoxConcerts.SelectedItem, Concert)
            'update the values
            lsCon.venue = DirectCast(CBVenue.SelectedItem, Venue)
            lsCon.artist = DirectCast(CBArtist.SelectedItem, Artist)
            lsCon.concertDate = CBDate.Value.Date

            Try
                lsCon.UpdateConcert()
                MessageBox.Show("Concert updated correctly", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        lstBoxSetlists.Items.Clear()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        c = New Concert
        song = New Song
        Dim lssong As Song

        If lstBoxSetlists.SelectedItem Is Nothing Then

            If lstBoxConcerts.SelectedItem Is Nothing Then
                MessageBox.Show("Please select an existing concert from the list", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            c = DirectCast(lstBoxConcerts.SelectedItem, Concert)

            Try
                If c.setlist.Count > 0 Then
                    Dim result As DialogResult = MessageBox.Show("You will also delete its setlist. Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If result = DialogResult.Yes Then

                        For i As Integer = c.setlist.Count - 1 To 0
                            Dim sg As Song = c.setlist(i)
                            c.deleteSetlist(sg)
                        Next

                        c.DeleteConcert()
                        lstBoxConcerts.Items.Remove(c)
                        MessageBox.Show("Concert deleted correctly", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        Exit Sub
                    End If
                Else
                    c.DeleteConcert()
                    lstBoxConcerts.Items.Remove(c)
                    MessageBox.Show("Concert deleted correctly", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

        ElseIf CBSong.Text <> "" Then
            If lstBoxSetlists.SelectedItem Is Nothing Then
                MessageBox.Show("Please select an existing song from the list", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If lstBoxConcerts.SelectedItem Is Nothing Then
                MessageBox.Show("Please select an existing concert from the list", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            song = DirectCast(lstBoxSetlists.SelectedItem, Song)
            c = DirectCast(lstBoxConcerts.SelectedItem, Concert)

            Try
                c.setlist.Remove(song)
                c.deleteSetlist(song)
                lstBoxSetlists.Items.Remove(lstBoxSetlists.SelectedItem)
                MessageBox.Show("Song deleted correctly from the setlist", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            If song.songOrder < lstBoxSetlists.Items.Count Then 'if it is not the last one, update the rest of indexes
                For Each lssong In lstBoxSetlists.Items
                    If lssong.songOrder > song.songOrder Then
                        lssong.songOrder -= 1
                        c.updateSetlist(lssong)
                    End If
                Next
            End If

        End If
    End Sub

    Private Sub lstBoxSetlists_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBoxSetlists.SelectedIndexChanged
        DownArrow.Visible = True : UpArrow.Visible = True

        If lstBoxSetlists.SelectedItem IsNot Nothing Then
            Dim s As Song = DirectCast(lstBoxSetlists.SelectedItem, Song)
            For Each item As Song In CBSong.Items
                If item.idSong = s.idSong Then
                    CBSong.SelectedItem = item
                    Exit For
                End If
            Next
        End If

        DownArrow.Text = Char.ConvertFromUtf32(&H2193)
        UpArrow.Text = Char.ConvertFromUtf32(&H2191)
    End Sub

    Private Sub UpArrow_Click(sender As Object, e As EventArgs) Handles UpArrow.Click
        Dim lssong As Song
        Try
            If lstBoxSetlists.SelectedIndex > 0 Then
                Dim newIndex As Integer = lstBoxSetlists.SelectedIndex - 1
                Dim selectedSong As Song = DirectCast(lstBoxSetlists.SelectedItem, Song)
                lstBoxSetlists.Items.Insert(newIndex, selectedSong)
                lstBoxSetlists.Items.RemoveAt(lstBoxSetlists.SelectedIndex)
            End If
        Catch ex As Exception
            MessageBox.Show("Please select one item from the list", ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        Dim i = 1
        If lstBoxSetlists.Items.Count > 0 Then
            For Each lssong In lstBoxSetlists.Items
                lssong.songOrder = i
                c = DirectCast(lstBoxConcerts.SelectedItem, Concert)
                i += 1
                c.updateSetlist(lssong)
            Next
        End If

    End Sub

    Private Sub DownArrow_Click(sender As Object, e As EventArgs) Handles DownArrow.Click
        Dim lssong As Song

        Try
            If lstBoxSetlists.SelectedIndex < lstBoxSetlists.Items.Count - 1 Then
                Dim newIndex As Integer = lstBoxSetlists.SelectedIndex + 1
                Dim selectedSong As Song = DirectCast(lstBoxSetlists.SelectedItem, Song)
                lstBoxSetlists.Items.RemoveAt(lstBoxSetlists.SelectedIndex)
                lstBoxSetlists.Items.Insert(newIndex, selectedSong)
            End If
        Catch ex As Exception
            MessageBox.Show("Please select one item from the list", ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try


        Dim i = 1
        If lstBoxSetlists.Items.Count > 0 Then
            For Each lssong In lstBoxSetlists.Items
                lssong.songOrder = i
                c = DirectCast(lstBoxConcerts.SelectedItem, Concert)
                i += 1
                c.updateSetlist(lssong)
            Next
        End If
    End Sub

    Private Sub concertForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblArtist.Visible = True : lblVenue.Visible = True : lblDate.Visible = True : CBDate.Visible = True
        lblSong.Visible = True

        lstBoxConcerts.Items.Clear()

        Try
            c = New Concert
            ven = New Venue
            art = New Artist

            Me.c.ReadAllConcerts()
            Me.art.ReadAllArtists()
            Me.ven.ReadAllVenues()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        'add all concerts to the listbox
        For Each lsCon In c.ConcertDAO.Concerts
            lstBoxConcerts.Items.Add(lsCon)
        Next

        CBArtist.DataSource = art.ArtistDAO.Artists

        CBVenue.DataSource = ven.VenueDAO.Venues
    End Sub
End Class
