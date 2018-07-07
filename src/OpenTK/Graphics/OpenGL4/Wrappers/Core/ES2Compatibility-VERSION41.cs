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
        /// [requires: v4.1 or ARB_ES2_compatibility|VERSION_4_1]
        /// Specify the clear value for the depth buffer.
        /// </summary>
        /// <param name="d">
        /// Specifies the depth value used when the depth buffer is cleared. The initial value is 1.
        /// </param>
        [AutoGenerated(Category = "ARB_ES2_compatibility|VERSION_4_1", Version = "4.1", EntryPoint = "glClearDepthf")]
        public static void ClearDepth(float d)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_ES2_compatibility|VERSION_4_1]
        /// Specify mapping of depth values from normalized device coordinates to window coordinates.
        /// </summary>
        /// <param name="n">
        /// Specifies the mapping of the near clipping plane to window coordinates. The initial value is 0.
        /// </param>
        /// <param name="f">
        /// Specifies the mapping of the far clipping plane to window coordinates. The initial value is 1.
        /// </param>
        [AutoGenerated(Category = "ARB_ES2_compatibility|VERSION_4_1", Version = "4.1", EntryPoint = "glDepthRangef")]
        public static void DepthRange(float n, float f)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_ES2_compatibility|VERSION_4_1]
        /// Retrieve the range and precision for numeric formats supported by the shader compiler.
        /// </summary>
        /// <param name="shadertype">
        /// Specifies the type of shader whose precision to query. shaderType must be VertexShader or FragmentShader.
        /// </param>
        /// <param name="precisiontype">
        /// Specifies the numeric format whose precision and range to query.
        /// </param>
        /// <param name="range">
        /// [length: 2]
        /// Specifies the address of array of two integers into which encodings of the implementation's numeric range are returned.
        /// </param>
        /// <param name="precision">
        /// [length: 1]
        /// Specifies the address of an integer into which the numeric precision of the implementation is written.
        /// </param>
        [AutoGenerated(Category = "ARB_ES2_compatibility|VERSION_4_1", Version = "4.1", EntryPoint = "glGetShaderPrecisionFormat")]
        public static void GetShaderPrecisionFormat(OpenTK.Graphics.OpenGL4.ShaderType shadertype, OpenTK.Graphics.OpenGL4.ShaderPrecision precisiontype, [OutAttribute, CountAttribute(Count = 2)] int[] range, [OutAttribute, CountAttribute(Count = 1)] out int precision)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_ES2_compatibility|VERSION_4_1]
        /// Retrieve the range and precision for numeric formats supported by the shader compiler.
        /// </summary>
        /// <param name="shadertype">
        /// Specifies the type of shader whose precision to query. shaderType must be VertexShader or FragmentShader.
        /// </param>
        /// <param name="precisiontype">
        /// Specifies the numeric format whose precision and range to query.
        /// </param>
        /// <param name="range">
        /// [length: 2]
        /// Specifies the address of array of two integers into which encodings of the implementation's numeric range are returned.
        /// </param>
        /// <param name="precision">
        /// [length: 1]
        /// Specifies the address of an integer into which the numeric precision of the implementation is written.
        /// </param>
        [AutoGenerated(Category = "ARB_ES2_compatibility|VERSION_4_1", Version = "4.1", EntryPoint = "glGetShaderPrecisionFormat")]
        public static void GetShaderPrecisionFormat(OpenTK.Graphics.OpenGL4.ShaderType shadertype, OpenTK.Graphics.OpenGL4.ShaderPrecision precisiontype, [OutAttribute, CountAttribute(Count = 2)] out int range, [OutAttribute, CountAttribute(Count = 1)] out int precision)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_ES2_compatibility|VERSION_4_1]
        /// Retrieve the range and precision for numeric formats supported by the shader compiler.
        /// </summary>
        /// <param name="shadertype">
        /// Specifies the type of shader whose precision to query. shaderType must be VertexShader or FragmentShader.
        /// </param>
        /// <param name="precisiontype">
        /// Specifies the numeric format whose precision and range to query.
        /// </param>
        /// <param name="range">
        /// [length: 2]
        /// Specifies the address of array of two integers into which encodings of the implementation's numeric range are returned.
        /// </param>
        /// <param name="precision">
        /// [length: 1]
        /// Specifies the address of an integer into which the numeric precision of the implementation is written.
        /// </param>
        [AutoGenerated(Category = "ARB_ES2_compatibility|VERSION_4_1", Version = "4.1", EntryPoint = "glGetShaderPrecisionFormat")]
        public static unsafe void GetShaderPrecisionFormat(OpenTK.Graphics.OpenGL4.ShaderType shadertype, OpenTK.Graphics.OpenGL4.ShaderPrecision precisiontype, [OutAttribute, CountAttribute(Count = 2)] int* range, [OutAttribute, CountAttribute(Count = 1)] int* precision)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_ES2_compatibility|VERSION_4_1]
        /// Release resources consumed by the implementation's shader compiler.
        /// </summary>
        [AutoGenerated(Category = "ARB_ES2_compatibility|VERSION_4_1", Version = "4.1", EntryPoint = "glReleaseShaderCompiler")]
        public static void ReleaseShaderCompiler()
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_ES2_compatibility|VERSION_4_1]
        /// Load pre-compiled shader binaries.
        /// </summary>
        /// <param name="count">
        /// Specifies the number of shader object handles contained in shaders.
        /// </param>
        /// <param name="shaders">
        /// [length: count]
        /// Specifies the address of an array of shader handles into which to load pre-compiled shader binaries.
        /// </param>
        /// <param name="binaryformat">
        /// Specifies the format of the shader binaries contained in binary.
        /// </param>
        /// <param name="binary">
        /// [length: length]
        /// Specifies the address of an array of bytes containing pre-compiled binary shader code.
        /// </param>
        /// <param name="length">
        /// Specifies the length of the array whose address is given in binary.
        /// </param>
        [AutoGenerated(Category = "ARB_ES2_compatibility|VERSION_4_1", Version = "4.1", EntryPoint = "glShaderBinary")]
        public static void ShaderBinary(int count, [CountAttribute(Parameter = "count")] uint[] shaders, OpenTK.Graphics.OpenGL4.BinaryFormat binaryformat, [CountAttribute(Parameter = "length")] IntPtr binary, int length)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_ES2_compatibility|VERSION_4_1]
        /// Load pre-compiled shader binaries.
        /// </summary>
        /// <param name="count">
        /// Specifies the number of shader object handles contained in shaders.
        /// </param>
        /// <param name="shaders">
        /// [length: count]
        /// Specifies the address of an array of shader handles into which to load pre-compiled shader binaries.
        /// </param>
        /// <param name="binaryformat">
        /// Specifies the format of the shader binaries contained in binary.
        /// </param>
        /// <param name="binary">
        /// [length: length]
        /// Specifies the address of an array of bytes containing pre-compiled binary shader code.
        /// </param>
        /// <param name="length">
        /// Specifies the length of the array whose address is given in binary.
        /// </param>
        /// <typeparam name="T3"></typeparam>
        [AutoGenerated(Category = "ARB_ES2_compatibility|VERSION_4_1", Version = "4.1", EntryPoint = "glShaderBinary")]
        public static void ShaderBinary<T3>(int count, [CountAttribute(Parameter = "count")] uint[] shaders, OpenTK.Graphics.OpenGL4.BinaryFormat binaryformat, [InAttribute, OutAttribute, CountAttribute(Parameter = "length")] T3[] binary, int length)
            where T3 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_ES2_compatibility|VERSION_4_1]
        /// Load pre-compiled shader binaries.
        /// </summary>
        /// <param name="count">
        /// Specifies the number of shader object handles contained in shaders.
        /// </param>
        /// <param name="shaders">
        /// [length: count]
        /// Specifies the address of an array of shader handles into which to load pre-compiled shader binaries.
        /// </param>
        /// <param name="binaryformat">
        /// Specifies the format of the shader binaries contained in binary.
        /// </param>
        /// <param name="binary">
        /// [length: length]
        /// Specifies the address of an array of bytes containing pre-compiled binary shader code.
        /// </param>
        /// <param name="length">
        /// Specifies the length of the array whose address is given in binary.
        /// </param>
        /// <typeparam name="T3"></typeparam>
        [AutoGenerated(Category = "ARB_ES2_compatibility|VERSION_4_1", Version = "4.1", EntryPoint = "glShaderBinary")]
        public static void ShaderBinary<T3>(int count, [CountAttribute(Parameter = "count")] uint[] shaders, OpenTK.Graphics.OpenGL4.BinaryFormat binaryformat, [InAttribute, OutAttribute, CountAttribute(Parameter = "length")] T3[,] binary, int length)
            where T3 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_ES2_compatibility|VERSION_4_1]
        /// Load pre-compiled shader binaries.
        /// </summary>
        /// <param name="count">
        /// Specifies the number of shader object handles contained in shaders.
        /// </param>
        /// <param name="shaders">
        /// [length: count]
        /// Specifies the address of an array of shader handles into which to load pre-compiled shader binaries.
        /// </param>
        /// <param name="binaryformat">
        /// Specifies the format of the shader binaries contained in binary.
        /// </param>
        /// <param name="binary">
        /// [length: length]
        /// Specifies the address of an array of bytes containing pre-compiled binary shader code.
        /// </param>
        /// <param name="length">
        /// Specifies the length of the array whose address is given in binary.
        /// </param>
        /// <typeparam name="T3"></typeparam>
        [AutoGenerated(Category = "ARB_ES2_compatibility|VERSION_4_1", Version = "4.1", EntryPoint = "glShaderBinary")]
        public static void ShaderBinary<T3>(int count, [CountAttribute(Parameter = "count")] uint[] shaders, OpenTK.Graphics.OpenGL4.BinaryFormat binaryformat, [InAttribute, OutAttribute, CountAttribute(Parameter = "length")] T3[,,] binary, int length)
            where T3 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_ES2_compatibility|VERSION_4_1]
        /// Load pre-compiled shader binaries.
        /// </summary>
        /// <param name="count">
        /// Specifies the number of shader object handles contained in shaders.
        /// </param>
        /// <param name="shaders">
        /// [length: count]
        /// Specifies the address of an array of shader handles into which to load pre-compiled shader binaries.
        /// </param>
        /// <param name="binaryformat">
        /// Specifies the format of the shader binaries contained in binary.
        /// </param>
        /// <param name="binary">
        /// [length: length]
        /// Specifies the address of an array of bytes containing pre-compiled binary shader code.
        /// </param>
        /// <param name="length">
        /// Specifies the length of the array whose address is given in binary.
        /// </param>
        /// <typeparam name="T3"></typeparam>
        [AutoGenerated(Category = "ARB_ES2_compatibility|VERSION_4_1", Version = "4.1", EntryPoint = "glShaderBinary")]
        public static void ShaderBinary<T3>(int count, [CountAttribute(Parameter = "count")] uint[] shaders, OpenTK.Graphics.OpenGL4.BinaryFormat binaryformat, [InAttribute, OutAttribute, CountAttribute(Parameter = "length")] ref T3 binary, int length)
            where T3 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_ES2_compatibility|VERSION_4_1]
        /// Load pre-compiled shader binaries.
        /// </summary>
        /// <param name="count">
        /// Specifies the number of shader object handles contained in shaders.
        /// </param>
        /// <param name="shaders">
        /// [length: count]
        /// Specifies the address of an array of shader handles into which to load pre-compiled shader binaries.
        /// </param>
        /// <param name="binaryformat">
        /// Specifies the format of the shader binaries contained in binary.
        /// </param>
        /// <param name="binary">
        /// [length: length]
        /// Specifies the address of an array of bytes containing pre-compiled binary shader code.
        /// </param>
        /// <param name="length">
        /// Specifies the length of the array whose address is given in binary.
        /// </param>
        [AutoGenerated(Category = "ARB_ES2_compatibility|VERSION_4_1", Version = "4.1", EntryPoint = "glShaderBinary")]
        public static void ShaderBinary(int count, [CountAttribute(Parameter = "count")] ref uint shaders, OpenTK.Graphics.OpenGL4.BinaryFormat binaryformat, [CountAttribute(Parameter = "length")] IntPtr binary, int length)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_ES2_compatibility|VERSION_4_1]
        /// Load pre-compiled shader binaries.
        /// </summary>
        /// <param name="count">
        /// Specifies the number of shader object handles contained in shaders.
        /// </param>
        /// <param name="shaders">
        /// [length: count]
        /// Specifies the address of an array of shader handles into which to load pre-compiled shader binaries.
        /// </param>
        /// <param name="binaryformat">
        /// Specifies the format of the shader binaries contained in binary.
        /// </param>
        /// <param name="binary">
        /// [length: length]
        /// Specifies the address of an array of bytes containing pre-compiled binary shader code.
        /// </param>
        /// <param name="length">
        /// Specifies the length of the array whose address is given in binary.
        /// </param>
        /// <typeparam name="T3"></typeparam>
        [AutoGenerated(Category = "ARB_ES2_compatibility|VERSION_4_1", Version = "4.1", EntryPoint = "glShaderBinary")]
        public static void ShaderBinary<T3>(int count, [CountAttribute(Parameter = "count")] ref uint shaders, OpenTK.Graphics.OpenGL4.BinaryFormat binaryformat, [InAttribute, OutAttribute, CountAttribute(Parameter = "length")] T3[] binary, int length)
            where T3 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_ES2_compatibility|VERSION_4_1]
        /// Load pre-compiled shader binaries.
        /// </summary>
        /// <param name="count">
        /// Specifies the number of shader object handles contained in shaders.
        /// </param>
        /// <param name="shaders">
        /// [length: count]
        /// Specifies the address of an array of shader handles into which to load pre-compiled shader binaries.
        /// </param>
        /// <param name="binaryformat">
        /// Specifies the format of the shader binaries contained in binary.
        /// </param>
        /// <param name="binary">
        /// [length: length]
        /// Specifies the address of an array of bytes containing pre-compiled binary shader code.
        /// </param>
        /// <param name="length">
        /// Specifies the length of the array whose address is given in binary.
        /// </param>
        /// <typeparam name="T3"></typeparam>
        [AutoGenerated(Category = "ARB_ES2_compatibility|VERSION_4_1", Version = "4.1", EntryPoint = "glShaderBinary")]
        public static void ShaderBinary<T3>(int count, [CountAttribute(Parameter = "count")] ref uint shaders, OpenTK.Graphics.OpenGL4.BinaryFormat binaryformat, [InAttribute, OutAttribute, CountAttribute(Parameter = "length")] T3[,] binary, int length)
            where T3 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_ES2_compatibility|VERSION_4_1]
        /// Load pre-compiled shader binaries.
        /// </summary>
        /// <param name="count">
        /// Specifies the number of shader object handles contained in shaders.
        /// </param>
        /// <param name="shaders">
        /// [length: count]
        /// Specifies the address of an array of shader handles into which to load pre-compiled shader binaries.
        /// </param>
        /// <param name="binaryformat">
        /// Specifies the format of the shader binaries contained in binary.
        /// </param>
        /// <param name="binary">
        /// [length: length]
        /// Specifies the address of an array of bytes containing pre-compiled binary shader code.
        /// </param>
        /// <param name="length">
        /// Specifies the length of the array whose address is given in binary.
        /// </param>
        /// <typeparam name="T3"></typeparam>
        [AutoGenerated(Category = "ARB_ES2_compatibility|VERSION_4_1", Version = "4.1", EntryPoint = "glShaderBinary")]
        public static void ShaderBinary<T3>(int count, [CountAttribute(Parameter = "count")] ref uint shaders, OpenTK.Graphics.OpenGL4.BinaryFormat binaryformat, [InAttribute, OutAttribute, CountAttribute(Parameter = "length")] T3[,,] binary, int length)
            where T3 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_ES2_compatibility|VERSION_4_1]
        /// Load pre-compiled shader binaries.
        /// </summary>
        /// <param name="count">
        /// Specifies the number of shader object handles contained in shaders.
        /// </param>
        /// <param name="shaders">
        /// [length: count]
        /// Specifies the address of an array of shader handles into which to load pre-compiled shader binaries.
        /// </param>
        /// <param name="binaryformat">
        /// Specifies the format of the shader binaries contained in binary.
        /// </param>
        /// <param name="binary">
        /// [length: length]
        /// Specifies the address of an array of bytes containing pre-compiled binary shader code.
        /// </param>
        /// <param name="length">
        /// Specifies the length of the array whose address is given in binary.
        /// </param>
        /// <typeparam name="T3"></typeparam>
        [AutoGenerated(Category = "ARB_ES2_compatibility|VERSION_4_1", Version = "4.1", EntryPoint = "glShaderBinary")]
        public static void ShaderBinary<T3>(int count, [CountAttribute(Parameter = "count")] ref uint shaders, OpenTK.Graphics.OpenGL4.BinaryFormat binaryformat, [InAttribute, OutAttribute, CountAttribute(Parameter = "length")] ref T3 binary, int length)
            where T3 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_ES2_compatibility|VERSION_4_1]
        /// Load pre-compiled shader binaries.
        /// </summary>
        /// <param name="count">
        /// Specifies the number of shader object handles contained in shaders.
        /// </param>
        /// <param name="shaders">
        /// [length: count]
        /// Specifies the address of an array of shader handles into which to load pre-compiled shader binaries.
        /// </param>
        /// <param name="binaryformat">
        /// Specifies the format of the shader binaries contained in binary.
        /// </param>
        /// <param name="binary">
        /// [length: length]
        /// Specifies the address of an array of bytes containing pre-compiled binary shader code.
        /// </param>
        /// <param name="length">
        /// Specifies the length of the array whose address is given in binary.
        /// </param>
        [AutoGenerated(Category = "ARB_ES2_compatibility|VERSION_4_1", Version = "4.1", EntryPoint = "glShaderBinary")]
        public static unsafe void ShaderBinary(int count, [CountAttribute(Parameter = "count")] uint* shaders, OpenTK.Graphics.OpenGL4.BinaryFormat binaryformat, [CountAttribute(Parameter = "length")] IntPtr binary, int length)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_ES2_compatibility|VERSION_4_1]
        /// Load pre-compiled shader binaries.
        /// </summary>
        /// <param name="count">
        /// Specifies the number of shader object handles contained in shaders.
        /// </param>
        /// <param name="shaders">
        /// [length: count]
        /// Specifies the address of an array of shader handles into which to load pre-compiled shader binaries.
        /// </param>
        /// <param name="binaryformat">
        /// Specifies the format of the shader binaries contained in binary.
        /// </param>
        /// <param name="binary">
        /// [length: length]
        /// Specifies the address of an array of bytes containing pre-compiled binary shader code.
        /// </param>
        /// <param name="length">
        /// Specifies the length of the array whose address is given in binary.
        /// </param>
        /// <typeparam name="T3"></typeparam>
        [AutoGenerated(Category = "ARB_ES2_compatibility|VERSION_4_1", Version = "4.1", EntryPoint = "glShaderBinary")]
        public static unsafe void ShaderBinary<T3>(int count, [CountAttribute(Parameter = "count")] uint* shaders, OpenTK.Graphics.OpenGL4.BinaryFormat binaryformat, [InAttribute, OutAttribute, CountAttribute(Parameter = "length")] T3[] binary, int length)
            where T3 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_ES2_compatibility|VERSION_4_1]
        /// Load pre-compiled shader binaries.
        /// </summary>
        /// <param name="count">
        /// Specifies the number of shader object handles contained in shaders.
        /// </param>
        /// <param name="shaders">
        /// [length: count]
        /// Specifies the address of an array of shader handles into which to load pre-compiled shader binaries.
        /// </param>
        /// <param name="binaryformat">
        /// Specifies the format of the shader binaries contained in binary.
        /// </param>
        /// <param name="binary">
        /// [length: length]
        /// Specifies the address of an array of bytes containing pre-compiled binary shader code.
        /// </param>
        /// <param name="length">
        /// Specifies the length of the array whose address is given in binary.
        /// </param>
        /// <typeparam name="T3"></typeparam>
        [AutoGenerated(Category = "ARB_ES2_compatibility|VERSION_4_1", Version = "4.1", EntryPoint = "glShaderBinary")]
        public static unsafe void ShaderBinary<T3>(int count, [CountAttribute(Parameter = "count")] uint* shaders, OpenTK.Graphics.OpenGL4.BinaryFormat binaryformat, [InAttribute, OutAttribute, CountAttribute(Parameter = "length")] T3[,] binary, int length)
            where T3 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_ES2_compatibility|VERSION_4_1]
        /// Load pre-compiled shader binaries.
        /// </summary>
        /// <param name="count">
        /// Specifies the number of shader object handles contained in shaders.
        /// </param>
        /// <param name="shaders">
        /// [length: count]
        /// Specifies the address of an array of shader handles into which to load pre-compiled shader binaries.
        /// </param>
        /// <param name="binaryformat">
        /// Specifies the format of the shader binaries contained in binary.
        /// </param>
        /// <param name="binary">
        /// [length: length]
        /// Specifies the address of an array of bytes containing pre-compiled binary shader code.
        /// </param>
        /// <param name="length">
        /// Specifies the length of the array whose address is given in binary.
        /// </param>
        /// <typeparam name="T3"></typeparam>
        [AutoGenerated(Category = "ARB_ES2_compatibility|VERSION_4_1", Version = "4.1", EntryPoint = "glShaderBinary")]
        public static unsafe void ShaderBinary<T3>(int count, [CountAttribute(Parameter = "count")] uint* shaders, OpenTK.Graphics.OpenGL4.BinaryFormat binaryformat, [InAttribute, OutAttribute, CountAttribute(Parameter = "length")] T3[,,] binary, int length)
            where T3 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_ES2_compatibility|VERSION_4_1]
        /// Load pre-compiled shader binaries.
        /// </summary>
        /// <param name="count">
        /// Specifies the number of shader object handles contained in shaders.
        /// </param>
        /// <param name="shaders">
        /// [length: count]
        /// Specifies the address of an array of shader handles into which to load pre-compiled shader binaries.
        /// </param>
        /// <param name="binaryformat">
        /// Specifies the format of the shader binaries contained in binary.
        /// </param>
        /// <param name="binary">
        /// [length: length]
        /// Specifies the address of an array of bytes containing pre-compiled binary shader code.
        /// </param>
        /// <param name="length">
        /// Specifies the length of the array whose address is given in binary.
        /// </param>
        /// <typeparam name="T3"></typeparam>
        [AutoGenerated(Category = "ARB_ES2_compatibility|VERSION_4_1", Version = "4.1", EntryPoint = "glShaderBinary")]
        public static unsafe void ShaderBinary<T3>(int count, [CountAttribute(Parameter = "count")] uint* shaders, OpenTK.Graphics.OpenGL4.BinaryFormat binaryformat, [InAttribute, OutAttribute, CountAttribute(Parameter = "length")] ref T3 binary, int length)
            where T3 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        #pragma warning disable SA1300 // Element should begin with an upper-case letter

        [Slot(74)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glClearDepthf(float d);

        [Slot(216)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glDepthRangef(float n, float f);

        [Slot(532)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern unsafe void glGetShaderPrecisionFormat(OpenTK.Graphics.OpenGL4.ShaderType shadertype, OpenTK.Graphics.OpenGL4.ShaderPrecision precisiontype, [OutAttribute, CountAttribute(Count = 2)] int* range, [OutAttribute, CountAttribute(Count = 1)] int* precision);

        [Slot(989)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glReleaseShaderCompiler();

        [Slot(1014)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern unsafe void glShaderBinary(int count, [CountAttribute(Parameter = "count")] uint* shaders, OpenTK.Graphics.OpenGL4.BinaryFormat binaryformat, [CountAttribute(Parameter = "length")] IntPtr binary, int length);
    }
}
