Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnComprobar.Click
        lblGuiones.Text = comprobar(txt1.Text, PictureBox1)
        txt1.Clear()


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        cambiarImagen()

    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End

    End Sub

    Private Sub empezar_Click(sender As Object, e As EventArgs)
        start()
    End Sub

    Private Sub txt1_TextChanged(sender As Object, e As EventArgs) Handles txt1.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        start()
        lblGuiones.Text = contruirGiuones()
        PictureBox1.Image = cambiarImagen()


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbl_Fallo.Click

    End Sub

    Private Sub btn_DeNuevo_Click(sender As Object, e As EventArgs) Handles btn_DeNuevo.Click
        start()
        lblGuiones.Text = contruirGiuones()
        PictureBox1.Image = cambiarImagen()
    End Sub
End Class
