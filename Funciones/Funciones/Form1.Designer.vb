<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCadenas = New System.Windows.Forms.TextBox()
        Me.txtLongitud = New System.Windows.Forms.TextBox()
        Me.txtPrimero = New System.Windows.Forms.TextBox()
        Me.txtUltimo = New System.Windows.Forms.TextBox()
        Me.txtTercero = New System.Windows.Forms.TextBox()
        Me.txtPosicion = New System.Windows.Forms.TextBox()
        Me.txtMayuscula = New System.Windows.Forms.TextBox()
        Me.txtMinuscula = New System.Windows.Forms.TextBox()
        Me.txtBorrar = New System.Windows.Forms.TextBox()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cadenas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Longitud"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ultimo caracter"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 277)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Pisicion de la letra B"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "3er al 8vo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(45, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 17)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Primer caracter"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(45, 410)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 17)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Borrar espacios"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(45, 358)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Minusculas"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(45, 312)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 17)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Mayusculas"
        '
        'txtCadenas
        '
        Me.txtCadenas.Location = New System.Drawing.Point(194, 27)
        Me.txtCadenas.Name = "txtCadenas"
        Me.txtCadenas.Size = New System.Drawing.Size(100, 22)
        Me.txtCadenas.TabIndex = 9
        '
        'txtLongitud
        '
        Me.txtLongitud.Location = New System.Drawing.Point(194, 84)
        Me.txtLongitud.Name = "txtLongitud"
        Me.txtLongitud.Size = New System.Drawing.Size(100, 22)
        Me.txtLongitud.TabIndex = 10
        '
        'txtPrimero
        '
        Me.txtPrimero.Location = New System.Drawing.Point(194, 179)
        Me.txtPrimero.Name = "txtPrimero"
        Me.txtPrimero.Size = New System.Drawing.Size(100, 22)
        Me.txtPrimero.TabIndex = 11
        '
        'txtUltimo
        '
        Me.txtUltimo.Location = New System.Drawing.Point(194, 125)
        Me.txtUltimo.Name = "txtUltimo"
        Me.txtUltimo.Size = New System.Drawing.Size(100, 22)
        Me.txtUltimo.TabIndex = 12
        '
        'txtTercero
        '
        Me.txtTercero.Location = New System.Drawing.Point(194, 224)
        Me.txtTercero.Name = "txtTercero"
        Me.txtTercero.Size = New System.Drawing.Size(100, 22)
        Me.txtTercero.TabIndex = 13
        '
        'txtPosicion
        '
        Me.txtPosicion.Location = New System.Drawing.Point(194, 277)
        Me.txtPosicion.Name = "txtPosicion"
        Me.txtPosicion.Size = New System.Drawing.Size(100, 22)
        Me.txtPosicion.TabIndex = 14
        '
        'txtMayuscula
        '
        Me.txtMayuscula.Location = New System.Drawing.Point(194, 312)
        Me.txtMayuscula.Name = "txtMayuscula"
        Me.txtMayuscula.Size = New System.Drawing.Size(100, 22)
        Me.txtMayuscula.TabIndex = 15
        '
        'txtMinuscula
        '
        Me.txtMinuscula.Location = New System.Drawing.Point(194, 358)
        Me.txtMinuscula.Name = "txtMinuscula"
        Me.txtMinuscula.Size = New System.Drawing.Size(100, 22)
        Me.txtMinuscula.TabIndex = 16
        '
        'txtBorrar
        '
        Me.txtBorrar.Location = New System.Drawing.Point(194, 410)
        Me.txtBorrar.Name = "txtBorrar"
        Me.txtBorrar.Size = New System.Drawing.Size(100, 22)
        Me.txtBorrar.TabIndex = 17
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(368, 27)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(75, 23)
        Me.btnMostrar.TabIndex = 18
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 450)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.txtBorrar)
        Me.Controls.Add(Me.txtMinuscula)
        Me.Controls.Add(Me.txtMayuscula)
        Me.Controls.Add(Me.txtPosicion)
        Me.Controls.Add(Me.txtTercero)
        Me.Controls.Add(Me.txtUltimo)
        Me.Controls.Add(Me.txtPrimero)
        Me.Controls.Add(Me.txtLongitud)
        Me.Controls.Add(Me.txtCadenas)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCadenas As TextBox
    Friend WithEvents txtLongitud As TextBox
    Friend WithEvents txtPrimero As TextBox
    Friend WithEvents txtUltimo As TextBox
    Friend WithEvents txtTercero As TextBox
    Friend WithEvents txtPosicion As TextBox
    Friend WithEvents txtMayuscula As TextBox
    Friend WithEvents txtMinuscula As TextBox
    Friend WithEvents txtBorrar As TextBox
    Friend WithEvents btnMostrar As Button
End Class
