namespace SDL.NET
{
    public partial struct SDL_version
    {
        [NativeTypeName("Uint8")]
        public byte major;

        [NativeTypeName("Uint8")]
        public byte minor;

        [NativeTypeName("Uint8")]
        public byte patch;
    }
}
