Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Addratio.Checked Then
            TextBox3.Text = TextBox1.Text + 0 + TextBox2.Text
        ElseIf subratio.Checked Then
            TextBox3.Text = TextBox1.Text - TextBox2.Text
        ElseIf Multiratio.Checked Then
            TextBox3.Text = TextBox1.Text * TextBox2.Text
        ElseIf divratio.Checked Then
            TextBox3.Text = TextBox1.Text / TextBox2.Text

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class
