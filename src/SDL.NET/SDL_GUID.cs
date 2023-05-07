namespace SDL.NET
{
    public unsafe partial struct SDL_GUID
    {
        [NativeTypeName("Uint8[16]")]
        public fixed byte data[16];
    }
}
