<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblvalor = New System.Windows.Forms.Label()
        Me.txtvalor = New System.Windows.Forms.TextBox()
        Me.lblDe = New System.Windows.Forms.Label()
        Me.lblA = New System.Windows.Forms.Label()
        Me.cbxtiem1 = New System.Windows.Forms.ComboBox()
        Me.cbxmonedas1 = New System.Windows.Forms.ComboBox()
        Me.cbxmasa1 = New System.Windows.Forms.ComboBox()
        Me.cbxlongi1 = New System.Windows.Forms.ComboBox()
        Me.cbxalma1 = New System.Windows.Forms.ComboBox()
        Me.cbxvol1 = New System.Windows.Forms.ComboBox()
        Me.cbxmonedas2 = New System.Windows.Forms.ComboBox()
        Me.cbxmasa2 = New System.Windows.Forms.ComboBox()
        Me.cbxlongi2 = New System.Windows.Forms.ComboBox()
        Me.cbxalma2 = New System.Windows.Forms.ComboBox()
        Me.cbxvol2 = New System.Windows.Forms.ComboBox()
        Me.cbxtiem2 = New System.Windows.Forms.ComboBox()
        Me.btnconvertir = New System.Windows.Forms.Button()
        Me.lblr = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblvalor
        '
        Me.lblvalor.AutoSize = True
        Me.lblvalor.Location = New System.Drawing.Point(13, 51)
        Me.lblvalor.Name = "lblvalor"
        Me.lblvalor.Size = New System.Drawing.Size(144, 13)
        Me.lblvalor.TabIndex = 0
        Me.lblvalor.Text = "Ingrese el numero a convertir"
        '
        'txtvalor
        '
        Me.txtvalor.Location = New System.Drawing.Point(28, 78)
        Me.txtvalor.Name = "txtvalor"
        Me.txtvalor.Size = New System.Drawing.Size(100, 20)
        Me.txtvalor.TabIndex = 1
        '
        'lblDe
        '
        Me.lblDe.AutoSize = True
        Me.lblDe.Location = New System.Drawing.Point(172, 51)
        Me.lblDe.Name = "lblDe"
        Me.lblDe.Size = New System.Drawing.Size(21, 13)
        Me.lblDe.TabIndex = 2
        Me.lblDe.Text = "De"
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Location = New System.Drawing.Point(172, 108)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(14, 13)
        Me.lblA.TabIndex = 3
        Me.lblA.Text = "A"
        '
        'cbxtiem1
        '
        Me.cbxtiem1.FormattingEnabled = True
        Me.cbxtiem1.Items.AddRange(New Object() {"Nanosegundo", "Microsegundo", "Milisegundo", "Segundo", "Minuto", "Hora", "Dia", "Semana", "Decada", "Año natural"})
        Me.cbxtiem1.Location = New System.Drawing.Point(192, 51)
        Me.cbxtiem1.Name = "cbxtiem1"
        Me.cbxtiem1.Size = New System.Drawing.Size(102, 21)
        Me.cbxtiem1.TabIndex = 4
        Me.cbxtiem1.Text = "Tiempo"
        '
        'cbxmonedas1
        '
        Me.cbxmonedas1.FormattingEnabled = True
        Me.cbxmonedas1.Items.AddRange(New Object() {"Dolar estadounidense", "Euro", "Yen", "Lempira", "Cordoba nicaraguense", "Quetzal", "Balboa", "Peso mexicano", "Libra esterlina", "Bolivar venezolano"})
        Me.cbxmonedas1.Location = New System.Drawing.Point(764, 51)
        Me.cbxmonedas1.Name = "cbxmonedas1"
        Me.cbxmonedas1.Size = New System.Drawing.Size(125, 21)
        Me.cbxmonedas1.TabIndex = 5
        Me.cbxmonedas1.Text = "Monedas"
        '
        'cbxmasa1
        '
        Me.cbxmasa1.FormattingEnabled = True
        Me.cbxmasa1.Items.AddRange(New Object() {"Kilogramos", "Hectogramos", "Decagramos", "Gramos", "Decigramos", "Centigramos", "Miligramos", "Libras", "Onzas", "Quilates"})
        Me.cbxmasa1.Location = New System.Drawing.Point(643, 51)
        Me.cbxmasa1.Name = "cbxmasa1"
        Me.cbxmasa1.Size = New System.Drawing.Size(115, 21)
        Me.cbxmasa1.TabIndex = 6
        Me.cbxmasa1.Text = "Masa"
        '
        'cbxlongi1
        '
        Me.cbxlongi1.FormattingEnabled = True
        Me.cbxlongi1.Items.AddRange(New Object() {"Metro", "Centimetro", "Milimetro", "Milla", "Yarda", "Pie", "Pulgada", "Kilometro", "Nanometro", "Micrometro"})
        Me.cbxlongi1.Location = New System.Drawing.Point(539, 51)
        Me.cbxlongi1.Name = "cbxlongi1"
        Me.cbxlongi1.Size = New System.Drawing.Size(98, 21)
        Me.cbxlongi1.TabIndex = 7
        Me.cbxlongi1.Text = "Longitud"
        '
        'cbxalma1
        '
        Me.cbxalma1.FormattingEnabled = True
        Me.cbxalma1.Items.AddRange(New Object() {"Bits", "Bytes", "Gigabits", "Gigabytes", "Kilobits", "Kilobytes", "Megabits", "Megabytes", "Petabits", "Petabytes"})
        Me.cbxalma1.Location = New System.Drawing.Point(429, 51)
        Me.cbxalma1.Name = "cbxalma1"
        Me.cbxalma1.Size = New System.Drawing.Size(104, 21)
        Me.cbxalma1.TabIndex = 8
        Me.cbxalma1.Text = "Almacenamiento"
        '
        'cbxvol1
        '
        Me.cbxvol1.FormattingEnabled = True
        Me.cbxvol1.Items.AddRange(New Object() {"Litro", "Mililitro", "Pie cubico", "Pulgada cubica", "Onza liquida imperial", "Metro cubico", "Galon imperial", "Cuarto estadounidense", "Taza imperial", "Cucharada estadounidense"})
        Me.cbxvol1.Location = New System.Drawing.Point(300, 51)
        Me.cbxvol1.Name = "cbxvol1"
        Me.cbxvol1.Size = New System.Drawing.Size(123, 21)
        Me.cbxvol1.TabIndex = 9
        Me.cbxvol1.Text = "Volumen"
        '
        'cbxmonedas2
        '
        Me.cbxmonedas2.FormattingEnabled = True
        Me.cbxmonedas2.Items.AddRange(New Object() {"Dolar estadounidense", "Euro", "Yen", "Lempira", "Cordoba nicaraguense", "Quetzal", "Balboa", "Peso mexicano", "Libra esterlina", "Bolivar venezolano"})
        Me.cbxmonedas2.Location = New System.Drawing.Point(764, 105)
        Me.cbxmonedas2.Name = "cbxmonedas2"
        Me.cbxmonedas2.Size = New System.Drawing.Size(125, 21)
        Me.cbxmonedas2.TabIndex = 10
        '
        'cbxmasa2
        '
        Me.cbxmasa2.FormattingEnabled = True
        Me.cbxmasa2.Items.AddRange(New Object() {"Kilogramos", "Hectogramos", "Decagramos", "Gramos", "Decigramos", "Centigramos", "Miligramos", "Libras", "Onzas", "Quilates"})
        Me.cbxmasa2.Location = New System.Drawing.Point(643, 105)
        Me.cbxmasa2.Name = "cbxmasa2"
        Me.cbxmasa2.Size = New System.Drawing.Size(115, 21)
        Me.cbxmasa2.TabIndex = 11
        '
        'cbxlongi2
        '
        Me.cbxlongi2.FormattingEnabled = True
        Me.cbxlongi2.Items.AddRange(New Object() {"Metro", "Centimetro", "Milimetro", "Milla", "Yarda", "Pie", "Pulgada", "Kilometro", "Nanometro", "Micrometro"})
        Me.cbxlongi2.Location = New System.Drawing.Point(539, 105)
        Me.cbxlongi2.Name = "cbxlongi2"
        Me.cbxlongi2.Size = New System.Drawing.Size(98, 21)
        Me.cbxlongi2.TabIndex = 12
        '
        'cbxalma2
        '
        Me.cbxalma2.FormattingEnabled = True
        Me.cbxalma2.Items.AddRange(New Object() {"Bits", "Bytes", "Gigabits", "Gigabytes", "Kilobits", "Kilobytes", "Megabits", "Megabytes", "Petabits", "Petabytes"})
        Me.cbxalma2.Location = New System.Drawing.Point(429, 105)
        Me.cbxalma2.Name = "cbxalma2"
        Me.cbxalma2.Size = New System.Drawing.Size(104, 21)
        Me.cbxalma2.TabIndex = 13
        '
        'cbxvol2
        '
        Me.cbxvol2.FormattingEnabled = True
        Me.cbxvol2.Items.AddRange(New Object() {"Litro", "Mililitro", "Pie cubico", "Pulgada cubica", "Onza liquida imperial", "Metro cubico", "Galon imperial", "Cuarto estadounidense", "Taza imperial", "Cucharada estadounidense"})
        Me.cbxvol2.Location = New System.Drawing.Point(297, 105)
        Me.cbxvol2.Name = "cbxvol2"
        Me.cbxvol2.Size = New System.Drawing.Size(126, 21)
        Me.cbxvol2.TabIndex = 14
        '
        'cbxtiem2
        '
        Me.cbxtiem2.FormattingEnabled = True
        Me.cbxtiem2.Items.AddRange(New Object() {"Nanosegundo", "Microsegundo", "Milisegundo", "Segundo", "Minuto", "Hora", "Dia", "Semana", "Decada", "Año natural"})
        Me.cbxtiem2.Location = New System.Drawing.Point(192, 105)
        Me.cbxtiem2.Name = "cbxtiem2"
        Me.cbxtiem2.Size = New System.Drawing.Size(102, 21)
        Me.cbxtiem2.TabIndex = 15
        '
        'btnconvertir
        '
        Me.btnconvertir.Location = New System.Drawing.Point(321, 158)
        Me.btnconvertir.Name = "btnconvertir"
        Me.btnconvertir.Size = New System.Drawing.Size(75, 23)
        Me.btnconvertir.TabIndex = 16
        Me.btnconvertir.Text = "Convertir"
        Me.btnconvertir.UseVisualStyleBackColor = True
        '
        'lblr
        '
        Me.lblr.AutoSize = True
        Me.lblr.Location = New System.Drawing.Point(471, 163)
        Me.lblr.Name = "lblr"
        Me.lblr.Size = New System.Drawing.Size(55, 13)
        Me.lblr.TabIndex = 17
        Me.lblr.Text = "Resultado"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 450)
        Me.Controls.Add(Me.lblr)
        Me.Controls.Add(Me.btnconvertir)
        Me.Controls.Add(Me.cbxtiem2)
        Me.Controls.Add(Me.cbxvol2)
        Me.Controls.Add(Me.cbxalma2)
        Me.Controls.Add(Me.cbxlongi2)
        Me.Controls.Add(Me.cbxmasa2)
        Me.Controls.Add(Me.cbxmonedas2)
        Me.Controls.Add(Me.cbxvol1)
        Me.Controls.Add(Me.cbxalma1)
        Me.Controls.Add(Me.cbxlongi1)
        Me.Controls.Add(Me.cbxmasa1)
        Me.Controls.Add(Me.cbxmonedas1)
        Me.Controls.Add(Me.cbxtiem1)
        Me.Controls.Add(Me.lblA)
        Me.Controls.Add(Me.lblDe)
        Me.Controls.Add(Me.txtvalor)
        Me.Controls.Add(Me.lblvalor)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblvalor As Label
    Friend WithEvents txtvalor As TextBox
    Friend WithEvents lblDe As Label
    Friend WithEvents lblA As Label
    Friend WithEvents cbxtiem1 As ComboBox
    Friend WithEvents cbxmonedas1 As ComboBox
    Friend WithEvents cbxmasa1 As ComboBox
    Friend WithEvents cbxlongi1 As ComboBox
    Friend WithEvents cbxalma1 As ComboBox
    Friend WithEvents cbxvol1 As ComboBox
    Friend WithEvents cbxmonedas2 As ComboBox
    Friend WithEvents cbxmasa2 As ComboBox
    Friend WithEvents cbxlongi2 As ComboBox
    Friend WithEvents cbxalma2 As ComboBox
    Friend WithEvents cbxvol2 As ComboBox
    Friend WithEvents cbxtiem2 As ComboBox
    Friend WithEvents btnconvertir As Button
    Friend WithEvents lblr As Label
End Class
