Structure archivo
    Public recnum As Integer
    Public nombre As String
    Public apellido As String
    Public horas As Integer
    Public paga As Decimal
    Public salario As Decimal
    Public diurno As Boolean
    Public nocturno As Boolean
    Public masculino As Boolean
    Public femenino As Boolean
    Public residencia As String

End Structure
Public Class Form1

    Private palabra As String


    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim campo As archivo, file As System.IO.StreamWriter, fil As System.IO.FileStream = New IO.FileStream("C:\\test.txt", IO.FileMode.OpenOrCreate)
        fil.Close()
        campo.recnum = Val(TextBox1.Text)
        campo.nombre = TextBox2.Text
        campo.apellido = TextBox3.Text
        campo.horas = Val(TextBox3.Text)
        campo.paga = Val(TextBox4.Text)
        campo.salario = Val(TextBox6.Text)
        If (CheckBox1.Checked = True) Then
            campo.diurno = True
            campo.nocturno = False
        Else
            If (CheckBox2.Checked = True) Then
                campo.nocturno = True
                campo.diurno = False
            End If
        End If
        If (RadioButton1.Checked = True) Then
            campo.femenino = True
            campo.masculino = False

        Else
            campo.masculino = True
            campo.femenino = False
        End If
        campo.residencia = palabra


        file = New IO.StreamWriter("C:\\test.txt", False)
        file.Write("{0} " & vbCrLf & "{1}" & vbCrLf & "{2}" & vbCrLf & "{3}/n" & vbCrLf & "{4}" & vbCrLf & "{5}" & vbCrLf & "{6}" & vbCrLf & "{7}" & vbCrLf & "{8}" & vbCrLf & "{9}" & vbCrLf & "{10}", campo.recnum, campo.nombre, campo.apellido, campo.horas, campo.paga, campo.salario, campo.diurno, campo.nocturno, campo.masculino, campo.femenino, campo.residencia)
        file.Close()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox6.Text = Val(TextBox4.Text) * Val(TextBox5.Text)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim res As String
        res = ComboBox1.Text
        resid(res)
    End Sub
    Sub resid(res As String)
        palabra = res
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim campo As archivo, file As System.IO.StreamReader
        file = My.Computer.FileSystem.OpenTextFileReader("C:\\test.txt")
        While (file.ReadLine() <> Nothing)
            If (campo.recnum <> Nothing) Then
                TextBox1.Text = campo.recnum
            End If
            If (campo.nombre <> Nothing) Then
                TextBox2.Text = campo.nombre
            End If
            If (campo.apellido <> Nothing) Then
                TextBox3.Text = campo.apellido
            End If
            If (campo.horas <> Nothing) Then
                TextBox4.Text = campo.horas
            End If
            If (campo.paga <> Nothing) Then
                TextBox5.Text = campo.paga
            End If
            If (campo.salario <> Nothing) Then
                TextBox6.Text = campo.salario
            End If
            If (campo.diurno <> Nothing) Then
                CheckBox1.Text = campo.diurno
            End If
            If (campo.nocturno <> Nothing) Then
                CheckBox2.Text = campo.nocturno
            End If
            If (campo.masculino <> Nothing) Then
                RadioButton1.Text = campo.masculino
            End If
            If (campo.femenino <> Nothing) Then
                RadioButton2.Text = campo.femenino
            End If
            If (campo.residencia <> Nothing) Then
                ComboBox1.Text = campo.residencia
            End If

        End While
        file.Close()

    End Sub
End Class