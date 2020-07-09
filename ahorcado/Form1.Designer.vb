<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btnComprobar = New System.Windows.Forms.Button()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Salir = New System.Windows.Forms.Button()
        Me.lblGuiones = New System.Windows.Forms.Label()
        Me.lbl_Fallo = New System.Windows.Forms.Label()
        Me.btn_DeNuevo = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnComprobar
        '
        Me.btnComprobar.Location = New System.Drawing.Point(316, 142)
        Me.btnComprobar.Name = "btnComprobar"
        Me.btnComprobar.Size = New System.Drawing.Size(118, 50)
        Me.btnComprobar.TabIndex = 0
        Me.btnComprobar.Text = "Comprueba"
        Me.btnComprobar.UseVisualStyleBackColor = True
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(316, 98)
        Me.txt1.Multiline = True
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(118, 20)
        Me.txt1.TabIndex = 1
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(313, 59)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(96, 13)
        Me.lbl1.TabIndex = 2
        Me.lbl1.Text = "Introduce una letra"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(41, 59)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(219, 133)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(505, 329)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 23)
        Me.Salir.TabIndex = 4
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'lblGuiones
        '
        Me.lblGuiones.AutoSize = True
        Me.lblGuiones.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuiones.Location = New System.Drawing.Point(64, 247)
        Me.lblGuiones.Name = "lblGuiones"
        Me.lblGuiones.Size = New System.Drawing.Size(0, 25)
        Me.lblGuiones.TabIndex = 6
        '
        'lbl_Fallo
        '
        Me.lbl_Fallo.AutoSize = True
        Me.lbl_Fallo.Font = New System.Drawing.Font("Mongolian Baiti", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Fallo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_Fallo.Location = New System.Drawing.Point(266, 55)
        Me.lbl_Fallo.Name = "lbl_Fallo"
        Me.lbl_Fallo.Size = New System.Drawing.Size(463, 71)
        Me.lbl_Fallo.TabIndex = 7
        Me.lbl_Fallo.Text = "HAS MUERTO"
        Me.lbl_Fallo.Visible = False
        '
        'btn_DeNuevo
        '
        Me.btn_DeNuevo.Location = New System.Drawing.Point(316, 142)
        Me.btn_DeNuevo.Name = "btn_DeNuevo"
        Me.btn_DeNuevo.Size = New System.Drawing.Size(140, 50)
        Me.btn_DeNuevo.TabIndex = 8
        Me.btn_DeNuevo.Text = "Jugar de nuevo"
        Me.btn_DeNuevo.UseVisualStyleBackColor = True
        Me.btn_DeNuevo.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 371)
        Me.Controls.Add(Me.btn_DeNuevo)
        Me.Controls.Add(Me.lbl_Fallo)
        Me.Controls.Add(Me.lblGuiones)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.btnComprobar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnComprobar As Button
    Friend WithEvents txt1 As TextBox
    Friend WithEvents lbl1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Salir As Button
    Friend WithEvents lblGuiones As Label
    Friend WithEvents lbl_Fallo As Label
    Friend WithEvents btn_DeNuevo As Button
End Class
