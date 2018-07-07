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
        /// Contains native bindings to functions in the category "ConditionalRender" in the extension "NV".
        /// </summary>
        public static partial class NV
        {
            /// <summary>
            /// [requires: NV_conditional_render]
            /// Start conditional rendering.
            /// </summary>
            /// <param name="id">
            /// Specifies the name of an occlusion query object whose results are used to determine if the rendering commands are discarded.
            /// </param>
            /// <param name="mode">
            /// Specifies how glBeginConditionalRender interprets the results of the occlusion query.
            /// </param>
            [AutoGenerated(Category = "NV_conditional_render", Version = "", EntryPoint = "glBeginConditionalRenderNV")]
            public static void BeginConditionalRender(uint id, OpenTK.Graphics.OpenGL4.TypeEnum mode)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_conditional_render]
            /// </summary>
            [AutoGenerated(Category = "NV_conditional_render", Version = "", EntryPoint = "glEndConditionalRenderNV")]
            public static void EndConditionalRender()
            {
                throw new BindingsNotRewrittenException();
            }

            #pragma warning disable SA1300 // Element should begin with an upper-case letter

            [Slot(7)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glBeginConditionalRenderNV(uint id, OpenTK.Graphics.OpenGL4.TypeEnum mode);

            [Slot(270)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glEndConditionalRenderNV();
        }
    }
}
