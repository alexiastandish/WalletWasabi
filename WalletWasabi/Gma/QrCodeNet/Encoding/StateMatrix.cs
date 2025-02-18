﻿namespace Gma.QrCodeNet.Encoding
{
	public sealed class StateMatrix
	{
		private MatrixStatus[,] MatrixStatus { get; }

		public StateMatrix(int width)
		{
			Width = width;
			MatrixStatus = new MatrixStatus[width, width];
		}

		public MatrixStatus this[int x, int y]
		{
			get => MatrixStatus[x, y];
			set => MatrixStatus[x, y] = value;
		}

		internal MatrixStatus this[MatrixPoint point]
		{
			get => this[point.X, point.Y];
			set => this[point.X, point.Y] = value;
		}

		public int Width { get; }

		public int Height => Width;
	}
}
