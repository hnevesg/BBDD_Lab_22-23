Public Class navigationForm

    Private navType As NavigationType
    Private reports As reportsForm
    Private art As Artist
    Private conc As Concert
    Private vnue As Venue
    Private cn As Country

    Enum NavigationType As Integer
        byArtist
        byVenue
    End Enum

    Private Sub byArtistBtn_Click(sender As Object, e As EventArgs) Handles byArtistBtn.Click
        ComboBox1.Items.Clear()
        navigationBox.Items.Clear()
        setlistBox.Items.Clear()

        PictureBox1.Visible = True
        lblCntr.Visible = False
        ComboBox2.Visible = False

        navType = NavigationType.byArtist

        Try
            art = New Artist
            art.ReadAllArtists()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        For Each lsArt In art.ArtistDAO.Artists
            ComboBox1.Items.Add(lsArt)
        Next
    End Sub

    Private Sub byVenueBtn_Click(sender As Object, e As EventArgs) Handles byVenueBtn.Click
        ComboBox1.Items.Clear()
        navigationBox.Items.Clear()
        setlistBox.Items.Clear()

        PictureBox1.Visible = True
        lblCntr.Visible = False
        ComboBox2.Visible = False

        navType = NavigationType.byVenue

        Try
            vnue = New Venue
            vnue.ReadAllVenues()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        For Each lsVenue In vnue.VenueDAO.Venues
            ComboBox1.Items.Add(lsVenue)
        Next
    End Sub

    Private Sub ReportBtn_Click(sender As Object, e As EventArgs) Handles ReportBtn.Click
        reports = New reportsForm
        Me.Hide()
        reports.Show()
        PictureBox1.Visible = False
        lblCntr.Visible = False
        ComboBox2.Visible = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case navType
            Case NavigationType.byArtist
                ComboBoxByArtist()
            Case NavigationType.byVenue
                ComboBoxByVenue()
            Case Else
                MessageBox.Show("Type not valid")
        End Select
    End Sub

    Private Sub ComboBoxByArtist()
        Dim selItm = DirectCast(ComboBox1.SelectedItem, Artist)

        navigationBox.Items.Clear()
        setlistBox.Items.Clear()
        PictureBox1.Visible = False

        For Each lsConc In selItm.concerts
            navigationBox.Items.Add(lsConc)
        Next

        lblCntr.Visible = True
        ComboBox2.Visible = True

        Try
            cn = New Country
            cn.ReadAllCountries()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        ComboBox2.Items.Clear()

        For Each lsCn In cn.CountryDAO.Countries
            ComboBox2.Items.Add(lsCn)
        Next
    End Sub

    Private Sub ComboBoxByVenue()
        Dim selItm = DirectCast(ComboBox1.SelectedItem, Venue)

        navigationBox.Items.Clear()
        setlistBox.Items.Clear()
        PictureBox1.Visible = False
        lblCntr.Visible = False
        ComboBox2.Visible = False

        For Each lsConc In selItm.concerts
            navigationBox.Items.Add(lsConc)
        Next
    End Sub

    Private Sub navigationBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles navigationBox.SelectedIndexChanged
        Select Case navType
            Case NavigationType.byArtist
                NavigationBoxByArtist()
            Case NavigationType.byVenue
                NavigationBoxByVenue()
            Case Else
                MessageBox.Show("Type not valid")
        End Select
    End Sub

    Private Sub NavigationBoxByArtist()
        setlistBox.Items.Clear()
        Dim selItm = DirectCast(navigationBox.SelectedItem, Concert)
        PictureBox1.Visible = False
        lblCntr.Visible = True
        ComboBox2.Visible = True

        If selItm.setlist IsNot Nothing Then
            Dim lConc As New List(Of Song)
            lConc = selItm.setlist.OrderBy(Function(s) s.songOrder).ToList()

            For Each itemSetl In lConc
                setlistBox.Items.Add(itemSetl)
            Next
        End If
    End Sub

    Private Sub NavigationBoxByVenue()
        setlistBox.Items.Clear()
        Dim selItm = DirectCast(navigationBox.SelectedItem, Concert)
        PictureBox1.Visible = False
        lblCntr.Visible = False
        ComboBox2.Visible = False
        Try
            If selItm.setlist IsNot Nothing Then
                Dim lConc As New List(Of Song)
                lConc = selItm.setlist.OrderBy(Function(s) s.songOrder).ToList()

                For Each itemSetl In lConc
                    setlistBox.Items.Add(itemSetl)
                Next
            End If
        Catch ex As Exception
            'continue
        End Try
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        mainForm.Show()
        Me.Close()
        PictureBox1.Visible = False
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim selItm = DirectCast(ComboBox1.SelectedItem, Artist)
        Dim selCntr = DirectCast(ComboBox2.SelectedItem, Country)

        navigationBox.Items.Clear()
        setlistBox.Items.Clear()

        For Each lsConc As Concert In selItm.concerts
            If lsConc.venue.venueCountry.idCountry = selCntr.idCountry Then
                navigationBox.Items.Add(lsConc)
            End If
        Next
    End Sub
End Class
