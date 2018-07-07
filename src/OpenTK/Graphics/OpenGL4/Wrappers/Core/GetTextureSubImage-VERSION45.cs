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
        /// [requires: v4.5 or ARB_get_texture_sub_image|VERSION_4_5]
        /// </summary>
        /// <param name="texture">
        /// </param>
        /// <param name="level">
        /// </param>
        /// <param name="xoffset">
        /// </param>
        /// <param name="yoffset">
        /// </param>
        /// <param name="zoffset">
        /// </param>
        /// <param name="width">
        /// </param>
        /// <param name="height">
        /// </param>
        /// <param name="depth">
        /// </param>
        /// <param name="bufSize">
        /// </param>
        /// <param name="pixels">
        /// </param>
        [AutoGenerated(Category = "ARB_get_texture_sub_image|VERSION_4_5", Version = "4.5", EntryPoint = "glGetCompressedTextureSubImage")]
        public static void GetCompressedTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, [OutAttribute] IntPtr pixels)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.5 or ARB_get_texture_sub_image|VERSION_4_5]
        /// </summary>
        /// <param name="texture">
        /// </param>
        /// <param name="level">
        /// </param>
        /// <param name="xoffset">
        /// </param>
        /// <param name="yoffset">
        /// </param>
        /// <param name="zoffset">
        /// </param>
        /// <param name="width">
        /// </param>
        /// <param name="height">
        /// </param>
        /// <param name="depth">
        /// </param>
        /// <param name="bufSize">
        /// </param>
        /// <param name="pixels">
        /// </param>
        /// <typeparam name="T9"></typeparam>
        [AutoGenerated(Category = "ARB_get_texture_sub_image|VERSION_4_5", Version = "4.5", EntryPoint = "glGetCompressedTextureSubImage")]
        public static void GetCompressedTextureSubImage<T9>(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, [InAttribute, OutAttribute] T9[] pixels)
            where T9 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.5 or ARB_get_texture_sub_image|VERSION_4_5]
        /// </summary>
        /// <param name="texture">
        /// </param>
        /// <param name="level">
        /// </param>
        /// <param name="xoffset">
        /// </param>
        /// <param name="yoffset">
        /// </param>
        /// <param name="zoffset">
        /// </param>
        /// <param name="width">
        /// </param>
        /// <param name="height">
        /// </param>
        /// <param name="depth">
        /// </param>
        /// <param name="bufSize">
        /// </param>
        /// <param name="pixels">
        /// </param>
        /// <typeparam name="T9"></typeparam>
        [AutoGenerated(Category = "ARB_get_texture_sub_image|VERSION_4_5", Version = "4.5", EntryPoint = "glGetCompressedTextureSubImage")]
        public static void GetCompressedTextureSubImage<T9>(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, [InAttribute, OutAttribute] T9[,] pixels)
            where T9 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.5 or ARB_get_texture_sub_image|VERSION_4_5]
        /// </summary>
        /// <param name="texture">
        /// </param>
        /// <param name="level">
        /// </param>
        /// <param name="xoffset">
        /// </param>
        /// <param name="yoffset">
        /// </param>
        /// <param name="zoffset">
        /// </param>
        /// <param name="width">
        /// </param>
        /// <param name="height">
        /// </param>
        /// <param name="depth">
        /// </param>
        /// <param name="bufSize">
        /// </param>
        /// <param name="pixels">
        /// </param>
        /// <typeparam name="T9"></typeparam>
        [AutoGenerated(Category = "ARB_get_texture_sub_image|VERSION_4_5", Version = "4.5", EntryPoint = "glGetCompressedTextureSubImage")]
        public static void GetCompressedTextureSubImage<T9>(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, [InAttribute, OutAttribute] T9[,,] pixels)
            where T9 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.5 or ARB_get_texture_sub_image|VERSION_4_5]
        /// </summary>
        /// <param name="texture">
        /// </param>
        /// <param name="level">
        /// </param>
        /// <param name="xoffset">
        /// </param>
        /// <param name="yoffset">
        /// </param>
        /// <param name="zoffset">
        /// </param>
        /// <param name="width">
        /// </param>
        /// <param name="height">
        /// </param>
        /// <param name="depth">
        /// </param>
        /// <param name="bufSize">
        /// </param>
        /// <param name="pixels">
        /// </param>
        /// <typeparam name="T9"></typeparam>
        [AutoGenerated(Category = "ARB_get_texture_sub_image|VERSION_4_5", Version = "4.5", EntryPoint = "glGetCompressedTextureSubImage")]
        public static void GetCompressedTextureSubImage<T9>(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, [InAttribute, OutAttribute] ref T9 pixels)
            where T9 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.5 or ARB_get_texture_sub_image|VERSION_4_5]
        /// </summary>
        /// <param name="texture">
        /// </param>
        /// <param name="level">
        /// </param>
        /// <param name="xoffset">
        /// </param>
        /// <param name="yoffset">
        /// </param>
        /// <param name="zoffset">
        /// </param>
        /// <param name="width">
        /// </param>
        /// <param name="height">
        /// </param>
        /// <param name="depth">
        /// </param>
        /// <param name="format">
        /// </param>
        /// <param name="type">
        /// </param>
        /// <param name="bufSize">
        /// </param>
        /// <param name="pixels">
        /// </param>
        [AutoGenerated(Category = "ARB_get_texture_sub_image|VERSION_4_5", Version = "4.5", EntryPoint = "glGetTextureSubImage")]
        public static void GetTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, int bufSize, [OutAttribute] IntPtr pixels)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.5 or ARB_get_texture_sub_image|VERSION_4_5]
        /// </summary>
        /// <param name="texture">
        /// </param>
        /// <param name="level">
        /// </param>
        /// <param name="xoffset">
        /// </param>
        /// <param name="yoffset">
        /// </param>
        /// <param name="zoffset">
        /// </param>
        /// <param name="width">
        /// </param>
        /// <param name="height">
        /// </param>
        /// <param name="depth">
        /// </param>
        /// <param name="format">
        /// </param>
        /// <param name="type">
        /// </param>
        /// <param name="bufSize">
        /// </param>
        /// <param name="pixels">
        /// </param>
        /// <typeparam name="T11"></typeparam>
        [AutoGenerated(Category = "ARB_get_texture_sub_image|VERSION_4_5", Version = "4.5", EntryPoint = "glGetTextureSubImage")]
        public static void GetTextureSubImage<T11>(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, int bufSize, [InAttribute, OutAttribute] T11[] pixels)
            where T11 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.5 or ARB_get_texture_sub_image|VERSION_4_5]
        /// </summary>
        /// <param name="texture">
        /// </param>
        /// <param name="level">
        /// </param>
        /// <param name="xoffset">
        /// </param>
        /// <param name="yoffset">
        /// </param>
        /// <param name="zoffset">
        /// </param>
        /// <param name="width">
        /// </param>
        /// <param name="height">
        /// </param>
        /// <param name="depth">
        /// </param>
        /// <param name="format">
        /// </param>
        /// <param name="type">
        /// </param>
        /// <param name="bufSize">
        /// </param>
        /// <param name="pixels">
        /// </param>
        /// <typeparam name="T11"></typeparam>
        [AutoGenerated(Category = "ARB_get_texture_sub_image|VERSION_4_5", Version = "4.5", EntryPoint = "glGetTextureSubImage")]
        public static void GetTextureSubImage<T11>(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, int bufSize, [InAttribute, OutAttribute] T11[,] pixels)
            where T11 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.5 or ARB_get_texture_sub_image|VERSION_4_5]
        /// </summary>
        /// <param name="texture">
        /// </param>
        /// <param name="level">
        /// </param>
        /// <param name="xoffset">
        /// </param>
        /// <param name="yoffset">
        /// </param>
        /// <param name="zoffset">
        /// </param>
        /// <param name="width">
        /// </param>
        /// <param name="height">
        /// </param>
        /// <param name="depth">
        /// </param>
        /// <param name="format">
        /// </param>
        /// <param name="type">
        /// </param>
        /// <param name="bufSize">
        /// </param>
        /// <param name="pixels">
        /// </param>
        /// <typeparam name="T11"></typeparam>
        [AutoGenerated(Category = "ARB_get_texture_sub_image|VERSION_4_5", Version = "4.5", EntryPoint = "glGetTextureSubImage")]
        public static void GetTextureSubImage<T11>(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, int bufSize, [InAttribute, OutAttribute] T11[,,] pixels)
            where T11 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.5 or ARB_get_texture_sub_image|VERSION_4_5]
        /// </summary>
        /// <param name="texture">
        /// </param>
        /// <param name="level">
        /// </param>
        /// <param name="xoffset">
        /// </param>
        /// <param name="yoffset">
        /// </param>
        /// <param name="zoffset">
        /// </param>
        /// <param name="width">
        /// </param>
        /// <param name="height">
        /// </param>
        /// <param name="depth">
        /// </param>
        /// <param name="format">
        /// </param>
        /// <param name="type">
        /// </param>
        /// <param name="bufSize">
        /// </param>
        /// <param name="pixels">
        /// </param>
        /// <typeparam name="T11"></typeparam>
        [AutoGenerated(Category = "ARB_get_texture_sub_image|VERSION_4_5", Version = "4.5", EntryPoint = "glGetTextureSubImage")]
        public static void GetTextureSubImage<T11>(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, int bufSize, [InAttribute, OutAttribute] ref T11 pixels)
            where T11 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        #pragma warning disable SA1300 // Element should begin with an upper-case letter

        [Slot(346)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glGetCompressedTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, [OutAttribute] IntPtr pixels);

        [Slot(565)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glGetTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, int bufSize, [OutAttribute] IntPtr pixels);
    }
}
