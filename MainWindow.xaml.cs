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

namespace ChessAI {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {

		private MasterViewModel MasterViewModel;

		public MainWindow(MasterViewModel MVM) {
			MasterViewModel = MVM;
			DataContext = MasterViewModel;
			InitializeComponent();
			ChessBoard.DataContext = MasterViewModel.ChessBoardVM;
		}

		private void BBGenBtn_Click(object sender, RoutedEventArgs e) {
			BitboardGeneratorWindow BBGenWnd = new BitboardGeneratorWindow();
			BBGenWnd.Show();
		}

	}
}
