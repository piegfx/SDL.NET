namespace SDL.NET
{
    [NativeTypeName("unsigned int")]
    public enum SDL_RendererFlip : uint
    {
        SDL_FLIP_NONE = 0x00000000,
        SDL_FLIP_HORIZONTAL = 0x00000001,
        SDL_FLIP_VERTICAL = 0x00000002,
    }
}
