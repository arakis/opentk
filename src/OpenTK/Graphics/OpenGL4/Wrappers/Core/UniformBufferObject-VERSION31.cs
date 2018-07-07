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
        /// [requires: v3.1 or ARB_uniform_buffer_object|VERSION_3_1]
        /// Retrieve the name of an active uniform block.
        /// </summary>
        /// <param name="program">
        /// Specifies the name of a program containing the uniform block.
        /// </param>
        /// <param name="uniformBlockIndex">
        /// Specifies the index of the uniform block within program.
        /// </param>
        /// <param name="bufSize">
        /// Specifies the size of the buffer addressed by uniformBlockName.
        /// </param>
        /// <param name="length">
        /// [length: 1]
        /// Specifies the address of a variable to receive the number of characters that were written to uniformBlockName.
        /// </param>
        /// <param name="uniformBlockName">
        /// [length: bufSize]
        /// Specifies the address an array of characters to receive the name of the uniform block at uniformBlockIndex.
        /// </param>
        [AutoGenerated(Category = "ARB_uniform_buffer_object|VERSION_3_1", Version = "3.1", EntryPoint = "glGetActiveUniformBlockName")]
        public static void GetActiveUniformBlockName(uint program, uint uniformBlockIndex, int bufSize, [OutAttribute, CountAttribute(Count = 1)] out int length, [OutAttribute, CountAttribute(Parameter = "bufSize")] out string uniformBlockName)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.1 or ARB_uniform_buffer_object|VERSION_3_1]
        /// Retrieve the name of an active uniform block.
        /// </summary>
        /// <param name="program">
        /// Specifies the name of a program containing the uniform block.
        /// </param>
        /// <param name="uniformBlockIndex">
        /// Specifies the index of the uniform block within program.
        /// </param>
        /// <param name="bufSize">
        /// Specifies the size of the buffer addressed by uniformBlockName.
        /// </param>
        /// <param name="length">
        /// [length: 1]
        /// Specifies the address of a variable to receive the number of characters that were written to uniformBlockName.
        /// </param>
        /// <param name="uniformBlockName">
        /// [length: bufSize]
        /// Specifies the address an array of characters to receive the name of the uniform block at uniformBlockIndex.
        /// </param>
        [AutoGenerated(Category = "ARB_uniform_buffer_object|VERSION_3_1", Version = "3.1", EntryPoint = "glGetActiveUniformBlockName")]
        public static unsafe void GetActiveUniformBlockName(uint program, uint uniformBlockIndex, int bufSize, [OutAttribute, CountAttribute(Count = 1)] int* length, [OutAttribute, CountAttribute(Parameter = "bufSize")] out string uniformBlockName)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.1 or ARB_uniform_buffer_object|VERSION_3_1]
        /// Query information about an active uniform block.
        /// </summary>
        /// <param name="program">
        /// Specifies the name of a program containing the uniform block.
        /// </param>
        /// <param name="uniformBlockIndex">
        /// Specifies the index of the uniform block within program.
        /// </param>
        /// <param name="pname">
        /// Specifies the name of the parameter to query.
        /// </param>
        /// <param name="params">
        /// [length: COMPSIZE(program,uniformBlockIndex,pname)]
        /// Specifies the address of a variable to receive the result of the query.
        /// </param>
        [AutoGenerated(Category = "ARB_uniform_buffer_object|VERSION_3_1", Version = "3.1", EntryPoint = "glGetActiveUniformBlockiv")]
        public static void GetActiveUniformBlock(uint program, uint uniformBlockIndex, OpenTK.Graphics.OpenGL4.ActiveUniformBlockParameter pname, [OutAttribute, CountAttribute(Computed = "program,uniformBlockIndex,pname")] int[] @params)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.1 or ARB_uniform_buffer_object|VERSION_3_1]
        /// Query information about an active uniform block.
        /// </summary>
        /// <param name="program">
        /// Specifies the name of a program containing the uniform block.
        /// </param>
        /// <param name="uniformBlockIndex">
        /// Specifies the index of the uniform block within program.
        /// </param>
        /// <param name="pname">
        /// Specifies the name of the parameter to query.
        /// </param>
        /// <param name="params">
        /// [length: COMPSIZE(program,uniformBlockIndex,pname)]
        /// Specifies the address of a variable to receive the result of the query.
        /// </param>
        [AutoGenerated(Category = "ARB_uniform_buffer_object|VERSION_3_1", Version = "3.1", EntryPoint = "glGetActiveUniformBlockiv")]
        public static void GetActiveUniformBlock(uint program, uint uniformBlockIndex, OpenTK.Graphics.OpenGL4.ActiveUniformBlockParameter pname, [OutAttribute, CountAttribute(Computed = "program,uniformBlockIndex,pname")] out int @params)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.1 or ARB_uniform_buffer_object|VERSION_3_1]
        /// Query information about an active uniform block.
        /// </summary>
        /// <param name="program">
        /// Specifies the name of a program containing the uniform block.
        /// </param>
        /// <param name="uniformBlockIndex">
        /// Specifies the index of the uniform block within program.
        /// </param>
        /// <param name="pname">
        /// Specifies the name of the parameter to query.
        /// </param>
        /// <param name="params">
        /// [length: COMPSIZE(program,uniformBlockIndex,pname)]
        /// Specifies the address of a variable to receive the result of the query.
        /// </param>
        [AutoGenerated(Category = "ARB_uniform_buffer_object|VERSION_3_1", Version = "3.1", EntryPoint = "glGetActiveUniformBlockiv")]
        public static unsafe void GetActiveUniformBlock(uint program, uint uniformBlockIndex, OpenTK.Graphics.OpenGL4.ActiveUniformBlockParameter pname, [OutAttribute, CountAttribute(Computed = "program,uniformBlockIndex,pname")] int* @params)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.1 or ARB_uniform_buffer_object|VERSION_3_1]
        /// Query the name of an active uniform.
        /// </summary>
        /// <param name="program">
        /// Specifies the program containing the active uniform index uniformIndex.
        /// </param>
        /// <param name="uniformIndex">
        /// Specifies the index of the active uniform whose name to query.
        /// </param>
        /// <param name="bufSize">
        /// Specifies the size of the buffer, in units of GLchar, of the buffer whose address is specified in uniformName.
        /// </param>
        /// <param name="length">
        /// [length: 1]
        /// Specifies the address of a variable that will receive the number of characters that were or would have been written to the buffer addressed by uniformName.
        /// </param>
        /// <param name="uniformName">
        /// [length: bufSize]
        /// Specifies the address of a buffer into which the GL will place the name of the active uniform at uniformIndex within program.
        /// </param>
        [AutoGenerated(Category = "ARB_uniform_buffer_object|VERSION_3_1", Version = "3.1", EntryPoint = "glGetActiveUniformName")]
        public static void GetActiveUniformName(uint program, uint uniformIndex, int bufSize, [OutAttribute, CountAttribute(Count = 1)] out int length, [OutAttribute, CountAttribute(Parameter = "bufSize")] out string uniformName)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.1 or ARB_uniform_buffer_object|VERSION_3_1]
        /// Query the name of an active uniform.
        /// </summary>
        /// <param name="program">
        /// Specifies the program containing the active uniform index uniformIndex.
        /// </param>
        /// <param name="uniformIndex">
        /// Specifies the index of the active uniform whose name to query.
        /// </param>
        /// <param name="bufSize">
        /// Specifies the size of the buffer, in units of GLchar, of the buffer whose address is specified in uniformName.
        /// </param>
        /// <param name="length">
        /// [length: 1]
        /// Specifies the address of a variable that will receive the number of characters that were or would have been written to the buffer addressed by uniformName.
        /// </param>
        /// <param name="uniformName">
        /// [length: bufSize]
        /// Specifies the address of a buffer into which the GL will place the name of the active uniform at uniformIndex within program.
        /// </param>
        [AutoGenerated(Category = "ARB_uniform_buffer_object|VERSION_3_1", Version = "3.1", EntryPoint = "glGetActiveUniformName")]
        public static unsafe void GetActiveUniformName(uint program, uint uniformIndex, int bufSize, [OutAttribute, CountAttribute(Count = 1)] int* length, [OutAttribute, CountAttribute(Parameter = "bufSize")] out string uniformName)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.1 or ARB_uniform_buffer_object|VERSION_3_1]
        /// Returns information about several active uniform variables for the specified program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="uniformCount">
        /// Specifies both the number of elements in the array of indices uniformIndices and the number of parameters written to params upon successful return.
        /// </param>
        /// <param name="uniformIndices">
        /// [length: uniformCount]
        /// Specifies the address of an array of uniformCount integers containing the indices of uniforms within program whose parameter pname should be queried.
        /// </param>
        /// <param name="pname">
        /// Specifies the property of each uniform in uniformIndices that should be written into the corresponding element of params.
        /// </param>
        /// <param name="params">
        /// [length: COMPSIZE(uniformCount,pname)]
        /// Specifies the address of an array of uniformCount integers which are to receive the value of pname for each uniform in uniformIndices.
        /// </param>
        [AutoGenerated(Category = "ARB_uniform_buffer_object|VERSION_3_1", Version = "3.1", EntryPoint = "glGetActiveUniformsiv")]
        public static void GetActiveUniforms(uint program, int uniformCount, [CountAttribute(Parameter = "uniformCount")] uint[] uniformIndices, OpenTK.Graphics.OpenGL4.ActiveUniformParameter pname, [OutAttribute, CountAttribute(Computed = "uniformCount,pname")] int[] @params)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.1 or ARB_uniform_buffer_object|VERSION_3_1]
        /// Returns information about several active uniform variables for the specified program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="uniformCount">
        /// Specifies both the number of elements in the array of indices uniformIndices and the number of parameters written to params upon successful return.
        /// </param>
        /// <param name="uniformIndices">
        /// [length: uniformCount]
        /// Specifies the address of an array of uniformCount integers containing the indices of uniforms within program whose parameter pname should be queried.
        /// </param>
        /// <param name="pname">
        /// Specifies the property of each uniform in uniformIndices that should be written into the corresponding element of params.
        /// </param>
        /// <param name="params">
        /// [length: COMPSIZE(uniformCount,pname)]
        /// Specifies the address of an array of uniformCount integers which are to receive the value of pname for each uniform in uniformIndices.
        /// </param>
        [AutoGenerated(Category = "ARB_uniform_buffer_object|VERSION_3_1", Version = "3.1", EntryPoint = "glGetActiveUniformsiv")]
        public static void GetActiveUniforms(uint program, int uniformCount, [CountAttribute(Parameter = "uniformCount")] ref uint uniformIndices, OpenTK.Graphics.OpenGL4.ActiveUniformParameter pname, [OutAttribute, CountAttribute(Computed = "uniformCount,pname")] out int @params)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.1 or ARB_uniform_buffer_object|VERSION_3_1]
        /// Returns information about several active uniform variables for the specified program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="uniformCount">
        /// Specifies both the number of elements in the array of indices uniformIndices and the number of parameters written to params upon successful return.
        /// </param>
        /// <param name="uniformIndices">
        /// [length: uniformCount]
        /// Specifies the address of an array of uniformCount integers containing the indices of uniforms within program whose parameter pname should be queried.
        /// </param>
        /// <param name="pname">
        /// Specifies the property of each uniform in uniformIndices that should be written into the corresponding element of params.
        /// </param>
        /// <param name="params">
        /// [length: COMPSIZE(uniformCount,pname)]
        /// Specifies the address of an array of uniformCount integers which are to receive the value of pname for each uniform in uniformIndices.
        /// </param>
        [AutoGenerated(Category = "ARB_uniform_buffer_object|VERSION_3_1", Version = "3.1", EntryPoint = "glGetActiveUniformsiv")]
        public static unsafe void GetActiveUniforms(uint program, int uniformCount, [CountAttribute(Parameter = "uniformCount")] uint* uniformIndices, OpenTK.Graphics.OpenGL4.ActiveUniformParameter pname, [OutAttribute, CountAttribute(Computed = "uniformCount,pname")] int* @params)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.1 or ARB_uniform_buffer_object|VERSION_3_1]
        /// Retrieve the index of a named uniform block.
        /// </summary>
        /// <param name="program">
        /// Specifies the name of a program containing the uniform block.
        /// </param>
        /// <param name="uniformBlockName">
        /// [length: COMPSIZE()]
        /// Specifies the address an array of characters to containing the name of the uniform block whose index to retrieve.
        /// </param>
        [AutoGenerated(Category = "ARB_uniform_buffer_object|VERSION_3_1", Version = "3.1", EntryPoint = "glGetUniformBlockIndex")]
        public static uint GetUniformBlockIndex(uint program, [CountAttribute(Computed = "")] string uniformBlockName)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.1 or ARB_uniform_buffer_object|VERSION_3_1]
        /// Retrieve the index of a named uniform block.
        /// </summary>
        /// <param name="program">
        /// Specifies the name of a program containing uniforms whose indices to query.
        /// </param>
        /// <param name="uniformCount">
        /// Specifies the number of uniforms whose indices to query.
        /// </param>
        /// <param name="uniformNames">
        /// [length: COMPSIZE(uniformCount)]
        /// Specifies the address of an array of pointers to buffers containing the names of the queried uniforms.
        /// </param>
        /// <param name="uniformIndices">
        /// [length: COMPSIZE(uniformCount)]
        /// Specifies the address of an array that will receive the indices of the uniforms.
        /// </param>
        [AutoGenerated(Category = "ARB_uniform_buffer_object|VERSION_3_1", Version = "3.1", EntryPoint = "glGetUniformIndices")]
        public static void GetUniformIndices(uint program, int uniformCount, [CountAttribute(Computed = "uniformCount")] string[] uniformNames, [OutAttribute, CountAttribute(Computed = "uniformCount")] uint[] uniformIndices)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.1 or ARB_uniform_buffer_object|VERSION_3_1]
        /// Retrieve the index of a named uniform block.
        /// </summary>
        /// <param name="program">
        /// Specifies the name of a program containing uniforms whose indices to query.
        /// </param>
        /// <param name="uniformCount">
        /// Specifies the number of uniforms whose indices to query.
        /// </param>
        /// <param name="uniformNames">
        /// [length: COMPSIZE(uniformCount)]
        /// Specifies the address of an array of pointers to buffers containing the names of the queried uniforms.
        /// </param>
        /// <param name="uniformIndices">
        /// [length: COMPSIZE(uniformCount)]
        /// Specifies the address of an array that will receive the indices of the uniforms.
        /// </param>
        [AutoGenerated(Category = "ARB_uniform_buffer_object|VERSION_3_1", Version = "3.1", EntryPoint = "glGetUniformIndices")]
        public static void GetUniformIndices(uint program, int uniformCount, [CountAttribute(Computed = "uniformCount")] string[] uniformNames, [OutAttribute, CountAttribute(Computed = "uniformCount")] out uint uniformIndices)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.1 or ARB_uniform_buffer_object|VERSION_3_1]
        /// Retrieve the index of a named uniform block.
        /// </summary>
        /// <param name="program">
        /// Specifies the name of a program containing uniforms whose indices to query.
        /// </param>
        /// <param name="uniformCount">
        /// Specifies the number of uniforms whose indices to query.
        /// </param>
        /// <param name="uniformNames">
        /// [length: COMPSIZE(uniformCount)]
        /// Specifies the address of an array of pointers to buffers containing the names of the queried uniforms.
        /// </param>
        /// <param name="uniformIndices">
        /// [length: COMPSIZE(uniformCount)]
        /// Specifies the address of an array that will receive the indices of the uniforms.
        /// </param>
        [AutoGenerated(Category = "ARB_uniform_buffer_object|VERSION_3_1", Version = "3.1", EntryPoint = "glGetUniformIndices")]
        public static unsafe void GetUniformIndices(uint program, int uniformCount, [CountAttribute(Computed = "uniformCount")] string[] uniformNames, [OutAttribute, CountAttribute(Computed = "uniformCount")] uint* uniformIndices)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.1 or ARB_uniform_buffer_object|VERSION_3_1]
        /// Assign a binding point to an active uniform block.
        /// </summary>
        /// <param name="program">
        /// The name of a program object containing the active uniform block whose binding to assign.
        /// </param>
        /// <param name="uniformBlockIndex">
        /// The index of the active uniform block within program whose binding to assign.
        /// </param>
        /// <param name="uniformBlockBinding">
        /// Specifies the binding point to which to bind the uniform block with index uniformBlockIndex within program.
        /// </param>
        [AutoGenerated(Category = "ARB_uniform_buffer_object|VERSION_3_1", Version = "3.1", EntryPoint = "glUniformBlockBinding")]
        public static void UniformBlockBinding(uint program, uint uniformBlockIndex, uint uniformBlockBinding)
        {
            throw new BindingsNotRewrittenException();
        }

        #pragma warning disable SA1300 // Element should begin with an upper-case letter

        [Slot(325)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern unsafe void glGetActiveUniformBlockName(uint program, uint uniformBlockIndex, int bufSize, [OutAttribute, CountAttribute(Count = 1)] int* length, [OutAttribute, CountAttribute(Parameter = "bufSize")] IntPtr uniformBlockName);

        [Slot(324)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern unsafe void glGetActiveUniformBlockiv(uint program, uint uniformBlockIndex, OpenTK.Graphics.OpenGL4.ActiveUniformBlockParameter pname, [OutAttribute, CountAttribute(Computed = "program,uniformBlockIndex,pname")] int* @params);

        [Slot(326)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern unsafe void glGetActiveUniformName(uint program, uint uniformIndex, int bufSize, [OutAttribute, CountAttribute(Count = 1)] int* length, [OutAttribute, CountAttribute(Parameter = "bufSize")] IntPtr uniformName);

        [Slot(327)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern unsafe void glGetActiveUniformsiv(uint program, int uniformCount, [CountAttribute(Parameter = "uniformCount")] uint* uniformIndices, OpenTK.Graphics.OpenGL4.ActiveUniformParameter pname, [OutAttribute, CountAttribute(Computed = "uniformCount,pname")] int* @params);

        [Slot(570)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern uint glGetUniformBlockIndex(uint program, [CountAttribute(Computed = "")] IntPtr uniformBlockName);

        [Slot(575)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern unsafe void glGetUniformIndices(uint program, int uniformCount, [CountAttribute(Computed = "uniformCount")] IntPtr uniformNames, [OutAttribute, CountAttribute(Computed = "uniformCount")] uint* uniformIndices);

        [Slot(1177)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glUniformBlockBinding(uint program, uint uniformBlockIndex, uint uniformBlockBinding);
    }
}
