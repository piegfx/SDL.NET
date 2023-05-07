namespace SDL.NET
{
    public partial struct SDL_Finger
    {
        [NativeTypeName("SDL_FingerID")]
        public nint id;

        public float x;

        public float y;

        public float pressure;
    }
}
