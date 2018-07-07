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
        /// [requires: v3.2]
        /// Attach a level of a texture object as a logical buffer to the currently bound framebuffer object.
        /// </summary>
        /// <param name="target">
        /// Specifies the framebuffer target. target must be DrawFramebuffer, ReadFramebuffer, or Framebuffer. Framebuffer is equivalent to DrawFramebuffer.
        /// </param>
        /// <param name="attachment">
        /// Specifies the attachment point of the framebuffer. attachment must be ColorAttachmenti, DepthAttachment, StencilAttachment or DepthStencilAttachment.
        /// </param>
        /// <param name="texture">
        /// Specifies the texture object to attach to the framebuffer attachment point named by attachment.
        /// </param>
        /// <param name="level">
        /// Specifies the mipmap level of texture to attach.
        /// </param>
        [AutoGenerated(Category = "VERSION_3_2", Version = "3.2", EntryPoint = "glFramebufferTexture")]
        public static void FramebufferTexture(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, uint texture, int level)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.2]
        /// Return parameters of a buffer object.
        /// </summary>
        /// <param name="target">
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer, AtomicCounterBuffer, CopyReadBuffer, CopyWriteBuffer, DrawIndirectBuffer, DispatchIndirectBuffer, ElementArrayBuffer, PixelPackBuffer, PixelUnpackBuffer, QueryBuffer, ShaderStorageBuffer, TextureBuffer, TransformFeedbackBuffer, or UniformBuffer.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a buffer object parameter. Accepted values are BufferAccess, BufferMapped, BufferSize, or BufferUsage.
        /// </param>
        /// <param name="params">
        /// [length: COMPSIZE(pname)]
        /// Returns the requested parameter.
        /// </param>
        [AutoGenerated(Category = "VERSION_3_2", Version = "3.2", EntryPoint = "glGetBufferParameteri64v")]
        public static void GetBufferParameter(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.BufferParameterName pname, [OutAttribute, CountAttribute(Computed = "pname")] long[] @params)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.2]
        /// Return parameters of a buffer object.
        /// </summary>
        /// <param name="target">
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer, AtomicCounterBuffer, CopyReadBuffer, CopyWriteBuffer, DrawIndirectBuffer, DispatchIndirectBuffer, ElementArrayBuffer, PixelPackBuffer, PixelUnpackBuffer, QueryBuffer, ShaderStorageBuffer, TextureBuffer, TransformFeedbackBuffer, or UniformBuffer.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a buffer object parameter. Accepted values are BufferAccess, BufferMapped, BufferSize, or BufferUsage.
        /// </param>
        /// <param name="params">
        /// [length: COMPSIZE(pname)]
        /// Returns the requested parameter.
        /// </param>
        [AutoGenerated(Category = "VERSION_3_2", Version = "3.2", EntryPoint = "glGetBufferParameteri64v")]
        public static void GetBufferParameter(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.BufferParameterName pname, [OutAttribute, CountAttribute(Computed = "pname")] out long @params)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.2]
        /// Return parameters of a buffer object.
        /// </summary>
        /// <param name="target">
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer, AtomicCounterBuffer, CopyReadBuffer, CopyWriteBuffer, DrawIndirectBuffer, DispatchIndirectBuffer, ElementArrayBuffer, PixelPackBuffer, PixelUnpackBuffer, QueryBuffer, ShaderStorageBuffer, TextureBuffer, TransformFeedbackBuffer, or UniformBuffer.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a buffer object parameter. Accepted values are BufferAccess, BufferMapped, BufferSize, or BufferUsage.
        /// </param>
        /// <param name="params">
        /// [length: COMPSIZE(pname)]
        /// Returns the requested parameter.
        /// </param>
        [AutoGenerated(Category = "VERSION_3_2", Version = "3.2", EntryPoint = "glGetBufferParameteri64v")]
        public static unsafe void GetBufferParameter(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.BufferParameterName pname, [OutAttribute, CountAttribute(Computed = "pname")] long* @params)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.2]
        /// </summary>
        /// <param name="target">
        /// </param>
        /// <param name="index">
        /// </param>
        /// <param name="data">
        /// [length: COMPSIZE(target)]
        /// </param>
        [AutoGenerated(Category = "VERSION_3_2", Version = "3.2", EntryPoint = "glGetInteger64i_v")]
        public static void GetInteger64(OpenTK.Graphics.OpenGL4.GetIndexedPName target, uint index, [OutAttribute, CountAttribute(Computed = "target")] long[] data)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.2]
        /// </summary>
        /// <param name="target">
        /// </param>
        /// <param name="index">
        /// </param>
        /// <param name="data">
        /// [length: COMPSIZE(target)]
        /// </param>
        [AutoGenerated(Category = "VERSION_3_2", Version = "3.2", EntryPoint = "glGetInteger64i_v")]
        public static void GetInteger64(OpenTK.Graphics.OpenGL4.GetIndexedPName target, uint index, [OutAttribute, CountAttribute(Computed = "target")] out long data)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.2]
        /// </summary>
        /// <param name="target">
        /// </param>
        /// <param name="index">
        /// </param>
        /// <param name="data">
        /// [length: COMPSIZE(target)]
        /// </param>
        [AutoGenerated(Category = "VERSION_3_2", Version = "3.2", EntryPoint = "glGetInteger64i_v")]
        public static unsafe void GetInteger64(OpenTK.Graphics.OpenGL4.GetIndexedPName target, uint index, [OutAttribute, CountAttribute(Computed = "target")] long* data)
        {
            throw new BindingsNotRewrittenException();
        }

        #pragma warning disable SA1300 // Element should begin with an upper-case letter

        [Slot(292)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glFramebufferTexture(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, uint texture, int level);

        [Slot(333)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern unsafe void glGetBufferParameteri64v(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.BufferParameterName pname, [OutAttribute, CountAttribute(Computed = "pname")] long* @params);

        [Slot(377)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern unsafe void glGetInteger64i_v(OpenTK.Graphics.OpenGL4.GetIndexedPName target, uint index, [OutAttribute, CountAttribute(Computed = "target")] long* data);
    }
}
