Public Class HelloWorld
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(MessageBoxButtons.OK, "Hola " + TextBox1.Text)
    End Sub
End Class
