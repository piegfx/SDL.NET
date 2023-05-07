namespace SDL.NET
{
    public unsafe partial struct SDL_MessageBoxData
    {
        [NativeTypeName("Uint32")]
        public uint flags;

        public SDL_Window* window;

        [NativeTypeName("const char *")]
        public sbyte* title;

        [NativeTypeName("const char *")]
        public sbyte* message;

        public int numbuttons;

        [NativeTypeName("const SDL_MessageBoxButtonData *")]
        public SDL_MessageBoxButtonData* buttons;

        [NativeTypeName("const SDL_MessageBoxColorScheme *")]
        public SDL_MessageBoxColorScheme* colorScheme;
    }
}
