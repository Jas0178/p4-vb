Public Class claseuapa
    Public Function nota(x As Integer, y As Integer, z As Integer, m As Integer, n As Integer) As String


        Return x + y + z + m + n

    End Function

    Public Function resultado(x As Integer) As String
        If x >= 70 Then
            Return "Aprobado"
        Else
            Return "Reprobado"
        End If
    End Function
    Public Function literal(x As Integer) As String
        If x >= 88 And x <= 100 Then
            Return "A"

        ElseIf x >= 80 And x <= 87 Then
            Return "B"

        ElseIf x >= 70 And x <= 79 Then
            Return "C"

        ElseIf x >= 60 And x <= 69 Then
            Return "D"

        Else
            Return "F"


        End If

    End Function

End Class
