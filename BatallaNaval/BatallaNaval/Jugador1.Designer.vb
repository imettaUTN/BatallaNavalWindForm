<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Jugador1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ChCargaDatos = New System.Windows.Forms.CheckBox()
        Me.ChB1 = New System.Windows.Forms.CheckBox()
        Me.ChB2 = New System.Windows.Forms.CheckBox()
        Me.ChB3 = New System.Windows.Forms.CheckBox()
        Me.ChB4 = New System.Windows.Forms.CheckBox()
        Me.DataGridJ1 = New System.Windows.Forms.DataGridView()
        Me.chGuardarPartida = New System.Windows.Forms.CheckBox()
        Me.FlowLayoutPanel2.SuspendLayout()
        CType(Me.DataGridJ1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoSize = True
        Me.FlowLayoutPanel2.Controls.Add(Me.ChCargaDatos)
        Me.FlowLayoutPanel2.Controls.Add(Me.ChB1)
        Me.FlowLayoutPanel2.Controls.Add(Me.ChB2)
        Me.FlowLayoutPanel2.Controls.Add(Me.ChB3)
        Me.FlowLayoutPanel2.Controls.Add(Me.ChB4)
        Me.FlowLayoutPanel2.Controls.Add(Me.chGuardarPartida)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(15, 13)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(919, 53)
        Me.FlowLayoutPanel2.TabIndex = 2
        '
        'ChCargaDatos
        '
        Me.ChCargaDatos.AutoSize = True
        Me.ChCargaDatos.Checked = True
        Me.ChCargaDatos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChCargaDatos.Location = New System.Drawing.Point(3, 3)
        Me.ChCargaDatos.Name = "ChCargaDatos"
        Me.ChCargaDatos.Size = New System.Drawing.Size(92, 17)
        Me.ChCargaDatos.TabIndex = 0
        Me.ChCargaDatos.Text = "Cargar barcos"
        Me.ChCargaDatos.UseVisualStyleBackColor = True
        '
        'ChB1
        '
        Me.ChB1.AutoSize = True
        Me.ChB1.Location = New System.Drawing.Point(101, 3)
        Me.ChB1.Name = "ChB1"
        Me.ChB1.Size = New System.Drawing.Size(73, 17)
        Me.ChB1.TabIndex = 1
        Me.ChB1.Text = "Cargar B1"
        Me.ChB1.UseVisualStyleBackColor = True
        '
        'ChB2
        '
        Me.ChB2.AutoSize = True
        Me.ChB2.Location = New System.Drawing.Point(180, 3)
        Me.ChB2.Name = "ChB2"
        Me.ChB2.Size = New System.Drawing.Size(73, 17)
        Me.ChB2.TabIndex = 2
        Me.ChB2.Text = "Cargar B2"
        Me.ChB2.UseVisualStyleBackColor = True
        '
        'ChB3
        '
        Me.ChB3.AutoSize = True
        Me.ChB3.Location = New System.Drawing.Point(259, 3)
        Me.ChB3.Name = "ChB3"
        Me.ChB3.Size = New System.Drawing.Size(73, 17)
        Me.ChB3.TabIndex = 3
        Me.ChB3.Text = "Cargar B3"
        Me.ChB3.UseVisualStyleBackColor = True
        '
        'ChB4
        '
        Me.ChB4.AutoSize = True
        Me.ChB4.Location = New System.Drawing.Point(338, 3)
        Me.ChB4.Name = "ChB4"
        Me.ChB4.Size = New System.Drawing.Size(73, 17)
        Me.ChB4.TabIndex = 4
        Me.ChB4.Text = "Cargar B4"
        Me.ChB4.UseVisualStyleBackColor = True
        '
        'DataGridJ1
        '
        Me.DataGridJ1.AllowUserToAddRows = False
        Me.DataGridJ1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridJ1.ColumnHeadersVisible = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridJ1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridJ1.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridJ1.Location = New System.Drawing.Point(15, 72)
        Me.DataGridJ1.Name = "DataGridJ1"
        Me.DataGridJ1.Size = New System.Drawing.Size(919, 376)
        Me.DataGridJ1.TabIndex = 3
        '
        'chGuardarPartida
        '
        Me.chGuardarPartida.AutoSize = True
        Me.chGuardarPartida.Location = New System.Drawing.Point(417, 3)
        Me.chGuardarPartida.Name = "chGuardarPartida"
        Me.chGuardarPartida.Size = New System.Drawing.Size(100, 17)
        Me.chGuardarPartida.TabIndex = 5
        Me.chGuardarPartida.Text = "Guardar Partida"
        Me.chGuardarPartida.UseVisualStyleBackColor = True
        '
        'Jugador1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(965, 466)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.DataGridJ1)
        Me.Name = "Jugador1"
        Me.Text = "Jugador1"
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        CType(Me.DataGridJ1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents ChCargaDatos As CheckBox
    Friend WithEvents ChB1 As CheckBox
    Friend WithEvents ChB2 As CheckBox
    Friend WithEvents ChB3 As CheckBox
    Friend WithEvents ChB4 As CheckBox
    Friend WithEvents DataGridJ1 As DataGridView
    Friend WithEvents chGuardarPartida As CheckBox
End Class
