Imports System.Net.Http
Imports System.Net.Security
Imports System.Security.Cryptography.X509Certificates
Public Class Form1
    Private Function CertificateValidationCallback(request As HttpRequestMessage, certificate As X509Certificate2, chain As X509Chain, sslPolicyErrors As SslPolicyErrors) As Boolean

        For Each element In chain.ChainElements
            Dim cert As X509Certificate2 = element.Certificate
            Me.Invoke(Sub()
                          OutputTextBox.Text &= "Subject: " + cert.Subject _
                          & vbCrLf & "Issuer: " + cert.Issuer _
                          & vbCrLf & "Effective Date: " + cert.NotBefore _
                          & vbCrLf & "Expiry Date: " + cert.NotAfter _
                          & vbCrLf & "Raw Content : " + cert.GetRawCertDataString _
                          & vbCrLf & "--------------------------------------------" & vbCrLf & vbCrLf & vbCrLf
                      End Sub)
        Next

        Return True
    End Function
    Async Sub MakeRequest()
        Dim handler As HttpClientHandler = New HttpClientHandler()
        handler.ServerCertificateCustomValidationCallback = AddressOf CertificateValidationCallback

        Dim client As HttpClient = New HttpClient(handler)
        Using response As HttpResponseMessage = Await client.GetAsync(UrlTextBox.Text)
            If response.StatusCode = Net.HttpStatusCode.OK Then
                ' 
            End If
        End Using
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OutputTextBox.Text = ""
        Dim t1 As Task = New Task(AddressOf MakeRequest)
        t1.Start()
    End Sub
End Class
