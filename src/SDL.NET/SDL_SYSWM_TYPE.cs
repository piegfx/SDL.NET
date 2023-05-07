namespace SDL.NET
{
    [NativeTypeName("unsigned int")]
    public enum SDL_SYSWM_TYPE : uint
    {
        SDL_SYSWM_UNKNOWN,
        SDL_SYSWM_WINDOWS,
        SDL_SYSWM_X11,
        SDL_SYSWM_DIRECTFB,
        SDL_SYSWM_COCOA,
        SDL_SYSWM_UIKIT,
        SDL_SYSWM_WAYLAND,
        SDL_SYSWM_MIR,
        SDL_SYSWM_WINRT,
        SDL_SYSWM_ANDROID,
        SDL_SYSWM_VIVANTE,
        SDL_SYSWM_OS2,
        SDL_SYSWM_HAIKU,
        SDL_SYSWM_KMSDRM,
        SDL_SYSWM_RISCOS,
    }
}
