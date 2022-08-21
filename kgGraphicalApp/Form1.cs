using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kgGraphicalApp
{
	public partial class Form1 : Form
	{
		enum AlgorithmType
		{
			Dda,
			BresenhamLine,
			NonIntegerEnd,
			BresenhamCircle,
			BezierCurve,
			CyrusBeckClip,
			CohenSutherlandClip,
			MiddlePointClip
		}

		private readonly CustomLine _customLine;
		private AlgorithmType _algorithmType;
		private bool _isButtonDown;
		private bool _isTempRectangleSet;

		private Point _originPoint;
		private PointF _nonIntOriginPoint;
		private PointF _nonIntDestinationPoint;

		private List<Rectangle> _recentShape;
		private List<Rectangle> _shapes;
		private Rectangle _tempRectangle;
		private Segment[] _edges;
		private readonly Pen _solidPen;
		private readonly Pen _dashPen;
		private readonly List<Point> _clickPositions;
		

		public Form1()
		{
			InitializeComponent();
			_isButtonDown = false;
			_recentShape = new List<Rectangle>();
			_shapes = new List<Rectangle>();
			_algorithmType = AlgorithmType.Dda;
			_customLine = new CustomLine();
			_solidPen = new Pen(Color.Black);
			_clickPositions = new List<Point>();
			_tempRectangle = Rectangle.Empty;
			_isTempRectangleSet = false;
			_dashPen = new Pen(Color.Crimson, 3f) {DashStyle = DashStyle.Dash};
			_edges = null;
		}

		private void paintArea_MouseDown(object sender, MouseEventArgs e)
		{
			if (_algorithmType == AlgorithmType.NonIntegerEnd)
				return;
			_isButtonDown = true;
			_originPoint = e.Location;
			if (_algorithmType == AlgorithmType.BezierCurve)
			{
				if (_clickPositions.Count >= 11)
				{
					_shapes.AddRange(_recentShape);
					_clickPositions.Clear();
				}

				if (_clickPositions.Count == 0)
				{
					_clickPositions.Add(e.Location);
				}

				_clickPositions.Add(e.Location);
			}
		}

		private void paintArea_MouseUp(object sender, MouseEventArgs e)
		{
			if (_isButtonDown == false)
				return;
			_isButtonDown = false;
			_recentShape.Clear();
			if (!_isTempRectangleSet & (_algorithmType == AlgorithmType.CyrusBeckClip |
			                            _algorithmType == AlgorithmType.CohenSutherlandClip |
			                            _algorithmType == AlgorithmType.MiddlePointClip))
			{
				_isTempRectangleSet = true;
				return;
			}

			if (_algorithmType == AlgorithmType.BezierCurve)
			{
				_recentShape = MethodPicker(e);
			}
			else
				_shapes.AddRange(MethodPicker(e));

			paintArea.Refresh();
		}

		private void paintArea_MouseMove(object sender, MouseEventArgs e)
		{
			if (!_isButtonDown)
				return;

			if (_algorithmType == AlgorithmType.BezierCurve)
				_clickPositions[_clickPositions.Count - 1] = e.Location;

			if ((_algorithmType == AlgorithmType.CyrusBeckClip | _algorithmType == AlgorithmType.CohenSutherlandClip |
			     _algorithmType == AlgorithmType.MiddlePointClip) &
			    !_isTempRectangleSet)
			{
				_tempRectangle = new Rectangle(
					new Point(Math.Min(_originPoint.X, e.Location.X), Math.Min(_originPoint.Y, e.Location.Y)),
					new Size(Math.Abs(_originPoint.X - e.Location.X), Math.Abs(_originPoint.Y - e.Location.Y)));
				_edges = new[]
				{
					new Segment(_tempRectangle.Left, _tempRectangle.Top, _tempRectangle.Right,
						_tempRectangle.Top),
					new Segment(_tempRectangle.Right, _tempRectangle.Top, _tempRectangle.Right,
						_tempRectangle.Bottom),
					new Segment(_tempRectangle.Right, _tempRectangle.Bottom, _tempRectangle.Left,
						_tempRectangle.Bottom),
					new Segment(_tempRectangle.Left, _tempRectangle.Bottom, _tempRectangle.Left,
						_tempRectangle.Top)
				};
				paintArea.Refresh();
				return;
			}

			_recentShape = MethodPicker(e);
			paintArea.Refresh();
		}


		private void paintArea_Paint(object sender, PaintEventArgs e)
		{
			foreach (var rectangle in _recentShape)
				e.Graphics.DrawRectangle(_solidPen, rectangle);

			foreach (var rectangle in _shapes)
				e.Graphics.DrawRectangle(_solidPen, rectangle);

			e.Graphics.DrawRectangle(_dashPen, _tempRectangle);
		}

		private void DdaAlgorithmButton_Click(object sender, EventArgs e)
		{
			_algorithmType = AlgorithmType.Dda;
		}

		private void BresenhamAlgorithmButton_Click(object sender, EventArgs e)
		{
			_algorithmType = AlgorithmType.BresenhamLine;
		}

		private void NonIntegerEndAlgorithmButton_Click(object sender, EventArgs e)
		{
			_algorithmType = AlgorithmType.NonIntegerEnd;
			using (Dlg1 dlg1 = new Dlg1(CallBack))
			{
				if (dlg1.ShowDialog(this) == DialogResult.OK)
				{
					_nonIntOriginPoint = new PointF(dlg1.OriginX, dlg1.OriginY);
					_nonIntDestinationPoint = new PointF(dlg1.DestinationX, dlg1.DestinationY);
					_shapes.AddRange(MethodPicker(null));
				}
				_recentShape.Clear();
				paintArea.Refresh();
			}
		}

		private void CallBack(Dlg1 dlg1)
		{
			_nonIntOriginPoint = new PointF(dlg1.OriginX, dlg1.OriginY);
			_nonIntDestinationPoint = new PointF(dlg1.DestinationX, dlg1.DestinationY);
			_recentShape = MethodPicker(null);
			paintArea.Refresh();
		}


		private List<Rectangle> MethodPicker(MouseEventArgs e)
		{
			switch (_algorithmType)
			{
				case AlgorithmType.Dda:
					return _customLine.DdaLine(_originPoint.X, _originPoint.Y, e.X, e.Y);
				case AlgorithmType.BresenhamLine:
					return _customLine.BresenhamLine(_originPoint.X, _originPoint.Y, e.X, e.Y);
				case AlgorithmType.NonIntegerEnd:
					var temp = _customLine.NonIntegerEnd(_nonIntOriginPoint.X, _nonIntOriginPoint.Y,
						_nonIntDestinationPoint.X, _nonIntDestinationPoint.Y);
					return temp;
				case AlgorithmType.BresenhamCircle:
					return _customLine.BresenhamCircle(_originPoint.X, _originPoint.Y, e.X, e.Y);
				case AlgorithmType.BezierCurve:
					return _customLine.BezierCurve(_clickPositions);
				case AlgorithmType.CyrusBeckClip:
					return _customLine.CyrusBeckClip(new Segment(_originPoint.X, _originPoint.Y, e.X, e.Y),
						_edges);
				case AlgorithmType.CohenSutherlandClip:
					return _customLine.CohenSutherlandClip(
						new Segment(_originPoint.X, _originPoint.Y, e.X, e.Y), _tempRectangle);
				case AlgorithmType.MiddlePointClip:
					return _customLine.MiddlePointClip(
						new Segment(_originPoint.X, _originPoint.Y, e.X, e.Y), _tempRectangle);
				default:
					throw new System.NotImplementedException();
			}
		}

		private void BresenhamCircleButton_Click(object sender, EventArgs e)
		{
			_algorithmType = AlgorithmType.BresenhamCircle;
		}

		private void BezierCurveButton_Click(object sender, EventArgs e)
		{
			_algorithmType = AlgorithmType.BezierCurve;
			BezierCurveButton_CheckedChanged(sender, e);
		}

		private void BezierCurveButton_CheckedChanged(object sender, EventArgs e)
		{
			_clickPositions.Clear();
			if (_recentShape.Count <= 0) return;
			_shapes.AddRange(_recentShape);
			paintArea.Refresh();
		}

		private void ClearButton_Click(object sender, EventArgs e)
		{
			_originPoint = new Point();
			_shapes.Clear();
			_recentShape.Clear();
			_tempRectangle = Rectangle.Empty;
			_clickPositions.Clear();
			paintArea.Refresh();
			_isButtonDown = false;
			_isTempRectangleSet = false;
			_edges = null;
			paintArea.Refresh();
		}

		private void CyrusBeckClipButton_Click(object sender, EventArgs e)
		{
			_algorithmType = AlgorithmType.CyrusBeckClip;
			CyrusBeckClipButton_CheckedChanged(sender, e);
		}

		private void CyrusBeckClipButton_CheckedChanged(object sender, EventArgs e)
		{
			_tempRectangle = Rectangle.Empty;
			_isTempRectangleSet = false;
			_edges = null;
			paintArea.Refresh();
		}


		private void CohenSutherlandClipButton_CheckedChanged(object sender, EventArgs e)
		{
			_tempRectangle = Rectangle.Empty;
			_isTempRectangleSet = false;
			_edges = null;
			paintArea.Refresh();
		}

		private void CohenSutherlandClipButton_Click(object sender, EventArgs e)
		{
			_algorithmType = AlgorithmType.CohenSutherlandClip;
			CohenSutherlandClipButton_CheckedChanged(sender, e);
		}

		private void MiddlePointClipButton_CheckedChanged(object sender, EventArgs e)
		{
			_tempRectangle = Rectangle.Empty;
			_isTempRectangleSet = false;
			_edges = null;
			paintArea.Refresh();
		}

		private void MiddlePointClipButton_Click(object sender, EventArgs e)
		{
			_algorithmType = AlgorithmType.MiddlePointClip;
			CohenSutherlandClipButton_CheckedChanged(sender, e);
		}
	}
}