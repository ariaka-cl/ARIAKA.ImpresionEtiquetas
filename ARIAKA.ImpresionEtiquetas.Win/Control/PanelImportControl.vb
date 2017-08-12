Imports System.Windows.Forms
Imports DevExpress.XtraSplashScreen

Public Class PanelImportControl
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim report As New LabelXtraReport
        Dim ctrller As New Controller.GenerarDatosEtiquetas
        Dim inbredList As List(Of Model.InbredCodes) = TryCast(My.Forms.MainForm.MazorcaGridControl1.GridView1.DataSource, List(Of Model.InbredCodes))
        report.EtiquetasDataSource.DataSource = ctrller.PopulateReporte(inbredList)
        WaitPanel(True)
        report.ExportToPdf("c:reporte.pdf")
        WaitPanel(False)
        MessageBox.Show("Etiquetas Generadas", "Generar Etiquetas", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub WaitPanel(start As Boolean)
        If start Then
            SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Generando etiquetas...")
            Return
        End If
        If Not start Then
            SplashScreenManager.CloseForm()
            Return
        End If
    End Sub
End Class
