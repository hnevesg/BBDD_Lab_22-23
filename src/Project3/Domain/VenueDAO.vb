Public Class VenueDAO

    Public ReadOnly Property Venues As Collection

    Public Sub New()
        Me.Venues = New Collection
    End Sub

    Public Sub ReadAll()

        Dim v As Venue
        Dim instanceVenue As Venue.Venue_type
        Dim col, aux As Collection

        col = DBBroker.GetBroker().Read("SELECT * FROM venues ORDER BY idVenue")

        For Each aux In col
            v = New Venue(Convert.ToInt32(aux(1)))
            v.venueName = aux(2).ToString
            v.venueCountry.idCountry = aux(3).ToString
            v.venueCountry.ReadCountry()

            Dim venueType As Type = v.GetType()
            Dim enumValues As Array = [Enum].GetValues(venueType.GetNestedType("Venue_type"))
            For Each value In enumValues
                If value.ToString() = aux(4).ToString() Then
                    instanceVenue = CType(value, Venue.Venue_type)
                    v.venueType = instanceVenue
                    Exit For
                End If
            Next

            v.addConcerts()
            Me.Venues.Add(v)
        Next

    End Sub

    Public Sub Read(ByRef v As Venue)

        Dim instanceVenue As Venue.Venue_type
        Dim col As Collection : Dim aux As Collection

        col = DBBroker.GetBroker.Read("SELECT * FROM venues WHERE idVenue='" & v.idVenue & "';")

        For Each aux In col
            v.venueName = aux(2).ToString

            v.venueCountry = New Country
            v.venueCountry.idCountry = aux(3).ToString
            v.venueCountry.ReadCountry()

            Dim venueType As Type = v.GetType()
            Dim enumValues As Array = [Enum].GetValues(venueType.GetNestedType("Venue_type"))
            For Each value In enumValues
                If value.ToString() = aux(4).ToString() Then
                    instanceVenue = CType(value, Venue.Venue_type)
                    v.venueType = instanceVenue
                    Exit For
                End If
            Next

            v.concerts = New List(Of Concert)
            v.addConcerts()
        Next

    End Sub

    Public Sub addConcerts(ByRef v As Venue)

        Dim col, aux As Collection
        Dim conc As Concert

        col = DBBroker.GetBroker().Read("SELECT c.*, a.artistName, a.artistCountry FROM concerts c,artists a WHERE Venue='" & v.idVenue & "' and c.artist=a.idArtist;")

        For Each aux In col
            conc = New Concert(Convert.ToInt32(aux(1)))
            conc.artist.idArtist = Convert.ToInt32(aux(2).ToString)
            conc.artist.artistName = aux(5).ToString
            conc.artist.artistCountry = New Country
            conc.artist.artistCountry.idCountry = aux(6).ToString
            conc.artist.artistCountry.ReadCountry()
            conc.venue = v
            conc.concertDate = Convert.ToDateTime(aux(4).ToString)

            conc.addSongstoSetlist()
            v.concerts.Add(conc)
        Next

    End Sub

    Public Function Insert(ByVal v As Venue) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO venues (VenueName, VenueCountry, VenueType) VALUES ('" & v.venueName & "', '" & v.venueCountry.idCountry & "','" & v.venueType.ToString & "');")
    End Function

    Public Function Delete(ByVal v As Venue) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM venues WHERE idVenue='" & v.idVenue & "';")
    End Function

    Public Function Update(ByVal v As Venue) As Integer
        Return DBBroker.GetBroker.Change("UPDATE venues SET VenueName='" & v.venueName & "', VenueCountry='" & v.venueCountry.idCountry & "', VenueType='" & v.venueType.ToString & "' WHERE idVenue='" & v.idVenue & "';")
    End Function

End Class
