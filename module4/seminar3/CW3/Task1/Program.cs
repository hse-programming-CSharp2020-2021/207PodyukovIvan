using System;

namespace Task1
{
    class Matrix2
    {
        public double A11 { get; set; }
        public double A12 { get; set; }
        public double A21 { get; set; }
        public double A22 { get; set; }
        public Matrix2(double a11, double a12, double a21, double a22)
        {
            A11 = a11;
            A12 = a12;
            A21 = a21;
            A22 = a22;
        }
        public Matrix2(double a11, double a22)
        {
            A11 = a11;
            A22 = a22;
            A12 = A21 = 0;
        }
        public Matrix2(Matrix2 matrix)
        {
            A11 = matrix.A11;
            A12 = matrix.A12;
            A21 = matrix.A21;
            A22 = matrix.A22;
        }
        public double Det()
        {
            return A11 * A22 - A21 * A12;
        }
        public Matrix2 Transpose()
        {
            return new Matrix2(A11, A21, A12, A22);
        }
        public static Matrix2 operator +(Matrix2 m1, Matrix2 m2)
        {
            return new Matrix2(m1.A11 + m2.A11, m1.A12 + m2.A12, m1.A21 + m2.A21, m1.A22 + m2.A22);
        }
        public static Matrix2 operator -(Matrix2 m1, Matrix2 m2)
        {
            return new Matrix2(m1.A11 - m2.A11, m1.A12 - m2.A12, m1.A21 - m2.A21, m1.A22 - m2.A22);
        }
        public static Matrix2 operator *(Matrix2 m1, Matrix2 m2)
        {
            return new Matrix2(m1.A11 * m2.A11 + m1.A12 * m2.A21, m1.A11 * m2.A12 + m1.A12 * m2.A22, m1.A21 * m2.A11 + m1.A22 * m2.A21, m1.A21 * m2.A12 + m1.A22 * m2.A22);
        }
        public static Matrix2 operator /(Matrix2 m1, double a)
        {
            return new Matrix2(m1.A11 / a, m1.A12 / a, m1.A21 / a, m1.A22 / a);
        }
        public static Matrix2 operator *(Matrix2 m1, double a)
        {
            return new Matrix2(m1.A11 * a, m1.A12 * a, m1.A21 * a, m1.A22 * a);
        }
        public static Matrix2 operator *(double a, Matrix2 m1)
        {
            return m1 * a;
        }
        public static bool operator true(Matrix2 m1)
        {
            return m1.Det() > 0;
        }
        public static bool operator false(Matrix2 m1)
        {
            return m1.Det() <= 0;
        }
        public static implicit operator double(Matrix2 m1)
        {
            return m1.Det();
        }
        public static Matrix2 operator &(Matrix2 m1, Matrix2 m2)
        {
            return m1.Transpose() + m2.Transpose();
        }
        public static Matrix2 operator |(Matrix2 m1, Matrix2 m2)
        {
            Matrix2 m3 = m1 * m2;
            return m3 * m3.Det();
        }
        public override string ToString()
        {
            return $"{A11:F3}\t{A12:F3}\n{A21:F3}\t{A22:F3}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
