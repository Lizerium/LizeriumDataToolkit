/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 26 апреля 2026 09:57:02
 * Version: 1.0.2451
 */

using System;
using System.Runtime.InteropServices;

namespace LibreLancer.Dialogs;

enum NFDResult : int
{
    NFD_ERROR,
    NFD_OKAY,
    NFD_CANCEL
}
static unsafe class NFD
{
    [StructLayout(LayoutKind.Sequential)]
    public struct NFDFilterItem
    {
        public void* name;
        public void* spec;
    }

    [DllImport("lancerdialogs", CallingConvention = CallingConvention.Cdecl)]
    public static extern NFDResult NFD_Init();

    [DllImport("lancerdialogs", CallingConvention = CallingConvention.Cdecl)]
    public static extern void NFD_Quit();


    [DllImport("lancerdialogs", CallingConvention = CallingConvention.Cdecl)]
    public static extern NFDResult NFD_OpenDialogN(
        void** outPath,
        NFDFilterItem* filterList,
        uint filterCount,
        void* defaultPath);

    [DllImport("lancerdialogs", CallingConvention = CallingConvention.Cdecl)]
    public static extern NFDResult NFD_SaveDialogN(
        void** outPath,
        NFDFilterItem* filterList,
        uint filterCount,
        void* defaultPath,
        void* defaultName);

    [DllImport("lancerdialogs", CallingConvention = CallingConvention.Cdecl)]
    public static extern NFDResult NFD_PickFolderN(
        void** outPath,
        void* defaultPath);

    [DllImport("lancerdialogs", CallingConvention = CallingConvention.Cdecl)]
    public static extern void NFD_ClearError();

    [DllImport("lancerdialogs", CallingConvention = CallingConvention.Cdecl)]
    public static extern void* NFD_GetError();

    [DllImport("lancerdialogs", CallingConvention =  CallingConvention.Cdecl)]
    public static extern void NFD_FreePathN(void* path);
}
