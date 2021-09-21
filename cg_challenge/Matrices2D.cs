using System;

namespace cg_challenge
{
    public static class Matrices2D
    {
        public static readonly Matrix plusScale = new Matrix(new float[,] { { 1.05F, 0, 0 }, { 0, 1.05F, 0 }, { 0, 0, 1F } });

        public static readonly Matrix minusScale = new Matrix(new float[,] { { 0.95F, 0, 0 }, { 0, 0.95F, 0 }, { 0, 0, 1F } });

        public static readonly Matrix plusRotate = new Matrix(new float[,] { { (float)Math.Cos(Math.PI / 36.0), (float)Math.Sin(Math.PI / 36.0), 0 },
            { -(float)Math.Sin(Math.PI / 36.0), (float)Math.Cos(Math.PI / 36.0), 0 }, { 0, 0, 1F } });

        public static readonly Matrix minusRotate = new Matrix(new float[,] { { (float)Math.Cos(Math.PI / 36.0), (float)Math.Sin(-Math.PI / 36.0), 0 },
            { (float)Math.Sin(Math.PI / 36.0), (float)Math.Cos(Math.PI / 36.0), 0 }, { 0, 0, 1F } });

        public static readonly Matrix plusXTransf = new Matrix(new float[,] { { 1F, 0, 0 }, { 0, 1F, 0 }, { 5F, 0, 1F } });

        public static readonly Matrix minusXTransf = new Matrix(new float[,] { { 1F, 0, 0 }, { 0, 1F, 0 }, { -5F, 0, 1F } });

        public static readonly Matrix plusYTransf = new Matrix(new float[,] { { 1F, 0, 0 }, { 0, 1F, 0 }, { 0, 5F, 1F } });

        public static readonly Matrix minusYTransf = new Matrix(new float[,] { { 1F, 0, 0 }, { 0, 1F, 0 }, { 0, -5F, 1F } });

        public static readonly Matrix plusXScale = new Matrix(new float[,] { { 1.05F, 0, 0 }, { 0, 1F, 0 }, { 0, 0, 1F } });

        public static readonly Matrix minusXScale = new Matrix(new float[,] { { 0.95F, 0, 0 }, { 0, 1F, 0 }, { 0, 0, 1F } });

        public static readonly Matrix plusYScale = new Matrix(new float[,] { { 1F, 0, 0 }, { 0, 1.05F, 0 }, { 0, 0, 1F } });

        public static readonly Matrix minusYScale = new Matrix(new float[,] { { 1F, 0, 0 }, { 0, 0.95F, 0 }, { 0, 0, 1F } });
    }
}
