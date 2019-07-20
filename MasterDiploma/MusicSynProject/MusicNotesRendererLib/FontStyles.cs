﻿/*
Polish System for Archivising Music Control Library (PSAM Control Library)
http://www.archiwistykamuzyczna.pl/index.php?article=download&lang=en#MusicNotesRendererLib

Copyright (c) 2010, Jacek Salamon
All rights reserved.

Redistribution and use in source and binary forms, with or without modification, 
are permitted provided that the following conditions are met:

* Redistributions of source code must retain the above copyright notice, this list
  of conditions and the following disclaimer.
* Redistributions in binary form must reproduce the above copyright notice, this list
  of conditions and the following disclaimer in the documentation and/or other
  materials provided with the distribution.
* Neither the name of Jacek Salamon nor the names of contributors may be used to
  endorse or promote products derived from this software without specific prior
  written permission.
 
THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY
EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES
OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT
SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT
OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)
HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR
TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE,
EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE. 

============================================================================================
Fugue Icons
Copyright (C) 2009 Yusuke Kamiyamane. All rights reserved.
The icons are licensed under a Creative Commons Attribution 3.0 license.
*/

using System.Drawing;

namespace MusicNotesRendererLib
{
    public static class FontStyles
    {
        public static Font MusicFont = new Font("Polihymnia", 20);
        public static Font GraceNoteFont = new Font("Polihymnia", 18);
        public static Font StaffFont = new Font("Polihymnia", 23);
        public static Font LyricFont = new Font("Times New Roman", 8);
        public static Font LyricFontBold = new Font("Times New Roman", 10, FontStyle.Bold);
        public static Font MiscArticulationFont = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
        public static Font DirectionFont = new Font("Microsoft Sans Serif", 9, FontStyle.Italic | FontStyle.Bold);
        public static Font TrillFont = new Font("Times New Roman", 9, FontStyle.Italic | FontStyle.Bold);
        public static Font TimeSignatureFont = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
    }
}
