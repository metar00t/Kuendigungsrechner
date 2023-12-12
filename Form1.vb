Public Class Form1
    Private Sub btnEnde_Click(sender As Object, e As EventArgs) Handles btnEnde.Click
        End
    End Sub

    Private Function BerechneDieStartZeit(ByVal User As String, ByVal Start As Date)
        Dim ZeitspanneBeginn, ZeitspanneKündigung As Long
        If txtName.Text = User Then
            ZeitspanneBeginn = DateDiff(DateInterval.Year, Start, dateKündigungsTag.Value)
            cbProbezeit.Checked = True
        End If
    End Function

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim Name() As String = {"Adams", "Meyer", "Beyer", "Gottschalk"}
        Dim Beginn As Date = #01/01/2000#
        Dim x As Integer = 0
        Do Until txtName.Text = Name(x)
            x += 1
        Loop
        BerechneDieStartZeit(Name(x), Beginn)

    End Sub

    ' Vor dem Start des Eigentlichen Programmes, wird der Name des MA's erfasst und die dazugehörigen Daten eingetragen
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim Meldung, Titel, [Default] As String
        Dim MeineMeldung As Object
        Dim Beginn As Date = #01/01/2000#
        Meldung = "Wie lautet Ihr Name?"
        Titel = "MA Name"
        [Default] = ""

        MeineMeldung = InputBox(Meldung, Titel, [Default])

        If MeineMeldung Is "" Then
            MessageBox.Show("Versuchen Sie es erneut", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Question)
            End
        End If
        txtName.Text = MeineMeldung
        txtName.Enabled = False
        dateAnfangDesArbeitsverhältnisses.Value = Beginn

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