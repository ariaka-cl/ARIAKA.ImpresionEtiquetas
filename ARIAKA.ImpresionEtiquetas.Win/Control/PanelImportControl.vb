Imports System.Windows.Forms
Imports DevExpress.XtraSplashScreen

Public Class PanelImportControl

    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click

        Dim report As New LabelXtraReport
        Dim ctrller As New Controller.GenerarDatosEtiquetas
        Dim inbredList As List(Of Model.InbredCodes) = TryCast(My.Forms.MainForm.MazorcaGridControl1.GridView1.DataSource, List(Of Model.InbredCodes))
        Dim radioGroup As RadioButton = GroupBox_etiquetas.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)
        Dim etiqueta As String = radioGroup.Text

        SaveFileDialog_resporte.Filter = "Pdf Files|*.pdf"
        SaveFileDialog_resporte.ShowDialog()
        Dim filePathToSave As String = SaveFileDialog_resporte.FileName
        If String.IsNullOrWhiteSpace(filePathToSave) Then
            MessageBox.Show("Etiquetas Generadas", "Generar Etiquetas", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Return
        End If
        Select Case etiqueta
            Case "Bulk"
                report.EtiquetasDataSource.DataSource = ctrller.ReporteBulk(inbredList)
            Case "Laboratorio"
                report.EtiquetasDataSource.DataSource = ctrller.PopulateReporteLabD1Remanente(inbredList, "LAB")
            Case "Remanente"
                report.EtiquetasDataSource.DataSource = ctrller.PopulateReporteLabD1Remanente(inbredList, etiqueta)
            Case "D1"
                report.EtiquetasDataSource.DataSource = ctrller.PopulateReporteLabD1Remanente(inbredList, etiqueta)
            Case "Grupo"
                report.EtiquetasDataSource.DataSource = ctrller.PopulateReporte(inbredList)
        End Select
        WaitPanel(True, "Generando etiquetas")
        report.ExportToPdf(filePathToSave)
        WaitPanel(False)
        MessageBox.Show("Etiquetas Generadas", "Generar Etiquetas", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub WaitPanel(start As Boolean, Optional mensaje As String = Nothing)
        If start Then
            SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption(mensaje)
            Return
        End If
        If Not start Then
            SplashScreenManager.CloseForm()
            Return
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        OpenFileDialog_inputs.Title = "Selección Archivo Entrada"
        OpenFileDialog_inputs.Filter = "Excel Worksheets|*.xls;*.xlsm;*.xlsx"
        OpenFileDialog_inputs.ShowDialog()
        LabelControl_fileName.Text = OpenFileDialog_inputs.FileName
        FillGrid(LabelControl_fileName.Text)
    End Sub

    Public Sub FillGrid(fileName As String)
        WaitPanel(True, "Importando Información")
        Dim bd As New Model.InbredContext
        My.Forms.MainForm.MazorcaGridControl1.InbredCodesDTOBindingSource.DataSource = bd.SelectExcel(fileName, bd.GetSheetNames(fileName))
        My.Forms.MainForm.MazorcaGridControl1.GridControl1.DataSource = My.Forms.MainForm.MazorcaGridControl1.InbredCodesDTOBindingSource.DataSource
        My.Forms.MainForm.MazorcaGridControl1.Refresh()
        WaitPanel(False)
    End Sub

End Class
