Imports System.Data
Imports System.Data.OleDb
Public Class frmMenu

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Try
            Dim conexion As New OleDbConnection
            conexion.ConnectionString = ("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=" & Ruta)

            Dim sentsqlinsert As String
            sentsqlinsert = "UPDATE ACCESOS SET HORASALIDA='" & Format(Now, "hh:mm") & "' WHERE NOACCESO=" & NumAcceso


            Dim comando As New OleDbCommand(sentsqlinsert, conexion)

            conexion.Open()
            comando.ExecuteNonQuery()
            conexion.Close()

            End

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub


    Private Sub RegistroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroToolStripMenuItem.Click
        frmRegistroCliente.Show()
        Me.Close()
    End Sub

    Private Sub ActualizacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizacionToolStripMenuItem.Click
        frmActualizar.Show()
        Me.Close()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        frmCancelacion.Show()
        Me.Close()
    End Sub

    Private Sub NombreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NombreToolStripMenuItem.Click
        frmConsultaNombre.Show()
        Me.Close()
    End Sub

    Private Sub SexoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SexoToolStripMenuItem.Click
        frmConsultaSexo.Show()
        Me.Close()
    End Sub

    Private Sub EdadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EdadToolStripMenuItem.Click
        frmConsultaEdad.Show()
        Me.Close()
    End Sub

    Private Sub CiudadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CiudadToolStripMenuItem.Click
        frmConsultaCiudad.Show()
        Me.Close()
    End Sub

    Private Sub EstadoDeCuentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadoDeCuentaToolStripMenuItem.Click
        frmEstadoDeCuenta.Show()
        Me.Close()
    End Sub

    Private Sub ReposicionDeTarjetaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReposicionDeTarjetaToolStripMenuItem.Click
        frmreposiciondetarjetas.Show()
        Me.Close()
    End Sub

    Private Sub CancelacionDeTarjetaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelacionDeTarjetaToolStripMenuItem.Click
        frmCancelacionDeTarjetas.Show()
        Me.Close()

    End Sub

    Private Sub AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AToolStripMenuItem.Click

    End Sub
End Class
