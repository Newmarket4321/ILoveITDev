// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.CalcEngine.Functions.XLMatrix
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Text.RegularExpressions;

namespace ClosedXML.Excel.CalcEngine.Functions
{
  internal class XLMatrix
  {
    private double detOfP = 1.0;
    public XLMatrix L;
    public XLMatrix U;
    public int cols;
    public double[,] mat;
    private int[] pi;
    public int rows;

    public XLMatrix(int iRows, int iCols)
    {
      this.rows = iRows;
      this.cols = iCols;
      this.mat = new double[this.rows, this.cols];
    }

    public XLMatrix(double[,] arr)
      : this(arr.GetLength(0), arr.GetLength(1))
    {
      int length1 = arr.GetLength(0);
      int length2 = arr.GetLength(1);
      for (int index1 = 0; index1 < length1; ++index1)
      {
        for (int index2 = 0; index2 < length2; ++index2)
          this.mat[index1, index2] = arr[index1, index2];
      }
    }

    public double this[int iRow, int iCol]
    {
      get
      {
        return this.mat[iRow, iCol];
      }
      set
      {
        this.mat[iRow, iCol] = value;
      }
    }

    public bool IsSquare()
    {
      return this.rows == this.cols;
    }

    public XLMatrix GetCol(int k)
    {
      XLMatrix xlMatrix = new XLMatrix(this.rows, 1);
      for (int index = 0; index < this.rows; ++index)
        xlMatrix[index, 0] = this.mat[index, k];
      return xlMatrix;
    }

    public void SetCol(XLMatrix v, int k)
    {
      for (int index = 0; index < this.rows; ++index)
        this.mat[index, k] = v[index, 0];
    }

    public void MakeLU()
    {
      if (!this.IsSquare())
        throw new Exception("The matrix is not square!");
      this.L = XLMatrix.IdentityMatrix(this.rows, this.cols);
      this.U = this.Duplicate();
      this.pi = new int[this.rows];
      for (int index = 0; index < this.rows; ++index)
        this.pi[index] = index;
      int index1 = 0;
      for (int index2 = 0; index2 < this.cols - 1; ++index2)
      {
        double num1 = 0.0;
        for (int index3 = index2; index3 < this.rows; ++index3)
        {
          if (Math.Abs(this.U[index3, index2]) > num1)
          {
            num1 = Math.Abs(this.U[index3, index2]);
            index1 = index3;
          }
        }
        if (num1 == 0.0)
          throw new Exception("The matrix is singular!");
        int num2 = this.pi[index2];
        this.pi[index2] = this.pi[index1];
        this.pi[index1] = num2;
        for (int index3 = 0; index3 < index2; ++index3)
        {
          double num3 = this.L[index2, index3];
          this.L[index2, index3] = this.L[index1, index3];
          this.L[index1, index3] = num3;
        }
        if (index2 != index1)
          this.detOfP *= -1.0;
        for (int index3 = 0; index3 < this.cols; ++index3)
        {
          double num3 = this.U[index2, index3];
          this.U[index2, index3] = this.U[index1, index3];
          this.U[index1, index3] = num3;
        }
        for (int index3 = index2 + 1; index3 < this.rows; ++index3)
        {
          this.L[index3, index2] = this.U[index3, index2] / this.U[index2, index2];
          for (int index4 = index2; index4 < this.cols; ++index4)
            this.U[index3, index4] -= this.L[index3, index2] * this.U[index2, index4];
        }
      }
    }

    public XLMatrix SolveWith(XLMatrix v)
    {
      if (this.rows != this.cols)
        throw new Exception("The matrix is not square!");
      if (this.rows != v.rows)
        throw new Exception("Wrong number of results in solution vector!");
      if (this.L == null)
        this.MakeLU();
      XLMatrix b = new XLMatrix(this.rows, 1);
      for (int index = 0; index < this.rows; ++index)
        b[index, 0] = v[this.pi[index], 0];
      return XLMatrix.SubsBack(this.U, XLMatrix.SubsForth(this.L, b));
    }

    public XLMatrix Invert()
    {
      if (this.L == null)
        this.MakeLU();
      XLMatrix xlMatrix = new XLMatrix(this.rows, this.cols);
      for (int k = 0; k < this.rows; ++k)
      {
        XLMatrix v1 = XLMatrix.ZeroMatrix(this.rows, 1);
        v1[k, 0] = 1.0;
        XLMatrix v2 = this.SolveWith(v1);
        xlMatrix.SetCol(v2, k);
      }
      return xlMatrix;
    }

    public double Determinant()
    {
      if (this.L == null)
        this.MakeLU();
      double detOfP = this.detOfP;
      for (int index = 0; index < this.rows; ++index)
        detOfP *= this.U[index, index];
      return detOfP;
    }

    public XLMatrix GetP()
    {
      if (this.L == null)
        this.MakeLU();
      XLMatrix xlMatrix = XLMatrix.ZeroMatrix(this.rows, this.cols);
      for (int index = 0; index < this.rows; ++index)
        xlMatrix[this.pi[index], index] = 1.0;
      return xlMatrix;
    }

    public XLMatrix Duplicate()
    {
      XLMatrix xlMatrix = new XLMatrix(this.rows, this.cols);
      for (int index1 = 0; index1 < this.rows; ++index1)
      {
        for (int index2 = 0; index2 < this.cols; ++index2)
          xlMatrix[index1, index2] = this.mat[index1, index2];
      }
      return xlMatrix;
    }

    public static XLMatrix SubsForth(XLMatrix A, XLMatrix b)
    {
      if (A.L == null)
        A.MakeLU();
      int rows = A.rows;
      XLMatrix xlMatrix = new XLMatrix(rows, 1);
      for (int index1 = 0; index1 < rows; ++index1)
      {
        xlMatrix[index1, 0] = b[index1, 0];
        for (int index2 = 0; index2 < index1; ++index2)
          xlMatrix[index1, 0] -= A[index1, index2] * xlMatrix[index2, 0];
        xlMatrix[index1, 0] /= A[index1, index1];
      }
      return xlMatrix;
    }

    public static XLMatrix SubsBack(XLMatrix A, XLMatrix b)
    {
      if (A.L == null)
        A.MakeLU();
      int rows = A.rows;
      XLMatrix xlMatrix = new XLMatrix(rows, 1);
      for (int index1 = rows - 1; index1 > -1; --index1)
      {
        xlMatrix[index1, 0] = b[index1, 0];
        for (int index2 = rows - 1; index2 > index1; --index2)
          xlMatrix[index1, 0] -= A[index1, index2] * xlMatrix[index2, 0];
        xlMatrix[index1, 0] /= A[index1, index1];
      }
      return xlMatrix;
    }

    public static XLMatrix ZeroMatrix(int iRows, int iCols)
    {
      XLMatrix xlMatrix = new XLMatrix(iRows, iCols);
      for (int index1 = 0; index1 < iRows; ++index1)
      {
        for (int index2 = 0; index2 < iCols; ++index2)
          xlMatrix[index1, index2] = 0.0;
      }
      return xlMatrix;
    }

    public static XLMatrix IdentityMatrix(int iRows, int iCols)
    {
      XLMatrix xlMatrix = XLMatrix.ZeroMatrix(iRows, iCols);
      for (int index = 0; index < Math.Min(iRows, iCols); ++index)
        xlMatrix[index, index] = 1.0;
      return xlMatrix;
    }

    public static XLMatrix RandomMatrix(int iRows, int iCols, int dispersion)
    {
      Random random = new Random();
      XLMatrix xlMatrix = new XLMatrix(iRows, iCols);
      for (int index1 = 0; index1 < iRows; ++index1)
      {
        for (int index2 = 0; index2 < iCols; ++index2)
          xlMatrix[index1, index2] = (double) random.Next(-dispersion, dispersion);
      }
      return xlMatrix;
    }

    public static XLMatrix Parse(string ps)
    {
      string[] strArray1 = Regex.Split(XLMatrix.NormalizeMatrixString(ps), "\r\n");
      string[] strArray2 = strArray1[0].Split(' ');
      XLMatrix xlMatrix = new XLMatrix(strArray1.Length, strArray2.Length);
      try
      {
        for (int index1 = 0; index1 < strArray1.Length; ++index1)
        {
          string[] strArray3 = strArray1[index1].Split(' ');
          for (int index2 = 0; index2 < strArray3.Length; ++index2)
            xlMatrix[index1, index2] = double.Parse(strArray3[index2]);
        }
      }
      catch (FormatException ex)
      {
        throw new Exception("Wrong input format!");
      }
      return xlMatrix;
    }

    public override string ToString()
    {
      string str = "";
      for (int index1 = 0; index1 < this.rows; ++index1)
      {
        for (int index2 = 0; index2 < this.cols; ++index2)
          str = str + string.Format("{0,5:0.00}", (object) this.mat[index1, index2]) + " ";
        str += "\r\n";
      }
      return str;
    }

    public static XLMatrix Transpose(XLMatrix m)
    {
      XLMatrix xlMatrix = new XLMatrix(m.cols, m.rows);
      for (int index1 = 0; index1 < m.rows; ++index1)
      {
        for (int index2 = 0; index2 < m.cols; ++index2)
          xlMatrix[index2, index1] = m[index1, index2];
      }
      return xlMatrix;
    }

    public static XLMatrix Power(XLMatrix m, int pow)
    {
      switch (pow)
      {
        case -1:
          return m.Invert();
        case 0:
          return XLMatrix.IdentityMatrix(m.rows, m.cols);
        case 1:
          return m.Duplicate();
        default:
          XLMatrix xlMatrix1;
          if (pow < 0)
          {
            xlMatrix1 = m.Invert();
            pow *= -1;
          }
          else
            xlMatrix1 = m.Duplicate();
          XLMatrix xlMatrix2 = XLMatrix.IdentityMatrix(m.rows, m.cols);
          while (pow != 0)
          {
            if ((pow & 1) == 1)
              xlMatrix2 *= xlMatrix1;
            xlMatrix1 *= xlMatrix1;
            pow >>= 1;
          }
          return xlMatrix2;
      }
    }

    private static void SafeAplusBintoC(XLMatrix A, int xa, int ya, XLMatrix B, int xb, int yb, XLMatrix C, int size)
    {
      for (int index1 = 0; index1 < size; ++index1)
      {
        for (int index2 = 0; index2 < size; ++index2)
        {
          C[index1, index2] = 0.0;
          if (xa + index2 < A.cols && ya + index1 < A.rows)
            C[index1, index2] += A[ya + index1, xa + index2];
          if (xb + index2 < B.cols && yb + index1 < B.rows)
            C[index1, index2] += B[yb + index1, xb + index2];
        }
      }
    }

    private static void SafeAminusBintoC(XLMatrix A, int xa, int ya, XLMatrix B, int xb, int yb, XLMatrix C, int size)
    {
      for (int index1 = 0; index1 < size; ++index1)
      {
        for (int index2 = 0; index2 < size; ++index2)
        {
          C[index1, index2] = 0.0;
          if (xa + index2 < A.cols && ya + index1 < A.rows)
            C[index1, index2] += A[ya + index1, xa + index2];
          if (xb + index2 < B.cols && yb + index1 < B.rows)
            C[index1, index2] -= B[yb + index1, xb + index2];
        }
      }
    }

    private static void SafeACopytoC(XLMatrix A, int xa, int ya, XLMatrix C, int size)
    {
      for (int index1 = 0; index1 < size; ++index1)
      {
        for (int index2 = 0; index2 < size; ++index2)
        {
          C[index1, index2] = 0.0;
          if (xa + index2 < A.cols && ya + index1 < A.rows)
            C[index1, index2] += A[ya + index1, xa + index2];
        }
      }
    }

    private static void AplusBintoC(XLMatrix A, int xa, int ya, XLMatrix B, int xb, int yb, XLMatrix C, int size)
    {
      for (int index1 = 0; index1 < size; ++index1)
      {
        for (int index2 = 0; index2 < size; ++index2)
          C[index1, index2] = A[ya + index1, xa + index2] + B[yb + index1, xb + index2];
      }
    }

    private static void AminusBintoC(XLMatrix A, int xa, int ya, XLMatrix B, int xb, int yb, XLMatrix C, int size)
    {
      for (int index1 = 0; index1 < size; ++index1)
      {
        for (int index2 = 0; index2 < size; ++index2)
          C[index1, index2] = A[ya + index1, xa + index2] - B[yb + index1, xb + index2];
      }
    }

    private static void ACopytoC(XLMatrix A, int xa, int ya, XLMatrix C, int size)
    {
      for (int index1 = 0; index1 < size; ++index1)
      {
        for (int index2 = 0; index2 < size; ++index2)
          C[index1, index2] = A[ya + index1, xa + index2];
      }
    }

    private static XLMatrix StrassenMultiply(XLMatrix A, XLMatrix B)
    {
      if (A.cols != B.rows)
        throw new Exception("Wrong dimension of matrix!");
      int num1 = Math.Max(Math.Max(A.rows, A.cols), Math.Max(B.rows, B.cols));
      if (num1 < 32)
      {
        XLMatrix xlMatrix = XLMatrix.ZeroMatrix(A.rows, B.cols);
        for (int index1 = 0; index1 < xlMatrix.rows; ++index1)
        {
          for (int index2 = 0; index2 < xlMatrix.cols; ++index2)
          {
            for (int index3 = 0; index3 < A.cols; ++index3)
              xlMatrix[index1, index2] += A[index1, index3] * B[index3, index2];
          }
        }
        return xlMatrix;
      }
      int num2 = 1;
      int length = 0;
      while (num1 > num2)
      {
        num2 *= 2;
        ++length;
      }
      int num3 = num2 / 2;
      XLMatrix[,] f = new XLMatrix[length, 9];
      for (int index1 = 0; index1 < length - 4; ++index1)
      {
        int num4 = (int) Math.Pow(2.0, (double) (length - index1 - 1));
        for (int index2 = 0; index2 < 9; ++index2)
          f[index1, index2] = new XLMatrix(num4, num4);
      }
      XLMatrix.SafeAplusBintoC(A, 0, 0, A, num3, num3, f[0, 0], num3);
      XLMatrix.SafeAplusBintoC(B, 0, 0, B, num3, num3, f[0, 1], num3);
      XLMatrix.StrassenMultiplyRun(f[0, 0], f[0, 1], f[0, 2], 1, f);
      XLMatrix.SafeAplusBintoC(A, 0, num3, A, num3, num3, f[0, 0], num3);
      XLMatrix.SafeACopytoC(B, 0, 0, f[0, 1], num3);
      XLMatrix.StrassenMultiplyRun(f[0, 0], f[0, 1], f[0, 3], 1, f);
      XLMatrix.SafeACopytoC(A, 0, 0, f[0, 0], num3);
      XLMatrix.SafeAminusBintoC(B, num3, 0, B, num3, num3, f[0, 1], num3);
      XLMatrix.StrassenMultiplyRun(f[0, 0], f[0, 1], f[0, 4], 1, f);
      XLMatrix.SafeACopytoC(A, num3, num3, f[0, 0], num3);
      XLMatrix.SafeAminusBintoC(B, 0, num3, B, 0, 0, f[0, 1], num3);
      XLMatrix.StrassenMultiplyRun(f[0, 0], f[0, 1], f[0, 5], 1, f);
      XLMatrix.SafeAplusBintoC(A, 0, 0, A, num3, 0, f[0, 0], num3);
      XLMatrix.SafeACopytoC(B, num3, num3, f[0, 1], num3);
      XLMatrix.StrassenMultiplyRun(f[0, 0], f[0, 1], f[0, 6], 1, f);
      XLMatrix.SafeAminusBintoC(A, 0, num3, A, 0, 0, f[0, 0], num3);
      XLMatrix.SafeAplusBintoC(B, 0, 0, B, num3, 0, f[0, 1], num3);
      XLMatrix.StrassenMultiplyRun(f[0, 0], f[0, 1], f[0, 7], 1, f);
      XLMatrix.SafeAminusBintoC(A, num3, 0, A, num3, num3, f[0, 0], num3);
      XLMatrix.SafeAplusBintoC(B, 0, num3, B, num3, num3, f[0, 1], num3);
      XLMatrix.StrassenMultiplyRun(f[0, 0], f[0, 1], f[0, 8], 1, f);
      XLMatrix xlMatrix1 = new XLMatrix(A.rows, B.cols);
      for (int index1 = 0; index1 < Math.Min(num3, xlMatrix1.rows); ++index1)
      {
        for (int index2 = 0; index2 < Math.Min(num3, xlMatrix1.cols); ++index2)
          xlMatrix1[index1, index2] = f[0, 2][index1, index2] + f[0, 5][index1, index2] - f[0, 6][index1, index2] + f[0, 8][index1, index2];
      }
      for (int index1 = 0; index1 < Math.Min(num3, xlMatrix1.rows); ++index1)
      {
        for (int index2 = num3; index2 < Math.Min(2 * num3, xlMatrix1.cols); ++index2)
          xlMatrix1[index1, index2] = f[0, 4][index1, index2 - num3] + f[0, 6][index1, index2 - num3];
      }
      for (int index1 = num3; index1 < Math.Min(2 * num3, xlMatrix1.rows); ++index1)
      {
        for (int index2 = 0; index2 < Math.Min(num3, xlMatrix1.cols); ++index2)
          xlMatrix1[index1, index2] = f[0, 3][index1 - num3, index2] + f[0, 5][index1 - num3, index2];
      }
      for (int index1 = num3; index1 < Math.Min(2 * num3, xlMatrix1.rows); ++index1)
      {
        for (int index2 = num3; index2 < Math.Min(2 * num3, xlMatrix1.cols); ++index2)
          xlMatrix1[index1, index2] = f[0, 2][index1 - num3, index2 - num3] - f[0, 3][index1 - num3, index2 - num3] + f[0, 4][index1 - num3, index2 - num3] + f[0, 7][index1 - num3, index2 - num3];
      }
      return xlMatrix1;
    }

    private static void StrassenMultiplyRun(XLMatrix A, XLMatrix B, XLMatrix C, int l, XLMatrix[,] f)
    {
      int rows = A.rows;
      int num = rows / 2;
      if (rows < 32)
      {
        for (int index1 = 0; index1 < C.rows; ++index1)
        {
          for (int index2 = 0; index2 < C.cols; ++index2)
          {
            C[index1, index2] = 0.0;
            for (int index3 = 0; index3 < A.cols; ++index3)
              C[index1, index2] += A[index1, index3] * B[index3, index2];
          }
        }
      }
      else
      {
        XLMatrix.AplusBintoC(A, 0, 0, A, num, num, f[l, 0], num);
        XLMatrix.AplusBintoC(B, 0, 0, B, num, num, f[l, 1], num);
        XLMatrix.StrassenMultiplyRun(f[l, 0], f[l, 1], f[l, 2], l + 1, f);
        XLMatrix.AplusBintoC(A, 0, num, A, num, num, f[l, 0], num);
        XLMatrix.ACopytoC(B, 0, 0, f[l, 1], num);
        XLMatrix.StrassenMultiplyRun(f[l, 0], f[l, 1], f[l, 3], l + 1, f);
        XLMatrix.ACopytoC(A, 0, 0, f[l, 0], num);
        XLMatrix.AminusBintoC(B, num, 0, B, num, num, f[l, 1], num);
        XLMatrix.StrassenMultiplyRun(f[l, 0], f[l, 1], f[l, 4], l + 1, f);
        XLMatrix.ACopytoC(A, num, num, f[l, 0], num);
        XLMatrix.AminusBintoC(B, 0, num, B, 0, 0, f[l, 1], num);
        XLMatrix.StrassenMultiplyRun(f[l, 0], f[l, 1], f[l, 5], l + 1, f);
        XLMatrix.AplusBintoC(A, 0, 0, A, num, 0, f[l, 0], num);
        XLMatrix.ACopytoC(B, num, num, f[l, 1], num);
        XLMatrix.StrassenMultiplyRun(f[l, 0], f[l, 1], f[l, 6], l + 1, f);
        XLMatrix.AminusBintoC(A, 0, num, A, 0, 0, f[l, 0], num);
        XLMatrix.AplusBintoC(B, 0, 0, B, num, 0, f[l, 1], num);
        XLMatrix.StrassenMultiplyRun(f[l, 0], f[l, 1], f[l, 7], l + 1, f);
        XLMatrix.AminusBintoC(A, num, 0, A, num, num, f[l, 0], num);
        XLMatrix.AplusBintoC(B, 0, num, B, num, num, f[l, 1], num);
        XLMatrix.StrassenMultiplyRun(f[l, 0], f[l, 1], f[l, 8], l + 1, f);
        for (int index1 = 0; index1 < num; ++index1)
        {
          for (int index2 = 0; index2 < num; ++index2)
            C[index1, index2] = f[l, 2][index1, index2] + f[l, 5][index1, index2] - f[l, 6][index1, index2] + f[l, 8][index1, index2];
        }
        for (int index1 = 0; index1 < num; ++index1)
        {
          for (int index2 = num; index2 < rows; ++index2)
            C[index1, index2] = f[l, 4][index1, index2 - num] + f[l, 6][index1, index2 - num];
        }
        for (int index1 = num; index1 < rows; ++index1)
        {
          for (int index2 = 0; index2 < num; ++index2)
            C[index1, index2] = f[l, 3][index1 - num, index2] + f[l, 5][index1 - num, index2];
        }
        for (int index1 = num; index1 < rows; ++index1)
        {
          for (int index2 = num; index2 < rows; ++index2)
            C[index1, index2] = f[l, 2][index1 - num, index2 - num] - f[l, 3][index1 - num, index2 - num] + f[l, 4][index1 - num, index2 - num] + f[l, 7][index1 - num, index2 - num];
        }
      }
    }

    public static XLMatrix StupidMultiply(XLMatrix m1, XLMatrix m2)
    {
      if (m1.cols != m2.rows)
        throw new Exception("Wrong dimensions of matrix!");
      XLMatrix xlMatrix = XLMatrix.ZeroMatrix(m1.rows, m2.cols);
      for (int index1 = 0; index1 < xlMatrix.rows; ++index1)
      {
        for (int index2 = 0; index2 < xlMatrix.cols; ++index2)
        {
          for (int index3 = 0; index3 < m1.cols; ++index3)
            xlMatrix[index1, index2] += m1[index1, index3] * m2[index3, index2];
        }
      }
      return xlMatrix;
    }

    private static XLMatrix Multiply(double n, XLMatrix m)
    {
      XLMatrix xlMatrix = new XLMatrix(m.rows, m.cols);
      for (int index1 = 0; index1 < m.rows; ++index1)
      {
        for (int index2 = 0; index2 < m.cols; ++index2)
          xlMatrix[index1, index2] = m[index1, index2] * n;
      }
      return xlMatrix;
    }

    private static XLMatrix Add(XLMatrix m1, XLMatrix m2)
    {
      if (m1.rows != m2.rows || m1.cols != m2.cols)
        throw new Exception("Matrices must have the same dimensions!");
      XLMatrix xlMatrix = new XLMatrix(m1.rows, m1.cols);
      for (int index1 = 0; index1 < xlMatrix.rows; ++index1)
      {
        for (int index2 = 0; index2 < xlMatrix.cols; ++index2)
          xlMatrix[index1, index2] = m1[index1, index2] + m2[index1, index2];
      }
      return xlMatrix;
    }

    public static string NormalizeMatrixString(string matStr)
    {
      while (matStr.IndexOf("  ") != -1)
        matStr = matStr.Replace("  ", " ");
      matStr = matStr.Replace(" \r\n", "\r\n");
      matStr = matStr.Replace("\r\n ", "\r\n");
      matStr = matStr.Replace("\r\n", "|");
      while (matStr.LastIndexOf("|") == matStr.Length - 1)
        matStr = matStr.Substring(0, matStr.Length - 1);
      matStr = matStr.Replace("|", "\r\n");
      return matStr;
    }

    public static XLMatrix operator -(XLMatrix m)
    {
      return XLMatrix.Multiply(-1.0, m);
    }

    public static XLMatrix operator +(XLMatrix m1, XLMatrix m2)
    {
      return XLMatrix.Add(m1, m2);
    }

    public static XLMatrix operator -(XLMatrix m1, XLMatrix m2)
    {
      return XLMatrix.Add(m1, -m2);
    }

    public static XLMatrix operator *(XLMatrix m1, XLMatrix m2)
    {
      return XLMatrix.StrassenMultiply(m1, m2);
    }

    public static XLMatrix operator *(double n, XLMatrix m)
    {
      return XLMatrix.Multiply(n, m);
    }
  }
}
