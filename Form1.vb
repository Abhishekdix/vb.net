Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAddgoods.Click
        Form2.Show()
        Me.Hide()


    End Sub

    Private Sub btnDeletegoods_Click(sender As Object, e As EventArgs) Handles btnDeletegoods.Click
        Delete.Show()
        Me.Hide()

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Form4.Show()
        Me.Hide()

    End Sub
End Class
