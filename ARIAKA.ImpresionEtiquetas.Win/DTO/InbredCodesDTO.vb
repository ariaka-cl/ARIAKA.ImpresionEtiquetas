Namespace DTO
    Public Class InbredCodesDTO
        Public Property InbredCode As String
        Public Property Population As String
        Public Property SourceID As String
        Public Property BreedgingProgram As String
        Public Property Correlativo As String
        Public Property Grupo As GroupDTO
    End Class
    Public Class GroupDTO
        Public Property Zero As Integer
        Public Property GrupoD As Integer
        Public Property GrupoC As Integer
        Public Property GrupoB As Integer
        Public Property GrupoA As Integer
    End Class
    Public Class EtiquetaDTO
        Public Property Familia As InbredCodesDTO
        Public Property NumeroMazorca As Integer
        Public Property Correlativo As Integer
        Public Property Grupo As String
        Public Property QRCode As String
        Public Property Etiqueta As String

    End Class
End Namespace
