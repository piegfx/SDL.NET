namespace SDL.NET
{
    public partial struct SDL_DollarGestureEvent
    {
        [NativeTypeName("Uint32")]
        public uint type;

        [NativeTypeName("Uint32")]
        public uint timestamp;

        [NativeTypeName("SDL_TouchID")]
        public nint touchId;

        [NativeTypeName("SDL_GestureID")]
        public nint gestureId;

        [NativeTypeName("Uint32")]
        public uint numFingers;

        public float error;

        public float x;

        public float y;
    }
}
