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
        /// Contains native bindings to functions in the category "ComputeVariableGroupSize" in the extension "Arb".
        /// </summary>
        public static partial class Arb
        {
            /// <summary>
            /// [requires: ARB_compute_variable_group_size]
            /// </summary>
            /// <param name="num_groups_x">
            /// </param>
            /// <param name="num_groups_y">
            /// </param>
            /// <param name="num_groups_z">
            /// </param>
            /// <param name="group_size_x">
            /// </param>
            /// <param name="group_size_y">
            /// </param>
            /// <param name="group_size_z">
            /// </param>
            [AutoGenerated(Category = "ARB_compute_variable_group_size", Version = "", EntryPoint = "glDispatchComputeGroupSizeARB")]
            public static void DispatchComputeGroupSize(uint num_groups_x, uint num_groups_y, uint num_groups_z, uint group_size_x, uint group_size_y, uint group_size_z)
            {
                throw new BindingsNotRewrittenException();
            }

            #pragma warning disable SA1300 // Element should begin with an upper-case letter

            [Slot(229)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glDispatchComputeGroupSizeARB(uint num_groups_x, uint num_groups_y, uint num_groups_z, uint group_size_x, uint group_size_y, uint group_size_z);
        }
    }
}
