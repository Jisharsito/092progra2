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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.arroz = New System.Windows.Forms.TextBox()
        Me.frijol = New System.Windows.Forms.TextBox()
        Me.azucar = New System.Windows.Forms.TextBox()
        Me.ingresar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.limpiar = New System.Windows.Forms.Button()
        Me.salir = New System.Windows.Forms.Button()
        Me.pago1 = New System.Windows.Forms.TextBox()
        Me.iva = New System.Windows.Forms.TextBox()
        Me.pago2 = New System.Windows.Forms.TextBox()
        Me.desc = New System.Windows.Forms.TextBox()
        Me.pago3 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Emoji", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(28, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "COMPRA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Libra de Arroz (Q2.00)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Libra de Frijol (Q1.75)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Libra de Azucar (Q2.50)"
        '
        'arroz
        '
        Me.arroz.Location = New System.Drawing.Point(194, 61)
        Me.arroz.Name = "arroz"
        Me.arroz.Size = New System.Drawing.Size(82, 23)
        Me.arroz.TabIndex = 4
        '
        'frijol
        '
        Me.frijol.Location = New System.Drawing.Point(194, 107)
        Me.frijol.Name = "frijol"
        Me.frijol.Size = New System.Drawing.Size(82, 23)
        Me.frijol.TabIndex = 5
        '
        'azucar
        '
        Me.azucar.Location = New System.Drawing.Point(194, 153)
        Me.azucar.Name = "azucar"
        Me.azucar.Size = New System.Drawing.Size(82, 23)
        Me.azucar.TabIndex = 6
        '
        'ingresar
        '
        Me.ingresar.Location = New System.Drawing.Point(259, 198)
        Me.ingresar.Name = "ingresar"
        Me.ingresar.Size = New System.Drawing.Size(75, 23)
        Me.ingresar.TabIndex = 7
        Me.ingresar.Text = "INGRESAR"
        Me.ingresar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Emoji", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(367, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 32)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "RESULTADOS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(377, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Pago a Realizar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(377, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 15)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "IVA"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(377, 153)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 15)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Pago Parcial"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(377, 198)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 15)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Descuento aniversario"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(377, 241)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 15)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Pago Total"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(512, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 15)
        Me.Label11.TabIndex = 14
        '
        'limpiar
        '
        Me.limpiar.Location = New System.Drawing.Point(568, 294)
        Me.limpiar.Name = "limpiar"
        Me.limpiar.Size = New System.Drawing.Size(75, 23)
        Me.limpiar.TabIndex = 20
        Me.limpiar.Text = "LIMPIAR"
        Me.limpiar.UseVisualStyleBackColor = True
        '
        'salir
        '
        Me.salir.Location = New System.Drawing.Point(664, 294)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(75, 23)
        Me.salir.TabIndex = 21
        Me.salir.Text = "SALIR"
        Me.salir.UseVisualStyleBackColor = True
        '
        'pago1
        '
        Me.pago1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.pago1.Location = New System.Drawing.Point(518, 59)
        Me.pago1.Name = "pago1"
        Me.pago1.ReadOnly = True
        Me.pago1.Size = New System.Drawing.Size(100, 16)
        Me.pago1.TabIndex = 22
        '
        'iva
        '
        Me.iva.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.iva.Location = New System.Drawing.Point(518, 107)
        Me.iva.Name = "iva"
        Me.iva.ReadOnly = True
        Me.iva.Size = New System.Drawing.Size(100, 16)
        Me.iva.TabIndex = 23
        '
        'pago2
        '
        Me.pago2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.pago2.Location = New System.Drawing.Point(518, 152)
        Me.pago2.Name = "pago2"
        Me.pago2.ReadOnly = True
        Me.pago2.Size = New System.Drawing.Size(100, 16)
        Me.pago2.TabIndex = 24
        '
        'desc
        '
        Me.desc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.desc.Location = New System.Drawing.Point(518, 195)
        Me.desc.Name = "desc"
        Me.desc.ReadOnly = True
        Me.desc.Size = New System.Drawing.Size(100, 16)
        Me.desc.TabIndex = 25
        '
        'pago3
        '
        Me.pago3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.pago3.Location = New System.Drawing.Point(518, 241)
        Me.pago3.Name = "pago3"
        Me.pago3.ReadOnly = True
        Me.pago3.Size = New System.Drawing.Size(100, 16)
        Me.pago3.TabIndex = 26
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 329)
        Me.Controls.Add(Me.pago3)
        Me.Controls.Add(Me.desc)
        Me.Controls.Add(Me.pago2)
        Me.Controls.Add(Me.iva)
        Me.Controls.Add(Me.pago1)
        Me.Controls.Add(Me.salir)
        Me.Controls.Add(Me.limpiar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ingresar)
        Me.Controls.Add(Me.azucar)
        Me.Controls.Add(Me.frijol)
        Me.Controls.Add(Me.arroz)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "201804858_Tienda"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents arroz As TextBox
    Friend WithEvents frijol As TextBox
    Friend WithEvents azucar As TextBox
    Friend WithEvents ingresar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents limpiar As Button
    Friend WithEvents salir As Button
    Friend WithEvents pago1 As TextBox
    Friend WithEvents iva As TextBox
    Friend WithEvents pago2 As TextBox
    Friend WithEvents desc As TextBox
    Friend WithEvents pago3 As TextBox
End Class
