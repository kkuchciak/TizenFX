/*
 * Copyright (c) 2018 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class ChromiumEwk
    {
        [DllImport(Libraries.ChromiumEwk, EntryPoint = "ewk_back_forward_list_item_url_get", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, CharSet = CharSet.Ansi)]
        internal static extern IntPtr _ewk_back_forward_list_item_url_get(IntPtr obj);
        internal static string ewk_back_forward_list_item_url_get(IntPtr obj)
        {
            IntPtr ptr = _ewk_back_forward_list_item_url_get(obj);
            return Marshal.PtrToStringAnsi(ptr);
        }

        [DllImport(Libraries.ChromiumEwk, EntryPoint = "ewk_back_forward_list_item_title_get", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, CharSet = CharSet.Ansi)]
        internal static extern IntPtr _ewk_back_forward_list_item_title_get(IntPtr obj);
        internal static string ewk_back_forward_list_item_title_get(IntPtr obj)
        {
            IntPtr ptr = _ewk_back_forward_list_item_title_get(obj);
            return Marshal.PtrToStringAnsi(ptr);
        }

        [DllImport(Libraries.ChromiumEwk, EntryPoint = "ewk_back_forward_list_item_original_url_get", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true, CharSet = CharSet.Ansi)]
        internal static extern IntPtr _ewk_back_forward_list_item_original_url_get(IntPtr obj);
        internal static string ewk_back_forward_list_item_original_url_get(IntPtr obj)
        {
            IntPtr ptr = _ewk_back_forward_list_item_original_url_get(obj);
            return Marshal.PtrToStringAnsi(ptr);
        }

        [DllImport(Libraries.ChromiumEwk)]
        internal static extern IntPtr ewk_back_forward_list_current_item_get(IntPtr backforwardlist);

        [DllImport(Libraries.ChromiumEwk)]
        internal static extern IntPtr ewk_back_forward_list_previous_item_get(IntPtr backforwardlist);

        [DllImport(Libraries.ChromiumEwk)]
        internal static extern uint ewk_back_forward_list_count(IntPtr backforwardlist);

        [DllImport(Libraries.ChromiumEwk)]
        internal static extern IntPtr ewk_back_forward_list_n_back_items_copy(IntPtr backforwardlist, int limit);

        [DllImport(Libraries.ChromiumEwk)]
        internal static extern IntPtr ewk_back_forward_list_n_forward_items_copy(IntPtr backforwardlist, int limit);
    }
}
