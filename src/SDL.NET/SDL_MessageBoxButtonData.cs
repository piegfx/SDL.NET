namespace SDL.NET
{
    public unsafe partial struct SDL_MessageBoxButtonData
    {
        [NativeTypeName("Uint32")]
        public uint flags;

        public int buttonid;

        [NativeTypeName("const char *")]
        public sbyte* text;
    }
}
