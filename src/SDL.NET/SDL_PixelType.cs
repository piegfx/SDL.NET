namespace SDL.NET
{
    [NativeTypeName("unsigned int")]
    public enum SDL_PixelType : uint
    {
        SDL_PIXELTYPE_UNKNOWN,
        SDL_PIXELTYPE_INDEX1,
        SDL_PIXELTYPE_INDEX4,
        SDL_PIXELTYPE_INDEX8,
        SDL_PIXELTYPE_PACKED8,
        SDL_PIXELTYPE_PACKED16,
        SDL_PIXELTYPE_PACKED32,
        SDL_PIXELTYPE_ARRAYU8,
        SDL_PIXELTYPE_ARRAYU16,
        SDL_PIXELTYPE_ARRAYU32,
        SDL_PIXELTYPE_ARRAYF16,
        SDL_PIXELTYPE_ARRAYF32,
    }
}
