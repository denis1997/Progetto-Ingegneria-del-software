<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.Location = New System.Drawing.Point(46, 381)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(266, 122)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Edifici"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Green
        Me.Button2.Location = New System.Drawing.Point(46, 756)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(266, 122)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Aree all'aperto"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Green
        Me.Button3.Location = New System.Drawing.Point(346, 40)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(266, 122)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Piazze"
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Green
        Me.Button4.Location = New System.Drawing.Point(346, 208)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(266, 122)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Parchi"
        Me.Button4.UseVisualStyleBackColor = False
        Me.Button4.Visible = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Green
        Me.Button5.Location = New System.Drawing.Point(346, 394)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(266, 122)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Vie"
        Me.Button5.UseVisualStyleBackColor = False
        Me.Button5.Visible = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Green
        Me.Button6.Location = New System.Drawing.Point(346, 575)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(266, 122)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Parcheggi"
        Me.Button6.UseVisualStyleBackColor = False
        Me.Button6.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1914, 1127)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class
