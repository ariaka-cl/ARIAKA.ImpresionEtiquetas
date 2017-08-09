Namespace Model
    Public Class InbredContext
        Public Function connection() As String
            Dim conexion As String = String.Format("Provider=Microsoft.ACE.OLEDB.12.0;" &
                              "Data Source={0}{1};Extended Properties='Excel 12.0;HDR=YES;IMEX=0'", My.Settings.path, My.Settings.fileName)
            Return conexion
        End Function

        Public Function SelectExcel(sheetName As String) As List(Of Model.InbredCodes)

            Dim MyConnection As OleDb.OleDbConnection = New OleDb.OleDbConnection(connection())
            MyConnection.Open()
            Dim MyCommand As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(String.Format("SELECT * FROM [{0}]", sheetName), MyConnection)
            MyCommand.TableMappings.Add("Table", "TestTable")
            Dim DtSet As New DataSet
            MyCommand.Fill(DtSet)
            Dim dt As DataTable = DtSet.Tables(0)
            Dim listInbredCodes As New List(Of Model.InbredCodes)

            For Each fila As DataRow In dt.Rows
                If Not IsDBNull(fila.Item(8)) Then
                    listInbredCodes.Add(New Model.InbredCodes With {.InbredCode = If(IsDBNull(fila.Item(7)), "", fila.Item(7)),
                                                                .Population = If(IsDBNull(fila.Item(8)), "", fila.Item(8)),
                                                                .SourceID = If(IsDBNull(fila.Item(9)), "", fila.Item(9).ToString),
                                                                .Grupo = New Group With {.Zero = 2,
                                                                                        .GrupoD = 3,
                                                                                        .GrupoB = 23,
                                                                                        .GrupoC = 12,
                                                                                        .GrupoA = 15}})

                End If
            Next
            listInbredCodes.RemoveAt(0)
            MyConnection.Close()
            Return listInbredCodes
        End Function

        Public Function GetSheetNames() As List(Of String)
            Dim MyConnection As OleDb.OleDbConnection = New OleDb.OleDbConnection(connection())
            MyConnection.Open()
            Try
                Dim dtSheets As DataTable = MyConnection.GetOleDbSchemaTable(OleDb.OleDbSchemaGuid.Tables, Nothing)
                Dim listSheet As New List(Of String)


                For Each drSheet As DataRow In dtSheets.Rows
                    If Not drSheet("TABLE_NAME").ToString().Contains("FilterDatabase") Then
                        listSheet.Add(drSheet("TABLE_NAME").ToString())
                    End If
                Next
                Return listSheet
            Finally
                MyConnection.Close()
            End Try
        End Function

    End Class
End Namespace
