<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculadora
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calculadora))
        Me.Suma = New System.Windows.Forms.Button()
        Me.ButtonSiete = New System.Windows.Forms.Button()
        Me.ButtonOcho = New System.Windows.Forms.Button()
        Me.ButtonNueve = New System.Windows.Forms.Button()
        Me.Resta = New System.Windows.Forms.Button()
        Me.ButtonCuatro = New System.Windows.Forms.Button()
        Me.ButtonCinco = New System.Windows.Forms.Button()
        Me.ButtonSeis = New System.Windows.Forms.Button()
        Me.Multiplicacion = New System.Windows.Forms.Button()
        Me.ButtonUno = New System.Windows.Forms.Button()
        Me.ButtonDos = New System.Windows.Forms.Button()
        Me.ButtonTres = New System.Windows.Forms.Button()
        Me.Division = New System.Windows.Forms.Button()
        Me.ButtonCero = New System.Windows.Forms.Button()
        Me.ButtonPunto = New System.Windows.Forms.Button()
        Me.ButtonIgual = New System.Windows.Forms.Button()
        Me.ButtonC = New System.Windows.Forms.Button()
        Me.TextResultado = New System.Windows.Forms.TextBox()
        Me.Borrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Suma
        '
        Me.Suma.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Suma.Location = New System.Drawing.Point(207, 86)
        Me.Suma.Name = "Suma"
        Me.Suma.Size = New System.Drawing.Size(59, 50)
        Me.Suma.TabIndex = 0
        Me.Suma.Text = "+"
        Me.Suma.UseVisualStyleBackColor = True
        '
        'ButtonSiete
        '
        Me.ButtonSiete.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSiete.Location = New System.Drawing.Point(12, 142)
        Me.ButtonSiete.Name = "ButtonSiete"
        Me.ButtonSiete.Size = New System.Drawing.Size(59, 50)
        Me.ButtonSiete.TabIndex = 1
        Me.ButtonSiete.Text = "7"
        Me.ButtonSiete.UseVisualStyleBackColor = True
        '
        'ButtonOcho
        '
        Me.ButtonOcho.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOcho.Location = New System.Drawing.Point(77, 142)
        Me.ButtonOcho.Name = "ButtonOcho"
        Me.ButtonOcho.Size = New System.Drawing.Size(59, 50)
        Me.ButtonOcho.TabIndex = 2
        Me.ButtonOcho.Text = "8"
        Me.ButtonOcho.UseVisualStyleBackColor = True
        '
        'ButtonNueve
        '
        Me.ButtonNueve.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNueve.Location = New System.Drawing.Point(142, 142)
        Me.ButtonNueve.Name = "ButtonNueve"
        Me.ButtonNueve.Size = New System.Drawing.Size(59, 50)
        Me.ButtonNueve.TabIndex = 3
        Me.ButtonNueve.Text = "9"
        Me.ButtonNueve.UseVisualStyleBackColor = True
        '
        'Resta
        '
        Me.Resta.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resta.Location = New System.Drawing.Point(142, 86)
        Me.Resta.Name = "Resta"
        Me.Resta.Size = New System.Drawing.Size(59, 50)
        Me.Resta.TabIndex = 4
        Me.Resta.Text = "-"
        Me.Resta.UseVisualStyleBackColor = True
        '
        'ButtonCuatro
        '
        Me.ButtonCuatro.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCuatro.Location = New System.Drawing.Point(12, 198)
        Me.ButtonCuatro.Name = "ButtonCuatro"
        Me.ButtonCuatro.Size = New System.Drawing.Size(59, 50)
        Me.ButtonCuatro.TabIndex = 5
        Me.ButtonCuatro.Text = "4"
        Me.ButtonCuatro.UseVisualStyleBackColor = True
        '
        'ButtonCinco
        '
        Me.ButtonCinco.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCinco.Location = New System.Drawing.Point(77, 198)
        Me.ButtonCinco.Name = "ButtonCinco"
        Me.ButtonCinco.Size = New System.Drawing.Size(59, 50)
        Me.ButtonCinco.TabIndex = 6
        Me.ButtonCinco.Text = "5"
        Me.ButtonCinco.UseVisualStyleBackColor = True
        '
        'ButtonSeis
        '
        Me.ButtonSeis.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSeis.Location = New System.Drawing.Point(142, 198)
        Me.ButtonSeis.Name = "ButtonSeis"
        Me.ButtonSeis.Size = New System.Drawing.Size(59, 50)
        Me.ButtonSeis.TabIndex = 7
        Me.ButtonSeis.Text = "6"
        Me.ButtonSeis.UseVisualStyleBackColor = True
        '
        'Multiplicacion
        '
        Me.Multiplicacion.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Multiplicacion.Location = New System.Drawing.Point(77, 86)
        Me.Multiplicacion.Name = "Multiplicacion"
        Me.Multiplicacion.Size = New System.Drawing.Size(59, 50)
        Me.Multiplicacion.TabIndex = 8
        Me.Multiplicacion.Text = "×"
        Me.Multiplicacion.UseVisualStyleBackColor = True
        '
        'ButtonUno
        '
        Me.ButtonUno.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUno.Location = New System.Drawing.Point(12, 254)
        Me.ButtonUno.Name = "ButtonUno"
        Me.ButtonUno.Size = New System.Drawing.Size(59, 50)
        Me.ButtonUno.TabIndex = 9
        Me.ButtonUno.Text = "1"
        Me.ButtonUno.UseVisualStyleBackColor = True
        '
        'ButtonDos
        '
        Me.ButtonDos.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDos.Location = New System.Drawing.Point(77, 254)
        Me.ButtonDos.Name = "ButtonDos"
        Me.ButtonDos.Size = New System.Drawing.Size(59, 50)
        Me.ButtonDos.TabIndex = 10
        Me.ButtonDos.Text = "2"
        Me.ButtonDos.UseVisualStyleBackColor = True
        '
        'ButtonTres
        '
        Me.ButtonTres.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTres.Location = New System.Drawing.Point(142, 254)
        Me.ButtonTres.Name = "ButtonTres"
        Me.ButtonTres.Size = New System.Drawing.Size(59, 50)
        Me.ButtonTres.TabIndex = 11
        Me.ButtonTres.Text = "3"
        Me.ButtonTres.UseVisualStyleBackColor = True
        '
        'Division
        '
        Me.Division.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Division.Location = New System.Drawing.Point(12, 86)
        Me.Division.Name = "Division"
        Me.Division.Size = New System.Drawing.Size(59, 50)
        Me.Division.TabIndex = 12
        Me.Division.Text = "÷"
        Me.Division.UseVisualStyleBackColor = True
        '
        'ButtonCero
        '
        Me.ButtonCero.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCero.Location = New System.Drawing.Point(12, 310)
        Me.ButtonCero.Name = "ButtonCero"
        Me.ButtonCero.Size = New System.Drawing.Size(124, 50)
        Me.ButtonCero.TabIndex = 13
        Me.ButtonCero.Text = "0"
        Me.ButtonCero.UseVisualStyleBackColor = True
        '
        'ButtonPunto
        '
        Me.ButtonPunto.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPunto.Location = New System.Drawing.Point(142, 310)
        Me.ButtonPunto.Name = "ButtonPunto"
        Me.ButtonPunto.Size = New System.Drawing.Size(59, 50)
        Me.ButtonPunto.TabIndex = 14
        Me.ButtonPunto.Text = "."
        Me.ButtonPunto.UseVisualStyleBackColor = True
        '
        'ButtonIgual
        '
        Me.ButtonIgual.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonIgual.Location = New System.Drawing.Point(207, 254)
        Me.ButtonIgual.Name = "ButtonIgual"
        Me.ButtonIgual.Size = New System.Drawing.Size(59, 106)
        Me.ButtonIgual.TabIndex = 15
        Me.ButtonIgual.Text = "="
        Me.ButtonIgual.UseVisualStyleBackColor = True
        '
        'ButtonC
        '
        Me.ButtonC.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ButtonC.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonC.Location = New System.Drawing.Point(207, 142)
        Me.ButtonC.Name = "ButtonC"
        Me.ButtonC.Size = New System.Drawing.Size(59, 50)
        Me.ButtonC.TabIndex = 16
        Me.ButtonC.Text = "C"
        Me.ButtonC.UseVisualStyleBackColor = False
        '
        'TextResultado
        '
        Me.TextResultado.Font = New System.Drawing.Font("HP Simplified", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextResultado.Location = New System.Drawing.Point(12, 12)
        Me.TextResultado.Name = "TextResultado"
        Me.TextResultado.ReadOnly = True
        Me.TextResultado.Size = New System.Drawing.Size(254, 56)
        Me.TextResultado.TabIndex = 17
        Me.TextResultado.Text = "0"
        Me.TextResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Borrar
        '
        Me.Borrar.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Borrar.Location = New System.Drawing.Point(207, 198)
        Me.Borrar.Name = "Borrar"
        Me.Borrar.Size = New System.Drawing.Size(59, 50)
        Me.Borrar.TabIndex = 18
        Me.Borrar.Text = "←"
        Me.Borrar.UseVisualStyleBackColor = True
        '
        'Calculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(276, 373)
        Me.Controls.Add(Me.Borrar)
        Me.Controls.Add(Me.TextResultado)
        Me.Controls.Add(Me.ButtonC)
        Me.Controls.Add(Me.ButtonIgual)
        Me.Controls.Add(Me.ButtonPunto)
        Me.Controls.Add(Me.ButtonCero)
        Me.Controls.Add(Me.Division)
        Me.Controls.Add(Me.ButtonTres)
        Me.Controls.Add(Me.ButtonDos)
        Me.Controls.Add(Me.ButtonUno)
        Me.Controls.Add(Me.Multiplicacion)
        Me.Controls.Add(Me.ButtonSeis)
        Me.Controls.Add(Me.ButtonCinco)
        Me.Controls.Add(Me.ButtonCuatro)
        Me.Controls.Add(Me.Resta)
        Me.Controls.Add(Me.ButtonNueve)
        Me.Controls.Add(Me.ButtonOcho)
        Me.Controls.Add(Me.ButtonSiete)
        Me.Controls.Add(Me.Suma)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Calculadora"
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Suma As Button
    Friend WithEvents ButtonSiete As Button
    Friend WithEvents ButtonOcho As Button
    Friend WithEvents ButtonNueve As Button
    Friend WithEvents Resta As Button
    Friend WithEvents ButtonCuatro As Button
    Friend WithEvents ButtonCinco As Button
    Friend WithEvents ButtonSeis As Button
    Friend WithEvents Multiplicacion As Button
    Friend WithEvents ButtonUno As Button
    Friend WithEvents ButtonDos As Button
    Friend WithEvents ButtonTres As Button
    Friend WithEvents Division As Button
    Friend WithEvents ButtonCero As Button
    Friend WithEvents ButtonPunto As Button
    Friend WithEvents ButtonIgual As Button
    Friend WithEvents ButtonC As Button
    Friend WithEvents TextResultado As TextBox
    Friend WithEvents Borrar As Button
End Class
