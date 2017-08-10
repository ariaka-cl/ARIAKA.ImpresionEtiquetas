Public Class PanelImportControl
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim report As New LabelXtraReport
        Dim dto As New Model.Etiqueta With {.Familia = New Model.InbredCodes With {.SourceID = "ZV16KV872579",
            .InbredCode = "7HHSL416D065125//!",
            .Population = "!17HHSM0579",
            .Grupo = New Model.Group With {.GrupoA = 1}}}

        report.EtiquetasDataSource.DataSource = dto
        report.ExportToPdf("c:reporte.pdf")
    End Sub
End Class
