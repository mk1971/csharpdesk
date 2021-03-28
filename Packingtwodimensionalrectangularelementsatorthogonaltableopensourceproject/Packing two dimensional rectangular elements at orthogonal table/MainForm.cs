/*****************************************************************************************************
 * Program name  : Packing two dimensional rectangular elements at orthogonal table                  *
 * Program ver.  : 1.3                                                                               *
 * Created by    : SharpDevelop                                                                      *
 * Code author   : Perić Željko                                                                      *
 * Code language : C#                                                                                *
 * Date created  : 16.12.2015                                                                        *
 * Time created  : 21:48                                                                             *
 *                                                                                                   *
 *                                                                                                   *
 * Program Description : Packing two dimensional rectangular elements at orthogonal table            *
 *                       with horizontal orientation exclusively,                                    *
 *                       by using class Pack Elements Along X Horizontally.cs.                       *
 *                                                                                                   *
 *                                                                                                   *
 *                                                                              All the best,        *
 *                                                                              Author               *
 *                                                                                                   *
 *****************************************************************************************************/

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Packing_two_dimensional_rectangular_elements_at_orthogonal_table
{
	public partial class MainForm : Form
	{
		#region Global variables
		//
		//
		//
		
		// Initial Table dimensions
		int table_length = 440;
		int table_width  = 313;
		
		// Graphics
		Graphics drawing_table;
		
		// element characteristics
		int l; // length
		int w; // width
		int a; // area
		int f; // fitting factor
		int x; // index
		
		// counters
		int i;
		int n;
		int m;
		
		//
		int val;
		
		// string format of number
		const string format = "0000000000";
		
		//
		//
		//
		#endregion
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			Initialize_Input_Tables();
			
			Initialize_Graphics(table_length,table_width);
		}
		
		#region Initialize
		void Initialize_Input_Tables()
		{
			//
			// Initialize Table_Dimensions
			//
			Table_Dimensions.Rows.Add(1);
			Table_Dimensions[0,0].Value = table_length;
			Table_Dimensions[1,0].Value = table_width;
			
			//
			// Initialize Table_Elements
			//
			i = 0;
			for (i=1;i<101;i++)
			{
				Element_List.Rows.Add(i.ToString()+" ",null,null,null,null);
			}
			Element_List.CurrentCell = Element_List[1,0];
		}
		
		void Initialize_Graphics(int Length, int Width)
		{
			//
			// Initialize new drawing table
			//
			
			// increase length and width by one
			Length++;
			Width++;
			
			// set picture length and width
			Picture.Width  = Length;
			Picture.Height = Width;
			
			// set new bitmap to image
			Picture.Image = new Bitmap(Length, Width);
			
			// set new drawing table Graphics
			drawing_table = Graphics.FromImage(Picture.Image);
			
			// decrease width by one
			Width--;
			
			// translate drawing table coordinate system origin to the lower left corner
			drawing_table.TranslateTransform(0,Width);
			
			// clear drawing table
			drawing_table.Clear(Color.White);
			
			// set position to visible scrollbars
			if(Panel.VerticalScroll.Visible)
				Panel.VerticalScroll.Value   = Panel.VerticalScroll.Maximum;
			if(Panel.HorizontalScroll.Visible)
				Panel.HorizontalScroll.Value = Panel.HorizontalScroll.Minimum;
		}
		#endregion
		
		#region Event handlers
		void Table_Dimension_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				val = int.Parse(Table_Dimensions[e.ColumnIndex,e.RowIndex].Value.ToString());
				
				if(val <= 0)
					Table_Dimensions[e.ColumnIndex,e.RowIndex].Value = 100;
			}
			catch (Exception)
			{
				MessageBox.Show("Incorrect value has been entered for table " +
				                Table_Dimensions.Columns[e.ColumnIndex].HeaderText +
				                ".   ",
				                " Entry Error   ",
				                MessageBoxButtons.OK,
				                MessageBoxIcon.Error
				               );
				
				Table_Dimensions[e.ColumnIndex,e.RowIndex].Value = 100.ToString();
			}
			
			if(Table_Dimensions[0,e.RowIndex].Value != null &&
			   Table_Dimensions[1,e.RowIndex].Value != null)
			{
				table_length = int.Parse(Table_Dimensions[0,e.RowIndex].Value.ToString());
				table_width  = int.Parse(Table_Dimensions[1,e.RowIndex].Value.ToString());
				
				// Table length value must be greater than width
				if(table_length<table_width)
				{
					Table_Dimensions[0,e.RowIndex].Value = table_width.ToString();
					Table_Dimensions[1,e.RowIndex].Value = table_length.ToString();
				}
				
				
				table_length = int.Parse(Table_Dimensions[0,e.RowIndex].Value.ToString());
				table_width  = int.Parse(Table_Dimensions[1,e.RowIndex].Value.ToString());
				
				Picture.Image.Dispose();
				drawing_table.Dispose();

				Initialize_Graphics(table_length, table_width);
			}
		}
		
		void Element_List_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				//
				// Check entered value
				//
				val = int.Parse(Element_List[e.ColumnIndex,e.RowIndex].Value.ToString());
				
				if((e.ColumnIndex == 1 && val > table_length) || val <= 0)
				{
					Element_List[e.ColumnIndex,e.RowIndex].Value = null;
					Element_List[3,e.RowIndex].Value = null;
				}
				else if((e.ColumnIndex == 2 && val > table_width) || val <= 0)
				{
					Element_List[e.ColumnIndex,e.RowIndex].Value = null;
					Element_List[3,e.RowIndex].Value = null;
				}
				else
					Element_List[e.ColumnIndex,e.RowIndex].Value = val.ToString();
				
				//
				//
				//
				if(Element_List[1,e.RowIndex].Value != null &&
				   Element_List[2,e.RowIndex].Value != null)
				{
					l = int.Parse(Element_List[1,e.RowIndex].Value.ToString());
					w = int.Parse(Element_List[2,e.RowIndex].Value.ToString());
					a = l*w;
					f = 0;
					
					// Length must be greater than width
					if(l<w)
					{
						Element_List[1,e.RowIndex].Value = w.ToString();
						Element_List[2,e.RowIndex].Value = l.ToString();
					}
					
					Element_List[3,e.RowIndex].Value = a.ToString();
					Element_List[4,e.RowIndex].Value = f.ToString();
				}
			}
			catch (Exception)
			{
				Element_List[e.ColumnIndex,e.RowIndex].Value = null;
			}
		}
		
		void Element_List_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
		{
			//
			// SortCompare event handler
			//

			// 
			// Sort elements in selected sort order
			// first by selected column then by length then by width of elements
			// 
			//
			// Compare values inside cells in selected column
			e.SortResult = System.String.CompareOrdinal(e.CellValue1.ToString(), e.CellValue2.ToString());

			// If values are equal
			// Compare values inside cells in second column
			if (e.SortResult == 0)
			{
				e.SortResult = System.String.CompareOrdinal(
					Element_List.Rows[e.RowIndex1].Cells[1].Value.ToString(),
					Element_List.Rows[e.RowIndex2].Cells[1].Value.ToString());
				
				// If values are equal
				// Compare values inside cells in third column
				if (e.SortResult == 0)
				{
					e.SortResult = System.String.CompareOrdinal(
						Element_List.Rows[e.RowIndex1].Cells[2].Value.ToString(),
						Element_List.Rows[e.RowIndex2].Cells[2].Value.ToString());
					
				}
			}
			e.Handled = true;
		}
		#endregion
		
		#region Main methods
		void Pack_Button_Click(object sender, EventArgs e)
		{
			//
			// Before packing process start,
			// sort elements in descending sort order
			// first by area then by length then by width of elements
			//
			Sort_Element_List();
			
			
			//
			// Declare new DataGridView table Table_List for memorizing
			// data of packed elements on table
			// index, position X, position Y, length and width of element
			//
			DataGridView Table_List = new DataGridView();
			
			//
			// Declare new class-type object Start,
			// type of Pack_Elements_Along_X_Horizontally class
			//
			Pack_Elements_Along_X_Horizontally Start = new Pack_Elements_Along_X_Horizontally();
			
			//
			// Fill Table_List by calling public method Pack_Elements, instance of Start,
			// that returns data grid view with packed elements data as a result of
			// packing process. Values that are going to be passed as arguments
			// are aranged and sorted accordingly to packing process demands : 
			// for horizontal orientation exclusively demand, 
			// value of length is greater or equal than value of width
			//
			Table_List = Start.Pack_Elements(table_length, table_width, Element_List);
			
			//
			// Draw packed elements
			//
			Draw_Graphics(Table_List);
			
			//
			// Release resource
			//
			Table_List.Dispose();
			
			Refresh();

		}
		
		void Format_Values_For_Sorting()
		{
			//
			// Adjust table cell values format for sort operation
			//
			// Important:
			//
			// Data stored inside array created as DataGridView class–type object
			// are always represented (memorized) as type of String.
			// When sorting, all data are compared as strings, numbers also.
			// If there is need to sort numbers, it is necessary to
			// adjust format of data, so that sort routine returns correct result.
			//
			//   numerical    formated       sorted
			//     data      for sorting    correctly
			//  as strings   as numbers    as numbers
			//
			//      "1"        "0001"        "0001"
			//     "10"        "0010"        "0003"
			//    "214"        "0214"        "0004"
			//      "3"        "0003"        "0005"
			//      "4"        "0004"        "0010"
			//      "5"        "0005"        "0214"
			//   "1024"        "1024"        "1024"
			//
			//
			//   numerical   not formated    sorted
			//     data      for sorting    correctly
			//  as strings   as numbers    as strings
			//
			//      "1"          "1"          "1"
			//     "10"         "10"         "10"
			//    "214"        "214"       "1024"
			//      "3"          "3"        "214"
			//      "4"          "4"          "3"
			//      "5"          "5"          "4"
			//   "1024"       "1024"          "5"
			//
			//
			//  Example of formating numerical data:
			//
			//  int numerical_data = 100;
			//  string format = "000000";
			//  string formated_data = data.ToString(format);
			//
			//  Result of formating:
			//
			//  numerical data   formated
			//
			//       100          000100
			//

			i = 0;
			for(i=0;i<Element_List.RowCount;i++)
			{
				if(Element_List[1,i].Value==null || Element_List[2,i].Value==null)
				{
					Element_List[0,i].Value = format;
					Element_List[1,i].Value = format;
					Element_List[2,i].Value = format;
					Element_List[3,i].Value = format;
					Element_List[4,i].Value = format;
				}
				else
				{
					Element_List[0,i].Value = int.Parse(Element_List[0,i].Value.ToString()).ToString(format);
					Element_List[1,i].Value = int.Parse(Element_List[1,i].Value.ToString()).ToString(format);
					Element_List[2,i].Value = int.Parse(Element_List[2,i].Value.ToString()).ToString(format);
					Element_List[3,i].Value = int.Parse(Element_List[3,i].Value.ToString()).ToString(format);
					Element_List[4,i].Value = int.Parse(Element_List[4,i].Value.ToString()).ToString(format);
				}
			}
		}
		
		void Sort_Element_List()
		{
			//
			// Adjust table values format for sort operation
			//
			//
			Format_Values_For_Sorting();
			
			
			//
			// Sort elements in descending sort order
			// first by area then by length then by width of element
			//
			Element_List.Sort(Element_List.Columns[3], ListSortDirection.Descending);
			
			//
			// Change table values format for presentation
			//
			Format_Sorted_Values();
		}
		
		void Format_Sorted_Values()
		{
			//
			// Format sorted table values for presentation in data grid view cells
			//
			
			i = 0;
			for(i=0;i<Element_List.RowCount;i++)
			{
				// set index value
				Element_List[0,i].Value = (i+1).ToString() + " ";
				
				if(Element_List[1,i].Value.ToString()==format || Element_List[2,i].Value.ToString()==format)
				{
					Element_List[1,i].Value = null;
					Element_List[2,i].Value = null;
					Element_List[3,i].Value = null;
					Element_List[4,i].Value = null;
				}
				else
				{
					Element_List[1,i].Value = int.Parse(Element_List[1,i].Value.ToString()).ToString();
					Element_List[2,i].Value = int.Parse(Element_List[2,i].Value.ToString()).ToString();
					Element_List[3,i].Value = int.Parse(Element_List[3,i].Value.ToString()).ToString();
					Element_List[4,i].Value = int.Parse(Element_List[4,i].Value.ToString()).ToString();
				}
				
				//
				// reset back collor of cell containing element index value
				//
				Element_List[0,i].Style.BackColor = Color.FromKnownColor(KnownColor.Control);
			}
			
			// set current data grid view cell
			Element_List.CurrentCell = Element_List[1,0];
		}
		
		void Draw_Graphics(DataGridView Table_List)
		{
			//
			// Draw packed elements
			//
			
			//
			// Local variables
			//
			Pen pencil  = new Pen(Color.Black,1);
			Brush brush = new SolidBrush(Color.Black);
			Font font   = new Font("Lucida",8,FontStyle.Regular);
			
			Rectangle element = new Rectangle();
			Point index_coordinates = new Point();
			
			// clear drawing table
			drawing_table.Clear(Color.White);
			
			n = 0; // number of packed elements
			m = 0; // elements counter
			x = 0; // element index
			
			n = Table_List.RowCount-1;
			
			m = 0;
			for(m=0;m<n;m++)
			{
				// set element width and heigth
				element.Width  = int.Parse(Table_List[3,m].Value.ToString());
				element.Height = int.Parse(Table_List[4,m].Value.ToString());

				// set element lower left corner coordinates
				element.X = int.Parse(Table_List[1,m].Value.ToString());
				element.Y = -int.Parse(Table_List[2,m].Value.ToString()) - element.Height;
				
				// draw element at drawing_table
				drawing_table.DrawRectangle(pencil, element);
				
				// set element index
				x = 0;
				x = int.Parse(Table_List[0,m].Value.ToString());
				
				// set index coordinates
				index_coordinates.X = element.X;
				index_coordinates.Y = element.Y;
				
				// draw index value
				drawing_table.DrawString(x.ToString(),font,brush,index_coordinates);
				
				//
				// Change back collor of cell containing index
				// of packed element
				//
				
				// set row index
				x--;
				
				// set back color to the first cell inside selected row
				Element_List[0,x].Style.BackColor = Color.LightGreen;
			}
			
			// release resources
			pencil.Dispose();
			brush.Dispose();
			font.Dispose();
			
			// set position to visible scroll bars
			if(Panel.VerticalScroll.Visible)
				Panel.VerticalScroll.Value   = Panel.VerticalScroll.Maximum;
			if(Panel.HorizontalScroll.Visible)
				Panel.HorizontalScroll.Value = Panel.HorizontalScroll.Minimum;
		}
		#endregion
	}
}
/************************************************************************
 * Program Licence :                                                    *
 *                                                                      *
 * Copyright 2015 , Perić Željko                                        *
 * (periczeljkosmederevo@yahoo.com)                                     *
 *                                                                      *
 * According to it's main purpose , this program is licensed            *
 * under the therms of 'Free Software' licence agreement.               *
 *                                                                      *
 * If You do not know what those therms applies to                      *
 * please read explanation at the following link :                      *
 * (http://www.gnu.org/philosophy/free-sw.html.en)                      *
 *                                                                      *
 * Since it is Free Software this program has no warranty of any kind.  *
 ************************************************************************
 * Ethical Notice :                                                     *
 *                                                                      *
 * It is not ethical to change program code signed by it's author       *
 * and then to redistribute it under the same author name ,             *
 * especially if it is incorrect.                                       *
 *                                                                      *
 * It is recommended that if You make improvement in program code ,     *
 * to make remarks of it and then to sign it with Your own name ,       *
 * for further redistribution as new major version of program.          *
 *                                                                      *
 * Author name and references of old program code version should be     *
 * kept , for tracking history of program development.                  *
 *                                                                      *
 * For any further information please contact code author at his email. *
 ************************************************************************/

/************************************
 * List Of Revisions                *
 ************************************
 *                                  *
 *                                  *
 *                                  *
 ************************************/

