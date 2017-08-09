Public Class ImportFromExcel

    Public Sub Coneccion()

        Dim MyConnection As System.Data.OleDb.OleDbConnection
        Dim DtSet As System.Data.DataSet
        Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
        MyConnection = New System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source='c:\vb.net-informations.xls';Extended Properties=Excel 8.0;")
        MyCommand = New System.Data.OleDb.OleDbDataAdapter("select * from [Sheet1$]", MyConnection)
        MyCommand.TableMappings.Add("Table", "Net-informations.com")
        DtSet = New System.Data.DataSet
        MyCommand.Fill(DtSet)
        'DataGridView1.DataSource = DtSet.Tables(0)
        MyConnection.Close()

    End Sub
End Class
