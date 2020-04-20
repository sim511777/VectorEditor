using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace VectorEditor {
    public class HatchInfo {
        public bool enabled { get; set; }
        public double dist { get; set; }
        public double angle { get; set; }
        public double beamComp { get; set; }
        public double startOffset { get; set; }
        public double endOffset { get; set; }
    }

    public abstract class Entity {
        public string Name { get; set; }
        public HatchInfo hatch1 { get; set; }
        public HatchInfo hatch2 { get; set; }
        public abstract List<List<Vector>> GetBorders();
        public abstract List<List<Vector>> GetHatches();
    }

    public class Point : Entity {
        public Vector ptCenter { get; set; }

        public override List<List<Vector>> GetBorders() {
            throw new NotImplementedException();
        }
        
        public override List<List<Vector>> GetHatches() {
            throw new NotImplementedException();
        }
    }

    public class Line : Entity {
        public Vector ptStart { get; set; }
        public Vector ptEnd { get; set; }

        public override List<List<Vector>> GetBorders() {
            throw new NotImplementedException();
        }

        public override List<List<Vector>> GetHatches() {
            throw new NotImplementedException();
        }
    }

    public class Arc : Entity {
        public Vector ptStart { get; set; }
        public Vector ptEnd { get; set; }
        public double bulge { get; set; }
        public int resolition { get; set; }

        public override List<List<Vector>> GetBorders() {
            throw new NotImplementedException();
        }

        public override List<List<Vector>> GetHatches() {
            throw new NotImplementedException();
        }
    }

    public class PolyLine : Entity {
        public List<Vector> ptList { get; set; }

        public override List<List<Vector>> GetBorders() {
            throw new NotImplementedException();
        }

        public override List<List<Vector>> GetHatches() {
            throw new NotImplementedException();
        }
    }

    public class Circle : Entity {
        public Vector ptCenter { get; set; }
        public double radius { get; set; }
        public int resolition { get; set; }

        public override List<List<Vector>> GetBorders() {
            throw new NotImplementedException();
        }

        public override List<List<Vector>> GetHatches() {
            throw new NotImplementedException();
        }
    }

    public class Ellipse : Entity {
        public Vector ptCenter { get; set; }
        public double radiusX { get; set; }
        public double radiusY { get; set; }
        public double rotation { get; set; }
        public double startAngle { get; set; }
        public double sizeAngle { get; set; }
        public int resolition { get; set; }

        public override List<List<Vector>> GetBorders() {
            throw new NotImplementedException();
        }

        public override List<List<Vector>> GetHatches() {
            throw new NotImplementedException();
        }
    }

    public class Spiral : Entity {
        public Vector ptCenter { get; set; }
        public double radiusX { get; set; }
        public double radiusY { get; set; }
        public double rotation { get; set; }
        public double numberOfTurns { get; set; }
        public double angularStep { get; set; }
        public bool clockWise { get; set; }
        public bool outerCircle { get; set; }

        public override List<List<Vector>> GetBorders() {
            throw new NotImplementedException();
        }

        public override List<List<Vector>> GetHatches() {
            throw new NotImplementedException();
        }
    }

    public class Rectangle : Entity {
        public Vector ptCenter { get; set; }
        public double width { get; set; }
        public double height { get; set; }
        public double rotation { get; set; }

        public override List<List<Vector>> GetBorders() {
            throw new NotImplementedException();
        }

        public override List<List<Vector>> GetHatches() {
            throw new NotImplementedException();
        }
    }

    public class Text : Entity {
        public Vector ptCenter { get; set; }
        public string text { get; set; }
        public Font font { get; set; }
        public double rotation { get; set; }

        public override List<List<Vector>> GetBorders() {
            throw new NotImplementedException();
        }

        public override List<List<Vector>> GetHatches() {
            throw new NotImplementedException();
        }
    }

    public enum BarcodeType {
        QR,
        Code39,
        DataMatrix,
    }

    public class Barcode : Entity {
        public Vector ptCenter { get; set; }
        public double width { get; set; }
        public double height { get; set; }
        public double rotation { get; set; }
        public BarcodeType codeType { get; set; }
        public string codeText { get; set; }

        public override List<List<Vector>> GetBorders() {
            throw new NotImplementedException();
        }

        public override List<List<Vector>> GetHatches() {
            throw new NotImplementedException();
        }
    }

    public class Image : Entity {
        public Vector ptCenter { get; set; }
        public double width { get; set; }
        public double height { get; set; }
        public double rotation { get; set; }
        public Bitmap bitmap { get; set; }

        public override List<List<Vector>> GetBorders() {
            throw new NotImplementedException();
        }

        public override List<List<Vector>> GetHatches() {
            throw new NotImplementedException();
        }
    }
}
