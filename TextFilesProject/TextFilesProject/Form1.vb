Public Class Form1
    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        Dim DICTIONARY_FILE As String = "C:\Users\ma52c\Google Drive\Coding\VisualBasic\TextFilesProject\prep\Dictionary.txt"
        Dim text As String
        Dim arySeperate() As String
        Dim objReader As New System.IO.StreamReader(DICTIONARY_FILE)
        Dim term As String
        Dim def As String

        Do While objReader.Peek() <> -1
            text = objReader.ReadLine()
            arySeperate = text.Split("=")
            term = arySeperate(0)
            def = arySeperate(1)

            term = term.Trim
            def = def.Trim

            lstTranslation.Items.Add(term)
            lstText.Items.Add(def)


        Loop

    End Sub
End Class
