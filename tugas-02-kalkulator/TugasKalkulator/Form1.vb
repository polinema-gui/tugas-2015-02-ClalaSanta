Public Class Form1
    Dim Angka1 As Integer
    Dim Angka2 As Integer
    Dim operasi As String
    Dim status As Boolean
    Private Sub input(ByVal angka As Char)
        If Me.status = True Then
            If (Me.TextBox1.Text = "0") Then
                Me.TextBox1.Text = Convert.ToString(angka)
            Else
                Dim TextBox1 As TextBox = Me.TextBox1
                TextBox1.Text = (TextBox1.Text & Convert.ToString(angka))
            End If
        Else
            Me.TextBox1.Text = Convert.ToString(angka)
            Me.status = True
        End If
    End Sub
    Private Sub inputOperator(ByVal oprator As String)
        If (Me.TextBox1.Text <> "0") Then
            If (Me.operasi = String.Empty) Then
                Me.Angka1 = Convert.ToInt32(Me.TextBox1.Text)
                Me.TextBox1.Text = Me.Angka1.ToString
                Me.status = False
            Else
                Me.hitung()
            End If
            Me.operasi = oprator
        End If
    End Sub
    Private Sub hitung()
        Me.Angka2 = Convert.ToInt32(Me.TextBox1.Text)
        Select Case Me.operasi
            Case "+"
                Me.Angka1 = (Me.Angka1 + Me.Angka2)
                Exit Select
            Case "-"
                Me.Angka1 = (Me.Angka1 - Me.Angka2)
                Exit Select
        End Select
        Me.TextBox1.Text = Me.Angka1.ToString
        Me.status = False
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If (Me.status AndAlso (Me.TextBox1.Text <> "0")) Then
            Dim resultText As TextBox = Me.TextBox1
            TextBox1.Text = (TextBox1.Text & "0")
        End If

    End Sub

    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        Me.TextBox1.Text = "0"
        Me.Angka1 = 0
        Me.operasi = String.Empty
    End Sub

    Private Sub ButtonHasil_Click(sender As Object, e As EventArgs) Handles ButtonHasil.Click
        If ((Me.TextBox1.Text <> "0") And (Me.Angka1 <> 0)) Then
            Me.hitung()
            Me.operasi = String.Empty
        End If
    End Sub

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        Me.inputOperator("+")
    End Sub
    Private Sub ButtonKurang_Click(sender As Object, e As EventArgs) Handles ButtonKurang.Click
        Me.inputOperator("-")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.input("1")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.input("2")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.input("3")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.input("4")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.input("5")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.input("6")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.input("7")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.input("8")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.input("9")
    End Sub
End Class



