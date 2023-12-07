Public Class Form1
    Private Structure User
        Public Name As String
        Public DateOfEmployment As Date
    End Structure

    Dim MA, Einstellungsdatum As User
    Dim Differenz_Zeit As TimeSpan

    Private Sub btnEnde_Click(sender As Object, e As EventArgs) Handles btnEnde.Click
        End
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        MA.Name = "Adams"
        Einstellungsdatum.DateOfEmployment = #08/14/2023#
        If txtName.Text = "Adams" Then
            dateAnfangDesArbeitsverhältnisses.Value = Einstellungsdatum.DateOfEmployment
            Differenz_Zeit = dateKündigungsTag.Value - dateAnfangDesArbeitsverhältnisses.Value
            lblAusgabe.Text = Differenz_Zeit.ToString
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