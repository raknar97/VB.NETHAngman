Module Module1
    Dim palabras() As String = {"caramelo verde", "casa roja", "koala", "german"}
    Dim guiones As String
    Dim chosen As String
    Dim fallos As Integer

    Sub start()
        Dim value As Integer ' = CInt(Int((4 * Rnd()) + 1))
        Dim ale As New Random
        value = ale.Next(0, palabras.Length)
        chosen = palabras(value)
    End Sub

    Function contruirGiuones() As String


        For i = 0 To chosen.Length - 1
            If chosen(i) = " " Then
                guiones = guiones & " "
            Else
                guiones = guiones & "-"
            End If

        Next
        Return guiones


    End Function
    Function cambiarImagen() As Image
        Return Image.FromFile(Application.StartupPath & "\ahorcado" & fallos & ".jpg")
    End Function

    Function sacar_Fallos() As Label


    End Function
    Function comprobar(caracter As String, pct As PictureBox) As String


        If chosen.Contains(caracter) Then


            For a = 0 To chosen.Length - 1
                If chosen(a) = caracter Then
                    guiones = guiones.Remove(a, 1)
                    guiones = guiones.Insert(a, caracter)

                End If
            Next
        Else
            fallos += 1
            If fallos = 6 Then
                sacar_Fallos()

            End If
            pct.Image = cambiarImagen()
        End If

        Return guiones
    End Function
End Module
