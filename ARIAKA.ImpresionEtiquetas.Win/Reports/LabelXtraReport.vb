Public Class LabelXtraReport
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        FillReport()
    End Sub
    Sub FillReport()
        Dim dto As New Model.Etiqueta With {.Familia = New Model.InbredCodes With {.SourceID = "ZV16KV872579",
            .InbredCode = "7HHSL4169/D065125//!",
            .Population = "!17HHSM0579",
            .Grupo = New Model.Group With {.GrupoA = 1}}}
        Me.BindingSource1.DataSource = dto
    End Sub

    Private Sub XrPanel1_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles XrPanel1.BeforePrint

    End Sub
End Class