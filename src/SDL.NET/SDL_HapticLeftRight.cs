namespace SDL.NET
{
    public partial struct SDL_HapticLeftRight
    {
        [NativeTypeName("Uint16")]
        public ushort type;

        [NativeTypeName("Uint32")]
        public uint length;

        [NativeTypeName("Uint16")]
        public ushort large_magnitude;

        [NativeTypeName("Uint16")]
        public ushort small_magnitude;
    }
}
