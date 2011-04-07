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

		protected bool isDragging;
		private Point clickPosition;

		public ChessPiece() {
			InitializeComponent();
		}

		private void UserControl_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e) {
			if (DataContext is ChessPieceViewModel) {
				ChessPieceViewModel tempVPVM = (ChessPieceViewModel)DataContext;
				PieceImg.Source = new BitmapImage(new Uri(tempVPVM.ResourceURI, UriKind.Relative));
			}
		}

		private void UserControl_MouseMove(object sender, MouseEventArgs e) {
			var draggableControl = sender as UserControl;
			if (isDragging && draggableControl != null) {
				Point currentPosition = e.GetPosition(this.Parent as UIElement);

				var transform = draggableControl.RenderTransform as TranslateTransform;
				if (transform == null) {
					transform = new TranslateTransform();
					draggableControl.RenderTransform = transform;
				}

				transform.X = currentPosition.X - clickPosition.X;
				transform.Y = currentPosition.Y - clickPosition.Y;
			}
		}

		private void UserControl_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) {
			isDragging = false;
			var draggable = sender as UserControl;
			draggable.ReleaseMouseCapture();
		}

		private void UserControl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
			isDragging = true;
			var draggableControl = sender as UserControl;
			clickPosition = e.GetPosition(this);
			draggableControl.CaptureMouse();
		}
	}
}
