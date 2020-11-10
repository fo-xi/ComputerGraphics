using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOperations
{
    public class Matrix
    {
	    private int _rowsСount;

	    private int _columnsСount;

	    public double[,] MatrixElements { get; set; }

		public int RowsСount
		{
		    get { return _rowsСount; }
		    set
		    {
			    if (value <= 0)
			    {
				    throw new ArgumentException($"{nameof(RowsСount)} cannot be " +
				                                $"negative");
			    }

			    _rowsСount = value;
		    }
	    }

	    public int СolumnsСount
		{
			get
			{
				return _columnsСount;
			}
			set
			{
				if (value <= 0)
				{
					throw new ArgumentException($"{nameof(СolumnsСount)} cannot be " +
					                            $"negative");
				}

				_columnsСount = value;
			}
		}

	    public Matrix(int length, int width)
		{
			RowsСount = length;
			СolumnsСount = width;
			MatrixElements = new double[RowsСount, СolumnsСount];
		}

    }
}
