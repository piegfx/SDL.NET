namespace SDL.NET
{
    [NativeTypeName("unsigned int")]
    public enum SDL_FlashOperation : uint
    {
        SDL_FLASH_CANCEL,
        SDL_FLASH_BRIEFLY,
        SDL_FLASH_UNTIL_FOCUSED,
    }
}
