Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPrinting.BarCode
Imports DevExpress.XtraPrinting.BarCode.Native

Namespace BarCode
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
			CalcRadioGroup(GetType(BarCodeSymbology), radioGroup1)
		End Sub

		Private Sub CalcRadioGroup(ByVal EnumType As Type, ByVal radioGroup As RadioGroup)
			For Each item As Object In System.Enum.GetValues(EnumType)
				Dim radioItem As New RadioGroupItem(item, item.ToString())
				radioGroup.Properties.Items.Add(radioItem)
			Next item
		End Sub

		Private Sub radioGroup1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioGroup1.SelectedIndexChanged
			barCodeControl1.Symbology = BarCodeGeneratorFactory.Create(CType(radioGroup1.EditValue, BarCodeSymbology))
		End Sub
	End Class
End Namespace
