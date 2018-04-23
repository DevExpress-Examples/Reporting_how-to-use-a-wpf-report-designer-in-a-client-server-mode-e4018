Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraReports.UI

Namespace ReportService
	Public Class Report
		Inherits XtraReport
		Private detailBand1 As DetailBand
		Private nwind1 As Nwind
		Private xrLabel1 As XRLabel
		Private xrLabel2 As XRLabel
		Private xrLabel4 As XRLabel
		Private xrLabel5 As XRLabel
		Private Title As XRControlStyle
		Private FieldCaption As XRControlStyle
		Private PageInfo As XRControlStyle
		Private DataField As XRControlStyle
		Private pageFooterBand1 As PageFooterBand
		Private xrPageInfo1 As XRPageInfo
		Private xrPageInfo2 As XRPageInfo
		Private reportHeaderBand1 As ReportHeaderBand
		Private xrLabel6 As XRLabel
		Private topMarginBand1 As TopMarginBand
		Private bottomMarginBand1 As BottomMarginBand
		Private xrPictureBox1 As XRPictureBox
		Private xrLabel3 As XRLabel
		Private categoriesTableAdapter As NwindTableAdapters.CategoriesTableAdapter

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub InitializeComponent()
			Me.detailBand1 = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
			Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
			Me.nwind1 = New ReportService.Nwind()
			Me.categoriesTableAdapter = New ReportService.NwindTableAdapters.CategoriesTableAdapter()
			Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.pageFooterBand1 = New DevExpress.XtraReports.UI.PageFooterBand()
			Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
			Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
			Me.reportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
			Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
			CType(Me.nwind1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' detailBand1
			' 
			Me.detailBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPictureBox1, Me.xrLabel3, Me.xrLabel1, Me.xrLabel2, Me.xrLabel4, Me.xrLabel5})
			Me.detailBand1.HeightF = 94.58332F
			Me.detailBand1.Name = "detailBand1"
			' 
			' xrPictureBox1
			' 
			Me.xrPictureBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Categories.Picture")})
			Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(174F, 59.91666F)
			Me.xrPictureBox1.Name = "xrPictureBox1"
			Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(470F, 18F)
			Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
			' 
			' xrLabel3
			' 
			Me.xrLabel3.ForeColor = System.Drawing.Color.Black
			Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(5.999994F, 59.91666F)
			Me.xrLabel3.Name = "xrLabel3"
			Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel3.SizeF = New System.Drawing.SizeF(162F, 18F)
			Me.xrLabel3.StyleName = "FieldCaption"
			Me.xrLabel3.StylePriority.UseForeColor = False
			Me.xrLabel3.Text = "Picture"
			' 
			' xrLabel1
			' 
			Me.xrLabel1.ForeColor = System.Drawing.Color.Black
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(6F, 9F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(162F, 18F)
			Me.xrLabel1.StyleName = "FieldCaption"
			Me.xrLabel1.StylePriority.UseForeColor = False
			Me.xrLabel1.Text = "Label"
			' 
			' xrLabel2
			' 
			Me.xrLabel2.ForeColor = System.Drawing.Color.Black
			Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(6F, 33F)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel2.SizeF = New System.Drawing.SizeF(162F, 18F)
			Me.xrLabel2.StyleName = "FieldCaption"
			Me.xrLabel2.StylePriority.UseForeColor = False
			Me.xrLabel2.Text = "Description"
			' 
			' xrLabel4
			' 
			Me.xrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoryName")})
			Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(174F, 9F)
			Me.xrLabel4.Name = "xrLabel4"
			Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel4.SizeF = New System.Drawing.SizeF(470F, 18F)
			Me.xrLabel4.StyleName = "DataField"
			Me.xrLabel4.Text = "xrLabel4"
			' 
			' xrLabel5
			' 
			Me.xrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.Description")})
			Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(174F, 33F)
			Me.xrLabel5.Name = "xrLabel5"
			Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel5.SizeF = New System.Drawing.SizeF(470F, 18F)
			Me.xrLabel5.StyleName = "DataField"
			Me.xrLabel5.Text = "xrLabel5"
			' 
			' nwind1
			' 
			Me.nwind1.DataSetName = "Nwind"
			Me.nwind1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' categoriesTableAdapter
			' 
			Me.categoriesTableAdapter.ClearBeforeFill = True
			' 
			' Title
			' 
			Me.Title.BackColor = System.Drawing.Color.White
			Me.Title.BorderColor = System.Drawing.SystemColors.ControlText
			Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.Title.BorderWidth = 1
			Me.Title.Font = New System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold)
			Me.Title.ForeColor = System.Drawing.Color.Maroon
			Me.Title.Name = "Title"
			' 
			' FieldCaption
			' 
			Me.FieldCaption.BackColor = System.Drawing.Color.White
			Me.FieldCaption.BorderColor = System.Drawing.SystemColors.ControlText
			Me.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.FieldCaption.BorderWidth = 1
			Me.FieldCaption.Font = New System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold)
			Me.FieldCaption.ForeColor = System.Drawing.Color.Maroon
			Me.FieldCaption.Name = "FieldCaption"
			' 
			' PageInfo
			' 
			Me.PageInfo.BackColor = System.Drawing.Color.White
			Me.PageInfo.BorderColor = System.Drawing.SystemColors.ControlText
			Me.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.PageInfo.BorderWidth = 1
			Me.PageInfo.Font = New System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold)
			Me.PageInfo.ForeColor = System.Drawing.SystemColors.ControlText
			Me.PageInfo.Name = "PageInfo"
			' 
			' DataField
			' 
			Me.DataField.BackColor = System.Drawing.Color.White
			Me.DataField.BorderColor = System.Drawing.SystemColors.ControlText
			Me.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.DataField.BorderWidth = 1
			Me.DataField.Font = New System.Drawing.Font("Times New Roman", 10F)
			Me.DataField.ForeColor = System.Drawing.SystemColors.ControlText
			Me.DataField.Name = "DataField"
			Me.DataField.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			' 
			' pageFooterBand1
			' 
			Me.pageFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPageInfo1, Me.xrPageInfo2})
			Me.pageFooterBand1.HeightF = 29F
			Me.pageFooterBand1.Name = "pageFooterBand1"
			' 
			' xrPageInfo1
			' 
			Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(6F, 6F)
			Me.xrPageInfo1.Name = "xrPageInfo1"
			Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
			Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(313F, 23F)
			Me.xrPageInfo1.StyleName = "PageInfo"
			' 
			' xrPageInfo2
			' 
			Me.xrPageInfo2.Format = "Page {0} of {1}"
			Me.xrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(331F, 6F)
			Me.xrPageInfo2.Name = "xrPageInfo2"
			Me.xrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrPageInfo2.SizeF = New System.Drawing.SizeF(313F, 23F)
			Me.xrPageInfo2.StyleName = "PageInfo"
			Me.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
			' 
			' reportHeaderBand1
			' 
			Me.reportHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel6})
			Me.reportHeaderBand1.HeightF = 51F
			Me.reportHeaderBand1.Name = "reportHeaderBand1"
			' 
			' xrLabel6
			' 
			Me.xrLabel6.BackColor = System.Drawing.Color.Transparent
			Me.xrLabel6.ForeColor = System.Drawing.Color.Black
			Me.xrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(6.00001F, 6.00001F)
			Me.xrLabel6.Name = "xrLabel6"
			Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel6.SizeF = New System.Drawing.SizeF(633.9999F, 32.99999F)
			Me.xrLabel6.StyleName = "Title"
			Me.xrLabel6.StylePriority.UseBackColor = False
			Me.xrLabel6.StylePriority.UseForeColor = False
			Me.xrLabel6.Text = "Sample Report"
			' 
			' topMarginBand1
			' 
			Me.topMarginBand1.Name = "topMarginBand1"
			' 
			' bottomMarginBand1
			' 
			Me.bottomMarginBand1.Name = "bottomMarginBand1"
			' 
			' Report
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.detailBand1, Me.pageFooterBand1, Me.reportHeaderBand1, Me.topMarginBand1, Me.bottomMarginBand1})
			Me.DataAdapter = Me.categoriesTableAdapter
			Me.DataMember = "Categories"
			Me.DataSource = Me.nwind1
			Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
			Me.Version = "12.1"
			CType(Me.nwind1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub
	End Class
End Namespace