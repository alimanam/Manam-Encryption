Imports System.IO

Public Class Form1
    Private Sub btnRandomKey_Click(sender As Object, e As EventArgs) Handles btnRandomKey.Click
        txtKey.Text = AesCryptography.CreatePassword(16)
    End Sub

    Private Sub btnEncrypt_Click(sender As Object, e As EventArgs) Handles btnEncrypt.Click
        Try
            Dim input = txtEncrypt.Text
            Dim password = txtKey.Text
            Dim result = AesCryptography.EncryptText(input, password)
            txtDecrypt.Text = result
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnDecrypt_Click(sender As Object, e As EventArgs) Handles btnDecrypt.Click
        Try
            Dim input = txtEncrypt.Text
            Dim password = txtKey.Text
            Dim result = AesCryptography.DecryptText(input, password)
            txtDecrypt.Text = result
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub copyMenItm_Click(sender As Object, e As EventArgs) Handles copyMenItm.Click
        My.Computer.Clipboard.SetText(txtDecrypt.Text)
    End Sub

    Private Sub pasteMenItm_Click(sender As Object, e As EventArgs) Handles pasteMenItm.Click
        txtEncrypt.Text = My.Computer.Clipboard.GetText
    End Sub

    Private Sub emptyMenItm_Click(sender As Object, e As EventArgs) Handles emptyMenItm.Click
        txtEncrypt.Text = ""
        txtDecrypt.Text = ""
    End Sub

    Private Sub aboutMenItm_Click(sender As Object, e As EventArgs) Handles aboutMenItm.Click
        MsgBox("Developed by Ali Dakhilzadeh ")
    End Sub

    Private Sub newMenItm_Click(sender As Object, e As EventArgs) Handles newMenItm.Click
        txtEncrypt.Text = ""
        txtDecrypt.Text = ""
        txtKey.Text = ""
    End Sub

    Private Sub openMenItm_Click(sender As Object, e As EventArgs) Handles openMenItm.Click
        OpenEncryptedFile()
    End Sub

    Private Sub OpenEncryptedFile()
        Try

            Using openFileDialog As OpenFileDialog = New OpenFileDialog()
                openFileDialog.Filter = "Manam Encrypted files (*.mEncrypt)|*.mEncrypt"
                openFileDialog.FilterIndex = 1
                openFileDialog.RestoreDirectory = True

                If openFileDialog.ShowDialog() = DialogResult.OK Then
                    Dim fileStream = openFileDialog.OpenFile()

                    Using reader As StreamReader = New StreamReader(fileStream)
                        txtEncrypt.Text = reader.ReadToEnd()
                    End Using

                    Dim Key = InputBox("Enter Password?", "Password", "")

                    txtDecrypt.Text = AesCryptography.DecryptText(txtEncrypt.Text, Key)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SaveToFile()
        Try
            Dim saveFileDialog1 As SaveFileDialog = New SaveFileDialog()
            saveFileDialog1.Filter = "Manam Encrypted files (*.mEncrypt)|*.mEncrypt"
            saveFileDialog1.RestoreDirectory = True

            If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                File.WriteAllText(saveFileDialog1.FileName, txtDecrypt.Text)
            End If

            MsgBox("File saved")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub saveMenItm_Click(sender As Object, e As EventArgs) Handles saveMenItm.Click
        SaveToFile()
    End Sub

    Private Sub exitMenItm_Click(sender As Object, e As EventArgs) Handles exitMenItm.Click
        Application.Exit()
    End Sub
End Class
