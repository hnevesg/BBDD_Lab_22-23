Public Class reportsForm

    Private repType As ReportType
    Private art As Artist
    Private orderedArtist As orderedListForm

    Enum ReportType As Integer
        mostPlayedSong
        mostPlayedAlbum
        mostConcert         ' ordered List of artists who have performed the most concerts between 2 specific dates
        mostCountry         ' ordered list of countries in which there have been more concerts between 2 specific dates
    End Enum

    Private Sub listartistBtn_Click(sender As Object, e As EventArgs) Handles listartistBtn.Click
        ' List of artists who have ever performed a complete album in a concert
        lstBox.Items.Clear()
        PictureBox1.Visible = False
        ComboBox1.Enabled = False

        Dim artistname As String
        Dim albumname As String

        Dim col, aux As Collection
        col = DBBroker.GetBroker().Read("SELECT DISTINCT a.artistname, al.albumname from artists a, albums al, setlists stl, concerts c, songs s 
                     where a.idArtist = al.Artist and al.idAlbum = s.Album and s.idSong = stl.Song and c.idconcert=stl.concert
                    group by c.idconcert, a.idArtist, al.idAlbum HAVING COUNT(*) = COUNT(DISTINCT stl.Song) 
                    and COUNT(*) = (SELECT COUNT(*) FROM songs where Album = al.idAlbum)
                    order by a.artistname;")

        For Each aux In col
            artistname = aux(1).ToString
            albumname = aux(2).ToString
            lstBox.Items.Add(artistname & ", album: " & albumname)
        Next
    End Sub

    Private Sub mostplayedalbumBtn_Click(sender As Object, e As EventArgs) Handles mostplayedalbumBtn.Click
        ' Most played albums by an artist
        lstBox.Items.Clear()
        ComboBox1.Items.Clear()
        PictureBox1.Visible = False

        repType = ReportType.mostPlayedAlbum

        'layout 
        ComboBox1.Enabled = True

        Try
            art = New Artist
            Me.art.ReadAllArtists()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        For Each lsArt In Me.art.ArtistDAO.Artists
            ComboBox1.Items.Add(lsArt)
        Next

        PictureBox1.Visible = True

    End Sub

    Private Sub mostplayedsongBtn_Click(sender As Object, e As EventArgs) Handles mostplayedsongBtn.Click
        ' Most played songs in all concerts
        lstBox.Items.Clear()
        ComboBox1.Items.Clear()

        repType = ReportType.mostPlayedSong

        'layout 
        ComboBox1.Enabled = True

        Dim lsArt As Artist
        art = New Artist

        Try
            Me.art.ReadAllArtists()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        For Each lsArt In Me.art.ArtistDAO.Artists
            ComboBox1.Items.Add(lsArt)
        Next

        PictureBox1.Visible = True
    End Sub

    Private Sub songplayedseverBtn_Click(sender As Object, e As EventArgs) Handles songplayedseverBtn.Click
        ' Songs played several times
        lstBox.Items.Clear()
        PictureBox1.Visible = False
        'layout 
        ComboBox1.Enabled = False

        Dim col, aux As Collection
        col = DBBroker.GetBroker().Read("Select s.songname, COUNT(*) from songs s, setlists sl, concerts c 
                                        where s.idSong = sl.Song and sl.Concert = c.idConcert
                                        GROUP BY s.idSong
                                        ORDER BY COUNT(*) DESC, s.songname;")

        Dim songname As String
        Dim performances As Integer

        For Each aux In col
            songname = aux(1).ToString
            performances = Convert.ToInt32(aux(2).ToString)
            lstBox.Items.Add(songname & ", times performed: " & performances)
        Next
    End Sub

    Private Sub mostconcertBtn_Click(sender As Object, e As EventArgs) Handles mostconcertBtn.Click
        ' Ordered List of artists who have performed the most concerts between 2 specific dates
        PictureBox1.Visible = False
        orderedArtist = New orderedListForm(Convert.ToInt32(ReportType.mostConcert))
        Me.Hide()
        lstBox.Items.Clear()
        PictureBox1.Visible = False
        orderedArtist.Show()
    End Sub

    Private Sub mostcountriesBtn_Click(sender As Object, e As EventArgs) Handles mostcountriesBtn.Click
        ' Ordered list of countries in which there have been more concerts between 2 specific dates

        'layout 
        orderedArtist = New orderedListForm(Convert.ToInt32(ReportType.mostCountry))
        Me.Hide()
        lstBox.Items.Clear()
        orderedArtist.Show()
        PictureBox1.Visible = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case repType
            Case ReportType.mostPlayedAlbum
                ComboBoxMostPlayedAlbum()
            Case ReportType.mostPlayedSong
                ComboBoxMostPlayedSong()
            Case Else
                MessageBox.Show("Type not valid")
        End Select
    End Sub

    Private Sub ComboBoxMostPlayedAlbum()
        lstBox.Items.Clear()
        PictureBox1.Visible = False
        Dim col, aux As Collection
        If ComboBox1.SelectedItem IsNot Nothing Then
            art = DirectCast(ComboBox1.SelectedItem, Artist)

            col = DBBroker.GetBroker().Read("SELECT alb.albumName, COUNT(distinct c.idconcert) from concerts c, setlists setl, songs s, albums alb, artists art
                                             where c.idConcert = setl.Concert and setl.Song = s.idSong and s.Album = alb.idAlbum 
                                             and alb.Artist = art.idArtist and art.idartist = '" & art.idArtist & "'
                                             GROUP BY alb.idalbum
                                             ORDER BY COUNT(distinct c.idconcert) DESC;")

            Dim albumname As String
            Dim performances As Integer
            For Each aux In col
                albumname = aux(1).ToString
                performances = Convert.ToInt32(aux(2).ToString)
                lstBox.Items.Add(albumname & ", performed: " & performances)
            Next
        End If
    End Sub
    Private Sub ComboBoxMostPlayedSong()
        lstBox.Items.Clear()
        Dim col, aux As Collection
        PictureBox1.Visible = False
        If ComboBox1.SelectedItem IsNot Nothing Then
            art = DirectCast(ComboBox1.SelectedItem, Artist)

            col = DBBroker.GetBroker().Read("SELECT s.songName, COUNT(*) from concerts c, setlists setl, songs s
                                             where c.idConcert = setl.Concert and setl.Song = s.idSong and c.Artist = '" & art.idArtist & "'
                                             GROUP BY s.songName
                                             ORDER BY COUNT(*) DESC;")

            Dim songname As String
            Dim performances As Integer
            For Each aux In col
                songname = aux(1).ToString
                performances = Convert.ToInt32(aux(2).ToString)
                lstBox.Items.Add(songname & ", performed: " & performances)
            Next
        End If
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        navigationForm.Show()
        Me.Close()
        PictureBox1.Visible = False
    End Sub

End Class
