<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Disparar
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
        Me.TxtFila = New System.Windows.Forms.TextBox()
        Me.TxtColumnas = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtDisparar = New System.Windows.Forms.Button()
        Me.CHJ1 = New System.Windows.Forms.CheckBox()
        Me.CHJ2 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'TxtFila
        '
        Me.TxtFila.Location = New System.Drawing.Point(44, 41)
        Me.TxtFila.Name = "TxtFila"
        Me.TxtFila.Size = New System.Drawing.Size(93, 20)
        Me.TxtFila.TabIndex = 0
        '
        'TxtColumnas
        '
        Me.TxtColumnas.Location = New System.Drawing.Point(219, 41)
        Me.TxtColumnas.Name = "TxtColumnas"
        Me.TxtColumnas.Size = New System.Drawing.Size(93, 20)
        Me.TxtColumnas.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(165, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Columna"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(-1, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fila"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(114, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Coordenadas:"
        '
        'BtDisparar
        '
        Me.BtDisparar.Location = New System.Drawing.Point(85, 96)
        Me.BtDisparar.Name = "BtDisparar"
        Me.BtDisparar.Size = New System.Drawing.Size(113, 23)
        Me.BtDisparar.TabIndex = 5
        Me.BtDisparar.Text = "Disparar"
        Me.BtDisparar.UseVisualStyleBackColor = True
        '
        'CHJ1
        '
        Me.CHJ1.AutoSize = True
        Me.CHJ1.Location = New System.Drawing.Point(56, 67)
        Me.CHJ1.Name = "CHJ1"
        Me.CHJ1.Size = New System.Drawing.Size(73, 17)
        Me.CHJ1.TabIndex = 6
        Me.CHJ1.Text = "Jugador 1"
        Me.CHJ1.UseVisualStyleBackColor = True
        '
        'CHJ2
        '
        Me.CHJ2.AutoSize = True
        Me.CHJ2.Location = New System.Drawing.Point(156, 67)
        Me.CHJ2.Name = "CHJ2"
        Me.CHJ2.Size = New System.Drawing.Size(73, 17)
        Me.CHJ2.TabIndex = 7
        Me.CHJ2.Text = "Jugador 2"
        Me.CHJ2.UseVisualStyleBackColor = True
        '
        'Disparar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 131)
        Me.Controls.Add(Me.CHJ2)
        Me.Controls.Add(Me.CHJ1)
        Me.Controls.Add(Me.BtDisparar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtColumnas)
        Me.Controls.Add(Me.TxtFila)
        Me.Name = "Disparar"
        Me.Text = "Disparar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtFila As TextBox
    Friend WithEvents TxtColumnas As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtDisparar As Button
    Friend WithEvents CHJ1 As CheckBox
    Friend WithEvents CHJ2 As CheckBox
End Class
