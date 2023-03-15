Public Class Form1

    Dim Nombre(5) As String
    Dim Correo(5) As String
    Dim Telefono(5) As String
    Dim FechadeNacimiento(5) As DateTime?

    Dim i As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Nombre(i) = TextBox1.Text
        Telefono(i) = TextBox2.Text
        Correo(i) = TextBox3.Text
        FechadeNacimiento(i) = DateTimePicker1.Value

        MsgBox("Arreglo" & (i) & "Registrado")
        If i = 5 Then
            MsgBox("Esta lleno")
        Else
            i = i + 1
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        DataGridView1.Rows.Add(TextBox1.Text, TextBox2.Text, TextBox3.Text, DateTimePicker1.Value)
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class
