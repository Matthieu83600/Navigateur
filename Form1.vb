Public Class Navigateur
    Dim web As New WebBrowser
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked
        If e.ClickedItem.Text = "Quitter" Then
            Application.Exit()
        ElseIf e.ClickedItem.Text = "Précédent" Then
            web.GoBack()
        ElseIf e.ClickedItem.Text = "Suivant" Then
            web.GoForward()
        ElseIf e.ClickedItem.Text = "Google" Then
            web.Navigate("https://google.fr")
        ElseIf e.ClickedItem.Text = "Sauvegarder" Then
            Dim webClient As New Net.WebClient
            webClient.DownloadFile(web.Url, "D:\Test\Save.html")
        ElseIf e.ClickedItem.Text = "Aide" Then
            MessageBox.Show("Logiciel développé par Matthieu Bonjour - Version 1.0", "Aide")
        End If
    End Sub

    Private Sub Navigateur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        web.Dock = DockStyle.Fill
        web.ScriptErrorsSuppressed = True
        Me.Controls.Add(web)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        web.Navigate(TextBox1.Text)
    End Sub
End Class
