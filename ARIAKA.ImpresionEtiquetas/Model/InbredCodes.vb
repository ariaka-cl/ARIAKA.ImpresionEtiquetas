Namespace Model
    Public Class InbredCodes
        Public Property InbredCode As String
        Public Property Population As String
        Public Property SourceID As String
        Public Property Correlativo As String
        Public Property Grupo As Group
    End Class
    Public Class Group
        Public Property Zero As Integer
        Public Property GrupoD As Integer
        Public Property GrupoC As Integer
        Public Property GrupoB As Integer
        Public Property GrupoA As Integer
    End Class
    Public Class Etiqueta
        Public Property Familia As InbredCodes
        Public Property NumeroMazorca As Integer
        Public Property Correlativo As Integer
        Public Property Grupo As String
        Public Property QRCode As String
        Public Property Etiqueta As String

    End Class
End Namespace