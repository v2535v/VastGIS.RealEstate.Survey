using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.RealEstate.Data.Entity;

namespace VastGIS.Plugins.RealEstate.Model
{
    public class ReLine
    {
        private double _startX;
        private double _startY;
        private double _endX;
        private double _endY;
        private RePoint _startPoint;
        private RePoint _centerPoint;
        private RePoint _endPoint;
        private double _length;

        public ReLine() { }

        public ReLine(double startX, double startY, double endX, double endY)
        {
            _startX = startX;
            _startY = startY;
            _endX = endX;
            _endY = endY;
            _startPoint = new RePoint(_startX, _startY);
            _endPoint = new RePoint(_endX, _endY);
            _centerPoint = new RePoint((_startX + _endX) / 2, (_startY + _endY) / 2);
            _length = CalculationDistance(_startX, _startY, _endX, _endY);
        }

        public double StartX
        {
            get { return _startX; }
        }

        public double StartY
        {
            get { return _startY; }
        }

        public double EndX
        {
            get { return _endX; }
        }

        public double EndY
        {
            get { return _endY; }
        }

        public RePoint StartPoint
        {
            get { return _startPoint; }
        }

        public RePoint CenterPoint
        {
            get { return _centerPoint; }
        }

        public RePoint EndPoint
        {
            get { return _endPoint; }
        }

        public double Length
        {
            get { return _length; }
        }

        private double CalculationDistance(double startX, double startY, double endX, double endY)
        {
            return Math.Sqrt(Math.Pow((startX - endX), 2) + Math.Pow((startY - endY), 2));
        }
    }
}
