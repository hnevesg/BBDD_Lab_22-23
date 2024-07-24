Public Class Venue

    Public Property idVenue As Integer
    Public Property venueName As String
    Public Property venueCountry As Country
    Public Property venueType As Venue_type
    Public Property concerts As List(Of Concert)

    Public Enum Venue_type
        hall
        pavilion
        stadium
        festival
    End Enum

    Public ReadOnly Property VenueDAO As VenueDAO

    Public Sub New()
        Me.VenueDAO = New VenueDAO
    End Sub

    Public Sub New(id As Integer)
        Me.VenueDAO = New VenueDAO
        Me.idVenue = id
        Me.venueCountry = New Country
        Me.concerts = New List(Of Concert)
    End Sub

    Public Sub addConcerts()
        Me.VenueDAO.addConcerts(Me)
    End Sub

    Public Sub ReadAllVenues()
        Me.VenueDAO.ReadAll()
    End Sub

    Public Sub ReadVenue()
        Me.VenueDAO.Read(Me)
    End Sub

    Public Function InsertVenue() As Integer
        Return Me.VenueDAO.Insert(Me)
    End Function

    Public Function DeleteVenue() As Integer
        Return Me.VenueDAO.Delete(Me)
    End Function

    Public Function UpdateVenue() As Integer
        Return Me.VenueDAO.Update(Me)
    End Function

    Public Overrides Function ToString() As String
        Return Me.venueName
    End Function

End Class
