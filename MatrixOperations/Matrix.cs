using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOperations
{
    public class Matrix
    {
	    private int _rowСount;

	    private int _columnsСount;

	    public double[,] MatrixElements { get; set; }

		public int RowСount
		{
		    get { return _rowСount; }
		    set
		    {
			    if (value <= 0 || value > 4)
			    {
				    throw new ArgumentException($"{nameof(RowСount)} cannot be " +
				                                $"negative or more than four");
			    }

			    _rowСount = value;
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
				if (value <= 0 || value > 4)
				{
					throw new ArgumentException($"{nameof(СolumnsСount)} cannot be " +
					                            $"negative or more than four");
				}

				_columnsСount = value;
			}
		}

	    public Matrix(int length, int width)
		{
			RowСount = length;
			СolumnsСount = width;
			MatrixElements = new double[RowСount, СolumnsСount];
		}

    }
}
