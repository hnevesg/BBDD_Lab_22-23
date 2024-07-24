Public Class ConcertDAO

    Public ReadOnly Property Concerts As Collection

    Public Sub New()
        Me.Concerts = New Collection
    End Sub

    Public Sub ReadAll()

        Dim c As Concert
        Dim col, aux As Collection

        col = DBBroker.GetBroker().Read("SELECT * FROM concerts ORDER BY idConcert")

        For Each aux In col
            c = New Concert(Convert.ToInt32(aux(1)))
            c.artist.idArtist = Convert.ToInt32(aux(2))
            c.artist.ReadArtist()

            c.venue.idVenue = Convert.ToInt32(aux(3))
            c.venue.ReadVenue()
            c.concertDate = Convert.ToDateTime(aux(4))

            c.artist.addConcerts()
            c.venue.addConcerts()

            c.addSongstoSetlist()

            Me.Concerts.Add(c)
        Next

    End Sub

    Public Sub addsongstosetlist(ByRef c As Concert)

        Dim col, aux As Collection
        Dim s As Song

        col = DBBroker.GetBroker().Read("SELECT s.*, a.*, art.*, setl.orderinsetlist FROM songs s, concerts c, setlists setl, artists art, albums a WHERE Concert='" & c.idConcert &
                                        "' and setl.song=s.idsong and setl.concert=c.idconcert and s.album=a.idalbum and c.artist=art.idartist;")

        For Each aux In col
            s = New Song(Convert.ToInt32(aux(1)))
            s.songName = aux(2).ToString
            s.songLength = Convert.ToInt32(aux(3).ToString)
            s.album.idAlbum = Convert.ToInt32(aux(4).ToString)
            s.songOrder = Convert.ToInt32(aux(13).ToString)

            s.album.albumName = aux(7).ToString
            s.album.albumYear = Convert.ToInt32(aux(8).ToString)

            s.album.artist = New Artist
            s.album.artist.idArtist = Convert.ToInt32(aux(9).ToString)
            s.album.artist.artistName = aux(11).ToString

            s.album.artist.artistCountry = New Country
            s.album.artist.artistCountry.idCountry = aux(12).ToString
            s.album.artist.artistCountry.ReadCountry()

            c.setlist.Add(s)
        Next

    End Sub

    Public Function addSetlist(ByVal c As Concert, ByVal s As Song) As Integer
        c.setlist.Add(s)
        Return DBBroker.GetBroker.Change("INSERT INTO setlists VALUES ('" & c.idConcert & "', '" & s.idSong & "', '" & s.songOrder & "');")
    End Function
    Public Function deleteSetlist(ByVal c As Concert, ByVal s As Song) As Integer
        c.setlist.Remove(s)
        Return DBBroker.GetBroker.Change("DELETE FROM setlists WHERE Concert='" & c.idConcert & "' AND Song='" & s.idSong & "';")
    End Function
    Public Function updateSetlist(ByVal c As Concert, ByVal s As Song) As Integer
        Return DBBroker.GetBroker.Change("UPDATE setlists SET OrderInSetlist='" & s.songOrder & "' WHERE Concert='" & c.idConcert & "' AND Song='" & s.idSong & "';")
    End Function

    Public Sub Read(ByRef c As Concert)

        Dim col As Collection : Dim aux As Collection

        col = DBBroker.GetBroker().Read("SELECT * FROM concerts WHERE idConcert='" & c.idConcert & "';")

        For Each aux In col
            c.artist = New Artist
            c.artist.idArtist = Convert.ToInt32(aux(2))
            c.artist.ReadArtist()

            c.venue = New Venue
            c.venue.idVenue = Convert.ToInt32(aux(3))
            c.venue.ReadVenue()
            c.concertDate = Convert.ToDateTime(aux(4))

            c.setlist = New List(Of Song)
            c.addSongstoSetlist()
        Next

    End Sub

    Public Function Insert(ByVal c As Concert) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO concerts (Artist, Venue, ConcertDate) VALUES ('" & c.artist.idArtist & "', '" & c.venue.idVenue & "','" & c.concertDate.ToString("yyyy-MM-dd") & "');")
    End Function

    Public Function Delete(ByVal c As Concert) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM concerts WHERE idConcert='" & c.idConcert & "';")
    End Function

    Public Function Update(ByVal c As Concert) As Integer
        Return DBBroker.GetBroker.Change("UPDATE concerts SET Artist='" & c.artist.idArtist & "', Venue='" & c.venue.idVenue & "', ConcertDate='" & c.concertDate.ToString("yyyy-MM-dd") & "' WHERE idConcert='" & c.idConcert & "';")
    End Function

End Class
