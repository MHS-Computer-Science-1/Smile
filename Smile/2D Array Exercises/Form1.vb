Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '1. Create a 2D array called 'grid' with 11 rows and 11 columns

        '2. Run the app, click the button and make sure it displays 100 zeros

        '3. Set every element to 1 using loops


        '4. Run the app, verify that 8s are now displayed

        '5. Now, set some of the elements to 1 to create a smiley face
        '   as shown in the lab description



        'This code displays the array in the ListBox
        'Do not alter it
        For row = 0 To grid.GetLength(0) - 1
            Dim rowOut As String = ""
            For col = 0 To grid.GetLength(1) - 1
                rowOut = rowOut & grid(row, col) & " "
            Next
            ListBox1.Items.Add(rowOut)
        Next

    End Sub
End Class
