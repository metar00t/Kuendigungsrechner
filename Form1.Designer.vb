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
        Me.BtnBerechnen = New System.Windows.Forms.Button()
        Me.btnEnde = New System.Windows.Forms.Button()
        Me.cbTVH = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NumMonateProbezeit = New System.Windows.Forms.NumericUpDown()
        Me.NumTVHMonate = New System.Windows.Forms.NumericUpDown()
        Me.LblProbezeit = New System.Windows.Forms.Label()
        Me.LblTVH = New System.Windows.Forms.Label()
        Me.LblTVHJahre = New System.Windows.Forms.Label()
        Me.NumTVHJahr = New System.Windows.Forms.NumericUpDown()
        Me.dateAktuellesDatum = New System.Windows.Forms.DateTimePicker()
        CType(Me.NumMonateProbezeit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumTVHMonate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumTVHJahr, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblName.Size = New System.Drawing.Size(98, 27)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "MA Name"
        '
        'dateAnfangDesArbeitsverhältnisses
        '
        Me.dateAnfangDesArbeitsverhältnisses.Enabled = False
        Me.dateAnfangDesArbeitsverhältnisses.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateAnfangDesArbeitsverhältnisses.Location = New System.Drawing.Point(36, 146)
        Me.dateAnfangDesArbeitsverhältnisses.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dateAnfangDesArbeitsverhältnisses.Name = "dateAnfangDesArbeitsverhältnisses"
        Me.dateAnfangDesArbeitsverhältnisses.Size = New System.Drawing.Size(108, 22)
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
        Me.dateKündigungsTag.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateKündigungsTag.Location = New System.Drawing.Point(36, 248)
        Me.dateKündigungsTag.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dateKündigungsTag.Name = "dateKündigungsTag"
        Me.dateKündigungsTag.Size = New System.Drawing.Size(108, 22)
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
        'BtnBerechnen
        '
        Me.BtnBerechnen.Location = New System.Drawing.Point(36, 420)
        Me.BtnBerechnen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnBerechnen.Name = "BtnBerechnen"
        Me.BtnBerechnen.Size = New System.Drawing.Size(184, 47)
        Me.BtnBerechnen.TabIndex = 8
        Me.BtnBerechnen.Text = "Berechnen"
        Me.BtnBerechnen.UseVisualStyleBackColor = True
        '
        'btnEnde
        '
        Me.btnEnde.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEnde.Location = New System.Drawing.Point(36, 471)
        Me.btnEnde.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEnde.Name = "btnEnde"
        Me.btnEnde.Size = New System.Drawing.Size(184, 47)
        Me.btnEnde.TabIndex = 9
        Me.btnEnde.Text = "Ende"
        Me.btnEnde.UseVisualStyleBackColor = True
        '
        'cbTVH
        '
        Me.cbTVH.AutoSize = True
        Me.cbTVH.Enabled = False
        Me.cbTVH.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTVH.Location = New System.Drawing.Point(201, 300)
        Me.cbTVH.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbTVH.Name = "cbTVH"
        Me.cbTVH.Size = New System.Drawing.Size(75, 26)
        Me.cbTVH.TabIndex = 10
        Me.cbTVH.Text = "TV-H"
        Me.cbTVH.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(275, 457)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 24)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Aktuelles Datum"
        '
        'NumMonateProbezeit
        '
        Me.NumMonateProbezeit.Location = New System.Drawing.Point(36, 346)
        Me.NumMonateProbezeit.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.NumMonateProbezeit.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumMonateProbezeit.Name = "NumMonateProbezeit"
        Me.NumMonateProbezeit.Size = New System.Drawing.Size(57, 22)
        Me.NumMonateProbezeit.TabIndex = 13
        Me.NumMonateProbezeit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumMonateProbezeit.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumMonateProbezeit.Visible = False
        '
        'NumTVHMonate
        '
        Me.NumTVHMonate.Location = New System.Drawing.Point(201, 357)
        Me.NumTVHMonate.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.NumTVHMonate.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumTVHMonate.Name = "NumTVHMonate"
        Me.NumTVHMonate.Size = New System.Drawing.Size(57, 22)
        Me.NumTVHMonate.TabIndex = 14
        Me.NumTVHMonate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumTVHMonate.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumTVHMonate.Visible = False
        '
        'LblProbezeit
        '
        Me.LblProbezeit.AutoSize = True
        Me.LblProbezeit.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProbezeit.Location = New System.Drawing.Point(109, 344)
        Me.LblProbezeit.Name = "LblProbezeit"
        Me.LblProbezeit.Size = New System.Drawing.Size(58, 24)
        Me.LblProbezeit.TabIndex = 15
        Me.LblProbezeit.Text = "Monat"
        Me.LblProbezeit.Visible = False
        '
        'LblTVH
        '
        Me.LblTVH.AutoSize = True
        Me.LblTVH.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTVH.Location = New System.Drawing.Point(274, 355)
        Me.LblTVH.Name = "LblTVH"
        Me.LblTVH.Size = New System.Drawing.Size(58, 24)
        Me.LblTVH.TabIndex = 16
        Me.LblTVH.Text = "Monat"
        Me.LblTVH.Visible = False
        '
        'LblTVHJahre
        '
        Me.LblTVHJahre.AutoSize = True
        Me.LblTVHJahre.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTVHJahre.Location = New System.Drawing.Point(439, 357)
        Me.LblTVHJahre.Name = "LblTVHJahre"
        Me.LblTVHJahre.Size = New System.Drawing.Size(44, 24)
        Me.LblTVHJahre.TabIndex = 18
        Me.LblTVHJahre.Text = "Jahr"
        Me.LblTVHJahre.Visible = False
        '
        'NumTVHJahr
        '
        Me.NumTVHJahr.Location = New System.Drawing.Point(366, 359)
        Me.NumTVHJahr.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.NumTVHJahr.Name = "NumTVHJahr"
        Me.NumTVHJahr.Size = New System.Drawing.Size(57, 22)
        Me.NumTVHJahr.TabIndex = 17
        Me.NumTVHJahr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumTVHJahr.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumTVHJahr.Visible = False
        '
        'dateAktuellesDatum
        '
        Me.dateAktuellesDatum.Enabled = False
        Me.dateAktuellesDatum.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateAktuellesDatum.Location = New System.Drawing.Point(279, 496)
        Me.dateAktuellesDatum.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dateAktuellesDatum.Name = "dateAktuellesDatum"
        Me.dateAktuellesDatum.Size = New System.Drawing.Size(131, 22)
        Me.dateAktuellesDatum.TabIndex = 4
        '
        'Form1
        '
        Me.AcceptButton = Me.BtnBerechnen
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnEnde
        Me.ClientSize = New System.Drawing.Size(422, 539)
        Me.Controls.Add(Me.LblTVH)
        Me.Controls.Add(Me.LblProbezeit)
        Me.Controls.Add(Me.NumTVHMonate)
        Me.Controls.Add(Me.NumMonateProbezeit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbTVH)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnEnde)
        Me.Controls.Add(Me.BtnBerechnen)
        Me.Controls.Add(Me.cbProbezeit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dateAktuellesDatum)
        Me.Controls.Add(Me.dateKündigungsTag)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dateAnfangDesArbeitsverhältnisses)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.LblTVHJahre)
        Me.Controls.Add(Me.NumTVHJahr)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Kündigungsrechner"
        CType(Me.NumMonateProbezeit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumTVHMonate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumTVHJahr, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents BtnBerechnen As Button
    Friend WithEvents btnEnde As Button
    Friend WithEvents cbTVH As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NumMonateProbezeit As NumericUpDown
    Friend WithEvents NumTVHMonate As NumericUpDown
    Friend WithEvents LblProbezeit As Label
    Friend WithEvents LblTVH As Label
    Friend WithEvents LblTVHJahre As Label
    Friend WithEvents NumTVHJahr As NumericUpDown
    Friend WithEvents dateAktuellesDatum As DateTimePicker
End Class
