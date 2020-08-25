Public Class Form1
    Private Sub btnconvertir_Click(sender As Object, e As EventArgs) Handles btnconvertir.Click
        Dim num1 As Decimal
        num1 = txtvalor.Text
        'Tiempo
        If cbxtiem1.Text = "Nanosegundo" And cbxtiem2.Text = "Microsegundo" Then
            lblr.Text = num1 / 1000
        ElseIf cbxtiem1.Text = "Nanosegundo" And cbxtiem2.Text = "Milisegundo" Then
            lblr.Text = num1 / 1000000.0
        ElseIf cbxtiem1.Text = "Nanosegundo" And cbxtiem2.Text = "Segundo" Then
            lblr.Text = num1 / 1000000000.0
        ElseIf cbxtiem1.Text = "Nanosegundo" And cbxtiem2.Text = "Minuto" Then
            lblr.Text = num1 / 60000000000.0
        ElseIf cbxtiem1.Text = "Nanosegundo" And cbxtiem2.Text = "Hora" Then
            lblr.Text = num1 / 3600000000000.0
        ElseIf cbxtiem1.Text = "Nanosegundo" And cbxtiem2.Text = "Dia" Then
            lblr.Text = num1 / 86400000000000.0
        ElseIf cbxtiem1.Text = "Nanosegundo" And cbxtiem2.Text = "Semana" Then
            lblr.Text = num1 / 604800000000000.0
        ElseIf cbxtiem1.Text = "Nanosegundo" And cbxtiem2.Text = "Decada" Then
            lblr.Text = num1 / 3.154E+17
        ElseIf cbxtiem1.Text = "Nanosegundo" And cbxtiem2.Text = "Año natural" Then
            lblr.Text = num1 / 3.154E+16
        ElseIf cbxtiem1.Text = "Microsegundo" And cbxtiem2.Text = "Nanosegundo" Then
            lblr.Text = num1 * 1000
        ElseIf cbxtiem1.Text = "Microsegundo" And cbxtiem2.Text = "Milisegundo" Then
            lblr.Text = num1 / 1000
        ElseIf cbxtiem1.Text = "Microsegundo" And cbxtiem2.Text = "Segundo" Then
            lblr.Text = num1 / 1000000.0
        ElseIf cbxtiem1.Text = "Microsegundo" And cbxtiem2.Text = "Minuto" Then
            lblr.Text = num1 / 60000000.0
        ElseIf cbxtiem1.Text = "Microsegundo" And cbxtiem2.Text = "Hora" Then
            lblr.Text = num1 / 3600000000.0
        ElseIf cbxtiem1.Text = "Microsegundo" And cbxtiem2.Text = "Dia" Then
            lblr.Text = num1 / 86400000000.0
        ElseIf cbxtiem1.Text = "Microsegundo" And cbxtiem2.Text = "Semana" Then
            lblr.Text = num1 / 604800000000.0
        ElseIf cbxtiem1.Text = "Microsegundo" And cbxtiem2.Text = "Decada" Then
            lblr.Text = num1 / 315400000000000.0
        ElseIf cbxtiem1.Text = "Microsegundo" And cbxtiem2.Text = "Año natural" Then
            lblr.Text = num1 / 31540000000000.0
        ElseIf cbxtiem1.Text = "Milisegundo" And cbxtiem2.Text = "Nanosegundo" Then
            lblr.Text = num1 * 1000000.0
        ElseIf cbxtiem1.Text = "Milisegundo" And cbxtiem2.Text = "Microsegundo" Then
            lblr.Text = num1 * 1000
        ElseIf cbxtiem1.Text = "Milisegundo" And cbxtiem2.Text = "Segundo" Then
            lblr.Text = num1 / 1000
        ElseIf cbxtiem1.Text = "Milisegundo" And cbxtiem2.Text = "Minuto" Then
            lblr.Text = num1 / 60000
        ElseIf cbxtiem1.Text = "Milisegundo" And cbxtiem2.Text = "Hora" Then
            lblr.Text = num1 / 3600000.0
        ElseIf cbxtiem1.Text = "Milisegundo" And cbxtiem2.Text = "Dia" Then
            lblr.Text = num1 / 86400000.0
        ElseIf cbxtiem1.Text = "Milisegundo" And cbxtiem2.Text = "Semana" Then
            lblr.Text = num1 / 604800000.0
        ElseIf cbxtiem1.Text = "Milisegundo" And cbxtiem2.Text = "Decada" Then
            lblr.Text = num1 / 315400000000.0
        ElseIf cbxtiem1.Text = "Milisegundo" And cbxtiem2.Text = "Año natural" Then
            lblr.Text = num1 / 31540000000.0
        ElseIf cbxtiem1.Text = "Segundo" And cbxtiem2.Text = "Nanosegundo" Then
            lblr.Text = num1 * 1000000000.0
        ElseIf cbxtiem1.Text = "Segundo" And cbxtiem2.Text = "Microsegundo" Then
            lblr.Text = num1 * 1000000.0
        ElseIf cbxtiem1.Text = "Segundo" And cbxtiem2.Text = "Milisegundo" Then
            lblr.Text = num1 * 1000
        ElseIf cbxtiem1.Text = "Segundo" And cbxtiem2.Text = "Minuto" Then
            lblr.Text = num1 / 60
        ElseIf cbxtiem1.Text = "Segundo" And cbxtiem2.Text = "Dia" Then
            lblr.Text = num1 / 86400
        ElseIf cbxtiem1.Text = "Segundo" And cbxtiem2.Text = "Semana" Then
            lblr.Text = num1 / 604800
        ElseIf cbxtiem1.Text = "Segundo" And cbxtiem2.Text = "Decada" Then
            lblr.Text = num1 / 315400000.0
        ElseIf cbxtiem1.Text = "Segundo" And cbxtiem2.Text = "Año natural" Then
            lblr.Text = num1 / 31540000.0
        ElseIf cbxtiem1.Text = "Minuto" And cbxtiem2.Text = "Nanosegundo" Then
            lblr.Text = num1 * 60000000000.0
        ElseIf cbxtiem1.Text = "Minuto" And cbxtiem2.Text = "Microsegundo" Then
            lblr.Text = num1 * 60000000.0
        ElseIf cbxtiem1.Text = "Minuto" And cbxtiem2.Text = "Milisegundo" Then
            lblr.Text = num1 * 60000
        ElseIf cbxtiem1.Text = "Minuto" And cbxtiem2.Text = "Segundo" Then
            lblr.Text = num1 * 60
        ElseIf cbxtiem1.Text = "Minuto" And cbxtiem2.Text = "Hora" Then
            lblr.Text = num1 / 60
        ElseIf cbxtiem1.Text = "Minuto" And cbxtiem2.Text = "Dia" Then
            lblr.Text = num1 / 1440
        ElseIf cbxtiem1.Text = "Minuto" And cbxtiem2.Text = "Semana" Then
            lblr.Text = num1 / 10080
        ElseIf cbxtiem1.Text = "Minuto" And cbxtiem2.Text = "Decada" Then
            lblr.Text = num1 * 0.0000001901
        ElseIf cbxtiem1.Text = "Minuto" And cbxtiem2.Text = "Año natural" Then
            lblr.Text = num1 / 525600
        ElseIf cbxtiem1.Text = "Hora" And cbxtiem2.Text = "Nanosegundo" Then
            lblr.Text = num1 * 3600000000000.0
        ElseIf cbxtiem1.Text = "Hora" And cbxtiem2.Text = "Microsegundo" Then
            lblr.Text = num1 * 3600000000.0
        ElseIf cbxtiem1.Text = "Hora" And cbxtiem2.Text = "Milisegundo" Then
            lblr.Text = num1 * 3600000.0
        ElseIf cbxtiem1.Text = "Hora" And cbxtiem2.Text = "Segundo" Then
            lblr.Text = num1 * 3600
        ElseIf cbxtiem1.Text = "Hora" And cbxtiem2.Text = "Minuto" Then
            lblr.Text = num1 * 60
        ElseIf cbxtiem1.Text = "Hora" And cbxtiem2.Text = "Dia" Then
            lblr.Text = num1 / 24
        ElseIf cbxtiem1.Text = "Hora" And cbxtiem2.Text = "Semana" Then
            lblr.Text = num1 / 168
        ElseIf cbxtiem1.Text = "Hora" And cbxtiem2.Text = "Decada" Then
            lblr.Text = num1 / 87600
        ElseIf cbxtiem1.Text = "Hora" And cbxtiem2.Text = "Año natural" Then
            lblr.Text = num1 / 8760
        ElseIf cbxtiem1.Text = "Dia" And cbxtiem2.Text = "Nanosegundo" Then
            lblr.Text = num1 * 86400000000000.0
        ElseIf cbxtiem1.Text = "Dia" And cbxtiem2.Text = "Microsegundo" Then
            lblr.Text = num1 * 86400000000.0
        ElseIf cbxtiem1.Text = "Dia" And cbxtiem2.Text = "Milisegundo" Then
            lblr.Text = num1 * 86400000.0
        ElseIf cbxtiem1.Text = "Dia" And cbxtiem2.Text = "Segundo" Then
            lblr.Text = num1 * 86400
        ElseIf cbxtiem1.Text = "Dia" And cbxtiem2.Text = "Minuto" Then
            lblr.Text = num1 * 1440
        ElseIf cbxtiem1.Text = "Dia" And cbxtiem2.Text = "Hora" Then
            lblr.Text = num1 * 24
        ElseIf cbxtiem1.Text = "Dia" And cbxtiem2.Text = "Semana" Then
            lblr.Text = num1 / 7
        ElseIf cbxtiem1.Text = "Dia" And cbxtiem2.Text = "Decada" Then
            lblr.Text = num1 / 3650
        ElseIf cbxtiem1.Text = "Dia" And cbxtiem2.Text = "Año natural" Then
            lblr.Text = num1 / 365
        ElseIf cbxtiem1.Text = "Semana" And cbxtiem2.Text = "Nanosegundo" Then
            lblr.Text = num1 * 604800000000000.0
        ElseIf cbxtiem1.Text = "Semana" And cbxtiem2.Text = "Microsegundo" Then
            lblr.Text = num1 * 604800000000.0
        ElseIf cbxtiem1.Text = "Semana" And cbxtiem2.Text = "Milisegundo" Then
            lblr.Text = num1 * 604800000.0
        ElseIf cbxtiem1.Text = "Semana" And cbxtiem2.Text = "Segundo" Then
            lblr.Text = num1 * 604800
        ElseIf cbxtiem1.Text = "Semana" And cbxtiem2.Text = "Minuto" Then
            lblr.Text = num1 * 10080
        ElseIf cbxtiem1.Text = "Semana" And cbxtiem2.Text = "Hora" Then
            lblr.Text = num1 * 168
        ElseIf cbxtiem1.Text = "Semana" And cbxtiem2.Text = "Dia" Then
            lblr.Text = num1 * 7
        ElseIf cbxtiem1.Text = "Semana" And cbxtiem2.Text = "Decada" Then
            lblr.Text = num1 / 521
        ElseIf cbxtiem1.Text = "Semana" And cbxtiem2.Text = "Año natural" Then
            lblr.Text = num1 / 52.143
        ElseIf cbxtiem1.Text = "Decada" And cbxtiem2.Text = "Nanosegundo" Then
            lblr.Text = num1 * 3.154E+17
        ElseIf cbxtiem1.Text = "Decada" And cbxtiem2.Text = "Microsegundo" Then
            lblr.Text = num1 * 315400000000000.0
        ElseIf cbxtiem1.Text = "Decada" And cbxtiem2.Text = "Milisegundo" Then
            lblr.Text = num1 * 315400000000.0
        ElseIf cbxtiem1.Text = "Decada" And cbxtiem2.Text = "Segundo" Then
            lblr.Text = num1 * 315400000.0
        ElseIf cbxtiem1.Text = "Decada" And cbxtiem2.Text = "Minuto" Then
            lblr.Text = num1 * 5256000.0
        ElseIf cbxtiem1.Text = "Decada" And cbxtiem2.Text = "Hora" Then
            lblr.Text = num1 * 87600
        ElseIf cbxtiem1.Text = "Decada" And cbxtiem2.Text = "Dia" Then
            lblr.Text = num1 * 3650
        ElseIf cbxtiem1.Text = "Decada" And cbxtiem2.Text = "Semana" Then
            lblr.Text = num1 * 521
        ElseIf cbxtiem1.Text = "Decada" And cbxtiem2.Text = "Año natural" Then
            lblr.Text = num1 * 10
        ElseIf cbxtiem1.Text = "Año natural" And cbxtiem2.Text = "Nanosegundo" Then
            lblr.Text = num1 * 3.154E+16
        ElseIf cbxtiem1.Text = "Año natural" And cbxtiem2.Text = "Microsegundo" Then
            lblr.Text = num1 * 31540000000000.0
        ElseIf cbxtiem1.Text = "Año natural" And cbxtiem2.Text = "Milisegundo" Then
            lblr.Text = num1 * 31540000000.0
        ElseIf cbxtiem1.Text = "Año natural" And cbxtiem2.Text = "Segundo" Then
            lblr.Text = num1 * 31540000.0
        ElseIf cbxtiem1.Text = "Año natural" And cbxtiem2.Text = "Minuto" Then
            lblr.Text = num1 * 525600
        ElseIf cbxtiem1.Text = "Año natural" And cbxtiem2.Text = "Hora" Then
            lblr.Text = num1 * 8760
        ElseIf cbxtiem1.Text = "Año natural" And cbxtiem2.Text = "Dia" Then
            lblr.Text = num1 * 365
        ElseIf cbxtiem1.Text = "Año natural" And cbxtiem2.Text = "Semana" Then
            lblr.Text = num1 * 52.143
        ElseIf cbxtiem1.Text = "Año natural" And cbxtiem2.Text = "Decada" Then
            lblr.Text = num1 / 10

            'Volumen
        ElseIf cbxvol1.Text = "Litro" And cbxvol2.Text = "Mililitro" Then
            lblr.Text = num1 * 1000
        ElseIf cbxvol1.Text = "Litro" And cbxvol2.Text = "Pie cubico" Then
            lblr.Text = num1 / 28.317
        ElseIf cbxvol1.Text = "Litro" And cbxvol2.Text = "Pulgada cubica" Then
            lblr.Text = num1 * 61.024
        ElseIf cbxvol1.Text = "Litro" And cbxvol2.Text = "Onza liquida imperial" Then
            lblr.Text = num1 * 35.195
        ElseIf cbxvol1.Text = "Litro" And cbxvol2.Text = "Metro cubico" Then
            lblr.Text = num1 / 1000
        ElseIf cbxvol1.Text = "Litro" And cbxvol2.Text = "Galon imperial" Then
            lblr.Text = num1 / 4.546
        ElseIf cbxvol1.Text = "Litro" And cbxvol2.Text = "Cuarto estadounidense" Then
            lblr.Text = num1 * 1.057
        ElseIf cbxvol1.Text = "Litro" And cbxvol2.Text = "Taza imperial" Then
            lblr.Text = num1 * 3.52
        ElseIf cbxvol1.Text = "Litro" And cbxvol2.Text = "Cucharada estadounidense" Then
            lblr.Text = num1 * 67.628
        ElseIf cbxvol1.Text = "Mililitro" And cbxvol2.Text = "Litro" Then
            lblr.Text = num1 / 1000
        ElseIf cbxvol1.Text = "Mililitro" And cbxvol2.Text = "Pie cubico" Then
            lblr.Text = num1 / 28317
        ElseIf cbxvol1.Text = "Mililitro" And cbxvol2.Text = "Onza liquida imperial" Then
            lblr.Text = num1 / 28.413
        ElseIf cbxvol1.Text = "Mililitro" And cbxvol2.Text = "Metro cubico" Then
            lblr.Text = num1 / 1000000.0
        ElseIf cbxvol1.Text = "Mililitro" And cbxvol2.Text = "Pulgada cubica" Then
            lblr.Text = num1 / 16.387
        ElseIf cbxvol1.Text = "Mililitro" And cbxvol2.Text = "Galon imperial" Then
            lblr.Text = num1 / 4546
        ElseIf cbxvol1.Text = "Mililitro" And cbxvol2.Text = "Cuarto estadounidense" Then
            lblr.Text = num1 / 946
        ElseIf cbxvol1.Text = "Mililitro" And cbxvol2.Text = "Taza imperial" Then
            lblr.Text = num1 / 284
        ElseIf cbxvol1.Text = "Mililitro" And cbxvol2.Text = "Cucharada estadounidense" Then
            lblr.Text = num1 / 14.787
        ElseIf cbxvol1.Text = "Pie cubico" And cbxvol2.Text = "Litro" Then
            lblr.Text = num1 * 28.317
        ElseIf cbxvol1.Text = "Pie cubico" And cbxvol2.Text = "Mililitro" Then
            lblr.Text = num1 * 28317
        ElseIf cbxvol1.Text = "Pie cubico" And cbxvol2.Text = "Pulgada cubica" Then
            lblr.Text = num1 * 1728
        ElseIf cbxvol1.Text = "Pie cubico" And cbxvol2.Text = "Onza liquida imperial" Then
            lblr.Text = num1 * 997
        ElseIf cbxvol1.Text = "Pie cubico" And cbxvol2.Text = "Metro cubico" Then
            lblr.Text = num1 / 35.315
        ElseIf cbxvol1.Text = "Pie cubico" And cbxvol2.Text = "Galon imperial" Then
            lblr.Text = num1 * 6.229
        ElseIf cbxvol1.Text = "Pie cubico" And cbxvol2.Text = "Cuarto estadounidense" Then
            lblr.Text = num1 * 29.922
        ElseIf cbxvol1.Text = "Pie cubico" And cbxvol2.Text = "Taza imperial" Then
            lblr.Text = num1 * 99.661
        ElseIf cbxvol1.Text = "Pie cubico" And cbxvol2.Text = "Cucharada estadounidense" Then
            lblr.Text = num1 * 1915
        ElseIf cbxvol1.Text = "Pulgada cubica" And cbxvol2.Text = "Litro" Then
            lblr.Text = num1 / 61.024
        ElseIf cbxvol1.Text = "Pulgada cubica" And cbxvol2.Text = "Mililitro" Then
            lblr.Text = num1 * 16.387
        ElseIf cbxvol1.Text = "Pulgada cubica" And cbxvol2.Text = "Pie cubico" Then
            lblr.Text = num1 / 1728
        ElseIf cbxvol1.Text = "Pulgada cubica" And cbxvol2.Text = "Onza liquida imperial" Then
            lblr.Text = num1 / 1.734
        ElseIf cbxvol1.Text = "Pulgada cubica" And cbxvol2.Text = "Metro cubico" Then
            lblr.Text = num1 * 1915
        ElseIf cbxvol1.Text = "Pulgada cubica" And cbxvol2.Text = "Galon imperial" Then
            lblr.Text = num1 / 61024
        ElseIf cbxvol1.Text = "Pulgada cubica" And cbxvol2.Text = "Cuarto estadounidense" Then
            lblr.Text = num1 / 57.75
        ElseIf cbxvol1.Text = "Pulgada cubica" And cbxvol2.Text = "Taza imperial" Then
            lblr.Text = num1 / 17.339
        ElseIf cbxvol1.Text = "Pulgada cubica" And cbxvol2.Text = "Cucharada estadounidense" Then
            lblr.Text = num1 * 1.108
        ElseIf cbxvol1.Text = "Onza liquida imperial" And cbxvol2.Text = "Litro" Then
            lblr.Text = num1 / 35.195
        ElseIf cbxvol1.Text = "Onza liquida imperial" And cbxvol2.Text = "Mililitro" Then
            lblr.Text = num1 * 28.413
        ElseIf cbxvol1.Text = "Onza liquida imperial" And cbxvol2.Text = "Pie cubico" Then
            lblr.Text = num1 / 997
        ElseIf cbxvol1.Text = "Onza liquida imperial" And cbxvol2.Text = "Pulgada cubica" Then
            lblr.Text = num1 * 1.734
        ElseIf cbxvol1.Text = "Onza liquida imperial" And cbxvol2.Text = "Metro cubico" Then
            lblr.Text = num1 / 35195
        ElseIf cbxvol1.Text = "Onza liquida imperial" And cbxvol2.Text = "Galon imperial" Then
            lblr.Text = num1 / 160
        ElseIf cbxvol1.Text = "Onza liquida imperial" And cbxvol2.Text = "Cuarto estadounidense" Then
            lblr.Text = num1 / 33.307
        ElseIf cbxvol1.Text = "Onza liquida imperial" And cbxvol2.Text = "Taza imperial" Then
            lblr.Text = num1 / 10
        ElseIf cbxvol1.Text = "Onza liquida imperial" And cbxvol2.Text = "Cucharada estadounidense" Then
            lblr.Text = num1 * 1.922
        ElseIf cbxvol1.Text = "Metro cubico" And cbxvol2.Text = "Litro" Then
            lblr.Text = num1 * 1000
        ElseIf cbxvol1.Text = "Metro cubico" And cbxvol2.Text = "Mililitro" Then
            lblr.Text = num1 * 1000000.0
        ElseIf cbxvol1.Text = "Metro cubico" And cbxvol2.Text = "Pie cubico" Then
            lblr.Text = num1 * 35.315
        ElseIf cbxvol1.Text = "Metro cubico" And cbxvol2.Text = "Pulgada cubica" Then
            lblr.Text = num1 * 61024
        ElseIf cbxvol1.Text = "Metro cubico" And cbxvol2.Text = "Onza liquida imperial" Then
            lblr.Text = num1 * 35195
        ElseIf cbxvol1.Text = "Metro cubico" And cbxvol2.Text = "Galon imperial" Then
            lblr.Text = num1 * 220
        ElseIf cbxvol1.Text = "Metro cubico" And cbxvol2.Text = "Cuarto estadounidense" Then
            lblr.Text = num1 * 1057
        ElseIf cbxvol1.Text = "Metro cubico" And cbxvol2.Text = "Taza imperial" Then
            lblr.Text = num1 * 3520
        ElseIf cbxvol1.Text = "Metro cubico" And cbxvol2.Text = "Cucharada estadounidense" Then
            lblr.Text = num1 * 67628
        ElseIf cbxvol1.Text = "Galon imperial" And cbxvol2.Text = "Litro" Then
            lblr.Text = num1 * 4.546
        ElseIf cbxvol1.Text = "Galon imperial" And cbxvol2.Text = "Mililitro" Then
            lblr.Text = num1 * 4546
        ElseIf cbxvol1.Text = "Galon imperial" And cbxvol2.Text = "Pie cubico" Then
            lblr.Text = num1 / 6.229
        ElseIf cbxvol1.Text = "Galon imperial" And cbxvol2.Text = "Pulgada cubica" Then
            lblr.Text = num1 * 277
        ElseIf cbxvol1.Text = "Galon imperial" And cbxvol2.Text = "Onza liquida imperial" Then
            lblr.Text = num1 * 160
        ElseIf cbxvol1.Text = "Galon imperial" And cbxvol2.Text = "Metro cubico" Then
            lblr.Text = num1 / 220
        ElseIf cbxvol1.Text = "Galon imperial" And cbxvol2.Text = "Cuarto estadounidense" Then
            lblr.Text = num1 * 4.804
        ElseIf cbxvol1.Text = "Galon imperial" And cbxvol2.Text = "Taza imperial" Then
            lblr.Text = num1 * 16
        ElseIf cbxvol1.Text = "Galon imperial" And cbxvol2.Text = "Cucharada estadounidense" Then
            lblr.Text = num1 * 307
        ElseIf cbxvol1.Text = "Cuarto estadounidense" And cbxvol2.Text = "Litro" Then
            lblr.Text = num1 / 1.057
        ElseIf cbxvol1.Text = "Cuarto estadounidense" And cbxvol2.Text = "Mililitro" Then
            lblr.Text = num1 * 946
        ElseIf cbxvol1.Text = "Cuarto estadounidense" And cbxvol2.Text = "Pie cubico" Then
            lblr.Text = num1 / 29.922
        ElseIf cbxvol1.Text = "Cuarto estadounidense" And cbxvol2.Text = "Pulgada cubica" Then
            lblr.Text = num1 * 57.75
        ElseIf cbxvol1.Text = "Cuarto estadounidense" And cbxvol2.Text = "Onza liquida imperial" Then
            lblr.Text = num1 * 33.307
        ElseIf cbxvol1.Text = "Cuarto estadounidense" And cbxvol2.Text = "Metro cubico" Then
            lblr.Text = num1 / 1057
        ElseIf cbxvol1.Text = "Cuarto estadounidense" And cbxvol2.Text = "Galon imperial" Then
            lblr.Text = num1 / 4.804
        ElseIf cbxvol1.Text = "Cuarto estadounidense" And cbxvol2.Text = "Taza imperial" Then
            lblr.Text = num1 * 3.331
        ElseIf cbxvol1.Text = "Cuarto estadounidense" And cbxvol2.Text = "Cucharada estadounidense" Then
            lblr.Text = num1 * 64
        ElseIf cbxvol1.Text = "Taza imperial" And cbxvol2.Text = "Litro" Then
            lblr.Text = num1 / 3.52
        ElseIf cbxvol1.Text = "Taza imperial" And cbxvol2.Text = "Mililitro" Then
            lblr.Text = num1 * 284
        ElseIf cbxvol1.Text = "Taza imperial" And cbxvol2.Text = "Pie cubico" Then
            lblr.Text = num1 / 99.661
        ElseIf cbxvol1.Text = "Taza imperial" And cbxvol2.Text = "Pulgada cubica" Then
            lblr.Text = num1 * 17.339
        ElseIf cbxvol1.Text = "Taza imperial" And cbxvol2.Text = "Onza liquida imperial" Then
            lblr.Text = num1 * 10
        ElseIf cbxvol1.Text = "Taza imperial" And cbxvol2.Text = "Metro cubico" Then
            lblr.Text = num1 / 3520
        ElseIf cbxvol1.Text = "Taza imperial" And cbxvol2.Text = "Galon imperial" Then
            lblr.Text = num1 / 16
        ElseIf cbxvol1.Text = "Taza imperial" And cbxvol2.Text = "Cuarto estadounidense" Then
            lblr.Text = num1 / 3.331
        ElseIf cbxvol1.Text = "Taza imperial" And cbxvol2.Text = "Cucharada estadounidense" Then
            lblr.Text = num1 * 19.215
        ElseIf cbxvol1.Text = "Cucharada estadounidense" And cbxvol2.Text = "Litro" Then
            lblr.Text = num1 / 67.628
        ElseIf cbxvol1.Text = "Cucharada estadounidense" And cbxvol2.Text = "Mililitro" Then
            lblr.Text = num1 * 14.787
        ElseIf cbxvol1.Text = "Cucharada estadounidense" And cbxvol2.Text = "Pie cubico" Then
            lblr.Text = num1 / 1915
        ElseIf cbxvol1.Text = "Cucharada estadounidense" And cbxvol2.Text = "Pulgada cubica" Then
            lblr.Text = num1 / 1.108
        ElseIf cbxvol1.Text = "Cucharada estadounidense" And cbxvol2.Text = "Onza liquida imperial" Then
            lblr.Text = num1 / 1.922
        ElseIf cbxvol1.Text = "Cucharada estadounidense" And cbxvol2.Text = "Metro cubico" Then
            lblr.Text = num1 / 67628
        ElseIf cbxvol1.Text = "Cucharada estadounidense" And cbxvol2.Text = "Galon imperial" Then
            lblr.Text = num1 / 307
        ElseIf cbxvol1.Text = "Cucharada estadounidense" And cbxvol2.Text = "Cuarto estadounidense" Then
            lblr.Text = num1 / 64
        ElseIf cbxvol1.Text = "Cucharada estadounidense" And cbxvol2.Text = "Taza imperial" Then
            lblr.Text = num1 / 19.215

            'Almacenamiento
        ElseIf cbxalma1.Text = "Bits" And cbxalma2.Text = "Bytes" Then
            lblr.Text = num1 / 8
        ElseIf cbxalma1.Text = "Bits" And cbxalma2.Text = "Gigabits" Then
            lblr.Text = num1 / 1073741824
        ElseIf cbxalma1.Text = "Bits" And cbxalma2.Text = "Gigabytes" Then
            lblr.Text = num1 / 8589934592
        ElseIf cbxalma1.Text = "Bits" And cbxalma2.Text = "Kilobits" Then
            lblr.Text = num1 / 1024
        ElseIf cbxalma1.Text = "Bits" And cbxalma2.Text = "Kilobytes" Then
            lblr.Text = num1 / 8192
        ElseIf cbxalma1.Text = "Bits" And cbxalma2.Text = "Megabits" Then
            lblr.Text = num1 / 1048576
        ElseIf cbxalma1.Text = "Bits" And cbxalma2.Text = "Megabytes" Then
            lblr.Text = num1 / 8388608
        ElseIf cbxalma1.Text = "Bits" And cbxalma2.Text = "Petabits" Then
            lblr.Text = num1 / 1125899906842620
        ElseIf cbxalma1.Text = "Bits" And cbxalma2.Text = "Petabytes" Then
            lblr.Text = num1 / 9007199254740990
        ElseIf cbxalma1.Text = "Bytes" And cbxalma2.Text = "Bits" Then
            lblr.Text = num1 * 8
        ElseIf cbxalma1.Text = "Bytes" And cbxalma2.Text = "Gigabits" Then
            lblr.Text = num1 / 134217728
        ElseIf cbxalma1.Text = "Bytes" And cbxalma2.Text = "Gigabytes" Then
            lblr.Text = num1 / 1073741824
        ElseIf cbxalma1.Text = "Bytes" And cbxalma2.Text = "Kilobits" Then
            lblr.Text = num1 / 128
        ElseIf cbxalma1.Text = "Bytes" And cbxalma2.Text = "Kilobytes" Then
            lblr.Text = num1 / 1000
        ElseIf cbxalma1.Text = "Bytes" And cbxalma2.Text = "Megabits" Then
            lblr.Text = num1 / 131072
        ElseIf cbxalma1.Text = "Bytes" And cbxalma2.Text = "Megabytes" Then
            lblr.Text = num1 / 1048576
        ElseIf cbxalma1.Text = "Bytes" And cbxalma2.Text = "Petabits" Then
            lblr.Text = num1 / 140737488355328
        ElseIf cbxalma1.Text = "Bytes" And cbxalma2.Text = "Petabytes" Then
            lblr.Text = num1 / 1125899906842620
        ElseIf cbxalma1.Text = "Bytes" And cbxalma2.Text = "Petabytes" Then
            lblr.Text = num1 / 1125899906842620
        ElseIf cbxalma1.Text = "Gigabits" And cbxalma2.Text = "Bits" Then
            lblr.Text = num1 * 1073741824
        ElseIf cbxalma1.Text = "Gigabits" And cbxalma2.Text = "Bytes" Then
            lblr.Text = num1 * 134217728
        ElseIf cbxalma1.Text = "Gigabits" And cbxalma2.Text = "Gigabytes" Then
            lblr.Text = num1 / 8
        ElseIf cbxalma1.Text = "Gigabits" And cbxalma2.Text = "Kilobits" Then
            lblr.Text = num1 * 1048576
        ElseIf cbxalma1.Text = "Gigabits" And cbxalma2.Text = "Kilobytes" Then
            lblr.Text = num1 * 131072
        ElseIf cbxalma1.Text = "Gigabits" And cbxalma2.Text = "Megabits" Then
            lblr.Text = num1 * 1024
        ElseIf cbxalma1.Text = "Gigabits" And cbxalma2.Text = "Megabytes" Then
            lblr.Text = num1 * 128
        ElseIf cbxalma1.Text = "Gigabits" And cbxalma2.Text = "Petabits" Then
            lblr.Text = num1 / 1048576
        ElseIf cbxalma1.Text = "Gigabits" And cbxalma2.Text = "Petabytes" Then
            lblr.Text = num1 / 8388608
        ElseIf cbxalma1.Text = "Gigabytes" And cbxalma2.Text = "Bits" Then
            lblr.Text = num1 * 8589934592
        ElseIf cbxalma1.Text = "Gigabytes" And cbxalma2.Text = "Bytes" Then
            lblr.Text = num1 * 1073741824
        ElseIf cbxalma1.Text = "Gigabytes" And cbxalma2.Text = "Gigabits" Then
            lblr.Text = num1 * 8
        ElseIf cbxalma1.Text = "Gigabytes" And cbxalma2.Text = "Kilobits" Then
            lblr.Text = num1 * 8388608
        ElseIf cbxalma1.Text = "Gigabytes" And cbxalma2.Text = "Kilobytes" Then
            lblr.Text = num1 * 1048576
        ElseIf cbxalma1.Text = "Gigabytes" And cbxalma2.Text = "Megabits" Then
            lblr.Text = num1 * 8192
        ElseIf cbxalma1.Text = "Gigabytes" And cbxalma2.Text = "Megabytes" Then
            lblr.Text = num1 * 1024
        ElseIf cbxalma1.Text = "Gigabytes" And cbxalma2.Text = "Petabits" Then
            lblr.Text = num1 / 131072
        ElseIf cbxalma1.Text = "Gigabytes" And cbxalma2.Text = "Petabytes" Then
            lblr.Text = num1 / 1048576
        ElseIf cbxalma1.Text = "Kilobits" And cbxalma2.Text = "Bits" Then
            lblr.Text = num1 * 1024
        ElseIf cbxalma1.Text = "Kilobits" And cbxalma2.Text = "Bytes" Then
            lblr.Text = num1 * 128
        ElseIf cbxalma1.Text = "Kilobits" And cbxalma2.Text = "Gigabits" Then
            lblr.Text = num1 / 1048576
        ElseIf cbxalma1.Text = "Kilobits" And cbxalma2.Text = "Gigabytes" Then
            lblr.Text = num1 / 8388608
        ElseIf cbxalma1.Text = "Kilobits" And cbxalma2.Text = "Kilobytes" Then
            lblr.Text = num1 / 8
        ElseIf cbxalma1.Text = "Kilobits" And cbxalma2.Text = "Megabits" Then
            lblr.Text = num1 / 1024
        ElseIf cbxalma1.Text = "Kilobits" And cbxalma2.Text = "Megabytes" Then
            lblr.Text = num1 / 8192
        ElseIf cbxalma1.Text = "Kilobits" And cbxalma2.Text = "Petabits" Then
            lblr.Text = num1 / 1099511627776
        ElseIf cbxalma1.Text = "Kilobits" And cbxalma2.Text = "Petabytes" Then
            lblr.Text = num1 / 8796093022208
        ElseIf cbxalma1.Text = "Kilobytes" And cbxalma2.Text = "Bits" Then
            lblr.Text = num1 * 8192
        ElseIf cbxalma1.Text = "Kilobytes" And cbxalma2.Text = "Bytes" Then
            lblr.Text = num1 * 1000
        ElseIf cbxalma1.Text = "Kilobytes" And cbxalma2.Text = "Gigabits" Then
            lblr.Text = num1 / 131072
        ElseIf cbxalma1.Text = "Kilobytes" And cbxalma2.Text = "Gigabytes" Then
            lblr.Text = num1 / 1048576
        ElseIf cbxalma1.Text = "Kilobytes" And cbxalma2.Text = "Kilobits" Then
            lblr.Text = num1 * 8
        ElseIf cbxalma1.Text = "Kilobytes" And cbxalma2.Text = "Megabits" Then
            lblr.Text = num1 / 128
        ElseIf cbxalma1.Text = "Kilobytes" And cbxalma2.Text = "Megabytes" Then
            lblr.Text = num1 / 1024
        ElseIf cbxalma1.Text = "Kilobytes" And cbxalma2.Text = "Petabits" Then
            lblr.Text = num1 / 137438953472
        ElseIf cbxalma1.Text = "Kilobytes" And cbxalma2.Text = "Petabytes" Then
            lblr.Text = num1 / 1099511627776
        ElseIf cbxalma1.Text = "Megabits" And cbxalma2.Text = "Bits" Then
            lblr.Text = num1 * 1048576
        ElseIf cbxalma1.Text = "Megabits" And cbxalma2.Text = "Bytes" Then
            lblr.Text = num1 * 131072
        ElseIf cbxalma1.Text = "Megabits" And cbxalma2.Text = "Gigabits" Then
            lblr.Text = num1 / 1024
        ElseIf cbxalma1.Text = "Megabits" And cbxalma2.Text = "Gigabytes" Then
            lblr.Text = num1 / 8192
        ElseIf cbxalma1.Text = "Megabits" And cbxalma2.Text = "Kilobits" Then
            lblr.Text = num1 * 1024
        ElseIf cbxalma1.Text = "Megabits" And cbxalma2.Text = "Kilobytes" Then
            lblr.Text = num1 * 128
        ElseIf cbxalma1.Text = "Megabits" And cbxalma2.Text = "Megabytes" Then
            lblr.Text = num1 / 8
        ElseIf cbxalma1.Text = "Megabits" And cbxalma2.Text = "Petabits" Then
            lblr.Text = num1 / 1073741824
        ElseIf cbxalma1.Text = "Megabits" And cbxalma2.Text = "Petabytes" Then
            lblr.Text = num1 / 8589934592
        ElseIf cbxalma1.Text = "Megabytes" And cbxalma2.Text = "Bits" Then
            lblr.Text = num1 * 8388608
        ElseIf cbxalma1.Text = "Megabytes" And cbxalma2.Text = "Bytes" Then
            lblr.Text = num1 * 1048576
        ElseIf cbxalma1.Text = "Megabytes" And cbxalma2.Text = "Gigabits" Then
            lblr.Text = num1 / 128
        ElseIf cbxalma1.Text = "Megabytes" And cbxalma2.Text = "Gigabytes" Then
            lblr.Text = num1 / 1024
        ElseIf cbxalma1.Text = "Megabytes" And cbxalma2.Text = "Kilobits" Then
            lblr.Text = num1 * 8192
        ElseIf cbxalma1.Text = "Megabytes" And cbxalma2.Text = "Kilobytes" Then
            lblr.Text = num1 * 1024
        ElseIf cbxalma1.Text = "Megabytes" And cbxalma2.Text = "Megabits" Then
            lblr.Text = num1 * 8
        ElseIf cbxalma1.Text = "Megabytes" And cbxalma2.Text = "Petabits" Then
            lblr.Text = num1 / 134217728
        ElseIf cbxalma1.Text = "Megabytes" And cbxalma2.Text = "Petabytes" Then
            lblr.Text = num1 / 1073741824
        ElseIf cbxalma1.Text = "Petabits" And cbxalma2.Text = "Bits" Then
            lblr.Text = num1 * 1125899906842620
        ElseIf cbxalma1.Text = "Petabits" And cbxalma2.Text = "Bytes" Then
            lblr.Text = num1 * 140737488355328
        ElseIf cbxalma1.Text = "Petabits" And cbxalma2.Text = "Gigabits" Then
            lblr.Text = num1 * 1048576
        ElseIf cbxalma1.Text = "Petabits" And cbxalma2.Text = "Gigabytes" Then
            lblr.Text = num1 * 131072
        ElseIf cbxalma1.Text = "Petabits" And cbxalma2.Text = "Kilobits" Then
            lblr.Text = num1 * 1099511627776
        ElseIf cbxalma1.Text = "Petabits" And cbxalma2.Text = "Kilobytes" Then
            lblr.Text = num1 * 137438953472
        ElseIf cbxalma1.Text = "Petabits" And cbxalma2.Text = "Megabits" Then
            lblr.Text = num1 * 1073741824
        ElseIf cbxalma1.Text = "Petabits" And cbxalma2.Text = "Megabytes" Then
            lblr.Text = num1 * 134217728
        ElseIf cbxalma1.Text = "Petabits" And cbxalma2.Text = "Petabytes" Then
            lblr.Text = num1 / 8
        ElseIf cbxalma1.Text = "Petabytes" And cbxalma2.Text = "Bits" Then
            lblr.Text = num1 * 9007199254740990
        ElseIf cbxalma1.Text = "Petabytes" And cbxalma2.Text = "Bytes" Then
            lblr.Text = num1 * 1125899906842620
        ElseIf cbxalma1.Text = "Petabytes" And cbxalma2.Text = "Gigabits" Then
            lblr.Text = num1 * 8388608
        ElseIf cbxalma1.Text = "Petabytes" And cbxalma2.Text = "Gigabytes" Then
            lblr.Text = num1 * 1048576
        ElseIf cbxalma1.Text = "Petabytes" And cbxalma2.Text = "Kilobits" Then
            lblr.Text = num1 * 8796093022208
        ElseIf cbxalma1.Text = "Petabytes" And cbxalma2.Text = "Kilobytes" Then
            lblr.Text = num1 * 1099511627776
        ElseIf cbxalma1.Text = "Petabytes" And cbxalma2.Text = "Megabits" Then
            lblr.Text = num1 * 8589934592
        ElseIf cbxalma1.Text = "Petabytes" And cbxalma2.Text = "Megabytes" Then
            lblr.Text = num1 * 1073741824
        ElseIf cbxalma1.Text = "Petabytes" And cbxalma2.Text = "Petabits" Then
            lblr.Text = num1 * 8

            'Longitud
        ElseIf cbxlongi1.Text = "Metro" And cbxlongi2.Text = "Centimetro" Then
            lblr.Text = num1 * 100
        ElseIf cbxlongi1.Text = "Metro" And cbxlongi2.Text = "Milimetro" Then
            lblr.Text = num1 * 1000
        ElseIf cbxlongi1.Text = "Metro" And cbxlongi2.Text = "Milla" Then
            lblr.Text = num1 / 1609
        ElseIf cbxlongi1.Text = "Metro" And cbxlongi2.Text = "Yarda" Then
            lblr.Text = num1 * 1.094
        ElseIf cbxlongi1.Text = "Metro" And cbxlongi2.Text = "Pie" Then
            lblr.Text = num1 * 3.281
        ElseIf cbxlongi1.Text = "Metro" And cbxlongi2.Text = "Pulgada" Then
            lblr.Text = num1 * 39.37
        ElseIf cbxlongi1.Text = "Metro" And cbxlongi2.Text = "Kilometro" Then
            lblr.Text = num1 / 1000
        ElseIf cbxlongi1.Text = "Metro" And cbxlongi2.Text = "Nanometro" Then
            lblr.Text = num1 * 1000000000.0
        ElseIf cbxlongi1.Text = "Metro" And cbxlongi2.Text = "Micrometro" Then
            lblr.Text = num1 * 1000000.0
        ElseIf cbxlongi1.Text = "Centimetro" And cbxlongi2.Text = "Metro" Then
            lblr.Text = num1 / 100
        ElseIf cbxlongi1.Text = "Centimetro" And cbxlongi2.Text = "Milimetro" Then
            lblr.Text = num1 * 10
        ElseIf cbxlongi1.Text = "Centimetro" And cbxlongi2.Text = "Milla" Then
            lblr.Text = num1 / 160934
        ElseIf cbxlongi1.Text = "Centimetro" And cbxlongi2.Text = "Yarda" Then
            lblr.Text = num1 / 91.44
        ElseIf cbxlongi1.Text = "Centimetro" And cbxlongi2.Text = "Pie" Then
            lblr.Text = num1 / 30.48
        ElseIf cbxlongi1.Text = "Centimetro" And cbxlongi2.Text = "Pulgada" Then
            lblr.Text = num1 / 2.54
        ElseIf cbxlongi1.Text = "Centimetro" And cbxlongi2.Text = "Kilometro" Then
            lblr.Text = num1 * 100000
        ElseIf cbxlongi1.Text = "Centimetro" And cbxlongi2.Text = "Nanometro" Then
            lblr.Text = num1 * 10000000.0
        ElseIf cbxlongi1.Text = "Centimetro" And cbxlongi2.Text = "Micrometro" Then
            lblr.Text = num1 * 10000
        ElseIf cbxlongi1.Text = "Milimetro" And cbxlongi2.Text = "Metro" Then
            lblr.Text = num1 / 1000
        ElseIf cbxlongi1.Text = "Milimetro" And cbxlongi2.Text = "Centimetro" Then
            lblr.Text = num1 / 10
        ElseIf cbxlongi1.Text = "Milimetro" And cbxlongi2.Text = "Milla" Then
            lblr.Text = num1 / 1609000.0
        ElseIf cbxlongi1.Text = "Milimetro" And cbxlongi2.Text = "Yarda" Then
            lblr.Text = num1 / 914
        ElseIf cbxlongi1.Text = "Milimetro" And cbxlongi2.Text = "Pie" Then
            lblr.Text = num1 / 305
        ElseIf cbxlongi1.Text = "Milimetro" And cbxlongi2.Text = "Pulgada" Then
            lblr.Text = num1 / 25.4
        ElseIf cbxlongi1.Text = "Milimetro" And cbxlongi2.Text = "Kilometro" Then
            lblr.Text = num1 / 1000000.0
        ElseIf cbxlongi1.Text = "Milimetro" And cbxlongi2.Text = "Nanometro" Then
            lblr.Text = num1 * 1000000.0
        ElseIf cbxlongi1.Text = "Milimetro" And cbxlongi2.Text = "Micrometro" Then
            lblr.Text = num1 * 1000
        ElseIf cbxlongi1.Text = "Milla" And cbxlongi2.Text = "Metro" Then
            lblr.Text = num1 * 1604.34
        ElseIf cbxlongi1.Text = "Milla" And cbxlongi2.Text = "Centimetro" Then
            lblr.Text = num1 * 160934
        ElseIf cbxlongi1.Text = "Milla" And cbxlongi2.Text = "Milimetro" Then
            lblr.Text = num1 * 1609000.0
        ElseIf cbxlongi1.Text = "Milla" And cbxlongi2.Text = "Yarda" Then
            lblr.Text = num1 * 1760
        ElseIf cbxlongi1.Text = "Milla" And cbxlongi2.Text = "Pie" Then
            lblr.Text = num1 * 5280
        ElseIf cbxlongi1.Text = "Milla" And cbxlongi2.Text = "Pulgada" Then
            lblr.Text = num1 * 63360
        ElseIf cbxlongi1.Text = "Milla" And cbxlongi2.Text = "Kilometro" Then
            lblr.Text = num1 * 1.60934
        ElseIf cbxlongi1.Text = "Milla" And cbxlongi2.Text = "Nanometro" Then
            lblr.Text = num1 * 1609000000000.0
        ElseIf cbxlongi1.Text = "Milla" And cbxlongi2.Text = "Micrometro" Then
            lblr.Text = num1 * 1609000000.0
        ElseIf cbxlongi1.Text = "Yarda" And cbxlongi2.Text = "Metro" Then
            lblr.Text = num1 * 0.9144
        ElseIf cbxlongi1.Text = "Yarda" And cbxlongi2.Text = "Centimetro" Then
            lblr.Text = num1 * 91.44
        ElseIf cbxlongi1.Text = "Yarda" And cbxlongi2.Text = "Milimetro" Then
            lblr.Text = num1 * 914.4
        ElseIf cbxlongi1.Text = "Yarda" And cbxlongi2.Text = "Milla" Then
            lblr.Text = num1 * 0.000568182
        ElseIf cbxlongi1.Text = "Yarda" And cbxlongi2.Text = "Pie" Then
            lblr.Text = num1 * 3
        ElseIf cbxlongi1.Text = "Yarda" And cbxlongi2.Text = "Pulgada" Then
            lblr.Text = num1 * 36
        ElseIf cbxlongi1.Text = "Yarda" And cbxlongi2.Text = "Kilometro" Then
            lblr.Text = num1 * 0.0009144
        ElseIf cbxlongi1.Text = "Yarda" And cbxlongi2.Text = "Nanometro" Then
            lblr.Text = num1 * 914400000.0
        ElseIf cbxlongi1.Text = "Yarda" And cbxlongi2.Text = "Micrometro" Then
            lblr.Text = num1 * 914400
        ElseIf cbxlongi1.Text = "Pie" And cbxlongi2.Text = "Metro" Then
            lblr.Text = num1 * 0.3048
        ElseIf cbxlongi1.Text = "Pie" And cbxlongi2.Text = "Centimetro" Then
            lblr.Text = num1 * 3048
        ElseIf cbxlongi1.Text = "Pie" And cbxlongi2.Text = "Milimetro" Then
            lblr.Text = num1 * 304.8
        ElseIf cbxlongi1.Text = "Pie" And cbxlongi2.Text = "Milla" Then
            lblr.Text = num1 * 0.000189394
        ElseIf cbxlongi1.Text = "Pie" And cbxlongi2.Text = "Yarda" Then
            lblr.Text = num1 / 3
        ElseIf cbxlongi1.Text = "Pie" And cbxlongi2.Text = "Pulgada" Then
            lblr.Text = num1 * 12
        ElseIf cbxlongi1.Text = "Pie" And cbxlongi2.Text = "Kilometro" Then
            lblr.Text = num1 * 0.0003048
        ElseIf cbxlongi1.Text = "Pie" And cbxlongi2.Text = "Nanometro" Then
            lblr.Text = num1 * 304800000.0
        ElseIf cbxlongi1.Text = "Pie" And cbxlongi2.Text = "Micrometro" Then
            lblr.Text = num1 * 304800
        ElseIf cbxlongi1.Text = "Pulgada" And cbxlongi2.Text = "Metro" Then
            lblr.Text = num1 * 0.0254
        ElseIf cbxlongi1.Text = "Pulgada" And cbxlongi2.Text = "Centimetro" Then
            lblr.Text = num1 * 2.54
        ElseIf cbxlongi1.Text = "Pulgada" And cbxlongi2.Text = "Milimetro" Then
            lblr.Text = num1 * 25.4
        ElseIf cbxlongi1.Text = "Pulgada" And cbxlongi2.Text = "Milla" Then
            lblr.Text = num1 * 0.000015783
        ElseIf cbxlongi1.Text = "Pulgada" And cbxlongi2.Text = "Yarda" Then
            lblr.Text = num1 * 0.0277778
        ElseIf cbxlongi1.Text = "Pulgada" And cbxlongi2.Text = "Pie" Then
            lblr.Text = num1 * 0.0833333
        ElseIf cbxlongi1.Text = "Pulgada" And cbxlongi2.Text = "Kilometro" Then
            lblr.Text = num1 * 0.0000254
        ElseIf cbxlongi1.Text = "Pulgada" And cbxlongi2.Text = "Nanometro" Then
            lblr.Text = num1 * 25400000.0
        ElseIf cbxlongi1.Text = "Pulgada" And cbxlongi2.Text = "Micrometro" Then
            lblr.Text = num1 * 25400
        ElseIf cbxlongi1.Text = "Kilometro" And cbxlongi2.Text = "Metro" Then
            lblr.Text = num1 * 1000
        ElseIf cbxlongi1.Text = "Kilometro" And cbxlongi2.Text = "Centimetro" Then
            lblr.Text = num1 * 100000
        ElseIf cbxlongi1.Text = "Kilometro" And cbxlongi2.Text = "Milimetro" Then
            lblr.Text = num1 * 1000000.0
        ElseIf cbxlongi1.Text = "Kilometro" And cbxlongi2.Text = "Milla" Then
            lblr.Text = num1 * 0.621371
        ElseIf cbxlongi1.Text = "Kilometro" And cbxlongi2.Text = "Yarda" Then
            lblr.Text = num1 * 1093.61
        ElseIf cbxlongi1.Text = "Kilometro" And cbxlongi2.Text = "Pie" Then
            lblr.Text = num1 * 3280.84
        ElseIf cbxlongi1.Text = "Kilometro" And cbxlongi2.Text = "Pulgada" Then
            lblr.Text = num1 * 39370.1
        ElseIf cbxlongi1.Text = "Kilometro" And cbxlongi2.Text = "Nanometro" Then
            lblr.Text = num1 * 1000000000000.0
        ElseIf cbxlongi1.Text = "Kilometro" And cbxlongi2.Text = "Micrometro" Then
            lblr.Text = num1 * 1000000000.0
        ElseIf cbxlongi1.Text = "Nanometro" And cbxlongi2.Text = "Metro" Then
            lblr.Text = num1 * 0.000000001
        ElseIf cbxlongi1.Text = "Nanometro" And cbxlongi2.Text = "Centimetro" Then
            lblr.Text = num1 * 0.0000001
        ElseIf cbxlongi1.Text = "Nanometro" And cbxlongi2.Text = "Milimetro" Then
            lblr.Text = num1 * 0.000001
        ElseIf cbxlongi1.Text = "Nanometro" And cbxlongi2.Text = "Milla" Then
            lblr.Text = num1 * 0.00000000000062137
        ElseIf cbxlongi1.Text = "Nanometro" And cbxlongi2.Text = "Yarda" Then
            lblr.Text = num1 * 0.0000000010936
        ElseIf cbxlongi1.Text = "Nanometro" And cbxlongi2.Text = "Pie" Then
            lblr.Text = num1 * 0.0000000032808
        ElseIf cbxlongi1.Text = "Nanometro" And cbxlongi2.Text = "Pulgada" Then
            lblr.Text = num1 * 0.00000003937
        ElseIf cbxlongi1.Text = "Nanometro" And cbxlongi2.Text = "Kilometro" Then
            lblr.Text = num1 * 0.000000000001
        ElseIf cbxlongi1.Text = "Nanometro" And cbxlongi2.Text = "Micrometro" Then
            lblr.Text = num1 * 0.001
        ElseIf cbxlongi1.Text = "Micrometro" And cbxlongi2.Text = "Metro" Then
            lblr.Text = num1 * 0.000001
        ElseIf cbxlongi1.Text = "Micrometro" And cbxlongi2.Text = "Centimetro" Then
            lblr.Text = num1 * 0.0001
        ElseIf cbxlongi1.Text = "Micrometro" And cbxlongi2.Text = "Milimetro" Then
            lblr.Text = num1 * 0.001
        ElseIf cbxlongi1.Text = "Micrometro" And cbxlongi2.Text = "Milla" Then
            lblr.Text = num1 * 0.00000000062137
        ElseIf cbxlongi1.Text = "Micrometro" And cbxlongi2.Text = "Yarda" Then
            lblr.Text = num1 * 0.0000010936
        ElseIf cbxlongi1.Text = "Micrometro" And cbxlongi2.Text = "Pie" Then
            lblr.Text = num1 * 0.000016404
        ElseIf cbxlongi1.Text = "Micrometro" And cbxlongi2.Text = "Pulgada" Then
            lblr.Text = num1 * 0.00003937
        ElseIf cbxlongi1.Text = "Micrometro" And cbxlongi2.Text = "Kilometro" Then
            lblr.Text = num1 * 0.000000001
        ElseIf cbxlongi1.Text = "Micrometro" And cbxlongi2.Text = "Nanometro" Then
            lblr.Text = num1 * 1000

            'Masa
        ElseIf cbxmasa1.Text = "Kilogramos" And cbxmasa2.Text = "Hectogramos" Then
            lblr.Text = num1 * 10
        ElseIf cbxmasa1.Text = "Kilogramos" And cbxmasa2.Text = "Decagramos" Then
            lblr.Text = num1 * 100
        ElseIf cbxmasa1.Text = "Kilogramos" And cbxmasa2.Text = "Gramos" Then
            lblr.Text = num1 * 1000
        ElseIf cbxmasa1.Text = "Kilogramos" And cbxmasa2.Text = "Decigramos" Then
            lblr.Text = num1 * 10000
        ElseIf cbxmasa1.Text = "Kilogramos" And cbxmasa2.Text = "Centigramos" Then
            lblr.Text = num1 * 100000
        ElseIf cbxmasa1.Text = "Kilogramos" And cbxmasa2.Text = "Miligramos" Then
            lblr.Text = num1 * 1000000.0
        ElseIf cbxmasa1.Text = "Kilogramos" And cbxmasa2.Text = "Libras" Then
            lblr.Text = num1 * 2.205
        ElseIf cbxmasa1.Text = "Kilogramos" And cbxmasa2.Text = "Onzas" Then
            lblr.Text = num1 * 35.274
        ElseIf cbxmasa1.Text = "Kilogramos" And cbxmasa2.Text = "Quilates" Then
            lblr.Text = num1 * 5000
        ElseIf cbxmasa1.Text = "Hectogramos" And cbxmasa2.Text = "Kilogramos" Then
            lblr.Text = num1 / 10
        ElseIf cbxmasa1.Text = "Hectogramos" And cbxmasa2.Text = "Decagramos" Then
            lblr.Text = num1 * 10
        ElseIf cbxmasa1.Text = "Hectogramos" And cbxmasa2.Text = "Gramos" Then
            lblr.Text = num1 * 100
        ElseIf cbxmasa1.Text = "Hectogramos" And cbxmasa2.Text = "Decigramos" Then
            lblr.Text = num1 * 1000
        ElseIf cbxmasa1.Text = "Hectogramos" And cbxmasa2.Text = "Centigramos" Then
            lblr.Text = num1 * 10000
        ElseIf cbxmasa1.Text = "Hectogramos" And cbxmasa2.Text = "Miligramos" Then
            lblr.Text = num1 * 100000
        ElseIf cbxmasa1.Text = "Hectogramos" And cbxmasa2.Text = "Libras" Then
            lblr.Text = num1 / 4.536
        ElseIf cbxmasa1.Text = "Hectogramos" And cbxmasa2.Text = "Onzas" Then
            lblr.Text = num1 * 3.527
        ElseIf cbxmasa1.Text = "Hectogramos" And cbxmasa2.Text = "Quilates" Then
            lblr.Text = num1 * 500
        ElseIf cbxmasa1.Text = "Decagramos" And cbxmasa2.Text = "Kilogramos" Then
            lblr.Text = num1 / 100
        ElseIf cbxmasa1.Text = "Decagramos" And cbxmasa2.Text = "Hectogramos" Then
            lblr.Text = num1 / 10
        ElseIf cbxmasa1.Text = "Decagramos" And cbxmasa2.Text = "Gramos" Then
            lblr.Text = num1 * 10
        ElseIf cbxmasa1.Text = "Decagramos" And cbxmasa2.Text = "Decigramos" Then
            lblr.Text = num1 * 100
        ElseIf cbxmasa1.Text = "Decagramos" And cbxmasa2.Text = "Centigramos" Then
            lblr.Text = num1 * 1000
        ElseIf cbxmasa1.Text = "Decagramos" And cbxmasa2.Text = "Miligramos" Then
            lblr.Text = num1 * 10000
        ElseIf cbxmasa1.Text = "Decagramos" And cbxmasa2.Text = "Libras" Then
            lblr.Text = num1 / 45.359
        ElseIf cbxmasa1.Text = "Decagramos" And cbxmasa2.Text = "Onzas" Then
            lblr.Text = num1 / 2.835
        ElseIf cbxmasa1.Text = "Decagramos" And cbxmasa2.Text = "Quilates" Then
            lblr.Text = num1 * 50
        ElseIf cbxmasa1.Text = "Gramos" And cbxmasa2.Text = "Kilogramos" Then
            lblr.Text = num1 * 1000
        ElseIf cbxmasa1.Text = "Gramos" And cbxmasa2.Text = "Hectogramos" Then
            lblr.Text = num1 / 100
        ElseIf cbxmasa1.Text = "Gramos" And cbxmasa2.Text = "Decagramos" Then
            lblr.Text = num1 / 10
        ElseIf cbxmasa1.Text = "Gramos" And cbxmasa2.Text = "Decigramos" Then
            lblr.Text = num1 * 10
        ElseIf cbxmasa1.Text = "Gramos" And cbxmasa2.Text = "Centigramos" Then
            lblr.Text = num1 * 100
        ElseIf cbxmasa1.Text = "Gramos" And cbxmasa2.Text = "Miligramos" Then
            lblr.Text = num1 * 1000
        ElseIf cbxmasa1.Text = "Gramos" And cbxmasa2.Text = "Libras" Then
            lblr.Text = num1 / 454
        ElseIf cbxmasa1.Text = "Gramos" And cbxmasa2.Text = "Onzas" Then
            lblr.Text = num1 / 28.35
        ElseIf cbxmasa1.Text = "Gramos" And cbxmasa2.Text = "Quilates" Then
            lblr.Text = num1 * 5
        ElseIf cbxmasa1.Text = "Decigramos" And cbxmasa2.Text = "Kilogramos" Then
            lblr.Text = num1 * 10000
        ElseIf cbxmasa1.Text = "Decigramos" And cbxmasa2.Text = "Hectogramos" Then
            lblr.Text = num1 / 1000
        ElseIf cbxmasa1.Text = "Decigramos" And cbxmasa2.Text = "Decagramos" Then
            lblr.Text = num1 / 100
        ElseIf cbxmasa1.Text = "Decigramos" And cbxmasa2.Text = "Gramos" Then
            lblr.Text = num1 / 10
        ElseIf cbxmasa1.Text = "Decigramos" And cbxmasa2.Text = "Centigramos" Then
            lblr.Text = num1 * 10
        ElseIf cbxmasa1.Text = "Decigramos" And cbxmasa2.Text = "Miligramos" Then
            lblr.Text = num1 * 100
        ElseIf cbxmasa1.Text = "Decigramos" And cbxmasa2.Text = "Libras" Then
            lblr.Text = num1 / 4536
        ElseIf cbxmasa1.Text = "Decigramos" And cbxmasa2.Text = "Onzas" Then
            lblr.Text = num1 / 283
        ElseIf cbxmasa1.Text = "Decigramos" And cbxmasa2.Text = "Quilates" Then
            lblr.Text = num1 / 2
        ElseIf cbxmasa1.Text = "Centigramos" And cbxmasa2.Text = "Kilogramos" Then
            lblr.Text = num1 * 100000
        ElseIf cbxmasa1.Text = "Centigramos" And cbxmasa2.Text = "Hectogramos" Then
            lblr.Text = num1 / 10000
        ElseIf cbxmasa1.Text = "Centigramos" And cbxmasa2.Text = "Decagramos" Then
            lblr.Text = num1 / 1000
        ElseIf cbxmasa1.Text = "Centigramos" And cbxmasa2.Text = "Gramos" Then
            lblr.Text = num1 / 100
        ElseIf cbxmasa1.Text = "Centigramos" And cbxmasa2.Text = "Decigramos" Then
            lblr.Text = num1 / 10
        ElseIf cbxmasa1.Text = "Centigramos" And cbxmasa2.Text = "Miligramos" Then
            lblr.Text = num1 * 10
        ElseIf cbxmasa1.Text = "Centimetro" And cbxmasa2.Text = "Libras" Then
            lblr.Text = num1 / 45359
        ElseIf cbxmasa1.Text = "Centimetro" And cbxmasa2.Text = "Onzas" Then
            lblr.Text = num1 / 2835
        ElseIf cbxmasa1.Text = "Centimetro" And cbxmasa2.Text = "Quilates" Then
            lblr.Text = num1 / 20
        ElseIf cbxmasa1.Text = "Miligramos" And cbxmasa2.Text = "Kilogramos" Then
            lblr.Text = num1 / 1000000.0
        ElseIf cbxmasa1.Text = "Miligramos" And cbxmasa2.Text = "Hectogramos" Then
            lblr.Text = num1 / 100000
        ElseIf cbxmasa1.Text = "Miligramos" And cbxmasa2.Text = "Decagramos" Then
            lblr.Text = num1 / 10000
        ElseIf cbxmasa1.Text = "Miligramos" And cbxmasa2.Text = "Gramos" Then
            lblr.Text = num1 / 1000
        ElseIf cbxmasa1.Text = "Miligramos" And cbxmasa2.Text = "Decigramos" Then
            lblr.Text = num1 / 100
        ElseIf cbxmasa1.Text = "Miligramos" And cbxmasa2.Text = "Centigramos" Then
            lblr.Text = num1 / 10
        ElseIf cbxmasa1.Text = "Miligramos" And cbxmasa2.Text = "Libras" Then
            lblr.Text = num1 / 453592
        ElseIf cbxmasa1.Text = "Miligramos" And cbxmasa2.Text = "Onzas" Then
            lblr.Text = num1 / 28350
        ElseIf cbxmasa1.Text = "Miligramos" And cbxmasa2.Text = "Quilates" Then
            lblr.Text = num1 / 200
        ElseIf cbxmasa1.Text = "Libras" And cbxmasa2.Text = "Kilogramos" Then
            lblr.Text = num1 / 2.205
        ElseIf cbxmasa1.Text = "Libras" And cbxmasa2.Text = "Hectogramos" Then
            lblr.Text = num1 * 4.536
        ElseIf cbxmasa1.Text = "Libras" And cbxmasa2.Text = "Decagramos" Then
            lblr.Text = num1 * 45.359
        ElseIf cbxmasa1.Text = "Libras" And cbxmasa2.Text = "Gramos" Then
            lblr.Text = num1 / 454
        ElseIf cbxmasa1.Text = "Libras" And cbxmasa2.Text = "Decigramos" Then
            lblr.Text = num1 * 4536
        ElseIf cbxmasa1.Text = "Libras" And cbxmasa2.Text = "Centigramos" Then
            lblr.Text = num1 * 45359
        ElseIf cbxmasa1.Text = "Libras" And cbxmasa2.Text = "Miligramos" Then
            lblr.Text = num1 * 453592
        ElseIf cbxmasa1.Text = "Libras" And cbxmasa2.Text = "Onzas" Then
            lblr.Text = num1 * 16
        ElseIf cbxmasa1.Text = "Libras" And cbxmasa2.Text = "Quilates" Then
            lblr.Text = num1 * 2268
        ElseIf cbxmasa1.Text = "Onzas" And cbxmasa2.Text = "Kilogramos" Then
            lblr.Text = num1 / 35.274
        ElseIf cbxmasa1.Text = "Onzas" And cbxmasa2.Text = "Hectogramos" Then
            lblr.Text = num1 / 3.527
        ElseIf cbxmasa1.Text = "Onzas" And cbxmasa2.Text = "Decagramos" Then
            lblr.Text = num1 * 2.835
        ElseIf cbxmasa1.Text = "Onzas" And cbxmasa2.Text = "Gramos" Then
            lblr.Text = num1 * 28.35
        ElseIf cbxmasa1.Text = "Onzas" And cbxmasa2.Text = "Decigramos" Then
            lblr.Text = num1 * 283
        ElseIf cbxmasa1.Text = "Onzas" And cbxmasa2.Text = "Centigramos" Then
            lblr.Text = num1 * 2835
        ElseIf cbxmasa1.Text = "Onzas" And cbxmasa2.Text = "Miligramos" Then
            lblr.Text = num1 * 28350
        ElseIf cbxmasa1.Text = "Onzas" And cbxmasa2.Text = "Libras" Then
            lblr.Text = num1 / 16
        ElseIf cbxmasa1.Text = "Onzas" And cbxmasa2.Text = "Quilates" Then
            lblr.Text = num1 * 142
        ElseIf cbxmasa1.Text = "Quilates" And cbxmasa2.Text = "Kilogramos" Then
            lblr.Text = num1 / 5000
        ElseIf cbxmasa1.Text = "Quilates" And cbxmasa2.Text = "Hectogramos" Then
            lblr.Text = num1 / 500
        ElseIf cbxmasa1.Text = "Quilates" And cbxmasa2.Text = "Decagramos" Then
            lblr.Text = num1 / 50
        ElseIf cbxmasa1.Text = "Quilates" And cbxmasa2.Text = "Gramos" Then
            lblr.Text = num1 / 5
        ElseIf cbxmasa1.Text = "Quilates" And cbxmasa2.Text = "Decigramos" Then
            lblr.Text = num1 * 2
        ElseIf cbxmasa1.Text = "Quilates" And cbxmasa2.Text = "Centigramos" Then
            lblr.Text = num1 * 20
        ElseIf cbxmasa1.Text = "Quilates" And cbxmasa2.Text = "Miligramos" Then
            lblr.Text = num1 * 200
        ElseIf cbxmasa1.Text = "Quilates" And cbxmasa2.Text = "Libras" Then
            lblr.Text = num1 / 2268
        ElseIf cbxmasa1.Text = "Quilates" And cbxmasa2.Text = "Onzas" Then
            lblr.Text = num1 / 142

            'Monedas
        ElseIf cbxmonedas1.Text = "Dolar estadounidense" And cbxmonedas2.Text = "Euro" Then
            lblr.Text = num1 * 0.84
        ElseIf cbxmonedas1.Text = "Dolar estadounidense" And cbxmonedas2.Text = "Yen" Then
            lblr.Text = num1 * 106.01
        ElseIf cbxmonedas1.Text = "Dolar estadounidense" And cbxmonedas2.Text = "Lempira" Then
            lblr.Text = num1 * 24.77
        ElseIf cbxmonedas1.Text = "Dolar estadounidense" And cbxmonedas2.Text = "Yen" Then
            lblr.Text = num1 * 106.01
        ElseIf cbxmonedas1.Text = "Dolar estadounidense" And cbxmonedas2.Text = "Cordoba nicaraguense" Then
            lblr.Text = num1 * 34.55
        ElseIf cbxmonedas1.Text = "Dolar estadounidense" And cbxmonedas2.Text = "Quetzal" Then
            lblr.Text = num1 * 7.7
        ElseIf cbxmonedas1.Text = "Dolar estadounidense" And cbxmonedas2.Text = "Balboa" Then
            lblr.Text = num1 * 1.0
        ElseIf cbxmonedas1.Text = "Dolar estadounidense" And cbxmonedas2.Text = "Peso mexicano" Then
            lblr.Text = num1 * 22.12
        ElseIf cbxmonedas1.Text = "Dolar estadounidense" And cbxmonedas2.Text = "Libra esterlina" Then
            lblr.Text = num1 * 0.76
        ElseIf cbxmonedas1.Text = "Dolar estadounidense" And cbxmonedas2.Text = "Bolivar venezolano" Then
            lblr.Text = num1 * 283663.0
        ElseIf cbxmonedas1.Text = "Euro" And cbxmonedas2.Text = "Dolar estadounidense" Then
            lblr.Text = num1 * 1.19
        ElseIf cbxmonedas1.Text = "Euro" And cbxmonedas2.Text = "Yen" Then
            lblr.Text = num1 * 125.82
        ElseIf cbxmonedas1.Text = "Euro" And cbxmonedas2.Text = "Lempira" Then
            lblr.Text = num1 * 29.38
        ElseIf cbxmonedas1.Text = "Euro" And cbxmonedas2.Text = "Cordoba nicaraguense" Then
            lblr.Text = num1 * 41.07
        ElseIf cbxmonedas1.Text = "Euro" And cbxmonedas2.Text = "Quetzal" Then
            lblr.Text = num1 * 9.14
        ElseIf cbxmonedas1.Text = "Euro" And cbxmonedas2.Text = "Balboa" Then
            lblr.Text = num1 * 1.19
        ElseIf cbxmonedas1.Text = "Euro" And cbxmonedas2.Text = "Peso mexicano" Then
            lblr.Text = num1 * 26.32
        ElseIf cbxmonedas1.Text = "Euro" And cbxmonedas2.Text = "Libra esterlina" Then
            lblr.Text = num1 * 0.91
        ElseIf cbxmonedas1.Text = "Euro" And cbxmonedas2.Text = "Bolivar venezolano" Then
            lblr.Text = num1 * 336700.89
        ElseIf cbxmonedas1.Text = "Yen" And cbxmonedas2.Text = "Dolar estadounidense" Then
            lblr.Text = num1 * 0.0094
        ElseIf cbxmonedas1.Text = "Yen" And cbxmonedas2.Text = "Euro" Then
            lblr.Text = num1 * 0.0079
        ElseIf cbxmonedas1.Text = "Yen" And cbxmonedas2.Text = "Lempira" Then
            lblr.Text = num1 * 0.23
        ElseIf cbxmonedas1.Text = "Yen" And cbxmonedas2.Text = "Cordoba nicaraguense" Then
            lblr.Text = num1 * 0.33
        ElseIf cbxmonedas1.Text = "Yen" And cbxmonedas2.Text = "Quetzal" Then
            lblr.Text = num1 * 0.073
        ElseIf cbxmonedas1.Text = "Yen" And cbxmonedas2.Text = "Balboa" Then
            lblr.Text = num1 * 0.0094
        ElseIf cbxmonedas1.Text = "Yen" And cbxmonedas2.Text = "Peso mexicano" Then
            lblr.Text = num1 * 0.21
        ElseIf cbxmonedas1.Text = "Yen" And cbxmonedas2.Text = "Libra esterlina" Then
            lblr.Text = num1 * 0.0072
        ElseIf cbxmonedas1.Text = "Yen" And cbxmonedas2.Text = "Bolivar venezolano" Then
            lblr.Text = num1 * 2676.12
        ElseIf cbxmonedas1.Text = "Lempira" And cbxmonedas2.Text = "Dolar estadounidense" Then
            lblr.Text = num1 * 0.04
        ElseIf cbxmonedas1.Text = "Lempira" And cbxmonedas2.Text = "Euro" Then
            lblr.Text = num1 * 0.034
        ElseIf cbxmonedas1.Text = "Lempira" And cbxmonedas2.Text = "Yen" Then
            lblr.Text = num1 * 4.28
        ElseIf cbxmonedas1.Text = "Lempira" And cbxmonedas2.Text = "Cordoba nicaraguense" Then
            lblr.Text = num1 * 1.4
        ElseIf cbxmonedas1.Text = "Lempira" And cbxmonedas2.Text = "Quetzal" Then
            lblr.Text = num1 * 0.31
        ElseIf cbxmonedas1.Text = "Lempira" And cbxmonedas2.Text = "Balboa" Then
            lblr.Text = num1 * 0.04
        ElseIf cbxmonedas1.Text = "Lempira" And cbxmonedas2.Text = "Peso mexicano" Then
            lblr.Text = num1 * 0.9
        ElseIf cbxmonedas1.Text = "Lempira" And cbxmonedas2.Text = "Libra esterlina" Then
            lblr.Text = num1 * 0.031
        ElseIf cbxmonedas1.Text = "Lempira" And cbxmonedas2.Text = "Bolivar venezolano" Then
            lblr.Text = num1 * 11458.79
        ElseIf cbxmonedas1.Text = "Cordoba nicaraguense" And cbxmonedas2.Text = "Dolar estadounidense" Then
            lblr.Text = num1 * 0.029
        ElseIf cbxmonedas1.Text = "Cordoba nicaraguense" And cbxmonedas2.Text = "Euro" Then
            lblr.Text = num1 * 0.024
        ElseIf cbxmonedas1.Text = "Cordoba nicaraguense" And cbxmonedas2.Text = "Yen" Then
            lblr.Text = num1 * 3.06
        ElseIf cbxmonedas1.Text = "Cordoba nicaraguense" And cbxmonedas2.Text = "Lempira" Then
            lblr.Text = num1 * 0.72
        ElseIf cbxmonedas1.Text = "Cordoba nicaraguense" And cbxmonedas2.Text = "Quetzal" Then
            lblr.Text = num1 * 0.22
        ElseIf cbxmonedas1.Text = "Cordoba nicaraguense" And cbxmonedas2.Text = "Balboa" Then
            lblr.Text = num1 * 0.029
        ElseIf cbxmonedas1.Text = "Cordoba nicaraguense" And cbxmonedas2.Text = "Peso mexicano" Then
            lblr.Text = num1 * 0.64
        ElseIf cbxmonedas1.Text = "Cordoba nicaraguense" And cbxmonedas2.Text = "Libra esterlina" Then
            lblr.Text = num1 * 0.022
        ElseIf cbxmonedas1.Text = "Cordoba nicaraguense" And cbxmonedas2.Text = "Bolivar venezolano" Then
            lblr.Text = num1 * 8198.35
        ElseIf cbxmonedas1.Text = "Quetzal" And cbxmonedas2.Text = "Dolar estadounidense" Then
            lblr.Text = num1 * 0.13
        ElseIf cbxmonedas1.Text = "Quetzal" And cbxmonedas2.Text = "Euro" Then
            lblr.Text = num1 * 0.11
        ElseIf cbxmonedas1.Text = "Quetzal" And cbxmonedas2.Text = "Yen" Then
            lblr.Text = num1 * 13.77
        ElseIf cbxmonedas1.Text = "Quetzal" And cbxmonedas2.Text = "Lempira" Then
            lblr.Text = num1 * 3.22
        ElseIf cbxmonedas1.Text = "Quetzal" And cbxmonedas2.Text = "Cordoba nicaraguense" Then
            lblr.Text = num1 * 4.5
        ElseIf cbxmonedas1.Text = "Quetzal" And cbxmonedas2.Text = "Balboa" Then
            lblr.Text = num1 * 0.13
        ElseIf cbxmonedas1.Text = "Quetzal" And cbxmonedas2.Text = "Peso mexicano" Then
            lblr.Text = num1 * 2.88
        ElseIf cbxmonedas1.Text = "Quetzal" And cbxmonedas2.Text = "Libra esterlina" Then
            lblr.Text = num1 * 0.099
        ElseIf cbxmonedas1.Text = "Quetzal" And cbxmonedas2.Text = "Bolivar venezolano" Then
            lblr.Text = num1 * 36871.14
        ElseIf cbxmonedas1.Text = "Balboa" And cbxmonedas2.Text = "Dolar estadounidense" Then
            lblr.Text = num1 * 1.0
        ElseIf cbxmonedas1.Text = "Balboa" And cbxmonedas2.Text = "Euro" Then
            lblr.Text = num1 * 0.84
        ElseIf cbxmonedas1.Text = "Balboa" And cbxmonedas2.Text = "Yen" Then
            lblr.Text = num1 * 106.05
        ElseIf cbxmonedas1.Text = "Balboa" And cbxmonedas2.Text = "Lempira" Then
            lblr.Text = num1 * 24.77
        ElseIf cbxmonedas1.Text = "Balboa" And cbxmonedas2.Text = "Cordoba nicaraguense" Then
            lblr.Text = num1 * 34.61
        ElseIf cbxmonedas1.Text = "Balboa" And cbxmonedas2.Text = "Quetzal" Then
            lblr.Text = num1 * 7.7
        ElseIf cbxmonedas1.Text = "Balboa" And cbxmonedas2.Text = "Peso mexicano" Then
            lblr.Text = num1 * 22.19
        ElseIf cbxmonedas1.Text = "Balboa" And cbxmonedas2.Text = "Libra esterlina" Then
            lblr.Text = num1 * 0.76
        ElseIf cbxmonedas1.Text = "Balboa" And cbxmonedas2.Text = "Bolivar venezolano" Then
            lblr.Text = num1 * 283777.32
        ElseIf cbxmonedas1.Text = "Peso mexicano" And cbxmonedas2.Text = "Dolar estadounidense" Then
            lblr.Text = num1 * 0.045
        ElseIf cbxmonedas1.Text = "Peso mexicano" And cbxmonedas2.Text = "Euro" Then
            lblr.Text = num1 * 0.038
        ElseIf cbxmonedas1.Text = "Peso mexicano" And cbxmonedas2.Text = "Yen" Then
            lblr.Text = num1 * 4.78
        ElseIf cbxmonedas1.Text = "Peso mexicano" And cbxmonedas2.Text = "Lempira" Then
            lblr.Text = num1 * 1.12
        ElseIf cbxmonedas1.Text = "Peso mexicano" And cbxmonedas2.Text = "Cordoba nicaraguense" Then
            lblr.Text = num1 * 1.56
        ElseIf cbxmonedas1.Text = "Peso mexicano" And cbxmonedas2.Text = "Quetzal" Then
            lblr.Text = num1 * 0.35
        ElseIf cbxmonedas1.Text = "Peso mexicano" And cbxmonedas2.Text = "Balboa" Then
            lblr.Text = num1 * 0.045
        ElseIf cbxmonedas1.Text = "Peso mexicano" And cbxmonedas2.Text = "Libra esterlina" Then
            lblr.Text = num1 * 0.034
        ElseIf cbxmonedas1.Text = "Peso mexicano" And cbxmonedas2.Text = "Bolivar venezolano" Then
            lblr.Text = num1 * 12788.48
        ElseIf cbxmonedas1.Text = "Libra esterlina" And cbxmonedas2.Text = "Dolar estadounidense" Then
            lblr.Text = num1 * 1.31
        ElseIf cbxmonedas1.Text = "Libra esterlina" And cbxmonedas2.Text = "Euro" Then
            lblr.Text = num1 * 1.1
        ElseIf cbxmonedas1.Text = "Libra esterlina" And cbxmonedas2.Text = "Yen" Then
            lblr.Text = num1 * 138.93
        ElseIf cbxmonedas1.Text = "Libra esterlina" And cbxmonedas2.Text = "Lempira" Then
            lblr.Text = num1 * 32.45
        ElseIf cbxmonedas1.Text = "Libra esterlina" And cbxmonedas2.Text = "Cordoba nicaraguense" Then
            lblr.Text = num1 * 45.35
        ElseIf cbxmonedas1.Text = "Libra esterlina" And cbxmonedas2.Text = "Quetzal" Then
            lblr.Text = num1 * 10.09
        ElseIf cbxmonedas1.Text = "Libra esterlina" And cbxmonedas2.Text = "Balboa" Then
            lblr.Text = num1 * 1.31
        ElseIf cbxmonedas1.Text = "Libra esterlina" And cbxmonedas2.Text = "Peso mexicano" Then
            lblr.Text = num1 * 29.08
        ElseIf cbxmonedas1.Text = "Libra esterlina" And cbxmonedas2.Text = "Bolivar venezolano" Then
            lblr.Text = num1 * 371797.38
        ElseIf cbxmonedas1.Text = "Bolivar venezolano" And cbxmonedas2.Text = "Dolar estadounidense" Then
            lblr.Text = num1 * 0.0000035
        ElseIf cbxmonedas1.Text = "Bolivar venezolano" And cbxmonedas2.Text = "Euro" Then
            lblr.Text = num1 * 0.000003
        ElseIf cbxmonedas1.Text = "Bolivar venezolano" And cbxmonedas2.Text = "Yen" Then
            lblr.Text = num1 * 0.00037
        ElseIf cbxmonedas1.Text = "Bolivar venezolano" And cbxmonedas2.Text = "Lempira" Then
            lblr.Text = num1 * 0.000087
        ElseIf cbxmonedas1.Text = "Bolivar venezolano" And cbxmonedas2.Text = "Cordoba nicaraguense" Then
            lblr.Text = num1 * 0.00012
        ElseIf cbxmonedas1.Text = "Bolivar venezolano" And cbxmonedas2.Text = "Quetzal" Then
            lblr.Text = num1 * 0.000027
        ElseIf cbxmonedas1.Text = "Bolivar venezolano" And cbxmonedas2.Text = "Balboa" Then
            lblr.Text = num1 * 0.0000035
        ElseIf cbxmonedas1.Text = "Bolivar venezolano" And cbxmonedas2.Text = "Peso mexicano" Then
            lblr.Text = num1 * 0.000078
        ElseIf cbxmonedas1.Text = "Bolivar venezolano" And cbxmonedas2.Text = "Libra esterlina" Then
            lblr.Text = num1 * 0.0000027


        End If


    End Sub
End Class
