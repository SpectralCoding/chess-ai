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
using System.Windows.Shapes;
using ChessAI.Internal;

namespace ChessAI {
	/// <summary>
	/// Interaction logic for BitboardGeneratorWindow.xaml
	/// </summary>
	public partial class BitboardGeneratorWindow : Window {
		public BitboardGeneratorWindow() {
			InitializeComponent();
		}

		private void ToULongBtn_Click(object sender, RoutedEventArgs e) {
			ulong TempBitBoard = 0;
			string BinaryString = String.Empty;
			#region BinaryString Formation
			if (A8Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (B8Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (C8Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (D8Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (E8Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (F8Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (G8Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (H8Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (A7Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (B7Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (C7Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (D7Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (E7Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (F7Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (G7Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (H7Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (A6Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (B6Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (C6Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (D6Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (E6Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (F6Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (G6Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (H6Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (A5Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (B5Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (C5Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (D5Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (E5Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (F5Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (G5Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (H5Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (A4Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (B4Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (C4Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (D4Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (E4Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (F4Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (G4Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (H4Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (A3Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (B3Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (C3Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (D3Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (E3Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (F3Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (G3Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (H3Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (A2Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (B2Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (C2Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (D2Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (E2Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (F2Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (G2Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (H2Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (A1Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (B1Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (C1Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (D1Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (E1Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (F1Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (G1Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			if (H1Chk.IsChecked == true) { BinaryString += "1"; } else { BinaryString += "0"; }
			#endregion
			TempBitBoard = Convert.ToUInt64(BinaryString, 2);
			ULongTxt.Text = TempBitBoard.ToString();
			BinaryStringTxt.Text = BinaryString;
		}

		private void ToBitBoardBtn_Click(object sender, RoutedEventArgs e) {
			String BinaryString = Functions.ULongToBinaryString(Convert.ToUInt64(ULongTxt.Text));
			if (BinaryString.Substring(0, 1) == "1") { A8Chk.IsChecked = true; } else { A8Chk.IsChecked = false; }
			if (BinaryString.Substring(1, 1) == "1") { B8Chk.IsChecked = true; } else { B8Chk.IsChecked = false; }
			if (BinaryString.Substring(2, 1) == "1") { C8Chk.IsChecked = true; } else { C8Chk.IsChecked = false; }
			if (BinaryString.Substring(3, 1) == "1") { D8Chk.IsChecked = true; } else { D8Chk.IsChecked = false; }
			if (BinaryString.Substring(4, 1) == "1") { E8Chk.IsChecked = true; } else { E8Chk.IsChecked = false; }
			if (BinaryString.Substring(5, 1) == "1") { F8Chk.IsChecked = true; } else { F8Chk.IsChecked = false; }
			if (BinaryString.Substring(6, 1) == "1") { G8Chk.IsChecked = true; } else { G8Chk.IsChecked = false; }
			if (BinaryString.Substring(7, 1) == "1") { H8Chk.IsChecked = true; } else { H8Chk.IsChecked = false; }
			if (BinaryString.Substring(8, 1) == "1") { A7Chk.IsChecked = true; } else { A7Chk.IsChecked = false; }
			if (BinaryString.Substring(9, 1) == "1") { B7Chk.IsChecked = true; } else { B7Chk.IsChecked = false; }
			if (BinaryString.Substring(10, 1) == "1") { C7Chk.IsChecked = true; } else { C7Chk.IsChecked = false; }
			if (BinaryString.Substring(11, 1) == "1") { D7Chk.IsChecked = true; } else { D7Chk.IsChecked = false; }
			if (BinaryString.Substring(12, 1) == "1") { E7Chk.IsChecked = true; } else { E7Chk.IsChecked = false; }
			if (BinaryString.Substring(13, 1) == "1") { F7Chk.IsChecked = true; } else { F7Chk.IsChecked = false; }
			if (BinaryString.Substring(14, 1) == "1") { G7Chk.IsChecked = true; } else { G7Chk.IsChecked = false; }
			if (BinaryString.Substring(15, 1) == "1") { H7Chk.IsChecked = true; } else { H7Chk.IsChecked = false; }
			if (BinaryString.Substring(16, 1) == "1") { A6Chk.IsChecked = true; } else { A6Chk.IsChecked = false; }
			if (BinaryString.Substring(17, 1) == "1") { B6Chk.IsChecked = true; } else { B6Chk.IsChecked = false; }
			if (BinaryString.Substring(18, 1) == "1") { C6Chk.IsChecked = true; } else { C6Chk.IsChecked = false; }
			if (BinaryString.Substring(19, 1) == "1") { D6Chk.IsChecked = true; } else { D6Chk.IsChecked = false; }
			if (BinaryString.Substring(20, 1) == "1") { E6Chk.IsChecked = true; } else { E6Chk.IsChecked = false; }
			if (BinaryString.Substring(21, 1) == "1") { F6Chk.IsChecked = true; } else { F6Chk.IsChecked = false; }
			if (BinaryString.Substring(22, 1) == "1") { G6Chk.IsChecked = true; } else { G6Chk.IsChecked = false; }
			if (BinaryString.Substring(23, 1) == "1") { H6Chk.IsChecked = true; } else { H6Chk.IsChecked = false; }
			if (BinaryString.Substring(24, 1) == "1") { A5Chk.IsChecked = true; } else { A5Chk.IsChecked = false; }
			if (BinaryString.Substring(25, 1) == "1") { B5Chk.IsChecked = true; } else { B5Chk.IsChecked = false; }
			if (BinaryString.Substring(26, 1) == "1") { C5Chk.IsChecked = true; } else { C5Chk.IsChecked = false; }
			if (BinaryString.Substring(27, 1) == "1") { D5Chk.IsChecked = true; } else { D5Chk.IsChecked = false; }
			if (BinaryString.Substring(28, 1) == "1") { E5Chk.IsChecked = true; } else { E5Chk.IsChecked = false; }
			if (BinaryString.Substring(29, 1) == "1") { F5Chk.IsChecked = true; } else { F5Chk.IsChecked = false; }
			if (BinaryString.Substring(30, 1) == "1") { G5Chk.IsChecked = true; } else { G5Chk.IsChecked = false; }
			if (BinaryString.Substring(31, 1) == "1") { H5Chk.IsChecked = true; } else { H5Chk.IsChecked = false; }
			if (BinaryString.Substring(32, 1) == "1") { A4Chk.IsChecked = true; } else { A4Chk.IsChecked = false; }
			if (BinaryString.Substring(33, 1) == "1") { B4Chk.IsChecked = true; } else { B4Chk.IsChecked = false; }
			if (BinaryString.Substring(34, 1) == "1") { C4Chk.IsChecked = true; } else { C4Chk.IsChecked = false; }
			if (BinaryString.Substring(35, 1) == "1") { D4Chk.IsChecked = true; } else { D4Chk.IsChecked = false; }
			if (BinaryString.Substring(36, 1) == "1") { E4Chk.IsChecked = true; } else { E4Chk.IsChecked = false; }
			if (BinaryString.Substring(37, 1) == "1") { F4Chk.IsChecked = true; } else { F4Chk.IsChecked = false; }
			if (BinaryString.Substring(38, 1) == "1") { G4Chk.IsChecked = true; } else { G4Chk.IsChecked = false; }
			if (BinaryString.Substring(39, 1) == "1") { H4Chk.IsChecked = true; } else { H4Chk.IsChecked = false; }
			if (BinaryString.Substring(40, 1) == "1") { A3Chk.IsChecked = true; } else { A3Chk.IsChecked = false; }
			if (BinaryString.Substring(41, 1) == "1") { B3Chk.IsChecked = true; } else { B3Chk.IsChecked = false; }
			if (BinaryString.Substring(42, 1) == "1") { C3Chk.IsChecked = true; } else { C3Chk.IsChecked = false; }
			if (BinaryString.Substring(43, 1) == "1") { D3Chk.IsChecked = true; } else { D3Chk.IsChecked = false; }
			if (BinaryString.Substring(44, 1) == "1") { E3Chk.IsChecked = true; } else { E3Chk.IsChecked = false; }
			if (BinaryString.Substring(45, 1) == "1") { F3Chk.IsChecked = true; } else { F3Chk.IsChecked = false; }
			if (BinaryString.Substring(46, 1) == "1") { G3Chk.IsChecked = true; } else { G3Chk.IsChecked = false; }
			if (BinaryString.Substring(47, 1) == "1") { H3Chk.IsChecked = true; } else { H3Chk.IsChecked = false; }
			if (BinaryString.Substring(48, 1) == "1") { A2Chk.IsChecked = true; } else { A2Chk.IsChecked = false; }
			if (BinaryString.Substring(49, 1) == "1") { B2Chk.IsChecked = true; } else { B2Chk.IsChecked = false; }
			if (BinaryString.Substring(50, 1) == "1") { C2Chk.IsChecked = true; } else { C2Chk.IsChecked = false; }
			if (BinaryString.Substring(51, 1) == "1") { D2Chk.IsChecked = true; } else { D2Chk.IsChecked = false; }
			if (BinaryString.Substring(52, 1) == "1") { E2Chk.IsChecked = true; } else { E2Chk.IsChecked = false; }
			if (BinaryString.Substring(53, 1) == "1") { F2Chk.IsChecked = true; } else { F2Chk.IsChecked = false; }
			if (BinaryString.Substring(54, 1) == "1") { G2Chk.IsChecked = true; } else { G2Chk.IsChecked = false; }
			if (BinaryString.Substring(55, 1) == "1") { H2Chk.IsChecked = true; } else { H2Chk.IsChecked = false; }
			if (BinaryString.Substring(56, 1) == "1") { A1Chk.IsChecked = true; } else { A1Chk.IsChecked = false; }
			if (BinaryString.Substring(57, 1) == "1") { B1Chk.IsChecked = true; } else { B1Chk.IsChecked = false; }
			if (BinaryString.Substring(58, 1) == "1") { C1Chk.IsChecked = true; } else { C1Chk.IsChecked = false; }
			if (BinaryString.Substring(59, 1) == "1") { D1Chk.IsChecked = true; } else { D1Chk.IsChecked = false; }
			if (BinaryString.Substring(60, 1) == "1") { E1Chk.IsChecked = true; } else { E1Chk.IsChecked = false; }
			if (BinaryString.Substring(61, 1) == "1") { F1Chk.IsChecked = true; } else { F1Chk.IsChecked = false; }
			if (BinaryString.Substring(62, 1) == "1") { G1Chk.IsChecked = true; } else { G1Chk.IsChecked = false; }
			if (BinaryString.Substring(63, 1) == "1") { H1Chk.IsChecked = true; } else { H1Chk.IsChecked = false; }
		}

		private void Window_Loaded(object sender, RoutedEventArgs e) {
			BitBoardDB.GenerateAttacks();
		}

		#region Checkbox Click Events
		private void HeadChk_Click(object sender, RoutedEventArgs e) {
			A8Chk.IsChecked = HeadChk.IsChecked;
			B8Chk.IsChecked = HeadChk.IsChecked;
			C8Chk.IsChecked = HeadChk.IsChecked;
			D8Chk.IsChecked = HeadChk.IsChecked;
			E8Chk.IsChecked = HeadChk.IsChecked;
			F8Chk.IsChecked = HeadChk.IsChecked;
			G8Chk.IsChecked = HeadChk.IsChecked;
			H8Chk.IsChecked = HeadChk.IsChecked;
			A7Chk.IsChecked = HeadChk.IsChecked;
			B7Chk.IsChecked = HeadChk.IsChecked;
			C7Chk.IsChecked = HeadChk.IsChecked;
			D7Chk.IsChecked = HeadChk.IsChecked;
			E7Chk.IsChecked = HeadChk.IsChecked;
			F7Chk.IsChecked = HeadChk.IsChecked;
			G7Chk.IsChecked = HeadChk.IsChecked;
			H7Chk.IsChecked = HeadChk.IsChecked;
			A6Chk.IsChecked = HeadChk.IsChecked;
			B6Chk.IsChecked = HeadChk.IsChecked;
			C6Chk.IsChecked = HeadChk.IsChecked;
			D6Chk.IsChecked = HeadChk.IsChecked;
			E6Chk.IsChecked = HeadChk.IsChecked;
			F6Chk.IsChecked = HeadChk.IsChecked;
			G6Chk.IsChecked = HeadChk.IsChecked;
			H6Chk.IsChecked = HeadChk.IsChecked;
			A5Chk.IsChecked = HeadChk.IsChecked;
			B5Chk.IsChecked = HeadChk.IsChecked;
			C5Chk.IsChecked = HeadChk.IsChecked;
			D5Chk.IsChecked = HeadChk.IsChecked;
			E5Chk.IsChecked = HeadChk.IsChecked;
			F5Chk.IsChecked = HeadChk.IsChecked;
			G5Chk.IsChecked = HeadChk.IsChecked;
			H5Chk.IsChecked = HeadChk.IsChecked;
			A4Chk.IsChecked = HeadChk.IsChecked;
			B4Chk.IsChecked = HeadChk.IsChecked;
			C4Chk.IsChecked = HeadChk.IsChecked;
			D4Chk.IsChecked = HeadChk.IsChecked;
			E4Chk.IsChecked = HeadChk.IsChecked;
			F4Chk.IsChecked = HeadChk.IsChecked;
			G4Chk.IsChecked = HeadChk.IsChecked;
			H4Chk.IsChecked = HeadChk.IsChecked;
			A3Chk.IsChecked = HeadChk.IsChecked;
			B3Chk.IsChecked = HeadChk.IsChecked;
			C3Chk.IsChecked = HeadChk.IsChecked;
			D3Chk.IsChecked = HeadChk.IsChecked;
			E3Chk.IsChecked = HeadChk.IsChecked;
			F3Chk.IsChecked = HeadChk.IsChecked;
			G3Chk.IsChecked = HeadChk.IsChecked;
			H3Chk.IsChecked = HeadChk.IsChecked;
			A2Chk.IsChecked = HeadChk.IsChecked;
			B2Chk.IsChecked = HeadChk.IsChecked;
			C2Chk.IsChecked = HeadChk.IsChecked;
			D2Chk.IsChecked = HeadChk.IsChecked;
			E2Chk.IsChecked = HeadChk.IsChecked;
			F2Chk.IsChecked = HeadChk.IsChecked;
			G2Chk.IsChecked = HeadChk.IsChecked;
			H2Chk.IsChecked = HeadChk.IsChecked;
			A1Chk.IsChecked = HeadChk.IsChecked;
			B1Chk.IsChecked = HeadChk.IsChecked;
			C1Chk.IsChecked = HeadChk.IsChecked;
			D1Chk.IsChecked = HeadChk.IsChecked;
			E1Chk.IsChecked = HeadChk.IsChecked;
			F1Chk.IsChecked = HeadChk.IsChecked;
			G1Chk.IsChecked = HeadChk.IsChecked;
			H1Chk.IsChecked = HeadChk.IsChecked;
			HeadAChk.IsChecked = HeadChk.IsChecked;
			HeadBChk.IsChecked = HeadChk.IsChecked;
			HeadCChk.IsChecked = HeadChk.IsChecked;
			HeadDChk.IsChecked = HeadChk.IsChecked;
			HeadEChk.IsChecked = HeadChk.IsChecked;
			HeadFChk.IsChecked = HeadChk.IsChecked;
			HeadGChk.IsChecked = HeadChk.IsChecked;
			HeadHChk.IsChecked = HeadChk.IsChecked;
			Head8Chk.IsChecked = HeadChk.IsChecked;
			Head7Chk.IsChecked = HeadChk.IsChecked;
			Head6Chk.IsChecked = HeadChk.IsChecked;
			Head5Chk.IsChecked = HeadChk.IsChecked;
			Head4Chk.IsChecked = HeadChk.IsChecked;
			Head3Chk.IsChecked = HeadChk.IsChecked;
			Head2Chk.IsChecked = HeadChk.IsChecked;
			Head1Chk.IsChecked = HeadChk.IsChecked;
			ToULongBtn_Click(this, null);
		}

		private void HeadAChk_Click(object sender, RoutedEventArgs e) {
			A8Chk.IsChecked = HeadAChk.IsChecked;
			A7Chk.IsChecked = HeadAChk.IsChecked;
			A6Chk.IsChecked = HeadAChk.IsChecked;
			A5Chk.IsChecked = HeadAChk.IsChecked;
			A4Chk.IsChecked = HeadAChk.IsChecked;
			A3Chk.IsChecked = HeadAChk.IsChecked;
			A2Chk.IsChecked = HeadAChk.IsChecked;
			A1Chk.IsChecked = HeadAChk.IsChecked;
			ToULongBtn_Click(this, null);
		}

		private void HeadBChk_Click(object sender, RoutedEventArgs e) {
			B8Chk.IsChecked = HeadBChk.IsChecked;
			B7Chk.IsChecked = HeadBChk.IsChecked;
			B6Chk.IsChecked = HeadBChk.IsChecked;
			B5Chk.IsChecked = HeadBChk.IsChecked;
			B4Chk.IsChecked = HeadBChk.IsChecked;
			B3Chk.IsChecked = HeadBChk.IsChecked;
			B2Chk.IsChecked = HeadBChk.IsChecked;
			B1Chk.IsChecked = HeadBChk.IsChecked;
			ToULongBtn_Click(this, null);
		}

		private void HeadCChk_Click(object sender, RoutedEventArgs e) {
			C8Chk.IsChecked = HeadCChk.IsChecked;
			C7Chk.IsChecked = HeadCChk.IsChecked;
			C6Chk.IsChecked = HeadCChk.IsChecked;
			C5Chk.IsChecked = HeadCChk.IsChecked;
			C4Chk.IsChecked = HeadCChk.IsChecked;
			C3Chk.IsChecked = HeadCChk.IsChecked;
			C2Chk.IsChecked = HeadCChk.IsChecked;
			C1Chk.IsChecked = HeadCChk.IsChecked;
			ToULongBtn_Click(this, null);
		}

		private void HeadDChk_Click(object sender, RoutedEventArgs e) {
			D8Chk.IsChecked = HeadDChk.IsChecked;
			D7Chk.IsChecked = HeadDChk.IsChecked;
			D6Chk.IsChecked = HeadDChk.IsChecked;
			D5Chk.IsChecked = HeadDChk.IsChecked;
			D4Chk.IsChecked = HeadDChk.IsChecked;
			D3Chk.IsChecked = HeadDChk.IsChecked;
			D2Chk.IsChecked = HeadDChk.IsChecked;
			D1Chk.IsChecked = HeadDChk.IsChecked;
			ToULongBtn_Click(this, null);
		}

		private void HeadEChk_Click(object sender, RoutedEventArgs e) {
			E8Chk.IsChecked = HeadEChk.IsChecked;
			E7Chk.IsChecked = HeadEChk.IsChecked;
			E6Chk.IsChecked = HeadEChk.IsChecked;
			E5Chk.IsChecked = HeadEChk.IsChecked;
			E4Chk.IsChecked = HeadEChk.IsChecked;
			E3Chk.IsChecked = HeadEChk.IsChecked;
			E2Chk.IsChecked = HeadEChk.IsChecked;
			E1Chk.IsChecked = HeadEChk.IsChecked;
			ToULongBtn_Click(this, null);
		}

		private void HeadFChk_Click(object sender, RoutedEventArgs e) {
			F8Chk.IsChecked = HeadFChk.IsChecked;
			F7Chk.IsChecked = HeadFChk.IsChecked;
			F6Chk.IsChecked = HeadFChk.IsChecked;
			F5Chk.IsChecked = HeadFChk.IsChecked;
			F4Chk.IsChecked = HeadFChk.IsChecked;
			F3Chk.IsChecked = HeadFChk.IsChecked;
			F2Chk.IsChecked = HeadFChk.IsChecked;
			F1Chk.IsChecked = HeadFChk.IsChecked;
			ToULongBtn_Click(this, null);
		}

		private void HeadGChk_Click(object sender, RoutedEventArgs e) {
			G8Chk.IsChecked = HeadGChk.IsChecked;
			G7Chk.IsChecked = HeadGChk.IsChecked;
			G6Chk.IsChecked = HeadGChk.IsChecked;
			G5Chk.IsChecked = HeadGChk.IsChecked;
			G4Chk.IsChecked = HeadGChk.IsChecked;
			G3Chk.IsChecked = HeadGChk.IsChecked;
			G2Chk.IsChecked = HeadGChk.IsChecked;
			G1Chk.IsChecked = HeadGChk.IsChecked;
			ToULongBtn_Click(this, null);
		}

		private void HeadHChk_Click(object sender, RoutedEventArgs e) {
			H8Chk.IsChecked = HeadHChk.IsChecked;
			H7Chk.IsChecked = HeadHChk.IsChecked;
			H6Chk.IsChecked = HeadHChk.IsChecked;
			H5Chk.IsChecked = HeadHChk.IsChecked;
			H4Chk.IsChecked = HeadHChk.IsChecked;
			H3Chk.IsChecked = HeadHChk.IsChecked;
			H2Chk.IsChecked = HeadHChk.IsChecked;
			H1Chk.IsChecked = HeadHChk.IsChecked;
			ToULongBtn_Click(this, null);
		}

		private void Head1Chk_Click(object sender, RoutedEventArgs e) {
			A1Chk.IsChecked = Head1Chk.IsChecked;
			B1Chk.IsChecked = Head1Chk.IsChecked;
			C1Chk.IsChecked = Head1Chk.IsChecked;
			D1Chk.IsChecked = Head1Chk.IsChecked;
			E1Chk.IsChecked = Head1Chk.IsChecked;
			F1Chk.IsChecked = Head1Chk.IsChecked;
			G1Chk.IsChecked = Head1Chk.IsChecked;
			H1Chk.IsChecked = Head1Chk.IsChecked;
			ToULongBtn_Click(this, null);
		}

		private void Head2Chk_Click(object sender, RoutedEventArgs e) {
			A2Chk.IsChecked = Head2Chk.IsChecked;
			B2Chk.IsChecked = Head2Chk.IsChecked;
			C2Chk.IsChecked = Head2Chk.IsChecked;
			D2Chk.IsChecked = Head2Chk.IsChecked;
			E2Chk.IsChecked = Head2Chk.IsChecked;
			F2Chk.IsChecked = Head2Chk.IsChecked;
			G2Chk.IsChecked = Head2Chk.IsChecked;
			H2Chk.IsChecked = Head2Chk.IsChecked;
			ToULongBtn_Click(this, null);
		}

		private void Head3Chk_Click(object sender, RoutedEventArgs e) {
			A3Chk.IsChecked = Head3Chk.IsChecked;
			B3Chk.IsChecked = Head3Chk.IsChecked;
			C3Chk.IsChecked = Head3Chk.IsChecked;
			D3Chk.IsChecked = Head3Chk.IsChecked;
			E3Chk.IsChecked = Head3Chk.IsChecked;
			F3Chk.IsChecked = Head3Chk.IsChecked;
			G3Chk.IsChecked = Head3Chk.IsChecked;
			H3Chk.IsChecked = Head3Chk.IsChecked;
			ToULongBtn_Click(this, null);
		}

		private void Head4Chk_Click(object sender, RoutedEventArgs e) {
			A4Chk.IsChecked = Head4Chk.IsChecked;
			B4Chk.IsChecked = Head4Chk.IsChecked;
			C4Chk.IsChecked = Head4Chk.IsChecked;
			D4Chk.IsChecked = Head4Chk.IsChecked;
			E4Chk.IsChecked = Head4Chk.IsChecked;
			F4Chk.IsChecked = Head4Chk.IsChecked;
			G4Chk.IsChecked = Head4Chk.IsChecked;
			H4Chk.IsChecked = Head4Chk.IsChecked;
			ToULongBtn_Click(this, null);
		}

		private void Head5Chk_Click(object sender, RoutedEventArgs e) {
			A5Chk.IsChecked = Head5Chk.IsChecked;
			B5Chk.IsChecked = Head5Chk.IsChecked;
			C5Chk.IsChecked = Head5Chk.IsChecked;
			D5Chk.IsChecked = Head5Chk.IsChecked;
			E5Chk.IsChecked = Head5Chk.IsChecked;
			F5Chk.IsChecked = Head5Chk.IsChecked;
			G5Chk.IsChecked = Head5Chk.IsChecked;
			H5Chk.IsChecked = Head5Chk.IsChecked;
			ToULongBtn_Click(this, null);
		}

		private void Head6Chk_Click(object sender, RoutedEventArgs e) {
			A6Chk.IsChecked = Head6Chk.IsChecked;
			B6Chk.IsChecked = Head6Chk.IsChecked;
			C6Chk.IsChecked = Head6Chk.IsChecked;
			D6Chk.IsChecked = Head6Chk.IsChecked;
			E6Chk.IsChecked = Head6Chk.IsChecked;
			F6Chk.IsChecked = Head6Chk.IsChecked;
			G6Chk.IsChecked = Head6Chk.IsChecked;
			H6Chk.IsChecked = Head6Chk.IsChecked;
			ToULongBtn_Click(this, null);
		}

		private void Head7Chk_Click(object sender, RoutedEventArgs e) {
			A7Chk.IsChecked = Head7Chk.IsChecked;
			B7Chk.IsChecked = Head7Chk.IsChecked;
			C7Chk.IsChecked = Head7Chk.IsChecked;
			D7Chk.IsChecked = Head7Chk.IsChecked;
			E7Chk.IsChecked = Head7Chk.IsChecked;
			F7Chk.IsChecked = Head7Chk.IsChecked;
			G7Chk.IsChecked = Head7Chk.IsChecked;
			H7Chk.IsChecked = Head7Chk.IsChecked;
			ToULongBtn_Click(this, null);
		}

		private void Head8Chk_Click(object sender, RoutedEventArgs e) {
			A8Chk.IsChecked = Head8Chk.IsChecked;
			B8Chk.IsChecked = Head8Chk.IsChecked;
			C8Chk.IsChecked = Head8Chk.IsChecked;
			D8Chk.IsChecked = Head8Chk.IsChecked;
			E8Chk.IsChecked = Head8Chk.IsChecked;
			F8Chk.IsChecked = Head8Chk.IsChecked;
			G8Chk.IsChecked = Head8Chk.IsChecked;
			H8Chk.IsChecked = Head8Chk.IsChecked;
			ToULongBtn_Click(this, null);
		}
		#endregion

		private void PieceTypeCmb_SelectionChanged(object sender, SelectionChangedEventArgs e) {
			BitBoardLst.Items.Clear();
			
			switch (((ComboBoxItem)PieceTypeCmb.SelectedItem).Content.ToString()) {
				case "Rook":
					for (int i = 0; i < BitBoardDB.RookAttacks.Length; i++) {
						BitBoardLst.Items.Add("Rook - " + i);
					}
					break;
				case "Knight":
					for (int i = 0; i < BitBoardDB.KnightAttacks.Length; i++) {
						BitBoardLst.Items.Add("Knight - " + i);
					}
					break;
			}
		}

		private void BitBoardLst_SelectionChanged(object sender, SelectionChangedEventArgs e) {
			if (BitBoardLst.SelectedValue != null) {
				string[] tempSplit = BitBoardLst.SelectedValue.ToString().Split(' ');
				switch (tempSplit[0]) {
					case "Rook":
						ULongTxt.Text = BitBoardDB.RookAttacks[Convert.ToInt32(tempSplit[2])].ToString();
						ToBitBoardBtn_Click(this, null);
						break;
					case "Knight":
						ULongTxt.Text = BitBoardDB.KnightAttacks[Convert.ToInt32(tempSplit[2])].ToString();
						ToBitBoardBtn_Click(this, null);
						break;
				}
			}
		}

	}
}
