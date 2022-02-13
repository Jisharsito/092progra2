<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnVenta = New System.Windows.Forms.CheckBox()
        Me.btnCompra = New System.Windows.Forms.CheckBox()
        Me.aplicar = New System.Windows.Forms.Button()
        Me.salir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(22, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CASA CAMBIOS"
        '
        'btnVenta
        '
        Me.btnVenta.AutoSize = True
        Me.btnVenta.Location = New System.Drawing.Point(31, 63)
        Me.btnVenta.Name = "btnVenta"
        Me.btnVenta.Size = New System.Drawing.Size(58, 19)
        Me.btnVenta.TabIndex = 1
        Me.btnVenta.Text = "Venta "
        Me.btnVenta.UseVisualStyleBackColor = True
        '
        'btnCompra
        '
        Me.btnCompra.AutoSize = True
        Me.btnCompra.Location = New System.Drawing.Point(32, 107)
        Me.btnCompra.Name = "btnCompra"
        Me.btnCompra.Size = New System.Drawing.Size(69, 19)
        Me.btnCompra.TabIndex = 2
        Me.btnCompra.Text = "Compra"
        Me.btnCompra.UseVisualStyleBackColor = True
        '
        'aplicar
        '
        Me.aplicar.Location = New System.Drawing.Point(88, 142)
        Me.aplicar.Name = "aplicar"
        Me.aplicar.Size = New System.Drawing.Size(75, 23)
        Me.aplicar.TabIndex = 3
        Me.aplicar.Text = "Aplicar"
        Me.aplicar.UseVisualStyleBackColor = True
        '
        'salir
        '
        Me.salir.Location = New System.Drawing.Point(183, 142)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(75, 23)
        Me.salir.TabIndex = 4
        Me.salir.Text = "Salir"
        Me.salir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 187)
        Me.Controls.Add(Me.salir)
        Me.Controls.Add(Me.aplicar)
        Me.Controls.Add(Me.btnCompra)
        Me.Controls.Add(Me.btnVenta)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnVenta As CheckBox
    Friend WithEvents btnCompra As CheckBox
    Friend WithEvents aplicar As Button
    Friend WithEvents salir As Button
End Class
