Imports Microsoft.VisualBasic
Imports System
Namespace BarCode
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim qrCodeGenerator3 As New DevExpress.XtraPrinting.BarCode.QRCodeGenerator()
			Me.barCodeControl1 = New DevExpress.XtraEditors.BarCodeControl()
			Me.radioGroup1 = New DevExpress.XtraEditors.RadioGroup()
			CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' barCodeControl1
			' 
			Me.barCodeControl1.AutoModule = True
			Me.barCodeControl1.Location = New System.Drawing.Point(13, 13)
			Me.barCodeControl1.Name = "barCodeControl1"
			Me.barCodeControl1.Padding = New System.Windows.Forms.Padding(10, 2, 10, 0)
			Me.barCodeControl1.Size = New System.Drawing.Size(169, 164)
			qrCodeGenerator3.ErrorCorrectionLevel = DevExpress.XtraPrinting.BarCode.QRCodeErrorCorrectionLevel.H
			qrCodeGenerator3.Version = DevExpress.XtraPrinting.BarCode.QRCodeVersion.Version1
			Me.barCodeControl1.Symbology = qrCodeGenerator3
			Me.barCodeControl1.TabIndex = 0
			Me.barCodeControl1.Text = "123456789"
			' 
			' radioGroup1
			' 
			Me.radioGroup1.Location = New System.Drawing.Point(261, 12)
			Me.radioGroup1.Name = "radioGroup1"
			Me.radioGroup1.Size = New System.Drawing.Size(291, 362)
			Me.radioGroup1.TabIndex = 3
'			Me.radioGroup1.SelectedIndexChanged += New System.EventHandler(Me.radioGroup1_SelectedIndexChanged);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(627, 403)
			Me.Controls.Add(Me.radioGroup1)
			Me.Controls.Add(Me.barCodeControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private barCodeControl1 As DevExpress.XtraEditors.BarCodeControl
		Private WithEvents radioGroup1 As DevExpress.XtraEditors.RadioGroup
	End Class
End Namespace

