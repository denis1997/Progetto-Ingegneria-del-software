<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form15
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(518, 708)
        Me.Button6.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(569, 93)
        Me.Button6.TabIndex = 11
        Me.Button6.Text = "Rimuovi area del piano"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(518, 437)
        Me.Button5.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(569, 93)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Rimuovi piano"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(518, 572)
        Me.Button4.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(569, 93)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Rimuovi area all'aperto"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(518, 301)
        Me.Button3.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(569, 93)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Rimuovi edificio"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(518, 164)
        Me.Button2.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(569, 93)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Rimuovi zona"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(518, 28)
        Me.Button1.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(569, 93)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Rimuovi città"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form15
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1605, 828)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form15"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form15"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
