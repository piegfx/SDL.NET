namespace SDL.NET
{
    [NativeTypeName("unsigned int")]
    public enum SDL_ThreadPriority : uint
    {
        SDL_THREAD_PRIORITY_LOW,
        SDL_THREAD_PRIORITY_NORMAL,
        SDL_THREAD_PRIORITY_HIGH,
        SDL_THREAD_PRIORITY_TIME_CRITICAL,
    }
}
