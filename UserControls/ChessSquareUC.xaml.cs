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
	/// Interaction logic for ChessSquare.xaml
	/// </summary>
	public partial class ChessSquare : UserControl {

		public ChessSquare() {
			InitializeComponent();
		}

		private void UserControl_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e) {
			if (DataContext is ChessSquareViewModel) {
				ChessSquareViewModel tempCSVM = (ChessSquareViewModel)DataContext;
				CoordLbl.Content = tempCSVM.RankStr + tempCSVM.FileStr;
				IndexLbl.Content = String.Format("[{0}][{1}]", tempCSVM.Rank, tempCSVM.File);
			}
		}

	}
}
