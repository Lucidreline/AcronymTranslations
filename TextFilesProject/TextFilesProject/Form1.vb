Public Class Acronyms

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
        txtDefinition.Clear()
        txtNewLine.Clear()

    End Sub

    Private Sub lstTranslation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTranslation.SelectedIndexChanged
        Dim selectedIndex As Integer
        selectedIndex = lstTranslation.SelectedIndex
        TextBox1.Text = lstText.Items.Item(selectedIndex)

    End Sub

    Private Sub lstText_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstText.SelectedIndexChanged
        Dim selectedIndex As Integer
        selectedIndex = lstText.SelectedIndex
        TextBox1.Text = lstTranslation.Items.Item(selectedIndex)
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

        lstTranslation.Items.Clear()
        lstText.Items.Clear()

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
        objReader.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadListBoxes()
    End Sub
End Class
