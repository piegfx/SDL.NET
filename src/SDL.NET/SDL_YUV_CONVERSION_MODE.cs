namespace SDL.NET
{
    [NativeTypeName("unsigned int")]
    public enum SDL_YUV_CONVERSION_MODE : uint
    {
        SDL_YUV_CONVERSION_JPEG,
        SDL_YUV_CONVERSION_BT601,
        SDL_YUV_CONVERSION_BT709,
        SDL_YUV_CONVERSION_AUTOMATIC,
    }
}
