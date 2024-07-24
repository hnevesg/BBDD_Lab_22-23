Public Class Song

    Public Property idSong As Integer
    Public Property songName As String
    Public Property songLength As Integer
    Public Property album As Album
    Public Property songOrder As Integer

    Public ReadOnly Property SongDAO As SongDAO

    Public Sub New()
        Me.SongDAO = New SongDAO
    End Sub

    Public Sub New(id As Integer)
        Me.SongDAO = New SongDAO
        Me.idSong = id
        Me.album = New Album
    End Sub

    Public Sub ReadAllSongs()
        Me.SongDAO.ReadAll()
    End Sub

    Public Sub ReadSong()
        Me.SongDAO.Read(Me)
    End Sub

    Public Function InsertSong() As Integer
        Return Me.SongDAO.Insert(Me)
    End Function

    Public Function DeleteSong() As Integer
        Return Me.SongDAO.Delete(Me)
    End Function

    Public Function UpdateSong() As Integer
        Return Me.SongDAO.Update(Me)
    End Function

    Public Overrides Function ToString() As String
        Return Me.songName & ", duration: " & Me.songLength & " minutes, album: " & Me.album.albumName
    End Function

End Class
