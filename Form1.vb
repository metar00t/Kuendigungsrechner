' Dieser Code wurde von metar00t erstellt
' © metar00t

Public Class Form1

    Private Sub btnEnde_Click(sender As Object, e As EventArgs) Handles btnEnde.Click
        MessageBox.Show("Programm wird beendet", "Bis auf wiedersehen!", MessageBoxButtons.OK, MessageBoxIcon.None)
        End
    End Sub

    Private Function BerechnungBGB(ByVal BeginnArbeitsverhältnis As Date, ByVal Kündigungstag As Date)
        Dim Fristtag, ZeitraumKündigung, DauerBetriebszugehörigkeitWochen, DauerBetriebszugehörigkeitProbezeit As Long
        DauerBetriebszugehörigkeitWochen = DateDiff(DateInterval.WeekOfYear, Date.Now, BeginnArbeitsverhältnis)
        DauerBetriebszugehörigkeitProbezeit = DateDiff(DateInterval.Month, Date.Now, BeginnArbeitsverhältnis)
        ZeitraumKündigung = DateDiff(DateInterval.WeekOfYear, Date.Now, Kündigungstag)
        Fristtag = DateDiff(DateInterval.Day, Date.Now, Kündigungstag)

        If cbProbezeit.Checked = False And cbTVH.Checked = False Then
            If ZeitraumKündigung = 4 And Fristtag = 15 Then
                MessageBox.Show("Sie können zum 15. kündigen!", "BGB", MessageBoxButtons.OK, MessageBoxIcon.None)
            End If
            If ZeitraumKündigung > 4 Then
                MessageBox.Show("Sie können zum Ende des Monats kündigen!", "BGB", MessageBoxButtons.OK, MessageBoxIcon.None)
            End If
        End If

        If cbProbezeit.Checked = True And cbTVH.Checked = False Then
            If DauerBetriebszugehörigkeitProbezeit <= 6 Then
                'Darüberschauen lassen
                If ZeitraumKündigung = 2 Then
                    MessageBox.Show("Sie können fristgerecht kündigen", "Probezeit", MessageBoxButtons.OK, MessageBoxIcon.None)
                    Return True
                End If
            End If
            If ZeitraumKündigung > 2 Then
                MessageBox.Show("Sie haben die Frist nicht eingehalten!", "Probezeit", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If
        End If
        Return 0
    End Function

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim Failsafe As Long

        If Failsafe < 0 Then
            MessageBox.Show("Ungülter Zeitraum", "Böse", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        BerechnungBGB(dateAnfangDesArbeitsverhältnisses.Value, dateKündigungsTag.Value)
    End Sub

    ' Vor dem Start des Eigentlichen Programmes, wird der Name des MA's erfasst und die dazugehörigen Daten eingetragen
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
Restart:
        Dim Meldung, Titel, [Default] As String
        Dim ErsteMeldung As Object
        Dim Beginn As Date = #08/14/2023#
        Dim Name() As String = {"Adams", "Hölz", "Meyer", "Beyer", "Gottschalk", "Seefeldt", "Hübscher", "Diehl", "Ullmann"}
        Dim x As Integer
        Meldung = "Welches MA Profil wollen Sie aufrufen?"
        Titel = "Register"
        [Default] = ""

        ErsteMeldung = InputBox(Meldung, Titel, [Default])
        Dim Index As Integer = Array.LastIndexOf(Name, ErsteMeldung)
        Dim Abbruch = String.IsNullOrEmpty(ErsteMeldung)

        If Abbruch Then
            MessageBox.Show("Bitte tragen Sie einen MA Namen ein!", "Keine Eingabe erkannt", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            GoTo Restart
        End If
        If x > Index Then
            MessageBox.Show("Dieser MA existiert nicht", "Fehler 404", MessageBoxButtons.OK, MessageBoxIcon.Error)
            GoTo Restart
        End If


        For x = 0 To Index Step 1

            txtName.Text = ErsteMeldung
            txtName.Enabled = False
            dateAnfangDesArbeitsverhältnisses.Value = Beginn

            If ErsteMeldung = "Meyer" Or ErsteMeldung = "Gottschalk" Then
                cbProbezeit.Checked = True
            End If

            If ErsteMeldung = "Adams" Or ErsteMeldung = "Beyer" Then
                cbTVH.Checked = True
            End If

        Next






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