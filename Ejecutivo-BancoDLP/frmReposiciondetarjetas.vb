Imports System.Data
Imports System.Data.OleDb
Public Class frmreposiciondetarjetas
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
            sentsql1 = "SELECT * FROM CLIENTES WHERE IDCLIENTE='" & txtIdCliente.Text & "'"

            Dim objadap As New OleDbDataAdapter(sentsql1, conexion)
            Dim miconsulta As New DataTable

            conexion.Open()
            objadap.Fill(miconsulta)

            If (miconsulta.Rows.Count) = 0 Then

                MsgBox("El cliente con el id ingresado no existe, Verifique.")
                txtIdCliente.Focus()

            Else

                IDBuscado = txtIdCliente.Text

                txtIdCliente.DataBindings.Add("text", miconsulta, "idcliente")
                txtNombreDP.DataBindings.Add("text", miconsulta, "nombre")
                txtApellidoPaternoDP.DataBindings.Add("text", miconsulta, "Apellido paterno")
                txtApellidoMaternoDP.DataBindings.Add("text", miconsulta, "Apellido materno")
                txtCURPDP.DataBindings.Add("text", miconsulta, "CURP")
                cbxSexoDP.DataBindings.Add("text", miconsulta, "Sexo")
                txtEdadDP.DataBindings.Add("text", miconsulta, "Edad")
                DTPFechaDeNacimientoDP.DataBindings.Add("text", miconsulta, "Fecha de nacimiento")
                cbxEstadocivilDP.DataBindings.Add("text", miconsulta, "Estado civil")
                TxtTelefonodecasaDp.DataBindings.Add("text", miconsulta, "Telefono Casa")
                txtCelularDP.DataBindings.Add("text", miconsulta, "Celular")
                txtCorreoelectronicoDP.DataBindings.Add("text", miconsulta, "Correo electronico")
                txtCalleDP.DataBindings.Add("text", miconsulta, "Calle")
                txtNumerodecasaDP.DataBindings.Add("text", miconsulta, "Numero de casa")
                txtColoniaDP.DataBindings.Add("text", miconsulta, "Colonia")
                txtCiudadDP.DataBindings.Add("text", miconsulta, "Ciudad")
                txtcodigopostalDP.DataBindings.Add("text", miconsulta, "Codigo postal")
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
                IDBuscado = txtIdCliente.Text

                TxtNumerodecuentaDC.DataBindings.Add("text", miconsulta, "Numero de cuenta")
                cboTipodecuentaDC.DataBindings.Add("text", miconsulta, "Tipo de cuenta")
                TxtMontodeaperturaDC.DataBindings.Add("text", miconsulta, "Monto de apertura")
                TxtSaldoDC.DataBindings.Add("text", miconsulta, "Saldo")
                txtEstatus.DataBindings.Add("text", miconsulta, "Estatus")
                txtIdCliente2.DataBindings.Add("text", miconsulta, "idcliente")

                TxtNumerodecuentaDC.DataBindings.Clear()
                cboTipodecuentaDC.DataBindings.Clear()
                TxtMontodeaperturaDC.DataBindings.Clear()
                TxtSaldoDC.DataBindings.Clear()
                txtEstatus.DataBindings.Clear()
                txtIdCliente2.DataBindings.Clear()

                txtNum1.Enabled = True
                txtNum2.Enabled = True
                txtNum3.Enabled = True
                txtNum4.Enabled = True

                btnAceptar.Enabled = True
            End If

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            Exit Sub
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        frmMenu.Show()
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Try
            Dim conexion As New OleDbConnection
            conexion.ConnectionString = ("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=" & Ruta)

            Dim sentsqlinsert As String
            sentsqlinsert = "UPDATE tarjetas SET idtarjeta='" & txtNum1.Text & txtNum2.Text & txtNum3.Text & txtNum4.Text & "', estatus='INACTIVO' where nocuenta=" & TxtNumerodecuentaDC.Text & " AND IDCLIENTE=" & txtIdCliente2.Text


            Dim comando As New OleDbCommand(sentsqlinsert, conexion)

            conexion.Open()
            comando.ExecuteNonQuery()

            MessageBox.Show("La tarjeta ha sido repuesta. Espere la autorizacion.", "Tarjeta repuesta...")

            conexion.Close()

            btnAceptar.Enabled = False

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try


        Try
            Dim conexion As New OleDbConnection()
            conexion.ConnectionString = ("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=" & Ruta)

            Dim SentSQLinsert As String

            SentSQLinsert = "INSERT INTO Operaciones(OPERACION, QUIEN, AQuien, FECHA, HORA, NOACCESO) VALUES('ASIGNAR NUEVA TARJETA'," & IDempActivo & "," & txtIdCliente.Text & ",'" & Format(Now, "dd/MM/yyyy") & "','" & Format(Now, "hh:mm") & "'," & NumAcceso & ")"
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

            txtNum1.Clear()
            txtNum2.Clear()
            txtNum3.Clear()
            txtNum4.Clear()

            btnAceptar.Enabled = False
            txtNum1.Enabled = False
            txtNum2.Enabled = False
            txtNum3.Enabled = False
            txtNum4.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            Exit Sub
        End Try

    End Sub
End Class