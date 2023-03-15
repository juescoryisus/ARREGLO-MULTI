Public Class contacto
    Inherits persona

    Private _telefono As String

    Public Property Telefono As String
        Get
            Return _telefono
        End Get
        Set(ByVal value As String)
            _telefono = value.Replace(" ", " ").Replace("-", " ")

        End Set
    End Property
    Public Sub New(ByVal nombre As String)
    End Sub

    Public Sub New()

    End Sub

    Public Overrides Function ToString() As String
        Return MyBase.ToString() & "  " & _telefono
    End Function
End Class
