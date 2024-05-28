Imports System
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Module AesCryptography
    Public Function CreatePassword(ByVal length As Integer) As String
        Const valid As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890.!?$%^*{}@"
        Dim res As StringBuilder = New StringBuilder()
        Dim rnd As Random = New Random()

        If True Then

            While 0 < Math.Max(System.Threading.Interlocked.Decrement(length), length + 1)
                res.Append(valid(rnd.[Next](valid.Length)))
            End While
        End If

        Return res.ToString()
    End Function

    Private Function AesEncrypt(ByVal bytesToEncrypted As Byte(), ByVal passwordBytes As Byte()) As Byte()
        Dim encryptedBytes As Byte()
        Dim saltBytes = New Byte() {1, 2, 3, 4, 5, 6, 7, 8}

        Using memoryStream = New MemoryStream()

            Using aes = New RijndaelManaged()
                aes.KeySize = 256
                aes.BlockSize = 128
                Dim key = New Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000)
                aes.Key = key.GetBytes(aes.KeySize / 8)
                aes.IV = key.GetBytes(aes.BlockSize / 8)
                aes.Mode = CipherMode.CBC

                Using cs = New CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write)
                    cs.Write(bytesToEncrypted, 0, bytesToEncrypted.Length)
                    cs.Close()
                End Using

                encryptedBytes = memoryStream.ToArray()
            End Using
        End Using

        Return encryptedBytes
    End Function

    Private Function AesDecrypt(ByVal bytesToDecrypted As Byte(), ByVal passwordBytes As Byte()) As Byte()
        Dim decryptedBytes As Byte()
        Dim saltBytes = New Byte() {1, 2, 3, 4, 5, 6, 7, 8}

        Using memoryStream = New MemoryStream()

            Using aes = New RijndaelManaged()
                aes.KeySize = 256
                aes.BlockSize = 128
                Dim key = New Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000)
                aes.Key = key.GetBytes(aes.KeySize / 8)
                aes.IV = key.GetBytes(aes.BlockSize / 8)
                aes.Mode = CipherMode.CBC

                Using cs = New CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Write)
                    cs.Write(bytesToDecrypted, 0, bytesToDecrypted.Length)
                    cs.Close()
                End Using

                decryptedBytes = memoryStream.ToArray()
            End Using
        End Using

        Return decryptedBytes
    End Function

    Public Function EncryptText(ByVal input As String, ByVal password As String) As String
        If String.IsNullOrEmpty(input) Then Throw New ArgumentNullException(NameOf(input))
        If String.IsNullOrEmpty(password) Then Throw New ArgumentNullException(NameOf(password))
        Dim bytesToEncrypted = Encoding.UTF8.GetBytes(input)
        Dim passwordBytes = Encoding.UTF8.GetBytes(password)
        passwordBytes = SHA256.Create().ComputeHash(passwordBytes)
        Dim bytesEncrypted = AesEncrypt(bytesToEncrypted, passwordBytes)
        Dim result = Convert.ToBase64String(bytesEncrypted)
        Return result
    End Function

    Public Function DecryptText(ByVal input As String, ByVal password As String) As String
        If String.IsNullOrEmpty(input) Then Throw New ArgumentNullException(NameOf(input))
        If String.IsNullOrEmpty(password) Then Throw New ArgumentNullException(NameOf(password))
        Dim bytesToDecrypted = Convert.FromBase64String(input)
        Dim passwordBytes = Encoding.UTF8.GetBytes(password)
        passwordBytes = SHA256.Create().ComputeHash(passwordBytes)
        Dim bytesDecrypted = AesDecrypt(bytesToDecrypted, passwordBytes)
        Dim result = Encoding.UTF8.GetString(bytesDecrypted)
        Return result
    End Function

    Public Sub EncryptFile(ByVal filePath As String, ByVal password As String)
        If String.IsNullOrEmpty(filePath) Then Throw New ArgumentNullException(NameOf(filePath))
        If String.IsNullOrEmpty(password) Then Throw New ArgumentNullException(NameOf(password))
        Dim bytesToEncrypted = File.ReadAllBytes(filePath)
        Dim passwordBytes = Encoding.UTF8.GetBytes(password)
        passwordBytes = SHA256.Create().ComputeHash(passwordBytes)
        Dim bytesEncrypted = AesEncrypt(bytesToEncrypted, passwordBytes)
        File.WriteAllBytes(filePath, bytesEncrypted)
    End Sub

    Public Sub DecryptFile(ByVal filePath As String, ByVal password As String)
        If String.IsNullOrEmpty(filePath) Then Throw New ArgumentNullException(NameOf(filePath))
        If String.IsNullOrEmpty(password) Then Throw New ArgumentNullException(NameOf(password))
        Dim bytesToDecrypted = File.ReadAllBytes(filePath)
        Dim passwordBytes = Encoding.UTF8.GetBytes(password)
        passwordBytes = SHA256.Create().ComputeHash(passwordBytes)
        Dim bytesDecrypted = AesDecrypt(bytesToDecrypted, passwordBytes)
        File.WriteAllBytes(filePath, bytesDecrypted)
    End Sub

End Module
