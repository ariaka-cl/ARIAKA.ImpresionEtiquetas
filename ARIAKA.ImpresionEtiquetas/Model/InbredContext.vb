Namespace Model
    Public Class InbredContext
        Public Function connection(pathFileName As String) As String
            Dim conexion As String = String.Format("Provider=Microsoft.ACE.OLEDB.12.0;" &
                              "Data Source={0};Extended Properties='Excel 12.0;HDR=YES;IMEX=0'", pathFileName)
            Return conexion
        End Function

        Public Function SelectExcel(pathFileName As String, sheetName As String) As List(Of Model.InbredCodes)

            Dim MyConnection As OleDb.OleDbConnection = New OleDb.OleDbConnection(connection(pathFileName))
            MyConnection.Open()
            Dim MyCommand As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(String.Format("SELECT * FROM [{0}]", sheetName), MyConnection)
            MyCommand.TableMappings.Add("Table", "TestTable")
            Dim DtSet As New DataSet
            MyCommand.Fill(DtSet)
            Dim dt As DataTable = DtSet.Tables(0)
            Dim listInbredCodes As New List(Of Model.InbredCodes)

            For Each fila As DataRow In dt.Rows
                If Not IsDBNull(fila.Item(0)) AndAlso Not fila.Item(0).ToString().Contains("Source") Then
                    listInbredCodes.Add(New Model.InbredCodes With {.InbredCode = If(IsDBNull(fila.Item(1)), "", fila.Item(1)),
                                                                .Population = If(IsDBNull(fila.Item(2)), "", fila.Item(2)),
                                                                .SourceID = If(IsDBNull(fila.Item(0)), "", fila.Item(0).ToString),
                                                                .Grupo = New Group With {.Zero = If(IsDBNull(fila.Item(4)), 0, fila.Item(4)),
                                                                                        .GrupoD = If(IsDBNull(fila.Item(5)), 0, fila.Item(5)),
                                                                                        .GrupoC = If(IsDBNull(fila.Item(6)), 0, fila.Item(6)),
                                                                                        .GrupoB = If(IsDBNull(fila.Item(7)), 0, fila.Item(7)),
                                                                                        .GrupoA = If(IsDBNull(fila.Item(8)), 0, fila.Item(8))}})

                End If
            Next
            MyConnection.Close()
            Return listInbredCodes
        End Function

        Public Function GetSheetNames(pathFileName As String) As String
            Dim MyConnection As OleDb.OleDbConnection = New OleDb.OleDbConnection(connection(pathFileName))
            MyConnection.Open()
            Try
                Dim dtSheets As DataTable = MyConnection.GetOleDbSchemaTable(OleDb.OleDbSchemaGuid.Tables, Nothing)
                Dim listSheet As New List(Of String)


                For Each drSheet As DataRow In dtSheets.Rows
                    If Not drSheet("TABLE_NAME").ToString().Contains("FilterDatabase") Then
                        listSheet.Add(drSheet("TABLE_NAME").ToString())
                    End If
                Next
                Dim hojaNombre As String = listSheet.Where(Function(n) n.Contains(My.Settings.hojaNombre)).FirstOrDefault()
                Return hojaNombre
            Finally
                MyConnection.Close()
            End Try
        End Function

    End Class
End Namespace
