Public Class SongDAO
    Public ReadOnly Property Songs As Collection

    Public Sub New()
        Me.Songs = New Collection
    End Sub

    Public Sub ReadAll()

        Dim s As Song
        Dim col, aux As Collection

        col = DBBroker.GetBroker().Read("SELECT * FROM songs ORDER BY idSong")

        For Each aux In col
            s = New Song(Convert.ToInt32(aux(1)))
            s.songName = aux(2).ToString
            s.songLength = Convert.ToInt32(aux(3).ToString)
            s.album.idAlbum = Convert.ToInt32(aux(4).ToString)
            s.album.ReadAlbum()
            s.songOrder = Convert.ToInt32(aux(5).ToString)

            's.album.addSongs()

            Me.Songs.Add(s)
        Next

    End Sub

    Public Sub Read(ByRef s As Song)

        Dim col As Collection : Dim aux As Collection

        col = DBBroker.GetBroker.Read("SELECT * FROM songs WHERE idSong='" & s.idSong & "';")

        For Each aux In col
            s.songName = aux(2).ToString
            s.songLength = Convert.ToInt32(aux(3).ToString)

            s.album = New Album
            s.album.idAlbum = Convert.ToInt32(aux(4).ToString)
            s.album.ReadAlbum()
            s.album.addSongs()

            s.songOrder = Convert.ToInt32(aux(5).ToString)
        Next

    End Sub

    Public Function Insert(ByVal s As Song) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO songs (SongName, SongLength, Album, SongOrder) VALUES ('" & s.songName & "', '" & s.songLength & "','" & s.album.idAlbum & " ',' " & s.songOrder & "');")
    End Function

    Public Function Delete(ByVal s As Song) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM songs WHERE idSong='" & s.idSong & "';")
    End Function

    Public Function Update(ByVal s As Song) As Integer
        Return DBBroker.GetBroker.Change("UPDATE songs SET SongName='" & s.songName & "', SongLength='" & s.songLength & "', Album='" & s.album.idAlbum & "', SongOrder=' " & s.songOrder & "' WHERE idSong='" & s.idSong & "';")
    End Function

End Class
