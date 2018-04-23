Imports Microsoft.VisualBasic
Imports System
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Input
Imports DevExpress.Xpf.Core.WPFCompatibility
Imports DevExpress.Xpf.Grid
Imports System.Collections.Generic

Namespace _1721___CellImageZoom
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()

			gridControl1.DataSource = GetData()
		End Sub

		Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim button As Button = CType(e.OriginalSource, Button)
			image.DataContext = (CType(button.Content, Image)).Source
			image.Visibility = Visibility.Visible
			image.Width = 700
			image.Height = 700
		End Sub

		Private Sub image_MouseLeave(ByVal sender As Object, ByVal e As MouseEventArgs)
			image.Visibility = Visibility.Collapsed
			image.DataContext = Nothing
		End Sub

		Public Class Vehicle
			Public Sub New(ByVal name As String, ByVal category As String, ByVal picture As String)
				Name = name
				Category = category
				Picture = picture
			End Sub
			Private privateName As String
			Public Property Name() As String
				Get
					Return privateName
				End Get
				Set(ByVal value As String)
					privateName = value
				End Set
			End Property

			Private privateCategory As String
			Public Property Category() As String
				Get
					Return privateCategory
				End Get
				Set(ByVal value As String)
					privateCategory = value
				End Set
			End Property

			Private privatePicture As String
			Public Property Picture() As String
				Get
					Return privatePicture
				End Get
				Set(ByVal value As String)
					privatePicture = value
				End Set
			End Property
		End Class

		Private Function GetData() As List(Of Vehicle)
			Return New List(Of Vehicle) (New Vehicle() {New Vehicle("Mercedes", "Coupe", "/1721%20-%20CellImageZoom;component/Pictures/Mercedes.png"), New Vehicle("Ford", "Truck", "/1721%20-%20CellImageZoom;component/Pictures/Ford.png"), New Vehicle("Jaguar", "Fourdoor", "/1721%20-%20CellImageZoom;component/Pictures/Jaguar.png")})
		End Function
	End Class
End Namespace
