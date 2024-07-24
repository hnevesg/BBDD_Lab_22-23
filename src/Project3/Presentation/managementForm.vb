Public Class manageForm
    ' when we insert or delete a new object in the db we have to update the collection
    Private insType As InsertType
        Private delType As InsertType
        Private updType As InsertType

        Private art As Artist
        Private albm As Album
        Private sng As Song
        Private vnue As Venue
        Private cntr As Country

        Enum InsertType As Integer
            Artist
            Album
            Song
            Venue
            Country
        End Enum

        ' artist management button
        Private Sub BtnArtist_Click(sender As Object, e As EventArgs) Handles BtnArtist.Click
            objList.Items.Clear()

            nameTxt.Clear()

            hiddenLabel.Text = "Artist management"
            insType = InsertType.Artist
            delType = InsertType.Artist
            updType = InsertType.Artist

            Dim lsArt As Artist : Dim lsCount As Country

            Try
                art = New Artist
                art.ReadAllArtists()

                cntr = New Country
                cntr.ReadAllCountries()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

            For Each lsArt In art.ArtistDAO.Artists
                objList.Items.Add(lsArt)
            Next

            typesCurtain.Items.Clear()
            For Each lsCount In cntr.CountryDAO.Countries
                typesCurtain.Items.Add(lsCount)
            Next

            ' layout
            nameLabel.Visible = True : secondLabel.Visible = False
            typeLabel.Visible = True : ComboBox1.Visible = False
            year_length.Visible = False : order.Visible = False : NumericUpDown1.Visible = False : NumericUpDown2.Visible = False

            typesCurtain.Visible = True
            nameTxt.Visible = True : secondTxt.Visible = False

            BtnUpdate.Enabled = True
            BtnInsert.Enabled = True
            BtnDelete.Enabled = True
            BtnClear.Enabled = True

            nameLabel.Text = "Artist Name"
            typeLabel.Text = "Artist Country"
        End Sub

        ' album management button
        Private Sub BtnAlbum_Click(sender As Object, e As EventArgs) Handles BtnAlbum.Click
            objList.Items.Clear()
            typesCurtain.Items.Clear()

            nameTxt.Clear()

            hiddenLabel.Text = "Album management"
            insType = InsertType.Album
            delType = InsertType.Album
            updType = InsertType.Album

            ' when album button is clicked, list shows album in the db
            Dim lsAlb As Album
            Dim lsArt As Artist

            Me.typesCurtain.DisplayMember = "Key"
            Me.typesCurtain.ValueMember = "Value"

            Try
                art = New Artist
                art.ReadAllArtists()

                albm = New Album
                'albm.artist = New Artist
                albm.ReadAllAlbums()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

            ' album in the listbox
            For Each lsAlb In albm.AlbumDAO.Albums
                objList.Items.Add(lsAlb)
            Next

            typesCurtain.Items.Clear()
            For Each lsArt In art.ArtistDAO.Artists
                typesCurtain.Items.Add(lsArt)
            Next

            ' layout
            nameLabel.Visible = True : secondLabel.Visible = False
            typeLabel.Visible = True : ComboBox1.Visible = False
            year_length.Visible = True : order.Visible = False : NumericUpDown1.Visible = True : NumericUpDown2.Visible = False

            typesCurtain.Visible = True
            secondTxt.Visible = True : nameTxt.Visible = True

            BtnUpdate.Enabled = True
            BtnInsert.Enabled = True
            BtnDelete.Enabled = True
            BtnClear.Enabled = True

            typeLabel.Text = "Artist"
            nameLabel.Text = "Album Name"
            year_length.Text = "Album Year"
        End Sub

        ' song management button
        Private Sub BtnSong_Click(sender As Object, e As EventArgs) Handles BtnSong.Click
            objList.Items.Clear()
            typesCurtain.Items.Clear()


            nameTxt.Clear()

            hiddenLabel.Text = "Song management"
            insType = InsertType.Song
            delType = InsertType.Song
            updType = InsertType.Song

            ' when song button is clicked, list show songs in the db
            Dim lsSng As Song
            Dim lsAlbum As Album

            Try
                albm = New Album()
                albm.ReadAllAlbums()

                sng = New Song
                sng.album = New Album
                sng.ReadAllSongs()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

            ' add song in the listbox
            For Each lsSng In sng.SongDAO.Songs
                objList.Items.Add(lsSng)
            Next

            ' add album in the combobox
            typesCurtain.Items.Clear()
            For Each lsAlbum In albm.AlbumDAO.Albums
                typesCurtain.Items.Add(lsAlbum)
            Next

            'layout
            nameLabel.Visible = True : secondLabel.Visible = False
            typeLabel.Visible = True : year_length.Visible = True
            ComboBox1.Visible = False : order.Visible = True

            typesCurtain.Visible = True : NumericUpDown1.Visible = True
            nameTxt.Visible = True : secondTxt.Visible = True : NumericUpDown2.Visible = True

            BtnUpdate.Enabled = True
            BtnInsert.Enabled = True
            BtnDelete.Enabled = True
            BtnClear.Enabled = True

            nameLabel.Text = "Song Name"
            typeLabel.Text = "Album"
            year_length.Text = "Song Length"
            order.Text = "Song Order"
        End Sub

        'venue management button
        Private Sub BtnVenue_Click(sender As Object, e As EventArgs) Handles BtnVenue.Click
            objList.Items.Clear()
            typesCurtain.Items.Clear()


            nameTxt.Clear()

            hiddenLabel.Text = "Venues management"
            insType = InsertType.Venue
            delType = InsertType.Venue
            updType = InsertType.Venue

            ' when venues botton is clicked, show venues in the db
            Dim lsVnue As Venue
            Dim lsCountry As Country

            Try
                cntr = New Country
                cntr.ReadAllCountries()

                vnue = New Venue
                vnue.ReadAllVenues()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

            ComboBox1.DataSource = [Enum].GetValues(GetType(Venue.Venue_type))


            ' add venue in listbox
            For Each lsVnue In vnue.VenueDAO.Venues
                objList.Items.Add(lsVnue)
            Next

            ' show us countries in the combobox
            typesCurtain.Items.Clear()
            For Each lsCountry In cntr.CountryDAO.Countries
                typesCurtain.Items.Add(lsCountry)
            Next

            ' layout
            nameLabel.Visible = True : secondLabel.Visible = True : typeLabel.Visible = True
            ComboBox1.Visible = True
            year_length.Visible = False : order.Visible = False : NumericUpDown1.Visible = False : NumericUpDown2.Visible = False
            nameTxt.Visible = True : typesCurtain.Visible = True : secondTxt.Visible = False

            BtnUpdate.Enabled = True
            BtnInsert.Enabled = True
            BtnDelete.Enabled = True
            BtnClear.Enabled = True

            typeLabel.Text = "Venue Country"
            nameLabel.Text = "Venue Name"
            secondLabel.Text = "Venue Type"
        End Sub

        ' country management button
        Private Sub BtnCountry_Click(sender As Object, e As EventArgs) Handles BtnCountry.Click
            objList.Items.Clear()

            nameTxt.Clear()

            hiddenLabel.Text = "Countries management"
            insType = InsertType.Country
            delType = InsertType.Country
            updType = InsertType.Country

            ' when country button is clicked, show countries in the db
            Dim lsCntr As Country

            Try
                cntr = New Country
                cntr.ReadAllCountries()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

            For Each lsCntr In Me.cntr.CountryDAO.Countries
                objList.Items.Add(lsCntr)
            Next

            'layout
            typesCurtain.Visible = False
            nameLabel.Visible = True : secondLabel.Visible = False
            typeLabel.Visible = False : ComboBox1.Visible = False
            year_length.Visible = False : order.Visible = False : NumericUpDown1.Visible = False : NumericUpDown2.Visible = False
            nameTxt.Visible = True : secondTxt.Visible = False

            BtnUpdate.Enabled = True
            BtnInsert.Enabled = True
            BtnDelete.Enabled = True
            BtnClear.Enabled = True

            nameLabel.Text = "Country name"
        End Sub

        ' selected item - LIST BOX
        Private Sub lstBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles objList.SelectedIndexChanged
            Select Case insType
                Case InsertType.Artist
                    SelectedArtistItem()
                Case InsertType.Album
                    SelectedAlbumItem()
                Case InsertType.Song
                    SelectedSongItem()
                Case InsertType.Venue
                    SelectedVenueItem()
                Case InsertType.Country
                    SelectedCountryItem()
                Case Else
                    MessageBox.Show("Type not valid")
            End Select
        End Sub

        Private Sub SelectedArtistItem()
            Dim selItm As Artist
            selItm = DirectCast(objList.SelectedItem, Artist)

            nameTxt.Text = selItm.artistName

            For Each item As Country In typesCurtain.Items
                If item.idCountry = selItm.artistCountry.idCountry Then
                    typesCurtain.SelectedItem = item
                    Exit For
                End If
            Next
        End Sub

        Private Sub SelectedAlbumItem()
            Dim selItm As Album
            selItm = DirectCast(objList.SelectedItem, Album)

            nameTxt.Text = selItm.albumName
            NumericUpDown1.Value = selItm.albumYear
            For Each item As Artist In typesCurtain.Items
                If item.idArtist = selItm.artist.idArtist Then
                    typesCurtain.SelectedItem = item
                    Exit For
                End If
            Next
        End Sub

        Private Sub SelectedSongItem()
            Dim selItm As Song
            selItm = DirectCast(objList.SelectedItem, Song)

            nameTxt.Text = selItm.songName
            NumericUpDown1.Value = selItm.songLength
            NumericUpDown2.Value = selItm.songOrder
            For Each item As Album In typesCurtain.Items
                If item.idAlbum = selItm.album.idAlbum Then
                    typesCurtain.SelectedItem = item
                    Exit For
                End If
            Next
        End Sub

        Private Sub SelectedVenueItem()
            Dim selItm As Venue
            selItm = DirectCast(objList.SelectedItem, Venue)

            nameTxt.Text = selItm.venueName
            ComboBox1.SelectedItem = selItm.venueType
            For Each item As Country In typesCurtain.Items
                If item.idCountry = selItm.venueCountry.idCountry Then
                    typesCurtain.SelectedItem = item
                    Exit For
                End If
            Next
        End Sub
        Private Sub SelectedCountryItem()
            Dim selItm As Country
            selItm = DirectCast(objList.SelectedItem, Country)

            nameTxt.Text = selItm.countryName
        End Sub

        ' based on the value of insType, the insert button refers to the various tables
        Private Sub BtnInsert_Click(sender As Object, e As EventArgs) Handles BtnInsert.Click
            Select Case insType
                Case InsertType.Artist
                    InsertArtist()
                Case InsertType.Album
                    InsertAlbum()
                Case InsertType.Song
                    InsertSong()
                Case InsertType.Venue
                    InsertVenue()
                Case InsertType.Country
                    InsertCountry()
                Case Else
                    MessageBox.Show("Type not valid")
            End Select
        End Sub

        Private Sub InsertArtist()
            Dim flag As Boolean = False

            If typesCurtain.SelectedItem IsNot Nothing And nameTxt.Text <> "" Then
                art.artistName = nameTxt.Text
                art.artistCountry = DirectCast(typesCurtain.SelectedItem, Country)

                For Each temp As Artist In art.ArtistDAO.Artists
                    If (temp.artistName.ToLower = art.artistName.ToLower And temp.artistCountry.idCountry = art.artistCountry.idCountry) Then
                        flag = True
                        Exit For
                    ElseIf temp.artistName.ToLower = art.artistName Then
                        MessageBox.Show("Artist name already present", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Next

                If flag Then
                    MessageBox.Show("Artist already present", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else
                    Try
                        art.InsertArtist()
                        MessageBox.Show("Artist entered correctly", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch e As Exception
                        MessageBox.Show(e.Message, e.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End Try
                End If
            Else
                MessageBox.Show("The fields cannot be empty", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End Sub

        Private Sub InsertAlbum()
            If typesCurtain.SelectedItem IsNot Nothing And nameTxt.Text <> "" Then
                Dim selectedItem As Artist = DirectCast(typesCurtain.SelectedItem, Artist)
                Dim flag As Boolean = False

                albm.albumName = nameTxt.Text
                albm.albumYear = CInt(NumericUpDown1.Value)
                albm.artist = selectedItem

                For Each temp As Album In albm.AlbumDAO.Albums
                    If (temp.albumName.toLower = albm.albumName.toLower And temp.albumYear = albm.albumYear And temp.artist.idArtist = albm.artist.idArtist) Then
                        flag = True
                        Exit For
                    ElseIf temp.albumName.toLower = albm.albumName.toLower Then
                        MessageBox.Show("Album name already present", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Next

                If flag Then
                    MessageBox.Show("Album already present", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else
                    Try
                        albm.InsertAlbum()
                        MessageBox.Show("Album entered correctly", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch e As Exception
                        MessageBox.Show(e.Message, e.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End Try
                End If
            Else
                MessageBox.Show("The fields cannot be empty", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End Sub
        Private Sub InsertSong()
            Dim flag As Boolean
            If typesCurtain.SelectedItem IsNot Nothing And nameTxt.Text <> "" Then
                Dim selItm As Album = DirectCast(typesCurtain.SelectedItem, Album)

                sng.songName = nameTxt.Text
                sng.songLength = CInt(NumericUpDown1.Value)
                sng.album = selItm
                sng.songOrder = CInt(NumericUpDown2.Value)

                For Each temp As Song In sng.SongDAO.Songs
                    If (temp.songName.toLower = sng.songName.toLower And temp.songLength = sng.songLength And temp.album.idAlbum = sng.album.idAlbum) Then
                        flag = True
                        Exit For
                    ElseIf temp.songName.toLower = sng.songName.toLower Then
                        MessageBox.Show("Song name already present", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Next

                If flag Then
                    MessageBox.Show("Song already present", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else
                    Try
                        sng.InsertSong()
                        MessageBox.Show("Song entered correctly", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch e As Exception
                        MessageBox.Show(e.Message, e.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End Try
                End If
            Else
                MessageBox.Show("The fields cannot be empty", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End Sub
        Private Sub InsertVenue()
            Dim flag As Boolean
            If typesCurtain.SelectedItem IsNot Nothing And nameTxt.Text <> "" Then
                Dim selItm As Country = DirectCast(typesCurtain.SelectedItem, Country)

                vnue.venueName = nameTxt.Text
                vnue.venueCountry = selItm
                vnue.venueType = DirectCast(ComboBox1.SelectedItem, Venue.Venue_type)

                For Each temp As Venue In vnue.VenueDAO.Venues
                    If (temp.venueName.ToLower = vnue.venueName.ToLower And temp.venueType = vnue.venueType And temp.venueCountry.idCountry = vnue.venueCountry.idCountry) Then
                        flag = True
                        Exit For
                    ElseIf temp.venueName.ToLower = vnue.venueName.ToLower Then
                        MessageBox.Show("Venue name already present", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Next

                If flag Then
                    MessageBox.Show("Venue already present", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else
                    Try
                        vnue.InsertVenue()
                        MessageBox.Show("Venue entered correctly", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch e As Exception
                        MessageBox.Show(e.Message, e.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End Try
                End If
            Else
                MessageBox.Show("The fields cannot be empty", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End Sub
        Private Sub InsertCountry()
            Dim flag As Boolean = False
            If nameTxt.Text.Length >= 3 Then
                cntr.countryName = nameTxt.Text
                cntr.idCountry = cntr.countryName.Substring(0, 3).ToUpper

                For Each temp As Country In cntr.CountryDAO.Countries
                    If (temp.countryName.ToLower = cntr.countryName.ToLower) Then
                        flag = True
                        Exit For
                    End If
                Next

                If flag Then
                    MessageBox.Show("Country already present", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else
                    Try
                        cntr.InsertCountry()
                        MessageBox.Show("Country entered correctly", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch e As Exception
                        MessageBox.Show(e.Message, e.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End Try
                End If
            Else
                MessageBox.Show("The fields cannot be empty", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End Sub

        ' delete button
        Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
            Select Case insType
                Case InsertType.Artist
                    DeleteArtist()
                Case InsertType.Album
                    DeleteAlbum()
                Case InsertType.Song
                    DeleteSong()
                Case InsertType.Venue
                    DeleteVenue()
                Case InsertType.Country
                    DeleteCountry()
                Case Else
                    MessageBox.Show("Type not valid")
            End Select
        End Sub

        Private Sub DeleteArtist()
            ' to delete an artist, select first in the listbox
            If (objList.SelectedItem IsNot Nothing) Then
                art = DirectCast(objList.SelectedItem, Artist)
            Else
                MessageBox.Show("Select one artist from the list", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If art.albums.Count > 0 Or art.concerts.Count > 0 Then
                MessageBox.Show("First, all albums, songs and concerts of this artist must be deleted", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Try
                art.DeleteArtist()
                MessageBox.Show("Artist deleted correctly", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch e As Exception
                MessageBox.Show(e.Message, e.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End Sub

        Private Sub DeleteAlbum()

            If (objList.SelectedItem IsNot Nothing) Then
                albm = DirectCast(objList.SelectedItem, Album)
            Else
                MessageBox.Show("Select one album from the list", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If albm.songs.Count > 0 Then
                MessageBox.Show("First, all songs of the album must be deleted", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Try
                albm.DeleteAlbum()
                MessageBox.Show("Album deleted correctly", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch e As Exception
                MessageBox.Show(e.Message, e.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End Sub
        Private Sub DeleteSong()
            If (objList.SelectedItem IsNot Nothing) Then
                sng = DirectCast(objList.SelectedItem, Song)
            Else
                MessageBox.Show("Select one song from the list", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

        Try
            sng.DeleteSong()
            MessageBox.Show("Song deleted correctly", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As MySql.Data.MySqlClient.MySqlException
            If ex.Number = 1451 Then
                MessageBox.Show("First, the song must be deleted from all setlists", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch e As Exception
            MessageBox.Show(e.Message, e.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            End Try
        End Sub
        Private Sub DeleteVenue()
            If (objList.SelectedItem IsNot Nothing) Then
                vnue = DirectCast(objList.SelectedItem, Venue)
            Else
                MessageBox.Show("Select one venue from the list", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If vnue.concerts.Count > 0 Then
            MessageBox.Show("First, all concerts of this venue must be deleted", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            End If

            Try
                vnue.DeleteVenue()
                MessageBox.Show("Venue deleted correctly", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch e As Exception
                MessageBox.Show(e.Message, e.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End Sub

        Private Sub DeleteCountry()
            If (objList.SelectedItem IsNot Nothing) Then
                cntr = DirectCast(objList.SelectedItem, Country)
            Else
                MessageBox.Show("Select one country from the list", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

        Try
            cntr.DeleteCountry()
            MessageBox.Show("Country deleted correctly", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As MySql.Data.MySqlClient.MySqlException
            If ex.Number = 1451 Then
                MessageBox.Show("First, the artists and venues from this country must be deleted", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch e As Exception
            MessageBox.Show(e.Message, e.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End Sub

        ' update button
        Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
            Select Case insType
                Case InsertType.Artist
                    UpdateArtist()
                Case InsertType.Album
                    UpdateAlbum()
                Case InsertType.Song
                    UpdateSong()
                Case InsertType.Venue
                    UpdateVenue()
                Case InsertType.Country
                    UpdateCountry()
                Case Else
                    MessageBox.Show("Type not valid")
            End Select
        End Sub
        Private Sub UpdateArtist()
            If (objList.SelectedItem IsNot Nothing) Then
                art = DirectCast(objList.SelectedItem, Artist)
            Else
                MessageBox.Show("Select one artist from the list", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            art.artistName = nameTxt.Text
            art.artistCountry = DirectCast(typesCurtain.SelectedItem, Country)

            Try
                art.UpdateArtist()
                MessageBox.Show("Artist updated correctly", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch e As Exception
                MessageBox.Show(e.Message, e.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End Sub

        Private Sub UpdateAlbum()
            If (objList.SelectedItem IsNot Nothing) Then
                albm = DirectCast(objList.SelectedItem, Album)
            Else
                MessageBox.Show("Select one album from the list", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            albm.albumName = nameTxt.Text
            albm.albumYear = CInt(NumericUpDown1.Value)
            albm.artist = DirectCast(typesCurtain.SelectedItem, Artist)

            Try
                albm.UpdateAlbum()
                MessageBox.Show("Album updated correctly", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch e As Exception
                MessageBox.Show(e.Message, e.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End Sub
        Private Sub UpdateSong()
            If (objList.SelectedItem IsNot Nothing) Then
                sng = DirectCast(objList.SelectedItem, Song)
            Else
                MessageBox.Show("Select one song from the list", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            sng.songName = nameTxt.Text
            sng.songLength = CInt(NumericUpDown1.Value)
            sng.album = DirectCast(typesCurtain.SelectedItem, Album)
            sng.songOrder = CInt(NumericUpDown2.Value)
            Try
                sng.UpdateSong()
                MessageBox.Show("Song updated correctly", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch e As Exception
                MessageBox.Show(e.Message, e.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End Sub
        Private Sub UpdateVenue()
            If (objList.SelectedItem IsNot Nothing) Then
                vnue = DirectCast(objList.SelectedItem, Venue)
            Else
                MessageBox.Show("Select one venue from the list", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            vnue.venueName = nameTxt.Text
            vnue.venueCountry = DirectCast(typesCurtain.SelectedItem, Country)
            vnue.venueType = DirectCast(ComboBox1.SelectedItem, Venue.Venue_type)

            Try
                vnue.UpdateVenue()
                MessageBox.Show("Venue updated correctly", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch e As Exception
                MessageBox.Show(e.Message, e.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End Sub
        Private Sub UpdateCountry()
            If (objList.SelectedItem IsNot Nothing) Then
                cntr = DirectCast(objList.SelectedItem, Country)
            Else
                MessageBox.Show("Select one country from the list", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            cntr.countryName = nameTxt.Text

            Try
                cntr.UpdateCountry()
                MessageBox.Show("Country updated correctly", "SETLISTS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch e As Exception
                MessageBox.Show(e.Message, e.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End Sub

        ' clear button
        Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
            nameTxt.Clear()
            secondTxt.Clear()
            ComboBox1.DataSource = Nothing
            ComboBox1.Items.Clear()
            typesCurtain.Items.Clear()
            objList.Items.Clear()
        End Sub

        ' back button
        Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
            mainForm.Show()
            Me.Close()
        End Sub

        Private Sub manageForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            BtnUpdate.Enabled = False
            BtnInsert.Enabled = False
            BtnDelete.Enabled = False
            BtnClear.Enabled = False
        End Sub
    End Class
