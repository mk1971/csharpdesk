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

namespace Packing_two_dimensional_rectangular_elements_at_orthogonal_table
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Panel = new System.Windows.Forms.Panel();
			this.Picture = new System.Windows.Forms.PictureBox();
			this.Table_Dimensions = new System.Windows.Forms.DataGridView();
			this.T_Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.T_Width = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Element_List = new System.Windows.Forms.DataGridView();
			this.E_Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.E_Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.E_Width = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.E_Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.E_Fit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Pack_Button = new System.Windows.Forms.Button();
			this.Panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Table_Dimensions)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Element_List)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(153, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Table";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(153, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Elements";
			// 
			// Panel
			// 
			this.Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.Panel.AutoScroll = true;
			this.Panel.BackColor = System.Drawing.SystemColors.Control;
			this.Panel.Controls.Add(this.Picture);
			this.Panel.Location = new System.Drawing.Point(341, 29);
			this.Panel.Name = "Panel";
			this.Panel.Size = new System.Drawing.Size(441, 314);
			this.Panel.TabIndex = 5;
			// 
			// Picture
			// 
			this.Picture.BackColor = System.Drawing.Color.White;
			this.Picture.Location = new System.Drawing.Point(0, 0);
			this.Picture.Name = "Picture";
			this.Picture.Size = new System.Drawing.Size(314, 258);
			this.Picture.TabIndex = 0;
			this.Picture.TabStop = false;
			// 
			// Table_Dimensions
			// 
			this.Table_Dimensions.AllowUserToAddRows = false;
			this.Table_Dimensions.AllowUserToDeleteRows = false;
			this.Table_Dimensions.AllowUserToResizeColumns = false;
			this.Table_Dimensions.AllowUserToResizeRows = false;
			this.Table_Dimensions.BackgroundColor = System.Drawing.SystemColors.Control;
			this.Table_Dimensions.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Table_Dimensions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
			this.Table_Dimensions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.Format = "N0";
			dataGridViewCellStyle1.NullValue = null;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.Table_Dimensions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.Table_Dimensions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.Table_Dimensions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.T_Length,
									this.T_Width});
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.Table_Dimensions.DefaultCellStyle = dataGridViewCellStyle4;
			this.Table_Dimensions.EnableHeadersVisualStyles = false;
			this.Table_Dimensions.Location = new System.Drawing.Point(12, 29);
			this.Table_Dimensions.Name = "Table_Dimensions";
			this.Table_Dimensions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			this.Table_Dimensions.RowHeadersVisible = false;
			this.Table_Dimensions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.Table_Dimensions.Size = new System.Drawing.Size(251, 45);
			this.Table_Dimensions.TabIndex = 3;
			this.Table_Dimensions.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_Dimension_CellEndEdit);
			// 
			// T_Length
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.Format = "N0";
			dataGridViewCellStyle2.NullValue = null;
			this.T_Length.DefaultCellStyle = dataGridViewCellStyle2;
			this.T_Length.HeaderText = "length";
			this.T_Length.MaxInputLength = 4;
			this.T_Length.Name = "T_Length";
			this.T_Length.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.T_Length.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.T_Length.Width = 125;
			// 
			// T_Width
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.Format = "N0";
			dataGridViewCellStyle3.NullValue = null;
			this.T_Width.DefaultCellStyle = dataGridViewCellStyle3;
			this.T_Width.HeaderText = "width";
			this.T_Width.MaxInputLength = 4;
			this.T_Width.Name = "T_Width";
			this.T_Width.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.T_Width.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.T_Width.Width = 125;
			// 
			// Element_List
			// 
			this.Element_List.AllowUserToAddRows = false;
			this.Element_List.AllowUserToDeleteRows = false;
			this.Element_List.AllowUserToResizeColumns = false;
			this.Element_List.AllowUserToResizeRows = false;
			this.Element_List.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.Element_List.BackgroundColor = System.Drawing.SystemColors.Control;
			this.Element_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Element_List.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
			this.Element_List.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
			this.Element_List.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.Format = "N0";
			dataGridViewCellStyle5.NullValue = null;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.Element_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.Element_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.Element_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.E_Index,
									this.E_Length,
									this.E_Width,
									this.E_Area,
									this.E_Fit});
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.Element_List.DefaultCellStyle = dataGridViewCellStyle11;
			this.Element_List.EnableHeadersVisualStyles = false;
			this.Element_List.Location = new System.Drawing.Point(12, 99);
			this.Element_List.Name = "Element_List";
			this.Element_List.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			this.Element_List.RowHeadersVisible = false;
			this.Element_List.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.Element_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.Element_List.Size = new System.Drawing.Size(320, 244);
			this.Element_List.TabIndex = 4;
			this.Element_List.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Element_List_CellEndEdit);
			this.Element_List.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.Element_List_SortCompare);
			// 
			// E_Index
			// 
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle6.Format = "N0";
			dataGridViewCellStyle6.NullValue = null;
			this.E_Index.DefaultCellStyle = dataGridViewCellStyle6;
			this.E_Index.HeaderText = "no";
			this.E_Index.MaxInputLength = 3;
			this.E_Index.Name = "E_Index";
			this.E_Index.ReadOnly = true;
			this.E_Index.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.E_Index.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.E_Index.Width = 50;
			// 
			// E_Length
			// 
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle7.Format = "N0";
			dataGridViewCellStyle7.NullValue = null;
			this.E_Length.DefaultCellStyle = dataGridViewCellStyle7;
			this.E_Length.HeaderText = "length";
			this.E_Length.MaxInputLength = 4;
			this.E_Length.Name = "E_Length";
			this.E_Length.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.E_Length.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.E_Length.Width = 75;
			// 
			// E_Width
			// 
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle8.Format = "N0";
			dataGridViewCellStyle8.NullValue = null;
			this.E_Width.DefaultCellStyle = dataGridViewCellStyle8;
			this.E_Width.HeaderText = "width";
			this.E_Width.MaxInputLength = 4;
			this.E_Width.Name = "E_Width";
			this.E_Width.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.E_Width.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.E_Width.Width = 75;
			// 
			// E_Area
			// 
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle9.Format = "N0";
			dataGridViewCellStyle9.NullValue = null;
			this.E_Area.DefaultCellStyle = dataGridViewCellStyle9;
			this.E_Area.HeaderText = "area";
			this.E_Area.MaxInputLength = 10;
			this.E_Area.Name = "E_Area";
			this.E_Area.ReadOnly = true;
			this.E_Area.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.E_Area.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// E_Fit
			// 
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle10.Format = "N0";
			dataGridViewCellStyle10.NullValue = null;
			this.E_Fit.DefaultCellStyle = dataGridViewCellStyle10;
			this.E_Fit.HeaderText = "fitting factor";
			this.E_Fit.MaxInputLength = 1;
			this.E_Fit.Name = "E_Fit";
			this.E_Fit.ReadOnly = true;
			this.E_Fit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.E_Fit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.E_Fit.Visible = false;
			// 
			// Pack_Button
			// 
			this.Pack_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Pack_Button.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Pack_Button.Location = new System.Drawing.Point(269, 29);
			this.Pack_Button.Name = "Pack_Button";
			this.Pack_Button.Size = new System.Drawing.Size(63, 45);
			this.Pack_Button.TabIndex = 0;
			this.Pack_Button.Text = "&Pack";
			this.Pack_Button.UseVisualStyleBackColor = true;
			this.Pack_Button.Click += new System.EventHandler(this.Pack_Button_Click);
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(794, 382);
			this.Controls.Add(this.Element_List);
			this.Controls.Add(this.Table_Dimensions);
			this.Controls.Add(this.Pack_Button);
			this.Controls.Add(this.Panel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "    Packing two dimensional rectangular elements at orthogonal table";
			this.Panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Table_Dimensions)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Element_List)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn T_Width;
		private System.Windows.Forms.DataGridViewTextBoxColumn T_Length;
		private System.Windows.Forms.DataGridViewTextBoxColumn E_Fit;
		private System.Windows.Forms.DataGridViewTextBoxColumn E_Area;
		private System.Windows.Forms.DataGridViewTextBoxColumn E_Width;
		private System.Windows.Forms.DataGridViewTextBoxColumn E_Length;
		private System.Windows.Forms.DataGridViewTextBoxColumn E_Index;
		private System.Windows.Forms.DataGridView Element_List;
		
		private System.Windows.Forms.DataGridView Table_Dimensions;
		
		private System.Windows.Forms.Button Pack_Button;
		
		private System.Windows.Forms.PictureBox Picture;
		
		private System.Windows.Forms.Panel Panel;
		
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
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
