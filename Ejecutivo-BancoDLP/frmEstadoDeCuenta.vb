Imports System.Data
Imports System.Data.OleDb
Public Class frmEstadoDeCuenta
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
            sentsql1 = "SELECT * FROM Cuentas WHERE IDCLIENTE=" & txtIdCliente.Text

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




                TxtSaldoDC.DataBindings.Clear()

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
            sentsql1 = "SELECT * FROM MOVIMIENTOS WHERE IDCLIENTE=" & txtIdCliente.Text

            Dim objadap As New OleDbDataAdapter(sentsql1, conexion)
            Dim obddataset As New DataSet

            conexion.Open()

            objadap.Fill(obddataset)
            gridLista.DataSource = obddataset.Tables(0)

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

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class