namespace SDL.NET
{
    public unsafe partial struct SDL_HapticDirection
    {
        [NativeTypeName("Uint8")]
        public byte type;

        [NativeTypeName("Sint32[3]")]
        public fixed int dir[3];
    }
}
