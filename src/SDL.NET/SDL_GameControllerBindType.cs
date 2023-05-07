namespace SDL.NET
{
    [NativeTypeName("unsigned int")]
    public enum SDL_GameControllerBindType : uint
    {
        SDL_CONTROLLER_BINDTYPE_NONE = 0,
        SDL_CONTROLLER_BINDTYPE_BUTTON,
        SDL_CONTROLLER_BINDTYPE_AXIS,
        SDL_CONTROLLER_BINDTYPE_HAT,
    }
}
