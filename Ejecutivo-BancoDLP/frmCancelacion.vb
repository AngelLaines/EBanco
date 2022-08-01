Imports System.Data
Imports System.Data.OleDb
Public Class frmCancelacion
    Public IDBuscado As Integer
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtIdCliente.Text = "" Then
            MsgBox("Falta el id del cliente.")
            txtIdCliente.Focus()
            Exit Sub
        End If

        Try
            Dim conexion As New OleDbConnection
            conexion.ConnectionString = ("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=" & Ruta)

            Dim sentsql1 As String
            sentsql1 = "SELECT * FROM CLIENTES WHERE IDCLIENTE=" & txtIdCliente.Text

            Dim objadap As New OleDbDataAdapter(sentsql1, conexion)
            Dim miconsulta As New DataTable

            conexion.Open()
            objadap.Fill(miconsulta)

            If (miconsulta.Rows.Count) = 0 Then

                MsgBox("El cliente con el id ingresado no existe, Verifique.")
                txtIdCliente.Focus()

            Else
                btnGuardar.Enabled = True
                IDBuscado = txtIdCliente.Text

                txtIdCliente.DataBindings.Add("text", miconsulta, "idcliente")
                txtNombreDP.DataBindings.Add("text", miconsulta, "nombre")
                txtApellidoPaternoDP.DataBindings.Add("text", miconsulta, "Apellidopaterno")
                txtApellidoMaternoDP.DataBindings.Add("text", miconsulta, "Apellidomaterno")
                txtCURPDP.DataBindings.Add("text", miconsulta, "CURP")
                cbxSexoDP.DataBindings.Add("text", miconsulta, "Sexo")
                txtEdadDP.DataBindings.Add("text", miconsulta, "Edad")
                DTPFechaDeNacimientoDP.DataBindings.Add("text", miconsulta, "Fechanacimiento")
                cbxEstadocivilDP.DataBindings.Add("text", miconsulta, "Estadocivil")
                TxtTelefonodecasaDp.DataBindings.Add("text", miconsulta, "Telefono")
                txtCelularDP.DataBindings.Add("text", miconsulta, "Celular")
                txtCorreoelectronicoDP.DataBindings.Add("text", miconsulta, "Correoelectronico")
                txtCalleDP.DataBindings.Add("text", miconsulta, "Calle")
                txtNumerodecasaDP.DataBindings.Add("text", miconsulta, "Nocasa")
                txtColoniaDP.DataBindings.Add("text", miconsulta, "Colonia")
                txtCiudadDP.DataBindings.Add("text", miconsulta, "Ciudad")
                txtcodigopostalDP.DataBindings.Add("text", miconsulta, "Codigopostal")
                txtMunicipioDP.DataBindings.Add("text", miconsulta, "Municipio")
                txtEstadoDP.DataBindings.Add("text", miconsulta, "Estado")

                txtIdCliente.DataBindings.Clear()
                txtNombreDP.DataBindings.Clear()
                txtApellidoPaternoDP.DataBindings.Clear()
                txtApellidoMaternoDP.DataBindings.Clear()
                txtCURPDP.DataBindings.Clear()
                cbxSexoDP.DataBindings.Clear()
                txtEdadDP.DataBindings.Clear()
                DTPFechaDeNacimientoDP.DataBindings.Clear()
                cbxEstadocivilDP.DataBindings.Clear()
                TxtTelefonodecasaDp.DataBindings.Clear()
                txtCelularDP.DataBindings.Clear()
                txtCorreoelectronicoDP.DataBindings.Clear()
                txtCalleDP.DataBindings.Clear()
                txtNumerodecasaDP.DataBindings.Clear()
                txtColoniaDP.DataBindings.Clear()
                txtCiudadDP.DataBindings.Clear()
                txtcodigopostalDP.DataBindings.Clear()
                txtMunicipioDP.DataBindings.Clear()
                txtEstadoDP.DataBindings.Clear()


            End If

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            Exit Sub
        End Try

        Try
            Dim conexion As New OleDbConnection
            conexion.ConnectionString = ("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=" & Ruta)

            Dim sentsql1 As String
            sentsql1 = "SELECT * FROM Cuentas WHERE IDCLIENTE=" & txtIdCliente.Text & " AND ESTATUS='ACTIVO'"

            Dim objadap As New OleDbDataAdapter(sentsql1, conexion)
            Dim miconsulta As New DataTable

            conexion.Open()
            objadap.Fill(miconsulta)

            If (miconsulta.Rows.Count) = 0 Then

                MsgBox("El cliente con el id ingresado no existe, o la cuenta ya esta inactiva. Verifique.")
                txtIdCliente.Focus()

            Else
                btnGuardar.Enabled = True
                IDBuscado = txtIdCliente.Text

                TxtNumerodecuentaDC.DataBindings.Add("text", miconsulta, "Nocuenta")
                cboTipodecuentaDC.DataBindings.Add("text", miconsulta, "Tipo")
                TxtMontodeaperturaDC.DataBindings.Add("text", miconsulta, "Monto")
                TxtSaldoDC.DataBindings.Add("text", miconsulta, "Saldo")
                txtEstatus.DataBindings.Add("text", miconsulta, "Estatus")
                txtIdCliente2.DataBindings.Add("text", miconsulta, "idcliente")

                TxtNumerodecuentaDC.DataBindings.Clear()
                cboTipodecuentaDC.DataBindings.Clear()
                TxtMontodeaperturaDC.DataBindings.Clear()
                TxtSaldoDC.DataBindings.Clear()
                txtEstatus.DataBindings.Clear()
                txtIdCliente2.DataBindings.Clear()

            End If

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            Exit Sub
        End Try
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim conexion As New OleDbConnection
            conexion.ConnectionString = ("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=" & Ruta)

            Dim sentsqlinsert As String
            sentsqlinsert = "UPDATE Cuentas SET estatus='INACTIVO' where idcliente=" & txtIdCliente2.Text & " AND NoCuenta=" & TxtNumerodecuentaDC.Text


            Dim comando As New OleDbCommand(sentsqlinsert, conexion)

            conexion.Open()
            comando.ExecuteNonQuery()

            MsgBox("La cuenta ha sido dada de baja.")
            conexion.Close()

            btnGuardar.Enabled = False

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try

        Try
            Dim conexion As New OleDbConnection()
            conexion.ConnectionString = ("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=" & Ruta)

            Dim SentSQLinsert As String

            SentSQLinsert = "INSERT INTO Operaciones(OPERACION, QUIEN, AQuien, FECHA, HORA, NOACCESO) VALUES('CANCELAR CUENTA'," & IDempActivo & "," & txtIdCliente.Text & ",'" & Format(Now, "dd/MM/yyyy") & "','" & Format(Now, "hh:mm") & "'," & NumAcceso & ")"
            Dim comando As New OleDbCommand(SentSQLinsert, conexion)

            conexion.Open()
            comando.ExecuteNonQuery()

            conexion.Close()

            txtIdCliente.Clear()
            txtNombreDP.Clear()
            txtApellidoPaternoDP.Clear()
            txtApellidoMaternoDP.Clear()
            txtCURPDP.Clear()
            cbxSexoDP.SelectedIndex = -1
            txtEdadDP.Clear()
            DTPFechaDeNacimientoDP.Value = Format(Now, "dd/MM/yyyy")
            cbxEstadocivilDP.SelectedIndex = -1
            TxtTelefonodecasaDp.Clear()
            txtCelularDP.Clear()
            txtCorreoelectronicoDP.Clear()
            txtCalleDP.Clear()
            txtNumerodecasaDP.Clear()
            txtColoniaDP.Clear()
            txtCiudadDP.Clear()
            txtcodigopostalDP.Clear()
            txtMunicipioDP.Clear()
            txtEstadoDP.Clear()

            TxtNumerodecuentaDC.Clear()
            txtEstatus.Clear()
            cboTipodecuentaDC.SelectedIndex = -1
            TxtMontodeaperturaDC.Clear()
            txtIdCliente2.Clear()
            TxtSaldoDC.Clear()

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            Exit Sub
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        frmMenu.Show()
        Me.Close()
    End Sub
End Class