Public Class ArtistDAO

    Public ReadOnly Property Artists As Collection

    Public Sub New()
        Me.Artists = New Collection
    End Sub

    Public Sub ReadAll()

        Dim a As Artist
        Dim col, aux As Collection

        col = DBBroker.GetBroker().Read("SELECT * FROM artists ORDER BY idArtist")

        For Each aux In col
            a = New Artist(Convert.ToInt32(aux(1).ToString))
            a.artistName = aux(2).ToString
            a.artistCountry.idCountry = aux(3).ToString
            a.artistCountry.ReadCountry()

            a.addAlbums()
            a.addConcerts()

            Me.Artists.Add(a)
        Next

    End Sub

    Public Sub Read(ByRef a As Artist)

        Dim col As Collection : Dim aux As Collection

        col = DBBroker.GetBroker.Read("SELECT * FROM artists WHERE idArtist='" & a.idArtist & "';")

        For Each aux In col
            a.artistName = aux(2).ToString

            a.artistCountry = New Country
            a.artistCountry.idCountry = aux(3).ToString
            a.artistCountry.ReadCountry()

            a.albums = New List(Of Album)
            a.concerts = New List(Of Concert)
            a.addAlbums()
            a.addConcerts()
        Next

    End Sub

    Public Sub addAlbums(ByRef a As Artist)

        Dim col, aux As Collection
        Dim alb As Album

        col = DBBroker.GetBroker().Read("SELECT * FROM albums WHERE Artist='" & a.idArtist & "';")

        For Each aux In col
            alb = New Album(Convert.ToInt32(aux(1)))
            alb.albumName = aux(2).ToString
            alb.albumYear = Convert.ToInt32(aux(3).ToString)
            alb.artist = a

            alb.addSongs()

            a.albums.Add(alb)
        Next

    End Sub

    Public Sub addconcerts(ByRef a As Artist)

        Dim col, aux As Collection
        Dim conc As Concert

        col = DBBroker.GetBroker().Read("SELECT * FROM concerts WHERE Artist='" & a.idArtist & "';")

        For Each aux In col
            conc = New Concert(Convert.ToInt32(aux(1)))
            conc.artist = a
            conc.venue.idVenue = Convert.ToInt32(aux(3).ToString)
            conc.venue.ReadVenue()
            conc.concertDate = Convert.ToDateTime(aux(4).ToString)

            conc.addSongstoSetlist()
            a.concerts.Add(conc)
        Next

    End Sub

    Public Function Insert(ByVal a As Artist) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO artists (ArtistName, ArtistCountry) VALUES ('" & a.artistName & "', '" & a.artistCountry.idCountry & "');")
    End Function

    Public Function Delete(ByVal a As Artist) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM artists WHERE idArtist='" & a.idArtist & "';")
    End Function

    Public Function Update(ByVal a As Artist) As Integer
        Return DBBroker.GetBroker.Change("UPDATE artists SET ArtistName='" & a.artistName & "', ArtistCountry='" & a.artistCountry.idCountry & "' WHERE idArtist='" & a.idArtist & "';")
    End Function

End Class
