﻿
' Instat-R
' Copyright (C) 2015
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations

Public Class dlgProbabilityPlot
    Private Sub dlgProbabilityPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UcrReceiverSingle1.Selector = ucrAddRemove
        UcrReceiverSingle1.SetMeAsReceiver()
        ucrBase.clsRsyntax.SetFunction("qqnorm")
        ucrBase.clsRsyntax.iCallType = 0
        rdoNormal.Checked = True
        txtTitle.Visible = False
        autoTranslate(Me)

    End Sub
    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk




    End Sub

    Private Sub rdoNormal_CheckedChanged(sender As Object, e As EventArgs) Handles rdoNormal.CheckedChanged
        If rdoNormal.Checked = True Then
            txtTitle.Text = "Normal Probability Plot of " & UcrReceiverSingle1.txtReceiverSingle.Text & ""
        End If

    End Sub

    Private Sub rdoGamma_CheckedChanged(sender As Object, e As EventArgs) Handles rdoGamma.CheckedChanged
        If rdoGamma.Checked = True Then
            txtTitle.Text = "Gamma Probability Plot"
        End If
    End Sub

    Private Sub rdoExtrmeValue_CheckedChanged(sender As Object, e As EventArgs) Handles rdoExtrmeValue.CheckedChanged
        If rdoExtrmeValue.Checked = True Then
            txtTitle.Text = "Extreme Value Probability Plot"
        End If
    End Sub

    Private Sub rdoEmperical_CheckedChanged(sender As Object, e As EventArgs) Handles rdoEmperical.CheckedChanged
        If rdoEmperical.Checked = True Then
            txtTitle.Text = "Emperical Probability Plot"
        End If
    End Sub

    Private Sub rdoExponential_CheckedChanged(sender As Object, e As EventArgs) Handles rdoExponential.CheckedChanged
        If rdoExponential.Checked = True Then
            txtTitle.Text = "Exponential Probability Plot"
        End If
    End Sub

    Private Sub ucrAddRemove_Load(sender As Object, e As EventArgs) Handles ucrAddRemove.Load

    End Sub

    Private Sub txtTitle_TextChanged(sender As Object, e As EventArgs) Handles txtTitle.TextChanged

    End Sub

    Private Sub txtTitle_Leave(sender As Object, e As EventArgs) Handles txtTitle.Leave
        ucrBase.clsRsyntax.AddParameter("main", Chr(34) & txtTitle.Text & Chr(34))
    End Sub

    Private Sub UcrReceiverSingle1_Leave(sender As Object, e As EventArgs) Handles UcrReceiverSingle1.LeftText
        ucrBase.clsRsyntax.AddParameter("y", "data$" & UcrReceiverSingle1.txtReceiverSingle.Text & "")
    End Sub
End Class


