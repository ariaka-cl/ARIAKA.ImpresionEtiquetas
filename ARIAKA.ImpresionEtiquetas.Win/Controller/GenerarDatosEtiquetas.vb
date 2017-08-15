Namespace Controller
    Public Class GenerarDatosEtiquetas

        Public Function PopulateReporte(inbredList As List(Of Model.InbredCodes)) As List(Of Model.Etiqueta)
            Dim listDtoEtiquetas As New List(Of Model.Etiqueta)
            Dim contador As Integer = 1

            For Each inbredCode As Model.InbredCodes In inbredList
                If inbredCode.Grupo.GrupoD <> 0 OrElse
                        inbredCode.Grupo.GrupoC <> 0 OrElse inbredCode.Grupo.GrupoB <> 0 OrElse
                        inbredCode.Grupo.GrupoA <> 0 Then

                    If inbredCode.Grupo.GrupoA <> 0 Then
                        Dim fin As Integer = inbredCode.Grupo.GrupoA
                        For i As Integer = 0 To fin - 1
                            Dim dto As New Model.Etiqueta With {.Familia = inbredCode,
                                                    .Correlativo = contador,
                                                    .Grupo = "A (+20 k)"}
                            dto.QRCode = GenerarQRCodeData(dto)
                            listDtoEtiquetas.Add(dto)
                            contador = contador + 1
                        Next
                    End If
                    If inbredCode.Grupo.GrupoB <> 0 Then
                        Dim fin As Integer = inbredCode.Grupo.GrupoB
                        For i As Integer = 0 To fin - 1
                            Dim dto As New Model.Etiqueta With {.Familia = inbredCode,
                                                    .Correlativo = contador,
                                                    .Grupo = "B (10-19 k)"}
                            dto.QRCode = GenerarQRCodeData(dto)
                            listDtoEtiquetas.Add(dto)
                            contador = contador + 1
                        Next
                    End If
                    If inbredCode.Grupo.GrupoC <> 0 Then
                        Dim fin As Integer = inbredCode.Grupo.GrupoC
                        For i As Integer = 0 To fin - 1
                            Dim dto As New Model.Etiqueta With {.Familia = inbredCode,
                                                    .Correlativo = contador,
                                                    .Grupo = "C (3-9 k)"}
                            dto.QRCode = GenerarQRCodeData(dto)
                            listDtoEtiquetas.Add(dto)
                            contador = contador + 1
                        Next
                    End If

                    'If inbredCode.Grupo.GrupoD <> 0 Then
                    '    Dim fin As Integer = inbredCode.Grupo.GrupoD
                    '    For i As Integer = 0 To fin - 1
                    '        Dim dto As New Model.Etiqueta With {.Familia = inbredCode,
                    '                                .Correlativo = contador,
                    '                                .Grupo = "D (1-2 k)"}

                    '        dto.QRCode = GenerarQRCodeData(dto)
                    '        listDtoEtiquetas.Add(dto)
                    '        contador = contador + 1
                    '    Next
                    'End If
                End If
                contador = 1
            Next
            Return listDtoEtiquetas
        End Function

        Private Function GenerarQRCodeData(etiq As Model.Etiqueta) As String
            Dim qrCode As String = String.Format("Source ID: {0}, Population: {1}, Inbred Code: {2}.{4}, Grupo: {3}, N: {4}", etiq.Familia.SourceID, etiq.Familia.Population, etiq.Familia.InbredCode, etiq.Grupo, etiq.Correlativo)
            Return qrCode
        End Function

    End Class
End Namespace
