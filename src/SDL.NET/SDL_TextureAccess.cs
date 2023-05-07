namespace SDL.NET
{
    [NativeTypeName("unsigned int")]
    public enum SDL_TextureAccess : uint
    {
        SDL_TEXTUREACCESS_STATIC,
        SDL_TEXTUREACCESS_STREAMING,
        SDL_TEXTUREACCESS_TARGET,
    }
}
