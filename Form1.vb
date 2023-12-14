' Dieser Code wurde von metar00t erstellt
' © metar00t


Imports System.Xml.Schema

Public Class Form1
    Private Sub btnEnde_Click(sender As Object, e As EventArgs) Handles btnEnde.Click
        End
    End Sub

    Private Function BerechnungDerFristen(ByVal User As String, ByVal Start As Date)
        Dim ZeitspanneBeginn, ZeitspanneKündigung As Long
        If txtName.Text = User Then
            ZeitspanneBeginn = DateDiff(DateInterval.Year, Start, Date.Now)
        End If
        If txtName.Text = User Then
            ZeitspanneKündigung = DateDiff(DateInterval.Month, Start, dateKündigungsTag.Value)
        End If
    End Function

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim Name() As String = {"Adams", "Meyer", "Beyer", "Gottschalk"}
        Dim Beginn As Date = #08/14/2023#
        Dim x As Integer = 0
        BerechnungDerFristen(Name(x), Beginn)
    End Sub

    ' Vor dem Start des Eigentlichen Programmes, wird der Name des MA's erfasst und die dazugehörigen Daten eingetragen
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
Restart:
        Dim Meldung, Titel, [Default] As String
        Dim MeineMeldung As Object
        Dim Beginn As Date = #08/14/2023#
        Dim Name() As String = {"Adams", "Meyer", "Beyer", "Gottschalk", "Seefeldt", "Hübscher", "Diehl", "Ullmann"}
        Dim x As Integer
        Meldung = "Welches MA Profil wollen sie aufrufen?"
        Titel = "Register"
        [Default] = ""

        MeineMeldung = InputBox(Meldung, Titel, [Default])
        Dim Index As String = Name.IndexOf(Name, MeineMeldung)

        For x = 0 To Index Step 1
            txtName.Text = MeineMeldung
            txtName.Enabled = False
            If MeineMeldung = "Meyer" Or MeineMeldung = "Gottschalk" Then
                cbProbezeit.Checked = True
            End If
        Next
        If Not MeineMeldung = Index Then
            MessageBox.Show("Dieser MA existiert nicht", "Fehler 404", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand)
        ElseIf MeineMeldung Is "" Then
            MessageBox.Show("Versuchen Sie es erneut", "Fehler", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information)
            GoTo Restart
        End If




    End Sub
End Class

'Wiederholen und nutzen Sie Ihre Kenntnisse aus Abschnitt F der FIAusbV.

'Implementieren Sie In einer Programmiersprache Ihrer Wahl Funktionen, die die folgenden Anforderungen erfüllen.

'Es soll nach den gesetzlichen Kündigungsfristen und/oder nach den im TV-H geregelten Kündigungsfristen gerechnet werden.

'Eine Funktion ermittelt die Dauer der Betriebszugehörigkeit zu einem vorgegebenen Datum anhand des Beginns des Arbeitsverhältnisses.

'Wenn der Beginn des Arbeitsverhältnisses und ein Kündigungsdatum übergeben wird, soll das Datum des letzten Arbeitstags ermittelt werden.

'Wenn der Beginn des Arbeitsverhältnisses und das Datum des letzten Arbeitstags übergeben wird, soll der spätestmögliche Kündigungsdatum ermittelt werden.

'Es soll berücksichtigt werden, ob die Probezeit noch läuft.

'Optional: Implementieren Sie Unit-Tests für Ihre Funktionen.

'Informieren Sie sich zunächst über die gesetzlichen und tariflichen Vorschriften.