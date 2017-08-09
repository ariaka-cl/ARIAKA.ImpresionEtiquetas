Namespace DTO
    Public Class InbredCodesDTO
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
End Namespace
