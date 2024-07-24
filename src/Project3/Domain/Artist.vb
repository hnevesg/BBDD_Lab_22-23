Public Class Artist

    Public Property idArtist As Integer
    Public Property artistName As String
    Public Property artistCountry As Country
    Public Property albums As List(Of Album)
    Public Property concerts As List(Of Concert)

    Public ReadOnly Property ArtistDAO As ArtistDAO

    Public Sub New()
        Me.ArtistDAO = New ArtistDAO
    End Sub

    Public Sub New(id As Integer)
        Me.ArtistDAO = New ArtistDAO
        Me.idArtist = id
        Me.artistCountry = New Country
        Me.albums = New List(Of Album)
        Me.concerts = New List(Of Concert)
    End Sub

    Public Sub addConcerts()
        Me.ArtistDAO.addconcerts(Me)
    End Sub

    Public Sub addAlbums()
        Me.ArtistDAO.addAlbums(Me)
    End Sub

    Public Sub ReadAllArtists()
        Me.ArtistDAO.ReadAll()
    End Sub

    Public Sub ReadArtist()
        Me.ArtistDAO.Read(Me)
    End Sub

    Public Function InsertArtist() As Integer
        Return Me.ArtistDAO.Insert(Me)
    End Function

    Public Function DeleteArtist() As Integer
        Return Me.ArtistDAO.Delete(Me)
    End Function

    Public Function UpdateArtist() As Integer
        Return Me.ArtistDAO.Update(Me)
    End Function

    Public Overrides Function ToString() As String
        Return Me.artistName
    End Function

End Class
