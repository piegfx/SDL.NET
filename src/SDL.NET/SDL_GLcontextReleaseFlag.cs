namespace SDL.NET
{
    [NativeTypeName("unsigned int")]
    public enum SDL_GLcontextReleaseFlag : uint
    {
        SDL_GL_CONTEXT_RELEASE_BEHAVIOR_NONE = 0x0000,
        SDL_GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH = 0x0001,
    }
}
