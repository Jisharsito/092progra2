<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.colones = New System.Windows.Forms.RadioButton()
        Me.euro = New System.Windows.Forms.RadioButton()
        Me.peso = New System.Windows.Forms.RadioButton()
        Me.dolar = New System.Windows.Forms.RadioButton()
        Me.valor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pagoF = New System.Windows.Forms.Button()
        Me.resultadoV = New System.Windows.Forms.TextBox()
        Me.salir2 = New System.Windows.Forms.Button()
        Me.limpiar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.colones)
        Me.GroupBox1.Controls.Add(Me.euro)
        Me.GroupBox1.Controls.Add(Me.peso)
        Me.GroupBox1.Controls.Add(Me.dolar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 131)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(314, 77)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de moneda"
        '
        'colones
        '
        Me.colones.AutoSize = True
        Me.colones.Location = New System.Drawing.Point(164, 47)
        Me.colones.Name = "colones"
        Me.colones.Size = New System.Drawing.Size(142, 19)
        Me.colones.TabIndex = 3
        Me.colones.TabStop = True
        Me.colones.Text = "Colones Costarricense"
        Me.colones.UseVisualStyleBackColor = True
        '
        'euro
        '
        Me.euro.AutoSize = True
        Me.euro.Location = New System.Drawing.Point(22, 47)
        Me.euro.Name = "euro"
        Me.euro.Size = New System.Drawing.Size(54, 19)
        Me.euro.TabIndex = 2
        Me.euro.TabStop = True
        Me.euro.Text = "Euros"
        Me.euro.UseVisualStyleBackColor = True
        '
        'peso
        '
        Me.peso.AutoSize = True
        Me.peso.Location = New System.Drawing.Point(164, 22)
        Me.peso.Name = "peso"
        Me.peso.Size = New System.Drawing.Size(105, 19)
        Me.peso.TabIndex = 1
        Me.peso.TabStop = True
        Me.peso.Text = "Peso Mexicano"
        Me.peso.UseVisualStyleBackColor = True
        '
        'dolar
        '
        Me.dolar.AutoSize = True
        Me.dolar.Location = New System.Drawing.Point(22, 22)
        Me.dolar.Name = "dolar"
        Me.dolar.Size = New System.Drawing.Size(53, 19)
        Me.dolar.TabIndex = 0
        Me.dolar.TabStop = True
        Me.dolar.Text = "Dolar"
        Me.dolar.UseVisualStyleBackColor = True
        '
        'valor
        '
        Me.valor.Location = New System.Drawing.Point(111, 102)
        Me.valor.Name = "valor"
        Me.valor.Size = New System.Drawing.Size(100, 23)
        Me.valor.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(23, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "VENTA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(204, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ingrese la cantidad que desea vender."
        '
        'pagoF
        '
        Me.pagoF.Location = New System.Drawing.Point(115, 225)
        Me.pagoF.Name = "pagoF"
        Me.pagoF.Size = New System.Drawing.Size(111, 23)
        Me.pagoF.TabIndex = 4
        Me.pagoF.Text = "Resultado Final"
        Me.pagoF.UseVisualStyleBackColor = True
        '
        'resultadoV
        '
        Me.resultadoV.Location = New System.Drawing.Point(126, 278)
        Me.resultadoV.Name = "resultadoV"
        Me.resultadoV.ReadOnly = True
        Me.resultadoV.Size = New System.Drawing.Size(85, 23)
        Me.resultadoV.TabIndex = 5
        '
        'salir2
        '
        Me.salir2.Location = New System.Drawing.Point(243, 323)
        Me.salir2.Name = "salir2"
        Me.salir2.Size = New System.Drawing.Size(75, 23)
        Me.salir2.TabIndex = 6
        Me.salir2.Text = "Salir"
        Me.salir2.UseVisualStyleBackColor = True
        '
        'limpiar
        '
        Me.limpiar.Location = New System.Drawing.Point(8, 323)
        Me.limpiar.Name = "limpiar"
        Me.limpiar.Size = New System.Drawing.Size(75, 23)
        Me.limpiar.TabIndex = 7
        Me.limpiar.Text = "Limpiar"
        Me.limpiar.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 358)
        Me.Controls.Add(Me.limpiar)
        Me.Controls.Add(Me.salir2)
        Me.Controls.Add(Me.resultadoV)
        Me.Controls.Add(Me.pagoF)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.valor)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents valor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents colones As RadioButton
    Friend WithEvents euro As RadioButton
    Friend WithEvents peso As RadioButton
    Friend WithEvents dolar As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents pagoF As Button
    Friend WithEvents resultadoV As TextBox
    Friend WithEvents salir2 As Button
    Friend WithEvents limpiar As Button
End Class
