//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2015 Stefanos Apostolopoulos for the Open Toolkit Library
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenTK.Graphics.OpenGL4
{
    public sealed partial class GL
    {
        /// <summary>
        /// [requires: v3.3 or ARB_blend_func_extended|VERSION_3_3]
        /// Bind a user-defined varying out variable to a fragment shader color number and index.
        /// </summary>
        /// <param name="program">
        /// The name of the program containing varying out variable whose binding to modify
        /// </param>
        /// <param name="colorNumber">
        /// The color number to bind the user-defined varying out variable to
        /// </param>
        /// <param name="index">
        /// The index of the color input to bind the user-defined varying out variable to
        /// </param>
        /// <param name="name">
        /// The name of the user-defined varying out variable whose binding to modify
        /// </param>
        [AutoGenerated(Category = "ARB_blend_func_extended|VERSION_3_3", Version = "3.3", EntryPoint = "glBindFragDataLocationIndexed")]
        public static void BindFragDataLocationIndexed(uint program, uint colorNumber, uint index, string name)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.3 or ARB_blend_func_extended|VERSION_3_3]
        /// Query the bindings of color indices to user-defined varying out variables.
        /// </summary>
        /// <param name="program">
        /// The name of the program containing varying out variable whose binding to query
        /// </param>
        /// <param name="name">
        /// The name of the user-defined varying out variable whose index to query
        /// </param>
        [AutoGenerated(Category = "ARB_blend_func_extended|VERSION_3_3", Version = "3.3", EntryPoint = "glGetFragDataIndex")]
        public static int GetFragDataIndex(uint program, string name)
        {
            throw new BindingsNotRewrittenException();
        }

        #pragma warning disable SA1300 // Element should begin with an upper-case letter

        [Slot(20)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBindFragDataLocationIndexed(uint program, uint colorNumber, uint index, IntPtr name);

        [Slot(364)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern int glGetFragDataIndex(uint program, IntPtr name);
    }
}
