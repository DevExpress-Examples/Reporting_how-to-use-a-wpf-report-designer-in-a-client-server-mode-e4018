Imports Microsoft.VisualBasic
Imports System.Windows
Imports DevExpress.Xpf.Core

Namespace WpfReportDesignerDemo
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			ThemeManager.ApplicationThemeName = "Office2007Silver"
			InitializeComponent()
		End Sub
	End Class
End Namespace
