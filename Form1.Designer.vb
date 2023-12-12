<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.dateAnfangDesArbeitsverhältnisses = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dateKündigungsTag = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbProbezeit = New System.Windows.Forms.CheckBox()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.btnEnde = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(37, 70)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(183, 22)
        Me.txtName.TabIndex = 0
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(32, 41)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(123, 34)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "MA Name"
        '
        'dateAnfangDesArbeitsverhältnisses
        '
        Me.dateAnfangDesArbeitsverhältnisses.Enabled = False
        Me.dateAnfangDesArbeitsverhältnisses.Location = New System.Drawing.Point(36, 146)
        Me.dateAnfangDesArbeitsverhältnisses.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dateAnfangDesArbeitsverhältnisses.Name = "dateAnfangDesArbeitsverhältnisses"
        Me.dateAnfangDesArbeitsverhältnisses.Size = New System.Drawing.Size(225, 22)
        Me.dateAnfangDesArbeitsverhältnisses.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Beginn des Arbeitverhältnisses"
        '
        'dateKündigungsTag
        '
        Me.dateKündigungsTag.Location = New System.Drawing.Point(36, 248)
        Me.dateKündigungsTag.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dateKündigungsTag.Name = "dateKündigungsTag"
        Me.dateKündigungsTag.Size = New System.Drawing.Size(225, 22)
        Me.dateKündigungsTag.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Kündigungstag"
        '
        'cbProbezeit
        '
        Me.cbProbezeit.AutoSize = True
        Me.cbProbezeit.Enabled = False
        Me.cbProbezeit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProbezeit.Location = New System.Drawing.Point(37, 300)
        Me.cbProbezeit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbProbezeit.Name = "cbProbezeit"
        Me.cbProbezeit.Size = New System.Drawing.Size(107, 26)
        Me.cbProbezeit.TabIndex = 6
        Me.cbProbezeit.Text = "Probezeit"
        Me.cbProbezeit.UseVisualStyleBackColor = True
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(36, 373)
        Me.btnCheck.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(184, 47)
        Me.btnCheck.TabIndex = 8
        Me.btnCheck.Text = "Berechnen"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'btnEnde
        '
        Me.btnEnde.Location = New System.Drawing.Point(36, 424)
        Me.btnEnde.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEnde.Name = "btnEnde"
        Me.btnEnde.Size = New System.Drawing.Size(184, 47)
        Me.btnEnde.TabIndex = 9
        Me.btnEnde.Text = "Ende"
        Me.btnEnde.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(36, 330)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(75, 26)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.Text = "TV-H"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCheck
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 503)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnEnde)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.cbProbezeit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dateKündigungsTag)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dateAnfangDesArbeitsverhältnisses)
        Me.Controls.Add(Me.lblName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Kündigungsrechner"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents dateAnfangDesArbeitsverhältnisses As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents dateKündigungsTag As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents cbProbezeit As CheckBox
    Friend WithEvents btnCheck As Button
    Friend WithEvents btnEnde As Button
    Friend WithEvents CheckBox1 As CheckBox
End Class
