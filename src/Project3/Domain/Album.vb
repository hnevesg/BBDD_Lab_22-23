Public Class Album

    Public Property idAlbum As Integer
    Public Property albumName As String
    Public Property albumYear As Integer
    Public Property artist As Artist
    Public Property songs As List(Of Song)

    Public ReadOnly Property AlbumDAO As AlbumDAO

    Public Sub New()
        Me.AlbumDAO = New AlbumDAO
    End Sub

    Public Sub New(id As Integer)
        Me.AlbumDAO = New AlbumDAO
        Me.idAlbum = id
        Me.artist = New Artist
        Me.songs = New List(Of Song)
    End Sub

    Public Sub ReadAllAlbums()
        Me.AlbumDAO.ReadAll()
    End Sub

    Public Sub addSongs()
        Me.AlbumDAO.addSongs(Me)
    End Sub

    Public Sub ReadAlbum()
        Me.AlbumDAO.Read(Me)
    End Sub

    Public Function InsertAlbum() As Integer
        Return Me.AlbumDAO.Insert(Me)
    End Function

    Public Function DeleteAlbum() As Integer
        Return Me.AlbumDAO.Delete(Me)
    End Function

    Public Function UpdateAlbum() As Integer
        Return Me.AlbumDAO.Update(Me)
    End Function

    Public Overrides Function ToString() As String
        Return Me.albumName & " (" & Me.albumYear & ")"
    End Function

End Class
