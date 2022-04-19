﻿/*
 * Created by SharpDevelop.
 * User: Predator
 * Date: 09-Feb-22
 * Time: 10:09 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace termProject
{
	/// <summary>
	/// Description of RoundedButton.
	/// This class is used to create a rounded button for window forms
	/// </summary>
	public class RoundedButton : Button
	{
		private int borderSize = 0;
		private int borderRadius = 15;
		private Color borderColor = Color.Tomato;
		
		//Properties
		[Category("Rounded Button Advance")]
		public int BorderSize
		{
			get { return borderSize; }
			set
			{
				borderSize = value;
				this.Invalidate();
			}
		}
		[Category("Rounded Button Advance")]
		public int BorderRadius
		{
			get { return borderRadius; }
			set
			{
				borderRadius = value;
				this.Invalidate();
			}
		}
		[Category("Rounded Button Advance")]
		public Color BorderColor
		{
			get { return borderColor; }
			set
			{
				borderColor = value;
				this.Invalidate();
			}
		}
		[Category("Rounded Button Advance")]
		public Color BackgroundColor
		{
			get { return this.BackColor; }
			set { this.BackColor = value; }
		}
		[Category("Rounded Button Advance")]
		public Color TextColor
		{
			get { return this.ForeColor; }
			set { this.ForeColor = value; }
		}
		
		
		public RoundedButton()
		{
			this.FlatStyle = FlatStyle.Flat;
			this.FlatAppearance.BorderSize = 0;
			this.Size = new Size(73, 30);
			this.BackColor = Color.LightPink;
			this.ForeColor = Color.White;
		}//econ
		
		private void Button_Resize(object sender, EventArgs e)
		{
			if (borderRadius > this.Height)
				borderRadius = this.Height;
		}
		
		private GraphicsPath GetFigurePath(Rectangle rect, float radius)
		{
			GraphicsPath path = new GraphicsPath();
			float curveSize = radius * 2F;
			path.StartFigure();
			path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
			path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
			path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
			path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
			path.CloseFigure();
			return path;
		}
		
		protected override void OnPaint(PaintEventArgs pevent)
		{
			base.OnPaint(pevent);
			Rectangle rectSurface = this.ClientRectangle;
			Rectangle rectBorder = Rectangle.Inflate(rectSurface,-borderSize, -borderSize);
			int smoothSize = 2;
			if (borderSize > 0)
				smoothSize = borderSize;
			if (borderRadius > 2) //Rounded button
			{
				using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
					using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius-borderSize))
						using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
							using (Pen penBorder = new Pen(borderColor, borderSize))
				{
					pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
					//Button surface
					this.Region = new Region(pathSurface);
					//Draw surface border for HD result
					pevent.Graphics.DrawPath(penSurface, pathSurface);
					//Button border
					if (borderSize >= 1)
						//Draw control border
						pevent.Graphics.DrawPath(penBorder, pathBorder);
				}
			}
			else //Normal button
			{
				pevent.Graphics.SmoothingMode = SmoothingMode.None;
				//Button surface
				this.Region = new Region(rectSurface);
				//Button border
				if (borderSize >= 1)
				{
					using (Pen penBorder = new Pen(borderColor, borderSize))
					{
						penBorder.Alignment = PenAlignment.Inset;
						pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
					}
				}
			}
		}
		
		protected override void OnHandleCreated(EventArgs e)
		{
			base.OnHandleCreated(e);
			this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
		}
		private void Container_BackColorChanged(object sender, EventArgs e)
		{
			this.Invalidate();
		}
		
		
		
	}//ec
}//en