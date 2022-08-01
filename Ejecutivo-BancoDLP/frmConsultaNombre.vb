Imports System.Data
Imports System.Data.OleDb
Public Class frmConsultaNombre

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtNombre.Text = "" Then
            MsgBox("Escribe el nombre o nombres del empleado")
            txtNombre.Focus()
            Exit Sub
        End If

        If txtApellidoP.Text = "" Then
            MsgBox("Escribe el apellido paterno del empleado")
            txtApellidoP.Focus()
            Exit Sub
        End If

        If txtApellidoM.Text = "" Then
            MsgBox("Escribe el apellido materno del empleado")
            txtApellidoP.Focus()
            Exit Sub
        End If

        Try
            Dim conexion As New OleDbConnection
            conexion.ConnectionString = ("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=" & Ruta)

            Dim sentSQL As String
            sentSQL = "SELECT * FROM CLIENTES WHERE NOMBRE='" & txtNombre.Text & "' AND ApellidoPaterno='" & txtApellidoP.Text & "' AND ApellidoMaterno='" & txtApellidoM.Text & "'"

            Dim ObjDataSet As New DataSet
            Dim objAdap As New OleDbDataAdapter(sentSQL, conexion)

            conexion.Open()
            objAdap.Fill(ObjDataSet)

            gridLsta.DataSource = ObjDataSet.Tables(0)

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