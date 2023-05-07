namespace SDL.NET
{
    [NativeTypeName("unsigned int")]
    public enum SDL_PowerState : uint
    {
        SDL_POWERSTATE_UNKNOWN,
        SDL_POWERSTATE_ON_BATTERY,
        SDL_POWERSTATE_NO_BATTERY,
        SDL_POWERSTATE_CHARGING,
        SDL_POWERSTATE_CHARGED,
    }
}
