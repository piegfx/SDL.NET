namespace SDL.NET
{
    [NativeTypeName("unsigned int")]
    public enum SDL_AudioStatus : uint
    {
        SDL_AUDIO_STOPPED = 0,
        SDL_AUDIO_PLAYING,
        SDL_AUDIO_PAUSED,
    }
}
