namespace SDL.NET
{
    [NativeTypeName("unsigned int")]
    public enum SDL_ArrayOrder : uint
    {
        SDL_ARRAYORDER_NONE,
        SDL_ARRAYORDER_RGB,
        SDL_ARRAYORDER_RGBA,
        SDL_ARRAYORDER_ARGB,
        SDL_ARRAYORDER_BGR,
        SDL_ARRAYORDER_BGRA,
        SDL_ARRAYORDER_ABGR,
    }
}
