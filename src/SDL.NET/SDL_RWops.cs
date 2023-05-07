using System.Runtime.InteropServices;

namespace SDL.NET
{
    public unsafe partial struct SDL_RWops
    {
        [NativeTypeName("Sint64 (*)(struct SDL_RWops *)")]
        public delegate* unmanaged[Cdecl]<SDL_RWops*, nint> size;

        [NativeTypeName("Sint64 (*)(struct SDL_RWops *, Sint64, int)")]
        public delegate* unmanaged[Cdecl]<SDL_RWops*, nint, int, nint> seek;

        [NativeTypeName("size_t (*)(struct SDL_RWops *, void *, size_t, size_t)")]
        public delegate* unmanaged[Cdecl]<SDL_RWops*, void*, nuint, nuint, nuint> read;

        [NativeTypeName("size_t (*)(struct SDL_RWops *, const void *, size_t, size_t)")]
        public delegate* unmanaged[Cdecl]<SDL_RWops*, void*, nuint, nuint, nuint> write;

        [NativeTypeName("int (*)(struct SDL_RWops *)")]
        public delegate* unmanaged[Cdecl]<SDL_RWops*, int> close;

        [NativeTypeName("Uint32")]
        public uint type;

        [NativeTypeName("__AnonymousRecord_SDL_rwops_L94_C5")]
        public _hidden_e__Union hidden;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _hidden_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_SDL_rwops_L122_C9")]
            public _mem_e__Struct mem;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_SDL_rwops_L128_C9")]
            public _unknown_e__Struct unknown;

            public unsafe partial struct _mem_e__Struct
            {
                [NativeTypeName("Uint8 *")]
                public byte* @base;

                [NativeTypeName("Uint8 *")]
                public byte* here;

                [NativeTypeName("Uint8 *")]
                public byte* stop;
            }

            public unsafe partial struct _unknown_e__Struct
            {
                public void* data1;

                public void* data2;
            }
        }
    }
}
