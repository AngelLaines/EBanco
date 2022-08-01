Imports System.Data
Imports System.Data.OleDb
Public Class frmActualizar
    Public IDBuscado As Integer
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        frmMenu.Show()
        Me.Close()
    End Sub

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
                txtApellidoPaternoDP.DataBindings.Clear()
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

                txtNombreDP.Enabled = True
                txtApellidoPaternoDP.Enabled = True
                txtApellidoMaternoDP.Enabled = True
                txtCURPDP.Enabled = True
                cbxSexoDP.Enabled = True
                txtEdadDP.Enabled = True
                DTPFechaDeNacimientoDP.Enabled = True
                cbxEstadocivilDP.Enabled = True
                TxtTelefonodecasaDp.Enabled = True
                txtCelularDP.Enabled = True
                txtCorreoelectronicoDP.Enabled = True
                txtCalleDP.Enabled = True
                txtNumerodecasaDP.Enabled = True
                txtColoniaDP.Enabled = True
                txtCiudadDP.Enabled = True
                txtcodigopostalDP.Enabled = True
                txtMunicipioDP.Enabled = True
                txtEstadoDP.Enabled = True

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
            sentsql1 = "SELECT * FROM Laborales WHERE IDCLIENTE='" & txtIdCliente.Text & "'"

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
                TxtNombredelaempresaDL.DataBindings.Add("text", miconsulta, "Nombreempresa")
                TxtDireccionDL.DataBindings.Add("text", miconsulta, "Direccion")
                TxtTelefonoDL.DataBindings.Add("text", miconsulta, "Telefono")
                TxtPuestoDL.DataBindings.Add("text", miconsulta, "Puesto")
                TxtsueldomensualDL.DataBindings.Add("text", miconsulta, "Sueldomensual")
                TxtantiguedadDL.DataBindings.Add("text", miconsulta, "Antiguedad")
               

                txtIdCliente.DataBindings.Clear()
                TxtNombredelaempresaDL.DataBindings.Clear()
                TxtDireccionDL.DataBindings.Clear()
                TxtTelefonoDL.DataBindings.Clear()
                TxtPuestoDL.DataBindings.Clear()
                TxtsueldomensualDL.DataBindings.Clear()
                TxtantiguedadDL.DataBindings.Clear()
                


                TxtNombredelaempresaDL.Enabled = True
                TxtDireccionDL.Enabled = True
                TxtTelefonoDL.Enabled = True
                TxtPuestoDL.Enabled = True
                TxtsueldomensualDL.Enabled = True
                TxtantiguedadDL.Enabled = True

            End If

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            Exit Sub
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If txtNombreDP.Text = "" Then
            MsgBox("Falta el dato nombre")
            txtNombreDP.Focus()
            Exit Sub
        End If

        If txtApellidoPaternoDP.Text = "" Then
            MsgBox("Falta el dato apellido paterno")
            txtApellidoPaternoDP.Focus()
            Exit Sub
        End If

        If txtApellidoMaternoDP.Text = "" Then
            MsgBox("Falta el dato apellido materno")
            txtApellidoMaternoDP.Focus()
            Exit Sub
        End If

        If cbxSexoDP.SelectedIndex = -1 Then
            MsgBox("Falta el dato sexo")
            Exit Sub
        End If

        If txtEdadDP.Text = "" Then
            MsgBox("Falta el dato edad")
            txtEdadDP.Focus()
            Exit Sub
        End If

        If cbxEstadocivilDP.SelectedIndex = -1 Then
            MsgBox("Falta el dato estado civil")
            Exit Sub
        End If

        If TxtTelefonodecasaDp.Text = "" Then
            MsgBox("Falta el dato telefono de casa")
            TxtTelefonodecasaDp.Focus()
            Exit Sub
        End If

        If txtCelularDP.Text = "" Then
            MsgBox("Falta el dato celular")
            txtCelularDP.Focus()
            Exit Sub
        End If

        If txtCorreoelectronicoDP.Text = "" Then
            MsgBox("Falta el dato correo electronico")
            txtCorreoelectronicoDP.Focus()
            Exit Sub
        End If

        If txtCalleDP.Text = "" Then
            MsgBox("Falta el dato calle")
            txtCalleDP.Focus()
            Exit Sub
        End If

        If txtNumerodecasaDP.Text = "" Then
            MsgBox("Falta el dato numero de casa")
            txtNumerodecasaDP.Focus()
            Exit Sub
        End If

        If txtColoniaDP.Text = "" Then
            MsgBox("Falta el dato colonia")
            txtColoniaDP.Focus()
            Exit Sub
        End If

        If txtCiudadDP.Text = "" Then
            MsgBox("Falta el dato ciudad")
            txtCiudadDP.Focus()
            Exit Sub
        End If

        If txtcodigopostalDP.Text = "" Then
            MsgBox("Falta el dato codigo postal")
            txtcodigopostalDP.Focus()
            Exit Sub
        End If

        If txtMunicipioDP.Text = "" Then
            MsgBox("Falta el dato apellido municipio")
            txtMunicipioDP.Focus()
            Exit Sub
        End If

        If TxtNombredelaempresaDL.Text = "" Then
            MsgBox("Falta el dato nombre de la empresa")
            TxtNombredelaempresaDL.Focus()
            Exit Sub
        End If

        If TxtDireccionDL.Text = "" Then
            MsgBox("Falta el dato direccion")
            TxtDireccionDL.Focus()
            Exit Sub
        End If

        If TxtTelefonoDL.Text = "" Then
            MsgBox("Falta el dato telefono de la empresa")
            TxtTelefonoDL.Focus()
            Exit Sub
        End If

        If TxtPuestoDL.Text = "" Then
            MsgBox("Falta el dato puesto")
            TxtPuestoDL.Focus()
            Exit Sub
        End If

        If TxtsueldomensualDL.Text = "" Then
            MsgBox("Falta el dato sueldo mensual")
            TxtsueldomensualDL.Focus()
            Exit Sub
        End If

        If TxtantiguedadDL.Text = "" Then
            MsgBox("Falta el dato antiguedad")
            TxtantiguedadDL.Focus()
            Exit Sub
        End If

      


        Try
            Dim conexion As New OleDbConnection
            conexion.ConnectionString = ("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=" & Ruta)

            Dim sentSQLUpdate As String
            sentSQLUpdate = "UPDATE CLIENTES SET NOMBRE='" & txtNombreDP.Text & "', ApellidoPaterno='" & txtApellidoPaternoDP.Text & "', ApellidoMaterno='" & txtApellidoMaternoDP.Text & "', CURP='" & txtCURPDP.Text & "', SEXO='" & cbxSexoDP.SelectedItem & "', EDAD=" & txtEdadDP.Text & ", FechaNacimiento='" & DTPFechaDeNacimientoDP.Value.ToString & "', EstadoCivil='" & cbxEstadocivilDP.SelectedItem & "', Telefono=" & TxtTelefonodecasaDp.Text & ", CELULAR=" & txtCelularDP.Text & ", CorreoElectronico='" & txtCorreoelectronicoDP.Text & "', CALLE='" & txtCalleDP.Text & "', NoCasa=" & txtNumerodecasaDP.Text & ", COLONIA='" & txtColoniaDP.Text & "', CIUDAD='" & txtCiudadDP.Text & "', CodigoPostal=" & txtcodigopostalDP.Text & ", MUNICIPIO='" & txtMunicipioDP.Text & "', ESTADO='" & txtEstadoDP.Text & "' WHERE IDcliente=" & IDBuscado

            Dim comando As New OleDbCommand(sentSQLUpdate, conexion)

            conexion.Open()
            comando.ExecuteNonQuery()

            MessageBox.Show("Los datos han sido actualizados con exito.", "Actualizando datos...")

            conexion.Close()



            btnGuardar.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            Exit Sub
        End Try


        Try
            Dim conexion As New OleDbConnection
            conexion.ConnectionString = ("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=" & Ruta)

            Dim sentSQLUpdate As String
            sentSQLUpdate = "UPDATE Laborales SET NombreEmpresa='" & TxtNombredelaempresaDL.Text & "', direccion='" & TxtDireccionDL.Text & "', telefono='" & TxtTelefonoDL.Text & "', puesto='" & TxtPuestoDL.Text & "', SueldoMensual='" & TxtsueldomensualDL.Text & "', antiguedad='" & TxtantiguedadDL.Text & "' WHERE idcliente='" & IDBuscado & "'"

            Dim comando As New OleDbCommand(sentSQLUpdate, conexion)

            conexion.Open()
            comando.ExecuteNonQuery()

            MessageBox.Show("Los datos han sido actualizados con exito.", "Actualizando datos...")

            conexion.Close()

            txtNombreDP.Enabled = False
            txtApellidoPaternoDP.Enabled = False
            txtApellidoMaternoDP.Enabled = False
            txtCURPDP.Enabled = False
            cbxSexoDP.Enabled = False
            txtEdadDP.Enabled = False
            DTPFechaDeNacimientoDP.Enabled = False
            cbxEstadocivilDP.Enabled = False
            TxtTelefonodecasaDp.Enabled = False
            txtCelularDP.Enabled = False
            txtCorreoelectronicoDP.Enabled = False
            txtCalleDP.Enabled = False
            txtNumerodecasaDP.Enabled = False
            txtColoniaDP.Enabled = False
            txtCiudadDP.Enabled = False
            txtcodigopostalDP.Enabled = False
            txtMunicipioDP.Enabled = False
            txtEstadoDP.Enabled = False
            TxtNombredelaempresaDL.Enabled = False
            TxtDireccionDL.Enabled = False
            TxtTelefonoDL.Enabled = False
            TxtPuestoDL.Enabled = False
            TxtsueldomensualDL.Enabled = False
            TxtantiguedadDL.Enabled = False

            btnGuardar.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            Exit Sub
        End Try

        Try
            Dim conexion As New OleDbConnection()
            conexion.ConnectionString = ("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=" & Ruta)

            Dim SentSQLinsert As String

            SentSQLinsert = "INSERT INTO Operaciones(OPERACION, QUIEN, AQuien, FECHA, HORA, NOACCESO) VALUES('ACTUALIZAR DATOS EMPLEADO'," & IDempActivo & "," & txtIdCliente.Text & ",'" & Format(Now, "dd/MM/yyyy") & "','" & Format(Now, "hh:mm") & "'," & NumAcceso & ")"
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
            TxtNombredelaempresaDL.Clear()
            TxtDireccionDL.Clear()
            TxtTelefonoDL.Clear()
            TxtPuestoDL.Clear()
            TxtsueldomensualDL.Clear()
            TxtantiguedadDL.Clear()

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            Exit Sub
        End Try
    End Sub
End Class