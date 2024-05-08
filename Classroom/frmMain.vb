Imports MySql.Data.MySqlClient


Public Class frmMain
    Dim connection As New MySqlConnection("Data Source=localhost; database=classroom; username=root; password=")
    Dim reader As MySqlDataReader
    Dim adapter As MySqlDataAdapter
    Dim command As MySqlCommand
    Dim query As String

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            connection.Open()
            query = "INSERT INTO bonifacio (student_id, firstname, middlename, lastname, gender, year_level) VALUES (@studentid, @firstname, @middlename, @lastname, @gender, @yearlevel);"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@studentid", txtID.Text)
            command.Parameters.AddWithValue("@firstname", txtFirstName.Text)
            command.Parameters.AddWithValue("@middlename", txtMiddleName.Text)
            command.Parameters.AddWithValue("@lastname", txtLastName.Text)
            command.Parameters.AddWithValue("@gender", cmbGender.Text)
            command.Parameters.AddWithValue("@yearlevel", cmbYear.Text)
            command.ExecuteNonQuery()
            MsgBox("Data added")
            connection.Close()
            LoadData()
            ClearData()
        Catch ex As Exception
            MsgBox(ex.Message)
            connection.Close()
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Sub LoadData()
        connection.Open()
        adapter = New MySqlDataAdapter("SELECT * FROM bonifacio", connection)
        Dim dt As New DataTable
        adapter.Fill(dt)
        dgv.DataSource = dt
        connection.Close()
    End Sub

    Sub ClearData()
        txtID.Clear()
        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtLastName.Clear()
        cmbGender.SelectedIndex = -1
        cmbYear.SelectedIndex = -1
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If txtID.Text = "" Then
                MsgBox("You cannot update a data without any specific ID from the table!")
            Else
                connection.Open()
                query = "DELETE FROM bonifacio WHERE student_id = @id"
                command = New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@id", txtID.Text)
                command.ExecuteNonQuery()
                MsgBox("Data Deleted")
                connection.Close()
                LoadData()
                ClearData()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            connection.Close()
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If txtID.Text = "" Then
                MsgBox("You cannot update a data without any specific ID from the table!")
            Else
                connection.Open()
                query = "UPDATE bonifacio SET firstname = @firstname, middlename = @middlename, lastname = @lastname, gender = @gender, year_level = @yearlevel WHERE student_id = @studentid;"
                command = New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@studentid", txtID.Text)
                command.Parameters.AddWithValue("@firstname", txtFirstName.Text)
                command.Parameters.AddWithValue("@middlename", txtMiddleName.Text)
                command.Parameters.AddWithValue("@lastname", txtLastName.Text)
                command.Parameters.AddWithValue("@gender", cmbGender.Text)
                command.Parameters.AddWithValue("@yearlevel", cmbYear.Text)
                command.ExecuteNonQuery()
                MsgBox($"ID {txtID.Text} is updated!")
                connection.Close()
                LoadData()
                ClearData()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            connection.Close()
        End Try

    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        Try
            txtID.Text = dgv.CurrentRow.Cells(0).Value
            txtFirstName.Text = dgv.CurrentRow.Cells(1).Value
            txtMiddleName.Text = dgv.CurrentRow.Cells(2).Value
            txtLastName.Text = dgv.CurrentRow.Cells(3).Value
            cmbGender.Text = dgv.CurrentRow.Cells(4).Value
            cmbYear.Text = dgv.CurrentRow.Cells(5).Value
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class
