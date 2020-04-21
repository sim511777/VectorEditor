using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace VectorEditor {
    public class HatchInfo {
        public bool Enabled { get; set; }
        public double Dist { get; set; }
        public double Angle { get; set; }
        public double BeamComp { get; set; }
        public double StartOffset { get; set; }
        public double EndOffset { get; set; }
    }

    public abstract class Entity {
        public string Name { get; set; }
        public HatchInfo Hatch1 { get; set; }
        public HatchInfo Hatch2 { get; set; }
        public abstract List<List<Vector>> GetBorders();
        public abstract List<List<Vector>> GetHatches();
    }

    public class Point : Entity {
        public Vector PtCenter { get; set; }

        public override List<List<Vector>> GetBorders() {
            throw new NotImplementedException();
        }
        
        public override List<List<Vector>> GetHatches() {
            throw new NotImplementedException();
        }
    }

    public class Line : Entity {
        public Vector PtStart { get; set; }
        public Vector PtEnd { get; set; }

        public override List<List<Vector>> GetBorders() {
            throw new NotImplementedException();
        }

        public override List<List<Vector>> GetHatches() {
            throw new NotImplementedException();
        }
    }

    public class Arc : Entity {
        public Vector PtStart { get; set; }
        public Vector PtEnd { get; set; }
        public double Bulge { get; set; }
        public int Resolition { get; set; }

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
        public Vector PtCenter { get; set; }
        public double Radius { get; set; }
        public int Resolition { get; set; }

        public override List<List<Vector>> GetBorders() {
            throw new NotImplementedException();
        }

        public override List<List<Vector>> GetHatches() {
            throw new NotImplementedException();
        }
    }

    public class Ellipse : Entity {
        public Vector PtCenter { get; set; }
        public double RadiusX { get; set; }
        public double RadiusY { get; set; }
        public double Rotation { get; set; }
        public double StartAngle { get; set; }
        public double SizeAngle { get; set; }
        public int Resolition { get; set; }

        public override List<List<Vector>> GetBorders() {
            throw new NotImplementedException();
        }

        public override List<List<Vector>> GetHatches() {
            throw new NotImplementedException();
        }
    }

    public class Spiral : Entity {
        public Vector PtCenter { get; set; }
        public double RadiusX { get; set; }
        public double RadiusY { get; set; }
        public double Rotation { get; set; }
        public double NumberOfTurns { get; set; }
        public double AngularStep { get; set; }
        public bool ClockWise { get; set; }
        public bool OuterCircle { get; set; }

        public override List<List<Vector>> GetBorders() {
            throw new NotImplementedException();
        }

        public override List<List<Vector>> GetHatches() {
            throw new NotImplementedException();
        }
    }

    public class Rectangle : Entity {
        public Vector PtCenter { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Rotation { get; set; }

        public override List<List<Vector>> GetBorders() {
            throw new NotImplementedException();
        }

        public override List<List<Vector>> GetHatches() {
            throw new NotImplementedException();
        }
    }

    public class Text : Entity {
        public Vector PtCenter { get; set; }
        public string Str { get; set; }
        public Font Font { get; set; }
        public double Rotation { get; set; }

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
        public Vector PtCenter { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Rotation { get; set; }
        public BarcodeType CodeType { get; set; }
        public string CodeText { get; set; }

        public override List<List<Vector>> GetBorders() {
            throw new NotImplementedException();
        }

        public override List<List<Vector>> GetHatches() {
            throw new NotImplementedException();
        }
    }

    public class Image : Entity {
        public Vector Center { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Rotation { get; set; }
        public Bitmap Bitmap { get; set; }

        public override List<List<Vector>> GetBorders() {
            throw new NotImplementedException();
        }

        public override List<List<Vector>> GetHatches() {
            throw new NotImplementedException();
        }
    }
}
