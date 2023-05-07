using System.Runtime.InteropServices;

namespace SDL.NET
{
    public partial struct SDL_SysWMinfo
    {
        public SDL_version version;

        public SDL_SYSWM_TYPE subsystem;

        [NativeTypeName("union (anonymous union at ../SDL/include/SDL_syswm.h:230:5)")]
        public _info_e__Union info;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _info_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("Uint8[64]")]
            public fixed byte dummy[64];
        }
    }
}
