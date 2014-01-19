Public Class Engine

    '## Class variables
    Private screen As String

    Private operand1 As String
    Private operand2 As String
    Private operator1 As Char
    Private operator2 As Char

    Private Function CharDecimalIs(ByVal ch As Char)
        Return ch = ","c Or ch = "."c
    End Function

    Private Function CharDigitIs(ByVal ch As Char)
        Return ch >= "0"c And ch <= "9"c
    End Function

    Private Function DecimalContains(ByVal str As String)
        For Each c As Char In str
            If CharDecimalIs(c) Then
                Return True
            End If
        Next

        Return False
    End Function

    Private Function OperandPush(ByVal operand As String, ByVal inp As Char)
        ' Assuming inp is not an operator

        If inp = ","c Or inp = "."c Then
            If DecimalContains(operand) Then
                Return False
            End If
        End If

        operand += inp
        Return True
    End Function

    Private Function Operand1Push(ByVal inp As Char)
        Return OperandPush(operand1, inp)
    End Function

    Private Function Operand2Push(ByVal inp As Char)
        Return OperandPush(operand2, inp)
    End Function

    Private Function FormatScreen()
        screen = ""
        screen += operand1
        screen += operator1
        screen += operand2
        screen += operator2
        Return screen
    End Function

    '## Add a char to the buffer when possible
    Public Function Add(ByVal ch As Char)

        If CharDigitIs(ch) Then '## Handling digits
            If operator1 = Nothing Then '# Fill in operand1
                Operand1Push(ch)
            ElseIf operator2 = Nothing Then '# Fill in operand2
                Operand2Push(ch)
            End If
        ElseIf CharDecimalIs(ch) Then
            If operator1 = Nothing And DecimalContains(
            End If


            '## Throw the display
            Return FormatScreen()
    End Function

    Private Function IsBasicOperator(ByVal op As Char)
        Return op = "+"c Or op = "-"c Or op = "*"c Or op = "/"c
    End Function

    'Private Function Compute()
    '    Dim C As Char
    '    Dim res, tmpres As Double
    '    Dim index As Integer
    '    Dim numop As Integer
    '    Dim operandes(3) As String

    '    C = Left(buffer, 1)
    '    index = 0
    '    numop = 0

    '    While index < (Len(buffer))
    '        While Not IsBasicOperator(C)
    '            operandes(numop) += C
    '            index += 1
    '            If index < Len(buffer) Then
    '                C = buffer(index)
    '            End If
    '        End While
    '        If numop < 2 Then
    '            numop += 1
    '        Else
    '            Select Case operandes(1)
    '                Case "+"c
    '                    tmpres = Val(operandes(0)) + Val(operandes(2))
    '                Case "*"c
    '                    tmpres = Val(operandes(0)) * Val(operandes(2))
    '                Case "-"c
    '                    tmpres = Val(operandes(0)) - Val(operandes(2))
    '                Case "/"c
    '                    tmpres = Val(operandes(0)) / Val(operandes(2))
    '            End Select
    '            'Console.WriteLine(CStr(tmpres))
    '            operandes(0) = tmpres
    '            numop = 1
    '        End If
    '        operandes(numop) = C
    '        numop += 1
    '        index += 1
    '        If index < Len(buffer) Then
    '            C = buffer(index)
    '        End If
    '    End While
    '    res = operandes(0)
    '    Return res
    'End Function


    'Private Function Compute()
    '    Dim res As Double
    '    Dim a, b, ope, h As String
    '    a = Nothing
    '    b = Nothing
    '    Dim iter As Boolean
    '    Dim C As Char
    '    iter = False
    '    Dim index As Integer
    '    index = 0
    '    h = Nothing
    '    C = Left(buffer, 1)
    '    While C <> "="c
    '        If Not IsBasicOperator(C) Then
    '            h += C
    '        Else
    '            ope = C
    '            If Not iter Then
    '                a = h
    '                iter = True
    '                h = Nothing
    '            Else
    '                b = h
    '                Select Case ope
    '                    Case "+"
    '                        res = CDbl(a) + CDbl(b)
    '                    Case "-"
    '                        res = CDbl(a) - CDbl(b)
    '                    Case "*"
    '                        res = CDbl(a) * CDbl(b)
    '                    Case "/"
    '                        res = CDbl(a) / CDbl(b)
    '                End Select
    '                buffer = buffer.Replace(a + ope + b, res)
    '                C = Left(buffer, 1)
    '            End If
    '        End If
    '        index = index + 1
    '        C = buffer.Chars(index)
    '    End While
    '    Return res
    'End Function
End Class
