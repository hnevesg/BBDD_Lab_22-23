Public Class Concert

    Public Property idConcert As Integer
    Public Property artist As Artist
    Public Property venue As Venue
    Public Property concertDate As Date
    Public Property setlist As List(Of Song)

    Public ReadOnly Property ConcertDAO As ConcertDAO

    Public Sub New()
        Me.ConcertDAO = New ConcertDAO
    End Sub

    Public Sub New(id As Integer)
        Me.ConcertDAO = New ConcertDAO
        Me.idConcert = id
        Me.artist = New Artist
        Me.venue = New Venue
        Me.setlist = New List(Of Song)
    End Sub

    Public Function deleteSetlist(s As Song) As Integer
        Return Me.ConcertDAO.deleteSetlist(Me, s)
    End Function

    Public Function updateSetlist(s As Song) As Integer
        Return Me.ConcertDAO.updateSetlist(Me, s)
    End Function

    Public Function insertSetlist(s As Song) As Integer
        Return Me.ConcertDAO.addSetlist(Me, s)
    End Function

    Public Sub ReadAllConcerts()
        Me.ConcertDAO.ReadAll()
    End Sub

    Public Sub addSongstoSetlist()
        Me.ConcertDAO.addsongstosetlist(Me)
    End Sub

    Public Sub ReadConcert()
        Me.ConcertDAO.Read(Me)
    End Sub

    Public Function InsertConcert() As Integer
        Return Me.ConcertDAO.Insert(Me)
    End Function

    Public Function DeleteConcert() As Integer
        Return Me.ConcertDAO.Delete(Me)
    End Function

    Public Function UpdateConcert() As Integer
        Return Me.ConcertDAO.Update(Me)
    End Function

    Public Overrides Function ToString() As String
        Return "Artist: " & Me.artist.artistName & ", venue: " & Me.venue.venueName & ", date: " & Me.concertDate.Date
    End Function

End Class
