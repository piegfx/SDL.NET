namespace SDL.NET
{
    [NativeTypeName("unsigned int")]
    public enum SDL_AssertState : uint
    {
        SDL_ASSERTION_RETRY,
        SDL_ASSERTION_BREAK,
        SDL_ASSERTION_ABORT,
        SDL_ASSERTION_IGNORE,
        SDL_ASSERTION_ALWAYS_IGNORE,
    }
}
