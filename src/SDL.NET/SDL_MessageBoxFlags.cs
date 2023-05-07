namespace SDL.NET
{
    [NativeTypeName("unsigned int")]
    public enum SDL_MessageBoxFlags : uint
    {
        SDL_MESSAGEBOX_ERROR = 0x00000010,
        SDL_MESSAGEBOX_WARNING = 0x00000020,
        SDL_MESSAGEBOX_INFORMATION = 0x00000040,
        SDL_MESSAGEBOX_BUTTONS_LEFT_TO_RIGHT = 0x00000080,
        SDL_MESSAGEBOX_BUTTONS_RIGHT_TO_LEFT = 0x00000100,
    }
}
