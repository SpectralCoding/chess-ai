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

		private Point FirstPoint = new Point();
		private Thickness InitialMargin = new Thickness(0, 0, 0, 0);
		private bool DraggingThis = false;

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
			FirstPoint = this.TranslatePoint(Mouse.GetPosition(this), (this.VisualParent as UIElement));
			Canvas.SetZIndex(this, int.MaxValue);
			InitialMargin = this.Margin;
			DraggingThis = true;
		}

		private void UserControl_MouseUp(object sender, MouseButtonEventArgs e) {
			DraggingThis = false;
		}

		private void UserControl_MouseMove(object sender, MouseEventArgs e) {
			if (DraggingThis) {
				Point PointInChessBoard = this.TranslatePoint(Mouse.GetPosition(this), (this.VisualParent as UIElement));
				double DeltaX = FirstPoint.X - PointInChessBoard.X;
				double DeltaY = FirstPoint.Y - PointInChessBoard.Y;
				this.Margin = new Thickness(InitialMargin.Left - DeltaX, InitialMargin.Top - DeltaY, InitialMargin.Right - DeltaX, InitialMargin.Right - DeltaY);
			}
		}

		private void UserControl_MouseLeave(object sender, MouseEventArgs e) {
			DraggingThis = false;
		}
	}
}
