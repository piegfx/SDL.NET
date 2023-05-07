namespace SDL.NET
{
    [NativeTypeName("unsigned int")]
    public enum SDL_DisplayEventID : uint
    {
        SDL_DISPLAYEVENT_NONE,
        SDL_DISPLAYEVENT_ORIENTATION,
        SDL_DISPLAYEVENT_CONNECTED,
        SDL_DISPLAYEVENT_DISCONNECTED,
    }
}
