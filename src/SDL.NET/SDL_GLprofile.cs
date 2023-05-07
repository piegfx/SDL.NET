namespace SDL.NET
{
    [NativeTypeName("unsigned int")]
    public enum SDL_GLprofile : uint
    {
        SDL_GL_CONTEXT_PROFILE_CORE = 0x0001,
        SDL_GL_CONTEXT_PROFILE_COMPATIBILITY = 0x0002,
        SDL_GL_CONTEXT_PROFILE_ES = 0x0004,
    }
}
