﻿/* Copyright (c) 2017 Rick (rick 'at' gibbed 'dot' us)
 * 
 * This software is provided 'as-is', without any express or implied
 * warranty. In no event will the authors be held liable for any damages
 * arising from the use of this software.
 * 
 * Permission is granted to anyone to use this software for any purpose,
 * including commercial applications, and to alter it and redistribute it
 * freely, subject to the following restrictions:
 * 
 * 1. The origin of this software must not be misrepresented; you must not
 *    claim that you wrote the original software. If you use this software
 *    in a product, an acknowledgment in the product documentation would
 *    be appreciated but is not required.
 * 
 * 2. Altered source versions must be plainly marked as such, and must not
 *    be misrepresented as being the original software.
 * 
 * 3. This notice may not be removed or altered from any source
 *    distribution.
 */

using System;
using System.Runtime.InteropServices;

namespace SKYNET.Interface
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct ISteamUtils005
    {
        public IntPtr GetSecondsSinceAppActive;
        public IntPtr GetSecondsSinceComputerActive;
        public IntPtr GetConnectedUniverse;
        public IntPtr GetServerRealTime;
        public IntPtr GetIPCountry;
        public IntPtr GetImageSize;
        public IntPtr GetImageRGBA;
        public IntPtr GetCSERIPPort;
        public IntPtr GetCurrentBatteryPower;
        public IntPtr GetAppID;
        public IntPtr SetOverlayNotificationPosition;
        public IntPtr IsAPICallCompleted;
        public IntPtr GetAPICallFailureReason;
        public IntPtr GetAPICallResult;
        public IntPtr RunFrame;
        public IntPtr GetIPCCallCount;
        public IntPtr SetWarningMessageHook;
        public IntPtr IsOverlayEnabled;
        public IntPtr OverlayNeedsPresent;
    }
}
