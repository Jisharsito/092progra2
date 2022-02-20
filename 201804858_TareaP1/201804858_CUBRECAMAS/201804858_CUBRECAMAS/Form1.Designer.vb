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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grande = New System.Windows.Forms.RadioButton()
        Me.medio = New System.Windows.Forms.RadioButton()
        Me.peque = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lona = New System.Windows.Forms.RadioButton()
        Me.seda = New System.Windows.Forms.RadioButton()
        Me.algo = New System.Windows.Forms.RadioButton()
        Me.cant = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.costo = New System.Windows.Forms.TextBox()
        Me.resultado = New System.Windows.Forms.TextBox()
        Me.venta = New System.Windows.Forms.TextBox()
        Me.limpiar = New System.Windows.Forms.Button()
        Me.result = New System.Windows.Forms.Button()
        Me.salir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grande)
        Me.GroupBox1.Controls.Add(Me.medio)
        Me.GroupBox1.Controls.Add(Me.peque)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(337, 51)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Talla"
        '
        'grande
        '
        Me.grande.AutoSize = True
        Me.grande.Location = New System.Drawing.Point(222, 22)
        Me.grande.Name = "grande"
        Me.grande.Size = New System.Drawing.Size(54, 19)
        Me.grande.TabIndex = 2
        Me.grande.TabStop = True
        Me.grande.Text = "Large"
        Me.grande.UseVisualStyleBackColor = True
        '
        'medio
        '
        Me.medio.AutoSize = True
        Me.medio.Location = New System.Drawing.Point(119, 22)
        Me.medio.Name = "medio"
        Me.medio.Size = New System.Drawing.Size(70, 19)
        Me.medio.TabIndex = 1
        Me.medio.TabStop = True
        Me.medio.Text = "Medium"
        Me.medio.UseVisualStyleBackColor = True
        '
        'peque
        '
        Me.peque.AutoSize = True
        Me.peque.Location = New System.Drawing.Point(16, 22)
        Me.peque.Name = "peque"
        Me.peque.Size = New System.Drawing.Size(54, 19)
        Me.peque.TabIndex = 0
        Me.peque.TabStop = True
        Me.peque.Text = "Small"
        Me.peque.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lona)
        Me.GroupBox2.Controls.Add(Me.seda)
        Me.GroupBox2.Controls.Add(Me.algo)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 85)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(337, 60)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Material"
        '
        'lona
        '
        Me.lona.AutoSize = True
        Me.lona.Location = New System.Drawing.Point(222, 22)
        Me.lona.Name = "lona"
        Me.lona.Size = New System.Drawing.Size(51, 19)
        Me.lona.TabIndex = 5
        Me.lona.TabStop = True
        Me.lona.Text = "Lona"
        Me.lona.UseVisualStyleBackColor = True
        '
        'seda
        '
        Me.seda.AutoSize = True
        Me.seda.Location = New System.Drawing.Point(119, 22)
        Me.seda.Name = "seda"
        Me.seda.Size = New System.Drawing.Size(50, 19)
        Me.seda.TabIndex = 4
        Me.seda.TabStop = True
        Me.seda.Text = "Seda"
        Me.seda.UseVisualStyleBackColor = True
        '
        'algo
        '
        Me.algo.AutoSize = True
        Me.algo.Location = New System.Drawing.Point(16, 22)
        Me.algo.Name = "algo"
        Me.algo.Size = New System.Drawing.Size(71, 19)
        Me.algo.TabIndex = 3
        Me.algo.TabStop = True
        Me.algo.Text = "Algodón"
        Me.algo.UseVisualStyleBackColor = True
        '
        'cant
        '
        Me.cant.Location = New System.Drawing.Point(79, 167)
        Me.cant.Name = "cant"
        Me.cant.Size = New System.Drawing.Size(81, 23)
        Me.cant.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cantidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(400, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Precio de Costo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(400, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "total"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(400, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Precio de venta unitaria"
        '
        'costo
        '
        Me.costo.Location = New System.Drawing.Point(563, 39)
        Me.costo.Name = "costo"
        Me.costo.ReadOnly = True
        Me.costo.Size = New System.Drawing.Size(100, 23)
        Me.costo.TabIndex = 7
        '
        'resultado
        '
        Me.resultado.Location = New System.Drawing.Point(563, 107)
        Me.resultado.Name = "resultado"
        Me.resultado.ReadOnly = True
        Me.resultado.Size = New System.Drawing.Size(100, 23)
        Me.resultado.TabIndex = 8
        '
        'venta
        '
        Me.venta.Location = New System.Drawing.Point(563, 73)
        Me.venta.Name = "venta"
        Me.venta.ReadOnly = True
        Me.venta.Size = New System.Drawing.Size(100, 23)
        Me.venta.TabIndex = 9
        '
        'limpiar
        '
        Me.limpiar.Location = New System.Drawing.Point(34, 214)
        Me.limpiar.Name = "limpiar"
        Me.limpiar.Size = New System.Drawing.Size(75, 23)
        Me.limpiar.TabIndex = 10
        Me.limpiar.Text = "Limpiar"
        Me.limpiar.UseVisualStyleBackColor = True
        '
        'result
        '
        Me.result.Location = New System.Drawing.Point(217, 170)
        Me.result.Name = "result"
        Me.result.Size = New System.Drawing.Size(75, 23)
        Me.result.TabIndex = 11
        Me.result.Text = "Aplicar"
        Me.result.UseVisualStyleBackColor = True
        '
        'salir
        '
        Me.salir.Location = New System.Drawing.Point(588, 214)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(75, 23)
        Me.salir.TabIndex = 12
        Me.salir.Text = "Salir"
        Me.salir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 249)
        Me.Controls.Add(Me.salir)
        Me.Controls.Add(Me.result)
        Me.Controls.Add(Me.limpiar)
        Me.Controls.Add(Me.venta)
        Me.Controls.Add(Me.resultado)
        Me.Controls.Add(Me.costo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cant)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents grande As RadioButton
    Friend WithEvents medio As RadioButton
    Friend WithEvents peque As RadioButton
    Friend WithEvents lona As RadioButton
    Friend WithEvents seda As RadioButton
    Friend WithEvents algo As RadioButton
    Friend WithEvents cant As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents costo As TextBox
    Friend WithEvents resultado As TextBox
    Friend WithEvents venta As TextBox
    Friend WithEvents limpiar As Button
    Friend WithEvents result As Button
    Friend WithEvents salir As Button
End Class
