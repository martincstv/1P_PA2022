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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_Numero1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_Numero2 = New System.Windows.Forms.TextBox()
        Me.Button = New System.Windows.Forms.Button()
        Me.Label_Resultado = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NUMERO1"
        '
        'TextBox_Numero1
        '
        Me.TextBox_Numero1.Location = New System.Drawing.Point(132, 40)
        Me.TextBox_Numero1.Name = "TextBox_Numero1"
        Me.TextBox_Numero1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox_Numero1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NUMERO2"
        '
        'TextBox_Numero2
        '
        Me.TextBox_Numero2.Location = New System.Drawing.Point(132, 90)
        Me.TextBox_Numero2.Name = "TextBox_Numero2"
        Me.TextBox_Numero2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox_Numero2.TabIndex = 3
        '
        'Button
        '
        Me.Button.Location = New System.Drawing.Point(43, 139)
        Me.Button.Name = "Button"
        Me.Button.Size = New System.Drawing.Size(189, 23)
        Me.Button.TabIndex = 4
        Me.Button.Text = "CALCULAR POTENCIA"
        Me.Button.UseVisualStyleBackColor = True
        '
        'Label_Resultado
        '
        Me.Label_Resultado.AutoSize = True
        Me.Label_Resultado.Location = New System.Drawing.Point(142, 188)
        Me.Label_Resultado.Name = "Label_Resultado"
        Me.Label_Resultado.Size = New System.Drawing.Size(90, 16)
        Me.Label_Resultado.TabIndex = 5
        Me.Label_Resultado.Text = "RESULTADO"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label_Resultado)
        Me.GroupBox1.Controls.Add(Me.TextBox_Numero1)
        Me.GroupBox1.Controls.Add(Me.Button)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox_Numero2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(324, 286)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operaciones"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 306)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consume Biblioteca"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_Numero1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_Numero2 As TextBox
    Friend WithEvents Button As Button
    Friend WithEvents Label_Resultado As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
