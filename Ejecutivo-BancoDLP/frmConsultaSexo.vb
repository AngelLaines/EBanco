Imports System.Data
Imports System.Data.OleDb
Public Class frmConsultaSexo

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If cboSexo.SelectedIndex = -1 Then
            MsgBox("Selecciona el sexo del empleado")
            Exit Sub
        End If

        Try
            Dim sentSQL As String
            sentSQL = "SELECT * FROM CLIENTES WHERE SEXO='" & (cboSexo.SelectedItem).ToString & "'"

            Dim conexion As New OleDbConnection
            conexion.ConnectionString = ("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=" & Ruta)

            Dim ObjDataSet As New DataSet
            Dim objAdap As New OleDbDataAdapter(sentSQL, conexion)

            conexion.Open()
            objAdap.Fill(ObjDataSet)

            gridLista.DataSource = ObjDataSet.Tables(0)

            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            Exit Sub
        End Try
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        frmMenu.Show()
        Me.Close()
    End Sub
End Class