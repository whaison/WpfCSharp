﻿// (C) Copyright 2014 by Autodesk, Inc.
//
// Permission to use, copy, modify, and distribute this software in
// object code form for any purpose and without fee is hereby granted, 
// provided that the above copyright notice appears in all copies and 
// that both that copyright notice and the limited warranty and
// restricted rights notice below appear in all supporting 
// documentation.
//
// AUTODESK PROVIDES THIS PROGRAM "AS IS" AND WITH ALL FAULTS. 
// AUTODESK SPECIFICALLY DISCLAIMS ANY IMPLIED WARRANTY OF
// MERCHANTABILITY OR FITNESS FOR A PARTICULAR USE.  AUTODESK, INC. 
// DOES NOT WARRANT THAT THE OPERATION OF THE PROGRAM WILL BE
// UNINTERRUPTED OR ERROR FREE.

//- Written by Cyrille Fauvel, Autodesk Developer Network (ADN)
//- http://www.autodesk.com/joinadn
//- January 20th, 2014
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Autodesk.ADN.WpfReCap {
	
	// Cursor switcher utility
	public class CursorSwitcher : IDisposable {
		private Cursor _previousCursor ;

		public CursorSwitcher (Cursor cursor) {
			_previousCursor =Mouse.OverrideCursor ;
			if ( cursor == null )
				Mouse.OverrideCursor =Cursors.Wait ;
			else
				Mouse.OverrideCursor =cursor ;
		}

		public void Dispose () {
			Mouse.OverrideCursor =_previousCursor ;
		}

	}

}
