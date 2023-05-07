namespace SDL.NET
{
    [NativeTypeName("unsigned int")]
    public enum SDL_GLContextResetNotification : uint
    {
        SDL_GL_CONTEXT_RESET_NO_NOTIFICATION = 0x0000,
        SDL_GL_CONTEXT_RESET_LOSE_CONTEXT = 0x0001,
    }
}
