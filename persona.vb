Public Class persona
    Private _nombre As String
    Private _fechaNacimiento As DateTime?
    Private _correo As String
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Public Property Correo As String
        Get
            Return _correo
        End Get
        Set(value As String)
            _correo = value
        End Set
    End Property

    Public Property FechaNacimiento As DateTime?
        Get
            Return _fechaNacimiento
        End Get
        Set(value As DateTime?)
            _fechaNacimiento = value
        End Set
    End Property
    Public Property edad As Integer
        Get
            Return edad
        End Get
        Set(value As Integer)
            edad = (DateTime.Now.Year - FechaNacimiento.Value.Year)
        End Set
    End Property
    Public Sub New()
        _nombre = String.Empty
    End Sub
    Public Sub New(ByVal _nombre As String)
        Me._nombre = _nombre
    End Sub
    Public Overrides Function ToString() As String
        Return Nombre.ToUpper()
    End Function
End Class
