namespace SDL.NET
{
    [NativeTypeName("unsigned int")]
    public enum SDL_LogPriority : uint
    {
        SDL_LOG_PRIORITY_VERBOSE = 1,
        SDL_LOG_PRIORITY_DEBUG,
        SDL_LOG_PRIORITY_INFO,
        SDL_LOG_PRIORITY_WARN,
        SDL_LOG_PRIORITY_ERROR,
        SDL_LOG_PRIORITY_CRITICAL,
        SDL_NUM_LOG_PRIORITIES,
    }
}
