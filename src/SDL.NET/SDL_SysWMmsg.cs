using System.Runtime.InteropServices;

namespace SDL.NET
{
    public partial struct SDL_SysWMmsg
    {
    }

    public partial struct SDL_SysWMmsg
    {
        public SDL_version version;

        public SDL_SYSWM_TYPE subsystem;

        [NativeTypeName("union (anonymous union at ../SDL/include/SDL_syswm.h:161:5)")]
        public _msg_e__Union msg;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _msg_e__Union
        {
            [FieldOffset(0)]
            public int dummy;
        }
    }
}
