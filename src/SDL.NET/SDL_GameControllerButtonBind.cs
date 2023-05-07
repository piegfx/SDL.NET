using System.Runtime.InteropServices;

namespace SDL.NET
{
    public partial struct SDL_GameControllerButtonBind
    {
        public SDL_GameControllerBindType bindType;

        [NativeTypeName("union (anonymous union at ../SDL/include/SDL_gamecontroller.h:93:5)")]
        public _value_e__Union value;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _value_e__Union
        {
            [FieldOffset(0)]
            public int button;

            [FieldOffset(0)]
            public int axis;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at ../SDL/include/SDL_gamecontroller.h:97:9)")]
            public _hat_e__Struct hat;

            public partial struct _hat_e__Struct
            {
                public int hat;

                public int hat_mask;
            }
        }
    }
}
