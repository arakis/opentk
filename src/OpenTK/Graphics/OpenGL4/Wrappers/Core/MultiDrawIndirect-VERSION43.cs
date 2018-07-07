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
        /// [requires: v4.3 or ARB_multi_draw_indirect|VERSION_4_3]
        /// Render multiple sets of primitives from array data, taking parameters from memory.
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, LineStripAdjacency, LinesAdjacency, TriangleStrip, TriangleFan, Triangles, TriangleStripAdjacency, TrianglesAdjacency, and Patches are accepted.
        /// </param>
        /// <param name="indirect">
        /// [length: COMPSIZE(drawcount,stride)]
        /// Specifies the address of an array of structures containing the draw parameters.
        /// </param>
        /// <param name="drawcount">
        /// Specifies the the number of elements in the array of draw parameter structures.
        /// </param>
        /// <param name="stride">
        /// Specifies the distance in basic machine units between elements of the draw parameter array.
        /// </param>
        [AutoGenerated(Category = "ARB_multi_draw_indirect|VERSION_4_3", Version = "4.3", EntryPoint = "glMultiDrawArraysIndirect")]
        public static void MultiDrawArraysIndirect(OpenTK.Graphics.OpenGL4.PrimitiveType mode, [CountAttribute(Computed = "drawcount,stride")] IntPtr indirect, int drawcount, int stride)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.3 or ARB_multi_draw_indirect|VERSION_4_3]
        /// Render multiple sets of primitives from array data, taking parameters from memory.
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, LineStripAdjacency, LinesAdjacency, TriangleStrip, TriangleFan, Triangles, TriangleStripAdjacency, TrianglesAdjacency, and Patches are accepted.
        /// </param>
        /// <param name="indirect">
        /// [length: COMPSIZE(drawcount,stride)]
        /// Specifies the address of an array of structures containing the draw parameters.
        /// </param>
        /// <param name="drawcount">
        /// Specifies the the number of elements in the array of draw parameter structures.
        /// </param>
        /// <param name="stride">
        /// Specifies the distance in basic machine units between elements of the draw parameter array.
        /// </param>
        /// <typeparam name="T1"></typeparam>
        [AutoGenerated(Category = "ARB_multi_draw_indirect|VERSION_4_3", Version = "4.3", EntryPoint = "glMultiDrawArraysIndirect")]
        public static void MultiDrawArraysIndirect<T1>(OpenTK.Graphics.OpenGL4.PrimitiveType mode, [InAttribute, OutAttribute, CountAttribute(Computed = "drawcount,stride")] T1[] indirect, int drawcount, int stride)
            where T1 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.3 or ARB_multi_draw_indirect|VERSION_4_3]
        /// Render multiple sets of primitives from array data, taking parameters from memory.
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, LineStripAdjacency, LinesAdjacency, TriangleStrip, TriangleFan, Triangles, TriangleStripAdjacency, TrianglesAdjacency, and Patches are accepted.
        /// </param>
        /// <param name="indirect">
        /// [length: COMPSIZE(drawcount,stride)]
        /// Specifies the address of an array of structures containing the draw parameters.
        /// </param>
        /// <param name="drawcount">
        /// Specifies the the number of elements in the array of draw parameter structures.
        /// </param>
        /// <param name="stride">
        /// Specifies the distance in basic machine units between elements of the draw parameter array.
        /// </param>
        /// <typeparam name="T1"></typeparam>
        [AutoGenerated(Category = "ARB_multi_draw_indirect|VERSION_4_3", Version = "4.3", EntryPoint = "glMultiDrawArraysIndirect")]
        public static void MultiDrawArraysIndirect<T1>(OpenTK.Graphics.OpenGL4.PrimitiveType mode, [InAttribute, OutAttribute, CountAttribute(Computed = "drawcount,stride")] T1[,] indirect, int drawcount, int stride)
            where T1 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.3 or ARB_multi_draw_indirect|VERSION_4_3]
        /// Render multiple sets of primitives from array data, taking parameters from memory.
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, LineStripAdjacency, LinesAdjacency, TriangleStrip, TriangleFan, Triangles, TriangleStripAdjacency, TrianglesAdjacency, and Patches are accepted.
        /// </param>
        /// <param name="indirect">
        /// [length: COMPSIZE(drawcount,stride)]
        /// Specifies the address of an array of structures containing the draw parameters.
        /// </param>
        /// <param name="drawcount">
        /// Specifies the the number of elements in the array of draw parameter structures.
        /// </param>
        /// <param name="stride">
        /// Specifies the distance in basic machine units between elements of the draw parameter array.
        /// </param>
        /// <typeparam name="T1"></typeparam>
        [AutoGenerated(Category = "ARB_multi_draw_indirect|VERSION_4_3", Version = "4.3", EntryPoint = "glMultiDrawArraysIndirect")]
        public static void MultiDrawArraysIndirect<T1>(OpenTK.Graphics.OpenGL4.PrimitiveType mode, [InAttribute, OutAttribute, CountAttribute(Computed = "drawcount,stride")] T1[,,] indirect, int drawcount, int stride)
            where T1 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.3 or ARB_multi_draw_indirect|VERSION_4_3]
        /// Render multiple sets of primitives from array data, taking parameters from memory.
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, LineStripAdjacency, LinesAdjacency, TriangleStrip, TriangleFan, Triangles, TriangleStripAdjacency, TrianglesAdjacency, and Patches are accepted.
        /// </param>
        /// <param name="indirect">
        /// [length: COMPSIZE(drawcount,stride)]
        /// Specifies the address of an array of structures containing the draw parameters.
        /// </param>
        /// <param name="drawcount">
        /// Specifies the the number of elements in the array of draw parameter structures.
        /// </param>
        /// <param name="stride">
        /// Specifies the distance in basic machine units between elements of the draw parameter array.
        /// </param>
        /// <typeparam name="T1"></typeparam>
        [AutoGenerated(Category = "ARB_multi_draw_indirect|VERSION_4_3", Version = "4.3", EntryPoint = "glMultiDrawArraysIndirect")]
        public static void MultiDrawArraysIndirect<T1>(OpenTK.Graphics.OpenGL4.PrimitiveType mode, [InAttribute, OutAttribute, CountAttribute(Computed = "drawcount,stride")] ref T1 indirect, int drawcount, int stride)
            where T1 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.3 or ARB_multi_draw_indirect|VERSION_4_3]
        /// Render indexed primitives from array data, taking parameters from memory.
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, LineStripAdjacency, LinesAdjacency, TriangleStrip, TriangleFan, Triangles, TriangleStripAdjacency, TrianglesAdjacency, and Patches are accepted.
        /// </param>
        /// <param name="type">
        /// Specifies the type of data in the buffer bound to the ElementArrayBuffer binding.
        /// </param>
        /// <param name="indirect">
        /// [length: COMPSIZE(drawcount,stride)]
        /// Specifies the address of a structure containing an array of draw parameters.
        /// </param>
        /// <param name="drawcount">
        /// Specifies the number of elements in the array addressed by indirect.
        /// </param>
        /// <param name="stride">
        /// Specifies the distance in basic machine units between elements of the draw parameter array.
        /// </param>
        [AutoGenerated(Category = "ARB_multi_draw_indirect|VERSION_4_3", Version = "4.3", EntryPoint = "glMultiDrawElementsIndirect")]
        public static void MultiDrawElementsIndirect(OpenTK.Graphics.OpenGL4.PrimitiveType mode, OpenTK.Graphics.OpenGL4.DrawElementsType type, [CountAttribute(Computed = "drawcount,stride")] IntPtr indirect, int drawcount, int stride)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.3 or ARB_multi_draw_indirect|VERSION_4_3]
        /// Render indexed primitives from array data, taking parameters from memory.
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, LineStripAdjacency, LinesAdjacency, TriangleStrip, TriangleFan, Triangles, TriangleStripAdjacency, TrianglesAdjacency, and Patches are accepted.
        /// </param>
        /// <param name="type">
        /// Specifies the type of data in the buffer bound to the ElementArrayBuffer binding.
        /// </param>
        /// <param name="indirect">
        /// [length: COMPSIZE(drawcount,stride)]
        /// Specifies the address of a structure containing an array of draw parameters.
        /// </param>
        /// <param name="drawcount">
        /// Specifies the number of elements in the array addressed by indirect.
        /// </param>
        /// <param name="stride">
        /// Specifies the distance in basic machine units between elements of the draw parameter array.
        /// </param>
        /// <typeparam name="T2"></typeparam>
        [AutoGenerated(Category = "ARB_multi_draw_indirect|VERSION_4_3", Version = "4.3", EntryPoint = "glMultiDrawElementsIndirect")]
        public static void MultiDrawElementsIndirect<T2>(OpenTK.Graphics.OpenGL4.PrimitiveType mode, OpenTK.Graphics.OpenGL4.DrawElementsType type, [InAttribute, OutAttribute, CountAttribute(Computed = "drawcount,stride")] T2[] indirect, int drawcount, int stride)
            where T2 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.3 or ARB_multi_draw_indirect|VERSION_4_3]
        /// Render indexed primitives from array data, taking parameters from memory.
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, LineStripAdjacency, LinesAdjacency, TriangleStrip, TriangleFan, Triangles, TriangleStripAdjacency, TrianglesAdjacency, and Patches are accepted.
        /// </param>
        /// <param name="type">
        /// Specifies the type of data in the buffer bound to the ElementArrayBuffer binding.
        /// </param>
        /// <param name="indirect">
        /// [length: COMPSIZE(drawcount,stride)]
        /// Specifies the address of a structure containing an array of draw parameters.
        /// </param>
        /// <param name="drawcount">
        /// Specifies the number of elements in the array addressed by indirect.
        /// </param>
        /// <param name="stride">
        /// Specifies the distance in basic machine units between elements of the draw parameter array.
        /// </param>
        /// <typeparam name="T2"></typeparam>
        [AutoGenerated(Category = "ARB_multi_draw_indirect|VERSION_4_3", Version = "4.3", EntryPoint = "glMultiDrawElementsIndirect")]
        public static void MultiDrawElementsIndirect<T2>(OpenTK.Graphics.OpenGL4.PrimitiveType mode, OpenTK.Graphics.OpenGL4.DrawElementsType type, [InAttribute, OutAttribute, CountAttribute(Computed = "drawcount,stride")] T2[,] indirect, int drawcount, int stride)
            where T2 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.3 or ARB_multi_draw_indirect|VERSION_4_3]
        /// Render indexed primitives from array data, taking parameters from memory.
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, LineStripAdjacency, LinesAdjacency, TriangleStrip, TriangleFan, Triangles, TriangleStripAdjacency, TrianglesAdjacency, and Patches are accepted.
        /// </param>
        /// <param name="type">
        /// Specifies the type of data in the buffer bound to the ElementArrayBuffer binding.
        /// </param>
        /// <param name="indirect">
        /// [length: COMPSIZE(drawcount,stride)]
        /// Specifies the address of a structure containing an array of draw parameters.
        /// </param>
        /// <param name="drawcount">
        /// Specifies the number of elements in the array addressed by indirect.
        /// </param>
        /// <param name="stride">
        /// Specifies the distance in basic machine units between elements of the draw parameter array.
        /// </param>
        /// <typeparam name="T2"></typeparam>
        [AutoGenerated(Category = "ARB_multi_draw_indirect|VERSION_4_3", Version = "4.3", EntryPoint = "glMultiDrawElementsIndirect")]
        public static void MultiDrawElementsIndirect<T2>(OpenTK.Graphics.OpenGL4.PrimitiveType mode, OpenTK.Graphics.OpenGL4.DrawElementsType type, [InAttribute, OutAttribute, CountAttribute(Computed = "drawcount,stride")] T2[,,] indirect, int drawcount, int stride)
            where T2 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.3 or ARB_multi_draw_indirect|VERSION_4_3]
        /// Render indexed primitives from array data, taking parameters from memory.
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, LineStripAdjacency, LinesAdjacency, TriangleStrip, TriangleFan, Triangles, TriangleStripAdjacency, TrianglesAdjacency, and Patches are accepted.
        /// </param>
        /// <param name="type">
        /// Specifies the type of data in the buffer bound to the ElementArrayBuffer binding.
        /// </param>
        /// <param name="indirect">
        /// [length: COMPSIZE(drawcount,stride)]
        /// Specifies the address of a structure containing an array of draw parameters.
        /// </param>
        /// <param name="drawcount">
        /// Specifies the number of elements in the array addressed by indirect.
        /// </param>
        /// <param name="stride">
        /// Specifies the distance in basic machine units between elements of the draw parameter array.
        /// </param>
        /// <typeparam name="T2"></typeparam>
        [AutoGenerated(Category = "ARB_multi_draw_indirect|VERSION_4_3", Version = "4.3", EntryPoint = "glMultiDrawElementsIndirect")]
        public static void MultiDrawElementsIndirect<T2>(OpenTK.Graphics.OpenGL4.PrimitiveType mode, OpenTK.Graphics.OpenGL4.DrawElementsType type, [InAttribute, OutAttribute, CountAttribute(Computed = "drawcount,stride")] ref T2 indirect, int drawcount, int stride)
            where T2 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        #pragma warning disable SA1300 // Element should begin with an upper-case letter

        [Slot(697)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glMultiDrawArraysIndirect(OpenTK.Graphics.OpenGL4.PrimitiveType mode, [CountAttribute(Computed = "drawcount,stride")] IntPtr indirect, int drawcount, int stride);

        [Slot(704)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glMultiDrawElementsIndirect(OpenTK.Graphics.OpenGL4.PrimitiveType mode, OpenTK.Graphics.OpenGL4.DrawElementsType type, [CountAttribute(Computed = "drawcount,stride")] IntPtr indirect, int drawcount, int stride);
    }
}
