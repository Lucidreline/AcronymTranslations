Public Class Form1

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        LoadListBoxes()
    End Sub



    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim formatNewEntry As String = vbNewLine & txtNewLine.Text.ToUpper & " = " & txtDefinition.Text
        Dim DICTIONARY_FILE As String = GetFilePath()

        Dim objWriter As New System.IO.StreamWriter(DICTIONARY_FILE, True)
        objWriter.Write(formatNewEntry)
        objWriter.Close()
        LoadListBoxes()

    End Sub

    Private Shared Function GetFilePath() As String
        Return "C:\Users\ma52c\Google Drive\Coding\VisualBasic\TextFilesProject\prep\Dictionary.txt"
    End Function

    Private Sub LoadListBoxes()
        Dim DICTIONARY_FILE As String = GetFilePath()
        Dim text As String
        Dim arySeperate() As String
        Dim objReader As New System.IO.StreamReader(DICTIONARY_FILE)
        Dim term As String
        Dim def As String

        Do While objReader.Peek() <> -1
            text = objReader.ReadLine()
            arySeperate = text.Split("=")
            term = arySeperate(0)

            term = term.Trim
            def = def.Trim

            lstTranslation.Items.Add(term)
            lstText.Items.Add(def)
        Loop
        objReader.Close()
    End Sub
End Class
