<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PIANO1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PIANO2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.STANZA1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.STANZA2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Corridoio1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Corridoio1ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Piano1ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Piano2ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Piano3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Piano1ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Piano2ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Piano1ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Piano2ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Piano3ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AreaMedicinaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Piano3ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Piano1ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Piano2ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Piano3ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VialeVittoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VialeDAnnunzioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParcheggiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PIANO1ToolStripMenuItem, Me.PIANO2ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Margin = New System.Windows.Forms.Padding(10)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(207, 450)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PIANO1ToolStripMenuItem
        '
        Me.PIANO1ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.STANZA1ToolStripMenuItem, Me.STANZA2ToolStripMenuItem, Me.Corridoio1ToolStripMenuItem1, Me.AreaMedicinaToolStripMenuItem})
        Me.PIANO1ToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PIANO1ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.PIANO1ToolStripMenuItem.Margin = New System.Windows.Forms.Padding(5, 150, 0, 0)
        Me.PIANO1ToolStripMenuItem.Name = "PIANO1ToolStripMenuItem"
        Me.PIANO1ToolStripMenuItem.Size = New System.Drawing.Size(189, 34)
        Me.PIANO1ToolStripMenuItem.Text = "EDIFICI"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(396, 51)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(367, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "DASHBOARD GESTORE DI ZONA"
        '
        'PIANO2ToolStripMenuItem
        '
        Me.PIANO2ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Corridoio1ToolStripMenuItem, Me.VialeVittoriaToolStripMenuItem, Me.VialeDAnnunzioToolStripMenuItem, Me.ParcheggiToolStripMenuItem})
        Me.PIANO2ToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PIANO2ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.PIANO2ToolStripMenuItem.Margin = New System.Windows.Forms.Padding(5, 150, 0, 0)
        Me.PIANO2ToolStripMenuItem.Name = "PIANO2ToolStripMenuItem"
        Me.PIANO2ToolStripMenuItem.Size = New System.Drawing.Size(189, 34)
        Me.PIANO2ToolStripMenuItem.Text = "AREE ALL'APERTO"
        '
        'STANZA1ToolStripMenuItem
        '
        Me.STANZA1ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Piano1ToolStripMenuItem1, Me.Piano2ToolStripMenuItem1, Me.Piano3ToolStripMenuItem})
        Me.STANZA1ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.STANZA1ToolStripMenuItem.Name = "STANZA1ToolStripMenuItem"
        Me.STANZA1ToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.STANZA1ToolStripMenuItem.Size = New System.Drawing.Size(222, 34)
        Me.STANZA1ToolStripMenuItem.Text = "Blocco 0"
        '
        'STANZA2ToolStripMenuItem
        '
        Me.STANZA2ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Piano1ToolStripMenuItem2, Me.Piano2ToolStripMenuItem2, Me.Piano3ToolStripMenuItem2})
        Me.STANZA2ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.STANZA2ToolStripMenuItem.Name = "STANZA2ToolStripMenuItem"
        Me.STANZA2ToolStripMenuItem.Size = New System.Drawing.Size(222, 34)
        Me.STANZA2ToolStripMenuItem.Text = "Blocco 1"
        '
        'Corridoio1ToolStripMenuItem
        '
        Me.Corridoio1ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Corridoio1ToolStripMenuItem.Name = "Corridoio1ToolStripMenuItem"
        Me.Corridoio1ToolStripMenuItem.Size = New System.Drawing.Size(180, 34)
        Me.Corridoio1ToolStripMenuItem.Text = "Piazze"
        '
        'Corridoio1ToolStripMenuItem1
        '
        Me.Corridoio1ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Piano1ToolStripMenuItem3, Me.Piano2ToolStripMenuItem3, Me.Piano3ToolStripMenuItem1})
        Me.Corridoio1ToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Corridoio1ToolStripMenuItem1.Name = "Corridoio1ToolStripMenuItem1"
        Me.Corridoio1ToolStripMenuItem1.Size = New System.Drawing.Size(222, 34)
        Me.Corridoio1ToolStripMenuItem1.Text = "Blocco 2"
        '
        'Piano1ToolStripMenuItem1
        '
        Me.Piano1ToolStripMenuItem1.Name = "Piano1ToolStripMenuItem1"
        Me.Piano1ToolStripMenuItem1.Size = New System.Drawing.Size(157, 34)
        Me.Piano1ToolStripMenuItem1.Text = "Piano 1"
        '
        'Piano2ToolStripMenuItem1
        '
        Me.Piano2ToolStripMenuItem1.Name = "Piano2ToolStripMenuItem1"
        Me.Piano2ToolStripMenuItem1.Size = New System.Drawing.Size(157, 34)
        Me.Piano2ToolStripMenuItem1.Text = "Piano 2"
        '
        'Piano3ToolStripMenuItem
        '
        Me.Piano3ToolStripMenuItem.Name = "Piano3ToolStripMenuItem"
        Me.Piano3ToolStripMenuItem.Size = New System.Drawing.Size(157, 34)
        Me.Piano3ToolStripMenuItem.Text = "Piano 3"
        '
        'Piano1ToolStripMenuItem2
        '
        Me.Piano1ToolStripMenuItem2.Name = "Piano1ToolStripMenuItem2"
        Me.Piano1ToolStripMenuItem2.Size = New System.Drawing.Size(163, 34)
        Me.Piano1ToolStripMenuItem2.Text = "Piano 1"
        '
        'Piano2ToolStripMenuItem2
        '
        Me.Piano2ToolStripMenuItem2.Name = "Piano2ToolStripMenuItem2"
        Me.Piano2ToolStripMenuItem2.Size = New System.Drawing.Size(163, 34)
        Me.Piano2ToolStripMenuItem2.Text = "Piano 2 "
        '
        'Piano1ToolStripMenuItem3
        '
        Me.Piano1ToolStripMenuItem3.Name = "Piano1ToolStripMenuItem3"
        Me.Piano1ToolStripMenuItem3.Size = New System.Drawing.Size(180, 34)
        Me.Piano1ToolStripMenuItem3.Text = "Piano 1"
        '
        'Piano2ToolStripMenuItem3
        '
        Me.Piano2ToolStripMenuItem3.Name = "Piano2ToolStripMenuItem3"
        Me.Piano2ToolStripMenuItem3.Size = New System.Drawing.Size(180, 34)
        Me.Piano2ToolStripMenuItem3.Text = "Piano 2"
        '
        'Piano3ToolStripMenuItem1
        '
        Me.Piano3ToolStripMenuItem1.Name = "Piano3ToolStripMenuItem1"
        Me.Piano3ToolStripMenuItem1.Size = New System.Drawing.Size(180, 34)
        Me.Piano3ToolStripMenuItem1.Text = "Piano 3"
        '
        'AreaMedicinaToolStripMenuItem
        '
        Me.AreaMedicinaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Piano1ToolStripMenuItem4, Me.Piano2ToolStripMenuItem4, Me.Piano3ToolStripMenuItem3})
        Me.AreaMedicinaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.AreaMedicinaToolStripMenuItem.Name = "AreaMedicinaToolStripMenuItem"
        Me.AreaMedicinaToolStripMenuItem.Size = New System.Drawing.Size(222, 34)
        Me.AreaMedicinaToolStripMenuItem.Text = "Area Medicina"
        '
        'Piano3ToolStripMenuItem2
        '
        Me.Piano3ToolStripMenuItem2.Name = "Piano3ToolStripMenuItem2"
        Me.Piano3ToolStripMenuItem2.Size = New System.Drawing.Size(163, 34)
        Me.Piano3ToolStripMenuItem2.Text = "Piano 3"
        '
        'Piano1ToolStripMenuItem4
        '
        Me.Piano1ToolStripMenuItem4.Name = "Piano1ToolStripMenuItem4"
        Me.Piano1ToolStripMenuItem4.Size = New System.Drawing.Size(157, 34)
        Me.Piano1ToolStripMenuItem4.Text = "Piano 1"
        '
        'Piano2ToolStripMenuItem4
        '
        Me.Piano2ToolStripMenuItem4.Name = "Piano2ToolStripMenuItem4"
        Me.Piano2ToolStripMenuItem4.Size = New System.Drawing.Size(157, 34)
        Me.Piano2ToolStripMenuItem4.Text = "Piano 2"
        '
        'Piano3ToolStripMenuItem3
        '
        Me.Piano3ToolStripMenuItem3.Name = "Piano3ToolStripMenuItem3"
        Me.Piano3ToolStripMenuItem3.Size = New System.Drawing.Size(157, 34)
        Me.Piano3ToolStripMenuItem3.Text = "Piano 3"
        '
        'VialeVittoriaToolStripMenuItem
        '
        Me.VialeVittoriaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.VialeVittoriaToolStripMenuItem.Name = "VialeVittoriaToolStripMenuItem"
        Me.VialeVittoriaToolStripMenuItem.Size = New System.Drawing.Size(180, 34)
        Me.VialeVittoriaToolStripMenuItem.Text = "Parchi"
        '
        'VialeDAnnunzioToolStripMenuItem
        '
        Me.VialeDAnnunzioToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.VialeDAnnunzioToolStripMenuItem.Name = "VialeDAnnunzioToolStripMenuItem"
        Me.VialeDAnnunzioToolStripMenuItem.Size = New System.Drawing.Size(180, 34)
        Me.VialeDAnnunzioToolStripMenuItem.Text = "Vie"
        '
        'ParcheggiToolStripMenuItem
        '
        Me.ParcheggiToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.ParcheggiToolStripMenuItem.Name = "ParcheggiToolStripMenuItem"
        Me.ParcheggiToolStripMenuItem.Size = New System.Drawing.Size(180, 34)
        Me.ParcheggiToolStripMenuItem.Text = "Parcheggi"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Yellow
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(402, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 47)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "AGGIUNGI SENSORI"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Yellow
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(533, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 47)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "RIMUOVI SENSORI"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Yellow
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(664, 9)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(124, 47)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "MODIFICA MASSIMALE"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(49, 242)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(49, 57)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 76)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PIANO1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PIANO2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents STANZA1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents STANZA2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Corridoio1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Corridoio1ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Piano1ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Piano2ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Piano3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Piano1ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents Piano2ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents Piano3ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents Piano1ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents Piano2ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents Piano3ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AreaMedicinaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Piano1ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents Piano2ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents Piano3ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents VialeVittoriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VialeDAnnunzioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ParcheggiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
