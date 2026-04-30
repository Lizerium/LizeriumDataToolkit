/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 апреля 2026 09:20:31
 * Version: 1.0.2455
 */

using System;

namespace LibreLancer;

static class SDLCommon
{
    public static int SDL_GL_GetSwapInterval()
    {
        int interval;
        if (SDL3.Supported)
            SDL3.SDL_GL_GetSwapInterval(out interval);
        else
            interval = SDL2.SDL_GL_GetSwapInterval();
        return interval;
    }
    public static int SDL_GL_SetSwapInterval(int interval)
        => SDL3.Supported
            ? (SDL3.SDL_GL_SetSwapInterval(interval) ? 1 : -1)
            : SDL2.SDL_GL_SetSwapInterval(interval);

    public static void SDL_GL_SwapWindow(IntPtr window)
    {
        if(SDL3.Supported)
            SDL3.SDL_GL_SwapWindow(window);
        else
            SDL2.SDL_GL_SwapWindow(window);
    }
}
