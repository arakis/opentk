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
        /// [requires: v4.3 or ARB_invalidate_subdata|VERSION_4_3]
        /// Invalidate the content of a buffer object's data store.
        /// </summary>
        /// <param name="buffer">
        /// The name of a buffer object whose data store to invalidate.
        /// </param>
        [AutoGenerated(Category = "ARB_invalidate_subdata|VERSION_4_3", Version = "4.3", EntryPoint = "glInvalidateBufferData")]
        public static void InvalidateBufferData(uint buffer)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.3 or ARB_invalidate_subdata|VERSION_4_3]
        /// Invalidate a region of a buffer object's data store.
        /// </summary>
        /// <param name="buffer">
        /// The name of a buffer object, a subrange of whose data store to invalidate.
        /// </param>
        /// <param name="offset">
        /// The offset within the buffer's data store of the start of the range to be invalidated.
        /// </param>
        /// <param name="length">
        /// The length of the range within the buffer's data store to be invalidated.
        /// </param>
        [AutoGenerated(Category = "ARB_invalidate_subdata|VERSION_4_3", Version = "4.3", EntryPoint = "glInvalidateBufferSubData")]
        public static void InvalidateBufferSubData(uint buffer, IntPtr offset, int length)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.3 or ARB_invalidate_subdata|VERSION_4_3]
        /// Invalidate a region of a buffer object's data store.
        /// </summary>
        /// <param name="buffer">
        /// The name of a buffer object, a subrange of whose data store to invalidate.
        /// </param>
        /// <param name="offset">
        /// The offset within the buffer's data store of the start of the range to be invalidated.
        /// </param>
        /// <param name="length">
        /// The length of the range within the buffer's data store to be invalidated.
        /// </param>
        [AutoGenerated(Category = "ARB_invalidate_subdata|VERSION_4_3", Version = "4.3", EntryPoint = "glInvalidateBufferSubData")]
        public static void InvalidateBufferSubData(uint buffer, IntPtr offset, IntPtr length)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.3 or ARB_invalidate_subdata|VERSION_4_3]
        /// Invalidate the content some or all of a framebuffer object's attachments.
        /// </summary>
        /// <param name="target">
        /// The target to which the framebuffer is attached. target must be Framebuffer, DrawFramebuffer, or ReadFramebuffer.
        /// </param>
        /// <param name="numAttachments">
        /// The number of entries in the attachments array.
        /// </param>
        /// <param name="attachments">
        /// [length: numAttachments]
        /// The address of an array identifying the attachments to be invalidated.
        /// </param>
        [AutoGenerated(Category = "ARB_invalidate_subdata|VERSION_4_3", Version = "4.3", EntryPoint = "glInvalidateFramebuffer")]
        public static void InvalidateFramebuffer(OpenTK.Graphics.OpenGL4.FramebufferTarget target, int numAttachments, [CountAttribute(Parameter = "numAttachments")] OpenTK.Graphics.OpenGL4.FramebufferAttachment[] attachments)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.3 or ARB_invalidate_subdata|VERSION_4_3]
        /// Invalidate the content some or all of a framebuffer object's attachments.
        /// </summary>
        /// <param name="target">
        /// The target to which the framebuffer is attached. target must be Framebuffer, DrawFramebuffer, or ReadFramebuffer.
        /// </param>
        /// <param name="numAttachments">
        /// The number of entries in the attachments array.
        /// </param>
        /// <param name="attachments">
        /// [length: numAttachments]
        /// The address of an array identifying the attachments to be invalidated.
        /// </param>
        [AutoGenerated(Category = "ARB_invalidate_subdata|VERSION_4_3", Version = "4.3", EntryPoint = "glInvalidateFramebuffer")]
        public static void InvalidateFramebuffer(OpenTK.Graphics.OpenGL4.FramebufferTarget target, int numAttachments, [CountAttribute(Parameter = "numAttachments")] ref OpenTK.Graphics.OpenGL4.FramebufferAttachment attachments)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.3 or ARB_invalidate_subdata|VERSION_4_3]
        /// Invalidate the content some or all of a framebuffer object's attachments.
        /// </summary>
        /// <param name="target">
        /// The target to which the framebuffer is attached. target must be Framebuffer, DrawFramebuffer, or ReadFramebuffer.
        /// </param>
        /// <param name="numAttachments">
        /// The number of entries in the attachments array.
        /// </param>
        /// <param name="attachments">
        /// [length: numAttachments]
        /// The address of an array identifying the attachments to be invalidated.
        /// </param>
        [AutoGenerated(Category = "ARB_invalidate_subdata|VERSION_4_3", Version = "4.3", EntryPoint = "glInvalidateFramebuffer")]
        public static unsafe void InvalidateFramebuffer(OpenTK.Graphics.OpenGL4.FramebufferTarget target, int numAttachments, [CountAttribute(Parameter = "numAttachments")] OpenTK.Graphics.OpenGL4.FramebufferAttachment* attachments)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.3 or ARB_invalidate_subdata|VERSION_4_3]
        /// Invalidate the content of a region of some or all of a framebuffer object's attachments.
        /// </summary>
        /// <param name="target">
        /// The target to which the framebuffer is attached. target must be Framebuffer, DrawFramebuffer, or ReadFramebuffer.
        /// </param>
        /// <param name="numAttachments">
        /// The number of entries in the attachments array.
        /// </param>
        /// <param name="attachments">
        /// [length: numAttachments]
        /// The address of an array identifying the attachments to be invalidated.
        /// </param>
        /// <param name="x">
        /// The X offset of the region to be invalidated.
        /// </param>
        /// <param name="y">
        /// The Y offset of the region to be invalidated.
        /// </param>
        /// <param name="width">
        /// The width of the region to be invalidated.
        /// </param>
        /// <param name="height">
        /// The height of the region to be invalidated.
        /// </param>
        [AutoGenerated(Category = "ARB_invalidate_subdata|VERSION_4_3", Version = "4.3", EntryPoint = "glInvalidateSubFramebuffer")]
        public static void InvalidateSubFramebuffer(OpenTK.Graphics.OpenGL4.FramebufferTarget target, int numAttachments, [CountAttribute(Parameter = "numAttachments")] OpenTK.Graphics.OpenGL4.FramebufferAttachment[] attachments, int x, int y, int width, int height)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.3 or ARB_invalidate_subdata|VERSION_4_3]
        /// Invalidate the content of a region of some or all of a framebuffer object's attachments.
        /// </summary>
        /// <param name="target">
        /// The target to which the framebuffer is attached. target must be Framebuffer, DrawFramebuffer, or ReadFramebuffer.
        /// </param>
        /// <param name="numAttachments">
        /// The number of entries in the attachments array.
        /// </param>
        /// <param name="attachments">
        /// [length: numAttachments]
        /// The address of an array identifying the attachments to be invalidated.
        /// </param>
        /// <param name="x">
        /// The X offset of the region to be invalidated.
        /// </param>
        /// <param name="y">
        /// The Y offset of the region to be invalidated.
        /// </param>
        /// <param name="width">
        /// The width of the region to be invalidated.
        /// </param>
        /// <param name="height">
        /// The height of the region to be invalidated.
        /// </param>
        [AutoGenerated(Category = "ARB_invalidate_subdata|VERSION_4_3", Version = "4.3", EntryPoint = "glInvalidateSubFramebuffer")]
        public static void InvalidateSubFramebuffer(OpenTK.Graphics.OpenGL4.FramebufferTarget target, int numAttachments, [CountAttribute(Parameter = "numAttachments")] ref OpenTK.Graphics.OpenGL4.FramebufferAttachment attachments, int x, int y, int width, int height)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.3 or ARB_invalidate_subdata|VERSION_4_3]
        /// Invalidate the content of a region of some or all of a framebuffer object's attachments.
        /// </summary>
        /// <param name="target">
        /// The target to which the framebuffer is attached. target must be Framebuffer, DrawFramebuffer, or ReadFramebuffer.
        /// </param>
        /// <param name="numAttachments">
        /// The number of entries in the attachments array.
        /// </param>
        /// <param name="attachments">
        /// [length: numAttachments]
        /// The address of an array identifying the attachments to be invalidated.
        /// </param>
        /// <param name="x">
        /// The X offset of the region to be invalidated.
        /// </param>
        /// <param name="y">
        /// The Y offset of the region to be invalidated.
        /// </param>
        /// <param name="width">
        /// The width of the region to be invalidated.
        /// </param>
        /// <param name="height">
        /// The height of the region to be invalidated.
        /// </param>
        [AutoGenerated(Category = "ARB_invalidate_subdata|VERSION_4_3", Version = "4.3", EntryPoint = "glInvalidateSubFramebuffer")]
        public static unsafe void InvalidateSubFramebuffer(OpenTK.Graphics.OpenGL4.FramebufferTarget target, int numAttachments, [CountAttribute(Parameter = "numAttachments")] OpenTK.Graphics.OpenGL4.FramebufferAttachment* attachments, int x, int y, int width, int height)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.3 or ARB_invalidate_subdata|VERSION_4_3]
        /// Invalidate the entirety a texture image.
        /// </summary>
        /// <param name="texture">
        /// The name of a texture object to invalidate.
        /// </param>
        /// <param name="level">
        /// The level of detail of the texture object to invalidate.
        /// </param>
        [AutoGenerated(Category = "ARB_invalidate_subdata|VERSION_4_3", Version = "4.3", EntryPoint = "glInvalidateTexImage")]
        public static void InvalidateTexImage(uint texture, int level)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.3 or ARB_invalidate_subdata|VERSION_4_3]
        /// Invalidate a region of a texture image.
        /// </summary>
        /// <param name="texture">
        /// The name of a texture object a subregion of which to invalidate.
        /// </param>
        /// <param name="level">
        /// The level of detail of the texture object within which the region resides.
        /// </param>
        /// <param name="xoffset">
        /// The X offset of the region to be invalidated.
        /// </param>
        /// <param name="yoffset">
        /// The Y offset of the region to be invalidated.
        /// </param>
        /// <param name="zoffset">
        /// The Z offset of the region to be invalidated.
        /// </param>
        /// <param name="width">
        /// The width of the region to be invalidated.
        /// </param>
        /// <param name="height">
        /// The height of the region to be invalidated.
        /// </param>
        /// <param name="depth">
        /// The depth of the region to be invalidated.
        /// </param>
        [AutoGenerated(Category = "ARB_invalidate_subdata|VERSION_4_3", Version = "4.3", EntryPoint = "glInvalidateTexSubImage")]
        public static void InvalidateTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth)
        {
            throw new BindingsNotRewrittenException();
        }

        #pragma warning disable SA1300 // Element should begin with an upper-case letter

        [Slot(605)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glInvalidateBufferData(uint buffer);

        [Slot(606)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glInvalidateBufferSubData(uint buffer, IntPtr offset, IntPtr length);

        [Slot(607)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern unsafe void glInvalidateFramebuffer(OpenTK.Graphics.OpenGL4.FramebufferTarget target, int numAttachments, [CountAttribute(Parameter = "numAttachments")] OpenTK.Graphics.OpenGL4.FramebufferAttachment* attachments);

        [Slot(610)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern unsafe void glInvalidateSubFramebuffer(OpenTK.Graphics.OpenGL4.FramebufferTarget target, int numAttachments, [CountAttribute(Parameter = "numAttachments")] OpenTK.Graphics.OpenGL4.FramebufferAttachment* attachments, int x, int y, int width, int height);

        [Slot(611)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glInvalidateTexImage(uint texture, int level);

        [Slot(612)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glInvalidateTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth);
    }
}
