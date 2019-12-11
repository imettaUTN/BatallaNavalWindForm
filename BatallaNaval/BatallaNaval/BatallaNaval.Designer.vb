<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BatallaNaval
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtFilas = New System.Windows.Forms.TextBox()
        Me.TxtColumnas = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtJugado1 = New System.Windows.Forms.Button()
        Me.BtJugado2 = New System.Windows.Forms.Button()
        Me.chPartidaGuardada = New System.Windows.Forms.CheckBox()
        Me.CHJugarPc = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(33, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Parametros"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtFilas
        '
        Me.TxtFilas.AcceptsReturn = True
        Me.TxtFilas.Cursor = System.Windows.Forms.Cursors.No
        Me.TxtFilas.Location = New System.Drawing.Point(179, 30)
        Me.TxtFilas.Name = "TxtFilas"
        Me.TxtFilas.Size = New System.Drawing.Size(38, 20)
        Me.TxtFilas.TabIndex = 1
        '
        'TxtColumnas
        '
        Me.TxtColumnas.Location = New System.Drawing.Point(302, 30)
        Me.TxtColumnas.Name = "TxtColumnas"
        Me.TxtColumnas.Size = New System.Drawing.Size(38, 20)
        Me.TxtColumnas.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(134, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "# Filas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(233, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "# Columnas"
        '
        'BtJugado1
        '
        Me.BtJugado1.Location = New System.Drawing.Point(81, 79)
        Me.BtJugado1.Name = "BtJugado1"
        Me.BtJugado1.Size = New System.Drawing.Size(75, 23)
        Me.BtJugado1.TabIndex = 6
        Me.BtJugado1.Text = "Jugador1"
        Me.BtJugado1.UseVisualStyleBackColor = True
        '
        'BtJugado2
        '
        Me.BtJugado2.Location = New System.Drawing.Point(221, 79)
        Me.BtJugado2.Name = "BtJugado2"
        Me.BtJugado2.Size = New System.Drawing.Size(75, 23)
        Me.BtJugado2.TabIndex = 7
        Me.BtJugado2.Text = "Jugador2"
        Me.BtJugado2.UseVisualStyleBackColor = True
        '
        'chPartidaGuardada
        '
        Me.chPartidaGuardada.AutoSize = True
        Me.chPartidaGuardada.Location = New System.Drawing.Point(33, 5)
        Me.chPartidaGuardada.Name = "chPartidaGuardada"
        Me.chPartidaGuardada.Size = New System.Drawing.Size(106, 17)
        Me.chPartidaGuardada.TabIndex = 8
        Me.chPartidaGuardada.Text = "PartidaGuardada"
        Me.chPartidaGuardada.UseVisualStyleBackColor = True
        '
        'CHJugarPc
        '
        Me.CHJugarPc.AutoSize = True
        Me.CHJugarPc.Location = New System.Drawing.Point(166, 5)
        Me.CHJugarPc.Name = "CHJugarPc"
        Me.CHJugarPc.Size = New System.Drawing.Size(102, 17)
        Me.CHJugarPc.TabIndex = 9
        Me.CHJugarPc.Text = "Jugar contra PC"
        Me.CHJugarPc.UseVisualStyleBackColor = True
        '
        'BatallaNaval
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 115)
        Me.Controls.Add(Me.CHJugarPc)
        Me.Controls.Add(Me.chPartidaGuardada)
        Me.Controls.Add(Me.BtJugado2)
        Me.Controls.Add(Me.BtJugado1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtColumnas)
        Me.Controls.Add(Me.TxtFilas)
        Me.Controls.Add(Me.Button1)
        Me.Name = "BatallaNaval"
        Me.Text = "BatallaNaval"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TxtFilas As TextBox
    Friend WithEvents TxtColumnas As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtJugado1 As Button
    Friend WithEvents BtJugado2 As Button
    Friend WithEvents chPartidaGuardada As CheckBox
    Friend WithEvents CHJugarPc As CheckBox
End Class
