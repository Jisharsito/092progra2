<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.valor = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.colones = New System.Windows.Forms.RadioButton()
        Me.peso = New System.Windows.Forms.RadioButton()
        Me.euro = New System.Windows.Forms.RadioButton()
        Me.dolar = New System.Windows.Forms.RadioButton()
        Me.total = New System.Windows.Forms.Button()
        Me.salir = New System.Windows.Forms.Button()
        Me.limpiar = New System.Windows.Forms.Button()
        Me.final = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(19, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "COMPRA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(227, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cantidad de Quetzales que desea cambiar"
        '
        'valor
        '
        Me.valor.Location = New System.Drawing.Point(118, 80)
        Me.valor.Name = "valor"
        Me.valor.Size = New System.Drawing.Size(100, 23)
        Me.valor.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.colones)
        Me.GroupBox1.Controls.Add(Me.peso)
        Me.GroupBox1.Controls.Add(Me.euro)
        Me.GroupBox1.Controls.Add(Me.dolar)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 116)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(329, 78)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Moneda que desea"
        '
        'colones
        '
        Me.colones.AutoSize = True
        Me.colones.Location = New System.Drawing.Point(168, 53)
        Me.colones.Name = "colones"
        Me.colones.Size = New System.Drawing.Size(147, 19)
        Me.colones.TabIndex = 3
        Me.colones.TabStop = True
        Me.colones.Text = "Colones constarricense"
        Me.colones.UseVisualStyleBackColor = True
        '
        'peso
        '
        Me.peso.AutoSize = True
        Me.peso.Location = New System.Drawing.Point(168, 29)
        Me.peso.Name = "peso"
        Me.peso.Size = New System.Drawing.Size(115, 19)
        Me.peso.TabIndex = 2
        Me.peso.TabStop = True
        Me.peso.Text = "Pesos Mexicanos"
        Me.peso.UseVisualStyleBackColor = True
        '
        'euro
        '
        Me.euro.AutoSize = True
        Me.euro.Location = New System.Drawing.Point(17, 54)
        Me.euro.Name = "euro"
        Me.euro.Size = New System.Drawing.Size(54, 19)
        Me.euro.TabIndex = 1
        Me.euro.TabStop = True
        Me.euro.Text = "Euros"
        Me.euro.UseVisualStyleBackColor = True
        '
        'dolar
        '
        Me.dolar.AutoSize = True
        Me.dolar.Location = New System.Drawing.Point(17, 29)
        Me.dolar.Name = "dolar"
        Me.dolar.Size = New System.Drawing.Size(53, 19)
        Me.dolar.TabIndex = 0
        Me.dolar.TabStop = True
        Me.dolar.Text = "Dolar"
        Me.dolar.UseVisualStyleBackColor = True
        '
        'total
        '
        Me.total.Location = New System.Drawing.Point(130, 221)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(75, 23)
        Me.total.TabIndex = 4
        Me.total.Text = "Total"
        Me.total.UseVisualStyleBackColor = True
        '
        'salir
        '
        Me.salir.Location = New System.Drawing.Point(272, 331)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(75, 23)
        Me.salir.TabIndex = 5
        Me.salir.Text = "Salir"
        Me.salir.UseVisualStyleBackColor = True
        '
        'limpiar
        '
        Me.limpiar.Location = New System.Drawing.Point(12, 331)
        Me.limpiar.Name = "limpiar"
        Me.limpiar.Size = New System.Drawing.Size(75, 23)
        Me.limpiar.TabIndex = 6
        Me.limpiar.Text = "limpiar"
        Me.limpiar.UseVisualStyleBackColor = True
        '
        'final
        '
        Me.final.Location = New System.Drawing.Point(118, 276)
        Me.final.Name = "final"
        Me.final.ReadOnly = True
        Me.final.Size = New System.Drawing.Size(100, 23)
        Me.final.TabIndex = 7
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 366)
        Me.Controls.Add(Me.final)
        Me.Controls.Add(Me.limpiar)
        Me.Controls.Add(Me.salir)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.valor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents valor As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents colones As RadioButton
    Friend WithEvents peso As RadioButton
    Friend WithEvents euro As RadioButton
    Friend WithEvents dolar As RadioButton
    Friend WithEvents total As Button
    Friend WithEvents salir As Button
    Friend WithEvents limpiar As Button
    Friend WithEvents final As TextBox
End Class
