Public Class Form1

    Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click
        'Print Happy Birthday in the Listbox
        MessageBox.Show("Thank You! " & txtName.Text)

        'Print Birthday Wishes to list box
        lstOut.Items.Add("Happy Birthday to you! ")
        lstOut.Items.Add("Happy Birthday to you! ")
        lstOut.Items.Add("Happy Birthday Dear " & txtName.Text)
        lstOut.Items.Add("Happy Birthday to you! ")



    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear txtName value
        txtName.Clear()
        lstOut.Items.Clear()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'When user exits the program
        Beep()
        Application.Exit()

    End Sub
End Class
