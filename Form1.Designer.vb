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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.dateAnfangDesArbeitsverhältnisses = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dateKündigungsTag = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbProbezeit = New System.Windows.Forms.CheckBox()
        Me.lblAusgabe = New System.Windows.Forms.Label()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.btnEnde = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(28, 55)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(138, 20)
        Me.txtName.TabIndex = 0
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Arial Narrow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(24, 26)
        Me.lblName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(61, 26)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name"
        '
        'dateAnfangDesArbeitsverhältnisses
        '
        Me.dateAnfangDesArbeitsverhältnisses.Enabled = False
        Me.dateAnfangDesArbeitsverhältnisses.Location = New System.Drawing.Point(28, 107)
        Me.dateAnfangDesArbeitsverhältnisses.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dateAnfangDesArbeitsverhältnisses.Name = "dateAnfangDesArbeitsverhältnisses"
        Me.dateAnfangDesArbeitsverhältnisses.Size = New System.Drawing.Size(170, 20)
        Me.dateAnfangDesArbeitsverhältnisses.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 85)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Beginn des Arbeitverhältnisses"
        '
        'dateKündigungsTag
        '
        Me.dateKündigungsTag.Location = New System.Drawing.Point(261, 107)
        Me.dateKündigungsTag.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dateKündigungsTag.Name = "dateKündigungsTag"
        Me.dateKündigungsTag.Size = New System.Drawing.Size(170, 20)
        Me.dateKündigungsTag.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(259, 85)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Kündigungstag"
        '
        'cbProbezeit
        '
        Me.cbProbezeit.AutoSize = True
        Me.cbProbezeit.Enabled = False
        Me.cbProbezeit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProbezeit.Location = New System.Drawing.Point(28, 140)
        Me.cbProbezeit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbProbezeit.Name = "cbProbezeit"
        Me.cbProbezeit.Size = New System.Drawing.Size(90, 22)
        Me.cbProbezeit.TabIndex = 6
        Me.cbProbezeit.Text = "Probezeit"
        Me.cbProbezeit.UseVisualStyleBackColor = True
        '
        'lblAusgabe
        '
        Me.lblAusgabe.AutoSize = True
        Me.lblAusgabe.Font = New System.Drawing.Font("Arial Narrow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAusgabe.Location = New System.Drawing.Point(25, 277)
        Me.lblAusgabe.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAusgabe.Name = "lblAusgabe"
        Me.lblAusgabe.Size = New System.Drawing.Size(27, 26)
        Me.lblAusgabe.TabIndex = 7
        Me.lblAusgabe.Text = "..."
        Me.lblAusgabe.Visible = False
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(28, 182)
        Me.btnCheck.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(138, 38)
        Me.btnCheck.TabIndex = 8
        Me.btnCheck.Text = "Berechnen"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'btnEnde
        '
        Me.btnEnde.Location = New System.Drawing.Point(261, 182)
        Me.btnEnde.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEnde.Name = "btnEnde"
        Me.btnEnde.Size = New System.Drawing.Size(138, 38)
        Me.btnEnde.TabIndex = 9
        Me.btnEnde.Text = "Ende"
        Me.btnEnde.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCheck
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 344)
        Me.Controls.Add(Me.btnEnde)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.lblAusgabe)
        Me.Controls.Add(Me.cbProbezeit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dateKündigungsTag)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dateAnfangDesArbeitsverhältnisses)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtName)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
    Friend WithEvents lblAusgabe As Label
    Friend WithEvents btnCheck As Button
    Friend WithEvents btnEnde As Button
End Class
