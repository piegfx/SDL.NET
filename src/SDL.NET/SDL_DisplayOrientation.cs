namespace SDL.NET
{
    [NativeTypeName("unsigned int")]
    public enum SDL_DisplayOrientation : uint
    {
        SDL_ORIENTATION_UNKNOWN,
        SDL_ORIENTATION_LANDSCAPE,
        SDL_ORIENTATION_LANDSCAPE_FLIPPED,
        SDL_ORIENTATION_PORTRAIT,
        SDL_ORIENTATION_PORTRAIT_FLIPPED,
    }
}
