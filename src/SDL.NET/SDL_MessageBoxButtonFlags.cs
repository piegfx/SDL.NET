namespace SDL.NET
{
    [NativeTypeName("unsigned int")]
    public enum SDL_MessageBoxButtonFlags : uint
    {
        SDL_MESSAGEBOX_BUTTON_RETURNKEY_DEFAULT = 0x00000001,
        SDL_MESSAGEBOX_BUTTON_ESCAPEKEY_DEFAULT = 0x00000002,
    }
}
