using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ChessAI.ViewModel;

namespace ChessAI.UserControls {
	/// <summary>
	/// Interaction logic for ChessPiece.xaml
	/// </summary>
	public partial class ChessPiece : UserControl {

		private bool IsDragging = false;
		private Point FirstPoint = new Point();

		public ChessPiece() {
			InitializeComponent();
		}

		private void UserControl_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e) {
			if (DataContext is ChessPieceViewModel) {
				ChessPieceViewModel tempVPVM = (ChessPieceViewModel)DataContext;
				PieceImg.Source = new BitmapImage(new Uri(tempVPVM.ResourceURI, UriKind.Relative));
			}
		}

		private void UserControl_MouseDown(object sender, MouseButtonEventArgs e) {
			IsDragging = true;
			FirstPoint = this.PointToScreen(Mouse.GetPosition(this));
		}

		private void UserControl_MouseUp(object sender, MouseButtonEventArgs e) {
			IsDragging = false;
		}

		private void UserControl_MouseMove(object sender, MouseEventArgs e) {
			//if (e.LeftButton) {
			//	Point absoluteScreenPos = this.PointToScreen(Mouse.GetPosition(this));
			//	this.Margin.Left += absoluteScreenPos.X - FirstPoint.X;
			//	this.Margin.Top += absoluteScreenPos.Y - FirstPoint.Y;
			//}
			//if (IsDragging) {
			//	UIElement tempUIE = (UIElement)this.VisualParent;
			//	Point absoluteScreenPos = this.PointToScreen(Mouse.GetPosition(tempUIE));
			//	Point boardPoint = this.TranslatePoint(absoluteScreenPos, (UIElement)this.VisualParent);
			//}
		}
	}
}
