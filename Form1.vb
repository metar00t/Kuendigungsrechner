' Dieser Code wurde von metar00t erstellt
' © metar00t

Public Class Form1

    ' Vor dem Start des Eigentlichen Programmes, wird der Name des MA's erfasst und die dazugehörigen Daten eingetragen
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        dateAktuellesDatum.Value = Date.Today
Restart:
        Dim Meldung, Titel, [Default] As String
        Dim ErsteMeldung As Object
        Dim Beginn As Date = #08/14/2023#
        Dim Name() As String = {"Adams", "Hölz", "Meyer", "Beyer", "Gottschalk", "Seefeldt", "Hübscher", "Diehl", "Ullmann"}
        Dim x As Integer
        Meldung = "Welches MA Profil wollen Sie aufrufen?"
        Titel = "MA Register"
        [Default] = ""

        ErsteMeldung = InputBox(Meldung, Titel, [Default])
        Dim Index As Integer = Array.LastIndexOf(Name, ErsteMeldung)
        Dim FehlendeEingabe = String.IsNullOrEmpty(ErsteMeldung)

        If FehlendeEingabe Then
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
                NumMonateProbezeit.Visible = True
                LblProbezeit.Visible = True
            End If

            If ErsteMeldung = "Adams" Or ErsteMeldung = "Beyer" Then
                cbTVH.Checked = True
                NumTVHMonate.Visible = True
                LblTVH.Visible = True
            End If

            If cbProbezeit.Checked = False And cbTVH.Checked = False Then
                cbProbezeit.Visible = False
                NumMonateProbezeit.Visible = False
                LblProbezeit.Visible = False
                cbTVH.Visible = False
                NumTVHMonate.Visible = False
                LblTVH.Visible = False
            End If

            If cbProbezeit.Checked = True And cbTVH.Checked = False Then
                cbTVH.Visible = False
                NumTVHMonate.Visible = False
                LblTVH.Visible = False
            End If

            If cbProbezeit.Checked = False And cbTVH.Checked = True Then
                cbProbezeit.Visible = False
                NumMonateProbezeit.Visible = False
                LblProbezeit.Visible = False
                cbTVH.Location = cbProbezeit.Location
                NumTVHMonate.Location = NumMonateProbezeit.Location
                LblTVH.Location = LblProbezeit.Location
                dateAktuellesDatum.Enabled = True
            End If

        Next

    End Sub

    Private Sub NumMonateProbezeit_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumMonateProbezeit.ValueChanged
        If NumMonateProbezeit.Value = 1 Then
            LblProbezeit.Text = "Monat"
        Else
            LblProbezeit.Text = "Monate"
        End If
    End Sub

    Private Sub NumTVH_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumTVHMonate.ValueChanged
        If NumTVHMonate.Value = 1 Then
            LblTVH.Text = "Monat"
        Else
            LblTVH.Text = "Monate"
        End If
        If NumTVHMonate.Value = 12 Then
            NumTVHMonate.Visible = False
            LblTVH.Visible = False
            NumTVHJahr.Visible = True
            LblTVHJahre.Visible = True
            NumTVHJahr.Location = NumTVHMonate.Location
            LblTVHJahre.Location = LblTVH.Location
            NumTVHJahr.Value = 1
        End If
    End Sub

    Private Sub NumTVHJahr_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumTVHJahr.ValueChanged
        If NumTVHJahr.Value = 1 Then
            LblTVHJahre.Text = "Jahr"
        Else
            LblTVHJahre.Text = "Jahre"
        End If
        If NumTVHJahr.Value = 0 Then
            NumTVHJahr.Visible = False
            LblTVHJahre.Visible = False
            NumTVHMonate.Visible = True
            LblTVH.Visible = True
            NumTVHMonate.Value = 11
        End If
    End Sub

    Private Function Berechnung(ByVal BeginnArbeitsverhältnis As Date, ByVal Kündigungstag As Date)
        Dim Fristtag, ZeitraumKündigungBGB, DauerBetriebszugehörigkeitWochen, DauerBetriebszugehörigkeitMonat, DauerBetriebszugehörigkeitJahr As Long
        DauerBetriebszugehörigkeitWochen = DateDiff(DateInterval.WeekOfYear, dateAktuellesDatum.Value, BeginnArbeitsverhältnis)
        ZeitraumKündigungBGB = DateDiff(DateInterval.Weekday, dateAktuellesDatum.Value, Kündigungstag)
        Fristtag = DateDiff(DateInterval.Day, dateAktuellesDatum.Value, Kündigungstag)
        DauerBetriebszugehörigkeitMonat = DateDiff(DateInterval.Month, BeginnArbeitsverhältnis, dateAktuellesDatum.Value)
        DauerBetriebszugehörigkeitJahr = DateDiff(DateInterval.Year, BeginnArbeitsverhältnis, dateAktuellesDatum.Value)

        ' In den Messageboxen Das Kündigungsdatum ausgeben lassen (siehe BGB)

        ' Ablauf für die BGB Kündigung

        If cbProbezeit.Checked = False And cbTVH.Checked = False Then
            If ZeitraumKündigungBGB = 4 And Fristtag = 15 Then
                MessageBox.Show("Sie können zum 15. kündigen!", "BGB", MessageBoxButtons.OK, MessageBoxIcon.None)
            End If
            If ZeitraumKündigungBGB = 4 Then
                MessageBox.Show("Sie können zum Ende des Monats kündigen!", "BGB", MessageBoxButtons.OK, MessageBoxIcon.None)
            End If
            If ZeitraumKündigungBGB < 4 Then
                MessageBox.Show("Frist nicht eingehalten!", "BGB", MessageBoxButtons.OK, MessageBoxIcon.None)
            End If
        End If

        ' Ablauf für die Kündigungsfrist während der Probezeit

        If cbProbezeit.Checked = True And cbTVH.Checked = False Then
            If NumMonateProbezeit.Value <= 6 Then
                If ZeitraumKündigungBGB = 2 Then
                    MessageBox.Show("Sie können fristgerecht kündigen", "Probezeit", MessageBoxButtons.OK, MessageBoxIcon.None)
                Else
                    MessageBox.Show("Sie haben die Frist nicht eingehalten!", "Probezeit", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If

        ' Ablauf für die TV-H Kündigung

        If cbProbezeit.Checked = False And cbTVH.Checked = True Then
            If DauerBetriebszugehörigkeitMonat <= 6 Then
                If NumTVHMonate.Value <= 6 Then
                    'Berechnung des Letzten Tags vom Monat seit Beginn des Arbeitsverhältnisses
                    Dim LetzterTagVomMonat As Date = DateSerial(Year(BeginnArbeitsverhältnis), Month(BeginnArbeitsverhältnis) + NumTVHMonate.Value, 0)
                    ' Abzug von 14 Tagen (2 Wochen) für die erste Kündigungsfrist
                    LetzterTagVomMonat = DateAdd(DateInterval.Day, -14, LetzterTagVomMonat)
                    Dim TVH_Monat As Long = DateDiff(DateInterval.Day, LetzterTagVomMonat, Kündigungstag)
                    If TVH_Monat = 0 Then
                        MessageBox.Show("Frist eingehalten", "Erfolg", MessageBoxButtons.OK)
                    Else
                        MessageBox.Show("Frist nicht eingehalten", "Error", MessageBoxButtons.OK)
                    End If
                End If
            End If
            If DauerBetriebszugehörigkeitMonat > 6 And DauerBetriebszugehörigkeitMonat <= 12 Then
                If NumTVHMonate.Value > 6 And NumTVHMonate.Value <= 12 Then
                    Dim LetzterTagVomMonat As Date = DateSerial(Year(BeginnArbeitsverhältnis), Month(BeginnArbeitsverhältnis) + NumTVHMonate.Value, 1)
                    LetzterTagVomMonat = DateAdd(DateInterval.Month, -1, LetzterTagVomMonat)
                    Dim TVH_Monat As Long = DateDiff(DateInterval.Day, LetzterTagVomMonat, Kündigungstag)
                    If TVH_Monat = 0 Then
                        MessageBox.Show("Frist eingehalten", "Erfolg", MessageBoxButtons.OK)
                    Else
                        MessageBox.Show("Frist nicht eingehalten", "Error", MessageBoxButtons.OK)
                    End If
                End If
            End If
            If DauerBetriebszugehörigkeitJahr >= 1 Then
                If NumTVHJahr.Value >= 1 Then
                    Dim Quartal As Date = DateSerial(Year(BeginnArbeitsverhältnis), Int((Month(BeginnArbeitsverhältnis) - NumTVHJahr.Value) / 3) * 3 + 4, 0)
                    Quartal = DateAdd(DateInterval.WeekOfYear, -6, Quartal)
                    Dim TVH_Quartal As Long = DateDiff(DateInterval.Weekday, Quartal, Kündigungstag)
                    lblName.Text = TVH_Quartal
                    If TVH_Quartal = 0 Then
                        MessageBox.Show("Frist eingehalten", "Erfolg", MessageBoxButtons.OK)
                    Else
                        MessageBox.Show("Frist nicht eingehalten", "Error", MessageBoxButtons.OK)
                    End If
                End If
            End If
            If DauerBetriebszugehörigkeitJahr >= 2 And DauerBetriebszugehörigkeitJahr <= 5 Then
                If NumTVHJahr.Value >= 2 And NumTVHJahr.Value <= 5 Then
                    Dim Quartal As Date = DateSerial(Year(BeginnArbeitsverhältnis), Int((Month(BeginnArbeitsverhältnis) - NumTVHJahr.Value) / 3) * 3 + 4, 0)
                    Quartal = DateAdd(DateInterval.Month, -3, Quartal)
                    Dim TVH_Quartal As Long = DateDiff(DateInterval.Month, Quartal, Kündigungstag)
                    If TVH_Quartal = 0 Then
                        MessageBox.Show("Frist eingehalten", "Erfolg", MessageBoxButtons.OK)
                    Else
                        MessageBox.Show("Frist nicht eingehalten", "Error", MessageBoxButtons.OK)
                    End If
                End If
            End If
            If DauerBetriebszugehörigkeitJahr >= 6 And DauerBetriebszugehörigkeitJahr <= 8 Then
                If NumTVHJahr.Value >= 6 And NumTVHJahr.Value <= 8 Then
                    Dim Quartal As Date = DateSerial(Year(BeginnArbeitsverhältnis), Int((Month(BeginnArbeitsverhältnis) - NumTVHJahr.Value) / 3) * 3 + 4, 0)
                    Quartal = DateAdd(DateInterval.Month, -4, Quartal)
                    Dim TVH_Quartal As Long = DateDiff(DateInterval.Month, Quartal, Kündigungstag)
                    If TVH_Quartal = 0 Then
                        MessageBox.Show("Frist eingehalten", "Erfolg", MessageBoxButtons.OK)
                    Else
                        MessageBox.Show("Frist nicht eingehalten", "Error", MessageBoxButtons.OK)
                    End If
                End If
            End If
            If DauerBetriebszugehörigkeitJahr >= 9 And DauerBetriebszugehörigkeitJahr <= 10 Then
                If NumTVHJahr.Value >= 9 And NumTVHJahr.Value <= 10 Then
                    Dim Quartal As Date = DateSerial(Year(BeginnArbeitsverhältnis), Int((Month(BeginnArbeitsverhältnis) - NumTVHJahr.Value) / 3) * 3 + 4, 0)
                    Quartal = DateAdd(DateInterval.Month, -5, Quartal)
                    Dim TVH_Quartal As Long = DateDiff(DateInterval.Month, Quartal, Kündigungstag)
                    If TVH_Quartal = 0 Then
                        MessageBox.Show("Frist eingehalten", "Erfolg", MessageBoxButtons.OK)
                    Else
                        MessageBox.Show("Frist nicht eingehalten", "Error", MessageBoxButtons.OK)
                    End If
                End If
            End If
            If DauerBetriebszugehörigkeitJahr >= 11 And DauerBetriebszugehörigkeitJahr <= 12 Then
                If NumTVHJahr.Value >= 11 And NumTVHJahr.Value <= 12 Then
                    Dim Quartal As Date = DateSerial(Year(BeginnArbeitsverhältnis), Int((Month(BeginnArbeitsverhältnis) - NumTVHJahr.Value) / 3) * 3 + 4, 0)
                    Quartal = DateAdd(DateInterval.Month, -6, Quartal)
                    Dim TVH_Quartal As Long = DateDiff(DateInterval.Month, Quartal, Kündigungstag)
                    If TVH_Quartal = 0 Then
                        MessageBox.Show("Frist eingehalten", "Erfolg", MessageBoxButtons.OK)
                    Else
                        MessageBox.Show("Frist nicht eingehalten", "Error", MessageBoxButtons.OK)
                    End If
                End If
            End If
        End If

        Return 0
    End Function

    Private Sub BtnBerechnen_Click(sender As Object, e As EventArgs) Handles BtnBerechnen.Click
        Dim Failsafe As Long
        Failsafe = DateDiff(DateInterval.Day, dateAnfangDesArbeitsverhältnisses.Value, dateKündigungsTag.Value)

        If Failsafe < 0 Then
            MessageBox.Show("Unzulässiger Kündigungsdatum", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Berechnung(dateAnfangDesArbeitsverhältnisses.Value, dateKündigungsTag.Value)
    End Sub
    Private Sub btnEnde_Click(sender As Object, e As EventArgs) Handles btnEnde.Click
        MessageBox.Show("Programm wird beendet", "Bis auf wiedersehen!", MessageBoxButtons.OK, MessageBoxIcon.None)
        Application.Exit()
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