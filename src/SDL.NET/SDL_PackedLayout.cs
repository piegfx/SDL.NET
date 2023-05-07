namespace SDL.NET
{
    [NativeTypeName("unsigned int")]
    public enum SDL_PackedLayout : uint
    {
        SDL_PACKEDLAYOUT_NONE,
        SDL_PACKEDLAYOUT_332,
        SDL_PACKEDLAYOUT_4444,
        SDL_PACKEDLAYOUT_1555,
        SDL_PACKEDLAYOUT_5551,
        SDL_PACKEDLAYOUT_565,
        SDL_PACKEDLAYOUT_8888,
        SDL_PACKEDLAYOUT_2101010,
        SDL_PACKEDLAYOUT_1010102,
    }
}
