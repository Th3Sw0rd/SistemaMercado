Imports WindowsApplication1
Imports System.Data.OleDb

Public Class UcProvincias
    Implements IProvinvcias

    Dim Conexion As New OleDbConnection
    Dim Adapter As New OleDbDataAdapter, ComandoABM As New OleDbCommandBuilder
    Dim DataSet As New DataSet

    Dim StringConexion As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BDDGARCA.accdb;"

    Public Function ObtenerProvinciasPorCodigo(CprMer As Object) As Provincia Implements IProvinvcias.ObtenerProvinciasPorCodigo
        Try

            Dim provincia As New Provincia

            Conexion.ConnectionString = StringConexion
            Conexion.Open()


            Conexion.Close()

            Return provincia

        Catch ex As Exception

            Throw ex

        End Try
    End Function

    Public Function ObtenerListaProvincias() As List(Of Provincia) Implements IProvinvcias.ObtenerListaProvincias
        Try

            Dim Provincias As New List(Of Provincia)

            Conexion.ConnectionString = StringConexion
            Conexion.Open()

            Conexion.Close()

            Return Provincias

        Catch ex As Exception

            Throw ex

        End Try
    End Function
End Class
