﻿
Public Class MazorcaGridControl
    Sub New()

        InitializeComponent()
        ' This line of code is generated by Data Source Configuration Wizard
        ' Fill a ExcelDataSource
        FillGrid()
    End Sub

    Public Sub FillGrid()
        Dim bd As New ARIAKA.ImpresionEtiquetas.Model.InbredContext
        InbredCodesDTOBindingSource.DataSource = bd.SelectExcel(bd.GetSheetNames().Item(0))
        GridControl1.DataSource = InbredCodesDTOBindingSource.DataSource
    End Sub
End Class