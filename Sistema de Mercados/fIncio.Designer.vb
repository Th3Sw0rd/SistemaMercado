<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fIncio
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnFacturar = New System.Windows.Forms.Button()
        Me.btnPuestos = New System.Windows.Forms.Button()
        Me.btnMercados = New System.Windows.Forms.Button()
        Me.btnAlmacen = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.btnFacturar)
        Me.Panel2.Controls.Add(Me.btnPuestos)
        Me.Panel2.Controls.Add(Me.btnMercados)
        Me.Panel2.Controls.Add(Me.btnAlmacen)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(295, 424)
        Me.Panel2.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(0, 162)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(295, 56)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Propietarios"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(0, 312)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(295, 56)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Buscar Facturas"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnFacturar
        '
        Me.btnFacturar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnFacturar.ForeColor = System.Drawing.Color.Black
        Me.btnFacturar.Location = New System.Drawing.Point(0, 368)
        Me.btnFacturar.Name = "btnFacturar"
        Me.btnFacturar.Size = New System.Drawing.Size(295, 56)
        Me.btnFacturar.TabIndex = 4
        Me.btnFacturar.Text = "Facturar"
        Me.btnFacturar.UseVisualStyleBackColor = True
        '
        'btnPuestos
        '
        Me.btnPuestos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPuestos.ForeColor = System.Drawing.Color.Black
        Me.btnPuestos.Location = New System.Drawing.Point(0, 106)
        Me.btnPuestos.Name = "btnPuestos"
        Me.btnPuestos.Size = New System.Drawing.Size(295, 56)
        Me.btnPuestos.TabIndex = 3
        Me.btnPuestos.Text = "Puestos"
        Me.btnPuestos.UseVisualStyleBackColor = True
        '
        'btnMercados
        '
        Me.btnMercados.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMercados.ForeColor = System.Drawing.Color.Black
        Me.btnMercados.Location = New System.Drawing.Point(0, 53)
        Me.btnMercados.Name = "btnMercados"
        Me.btnMercados.Size = New System.Drawing.Size(295, 53)
        Me.btnMercados.TabIndex = 2
        Me.btnMercados.Text = "Mercados"
        Me.btnMercados.UseVisualStyleBackColor = True
        '
        'btnAlmacen
        '
        Me.btnAlmacen.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAlmacen.ForeColor = System.Drawing.Color.Black
        Me.btnAlmacen.Location = New System.Drawing.Point(0, 0)
        Me.btnAlmacen.Name = "btnAlmacen"
        Me.btnAlmacen.Size = New System.Drawing.Size(295, 53)
        Me.btnAlmacen.TabIndex = 1
        Me.btnAlmacen.Text = "Almacenes"
        Me.btnAlmacen.UseVisualStyleBackColor = True
        '
        'fIncio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(295, 424)
        Me.Controls.Add(Me.Panel2)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "fIncio"
        Me.Text = "Inicio"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnAlmacen As Button
    Friend WithEvents btnPuestos As Button
    Friend WithEvents btnMercados As Button
    Friend WithEvents btnFacturar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
