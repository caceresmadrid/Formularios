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
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.txtBase = New System.Windows.Forms.TextBox()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRespuesta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtResp2 = New System.Windows.Forms.TextBox()
        Me.chkColorFondo = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btnMostrar
        '
        Me.btnMostrar.Enabled = False
        Me.btnMostrar.Location = New System.Drawing.Point(129, 160)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(94, 34)
        Me.btnMostrar.TabIndex = 2
        Me.btnMostrar.Text = "Calcular"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'txtBase
        '
        Me.txtBase.Location = New System.Drawing.Point(241, 59)
        Me.txtBase.Name = "txtBase"
        Me.txtBase.Size = New System.Drawing.Size(224, 20)
        Me.txtBase.TabIndex = 0
        '
        'txtAltura
        '
        Me.txtAltura.Location = New System.Drawing.Point(241, 94)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(224, 20)
        Me.txtAltura.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(120, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "base "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(120, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Altura"
        '
        'txtRespuesta
        '
        Me.txtRespuesta.Location = New System.Drawing.Point(241, 130)
        Me.txtRespuesta.Name = "txtRespuesta"
        Me.txtRespuesta.ReadOnly = True
        Me.txtRespuesta.Size = New System.Drawing.Size(224, 20)
        Me.txtRespuesta.TabIndex = 5
        Me.txtRespuesta.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(120, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Respuesta"
        '
        'txtResp2
        '
        Me.txtResp2.Location = New System.Drawing.Point(471, 130)
        Me.txtResp2.Name = "txtResp2"
        Me.txtResp2.ReadOnly = True
        Me.txtResp2.Size = New System.Drawing.Size(224, 20)
        Me.txtResp2.TabIndex = 4
        Me.txtResp2.TabStop = False
        '
        'chkColorFondo
        '
        Me.chkColorFondo.AutoSize = True
        Me.chkColorFondo.Location = New System.Drawing.Point(614, 54)
        Me.chkColorFondo.Name = "chkColorFondo"
        Me.chkColorFondo.Size = New System.Drawing.Size(48, 17)
        Me.chkColorFondo.TabIndex = 8
        Me.chkColorFondo.Text = "Rojo"
        Me.chkColorFondo.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(614, 77)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(46, 17)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Otro"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.chkColorFondo)
        Me.Controls.Add(Me.txtResp2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRespuesta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAltura)
        Me.Controls.Add(Me.txtBase)
        Me.Controls.Add(Me.btnMostrar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMostrar As Button
    Friend WithEvents txtBase As TextBox
    Friend WithEvents txtAltura As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRespuesta As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtResp2 As TextBox
    Friend WithEvents chkColorFondo As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
End Class
