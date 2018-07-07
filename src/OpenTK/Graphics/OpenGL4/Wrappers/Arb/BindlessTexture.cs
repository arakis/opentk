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
        /// Contains native bindings to functions in the category "BindlessTexture" in the extension "Arb".
        /// </summary>
        public static partial class Arb
        {
            /// <summary>
            /// [requires: ARB_bindless_texture]
            /// </summary>
            /// <param name="texture">
            /// </param>
            /// <param name="level">
            /// </param>
            /// <param name="layered">
            /// </param>
            /// <param name="layer">
            /// </param>
            /// <param name="format">
            /// </param>
            [AutoGenerated(Category = "ARB_bindless_texture", Version = "", EntryPoint = "glGetImageHandleARB")]
            public static ulong GetImageHandle(uint texture, int level, bool layered, int layer, OpenTK.Graphics.OpenGL4.PixelFormat format)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_bindless_texture]
            /// </summary>
            /// <param name="texture">
            /// </param>
            [AutoGenerated(Category = "ARB_bindless_texture", Version = "", EntryPoint = "glGetTextureHandleARB")]
            public static ulong GetTextureHandle(uint texture)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_bindless_texture]
            /// </summary>
            /// <param name="texture">
            /// </param>
            /// <param name="sampler">
            /// </param>
            [AutoGenerated(Category = "ARB_bindless_texture", Version = "", EntryPoint = "glGetTextureSamplerHandleARB")]
            public static ulong GetTextureSamplerHandle(uint texture, uint sampler)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_bindless_texture]
            /// </summary>
            /// <param name="index">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="params">
            /// </param>
            [AutoGenerated(Category = "ARB_bindless_texture", Version = "", EntryPoint = "glGetVertexAttribLui64vARB")]
            public static void GetVertexAttribL(uint index, OpenTK.Graphics.OpenGL4.VertexAttribParameterArb pname, [OutAttribute] ulong[] @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_bindless_texture]
            /// </summary>
            /// <param name="index">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="params">
            /// </param>
            [AutoGenerated(Category = "ARB_bindless_texture", Version = "", EntryPoint = "glGetVertexAttribLui64vARB")]
            public static void GetVertexAttribL(uint index, OpenTK.Graphics.OpenGL4.VertexAttribParameterArb pname, [OutAttribute] out ulong @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_bindless_texture]
            /// </summary>
            /// <param name="index">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="params">
            /// </param>
            [AutoGenerated(Category = "ARB_bindless_texture", Version = "", EntryPoint = "glGetVertexAttribLui64vARB")]
            public static unsafe void GetVertexAttribL(uint index, OpenTK.Graphics.OpenGL4.VertexAttribParameterArb pname, [OutAttribute] ulong* @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_bindless_texture]
            /// </summary>
            /// <param name="handle">
            /// </param>
            [AutoGenerated(Category = "ARB_bindless_texture", Version = "", EntryPoint = "glIsImageHandleResidentARB")]
            public static bool IsImageHandleResident(ulong handle)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_bindless_texture]
            /// </summary>
            /// <param name="handle">
            /// </param>
            [AutoGenerated(Category = "ARB_bindless_texture", Version = "", EntryPoint = "glIsTextureHandleResidentARB")]
            public static bool IsTextureHandleResident(ulong handle)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_bindless_texture]
            /// </summary>
            /// <param name="handle">
            /// </param>
            [AutoGenerated(Category = "ARB_bindless_texture", Version = "", EntryPoint = "glMakeImageHandleNonResidentARB")]
            public static void MakeImageHandleNonResident(ulong handle)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_bindless_texture]
            /// </summary>
            /// <param name="handle">
            /// </param>
            /// <param name="access">
            /// </param>
            [AutoGenerated(Category = "ARB_bindless_texture", Version = "", EntryPoint = "glMakeImageHandleResidentARB")]
            public static void MakeImageHandleResident(ulong handle, OpenTK.Graphics.OpenGL4.ArbBindlessTexture access)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_bindless_texture]
            /// </summary>
            /// <param name="handle">
            /// </param>
            [AutoGenerated(Category = "ARB_bindless_texture", Version = "", EntryPoint = "glMakeTextureHandleNonResidentARB")]
            public static void MakeTextureHandleNonResident(ulong handle)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_bindless_texture]
            /// </summary>
            /// <param name="handle">
            /// </param>
            [AutoGenerated(Category = "ARB_bindless_texture", Version = "", EntryPoint = "glMakeTextureHandleResidentARB")]
            public static void MakeTextureHandleResident(ulong handle)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_bindless_texture]
            /// </summary>
            /// <param name="program">
            /// </param>
            /// <param name="location">
            /// </param>
            /// <param name="value">
            /// </param>
            [AutoGenerated(Category = "ARB_bindless_texture", Version = "", EntryPoint = "glProgramUniformHandleui64ARB")]
            public static void ProgramUniformHandle(uint program, int location, ulong value)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_bindless_texture]
            /// </summary>
            /// <param name="program">
            /// </param>
            /// <param name="location">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="values">
            /// [length: count]
            /// </param>
            [AutoGenerated(Category = "ARB_bindless_texture", Version = "", EntryPoint = "glProgramUniformHandleui64vARB")]
            public static void ProgramUniformHandle(uint program, int location, int count, [CountAttribute(Parameter = "count")] ulong[] values)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_bindless_texture]
            /// </summary>
            /// <param name="program">
            /// </param>
            /// <param name="location">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="values">
            /// [length: count]
            /// </param>
            [AutoGenerated(Category = "ARB_bindless_texture", Version = "", EntryPoint = "glProgramUniformHandleui64vARB")]
            public static void ProgramUniformHandle(uint program, int location, int count, [CountAttribute(Parameter = "count")] ref ulong values)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_bindless_texture]
            /// </summary>
            /// <param name="program">
            /// </param>
            /// <param name="location">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="values">
            /// [length: count]
            /// </param>
            [AutoGenerated(Category = "ARB_bindless_texture", Version = "", EntryPoint = "glProgramUniformHandleui64vARB")]
            public static unsafe void ProgramUniformHandle(uint program, int location, int count, [CountAttribute(Parameter = "count")] ulong* values)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_bindless_texture]
            /// </summary>
            /// <param name="location">
            /// </param>
            /// <param name="value">
            /// </param>
            [AutoGenerated(Category = "ARB_bindless_texture", Version = "", EntryPoint = "glUniformHandleui64ARB")]
            public static void UniformHandle(int location, ulong value)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_bindless_texture]
            /// </summary>
            /// <param name="location">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="value">
            /// [length: count]
            /// </param>
            [AutoGenerated(Category = "ARB_bindless_texture", Version = "", EntryPoint = "glUniformHandleui64vARB")]
            public static void UniformHandle(int location, int count, [CountAttribute(Parameter = "count")] ulong[] value)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_bindless_texture]
            /// </summary>
            /// <param name="location">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="value">
            /// [length: count]
            /// </param>
            [AutoGenerated(Category = "ARB_bindless_texture", Version = "", EntryPoint = "glUniformHandleui64vARB")]
            public static void UniformHandle(int location, int count, [CountAttribute(Parameter = "count")] ref ulong value)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_bindless_texture]
            /// </summary>
            /// <param name="location">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="value">
            /// [length: count]
            /// </param>
            [AutoGenerated(Category = "ARB_bindless_texture", Version = "", EntryPoint = "glUniformHandleui64vARB")]
            public static unsafe void UniformHandle(int location, int count, [CountAttribute(Parameter = "count")] ulong* value)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_bindless_texture]
            /// </summary>
            /// <param name="index">
            /// </param>
            /// <param name="x">
            /// </param>
            [AutoGenerated(Category = "ARB_bindless_texture", Version = "", EntryPoint = "glVertexAttribL1ui64ARB")]
            public static void VertexAttribL1(uint index, ulong x)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_bindless_texture]
            /// </summary>
            /// <param name="index">
            /// </param>
            /// <param name="v">
            /// </param>
            [AutoGenerated(Category = "ARB_bindless_texture", Version = "", EntryPoint = "glVertexAttribL1ui64vARB")]
            public static void VertexAttribL1(uint index, ulong[] v)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_bindless_texture]
            /// </summary>
            /// <param name="index">
            /// </param>
            /// <param name="v">
            /// </param>
            [AutoGenerated(Category = "ARB_bindless_texture", Version = "", EntryPoint = "glVertexAttribL1ui64vARB")]
            public static void VertexAttribL1(uint index, ref ulong v)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_bindless_texture]
            /// </summary>
            /// <param name="index">
            /// </param>
            /// <param name="v">
            /// </param>
            [AutoGenerated(Category = "ARB_bindless_texture", Version = "", EntryPoint = "glVertexAttribL1ui64vARB")]
            public static unsafe void VertexAttribL1(uint index, ulong* v)
            {
                throw new BindingsNotRewrittenException();
            }

            #pragma warning disable SA1300 // Element should begin with an upper-case letter

            [Slot(375)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern ulong glGetImageHandleARB(uint texture, int level, bool layered, int layer, OpenTK.Graphics.OpenGL4.PixelFormat format);

            [Slot(547)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern ulong glGetTextureHandleARB(uint texture);

            [Slot(563)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern ulong glGetTextureSamplerHandleARB(uint texture, uint sampler);

            [Slot(596)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glGetVertexAttribLui64vARB(uint index, OpenTK.Graphics.OpenGL4.VertexAttribParameterArb pname, [OutAttribute] ulong* @params);

            [Slot(620)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern byte glIsImageHandleResidentARB(ulong handle);

            [Slot(637)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern byte glIsTextureHandleResidentARB(ulong handle);

            [Slot(648)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glMakeImageHandleNonResidentARB(ulong handle);

            [Slot(650)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glMakeImageHandleResidentARB(ulong handle, OpenTK.Graphics.OpenGL4.ArbBindlessTexture access);

            [Slot(654)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glMakeTextureHandleNonResidentARB(ulong handle);

            [Slot(656)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glMakeTextureHandleResidentARB(ulong handle);

            [Slot(935)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glProgramUniformHandleui64ARB(uint program, int location, ulong value);

            [Slot(937)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glProgramUniformHandleui64vARB(uint program, int location, int count, [CountAttribute(Parameter = "count")] ulong* values);

            [Slot(1178)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glUniformHandleui64ARB(int location, ulong value);

            [Slot(1180)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glUniformHandleui64vARB(int location, int count, [CountAttribute(Parameter = "count")] ulong* value);

            [Slot(1308)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glVertexAttribL1ui64ARB(uint index, ulong x);

            [Slot(1310)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glVertexAttribL1ui64vARB(uint index, ulong* v);
        }
    }
}
