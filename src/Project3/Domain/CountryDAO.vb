Public Class CountryDAO    
    Public ReadOnly Property Countries As Collection    
    
    Public Sub New()       
        Me.Countries = New Collection   
    End Sub    
    
    Public Sub ReadAll()        
        Dim c As Country     
        
        Dim col, aux As Collection 
        
        col = DBBroker.GetBroker().Read("SELECT * FROM country ORDER BY idCountry")      
        For Each aux In col         
            c = New Country(aux(1).ToString)      
            c.countryName = aux(2).ToString           
            Me.Countries.Add(c)
            Next
    End Sub    
    
    Public Sub Read(ByRef c As Country)       
        Dim col As Collection : Dim aux As Collection     
        col = DBBroker.GetBroker.Read("SELECT * FROM country WHERE idCountry='" & c.idCountry & "';")    
        For Each aux In col
            c.countryName = aux(2).ToString
            Next
    End Sub  
    
    Public Function Insert(ByVal c As Country) As Integer        
        Return DBBroker.GetBroker.Change("INSERT INTO country (idCountry, CountryName) VALUES ('" & c.idCountry & "','" & c.countryName & "');")   
    End Function
    
    Public Function Delete(ByVal c As Country) As Integer      
        Return DBBroker.GetBroker.Change("DELETE FROM country WHERE idCountry='" & c.idCountry & "';")   
    End Function   

    Public Function Update(ByVal c As Country) As Integer   
        Return DBBroker.GetBroker.Change("UPDATE country SET CountryName='" & c.countryName & "' WHERE idCountry='" & c.idCountry & "';")  
    End Function
End Class