Public Class Country

    Public Property idCountry As String
    Public Property countryName As String

    Public ReadOnly Property CountryDAO As CountryDAO

    Public Sub New()
        Me.CountryDAO = New CountryDAO
    End Sub

    Public Sub New(id As String)
        Me.CountryDAO = New CountryDAO
        Me.idCountry = id
    End Sub

    Public Sub ReadCountry()
        Me.CountryDAO.Read(Me)
    End Sub

    Public Function InsertCountry() As Integer
        Return Me.CountryDAO.Insert(Me)
    End Function

    Public Function DeleteCountry() As Integer
        Return Me.CountryDAO.Delete(Me)
    End Function

    Public Sub ReadAllCountries()
        Me.CountryDAO.ReadAll()
    End Sub

    Public Function UpdateCountry() As Integer
        Return Me.CountryDAO.Update(Me)
    End Function

    Public Overrides Function tostring() As String
        Return Me.countryName
    End Function

End Class
