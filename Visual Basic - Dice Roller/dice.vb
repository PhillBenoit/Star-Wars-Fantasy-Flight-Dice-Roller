Public Class frmDice
    Private Sub cmdRoll_Click(sender As Object, e As EventArgs) Handles cmdRoll.Click

        cmdClear_Click(sender, e)

        nudBoost.Enabled = False
        For x = 1 To nudBoost.Value
            Dim roll As Int16 = CInt(Int((Convert.ToSingle(nudBoost.Tag) * Rnd()) + 1))
            lstBoost.Items.Add(x.ToString + ")     " + roll.ToString)
            Select Case roll
                Case 3
                    nudSuccess.Value += 1
                Case 4
                    nudSuccess.Value += 1
                    nudAdvantage.Value += 1
                Case 5
                    nudAdvantage.Value += 2
                Case 6
                    nudAdvantage.Value += 1
            End Select
        Next

        nudSetback.Enabled = False
        For x = 1 To nudSetback.Value
            Dim roll As Int16 = CInt(Int((Convert.ToSingle(nudSetback.Tag) * Rnd()) + 1))
            lstSetback.Items.Add(x.ToString + ")     " + roll.ToString)
            Select Case roll
                Case 3
                    nudFailure.Value += 1
                Case 4
                    nudFailure.Value += 1
                Case 5
                    nudThreat.Value += 1
                Case 6
                    nudThreat.Value += 1
            End Select
        Next

        nudPercent.Enabled = False
        For x = 1 To nudPercent.Value
            Dim roll As Int16 = CInt(Int(Convert.ToSingle(nudPercent.Tag) * Rnd()))
            lstPercent.Items.Add(x.ToString + ")     " + roll.ToString)
        Next

        nudAbility.Enabled = False
        For x = 1 To nudAbility.Value
            Dim roll As Int16 = CInt(Int((Convert.ToSingle(nudAbility.Tag) * Rnd()) + 1))
            lstAbility.Items.Add(x.ToString + ")     " + roll.ToString)
            Select Case roll
                Case 2
                    nudSuccess.Value += 1
                Case 3
                    nudSuccess.Value += 1
                Case 4
                    nudSuccess.Value += 2
                Case 5
                    nudAdvantage.Value += 1
                Case 6
                    nudAdvantage.Value += 1
                Case 7
                    nudSuccess.Value += 1
                    nudAdvantage.Value += 1
                Case 8
                    nudAdvantage.Value += 2
            End Select
        Next

        nudDifficulty.Enabled = False
        For x = 1 To nudDifficulty.Value
            Dim roll As Int16 = CInt(Int((Convert.ToSingle(nudDifficulty.Tag) * Rnd()) + 1))
            lstDifficulty.Items.Add(x.ToString + ")     " + roll.ToString)
            Select Case roll
                Case 2
                    nudFailure.Value += 1
                Case 3
                    nudFailure.Value += 2
                Case 4
                    nudThreat.Value += 1
                Case 5
                    nudThreat.Value += 1
                Case 6
                    nudThreat.Value += 1
                Case 7
                    nudThreat.Value += 2
                Case 8
                    nudThreat.Value += 1
                    nudFailure.Value += 1
            End Select
        Next

        nudProficiency.Enabled = False
        For x = 1 To nudProficiency.Value
            Dim roll As Int16 = CInt(Int((Convert.ToSingle(nudProficiency.Tag) * Rnd()) + 1))
            lstProficiency.Items.Add(x.ToString + ")     " + roll.ToString)
            Select Case roll
                Case 2
                    nudSuccess.Value += 1
                Case 3
                    nudSuccess.Value += 1
                Case 4
                    nudSuccess.Value += 2
                Case 5
                    nudSuccess.Value += 2
                Case 6
                    nudAdvantage.Value += 1
                Case 7
                    nudSuccess.Value += 1
                    nudAdvantage.Value += 1
                Case 8
                    nudSuccess.Value += 1
                    nudAdvantage.Value += 1
                Case 9
                    nudSuccess.Value += 1
                    nudAdvantage.Value += 1
                Case 10
                    nudAdvantage.Value += 2
                Case 11
                    nudAdvantage.Value += 2
                Case 12
                    nudTriumph.Value += 1
            End Select
        Next

        nudChallenge.Enabled = False
        For x = 1 To nudChallenge.Value
            Dim roll As Int16 = CInt(Int((Convert.ToSingle(nudChallenge.Tag) * Rnd()) + 1))
            lstChallenge.Items.Add(x.ToString + ")     " + roll.ToString)
            Select Case roll
                Case 2
                    nudFailure.Value += 1
                Case 3
                    nudFailure.Value += 1
                Case 4
                    nudFailure.Value += 2
                Case 5
                    nudFailure.Value += 2
                Case 6
                    nudThreat.Value += 1
                Case 7
                    nudThreat.Value += 1
                Case 8
                    nudFailure.Value += 1
                    nudThreat.Value += 1
                Case 9
                    nudFailure.Value += 1
                    nudThreat.Value += 1
                Case 10
                    nudThreat.Value += 2
                Case 11
                    nudThreat.Value += 2
                Case 12
                    nudDispair.Value += 1
            End Select
        Next

        nudForce.Enabled = False
        For x = 1 To nudForce.Value
            Dim roll As Int16 = CInt(Int((Convert.ToSingle(nudForce.Tag) * Rnd()) + 1))
            lstForce.Items.Add(x.ToString + ")     " + roll.ToString)
            Select Case roll
                Case 1
                    nudDark.Value += 1
                Case 2
                    nudDark.Value += 1
                Case 3
                    nudDark.Value += 1
                Case 4
                    nudDark.Value += 1
                Case 5
                    nudDark.Value += 1
                Case 6
                    nudDark.Value += 1
                Case 7
                    nudDark.Value += 2
                Case 8
                    nudLight.Value += 1
                Case 9
                    nudLight.Value += 1
                Case 10
                    nudLight.Value += 2
                Case 11
                    nudLight.Value += 2
                Case 12
                    nudLight.Value += 2
            End Select
        Next

    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        End
    End Sub

    Private Sub frmDice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        nudSuccess.Value = 0
        nudAdvantage.Value = 0
        nudTriumph.Value = 0
        nudFailure.Value = 0
        nudThreat.Value = 0
        nudDispair.Value = 0
        nudLight.Value = 0
        nudDark.Value = 0

        nudBoost.Enabled = True
        lstBoost.Items.Clear()

        nudSetback.Enabled = True
        lstSetback.Items.Clear()

        nudPercent.Enabled = True
        lstPercent.Items.Clear()

        nudAbility.Enabled = True
        lstAbility.Items.Clear()

        nudDifficulty.Enabled = True
        lstDifficulty.Items.Clear()

        nudProficiency.Enabled = True
        lstProficiency.Items.Clear()

        nudChallenge.Enabled = True
        lstChallenge.Items.Clear()

        nudForce.Enabled = True
        lstForce.Items.Clear()

    End Sub

    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click
        cmdClear_Click(sender, e)

        nudBoost.Value = 0
        nudSetback.Value = 0
        nudPercent.Value = 0
        nudAbility.Value = 0
        nudDifficulty.Value = 0
        nudProficiency.Value = 0
        nudChallenge.Value = 0
        nudForce.Value = 0

    End Sub
End Class
