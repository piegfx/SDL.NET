namespace SDL.NET
{
    [NativeTypeName("unsigned int")]
    public enum SDL_BlendMode : uint
    {
        SDL_BLENDMODE_NONE = 0x00000000,
        SDL_BLENDMODE_BLEND = 0x00000001,
        SDL_BLENDMODE_ADD = 0x00000002,
        SDL_BLENDMODE_MOD = 0x00000004,
        SDL_BLENDMODE_MUL = 0x00000008,
        SDL_BLENDMODE_INVALID = 0x7FFFFFFF,
    }
}
