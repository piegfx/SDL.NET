namespace SDL.NET
{
    [NativeTypeName("unsigned int")]
    public enum SDL_errorcode : uint
    {
        SDL_ENOMEM,
        SDL_EFREAD,
        SDL_EFWRITE,
        SDL_EFSEEK,
        SDL_UNSUPPORTED,
        SDL_LASTERROR,
    }
}
