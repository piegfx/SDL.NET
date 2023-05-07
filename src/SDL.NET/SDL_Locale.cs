namespace SDL.NET
{
    public unsafe partial struct SDL_Locale
    {
        [NativeTypeName("const char *")]
        public sbyte* language;

        [NativeTypeName("const char *")]
        public sbyte* country;
    }
}
