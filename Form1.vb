Public Class Navigateur
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked
        If e.ClickedItem.Text = "Quitter" Then
            Application.Exit()
        ElseIf e.ClickedItem.Text = "Précédent" Then

        ElseIf e.ClickedItem.Text = "Suivant" Then

        ElseIf e.ClickedItem.Text = "Aide" Then
            MessageBox.Show("Logiciel développé par Matthieu Bonjour - Version 1.0", "Aide")
        End If
    End Sub

    Private Sub Navigateur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim web As New WebBrowser
        web.Dock = DockStyle.Fill
        Me.Controls.Add(web)
    End Sub
End Class
