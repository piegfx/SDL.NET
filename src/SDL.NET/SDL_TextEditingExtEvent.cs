namespace SDL.NET
{
    public unsafe partial struct SDL_TextEditingExtEvent
    {
        [NativeTypeName("Uint32")]
        public uint type;

        [NativeTypeName("Uint32")]
        public uint timestamp;

        [NativeTypeName("Uint32")]
        public uint windowID;

        [NativeTypeName("char *")]
        public sbyte* text;

        [NativeTypeName("Sint32")]
        public int start;

        [NativeTypeName("Sint32")]
        public int length;
    }
}
