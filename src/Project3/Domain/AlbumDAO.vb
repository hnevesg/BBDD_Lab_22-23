Public Class AlbumDAO

    Public ReadOnly Property Albums As Collection

    Public Sub New()
        Me.Albums = New Collection
    End Sub

    Public Sub ReadAll()

        Dim alb As Album
        Dim col, aux As Collection

        col = DBBroker.GetBroker().Read("SELECT * FROM albums ORDER BY idAlbum")

        For Each aux In col
            alb = New Album(Convert.ToInt32(aux(1)))
            alb.albumName = aux(2).ToString
            alb.albumYear = Convert.ToInt32(aux(3).ToString)
            alb.artist.idArtist = Convert.ToInt32(aux(4).ToString)
            alb.artist.ReadArtist()

            alb.artist.addAlbums()
            alb.addSongs()
            Me.Albums.Add(alb)
        Next

    End Sub

    Public Sub Read(ByRef a As Album)

        Dim col As Collection : Dim aux As Collection

        col = DBBroker.GetBroker.Read("SELECT * FROM albums WHERE idAlbum='" & a.idAlbum & "';")

        For Each aux In col
            a.albumName = aux(2).ToString
            a.albumYear = Convert.ToInt32(aux(3).ToString)

            a.artist = New Artist
            a.artist.idArtist = Convert.ToInt32(aux(4).ToString)
            a.artist.ReadArtist()
            a.artist.albums.Add(a)

            a.songs = New List(Of Song)
        Next

    End Sub

    Public Sub addSongs(ByRef a As Album)

        Dim col, aux As Collection
        Dim s As Song

        col = DBBroker.GetBroker().Read("SELECT * FROM songs WHERE Album='" & a.idAlbum & "';")

        For Each aux In col
            s = New Song(Convert.ToInt32(aux(1)))
            s.songName = aux(2).ToString
            s.songLength = Convert.ToInt32(aux(3).ToString)
            s.album = a
            s.songOrder = Convert.ToInt32(aux(5).ToString)

            s.album.songs.Add(s)
        Next

    End Sub

    Public Function Insert(ByVal a As Album) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO albums (AlbumName, YearAlbum, Artist) VALUES ('" & a.albumName & "', '" & a.albumYear & "','" & a.artist.idArtist & "');")
    End Function

    Public Function Delete(ByVal a As Album) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM albums WHERE idAlbum='" & a.idAlbum & "';")
    End Function

    Public Function Update(ByVal a As Album) As Integer
        Return DBBroker.GetBroker.Change("UPDATE albums SET AlbumName='" & a.albumName & "', YearAlbum='" & a.albumYear & "', Artist='" & a.artist.idArtist & "' WHERE idAlbum='" & a.idAlbum & "';")
    End Function

End Class
