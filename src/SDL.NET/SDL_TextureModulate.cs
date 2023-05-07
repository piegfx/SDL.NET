namespace SDL.NET
{
    [NativeTypeName("unsigned int")]
    public enum SDL_TextureModulate : uint
    {
        SDL_TEXTUREMODULATE_NONE = 0x00000000,
        SDL_TEXTUREMODULATE_COLOR = 0x00000001,
        SDL_TEXTUREMODULATE_ALPHA = 0x00000002,
    }
}
