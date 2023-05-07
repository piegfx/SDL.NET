using System;
using System.Runtime.InteropServices;

namespace SDL.NET
{
    public static unsafe partial class Sdl
    {
        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenURL", ExactSpelling = true)]
        public static extern int OpenURL([NativeTypeName("const char *")] sbyte* url);

        [NativeTypeName("#define SDL_POWER_HARDWIRED 1")]
        public const int SDL_POWER_HARDWIRED = 1;

        [NativeTypeName("#define SDL_FILESYSTEM_XBOX 1")]
        public const int SDL_FILESYSTEM_XBOX = 1;

        [NativeTypeName("#define SDL_DISABLE_WINDOWS_IME 1")]
        public const int SDL_DISABLE_WINDOWS_IME = 1;

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTicks", ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint GetTicks();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTicks64", ExactSpelling = true)]
        [return: NativeTypeName("Uint64")]
        public static extern nuint GetTicks64();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPerformanceCounter", ExactSpelling = true)]
        [return: NativeTypeName("Uint64")]
        public static extern nuint GetPerformanceCounter();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPerformanceFrequency", ExactSpelling = true)]
        [return: NativeTypeName("Uint64")]
        public static extern nuint GetPerformanceFrequency();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_Delay", ExactSpelling = true)]
        public static extern void Delay([NativeTypeName("Uint32")] uint ms);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AddTimer", ExactSpelling = true)]
        [return: NativeTypeName("SDL_TimerID")]
        public static extern int AddTimer([NativeTypeName("Uint32")] uint interval, [NativeTypeName("SDL_TimerCallback")] delegate* unmanaged[Cdecl]<uint, void*, uint> callback, void* param2);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RemoveTimer", ExactSpelling = true)]
        public static extern SDL_bool RemoveTimer([NativeTypeName("SDL_TimerID")] int id);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LinuxSetThreadPriority", ExactSpelling = true)]
        public static extern int LinuxSetThreadPriority([NativeTypeName("Sint64")] nint threadID, int priority);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LinuxSetThreadPriorityAndPolicy", ExactSpelling = true)]
        public static extern int LinuxSetThreadPriorityAndPolicy([NativeTypeName("Sint64")] nint threadID, int sdlPriority, int schedPolicy);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IsTablet", ExactSpelling = true)]
        public static extern SDL_bool IsTablet();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OnApplicationWillTerminate", ExactSpelling = true)]
        public static extern void OnApplicationWillTerminate();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OnApplicationDidReceiveMemoryWarning", ExactSpelling = true)]
        public static extern void OnApplicationDidReceiveMemoryWarning();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OnApplicationWillResignActive", ExactSpelling = true)]
        public static extern void OnApplicationWillResignActive();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OnApplicationDidEnterBackground", ExactSpelling = true)]
        public static extern void OnApplicationDidEnterBackground();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OnApplicationWillEnterForeground", ExactSpelling = true)]
        public static extern void OnApplicationWillEnterForeground();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OnApplicationDidBecomeActive", ExactSpelling = true)]
        public static extern void OnApplicationDidBecomeActive();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_malloc", ExactSpelling = true)]
        public static extern void* malloc([NativeTypeName("size_t")] nuint size);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_calloc", ExactSpelling = true)]
        public static extern void* calloc([NativeTypeName("size_t")] nuint nmemb, [NativeTypeName("size_t")] nuint size);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_realloc", ExactSpelling = true)]
        public static extern void* realloc(void* mem, [NativeTypeName("size_t")] nuint size);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_free", ExactSpelling = true)]
        public static extern void free(void* mem);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetOriginalMemoryFunctions", ExactSpelling = true)]
        public static extern void GetOriginalMemoryFunctions([NativeTypeName("SDL_malloc_func *")] delegate* unmanaged[Cdecl]<nuint, void*>* malloc_func, [NativeTypeName("SDL_calloc_func *")] delegate* unmanaged[Cdecl]<nuint, nuint, void*>* calloc_func, [NativeTypeName("SDL_realloc_func *")] delegate* unmanaged[Cdecl]<void*, nuint, void*>* realloc_func, [NativeTypeName("SDL_free_func *")] delegate* unmanaged[Cdecl]<void*, void>* free_func);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetMemoryFunctions", ExactSpelling = true)]
        public static extern void GetMemoryFunctions([NativeTypeName("SDL_malloc_func *")] delegate* unmanaged[Cdecl]<nuint, void*>* malloc_func, [NativeTypeName("SDL_calloc_func *")] delegate* unmanaged[Cdecl]<nuint, nuint, void*>* calloc_func, [NativeTypeName("SDL_realloc_func *")] delegate* unmanaged[Cdecl]<void*, nuint, void*>* realloc_func, [NativeTypeName("SDL_free_func *")] delegate* unmanaged[Cdecl]<void*, void>* free_func);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetMemoryFunctions", ExactSpelling = true)]
        public static extern int SetMemoryFunctions([NativeTypeName("SDL_malloc_func")] delegate* unmanaged[Cdecl]<nuint, void*> malloc_func, [NativeTypeName("SDL_calloc_func")] delegate* unmanaged[Cdecl]<nuint, nuint, void*> calloc_func, [NativeTypeName("SDL_realloc_func")] delegate* unmanaged[Cdecl]<void*, nuint, void*> realloc_func, [NativeTypeName("SDL_free_func")] delegate* unmanaged[Cdecl]<void*, void> free_func);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumAllocations", ExactSpelling = true)]
        public static extern int GetNumAllocations();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_getenv", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* getenv([NativeTypeName("const char *")] sbyte* name);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_setenv", ExactSpelling = true)]
        public static extern int setenv([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* value, int overwrite);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_qsort", ExactSpelling = true)]
        public static extern void qsort(void* @base, [NativeTypeName("size_t")] nuint nmemb, [NativeTypeName("size_t")] nuint size, [NativeTypeName("int (*)(const void *, const void *)")] delegate* unmanaged[Cdecl]<void*, void*, int> compare);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_bsearch", ExactSpelling = true)]
        public static extern void* bsearch([NativeTypeName("const void *")] void* key, [NativeTypeName("const void *")] void* @base, [NativeTypeName("size_t")] nuint nmemb, [NativeTypeName("size_t")] nuint size, [NativeTypeName("int (*)(const void *, const void *)")] delegate* unmanaged[Cdecl]<void*, void*, int> compare);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_abs", ExactSpelling = true)]
        public static extern int abs(int x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isalpha", ExactSpelling = true)]
        public static extern int isalpha(int x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isalnum", ExactSpelling = true)]
        public static extern int isalnum(int x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isblank", ExactSpelling = true)]
        public static extern int isblank(int x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_iscntrl", ExactSpelling = true)]
        public static extern int iscntrl(int x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isdigit", ExactSpelling = true)]
        public static extern int isdigit(int x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isxdigit", ExactSpelling = true)]
        public static extern int isxdigit(int x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ispunct", ExactSpelling = true)]
        public static extern int ispunct(int x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isspace", ExactSpelling = true)]
        public static extern int isspace(int x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isupper", ExactSpelling = true)]
        public static extern int isupper(int x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_islower", ExactSpelling = true)]
        public static extern int islower(int x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isprint", ExactSpelling = true)]
        public static extern int isprint(int x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isgraph", ExactSpelling = true)]
        public static extern int isgraph(int x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_toupper", ExactSpelling = true)]
        public static extern int toupper(int x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_tolower", ExactSpelling = true)]
        public static extern int tolower(int x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_crc16", ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort crc16([NativeTypeName("Uint16")] ushort crc, [NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] nuint len);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_crc32", ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint crc32([NativeTypeName("Uint32")] uint crc, [NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] nuint len);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_memset", ExactSpelling = true)]
        public static extern void* memset(void* dst, int c, [NativeTypeName("size_t")] nuint len);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_memcpy", ExactSpelling = true)]
        public static extern void* memcpy(void* dst, [NativeTypeName("const void *")] void* src, [NativeTypeName("size_t")] nuint len);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_memmove", ExactSpelling = true)]
        public static extern void* memmove(void* dst, [NativeTypeName("const void *")] void* src, [NativeTypeName("size_t")] nuint len);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_memcmp", ExactSpelling = true)]
        public static extern int memcmp([NativeTypeName("const void *")] void* s1, [NativeTypeName("const void *")] void* s2, [NativeTypeName("size_t")] nuint len);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcslen", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint wcslen([NativeTypeName("const wchar_t *")] uint* wstr);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcslcpy", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint wcslcpy([NativeTypeName("wchar_t *")] uint* dst, [NativeTypeName("const wchar_t *")] uint* src, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcslcat", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint wcslcat([NativeTypeName("wchar_t *")] uint* dst, [NativeTypeName("const wchar_t *")] uint* src, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcsdup", ExactSpelling = true)]
        [return: NativeTypeName("wchar_t *")]
        public static extern uint* wcsdup([NativeTypeName("const wchar_t *")] uint* wstr);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcsstr", ExactSpelling = true)]
        [return: NativeTypeName("wchar_t *")]
        public static extern uint* wcsstr([NativeTypeName("const wchar_t *")] uint* haystack, [NativeTypeName("const wchar_t *")] uint* needle);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcscmp", ExactSpelling = true)]
        public static extern int wcscmp([NativeTypeName("const wchar_t *")] uint* str1, [NativeTypeName("const wchar_t *")] uint* str2);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcsncmp", ExactSpelling = true)]
        public static extern int wcsncmp([NativeTypeName("const wchar_t *")] uint* str1, [NativeTypeName("const wchar_t *")] uint* str2, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcscasecmp", ExactSpelling = true)]
        public static extern int wcscasecmp([NativeTypeName("const wchar_t *")] uint* str1, [NativeTypeName("const wchar_t *")] uint* str2);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcsncasecmp", ExactSpelling = true)]
        public static extern int wcsncasecmp([NativeTypeName("const wchar_t *")] uint* str1, [NativeTypeName("const wchar_t *")] uint* str2, [NativeTypeName("size_t")] nuint len);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strlen", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint strlen([NativeTypeName("const char *")] sbyte* str);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strlcpy", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint strlcpy([NativeTypeName("char *")] sbyte* dst, [NativeTypeName("const char *")] sbyte* src, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_utf8strlcpy", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint utf8strlcpy([NativeTypeName("char *")] sbyte* dst, [NativeTypeName("const char *")] sbyte* src, [NativeTypeName("size_t")] nuint dst_bytes);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strlcat", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint strlcat([NativeTypeName("char *")] sbyte* dst, [NativeTypeName("const char *")] sbyte* src, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strdup", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* strdup([NativeTypeName("const char *")] sbyte* str);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strrev", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* strrev([NativeTypeName("char *")] sbyte* str);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strupr", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* strupr([NativeTypeName("char *")] sbyte* str);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strlwr", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* strlwr([NativeTypeName("char *")] sbyte* str);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strchr", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* strchr([NativeTypeName("const char *")] sbyte* str, int c);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strrchr", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* strrchr([NativeTypeName("const char *")] sbyte* str, int c);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strstr", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* strstr([NativeTypeName("const char *")] sbyte* haystack, [NativeTypeName("const char *")] sbyte* needle);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strcasestr", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* strcasestr([NativeTypeName("const char *")] sbyte* haystack, [NativeTypeName("const char *")] sbyte* needle);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strtokr", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* strtokr([NativeTypeName("char *")] sbyte* s1, [NativeTypeName("const char *")] sbyte* s2, [NativeTypeName("char **")] sbyte** saveptr);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_utf8strlen", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint utf8strlen([NativeTypeName("const char *")] sbyte* str);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_utf8strnlen", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint utf8strnlen([NativeTypeName("const char *")] sbyte* str, [NativeTypeName("size_t")] nuint bytes);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_itoa", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* itoa(int value, [NativeTypeName("char *")] sbyte* str, int radix);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_uitoa", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* uitoa([NativeTypeName("unsigned int")] uint value, [NativeTypeName("char *")] sbyte* str, int radix);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ltoa", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* ltoa([NativeTypeName("long")] nint value, [NativeTypeName("char *")] sbyte* str, int radix);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ultoa", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* ultoa([NativeTypeName("unsigned long")] nuint value, [NativeTypeName("char *")] sbyte* str, int radix);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_lltoa", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* lltoa([NativeTypeName("Sint64")] nint value, [NativeTypeName("char *")] sbyte* str, int radix);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ulltoa", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* ulltoa([NativeTypeName("Uint64")] nuint value, [NativeTypeName("char *")] sbyte* str, int radix);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_atoi", ExactSpelling = true)]
        public static extern int atoi([NativeTypeName("const char *")] sbyte* str);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_atof", ExactSpelling = true)]
        public static extern double atof([NativeTypeName("const char *")] sbyte* str);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strtol", ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern nint strtol([NativeTypeName("const char *")] sbyte* str, [NativeTypeName("char **")] sbyte** endp, int @base);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strtoul", ExactSpelling = true)]
        [return: NativeTypeName("unsigned long")]
        public static extern nuint strtoul([NativeTypeName("const char *")] sbyte* str, [NativeTypeName("char **")] sbyte** endp, int @base);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strtoll", ExactSpelling = true)]
        [return: NativeTypeName("Sint64")]
        public static extern nint strtoll([NativeTypeName("const char *")] sbyte* str, [NativeTypeName("char **")] sbyte** endp, int @base);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strtoull", ExactSpelling = true)]
        [return: NativeTypeName("Uint64")]
        public static extern nuint strtoull([NativeTypeName("const char *")] sbyte* str, [NativeTypeName("char **")] sbyte** endp, int @base);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strtod", ExactSpelling = true)]
        public static extern double strtod([NativeTypeName("const char *")] sbyte* str, [NativeTypeName("char **")] sbyte** endp);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strcmp", ExactSpelling = true)]
        public static extern int strcmp([NativeTypeName("const char *")] sbyte* str1, [NativeTypeName("const char *")] sbyte* str2);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strncmp", ExactSpelling = true)]
        public static extern int strncmp([NativeTypeName("const char *")] sbyte* str1, [NativeTypeName("const char *")] sbyte* str2, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strcasecmp", ExactSpelling = true)]
        public static extern int strcasecmp([NativeTypeName("const char *")] sbyte* str1, [NativeTypeName("const char *")] sbyte* str2);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strncasecmp", ExactSpelling = true)]
        public static extern int strncasecmp([NativeTypeName("const char *")] sbyte* str1, [NativeTypeName("const char *")] sbyte* str2, [NativeTypeName("size_t")] nuint len);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_sscanf", ExactSpelling = true)]
        public static extern int sscanf([NativeTypeName("const char *")] sbyte* text, [NativeTypeName("const char *")] sbyte* fmt, __arglist);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_snprintf", ExactSpelling = true)]
        public static extern int snprintf([NativeTypeName("char *")] sbyte* text, [NativeTypeName("size_t")] nuint maxlen, [NativeTypeName("const char *")] sbyte* fmt, __arglist);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_asprintf", ExactSpelling = true)]
        public static extern int asprintf([NativeTypeName("char **")] sbyte** strp, [NativeTypeName("const char *")] sbyte* fmt, __arglist);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_acos", ExactSpelling = true)]
        public static extern double acos(double x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_acosf", ExactSpelling = true)]
        public static extern float acosf(float x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_asin", ExactSpelling = true)]
        public static extern double asin(double x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_asinf", ExactSpelling = true)]
        public static extern float asinf(float x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_atan", ExactSpelling = true)]
        public static extern double atan(double x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_atanf", ExactSpelling = true)]
        public static extern float atanf(float x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_atan2", ExactSpelling = true)]
        public static extern double atan2(double y, double x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_atan2f", ExactSpelling = true)]
        public static extern float atan2f(float y, float x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ceil", ExactSpelling = true)]
        public static extern double ceil(double x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ceilf", ExactSpelling = true)]
        public static extern float ceilf(float x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_copysign", ExactSpelling = true)]
        public static extern double copysign(double x, double y);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_copysignf", ExactSpelling = true)]
        public static extern float copysignf(float x, float y);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_cos", ExactSpelling = true)]
        public static extern double cos(double x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_cosf", ExactSpelling = true)]
        public static extern float cosf(float x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_exp", ExactSpelling = true)]
        public static extern double exp(double x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_expf", ExactSpelling = true)]
        public static extern float expf(float x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_fabs", ExactSpelling = true)]
        public static extern double fabs(double x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_fabsf", ExactSpelling = true)]
        public static extern float fabsf(float x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_floor", ExactSpelling = true)]
        public static extern double floor(double x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_floorf", ExactSpelling = true)]
        public static extern float floorf(float x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_trunc", ExactSpelling = true)]
        public static extern double trunc(double x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_truncf", ExactSpelling = true)]
        public static extern float truncf(float x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_fmod", ExactSpelling = true)]
        public static extern double fmod(double x, double y);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_fmodf", ExactSpelling = true)]
        public static extern float fmodf(float x, float y);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_log", ExactSpelling = true)]
        public static extern double log(double x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_logf", ExactSpelling = true)]
        public static extern float logf(float x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_log10", ExactSpelling = true)]
        public static extern double log10(double x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_log10f", ExactSpelling = true)]
        public static extern float log10f(float x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_pow", ExactSpelling = true)]
        public static extern double pow(double x, double y);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_powf", ExactSpelling = true)]
        public static extern float powf(float x, float y);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_round", ExactSpelling = true)]
        public static extern double round(double x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_roundf", ExactSpelling = true)]
        public static extern float roundf(float x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_lround", ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern nint lround(double x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_lroundf", ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern nint lroundf(float x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_scalbn", ExactSpelling = true)]
        public static extern double scalbn(double x, int n);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_scalbnf", ExactSpelling = true)]
        public static extern float scalbnf(float x, int n);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_sin", ExactSpelling = true)]
        public static extern double sin(double x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_sinf", ExactSpelling = true)]
        public static extern float sinf(float x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_sqrt", ExactSpelling = true)]
        public static extern double sqrt(double x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_sqrtf", ExactSpelling = true)]
        public static extern float sqrtf(float x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_tan", ExactSpelling = true)]
        public static extern double tan(double x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_tanf", ExactSpelling = true)]
        public static extern float tanf(float x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_iconv_open", ExactSpelling = true)]
        [return: NativeTypeName("SDL_iconv_t")]
        public static extern _SDL_iconv_t* iconv_open([NativeTypeName("const char *")] sbyte* tocode, [NativeTypeName("const char *")] sbyte* fromcode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_iconv_close", ExactSpelling = true)]
        public static extern int iconv_close([NativeTypeName("SDL_iconv_t")] _SDL_iconv_t* cd);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_iconv", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint iconv([NativeTypeName("SDL_iconv_t")] _SDL_iconv_t* cd, [NativeTypeName("const char **")] sbyte** inbuf, [NativeTypeName("size_t *")] nuint* inbytesleft, [NativeTypeName("char **")] sbyte** outbuf, [NativeTypeName("size_t *")] nuint* outbytesleft);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_iconv_string", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* iconv_string([NativeTypeName("const char *")] sbyte* tocode, [NativeTypeName("const char *")] sbyte* fromcode, [NativeTypeName("const char *")] sbyte* inbuf, [NativeTypeName("size_t")] nuint inbytesleft);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte __builtin_mul_overflow(__arglist);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte __builtin_add_overflow(__arglist);

        [NativeTypeName("#define SDL_MAX_SINT8 ((Sint8)0x7F)")]
        public const sbyte SDL_MAX_SINT8 = ((sbyte)(0x7F));

        [NativeTypeName("#define SDL_MIN_SINT8 ((Sint8)(~0x7F))")]
        public const sbyte SDL_MIN_SINT8 = ((sbyte)(~0x7F));

        [NativeTypeName("#define SDL_MAX_UINT8 ((Uint8)0xFF)")]
        public const byte SDL_MAX_UINT8 = ((byte)(0xFF));

        [NativeTypeName("#define SDL_MIN_UINT8 ((Uint8)0x00)")]
        public const byte SDL_MIN_UINT8 = ((byte)(0x00));

        [NativeTypeName("#define SDL_MAX_SINT16 ((Sint16)0x7FFF)")]
        public const short SDL_MAX_SINT16 = ((short)(0x7FFF));

        [NativeTypeName("#define SDL_MIN_SINT16 ((Sint16)(~0x7FFF))")]
        public const short SDL_MIN_SINT16 = ((short)(~0x7FFF));

        [NativeTypeName("#define SDL_MAX_UINT16 ((Uint16)0xFFFF)")]
        public const ushort SDL_MAX_UINT16 = ((ushort)(0xFFFF));

        [NativeTypeName("#define SDL_MIN_UINT16 ((Uint16)0x0000)")]
        public const ushort SDL_MIN_UINT16 = ((ushort)(0x0000));

        [NativeTypeName("#define SDL_MAX_SINT32 ((Sint32)0x7FFFFFFF)")]
        public const int SDL_MAX_SINT32 = ((int)(0x7FFFFFFF));

        [NativeTypeName("#define SDL_MIN_SINT32 ((Sint32)(~0x7FFFFFFF))")]
        public const int SDL_MIN_SINT32 = ((int)(~0x7FFFFFFF));

        [NativeTypeName("#define SDL_MAX_UINT32 ((Uint32)0xFFFFFFFFu)")]
        public const uint SDL_MAX_UINT32 = ((uint)(0xFFFFFFFFU));

        [NativeTypeName("#define SDL_MIN_UINT32 ((Uint32)0x00000000)")]
        public const uint SDL_MIN_UINT32 = ((uint)(0x00000000));

        [NativeTypeName("#define SDL_MIN_UINT64 ((Uint64)(0x0000000000000000ull))")]
        public const nuint SDL_MIN_UINT64 = ((nuint)(0x0000000000000000UL));

        [NativeTypeName("#define SDL_FLT_EPSILON 1.1920928955078125e-07F")]
        public const float SDL_FLT_EPSILON = 1.1920928955078125e-07F;

        [NativeTypeName("#define SDL_PRIs64 \"ld\"")]
        public static ReadOnlySpan<byte> SDL_PRIs64 => new byte[] { 0x6C, 0x64, 0x00 };

        [NativeTypeName("#define SDL_PRIu64 \"lu\"")]
        public static ReadOnlySpan<byte> SDL_PRIu64 => new byte[] { 0x6C, 0x75, 0x00 };

        [NativeTypeName("#define SDL_PRIx64 \"lx\"")]
        public static ReadOnlySpan<byte> SDL_PRIx64 => new byte[] { 0x6C, 0x78, 0x00 };

        [NativeTypeName("#define SDL_PRIX64 \"lX\"")]
        public static ReadOnlySpan<byte> SDL_PRIX64 => new byte[] { 0x6C, 0x58, 0x00 };

        [NativeTypeName("#define SDL_PRIs32 \"d\"")]
        public static ReadOnlySpan<byte> SDL_PRIs32 => new byte[] { 0x64, 0x00 };

        [NativeTypeName("#define SDL_PRIu32 \"u\"")]
        public static ReadOnlySpan<byte> SDL_PRIu32 => new byte[] { 0x75, 0x00 };

        [NativeTypeName("#define SDL_PRIx32 \"x\"")]
        public static ReadOnlySpan<byte> SDL_PRIx32 => new byte[] { 0x78, 0x00 };

        [NativeTypeName("#define SDL_PRIX32 \"X\"")]
        public static ReadOnlySpan<byte> SDL_PRIX32 => new byte[] { 0x58, 0x00 };

        [NativeTypeName("#define M_PI 3.14159265358979323846264338327950288")]
        public const double M_PI = 3.14159265358979323846264338327950288;

        [NativeTypeName("#define SDL_ICONV_ERROR (size_t)-1")]
        public static readonly nuint SDL_ICONV_ERROR = unchecked((nuint)(-1));

        [NativeTypeName("#define SDL_ICONV_E2BIG (size_t)-2")]
        public static readonly nuint SDL_ICONV_E2BIG = unchecked((nuint)(-2));

        [NativeTypeName("#define SDL_ICONV_EILSEQ (size_t)-3")]
        public static readonly nuint SDL_ICONV_EILSEQ = unchecked((nuint)(-3));

        [NativeTypeName("#define SDL_ICONV_EINVAL (size_t)-4")]
        public static readonly nuint SDL_ICONV_EINVAL = unchecked((nuint)(-4));

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LockSensors", ExactSpelling = true)]
        public static extern void LockSensors();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnlockSensors", ExactSpelling = true)]
        public static extern void UnlockSensors();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_NumSensors", ExactSpelling = true)]
        public static extern int NumSensors();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SensorGetDeviceName", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SensorGetDeviceName(int device_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SensorGetDeviceType", ExactSpelling = true)]
        public static extern SDL_SensorType SensorGetDeviceType(int device_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SensorGetDeviceNonPortableType", ExactSpelling = true)]
        public static extern int SensorGetDeviceNonPortableType(int device_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SensorGetDeviceInstanceID", ExactSpelling = true)]
        [return: NativeTypeName("SDL_SensorID")]
        public static extern int SensorGetDeviceInstanceID(int device_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SensorOpen", ExactSpelling = true)]
        [return: NativeTypeName("SDL_Sensor *")]
        public static extern _SDL_Sensor* SensorOpen(int device_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SensorFromInstanceID", ExactSpelling = true)]
        [return: NativeTypeName("SDL_Sensor *")]
        public static extern _SDL_Sensor* SensorFromInstanceID([NativeTypeName("SDL_SensorID")] int instance_id);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SensorGetName", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SensorGetName([NativeTypeName("SDL_Sensor *")] _SDL_Sensor* sensor);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SensorGetType", ExactSpelling = true)]
        public static extern SDL_SensorType SensorGetType([NativeTypeName("SDL_Sensor *")] _SDL_Sensor* sensor);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SensorGetNonPortableType", ExactSpelling = true)]
        public static extern int SensorGetNonPortableType([NativeTypeName("SDL_Sensor *")] _SDL_Sensor* sensor);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SensorGetInstanceID", ExactSpelling = true)]
        [return: NativeTypeName("SDL_SensorID")]
        public static extern int SensorGetInstanceID([NativeTypeName("SDL_Sensor *")] _SDL_Sensor* sensor);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SensorGetData", ExactSpelling = true)]
        public static extern int SensorGetData([NativeTypeName("SDL_Sensor *")] _SDL_Sensor* sensor, float* data, int num_values);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SensorGetDataWithTimestamp", ExactSpelling = true)]
        public static extern int SensorGetDataWithTimestamp([NativeTypeName("SDL_Sensor *")] _SDL_Sensor* sensor, [NativeTypeName("Uint64 *")] nuint* timestamp, float* data, int num_values);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SensorClose", ExactSpelling = true)]
        public static extern void SensorClose([NativeTypeName("SDL_Sensor *")] _SDL_Sensor* sensor);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SensorUpdate", ExactSpelling = true)]
        public static extern void SensorUpdate();

        [NativeTypeName("#define SDL_STANDARD_GRAVITY 9.80665f")]
        public const float SDL_STANDARD_GRAVITY = 9.80665f;

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateMutex", ExactSpelling = true)]
        public static extern SDL_mutex* CreateMutex();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LockMutex", ExactSpelling = true)]
        public static extern int LockMutex(SDL_mutex* mutex);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_TryLockMutex", ExactSpelling = true)]
        public static extern int TryLockMutex(SDL_mutex* mutex);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnlockMutex", ExactSpelling = true)]
        public static extern int UnlockMutex(SDL_mutex* mutex);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyMutex", ExactSpelling = true)]
        public static extern void DestroyMutex(SDL_mutex* mutex);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateSemaphore", ExactSpelling = true)]
        [return: NativeTypeName("SDL_sem *")]
        public static extern SDL_semaphore* CreateSemaphore([NativeTypeName("Uint32")] uint initial_value);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroySemaphore", ExactSpelling = true)]
        public static extern void DestroySemaphore([NativeTypeName("SDL_sem *")] SDL_semaphore* sem);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SemWait", ExactSpelling = true)]
        public static extern int SemWait([NativeTypeName("SDL_sem *")] SDL_semaphore* sem);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SemTryWait", ExactSpelling = true)]
        public static extern int SemTryWait([NativeTypeName("SDL_sem *")] SDL_semaphore* sem);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SemWaitTimeout", ExactSpelling = true)]
        public static extern int SemWaitTimeout([NativeTypeName("SDL_sem *")] SDL_semaphore* sem, [NativeTypeName("Uint32")] uint ms);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SemPost", ExactSpelling = true)]
        public static extern int SemPost([NativeTypeName("SDL_sem *")] SDL_semaphore* sem);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SemValue", ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint SemValue([NativeTypeName("SDL_sem *")] SDL_semaphore* sem);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateCond", ExactSpelling = true)]
        public static extern SDL_cond* CreateCond();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyCond", ExactSpelling = true)]
        public static extern void DestroyCond(SDL_cond* cond);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CondSignal", ExactSpelling = true)]
        public static extern int CondSignal(SDL_cond* cond);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CondBroadcast", ExactSpelling = true)]
        public static extern int CondBroadcast(SDL_cond* cond);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CondWait", ExactSpelling = true)]
        public static extern int CondWait(SDL_cond* cond, SDL_mutex* mutex);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CondWaitTimeout", ExactSpelling = true)]
        public static extern int CondWaitTimeout(SDL_cond* cond, SDL_mutex* mutex, [NativeTypeName("Uint32")] uint ms);

        [NativeTypeName("#define SDL_MUTEX_TIMEDOUT 1")]
        public const int SDL_MUTEX_TIMEDOUT = 1;

        [NativeTypeName("#define SDL_MUTEX_MAXWAIT (~(Uint32)0)")]
        public const uint SDL_MUTEX_MAXWAIT = (~(uint)(0));

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerAddMappingsFromRW", ExactSpelling = true)]
        public static extern int GameControllerAddMappingsFromRW(SDL_RWops* rw, int freerw);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerAddMapping", ExactSpelling = true)]
        public static extern int GameControllerAddMapping([NativeTypeName("const char *")] sbyte* mappingString);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerNumMappings", ExactSpelling = true)]
        public static extern int GameControllerNumMappings();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerMappingForIndex", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* GameControllerMappingForIndex(int mapping_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerMappingForGUID", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* GameControllerMappingForGUID([NativeTypeName("SDL_JoystickGUID")] SDL_GUID guid);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerMapping", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* GameControllerMapping([NativeTypeName("SDL_GameController *")] _SDL_GameController* gamecontroller);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IsGameController", ExactSpelling = true)]
        public static extern SDL_bool IsGameController(int joystick_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerNameForIndex", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* GameControllerNameForIndex(int joystick_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerPathForIndex", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* GameControllerPathForIndex(int joystick_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerTypeForIndex", ExactSpelling = true)]
        public static extern SDL_GameControllerType GameControllerTypeForIndex(int joystick_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerMappingForDeviceIndex", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* GameControllerMappingForDeviceIndex(int joystick_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerOpen", ExactSpelling = true)]
        [return: NativeTypeName("SDL_GameController *")]
        public static extern _SDL_GameController* GameControllerOpen(int joystick_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerFromInstanceID", ExactSpelling = true)]
        [return: NativeTypeName("SDL_GameController *")]
        public static extern _SDL_GameController* GameControllerFromInstanceID([NativeTypeName("SDL_JoystickID")] int joyid);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerFromPlayerIndex", ExactSpelling = true)]
        [return: NativeTypeName("SDL_GameController *")]
        public static extern _SDL_GameController* GameControllerFromPlayerIndex(int player_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerName", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* GameControllerName([NativeTypeName("SDL_GameController *")] _SDL_GameController* gamecontroller);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerPath", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* GameControllerPath([NativeTypeName("SDL_GameController *")] _SDL_GameController* gamecontroller);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerGetType", ExactSpelling = true)]
        public static extern SDL_GameControllerType GameControllerGetType([NativeTypeName("SDL_GameController *")] _SDL_GameController* gamecontroller);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerGetPlayerIndex", ExactSpelling = true)]
        public static extern int GameControllerGetPlayerIndex([NativeTypeName("SDL_GameController *")] _SDL_GameController* gamecontroller);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerSetPlayerIndex", ExactSpelling = true)]
        public static extern void GameControllerSetPlayerIndex([NativeTypeName("SDL_GameController *")] _SDL_GameController* gamecontroller, int player_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerGetVendor", ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort GameControllerGetVendor([NativeTypeName("SDL_GameController *")] _SDL_GameController* gamecontroller);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerGetProduct", ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort GameControllerGetProduct([NativeTypeName("SDL_GameController *")] _SDL_GameController* gamecontroller);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerGetProductVersion", ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort GameControllerGetProductVersion([NativeTypeName("SDL_GameController *")] _SDL_GameController* gamecontroller);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerGetFirmwareVersion", ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort GameControllerGetFirmwareVersion([NativeTypeName("SDL_GameController *")] _SDL_GameController* gamecontroller);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerGetSerial", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* GameControllerGetSerial([NativeTypeName("SDL_GameController *")] _SDL_GameController* gamecontroller);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerGetAttached", ExactSpelling = true)]
        public static extern SDL_bool GameControllerGetAttached([NativeTypeName("SDL_GameController *")] _SDL_GameController* gamecontroller);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerGetJoystick", ExactSpelling = true)]
        [return: NativeTypeName("SDL_Joystick *")]
        public static extern _SDL_Joystick* GameControllerGetJoystick([NativeTypeName("SDL_GameController *")] _SDL_GameController* gamecontroller);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerEventState", ExactSpelling = true)]
        public static extern int GameControllerEventState(int state);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerUpdate", ExactSpelling = true)]
        public static extern void GameControllerUpdate();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerGetAxisFromString", ExactSpelling = true)]
        public static extern SDL_GameControllerAxis GameControllerGetAxisFromString([NativeTypeName("const char *")] sbyte* str);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerGetStringForAxis", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* GameControllerGetStringForAxis(SDL_GameControllerAxis axis);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerGetBindForAxis", ExactSpelling = true)]
        public static extern SDL_GameControllerButtonBind GameControllerGetBindForAxis([NativeTypeName("SDL_GameController *")] _SDL_GameController* gamecontroller, SDL_GameControllerAxis axis);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerHasAxis", ExactSpelling = true)]
        public static extern SDL_bool GameControllerHasAxis([NativeTypeName("SDL_GameController *")] _SDL_GameController* gamecontroller, SDL_GameControllerAxis axis);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerGetAxis", ExactSpelling = true)]
        [return: NativeTypeName("Sint16")]
        public static extern short GameControllerGetAxis([NativeTypeName("SDL_GameController *")] _SDL_GameController* gamecontroller, SDL_GameControllerAxis axis);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerGetButtonFromString", ExactSpelling = true)]
        public static extern SDL_GameControllerButton GameControllerGetButtonFromString([NativeTypeName("const char *")] sbyte* str);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerGetStringForButton", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* GameControllerGetStringForButton(SDL_GameControllerButton button);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerGetBindForButton", ExactSpelling = true)]
        public static extern SDL_GameControllerButtonBind GameControllerGetBindForButton([NativeTypeName("SDL_GameController *")] _SDL_GameController* gamecontroller, SDL_GameControllerButton button);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerHasButton", ExactSpelling = true)]
        public static extern SDL_bool GameControllerHasButton([NativeTypeName("SDL_GameController *")] _SDL_GameController* gamecontroller, SDL_GameControllerButton button);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerGetButton", ExactSpelling = true)]
        [return: NativeTypeName("Uint8")]
        public static extern byte GameControllerGetButton([NativeTypeName("SDL_GameController *")] _SDL_GameController* gamecontroller, SDL_GameControllerButton button);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerGetNumTouchpads", ExactSpelling = true)]
        public static extern int GameControllerGetNumTouchpads([NativeTypeName("SDL_GameController *")] _SDL_GameController* gamecontroller);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerGetNumTouchpadFingers", ExactSpelling = true)]
        public static extern int GameControllerGetNumTouchpadFingers([NativeTypeName("SDL_GameController *")] _SDL_GameController* gamecontroller, int touchpad);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerGetTouchpadFinger", ExactSpelling = true)]
        public static extern int GameControllerGetTouchpadFinger([NativeTypeName("SDL_GameController *")] _SDL_GameController* gamecontroller, int touchpad, int finger, [NativeTypeName("Uint8 *")] byte* state, float* x, float* y, float* pressure);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerHasSensor", ExactSpelling = true)]
        public static extern SDL_bool GameControllerHasSensor([NativeTypeName("SDL_GameController *")] _SDL_GameController* gamecontroller, SDL_SensorType type);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerSetSensorEnabled", ExactSpelling = true)]
        public static extern int GameControllerSetSensorEnabled([NativeTypeName("SDL_GameController *")] _SDL_GameController* gamecontroller, SDL_SensorType type, SDL_bool enabled);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerIsSensorEnabled", ExactSpelling = true)]
        public static extern SDL_bool GameControllerIsSensorEnabled([NativeTypeName("SDL_GameController *")] _SDL_GameController* gamecontroller, SDL_SensorType type);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerGetSensorDataRate", ExactSpelling = true)]
        public static extern float GameControllerGetSensorDataRate([NativeTypeName("SDL_GameController *")] _SDL_GameController* gamecontroller, SDL_SensorType type);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerGetSensorData", ExactSpelling = true)]
        public static extern int GameControllerGetSensorData([NativeTypeName("SDL_GameController *")] _SDL_GameController* gamecontroller, SDL_SensorType type, float* data, int num_values);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerGetSensorDataWithTimestamp", ExactSpelling = true)]
        public static extern int GameControllerGetSensorDataWithTimestamp([NativeTypeName("SDL_GameController *")] _SDL_GameController* gamecontroller, SDL_SensorType type, [NativeTypeName("Uint64 *")] nuint* timestamp, float* data, int num_values);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerRumble", ExactSpelling = true)]
        public static extern int GameControllerRumble([NativeTypeName("SDL_GameController *")] _SDL_GameController* gamecontroller, [NativeTypeName("Uint16")] ushort low_frequency_rumble, [NativeTypeName("Uint16")] ushort high_frequency_rumble, [NativeTypeName("Uint32")] uint duration_ms);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerRumbleTriggers", ExactSpelling = true)]
        public static extern int GameControllerRumbleTriggers([NativeTypeName("SDL_GameController *")] _SDL_GameController* gamecontroller, [NativeTypeName("Uint16")] ushort left_rumble, [NativeTypeName("Uint16")] ushort right_rumble, [NativeTypeName("Uint32")] uint duration_ms);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerHasLED", ExactSpelling = true)]
        public static extern SDL_bool GameControllerHasLED([NativeTypeName("SDL_GameController *")] _SDL_GameController* gamecontroller);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerHasRumble", ExactSpelling = true)]
        public static extern SDL_bool GameControllerHasRumble([NativeTypeName("SDL_GameController *")] _SDL_GameController* gamecontroller);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerHasRumbleTriggers", ExactSpelling = true)]
        public static extern SDL_bool GameControllerHasRumbleTriggers([NativeTypeName("SDL_GameController *")] _SDL_GameController* gamecontroller);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerSetLED", ExactSpelling = true)]
        public static extern int GameControllerSetLED([NativeTypeName("SDL_GameController *")] _SDL_GameController* gamecontroller, [NativeTypeName("Uint8")] byte red, [NativeTypeName("Uint8")] byte green, [NativeTypeName("Uint8")] byte blue);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerSendEffect", ExactSpelling = true)]
        public static extern int GameControllerSendEffect([NativeTypeName("SDL_GameController *")] _SDL_GameController* gamecontroller, [NativeTypeName("const void *")] void* data, int size);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerClose", ExactSpelling = true)]
        public static extern void GameControllerClose([NativeTypeName("SDL_GameController *")] _SDL_GameController* gamecontroller);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerGetAppleSFSymbolsNameForButton", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* GameControllerGetAppleSFSymbolsNameForButton([NativeTypeName("SDL_GameController *")] _SDL_GameController* gamecontroller, SDL_GameControllerButton button);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GameControllerGetAppleSFSymbolsNameForAxis", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* GameControllerGetAppleSFSymbolsNameForAxis([NativeTypeName("SDL_GameController *")] _SDL_GameController* gamecontroller, SDL_GameControllerAxis axis);

        [NativeTypeName("#define KHRONOS_SUPPORT_INT64 1")]
        public const int KHRONOS_SUPPORT_INT64 = 1;

        [NativeTypeName("#define KHRONOS_SUPPORT_FLOAT 1")]
        public const int KHRONOS_SUPPORT_FLOAT = 1;

        [NativeTypeName("#define KHRONOS_MAX_ENUM 0x7FFFFFFF")]
        public const int KHRONOS_MAX_ENUM = 0x7FFFFFFF;

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int __builtin_clz([NativeTypeName("unsigned int")] uint param0);

        [NativeTypeName("#define HAVE_GCC_SYNC_LOCK_TEST_AND_SET 1")]
        public const int HAVE_GCC_SYNC_LOCK_TEST_AND_SET = 1;

        [NativeTypeName("#define SDL_TIMERS_DISABLED 1")]
        public const int SDL_TIMERS_DISABLED = 1;

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCPUCount", ExactSpelling = true)]
        public static extern int GetCPUCount();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCPUCacheLineSize", ExactSpelling = true)]
        public static extern int GetCPUCacheLineSize();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasRDTSC", ExactSpelling = true)]
        public static extern SDL_bool HasRDTSC();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasAltiVec", ExactSpelling = true)]
        public static extern SDL_bool HasAltiVec();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasMMX", ExactSpelling = true)]
        public static extern SDL_bool HasMMX();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_Has3DNow", ExactSpelling = true)]
        public static extern SDL_bool Has3DNow();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasSSE", ExactSpelling = true)]
        public static extern SDL_bool HasSSE();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasSSE2", ExactSpelling = true)]
        public static extern SDL_bool HasSSE2();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasSSE3", ExactSpelling = true)]
        public static extern SDL_bool HasSSE3();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasSSE41", ExactSpelling = true)]
        public static extern SDL_bool HasSSE41();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasSSE42", ExactSpelling = true)]
        public static extern SDL_bool HasSSE42();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasAVX", ExactSpelling = true)]
        public static extern SDL_bool HasAVX();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasAVX2", ExactSpelling = true)]
        public static extern SDL_bool HasAVX2();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasAVX512F", ExactSpelling = true)]
        public static extern SDL_bool HasAVX512F();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasARMSIMD", ExactSpelling = true)]
        public static extern SDL_bool HasARMSIMD();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasNEON", ExactSpelling = true)]
        public static extern SDL_bool HasNEON();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasLSX", ExactSpelling = true)]
        public static extern SDL_bool HasLSX();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasLASX", ExactSpelling = true)]
        public static extern SDL_bool HasLASX();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSystemRAM", ExactSpelling = true)]
        public static extern int GetSystemRAM();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SIMDGetAlignment", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint SIMDGetAlignment();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SIMDAlloc", ExactSpelling = true)]
        public static extern void* SIMDAlloc([NativeTypeName("const size_t")] nuint len);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SIMDRealloc", ExactSpelling = true)]
        public static extern void* SIMDRealloc(void* mem, [NativeTypeName("const size_t")] nuint len);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SIMDFree", ExactSpelling = true)]
        public static extern void SIMDFree(void* ptr);

        [NativeTypeName("#define SDL_CACHELINE_SIZE 128")]
        public const int SDL_CACHELINE_SIZE = 128;

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_NumHaptics", ExactSpelling = true)]
        public static extern int NumHaptics();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HapticName", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* HapticName(int device_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HapticOpen", ExactSpelling = true)]
        [return: NativeTypeName("SDL_Haptic *")]
        public static extern _SDL_Haptic* HapticOpen(int device_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HapticOpened", ExactSpelling = true)]
        public static extern int HapticOpened(int device_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HapticIndex", ExactSpelling = true)]
        public static extern int HapticIndex([NativeTypeName("SDL_Haptic *")] _SDL_Haptic* haptic);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_MouseIsHaptic", ExactSpelling = true)]
        public static extern int MouseIsHaptic();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HapticOpenFromMouse", ExactSpelling = true)]
        [return: NativeTypeName("SDL_Haptic *")]
        public static extern _SDL_Haptic* HapticOpenFromMouse();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickIsHaptic", ExactSpelling = true)]
        public static extern int JoystickIsHaptic([NativeTypeName("SDL_Joystick *")] _SDL_Joystick* joystick);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HapticOpenFromJoystick", ExactSpelling = true)]
        [return: NativeTypeName("SDL_Haptic *")]
        public static extern _SDL_Haptic* HapticOpenFromJoystick([NativeTypeName("SDL_Joystick *")] _SDL_Joystick* joystick);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HapticClose", ExactSpelling = true)]
        public static extern void HapticClose([NativeTypeName("SDL_Haptic *")] _SDL_Haptic* haptic);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HapticNumEffects", ExactSpelling = true)]
        public static extern int HapticNumEffects([NativeTypeName("SDL_Haptic *")] _SDL_Haptic* haptic);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HapticNumEffectsPlaying", ExactSpelling = true)]
        public static extern int HapticNumEffectsPlaying([NativeTypeName("SDL_Haptic *")] _SDL_Haptic* haptic);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HapticQuery", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint HapticQuery([NativeTypeName("SDL_Haptic *")] _SDL_Haptic* haptic);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HapticNumAxes", ExactSpelling = true)]
        public static extern int HapticNumAxes([NativeTypeName("SDL_Haptic *")] _SDL_Haptic* haptic);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HapticEffectSupported", ExactSpelling = true)]
        public static extern int HapticEffectSupported([NativeTypeName("SDL_Haptic *")] _SDL_Haptic* haptic, SDL_HapticEffect* effect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HapticNewEffect", ExactSpelling = true)]
        public static extern int HapticNewEffect([NativeTypeName("SDL_Haptic *")] _SDL_Haptic* haptic, SDL_HapticEffect* effect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HapticUpdateEffect", ExactSpelling = true)]
        public static extern int HapticUpdateEffect([NativeTypeName("SDL_Haptic *")] _SDL_Haptic* haptic, int effect, SDL_HapticEffect* data);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HapticRunEffect", ExactSpelling = true)]
        public static extern int HapticRunEffect([NativeTypeName("SDL_Haptic *")] _SDL_Haptic* haptic, int effect, [NativeTypeName("Uint32")] uint iterations);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HapticStopEffect", ExactSpelling = true)]
        public static extern int HapticStopEffect([NativeTypeName("SDL_Haptic *")] _SDL_Haptic* haptic, int effect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HapticDestroyEffect", ExactSpelling = true)]
        public static extern void HapticDestroyEffect([NativeTypeName("SDL_Haptic *")] _SDL_Haptic* haptic, int effect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HapticGetEffectStatus", ExactSpelling = true)]
        public static extern int HapticGetEffectStatus([NativeTypeName("SDL_Haptic *")] _SDL_Haptic* haptic, int effect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HapticSetGain", ExactSpelling = true)]
        public static extern int HapticSetGain([NativeTypeName("SDL_Haptic *")] _SDL_Haptic* haptic, int gain);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HapticSetAutocenter", ExactSpelling = true)]
        public static extern int HapticSetAutocenter([NativeTypeName("SDL_Haptic *")] _SDL_Haptic* haptic, int autocenter);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HapticPause", ExactSpelling = true)]
        public static extern int HapticPause([NativeTypeName("SDL_Haptic *")] _SDL_Haptic* haptic);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HapticUnpause", ExactSpelling = true)]
        public static extern int HapticUnpause([NativeTypeName("SDL_Haptic *")] _SDL_Haptic* haptic);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HapticStopAll", ExactSpelling = true)]
        public static extern int HapticStopAll([NativeTypeName("SDL_Haptic *")] _SDL_Haptic* haptic);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HapticRumbleSupported", ExactSpelling = true)]
        public static extern int HapticRumbleSupported([NativeTypeName("SDL_Haptic *")] _SDL_Haptic* haptic);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HapticRumbleInit", ExactSpelling = true)]
        public static extern int HapticRumbleInit([NativeTypeName("SDL_Haptic *")] _SDL_Haptic* haptic);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HapticRumblePlay", ExactSpelling = true)]
        public static extern int HapticRumblePlay([NativeTypeName("SDL_Haptic *")] _SDL_Haptic* haptic, float strength, [NativeTypeName("Uint32")] uint length);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HapticRumbleStop", ExactSpelling = true)]
        public static extern int HapticRumbleStop([NativeTypeName("SDL_Haptic *")] _SDL_Haptic* haptic);

        [NativeTypeName("#define SDL_HAPTIC_CONSTANT (1u<<0)")]
        public const uint SDL_HAPTIC_CONSTANT = (1U << 0);

        [NativeTypeName("#define SDL_HAPTIC_SINE (1u<<1)")]
        public const uint SDL_HAPTIC_SINE = (1U << 1);

        [NativeTypeName("#define SDL_HAPTIC_LEFTRIGHT (1u<<2)")]
        public const uint SDL_HAPTIC_LEFTRIGHT = (1U << 2);

        [NativeTypeName("#define SDL_HAPTIC_TRIANGLE (1u<<3)")]
        public const uint SDL_HAPTIC_TRIANGLE = (1U << 3);

        [NativeTypeName("#define SDL_HAPTIC_SAWTOOTHUP (1u<<4)")]
        public const uint SDL_HAPTIC_SAWTOOTHUP = (1U << 4);

        [NativeTypeName("#define SDL_HAPTIC_SAWTOOTHDOWN (1u<<5)")]
        public const uint SDL_HAPTIC_SAWTOOTHDOWN = (1U << 5);

        [NativeTypeName("#define SDL_HAPTIC_RAMP (1u<<6)")]
        public const uint SDL_HAPTIC_RAMP = (1U << 6);

        [NativeTypeName("#define SDL_HAPTIC_SPRING (1u<<7)")]
        public const uint SDL_HAPTIC_SPRING = (1U << 7);

        [NativeTypeName("#define SDL_HAPTIC_DAMPER (1u<<8)")]
        public const uint SDL_HAPTIC_DAMPER = (1U << 8);

        [NativeTypeName("#define SDL_HAPTIC_INERTIA (1u<<9)")]
        public const uint SDL_HAPTIC_INERTIA = (1U << 9);

        [NativeTypeName("#define SDL_HAPTIC_FRICTION (1u<<10)")]
        public const uint SDL_HAPTIC_FRICTION = (1U << 10);

        [NativeTypeName("#define SDL_HAPTIC_CUSTOM (1u<<11)")]
        public const uint SDL_HAPTIC_CUSTOM = (1U << 11);

        [NativeTypeName("#define SDL_HAPTIC_GAIN (1u<<12)")]
        public const uint SDL_HAPTIC_GAIN = (1U << 12);

        [NativeTypeName("#define SDL_HAPTIC_AUTOCENTER (1u<<13)")]
        public const uint SDL_HAPTIC_AUTOCENTER = (1U << 13);

        [NativeTypeName("#define SDL_HAPTIC_STATUS (1u<<14)")]
        public const uint SDL_HAPTIC_STATUS = (1U << 14);

        [NativeTypeName("#define SDL_HAPTIC_PAUSE (1u<<15)")]
        public const uint SDL_HAPTIC_PAUSE = (1U << 15);

        [NativeTypeName("#define SDL_HAPTIC_POLAR 0")]
        public const int SDL_HAPTIC_POLAR = 0;

        [NativeTypeName("#define SDL_HAPTIC_CARTESIAN 1")]
        public const int SDL_HAPTIC_CARTESIAN = 1;

        [NativeTypeName("#define SDL_HAPTIC_SPHERICAL 2")]
        public const int SDL_HAPTIC_SPHERICAL = 2;

        [NativeTypeName("#define SDL_HAPTIC_STEERING_AXIS 3")]
        public const int SDL_HAPTIC_STEERING_AXIS = 3;

        [NativeTypeName("#define SDL_HAPTIC_INFINITY 4294967295U")]
        public const uint SDL_HAPTIC_INFINITY = 4294967295U;

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPreferredLocales", ExactSpelling = true)]
        public static extern SDL_Locale* GetPreferredLocales();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasIntersection", ExactSpelling = true)]
        public static extern SDL_bool HasIntersection([NativeTypeName("const SDL_Rect *")] SDL_Rect* A, [NativeTypeName("const SDL_Rect *")] SDL_Rect* B);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IntersectRect", ExactSpelling = true)]
        public static extern SDL_bool IntersectRect([NativeTypeName("const SDL_Rect *")] SDL_Rect* A, [NativeTypeName("const SDL_Rect *")] SDL_Rect* B, SDL_Rect* result);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnionRect", ExactSpelling = true)]
        public static extern void UnionRect([NativeTypeName("const SDL_Rect *")] SDL_Rect* A, [NativeTypeName("const SDL_Rect *")] SDL_Rect* B, SDL_Rect* result);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EnclosePoints", ExactSpelling = true)]
        public static extern SDL_bool EnclosePoints([NativeTypeName("const SDL_Point *")] SDL_Point* points, int count, [NativeTypeName("const SDL_Rect *")] SDL_Rect* clip, SDL_Rect* result);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IntersectRectAndLine", ExactSpelling = true)]
        public static extern SDL_bool IntersectRectAndLine([NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, int* X1, int* Y1, int* X2, int* Y2);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasIntersectionF", ExactSpelling = true)]
        public static extern SDL_bool HasIntersectionF([NativeTypeName("const SDL_FRect *")] SDL_FRect* A, [NativeTypeName("const SDL_FRect *")] SDL_FRect* B);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IntersectFRect", ExactSpelling = true)]
        public static extern SDL_bool IntersectFRect([NativeTypeName("const SDL_FRect *")] SDL_FRect* A, [NativeTypeName("const SDL_FRect *")] SDL_FRect* B, SDL_FRect* result);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnionFRect", ExactSpelling = true)]
        public static extern void UnionFRect([NativeTypeName("const SDL_FRect *")] SDL_FRect* A, [NativeTypeName("const SDL_FRect *")] SDL_FRect* B, SDL_FRect* result);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EncloseFPoints", ExactSpelling = true)]
        public static extern SDL_bool EncloseFPoints([NativeTypeName("const SDL_FPoint *")] SDL_FPoint* points, int count, [NativeTypeName("const SDL_FRect *")] SDL_FRect* clip, SDL_FRect* result);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IntersectFRectAndLine", ExactSpelling = true)]
        public static extern SDL_bool IntersectFRectAndLine([NativeTypeName("const SDL_FRect *")] SDL_FRect* rect, float* X1, float* Y1, float* X2, float* Y2);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LockJoysticks", ExactSpelling = true)]
        public static extern void LockJoysticks();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnlockJoysticks", ExactSpelling = true)]
        public static extern void UnlockJoysticks();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_NumJoysticks", ExactSpelling = true)]
        public static extern int NumJoysticks();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickNameForIndex", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* JoystickNameForIndex(int device_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickPathForIndex", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* JoystickPathForIndex(int device_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickGetDevicePlayerIndex", ExactSpelling = true)]
        public static extern int JoystickGetDevicePlayerIndex(int device_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickGetDeviceGUID", ExactSpelling = true)]
        [return: NativeTypeName("SDL_JoystickGUID")]
        public static extern SDL_GUID JoystickGetDeviceGUID(int device_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickGetDeviceVendor", ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort JoystickGetDeviceVendor(int device_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickGetDeviceProduct", ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort JoystickGetDeviceProduct(int device_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickGetDeviceProductVersion", ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort JoystickGetDeviceProductVersion(int device_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickGetDeviceType", ExactSpelling = true)]
        public static extern SDL_JoystickType JoystickGetDeviceType(int device_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickGetDeviceInstanceID", ExactSpelling = true)]
        [return: NativeTypeName("SDL_JoystickID")]
        public static extern int JoystickGetDeviceInstanceID(int device_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickOpen", ExactSpelling = true)]
        [return: NativeTypeName("SDL_Joystick *")]
        public static extern _SDL_Joystick* JoystickOpen(int device_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickFromInstanceID", ExactSpelling = true)]
        [return: NativeTypeName("SDL_Joystick *")]
        public static extern _SDL_Joystick* JoystickFromInstanceID([NativeTypeName("SDL_JoystickID")] int instance_id);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickFromPlayerIndex", ExactSpelling = true)]
        [return: NativeTypeName("SDL_Joystick *")]
        public static extern _SDL_Joystick* JoystickFromPlayerIndex(int player_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickAttachVirtual", ExactSpelling = true)]
        public static extern int JoystickAttachVirtual(SDL_JoystickType type, int naxes, int nbuttons, int nhats);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickAttachVirtualEx", ExactSpelling = true)]
        public static extern int JoystickAttachVirtualEx([NativeTypeName("const SDL_VirtualJoystickDesc *")] SDL_VirtualJoystickDesc* desc);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickDetachVirtual", ExactSpelling = true)]
        public static extern int JoystickDetachVirtual(int device_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickIsVirtual", ExactSpelling = true)]
        public static extern SDL_bool JoystickIsVirtual(int device_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickSetVirtualAxis", ExactSpelling = true)]
        public static extern int JoystickSetVirtualAxis([NativeTypeName("SDL_Joystick *")] _SDL_Joystick* joystick, int axis, [NativeTypeName("Sint16")] short value);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickSetVirtualButton", ExactSpelling = true)]
        public static extern int JoystickSetVirtualButton([NativeTypeName("SDL_Joystick *")] _SDL_Joystick* joystick, int button, [NativeTypeName("Uint8")] byte value);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickSetVirtualHat", ExactSpelling = true)]
        public static extern int JoystickSetVirtualHat([NativeTypeName("SDL_Joystick *")] _SDL_Joystick* joystick, int hat, [NativeTypeName("Uint8")] byte value);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickName", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* JoystickName([NativeTypeName("SDL_Joystick *")] _SDL_Joystick* joystick);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickPath", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* JoystickPath([NativeTypeName("SDL_Joystick *")] _SDL_Joystick* joystick);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickGetPlayerIndex", ExactSpelling = true)]
        public static extern int JoystickGetPlayerIndex([NativeTypeName("SDL_Joystick *")] _SDL_Joystick* joystick);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickSetPlayerIndex", ExactSpelling = true)]
        public static extern void JoystickSetPlayerIndex([NativeTypeName("SDL_Joystick *")] _SDL_Joystick* joystick, int player_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickGetGUID", ExactSpelling = true)]
        [return: NativeTypeName("SDL_JoystickGUID")]
        public static extern SDL_GUID JoystickGetGUID([NativeTypeName("SDL_Joystick *")] _SDL_Joystick* joystick);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickGetVendor", ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort JoystickGetVendor([NativeTypeName("SDL_Joystick *")] _SDL_Joystick* joystick);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickGetProduct", ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort JoystickGetProduct([NativeTypeName("SDL_Joystick *")] _SDL_Joystick* joystick);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickGetProductVersion", ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort JoystickGetProductVersion([NativeTypeName("SDL_Joystick *")] _SDL_Joystick* joystick);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickGetFirmwareVersion", ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort JoystickGetFirmwareVersion([NativeTypeName("SDL_Joystick *")] _SDL_Joystick* joystick);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickGetSerial", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* JoystickGetSerial([NativeTypeName("SDL_Joystick *")] _SDL_Joystick* joystick);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickGetType", ExactSpelling = true)]
        public static extern SDL_JoystickType JoystickGetType([NativeTypeName("SDL_Joystick *")] _SDL_Joystick* joystick);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickGetGUIDString", ExactSpelling = true)]
        public static extern void JoystickGetGUIDString([NativeTypeName("SDL_JoystickGUID")] SDL_GUID guid, [NativeTypeName("char *")] sbyte* pszGUID, int cbGUID);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickGetGUIDFromString", ExactSpelling = true)]
        [return: NativeTypeName("SDL_JoystickGUID")]
        public static extern SDL_GUID JoystickGetGUIDFromString([NativeTypeName("const char *")] sbyte* pchGUID);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickGUIDInfo", ExactSpelling = true)]
        public static extern void GetJoystickGUIDInfo([NativeTypeName("SDL_JoystickGUID")] SDL_GUID guid, [NativeTypeName("Uint16 *")] ushort* vendor, [NativeTypeName("Uint16 *")] ushort* product, [NativeTypeName("Uint16 *")] ushort* version, [NativeTypeName("Uint16 *")] ushort* crc16);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickGetAttached", ExactSpelling = true)]
        public static extern SDL_bool JoystickGetAttached([NativeTypeName("SDL_Joystick *")] _SDL_Joystick* joystick);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickInstanceID", ExactSpelling = true)]
        [return: NativeTypeName("SDL_JoystickID")]
        public static extern int JoystickInstanceID([NativeTypeName("SDL_Joystick *")] _SDL_Joystick* joystick);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickNumAxes", ExactSpelling = true)]
        public static extern int JoystickNumAxes([NativeTypeName("SDL_Joystick *")] _SDL_Joystick* joystick);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickNumBalls", ExactSpelling = true)]
        public static extern int JoystickNumBalls([NativeTypeName("SDL_Joystick *")] _SDL_Joystick* joystick);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickNumHats", ExactSpelling = true)]
        public static extern int JoystickNumHats([NativeTypeName("SDL_Joystick *")] _SDL_Joystick* joystick);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickNumButtons", ExactSpelling = true)]
        public static extern int JoystickNumButtons([NativeTypeName("SDL_Joystick *")] _SDL_Joystick* joystick);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickUpdate", ExactSpelling = true)]
        public static extern void JoystickUpdate();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickEventState", ExactSpelling = true)]
        public static extern int JoystickEventState(int state);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickGetAxis", ExactSpelling = true)]
        [return: NativeTypeName("Sint16")]
        public static extern short JoystickGetAxis([NativeTypeName("SDL_Joystick *")] _SDL_Joystick* joystick, int axis);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickGetAxisInitialState", ExactSpelling = true)]
        public static extern SDL_bool JoystickGetAxisInitialState([NativeTypeName("SDL_Joystick *")] _SDL_Joystick* joystick, int axis, [NativeTypeName("Sint16 *")] short* state);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickGetHat", ExactSpelling = true)]
        [return: NativeTypeName("Uint8")]
        public static extern byte JoystickGetHat([NativeTypeName("SDL_Joystick *")] _SDL_Joystick* joystick, int hat);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickGetBall", ExactSpelling = true)]
        public static extern int JoystickGetBall([NativeTypeName("SDL_Joystick *")] _SDL_Joystick* joystick, int ball, int* dx, int* dy);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickGetButton", ExactSpelling = true)]
        [return: NativeTypeName("Uint8")]
        public static extern byte JoystickGetButton([NativeTypeName("SDL_Joystick *")] _SDL_Joystick* joystick, int button);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickRumble", ExactSpelling = true)]
        public static extern int JoystickRumble([NativeTypeName("SDL_Joystick *")] _SDL_Joystick* joystick, [NativeTypeName("Uint16")] ushort low_frequency_rumble, [NativeTypeName("Uint16")] ushort high_frequency_rumble, [NativeTypeName("Uint32")] uint duration_ms);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickRumbleTriggers", ExactSpelling = true)]
        public static extern int JoystickRumbleTriggers([NativeTypeName("SDL_Joystick *")] _SDL_Joystick* joystick, [NativeTypeName("Uint16")] ushort left_rumble, [NativeTypeName("Uint16")] ushort right_rumble, [NativeTypeName("Uint32")] uint duration_ms);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickHasLED", ExactSpelling = true)]
        public static extern SDL_bool JoystickHasLED([NativeTypeName("SDL_Joystick *")] _SDL_Joystick* joystick);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickHasRumble", ExactSpelling = true)]
        public static extern SDL_bool JoystickHasRumble([NativeTypeName("SDL_Joystick *")] _SDL_Joystick* joystick);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickHasRumbleTriggers", ExactSpelling = true)]
        public static extern SDL_bool JoystickHasRumbleTriggers([NativeTypeName("SDL_Joystick *")] _SDL_Joystick* joystick);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickSetLED", ExactSpelling = true)]
        public static extern int JoystickSetLED([NativeTypeName("SDL_Joystick *")] _SDL_Joystick* joystick, [NativeTypeName("Uint8")] byte red, [NativeTypeName("Uint8")] byte green, [NativeTypeName("Uint8")] byte blue);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickSendEffect", ExactSpelling = true)]
        public static extern int JoystickSendEffect([NativeTypeName("SDL_Joystick *")] _SDL_Joystick* joystick, [NativeTypeName("const void *")] void* data, int size);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickClose", ExactSpelling = true)]
        public static extern void JoystickClose([NativeTypeName("SDL_Joystick *")] _SDL_Joystick* joystick);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickCurrentPowerLevel", ExactSpelling = true)]
        public static extern SDL_JoystickPowerLevel JoystickCurrentPowerLevel([NativeTypeName("SDL_Joystick *")] _SDL_Joystick* joystick);

        [NativeTypeName("#define SDL_IPHONE_MAX_GFORCE 5.0")]
        public const double SDL_IPHONE_MAX_GFORCE = 5.0;

        [NativeTypeName("#define SDL_VIRTUAL_JOYSTICK_DESC_VERSION 1")]
        public const int SDL_VIRTUAL_JOYSTICK_DESC_VERSION = 1;

        [NativeTypeName("#define SDL_JOYSTICK_AXIS_MAX 32767")]
        public const int SDL_JOYSTICK_AXIS_MAX = 32767;

        [NativeTypeName("#define SDL_JOYSTICK_AXIS_MIN -32768")]
        public const int SDL_JOYSTICK_AXIS_MIN = -32768;

        [NativeTypeName("#define SDL_HAT_CENTERED 0x00")]
        public const int SDL_HAT_CENTERED = 0x00;

        [NativeTypeName("#define SDL_HAT_UP 0x01")]
        public const int SDL_HAT_UP = 0x01;

        [NativeTypeName("#define SDL_HAT_RIGHT 0x02")]
        public const int SDL_HAT_RIGHT = 0x02;

        [NativeTypeName("#define SDL_HAT_DOWN 0x04")]
        public const int SDL_HAT_DOWN = 0x04;

        [NativeTypeName("#define SDL_HAT_LEFT 0x08")]
        public const int SDL_HAT_LEFT = 0x08;

        [NativeTypeName("#define SDL_HAT_RIGHTUP (SDL_HAT_RIGHT|SDL_HAT_UP)")]
        public const int SDL_HAT_RIGHTUP = (0x02 | 0x01);

        [NativeTypeName("#define SDL_HAT_RIGHTDOWN (SDL_HAT_RIGHT|SDL_HAT_DOWN)")]
        public const int SDL_HAT_RIGHTDOWN = (0x02 | 0x04);

        [NativeTypeName("#define SDL_HAT_LEFTUP (SDL_HAT_LEFT|SDL_HAT_UP)")]
        public const int SDL_HAT_LEFTUP = (0x08 | 0x01);

        [NativeTypeName("#define SDL_HAT_LEFTDOWN (SDL_HAT_LEFT|SDL_HAT_DOWN)")]
        public const int SDL_HAT_LEFTDOWN = (0x08 | 0x04);

        [NativeTypeName("#define SDL_AUDIO_DRIVER_ANDROID 1")]
        public const int SDL_AUDIO_DRIVER_ANDROID = 1;

        [NativeTypeName("#define SDL_AUDIO_DRIVER_OPENSLES 1")]
        public const int SDL_AUDIO_DRIVER_OPENSLES = 1;

        [NativeTypeName("#define SDL_AUDIO_DRIVER_AAUDIO 1")]
        public const int SDL_AUDIO_DRIVER_AAUDIO = 1;

        [NativeTypeName("#define SDL_JOYSTICK_ANDROID 1")]
        public const int SDL_JOYSTICK_ANDROID = 1;

        [NativeTypeName("#define SDL_HAPTIC_ANDROID 1")]
        public const int SDL_HAPTIC_ANDROID = 1;

        [NativeTypeName("#define SDL_SENSOR_ANDROID 1")]
        public const int SDL_SENSOR_ANDROID = 1;

        [NativeTypeName("#define SDL_VIDEO_DRIVER_ANDROID 1")]
        public const int SDL_VIDEO_DRIVER_ANDROID = 1;

        [NativeTypeName("#define SDL_POWER_ANDROID 1")]
        public const int SDL_POWER_ANDROID = 1;

        [NativeTypeName("#define SDL_FILESYSTEM_ANDROID 1")]
        public const int SDL_FILESYSTEM_ANDROID = 1;

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateRGBSurface", ExactSpelling = true)]
        public static extern SDL_Surface* CreateRGBSurface([NativeTypeName("Uint32")] uint flags, int width, int height, int depth, [NativeTypeName("Uint32")] uint Rmask, [NativeTypeName("Uint32")] uint Gmask, [NativeTypeName("Uint32")] uint Bmask, [NativeTypeName("Uint32")] uint Amask);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateRGBSurfaceWithFormat", ExactSpelling = true)]
        public static extern SDL_Surface* CreateRGBSurfaceWithFormat([NativeTypeName("Uint32")] uint flags, int width, int height, int depth, [NativeTypeName("Uint32")] uint format);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateRGBSurfaceFrom", ExactSpelling = true)]
        public static extern SDL_Surface* CreateRGBSurfaceFrom(void* pixels, int width, int height, int depth, int pitch, [NativeTypeName("Uint32")] uint Rmask, [NativeTypeName("Uint32")] uint Gmask, [NativeTypeName("Uint32")] uint Bmask, [NativeTypeName("Uint32")] uint Amask);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateRGBSurfaceWithFormatFrom", ExactSpelling = true)]
        public static extern SDL_Surface* CreateRGBSurfaceWithFormatFrom(void* pixels, int width, int height, int depth, int pitch, [NativeTypeName("Uint32")] uint format);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FreeSurface", ExactSpelling = true)]
        public static extern void FreeSurface(SDL_Surface* surface);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetSurfacePalette", ExactSpelling = true)]
        public static extern int SetSurfacePalette(SDL_Surface* surface, SDL_Palette* palette);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LockSurface", ExactSpelling = true)]
        public static extern int LockSurface(SDL_Surface* surface);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnlockSurface", ExactSpelling = true)]
        public static extern void UnlockSurface(SDL_Surface* surface);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LoadBMP_RW", ExactSpelling = true)]
        public static extern SDL_Surface* LoadBMP_RW(SDL_RWops* src, int freesrc);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SaveBMP_RW", ExactSpelling = true)]
        public static extern int SaveBMP_RW(SDL_Surface* surface, SDL_RWops* dst, int freedst);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetSurfaceRLE", ExactSpelling = true)]
        public static extern int SetSurfaceRLE(SDL_Surface* surface, int flag);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasSurfaceRLE", ExactSpelling = true)]
        public static extern SDL_bool HasSurfaceRLE(SDL_Surface* surface);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetColorKey", ExactSpelling = true)]
        public static extern int SetColorKey(SDL_Surface* surface, int flag, [NativeTypeName("Uint32")] uint key);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasColorKey", ExactSpelling = true)]
        public static extern SDL_bool HasColorKey(SDL_Surface* surface);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetColorKey", ExactSpelling = true)]
        public static extern int GetColorKey(SDL_Surface* surface, [NativeTypeName("Uint32 *")] uint* key);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetSurfaceColorMod", ExactSpelling = true)]
        public static extern int SetSurfaceColorMod(SDL_Surface* surface, [NativeTypeName("Uint8")] byte r, [NativeTypeName("Uint8")] byte g, [NativeTypeName("Uint8")] byte b);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSurfaceColorMod", ExactSpelling = true)]
        public static extern int GetSurfaceColorMod(SDL_Surface* surface, [NativeTypeName("Uint8 *")] byte* r, [NativeTypeName("Uint8 *")] byte* g, [NativeTypeName("Uint8 *")] byte* b);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetSurfaceAlphaMod", ExactSpelling = true)]
        public static extern int SetSurfaceAlphaMod(SDL_Surface* surface, [NativeTypeName("Uint8")] byte alpha);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSurfaceAlphaMod", ExactSpelling = true)]
        public static extern int GetSurfaceAlphaMod(SDL_Surface* surface, [NativeTypeName("Uint8 *")] byte* alpha);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetSurfaceBlendMode", ExactSpelling = true)]
        public static extern int SetSurfaceBlendMode(SDL_Surface* surface, SDL_BlendMode blendMode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSurfaceBlendMode", ExactSpelling = true)]
        public static extern int GetSurfaceBlendMode(SDL_Surface* surface, SDL_BlendMode* blendMode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetClipRect", ExactSpelling = true)]
        public static extern SDL_bool SetClipRect(SDL_Surface* surface, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetClipRect", ExactSpelling = true)]
        public static extern void GetClipRect(SDL_Surface* surface, SDL_Rect* rect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DuplicateSurface", ExactSpelling = true)]
        public static extern SDL_Surface* DuplicateSurface(SDL_Surface* surface);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ConvertSurface", ExactSpelling = true)]
        public static extern SDL_Surface* ConvertSurface(SDL_Surface* src, [NativeTypeName("const SDL_PixelFormat *")] SDL_PixelFormat* fmt, [NativeTypeName("Uint32")] uint flags);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ConvertSurfaceFormat", ExactSpelling = true)]
        public static extern SDL_Surface* ConvertSurfaceFormat(SDL_Surface* src, [NativeTypeName("Uint32")] uint pixel_format, [NativeTypeName("Uint32")] uint flags);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ConvertPixels", ExactSpelling = true)]
        public static extern int ConvertPixels(int width, int height, [NativeTypeName("Uint32")] uint src_format, [NativeTypeName("const void *")] void* src, int src_pitch, [NativeTypeName("Uint32")] uint dst_format, void* dst, int dst_pitch);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PremultiplyAlpha", ExactSpelling = true)]
        public static extern int PremultiplyAlpha(int width, int height, [NativeTypeName("Uint32")] uint src_format, [NativeTypeName("const void *")] void* src, int src_pitch, [NativeTypeName("Uint32")] uint dst_format, void* dst, int dst_pitch);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FillRect", ExactSpelling = true)]
        public static extern int FillRect(SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, [NativeTypeName("Uint32")] uint color);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FillRects", ExactSpelling = true)]
        public static extern int FillRects(SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rects, int count, [NativeTypeName("Uint32")] uint color);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UpperBlit", ExactSpelling = true)]
        public static extern int UpperBlit(SDL_Surface* src, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, SDL_Surface* dst, SDL_Rect* dstrect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LowerBlit", ExactSpelling = true)]
        public static extern int LowerBlit(SDL_Surface* src, SDL_Rect* srcrect, SDL_Surface* dst, SDL_Rect* dstrect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SoftStretch", ExactSpelling = true)]
        public static extern int SoftStretch(SDL_Surface* src, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* dstrect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SoftStretchLinear", ExactSpelling = true)]
        public static extern int SoftStretchLinear(SDL_Surface* src, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* dstrect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UpperBlitScaled", ExactSpelling = true)]
        public static extern int UpperBlitScaled(SDL_Surface* src, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, SDL_Surface* dst, SDL_Rect* dstrect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LowerBlitScaled", ExactSpelling = true)]
        public static extern int LowerBlitScaled(SDL_Surface* src, SDL_Rect* srcrect, SDL_Surface* dst, SDL_Rect* dstrect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetYUVConversionMode", ExactSpelling = true)]
        public static extern void SetYUVConversionMode(SDL_YUV_CONVERSION_MODE mode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetYUVConversionMode", ExactSpelling = true)]
        public static extern SDL_YUV_CONVERSION_MODE GetYUVConversionMode();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetYUVConversionModeForResolution", ExactSpelling = true)]
        public static extern SDL_YUV_CONVERSION_MODE GetYUVConversionModeForResolution(int width, int height);

        [NativeTypeName("#define SDL_SWSURFACE 0")]
        public const int SDL_SWSURFACE = 0;

        [NativeTypeName("#define SDL_PREALLOC 0x00000001")]
        public const int SDL_PREALLOC = 0x00000001;

        [NativeTypeName("#define SDL_RLEACCEL 0x00000002")]
        public const int SDL_RLEACCEL = 0x00000002;

        [NativeTypeName("#define SDL_DONTFREE 0x00000004")]
        public const int SDL_DONTFREE = 0x00000004;

        [NativeTypeName("#define SDL_SIMD_ALIGNED 0x00000008")]
        public const int SDL_SIMD_ALIGNED = 0x00000008;

        [NativeTypeName("#define SDL_BlitSurface SDL_UpperBlit")]
        public static readonly delegate*<SDL_Surface*, SDL_Rect*, SDL_Surface*, SDL_Rect*, int> SDL_BlitSurface = &UpperBlit;

        [NativeTypeName("#define SDL_BlitScaled SDL_UpperBlitScaled")]
        public static readonly delegate*<SDL_Surface*, SDL_Rect*, SDL_Surface*, SDL_Rect*, int> SDL_BlitScaled = &UpperBlitScaled;

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AtomicTryLock", ExactSpelling = true)]
        public static extern SDL_bool AtomicTryLock([NativeTypeName("SDL_SpinLock *")] int* @lock);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AtomicLock", ExactSpelling = true)]
        public static extern void AtomicLock([NativeTypeName("SDL_SpinLock *")] int* @lock);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AtomicUnlock", ExactSpelling = true)]
        public static extern void AtomicUnlock([NativeTypeName("SDL_SpinLock *")] int* @lock);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_MemoryBarrierReleaseFunction", ExactSpelling = true)]
        public static extern void MemoryBarrierReleaseFunction();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_MemoryBarrierAcquireFunction", ExactSpelling = true)]
        public static extern void MemoryBarrierAcquireFunction();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AtomicCAS", ExactSpelling = true)]
        public static extern SDL_bool AtomicCAS(SDL_atomic_t* a, int oldval, int newval);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AtomicSet", ExactSpelling = true)]
        public static extern int AtomicSet(SDL_atomic_t* a, int v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AtomicGet", ExactSpelling = true)]
        public static extern int AtomicGet(SDL_atomic_t* a);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AtomicAdd", ExactSpelling = true)]
        public static extern int AtomicAdd(SDL_atomic_t* a, int v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AtomicCASPtr", ExactSpelling = true)]
        public static extern SDL_bool AtomicCASPtr(void** a, void* oldval, void* newval);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AtomicSetPtr", ExactSpelling = true)]
        public static extern void* AtomicSetPtr(void** a, void* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AtomicGetPtr", ExactSpelling = true)]
        public static extern void* AtomicGetPtr(void** a);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glClearIndex([NativeTypeName("GLfloat")] float c);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glClearColor([NativeTypeName("GLclampf")] float red, [NativeTypeName("GLclampf")] float green, [NativeTypeName("GLclampf")] float blue, [NativeTypeName("GLclampf")] float alpha);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glClear([NativeTypeName("GLbitfield")] uint mask);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glIndexMask([NativeTypeName("GLuint")] uint mask);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColorMask([NativeTypeName("GLboolean")] byte red, [NativeTypeName("GLboolean")] byte green, [NativeTypeName("GLboolean")] byte blue, [NativeTypeName("GLboolean")] byte alpha);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glAlphaFunc([NativeTypeName("GLenum")] uint func, [NativeTypeName("GLclampf")] float @ref);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glBlendFunc([NativeTypeName("GLenum")] uint sfactor, [NativeTypeName("GLenum")] uint dfactor);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glLogicOp([NativeTypeName("GLenum")] uint opcode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glCullFace([NativeTypeName("GLenum")] uint mode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glFrontFace([NativeTypeName("GLenum")] uint mode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glPointSize([NativeTypeName("GLfloat")] float size);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glLineWidth([NativeTypeName("GLfloat")] float width);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glLineStipple([NativeTypeName("GLint")] int factor, [NativeTypeName("GLushort")] ushort pattern);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glPolygonMode([NativeTypeName("GLenum")] uint face, [NativeTypeName("GLenum")] uint mode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glPolygonOffset([NativeTypeName("GLfloat")] float factor, [NativeTypeName("GLfloat")] float units);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glPolygonStipple([NativeTypeName("const GLubyte *")] byte* mask);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetPolygonStipple([NativeTypeName("GLubyte *")] byte* mask);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glEdgeFlag([NativeTypeName("GLboolean")] byte flag);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glEdgeFlagv([NativeTypeName("const GLboolean *")] byte* flag);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glScissor([NativeTypeName("GLint")] int x, [NativeTypeName("GLint")] int y, [NativeTypeName("GLsizei")] int width, [NativeTypeName("GLsizei")] int height);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glClipPlane([NativeTypeName("GLenum")] uint plane, [NativeTypeName("const GLdouble *")] double* equation);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetClipPlane([NativeTypeName("GLenum")] uint plane, [NativeTypeName("GLdouble *")] double* equation);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glDrawBuffer([NativeTypeName("GLenum")] uint mode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glReadBuffer([NativeTypeName("GLenum")] uint mode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glEnable([NativeTypeName("GLenum")] uint cap);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glDisable([NativeTypeName("GLenum")] uint cap);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GLboolean")]
        public static extern byte glIsEnabled([NativeTypeName("GLenum")] uint cap);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glEnableClientState([NativeTypeName("GLenum")] uint cap);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glDisableClientState([NativeTypeName("GLenum")] uint cap);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetBooleanv([NativeTypeName("GLenum")] uint pname, [NativeTypeName("GLboolean *")] byte* @params);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetDoublev([NativeTypeName("GLenum")] uint pname, [NativeTypeName("GLdouble *")] double* @params);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetFloatv([NativeTypeName("GLenum")] uint pname, [NativeTypeName("GLfloat *")] float* @params);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetIntegerv([NativeTypeName("GLenum")] uint pname, [NativeTypeName("GLint *")] int* @params);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glPushAttrib([NativeTypeName("GLbitfield")] uint mask);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glPopAttrib();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glPushClientAttrib([NativeTypeName("GLbitfield")] uint mask);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glPopClientAttrib();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GLint")]
        public static extern int glRenderMode([NativeTypeName("GLenum")] uint mode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GLenum")]
        public static extern uint glGetError();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const GLubyte *")]
        public static extern byte* glGetString([NativeTypeName("GLenum")] uint name);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glFinish();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glFlush();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glHint([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLenum")] uint mode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glClearDepth([NativeTypeName("GLclampd")] double depth);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glDepthFunc([NativeTypeName("GLenum")] uint func);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glDepthMask([NativeTypeName("GLboolean")] byte flag);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glDepthRange([NativeTypeName("GLclampd")] double near_val, [NativeTypeName("GLclampd")] double far_val);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glClearAccum([NativeTypeName("GLfloat")] float red, [NativeTypeName("GLfloat")] float green, [NativeTypeName("GLfloat")] float blue, [NativeTypeName("GLfloat")] float alpha);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glAccum([NativeTypeName("GLenum")] uint op, [NativeTypeName("GLfloat")] float value);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMatrixMode([NativeTypeName("GLenum")] uint mode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glOrtho([NativeTypeName("GLdouble")] double left, [NativeTypeName("GLdouble")] double right, [NativeTypeName("GLdouble")] double bottom, [NativeTypeName("GLdouble")] double top, [NativeTypeName("GLdouble")] double near_val, [NativeTypeName("GLdouble")] double far_val);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glFrustum([NativeTypeName("GLdouble")] double left, [NativeTypeName("GLdouble")] double right, [NativeTypeName("GLdouble")] double bottom, [NativeTypeName("GLdouble")] double top, [NativeTypeName("GLdouble")] double near_val, [NativeTypeName("GLdouble")] double far_val);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glViewport([NativeTypeName("GLint")] int x, [NativeTypeName("GLint")] int y, [NativeTypeName("GLsizei")] int width, [NativeTypeName("GLsizei")] int height);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glPushMatrix();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glPopMatrix();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glLoadIdentity();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glLoadMatrixd([NativeTypeName("const GLdouble *")] double* m);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glLoadMatrixf([NativeTypeName("const GLfloat *")] float* m);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultMatrixd([NativeTypeName("const GLdouble *")] double* m);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultMatrixf([NativeTypeName("const GLfloat *")] float* m);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRotated([NativeTypeName("GLdouble")] double angle, [NativeTypeName("GLdouble")] double x, [NativeTypeName("GLdouble")] double y, [NativeTypeName("GLdouble")] double z);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRotatef([NativeTypeName("GLfloat")] float angle, [NativeTypeName("GLfloat")] float x, [NativeTypeName("GLfloat")] float y, [NativeTypeName("GLfloat")] float z);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glScaled([NativeTypeName("GLdouble")] double x, [NativeTypeName("GLdouble")] double y, [NativeTypeName("GLdouble")] double z);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glScalef([NativeTypeName("GLfloat")] float x, [NativeTypeName("GLfloat")] float y, [NativeTypeName("GLfloat")] float z);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTranslated([NativeTypeName("GLdouble")] double x, [NativeTypeName("GLdouble")] double y, [NativeTypeName("GLdouble")] double z);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTranslatef([NativeTypeName("GLfloat")] float x, [NativeTypeName("GLfloat")] float y, [NativeTypeName("GLfloat")] float z);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GLboolean")]
        public static extern byte glIsList([NativeTypeName("GLuint")] uint list);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glDeleteLists([NativeTypeName("GLuint")] uint list, [NativeTypeName("GLsizei")] int range);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GLuint")]
        public static extern uint glGenLists([NativeTypeName("GLsizei")] int range);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glNewList([NativeTypeName("GLuint")] uint list, [NativeTypeName("GLenum")] uint mode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glEndList();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glCallList([NativeTypeName("GLuint")] uint list);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glCallLists([NativeTypeName("GLsizei")] int n, [NativeTypeName("GLenum")] uint type, [NativeTypeName("const GLvoid *")] void* lists);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glListBase([NativeTypeName("GLuint")] uint @base);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glBegin([NativeTypeName("GLenum")] uint mode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glEnd();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex2d([NativeTypeName("GLdouble")] double x, [NativeTypeName("GLdouble")] double y);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex2f([NativeTypeName("GLfloat")] float x, [NativeTypeName("GLfloat")] float y);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex2i([NativeTypeName("GLint")] int x, [NativeTypeName("GLint")] int y);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex2s([NativeTypeName("GLshort")] short x, [NativeTypeName("GLshort")] short y);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex3d([NativeTypeName("GLdouble")] double x, [NativeTypeName("GLdouble")] double y, [NativeTypeName("GLdouble")] double z);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex3f([NativeTypeName("GLfloat")] float x, [NativeTypeName("GLfloat")] float y, [NativeTypeName("GLfloat")] float z);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex3i([NativeTypeName("GLint")] int x, [NativeTypeName("GLint")] int y, [NativeTypeName("GLint")] int z);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex3s([NativeTypeName("GLshort")] short x, [NativeTypeName("GLshort")] short y, [NativeTypeName("GLshort")] short z);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex4d([NativeTypeName("GLdouble")] double x, [NativeTypeName("GLdouble")] double y, [NativeTypeName("GLdouble")] double z, [NativeTypeName("GLdouble")] double w);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex4f([NativeTypeName("GLfloat")] float x, [NativeTypeName("GLfloat")] float y, [NativeTypeName("GLfloat")] float z, [NativeTypeName("GLfloat")] float w);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex4i([NativeTypeName("GLint")] int x, [NativeTypeName("GLint")] int y, [NativeTypeName("GLint")] int z, [NativeTypeName("GLint")] int w);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex4s([NativeTypeName("GLshort")] short x, [NativeTypeName("GLshort")] short y, [NativeTypeName("GLshort")] short z, [NativeTypeName("GLshort")] short w);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex2dv([NativeTypeName("const GLdouble *")] double* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex2fv([NativeTypeName("const GLfloat *")] float* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex2iv([NativeTypeName("const GLint *")] int* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex2sv([NativeTypeName("const GLshort *")] short* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex3dv([NativeTypeName("const GLdouble *")] double* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex3fv([NativeTypeName("const GLfloat *")] float* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex3iv([NativeTypeName("const GLint *")] int* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex3sv([NativeTypeName("const GLshort *")] short* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex4dv([NativeTypeName("const GLdouble *")] double* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex4fv([NativeTypeName("const GLfloat *")] float* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex4iv([NativeTypeName("const GLint *")] int* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex4sv([NativeTypeName("const GLshort *")] short* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glNormal3b([NativeTypeName("GLbyte")] sbyte nx, [NativeTypeName("GLbyte")] sbyte ny, [NativeTypeName("GLbyte")] sbyte nz);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glNormal3d([NativeTypeName("GLdouble")] double nx, [NativeTypeName("GLdouble")] double ny, [NativeTypeName("GLdouble")] double nz);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glNormal3f([NativeTypeName("GLfloat")] float nx, [NativeTypeName("GLfloat")] float ny, [NativeTypeName("GLfloat")] float nz);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glNormal3i([NativeTypeName("GLint")] int nx, [NativeTypeName("GLint")] int ny, [NativeTypeName("GLint")] int nz);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glNormal3s([NativeTypeName("GLshort")] short nx, [NativeTypeName("GLshort")] short ny, [NativeTypeName("GLshort")] short nz);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glNormal3bv([NativeTypeName("const GLbyte *")] sbyte* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glNormal3dv([NativeTypeName("const GLdouble *")] double* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glNormal3fv([NativeTypeName("const GLfloat *")] float* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glNormal3iv([NativeTypeName("const GLint *")] int* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glNormal3sv([NativeTypeName("const GLshort *")] short* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glIndexd([NativeTypeName("GLdouble")] double c);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glIndexf([NativeTypeName("GLfloat")] float c);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glIndexi([NativeTypeName("GLint")] int c);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glIndexs([NativeTypeName("GLshort")] short c);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glIndexub([NativeTypeName("GLubyte")] byte c);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glIndexdv([NativeTypeName("const GLdouble *")] double* c);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glIndexfv([NativeTypeName("const GLfloat *")] float* c);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glIndexiv([NativeTypeName("const GLint *")] int* c);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glIndexsv([NativeTypeName("const GLshort *")] short* c);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glIndexubv([NativeTypeName("const GLubyte *")] byte* c);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor3b([NativeTypeName("GLbyte")] sbyte red, [NativeTypeName("GLbyte")] sbyte green, [NativeTypeName("GLbyte")] sbyte blue);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor3d([NativeTypeName("GLdouble")] double red, [NativeTypeName("GLdouble")] double green, [NativeTypeName("GLdouble")] double blue);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor3f([NativeTypeName("GLfloat")] float red, [NativeTypeName("GLfloat")] float green, [NativeTypeName("GLfloat")] float blue);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor3i([NativeTypeName("GLint")] int red, [NativeTypeName("GLint")] int green, [NativeTypeName("GLint")] int blue);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor3s([NativeTypeName("GLshort")] short red, [NativeTypeName("GLshort")] short green, [NativeTypeName("GLshort")] short blue);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor3ub([NativeTypeName("GLubyte")] byte red, [NativeTypeName("GLubyte")] byte green, [NativeTypeName("GLubyte")] byte blue);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor3ui([NativeTypeName("GLuint")] uint red, [NativeTypeName("GLuint")] uint green, [NativeTypeName("GLuint")] uint blue);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor3us([NativeTypeName("GLushort")] ushort red, [NativeTypeName("GLushort")] ushort green, [NativeTypeName("GLushort")] ushort blue);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor4b([NativeTypeName("GLbyte")] sbyte red, [NativeTypeName("GLbyte")] sbyte green, [NativeTypeName("GLbyte")] sbyte blue, [NativeTypeName("GLbyte")] sbyte alpha);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor4d([NativeTypeName("GLdouble")] double red, [NativeTypeName("GLdouble")] double green, [NativeTypeName("GLdouble")] double blue, [NativeTypeName("GLdouble")] double alpha);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor4f([NativeTypeName("GLfloat")] float red, [NativeTypeName("GLfloat")] float green, [NativeTypeName("GLfloat")] float blue, [NativeTypeName("GLfloat")] float alpha);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor4i([NativeTypeName("GLint")] int red, [NativeTypeName("GLint")] int green, [NativeTypeName("GLint")] int blue, [NativeTypeName("GLint")] int alpha);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor4s([NativeTypeName("GLshort")] short red, [NativeTypeName("GLshort")] short green, [NativeTypeName("GLshort")] short blue, [NativeTypeName("GLshort")] short alpha);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor4ub([NativeTypeName("GLubyte")] byte red, [NativeTypeName("GLubyte")] byte green, [NativeTypeName("GLubyte")] byte blue, [NativeTypeName("GLubyte")] byte alpha);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor4ui([NativeTypeName("GLuint")] uint red, [NativeTypeName("GLuint")] uint green, [NativeTypeName("GLuint")] uint blue, [NativeTypeName("GLuint")] uint alpha);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor4us([NativeTypeName("GLushort")] ushort red, [NativeTypeName("GLushort")] ushort green, [NativeTypeName("GLushort")] ushort blue, [NativeTypeName("GLushort")] ushort alpha);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor3bv([NativeTypeName("const GLbyte *")] sbyte* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor3dv([NativeTypeName("const GLdouble *")] double* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor3fv([NativeTypeName("const GLfloat *")] float* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor3iv([NativeTypeName("const GLint *")] int* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor3sv([NativeTypeName("const GLshort *")] short* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor3ubv([NativeTypeName("const GLubyte *")] byte* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor3uiv([NativeTypeName("const GLuint *")] uint* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor3usv([NativeTypeName("const GLushort *")] ushort* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor4bv([NativeTypeName("const GLbyte *")] sbyte* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor4dv([NativeTypeName("const GLdouble *")] double* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor4fv([NativeTypeName("const GLfloat *")] float* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor4iv([NativeTypeName("const GLint *")] int* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor4sv([NativeTypeName("const GLshort *")] short* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor4ubv([NativeTypeName("const GLubyte *")] byte* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor4uiv([NativeTypeName("const GLuint *")] uint* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor4usv([NativeTypeName("const GLushort *")] ushort* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord1d([NativeTypeName("GLdouble")] double s);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord1f([NativeTypeName("GLfloat")] float s);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord1i([NativeTypeName("GLint")] int s);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord1s([NativeTypeName("GLshort")] short s);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord2d([NativeTypeName("GLdouble")] double s, [NativeTypeName("GLdouble")] double t);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord2f([NativeTypeName("GLfloat")] float s, [NativeTypeName("GLfloat")] float t);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord2i([NativeTypeName("GLint")] int s, [NativeTypeName("GLint")] int t);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord2s([NativeTypeName("GLshort")] short s, [NativeTypeName("GLshort")] short t);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord3d([NativeTypeName("GLdouble")] double s, [NativeTypeName("GLdouble")] double t, [NativeTypeName("GLdouble")] double r);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord3f([NativeTypeName("GLfloat")] float s, [NativeTypeName("GLfloat")] float t, [NativeTypeName("GLfloat")] float r);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord3i([NativeTypeName("GLint")] int s, [NativeTypeName("GLint")] int t, [NativeTypeName("GLint")] int r);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord3s([NativeTypeName("GLshort")] short s, [NativeTypeName("GLshort")] short t, [NativeTypeName("GLshort")] short r);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord4d([NativeTypeName("GLdouble")] double s, [NativeTypeName("GLdouble")] double t, [NativeTypeName("GLdouble")] double r, [NativeTypeName("GLdouble")] double q);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord4f([NativeTypeName("GLfloat")] float s, [NativeTypeName("GLfloat")] float t, [NativeTypeName("GLfloat")] float r, [NativeTypeName("GLfloat")] float q);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord4i([NativeTypeName("GLint")] int s, [NativeTypeName("GLint")] int t, [NativeTypeName("GLint")] int r, [NativeTypeName("GLint")] int q);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord4s([NativeTypeName("GLshort")] short s, [NativeTypeName("GLshort")] short t, [NativeTypeName("GLshort")] short r, [NativeTypeName("GLshort")] short q);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord1dv([NativeTypeName("const GLdouble *")] double* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord1fv([NativeTypeName("const GLfloat *")] float* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord1iv([NativeTypeName("const GLint *")] int* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord1sv([NativeTypeName("const GLshort *")] short* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord2dv([NativeTypeName("const GLdouble *")] double* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord2fv([NativeTypeName("const GLfloat *")] float* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord2iv([NativeTypeName("const GLint *")] int* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord2sv([NativeTypeName("const GLshort *")] short* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord3dv([NativeTypeName("const GLdouble *")] double* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord3fv([NativeTypeName("const GLfloat *")] float* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord3iv([NativeTypeName("const GLint *")] int* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord3sv([NativeTypeName("const GLshort *")] short* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord4dv([NativeTypeName("const GLdouble *")] double* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord4fv([NativeTypeName("const GLfloat *")] float* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord4iv([NativeTypeName("const GLint *")] int* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord4sv([NativeTypeName("const GLshort *")] short* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos2d([NativeTypeName("GLdouble")] double x, [NativeTypeName("GLdouble")] double y);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos2f([NativeTypeName("GLfloat")] float x, [NativeTypeName("GLfloat")] float y);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos2i([NativeTypeName("GLint")] int x, [NativeTypeName("GLint")] int y);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos2s([NativeTypeName("GLshort")] short x, [NativeTypeName("GLshort")] short y);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos3d([NativeTypeName("GLdouble")] double x, [NativeTypeName("GLdouble")] double y, [NativeTypeName("GLdouble")] double z);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos3f([NativeTypeName("GLfloat")] float x, [NativeTypeName("GLfloat")] float y, [NativeTypeName("GLfloat")] float z);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos3i([NativeTypeName("GLint")] int x, [NativeTypeName("GLint")] int y, [NativeTypeName("GLint")] int z);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos3s([NativeTypeName("GLshort")] short x, [NativeTypeName("GLshort")] short y, [NativeTypeName("GLshort")] short z);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos4d([NativeTypeName("GLdouble")] double x, [NativeTypeName("GLdouble")] double y, [NativeTypeName("GLdouble")] double z, [NativeTypeName("GLdouble")] double w);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos4f([NativeTypeName("GLfloat")] float x, [NativeTypeName("GLfloat")] float y, [NativeTypeName("GLfloat")] float z, [NativeTypeName("GLfloat")] float w);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos4i([NativeTypeName("GLint")] int x, [NativeTypeName("GLint")] int y, [NativeTypeName("GLint")] int z, [NativeTypeName("GLint")] int w);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos4s([NativeTypeName("GLshort")] short x, [NativeTypeName("GLshort")] short y, [NativeTypeName("GLshort")] short z, [NativeTypeName("GLshort")] short w);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos2dv([NativeTypeName("const GLdouble *")] double* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos2fv([NativeTypeName("const GLfloat *")] float* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos2iv([NativeTypeName("const GLint *")] int* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos2sv([NativeTypeName("const GLshort *")] short* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos3dv([NativeTypeName("const GLdouble *")] double* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos3fv([NativeTypeName("const GLfloat *")] float* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos3iv([NativeTypeName("const GLint *")] int* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos3sv([NativeTypeName("const GLshort *")] short* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos4dv([NativeTypeName("const GLdouble *")] double* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos4fv([NativeTypeName("const GLfloat *")] float* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos4iv([NativeTypeName("const GLint *")] int* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos4sv([NativeTypeName("const GLshort *")] short* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRectd([NativeTypeName("GLdouble")] double x1, [NativeTypeName("GLdouble")] double y1, [NativeTypeName("GLdouble")] double x2, [NativeTypeName("GLdouble")] double y2);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRectf([NativeTypeName("GLfloat")] float x1, [NativeTypeName("GLfloat")] float y1, [NativeTypeName("GLfloat")] float x2, [NativeTypeName("GLfloat")] float y2);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRecti([NativeTypeName("GLint")] int x1, [NativeTypeName("GLint")] int y1, [NativeTypeName("GLint")] int x2, [NativeTypeName("GLint")] int y2);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRects([NativeTypeName("GLshort")] short x1, [NativeTypeName("GLshort")] short y1, [NativeTypeName("GLshort")] short x2, [NativeTypeName("GLshort")] short y2);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRectdv([NativeTypeName("const GLdouble *")] double* v1, [NativeTypeName("const GLdouble *")] double* v2);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRectfv([NativeTypeName("const GLfloat *")] float* v1, [NativeTypeName("const GLfloat *")] float* v2);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRectiv([NativeTypeName("const GLint *")] int* v1, [NativeTypeName("const GLint *")] int* v2);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRectsv([NativeTypeName("const GLshort *")] short* v1, [NativeTypeName("const GLshort *")] short* v2);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertexPointer([NativeTypeName("GLint")] int size, [NativeTypeName("GLenum")] uint type, [NativeTypeName("GLsizei")] int stride, [NativeTypeName("const GLvoid *")] void* ptr);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glNormalPointer([NativeTypeName("GLenum")] uint type, [NativeTypeName("GLsizei")] int stride, [NativeTypeName("const GLvoid *")] void* ptr);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColorPointer([NativeTypeName("GLint")] int size, [NativeTypeName("GLenum")] uint type, [NativeTypeName("GLsizei")] int stride, [NativeTypeName("const GLvoid *")] void* ptr);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glIndexPointer([NativeTypeName("GLenum")] uint type, [NativeTypeName("GLsizei")] int stride, [NativeTypeName("const GLvoid *")] void* ptr);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoordPointer([NativeTypeName("GLint")] int size, [NativeTypeName("GLenum")] uint type, [NativeTypeName("GLsizei")] int stride, [NativeTypeName("const GLvoid *")] void* ptr);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glEdgeFlagPointer([NativeTypeName("GLsizei")] int stride, [NativeTypeName("const GLvoid *")] void* ptr);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetPointerv([NativeTypeName("GLenum")] uint pname, [NativeTypeName("GLvoid **")] void** @params);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glArrayElement([NativeTypeName("GLint")] int i);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glDrawArrays([NativeTypeName("GLenum")] uint mode, [NativeTypeName("GLint")] int first, [NativeTypeName("GLsizei")] int count);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glDrawElements([NativeTypeName("GLenum")] uint mode, [NativeTypeName("GLsizei")] int count, [NativeTypeName("GLenum")] uint type, [NativeTypeName("const GLvoid *")] void* indices);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glInterleavedArrays([NativeTypeName("GLenum")] uint format, [NativeTypeName("GLsizei")] int stride, [NativeTypeName("const GLvoid *")] void* pointer);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glShadeModel([NativeTypeName("GLenum")] uint mode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glLightf([NativeTypeName("GLenum")] uint light, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("GLfloat")] float param2);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glLighti([NativeTypeName("GLenum")] uint light, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("GLint")] int param2);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glLightfv([NativeTypeName("GLenum")] uint light, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("const GLfloat *")] float* @params);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glLightiv([NativeTypeName("GLenum")] uint light, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("const GLint *")] int* @params);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetLightfv([NativeTypeName("GLenum")] uint light, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("GLfloat *")] float* @params);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetLightiv([NativeTypeName("GLenum")] uint light, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("GLint *")] int* @params);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glLightModelf([NativeTypeName("GLenum")] uint pname, [NativeTypeName("GLfloat")] float param1);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glLightModeli([NativeTypeName("GLenum")] uint pname, [NativeTypeName("GLint")] int param1);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glLightModelfv([NativeTypeName("GLenum")] uint pname, [NativeTypeName("const GLfloat *")] float* @params);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glLightModeliv([NativeTypeName("GLenum")] uint pname, [NativeTypeName("const GLint *")] int* @params);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMaterialf([NativeTypeName("GLenum")] uint face, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("GLfloat")] float param2);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMateriali([NativeTypeName("GLenum")] uint face, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("GLint")] int param2);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMaterialfv([NativeTypeName("GLenum")] uint face, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("const GLfloat *")] float* @params);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMaterialiv([NativeTypeName("GLenum")] uint face, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("const GLint *")] int* @params);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetMaterialfv([NativeTypeName("GLenum")] uint face, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("GLfloat *")] float* @params);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetMaterialiv([NativeTypeName("GLenum")] uint face, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("GLint *")] int* @params);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColorMaterial([NativeTypeName("GLenum")] uint face, [NativeTypeName("GLenum")] uint mode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glPixelZoom([NativeTypeName("GLfloat")] float xfactor, [NativeTypeName("GLfloat")] float yfactor);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glPixelStoref([NativeTypeName("GLenum")] uint pname, [NativeTypeName("GLfloat")] float param1);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glPixelStorei([NativeTypeName("GLenum")] uint pname, [NativeTypeName("GLint")] int param1);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glPixelTransferf([NativeTypeName("GLenum")] uint pname, [NativeTypeName("GLfloat")] float param1);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glPixelTransferi([NativeTypeName("GLenum")] uint pname, [NativeTypeName("GLint")] int param1);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glPixelMapfv([NativeTypeName("GLenum")] uint map, [NativeTypeName("GLsizei")] int mapsize, [NativeTypeName("const GLfloat *")] float* values);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glPixelMapuiv([NativeTypeName("GLenum")] uint map, [NativeTypeName("GLsizei")] int mapsize, [NativeTypeName("const GLuint *")] uint* values);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glPixelMapusv([NativeTypeName("GLenum")] uint map, [NativeTypeName("GLsizei")] int mapsize, [NativeTypeName("const GLushort *")] ushort* values);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetPixelMapfv([NativeTypeName("GLenum")] uint map, [NativeTypeName("GLfloat *")] float* values);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetPixelMapuiv([NativeTypeName("GLenum")] uint map, [NativeTypeName("GLuint *")] uint* values);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetPixelMapusv([NativeTypeName("GLenum")] uint map, [NativeTypeName("GLushort *")] ushort* values);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glBitmap([NativeTypeName("GLsizei")] int width, [NativeTypeName("GLsizei")] int height, [NativeTypeName("GLfloat")] float xorig, [NativeTypeName("GLfloat")] float yorig, [NativeTypeName("GLfloat")] float xmove, [NativeTypeName("GLfloat")] float ymove, [NativeTypeName("const GLubyte *")] byte* bitmap);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glReadPixels([NativeTypeName("GLint")] int x, [NativeTypeName("GLint")] int y, [NativeTypeName("GLsizei")] int width, [NativeTypeName("GLsizei")] int height, [NativeTypeName("GLenum")] uint format, [NativeTypeName("GLenum")] uint type, [NativeTypeName("GLvoid *")] void* pixels);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glDrawPixels([NativeTypeName("GLsizei")] int width, [NativeTypeName("GLsizei")] int height, [NativeTypeName("GLenum")] uint format, [NativeTypeName("GLenum")] uint type, [NativeTypeName("const GLvoid *")] void* pixels);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glCopyPixels([NativeTypeName("GLint")] int x, [NativeTypeName("GLint")] int y, [NativeTypeName("GLsizei")] int width, [NativeTypeName("GLsizei")] int height, [NativeTypeName("GLenum")] uint type);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glStencilFunc([NativeTypeName("GLenum")] uint func, [NativeTypeName("GLint")] int @ref, [NativeTypeName("GLuint")] uint mask);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glStencilMask([NativeTypeName("GLuint")] uint mask);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glStencilOp([NativeTypeName("GLenum")] uint fail, [NativeTypeName("GLenum")] uint zfail, [NativeTypeName("GLenum")] uint zpass);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glClearStencil([NativeTypeName("GLint")] int s);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexGend([NativeTypeName("GLenum")] uint coord, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("GLdouble")] double param2);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexGenf([NativeTypeName("GLenum")] uint coord, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("GLfloat")] float param2);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexGeni([NativeTypeName("GLenum")] uint coord, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("GLint")] int param2);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexGendv([NativeTypeName("GLenum")] uint coord, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("const GLdouble *")] double* @params);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexGenfv([NativeTypeName("GLenum")] uint coord, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("const GLfloat *")] float* @params);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexGeniv([NativeTypeName("GLenum")] uint coord, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("const GLint *")] int* @params);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetTexGendv([NativeTypeName("GLenum")] uint coord, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("GLdouble *")] double* @params);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetTexGenfv([NativeTypeName("GLenum")] uint coord, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("GLfloat *")] float* @params);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetTexGeniv([NativeTypeName("GLenum")] uint coord, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("GLint *")] int* @params);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexEnvf([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("GLfloat")] float param2);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexEnvi([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("GLint")] int param2);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexEnvfv([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("const GLfloat *")] float* @params);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexEnviv([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("const GLint *")] int* @params);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetTexEnvfv([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("GLfloat *")] float* @params);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetTexEnviv([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("GLint *")] int* @params);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexParameterf([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("GLfloat")] float param2);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexParameteri([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("GLint")] int param2);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexParameterfv([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("const GLfloat *")] float* @params);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexParameteriv([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("const GLint *")] int* @params);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetTexParameterfv([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("GLfloat *")] float* @params);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetTexParameteriv([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("GLint *")] int* @params);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetTexLevelParameterfv([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLint")] int level, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("GLfloat *")] float* @params);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetTexLevelParameteriv([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLint")] int level, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("GLint *")] int* @params);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexImage1D([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLint")] int level, [NativeTypeName("GLint")] int internalFormat, [NativeTypeName("GLsizei")] int width, [NativeTypeName("GLint")] int border, [NativeTypeName("GLenum")] uint format, [NativeTypeName("GLenum")] uint type, [NativeTypeName("const GLvoid *")] void* pixels);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexImage2D([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLint")] int level, [NativeTypeName("GLint")] int internalFormat, [NativeTypeName("GLsizei")] int width, [NativeTypeName("GLsizei")] int height, [NativeTypeName("GLint")] int border, [NativeTypeName("GLenum")] uint format, [NativeTypeName("GLenum")] uint type, [NativeTypeName("const GLvoid *")] void* pixels);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetTexImage([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLint")] int level, [NativeTypeName("GLenum")] uint format, [NativeTypeName("GLenum")] uint type, [NativeTypeName("GLvoid *")] void* pixels);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGenTextures([NativeTypeName("GLsizei")] int n, [NativeTypeName("GLuint *")] uint* textures);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glDeleteTextures([NativeTypeName("GLsizei")] int n, [NativeTypeName("const GLuint *")] uint* textures);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glBindTexture([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLuint")] uint texture);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glPrioritizeTextures([NativeTypeName("GLsizei")] int n, [NativeTypeName("const GLuint *")] uint* textures, [NativeTypeName("const GLclampf *")] float* priorities);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GLboolean")]
        public static extern byte glAreTexturesResident([NativeTypeName("GLsizei")] int n, [NativeTypeName("const GLuint *")] uint* textures, [NativeTypeName("GLboolean *")] byte* residences);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GLboolean")]
        public static extern byte glIsTexture([NativeTypeName("GLuint")] uint texture);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexSubImage1D([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLint")] int level, [NativeTypeName("GLint")] int xoffset, [NativeTypeName("GLsizei")] int width, [NativeTypeName("GLenum")] uint format, [NativeTypeName("GLenum")] uint type, [NativeTypeName("const GLvoid *")] void* pixels);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexSubImage2D([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLint")] int level, [NativeTypeName("GLint")] int xoffset, [NativeTypeName("GLint")] int yoffset, [NativeTypeName("GLsizei")] int width, [NativeTypeName("GLsizei")] int height, [NativeTypeName("GLenum")] uint format, [NativeTypeName("GLenum")] uint type, [NativeTypeName("const GLvoid *")] void* pixels);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glCopyTexImage1D([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLint")] int level, [NativeTypeName("GLenum")] uint internalformat, [NativeTypeName("GLint")] int x, [NativeTypeName("GLint")] int y, [NativeTypeName("GLsizei")] int width, [NativeTypeName("GLint")] int border);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glCopyTexImage2D([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLint")] int level, [NativeTypeName("GLenum")] uint internalformat, [NativeTypeName("GLint")] int x, [NativeTypeName("GLint")] int y, [NativeTypeName("GLsizei")] int width, [NativeTypeName("GLsizei")] int height, [NativeTypeName("GLint")] int border);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glCopyTexSubImage1D([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLint")] int level, [NativeTypeName("GLint")] int xoffset, [NativeTypeName("GLint")] int x, [NativeTypeName("GLint")] int y, [NativeTypeName("GLsizei")] int width);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glCopyTexSubImage2D([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLint")] int level, [NativeTypeName("GLint")] int xoffset, [NativeTypeName("GLint")] int yoffset, [NativeTypeName("GLint")] int x, [NativeTypeName("GLint")] int y, [NativeTypeName("GLsizei")] int width, [NativeTypeName("GLsizei")] int height);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMap1d([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLdouble")] double u1, [NativeTypeName("GLdouble")] double u2, [NativeTypeName("GLint")] int stride, [NativeTypeName("GLint")] int order, [NativeTypeName("const GLdouble *")] double* points);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMap1f([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLfloat")] float u1, [NativeTypeName("GLfloat")] float u2, [NativeTypeName("GLint")] int stride, [NativeTypeName("GLint")] int order, [NativeTypeName("const GLfloat *")] float* points);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMap2d([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLdouble")] double u1, [NativeTypeName("GLdouble")] double u2, [NativeTypeName("GLint")] int ustride, [NativeTypeName("GLint")] int uorder, [NativeTypeName("GLdouble")] double v1, [NativeTypeName("GLdouble")] double v2, [NativeTypeName("GLint")] int vstride, [NativeTypeName("GLint")] int vorder, [NativeTypeName("const GLdouble *")] double* points);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMap2f([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLfloat")] float u1, [NativeTypeName("GLfloat")] float u2, [NativeTypeName("GLint")] int ustride, [NativeTypeName("GLint")] int uorder, [NativeTypeName("GLfloat")] float v1, [NativeTypeName("GLfloat")] float v2, [NativeTypeName("GLint")] int vstride, [NativeTypeName("GLint")] int vorder, [NativeTypeName("const GLfloat *")] float* points);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetMapdv([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLenum")] uint query, [NativeTypeName("GLdouble *")] double* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetMapfv([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLenum")] uint query, [NativeTypeName("GLfloat *")] float* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetMapiv([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLenum")] uint query, [NativeTypeName("GLint *")] int* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glEvalCoord1d([NativeTypeName("GLdouble")] double u);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glEvalCoord1f([NativeTypeName("GLfloat")] float u);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glEvalCoord1dv([NativeTypeName("const GLdouble *")] double* u);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glEvalCoord1fv([NativeTypeName("const GLfloat *")] float* u);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glEvalCoord2d([NativeTypeName("GLdouble")] double u, [NativeTypeName("GLdouble")] double v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glEvalCoord2f([NativeTypeName("GLfloat")] float u, [NativeTypeName("GLfloat")] float v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glEvalCoord2dv([NativeTypeName("const GLdouble *")] double* u);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glEvalCoord2fv([NativeTypeName("const GLfloat *")] float* u);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMapGrid1d([NativeTypeName("GLint")] int un, [NativeTypeName("GLdouble")] double u1, [NativeTypeName("GLdouble")] double u2);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMapGrid1f([NativeTypeName("GLint")] int un, [NativeTypeName("GLfloat")] float u1, [NativeTypeName("GLfloat")] float u2);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMapGrid2d([NativeTypeName("GLint")] int un, [NativeTypeName("GLdouble")] double u1, [NativeTypeName("GLdouble")] double u2, [NativeTypeName("GLint")] int vn, [NativeTypeName("GLdouble")] double v1, [NativeTypeName("GLdouble")] double v2);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMapGrid2f([NativeTypeName("GLint")] int un, [NativeTypeName("GLfloat")] float u1, [NativeTypeName("GLfloat")] float u2, [NativeTypeName("GLint")] int vn, [NativeTypeName("GLfloat")] float v1, [NativeTypeName("GLfloat")] float v2);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glEvalPoint1([NativeTypeName("GLint")] int i);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glEvalPoint2([NativeTypeName("GLint")] int i, [NativeTypeName("GLint")] int j);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glEvalMesh1([NativeTypeName("GLenum")] uint mode, [NativeTypeName("GLint")] int i1, [NativeTypeName("GLint")] int i2);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glEvalMesh2([NativeTypeName("GLenum")] uint mode, [NativeTypeName("GLint")] int i1, [NativeTypeName("GLint")] int i2, [NativeTypeName("GLint")] int j1, [NativeTypeName("GLint")] int j2);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glFogf([NativeTypeName("GLenum")] uint pname, [NativeTypeName("GLfloat")] float param1);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glFogi([NativeTypeName("GLenum")] uint pname, [NativeTypeName("GLint")] int param1);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glFogfv([NativeTypeName("GLenum")] uint pname, [NativeTypeName("const GLfloat *")] float* @params);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glFogiv([NativeTypeName("GLenum")] uint pname, [NativeTypeName("const GLint *")] int* @params);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glFeedbackBuffer([NativeTypeName("GLsizei")] int size, [NativeTypeName("GLenum")] uint type, [NativeTypeName("GLfloat *")] float* buffer);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glPassThrough([NativeTypeName("GLfloat")] float token);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glSelectBuffer([NativeTypeName("GLsizei")] int size, [NativeTypeName("GLuint *")] uint* buffer);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glInitNames();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glLoadName([NativeTypeName("GLuint")] uint name);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glPushName([NativeTypeName("GLuint")] uint name);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glPopName();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glDrawRangeElements([NativeTypeName("GLenum")] uint mode, [NativeTypeName("GLuint")] uint start, [NativeTypeName("GLuint")] uint end, [NativeTypeName("GLsizei")] int count, [NativeTypeName("GLenum")] uint type, [NativeTypeName("const GLvoid *")] void* indices);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexImage3D([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLint")] int level, [NativeTypeName("GLint")] int internalFormat, [NativeTypeName("GLsizei")] int width, [NativeTypeName("GLsizei")] int height, [NativeTypeName("GLsizei")] int depth, [NativeTypeName("GLint")] int border, [NativeTypeName("GLenum")] uint format, [NativeTypeName("GLenum")] uint type, [NativeTypeName("const GLvoid *")] void* pixels);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexSubImage3D([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLint")] int level, [NativeTypeName("GLint")] int xoffset, [NativeTypeName("GLint")] int yoffset, [NativeTypeName("GLint")] int zoffset, [NativeTypeName("GLsizei")] int width, [NativeTypeName("GLsizei")] int height, [NativeTypeName("GLsizei")] int depth, [NativeTypeName("GLenum")] uint format, [NativeTypeName("GLenum")] uint type, [NativeTypeName("const GLvoid *")] void* pixels);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glCopyTexSubImage3D([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLint")] int level, [NativeTypeName("GLint")] int xoffset, [NativeTypeName("GLint")] int yoffset, [NativeTypeName("GLint")] int zoffset, [NativeTypeName("GLint")] int x, [NativeTypeName("GLint")] int y, [NativeTypeName("GLsizei")] int width, [NativeTypeName("GLsizei")] int height);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColorTable([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLenum")] uint internalformat, [NativeTypeName("GLsizei")] int width, [NativeTypeName("GLenum")] uint format, [NativeTypeName("GLenum")] uint type, [NativeTypeName("const GLvoid *")] void* table);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColorSubTable([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLsizei")] int start, [NativeTypeName("GLsizei")] int count, [NativeTypeName("GLenum")] uint format, [NativeTypeName("GLenum")] uint type, [NativeTypeName("const GLvoid *")] void* data);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColorTableParameteriv([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("const GLint *")] int* @params);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColorTableParameterfv([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("const GLfloat *")] float* @params);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glCopyColorSubTable([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLsizei")] int start, [NativeTypeName("GLint")] int x, [NativeTypeName("GLint")] int y, [NativeTypeName("GLsizei")] int width);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glCopyColorTable([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLenum")] uint internalformat, [NativeTypeName("GLint")] int x, [NativeTypeName("GLint")] int y, [NativeTypeName("GLsizei")] int width);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetColorTable([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLenum")] uint format, [NativeTypeName("GLenum")] uint type, [NativeTypeName("GLvoid *")] void* table);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetColorTableParameterfv([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("GLfloat *")] float* @params);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetColorTableParameteriv([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("GLint *")] int* @params);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glBlendEquation([NativeTypeName("GLenum")] uint mode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glBlendColor([NativeTypeName("GLclampf")] float red, [NativeTypeName("GLclampf")] float green, [NativeTypeName("GLclampf")] float blue, [NativeTypeName("GLclampf")] float alpha);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glHistogram([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLsizei")] int width, [NativeTypeName("GLenum")] uint internalformat, [NativeTypeName("GLboolean")] byte sink);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glResetHistogram([NativeTypeName("GLenum")] uint target);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetHistogram([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLboolean")] byte reset, [NativeTypeName("GLenum")] uint format, [NativeTypeName("GLenum")] uint type, [NativeTypeName("GLvoid *")] void* values);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetHistogramParameterfv([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("GLfloat *")] float* @params);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetHistogramParameteriv([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("GLint *")] int* @params);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMinmax([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLenum")] uint internalformat, [NativeTypeName("GLboolean")] byte sink);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glResetMinmax([NativeTypeName("GLenum")] uint target);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetMinmax([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLboolean")] byte reset, [NativeTypeName("GLenum")] uint format, [NativeTypeName("GLenum")] uint types, [NativeTypeName("GLvoid *")] void* values);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetMinmaxParameterfv([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("GLfloat *")] float* @params);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetMinmaxParameteriv([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("GLint *")] int* @params);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glConvolutionFilter1D([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLenum")] uint internalformat, [NativeTypeName("GLsizei")] int width, [NativeTypeName("GLenum")] uint format, [NativeTypeName("GLenum")] uint type, [NativeTypeName("const GLvoid *")] void* image);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glConvolutionFilter2D([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLenum")] uint internalformat, [NativeTypeName("GLsizei")] int width, [NativeTypeName("GLsizei")] int height, [NativeTypeName("GLenum")] uint format, [NativeTypeName("GLenum")] uint type, [NativeTypeName("const GLvoid *")] void* image);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glConvolutionParameterf([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("GLfloat")] float @params);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glConvolutionParameterfv([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("const GLfloat *")] float* @params);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glConvolutionParameteri([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("GLint")] int @params);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glConvolutionParameteriv([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("const GLint *")] int* @params);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glCopyConvolutionFilter1D([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLenum")] uint internalformat, [NativeTypeName("GLint")] int x, [NativeTypeName("GLint")] int y, [NativeTypeName("GLsizei")] int width);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glCopyConvolutionFilter2D([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLenum")] uint internalformat, [NativeTypeName("GLint")] int x, [NativeTypeName("GLint")] int y, [NativeTypeName("GLsizei")] int width, [NativeTypeName("GLsizei")] int height);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetConvolutionFilter([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLenum")] uint format, [NativeTypeName("GLenum")] uint type, [NativeTypeName("GLvoid *")] void* image);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetConvolutionParameterfv([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("GLfloat *")] float* @params);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetConvolutionParameteriv([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLenum")] uint pname, [NativeTypeName("GLint *")] int* @params);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glSeparableFilter2D([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLenum")] uint internalformat, [NativeTypeName("GLsizei")] int width, [NativeTypeName("GLsizei")] int height, [NativeTypeName("GLenum")] uint format, [NativeTypeName("GLenum")] uint type, [NativeTypeName("const GLvoid *")] void* row, [NativeTypeName("const GLvoid *")] void* column);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetSeparableFilter([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLenum")] uint format, [NativeTypeName("GLenum")] uint type, [NativeTypeName("GLvoid *")] void* row, [NativeTypeName("GLvoid *")] void* column, [NativeTypeName("GLvoid *")] void* span);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glActiveTexture([NativeTypeName("GLenum")] uint texture);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glClientActiveTexture([NativeTypeName("GLenum")] uint texture);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glCompressedTexImage1D([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLint")] int level, [NativeTypeName("GLenum")] uint internalformat, [NativeTypeName("GLsizei")] int width, [NativeTypeName("GLint")] int border, [NativeTypeName("GLsizei")] int imageSize, [NativeTypeName("const GLvoid *")] void* data);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glCompressedTexImage2D([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLint")] int level, [NativeTypeName("GLenum")] uint internalformat, [NativeTypeName("GLsizei")] int width, [NativeTypeName("GLsizei")] int height, [NativeTypeName("GLint")] int border, [NativeTypeName("GLsizei")] int imageSize, [NativeTypeName("const GLvoid *")] void* data);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glCompressedTexImage3D([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLint")] int level, [NativeTypeName("GLenum")] uint internalformat, [NativeTypeName("GLsizei")] int width, [NativeTypeName("GLsizei")] int height, [NativeTypeName("GLsizei")] int depth, [NativeTypeName("GLint")] int border, [NativeTypeName("GLsizei")] int imageSize, [NativeTypeName("const GLvoid *")] void* data);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glCompressedTexSubImage1D([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLint")] int level, [NativeTypeName("GLint")] int xoffset, [NativeTypeName("GLsizei")] int width, [NativeTypeName("GLenum")] uint format, [NativeTypeName("GLsizei")] int imageSize, [NativeTypeName("const GLvoid *")] void* data);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glCompressedTexSubImage2D([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLint")] int level, [NativeTypeName("GLint")] int xoffset, [NativeTypeName("GLint")] int yoffset, [NativeTypeName("GLsizei")] int width, [NativeTypeName("GLsizei")] int height, [NativeTypeName("GLenum")] uint format, [NativeTypeName("GLsizei")] int imageSize, [NativeTypeName("const GLvoid *")] void* data);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glCompressedTexSubImage3D([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLint")] int level, [NativeTypeName("GLint")] int xoffset, [NativeTypeName("GLint")] int yoffset, [NativeTypeName("GLint")] int zoffset, [NativeTypeName("GLsizei")] int width, [NativeTypeName("GLsizei")] int height, [NativeTypeName("GLsizei")] int depth, [NativeTypeName("GLenum")] uint format, [NativeTypeName("GLsizei")] int imageSize, [NativeTypeName("const GLvoid *")] void* data);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetCompressedTexImage([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLint")] int lod, [NativeTypeName("GLvoid *")] void* img);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord1d([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLdouble")] double s);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord1dv([NativeTypeName("GLenum")] uint target, [NativeTypeName("const GLdouble *")] double* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord1f([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLfloat")] float s);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord1fv([NativeTypeName("GLenum")] uint target, [NativeTypeName("const GLfloat *")] float* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord1i([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLint")] int s);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord1iv([NativeTypeName("GLenum")] uint target, [NativeTypeName("const GLint *")] int* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord1s([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLshort")] short s);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord1sv([NativeTypeName("GLenum")] uint target, [NativeTypeName("const GLshort *")] short* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord2d([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLdouble")] double s, [NativeTypeName("GLdouble")] double t);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord2dv([NativeTypeName("GLenum")] uint target, [NativeTypeName("const GLdouble *")] double* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord2f([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLfloat")] float s, [NativeTypeName("GLfloat")] float t);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord2fv([NativeTypeName("GLenum")] uint target, [NativeTypeName("const GLfloat *")] float* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord2i([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLint")] int s, [NativeTypeName("GLint")] int t);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord2iv([NativeTypeName("GLenum")] uint target, [NativeTypeName("const GLint *")] int* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord2s([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLshort")] short s, [NativeTypeName("GLshort")] short t);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord2sv([NativeTypeName("GLenum")] uint target, [NativeTypeName("const GLshort *")] short* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord3d([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLdouble")] double s, [NativeTypeName("GLdouble")] double t, [NativeTypeName("GLdouble")] double r);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord3dv([NativeTypeName("GLenum")] uint target, [NativeTypeName("const GLdouble *")] double* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord3f([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLfloat")] float s, [NativeTypeName("GLfloat")] float t, [NativeTypeName("GLfloat")] float r);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord3fv([NativeTypeName("GLenum")] uint target, [NativeTypeName("const GLfloat *")] float* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord3i([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLint")] int s, [NativeTypeName("GLint")] int t, [NativeTypeName("GLint")] int r);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord3iv([NativeTypeName("GLenum")] uint target, [NativeTypeName("const GLint *")] int* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord3s([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLshort")] short s, [NativeTypeName("GLshort")] short t, [NativeTypeName("GLshort")] short r);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord3sv([NativeTypeName("GLenum")] uint target, [NativeTypeName("const GLshort *")] short* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord4d([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLdouble")] double s, [NativeTypeName("GLdouble")] double t, [NativeTypeName("GLdouble")] double r, [NativeTypeName("GLdouble")] double q);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord4dv([NativeTypeName("GLenum")] uint target, [NativeTypeName("const GLdouble *")] double* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord4f([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLfloat")] float s, [NativeTypeName("GLfloat")] float t, [NativeTypeName("GLfloat")] float r, [NativeTypeName("GLfloat")] float q);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord4fv([NativeTypeName("GLenum")] uint target, [NativeTypeName("const GLfloat *")] float* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord4i([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLint")] int s, [NativeTypeName("GLint")] int t, [NativeTypeName("GLint")] int r, [NativeTypeName("GLint")] int q);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord4iv([NativeTypeName("GLenum")] uint target, [NativeTypeName("const GLint *")] int* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord4s([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLshort")] short s, [NativeTypeName("GLshort")] short t, [NativeTypeName("GLshort")] short r, [NativeTypeName("GLshort")] short q);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord4sv([NativeTypeName("GLenum")] uint target, [NativeTypeName("const GLshort *")] short* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glLoadTransposeMatrixd([NativeTypeName("const GLdouble[16]")] double* m);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glLoadTransposeMatrixf([NativeTypeName("const GLfloat[16]")] float* m);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultTransposeMatrixd([NativeTypeName("const GLdouble[16]")] double* m);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultTransposeMatrixf([NativeTypeName("const GLfloat[16]")] float* m);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glSampleCoverage([NativeTypeName("GLclampf")] float value, [NativeTypeName("GLboolean")] byte invert);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glActiveTextureARB([NativeTypeName("GLenum")] uint texture);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glClientActiveTextureARB([NativeTypeName("GLenum")] uint texture);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord1dARB([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLdouble")] double s);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord1dvARB([NativeTypeName("GLenum")] uint target, [NativeTypeName("const GLdouble *")] double* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord1fARB([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLfloat")] float s);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord1fvARB([NativeTypeName("GLenum")] uint target, [NativeTypeName("const GLfloat *")] float* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord1iARB([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLint")] int s);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord1ivARB([NativeTypeName("GLenum")] uint target, [NativeTypeName("const GLint *")] int* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord1sARB([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLshort")] short s);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord1svARB([NativeTypeName("GLenum")] uint target, [NativeTypeName("const GLshort *")] short* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord2dARB([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLdouble")] double s, [NativeTypeName("GLdouble")] double t);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord2dvARB([NativeTypeName("GLenum")] uint target, [NativeTypeName("const GLdouble *")] double* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord2fARB([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLfloat")] float s, [NativeTypeName("GLfloat")] float t);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord2fvARB([NativeTypeName("GLenum")] uint target, [NativeTypeName("const GLfloat *")] float* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord2iARB([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLint")] int s, [NativeTypeName("GLint")] int t);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord2ivARB([NativeTypeName("GLenum")] uint target, [NativeTypeName("const GLint *")] int* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord2sARB([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLshort")] short s, [NativeTypeName("GLshort")] short t);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord2svARB([NativeTypeName("GLenum")] uint target, [NativeTypeName("const GLshort *")] short* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord3dARB([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLdouble")] double s, [NativeTypeName("GLdouble")] double t, [NativeTypeName("GLdouble")] double r);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord3dvARB([NativeTypeName("GLenum")] uint target, [NativeTypeName("const GLdouble *")] double* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord3fARB([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLfloat")] float s, [NativeTypeName("GLfloat")] float t, [NativeTypeName("GLfloat")] float r);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord3fvARB([NativeTypeName("GLenum")] uint target, [NativeTypeName("const GLfloat *")] float* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord3iARB([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLint")] int s, [NativeTypeName("GLint")] int t, [NativeTypeName("GLint")] int r);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord3ivARB([NativeTypeName("GLenum")] uint target, [NativeTypeName("const GLint *")] int* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord3sARB([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLshort")] short s, [NativeTypeName("GLshort")] short t, [NativeTypeName("GLshort")] short r);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord3svARB([NativeTypeName("GLenum")] uint target, [NativeTypeName("const GLshort *")] short* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord4dARB([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLdouble")] double s, [NativeTypeName("GLdouble")] double t, [NativeTypeName("GLdouble")] double r, [NativeTypeName("GLdouble")] double q);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord4dvARB([NativeTypeName("GLenum")] uint target, [NativeTypeName("const GLdouble *")] double* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord4fARB([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLfloat")] float s, [NativeTypeName("GLfloat")] float t, [NativeTypeName("GLfloat")] float r, [NativeTypeName("GLfloat")] float q);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord4fvARB([NativeTypeName("GLenum")] uint target, [NativeTypeName("const GLfloat *")] float* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord4iARB([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLint")] int s, [NativeTypeName("GLint")] int t, [NativeTypeName("GLint")] int r, [NativeTypeName("GLint")] int q);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord4ivARB([NativeTypeName("GLenum")] uint target, [NativeTypeName("const GLint *")] int* v);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord4sARB([NativeTypeName("GLenum")] uint target, [NativeTypeName("GLshort")] short s, [NativeTypeName("GLshort")] short t, [NativeTypeName("GLshort")] short r, [NativeTypeName("GLshort")] short q);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord4svARB([NativeTypeName("GLenum")] uint target, [NativeTypeName("const GLshort *")] short* v);

        [NativeTypeName("#define GL_VERSION_1_1 1")]
        public const int GL_VERSION_1_1 = 1;

        [NativeTypeName("#define GL_VERSION_1_2 1")]
        public const int GL_VERSION_1_2 = 1;

        [NativeTypeName("#define GL_VERSION_1_3 1")]
        public const int GL_VERSION_1_3 = 1;

        [NativeTypeName("#define GL_ARB_imaging 1")]
        public const int GL_ARB_imaging = 1;

        [NativeTypeName("#define GL_FALSE 0")]
        public const int GL_FALSE = 0;

        [NativeTypeName("#define GL_TRUE 1")]
        public const int GL_TRUE = 1;

        [NativeTypeName("#define GL_BYTE 0x1400")]
        public const int GL_BYTE = 0x1400;

        [NativeTypeName("#define GL_UNSIGNED_BYTE 0x1401")]
        public const int GL_UNSIGNED_BYTE = 0x1401;

        [NativeTypeName("#define GL_SHORT 0x1402")]
        public const int GL_SHORT = 0x1402;

        [NativeTypeName("#define GL_UNSIGNED_SHORT 0x1403")]
        public const int GL_UNSIGNED_SHORT = 0x1403;

        [NativeTypeName("#define GL_INT 0x1404")]
        public const int GL_INT = 0x1404;

        [NativeTypeName("#define GL_UNSIGNED_INT 0x1405")]
        public const int GL_UNSIGNED_INT = 0x1405;

        [NativeTypeName("#define GL_FLOAT 0x1406")]
        public const int GL_FLOAT = 0x1406;

        [NativeTypeName("#define GL_2_BYTES 0x1407")]
        public const int GL_2_BYTES = 0x1407;

        [NativeTypeName("#define GL_3_BYTES 0x1408")]
        public const int GL_3_BYTES = 0x1408;

        [NativeTypeName("#define GL_4_BYTES 0x1409")]
        public const int GL_4_BYTES = 0x1409;

        [NativeTypeName("#define GL_DOUBLE 0x140A")]
        public const int GL_DOUBLE = 0x140A;

        [NativeTypeName("#define GL_POINTS 0x0000")]
        public const int GL_POINTS = 0x0000;

        [NativeTypeName("#define GL_LINES 0x0001")]
        public const int GL_LINES = 0x0001;

        [NativeTypeName("#define GL_LINE_LOOP 0x0002")]
        public const int GL_LINE_LOOP = 0x0002;

        [NativeTypeName("#define GL_LINE_STRIP 0x0003")]
        public const int GL_LINE_STRIP = 0x0003;

        [NativeTypeName("#define GL_TRIANGLES 0x0004")]
        public const int GL_TRIANGLES = 0x0004;

        [NativeTypeName("#define GL_TRIANGLE_STRIP 0x0005")]
        public const int GL_TRIANGLE_STRIP = 0x0005;

        [NativeTypeName("#define GL_TRIANGLE_FAN 0x0006")]
        public const int GL_TRIANGLE_FAN = 0x0006;

        [NativeTypeName("#define GL_QUADS 0x0007")]
        public const int GL_QUADS = 0x0007;

        [NativeTypeName("#define GL_QUAD_STRIP 0x0008")]
        public const int GL_QUAD_STRIP = 0x0008;

        [NativeTypeName("#define GL_POLYGON 0x0009")]
        public const int GL_POLYGON = 0x0009;

        [NativeTypeName("#define GL_VERTEX_ARRAY 0x8074")]
        public const int GL_VERTEX_ARRAY = 0x8074;

        [NativeTypeName("#define GL_NORMAL_ARRAY 0x8075")]
        public const int GL_NORMAL_ARRAY = 0x8075;

        [NativeTypeName("#define GL_COLOR_ARRAY 0x8076")]
        public const int GL_COLOR_ARRAY = 0x8076;

        [NativeTypeName("#define GL_INDEX_ARRAY 0x8077")]
        public const int GL_INDEX_ARRAY = 0x8077;

        [NativeTypeName("#define GL_TEXTURE_COORD_ARRAY 0x8078")]
        public const int GL_TEXTURE_COORD_ARRAY = 0x8078;

        [NativeTypeName("#define GL_EDGE_FLAG_ARRAY 0x8079")]
        public const int GL_EDGE_FLAG_ARRAY = 0x8079;

        [NativeTypeName("#define GL_VERTEX_ARRAY_SIZE 0x807A")]
        public const int GL_VERTEX_ARRAY_SIZE = 0x807A;

        [NativeTypeName("#define GL_VERTEX_ARRAY_TYPE 0x807B")]
        public const int GL_VERTEX_ARRAY_TYPE = 0x807B;

        [NativeTypeName("#define GL_VERTEX_ARRAY_STRIDE 0x807C")]
        public const int GL_VERTEX_ARRAY_STRIDE = 0x807C;

        [NativeTypeName("#define GL_NORMAL_ARRAY_TYPE 0x807E")]
        public const int GL_NORMAL_ARRAY_TYPE = 0x807E;

        [NativeTypeName("#define GL_NORMAL_ARRAY_STRIDE 0x807F")]
        public const int GL_NORMAL_ARRAY_STRIDE = 0x807F;

        [NativeTypeName("#define GL_COLOR_ARRAY_SIZE 0x8081")]
        public const int GL_COLOR_ARRAY_SIZE = 0x8081;

        [NativeTypeName("#define GL_COLOR_ARRAY_TYPE 0x8082")]
        public const int GL_COLOR_ARRAY_TYPE = 0x8082;

        [NativeTypeName("#define GL_COLOR_ARRAY_STRIDE 0x8083")]
        public const int GL_COLOR_ARRAY_STRIDE = 0x8083;

        [NativeTypeName("#define GL_INDEX_ARRAY_TYPE 0x8085")]
        public const int GL_INDEX_ARRAY_TYPE = 0x8085;

        [NativeTypeName("#define GL_INDEX_ARRAY_STRIDE 0x8086")]
        public const int GL_INDEX_ARRAY_STRIDE = 0x8086;

        [NativeTypeName("#define GL_TEXTURE_COORD_ARRAY_SIZE 0x8088")]
        public const int GL_TEXTURE_COORD_ARRAY_SIZE = 0x8088;

        [NativeTypeName("#define GL_TEXTURE_COORD_ARRAY_TYPE 0x8089")]
        public const int GL_TEXTURE_COORD_ARRAY_TYPE = 0x8089;

        [NativeTypeName("#define GL_TEXTURE_COORD_ARRAY_STRIDE 0x808A")]
        public const int GL_TEXTURE_COORD_ARRAY_STRIDE = 0x808A;

        [NativeTypeName("#define GL_EDGE_FLAG_ARRAY_STRIDE 0x808C")]
        public const int GL_EDGE_FLAG_ARRAY_STRIDE = 0x808C;

        [NativeTypeName("#define GL_VERTEX_ARRAY_POINTER 0x808E")]
        public const int GL_VERTEX_ARRAY_POINTER = 0x808E;

        [NativeTypeName("#define GL_NORMAL_ARRAY_POINTER 0x808F")]
        public const int GL_NORMAL_ARRAY_POINTER = 0x808F;

        [NativeTypeName("#define GL_COLOR_ARRAY_POINTER 0x8090")]
        public const int GL_COLOR_ARRAY_POINTER = 0x8090;

        [NativeTypeName("#define GL_INDEX_ARRAY_POINTER 0x8091")]
        public const int GL_INDEX_ARRAY_POINTER = 0x8091;

        [NativeTypeName("#define GL_TEXTURE_COORD_ARRAY_POINTER 0x8092")]
        public const int GL_TEXTURE_COORD_ARRAY_POINTER = 0x8092;

        [NativeTypeName("#define GL_EDGE_FLAG_ARRAY_POINTER 0x8093")]
        public const int GL_EDGE_FLAG_ARRAY_POINTER = 0x8093;

        [NativeTypeName("#define GL_V2F 0x2A20")]
        public const int GL_V2F = 0x2A20;

        [NativeTypeName("#define GL_V3F 0x2A21")]
        public const int GL_V3F = 0x2A21;

        [NativeTypeName("#define GL_C4UB_V2F 0x2A22")]
        public const int GL_C4UB_V2F = 0x2A22;

        [NativeTypeName("#define GL_C4UB_V3F 0x2A23")]
        public const int GL_C4UB_V3F = 0x2A23;

        [NativeTypeName("#define GL_C3F_V3F 0x2A24")]
        public const int GL_C3F_V3F = 0x2A24;

        [NativeTypeName("#define GL_N3F_V3F 0x2A25")]
        public const int GL_N3F_V3F = 0x2A25;

        [NativeTypeName("#define GL_C4F_N3F_V3F 0x2A26")]
        public const int GL_C4F_N3F_V3F = 0x2A26;

        [NativeTypeName("#define GL_T2F_V3F 0x2A27")]
        public const int GL_T2F_V3F = 0x2A27;

        [NativeTypeName("#define GL_T4F_V4F 0x2A28")]
        public const int GL_T4F_V4F = 0x2A28;

        [NativeTypeName("#define GL_T2F_C4UB_V3F 0x2A29")]
        public const int GL_T2F_C4UB_V3F = 0x2A29;

        [NativeTypeName("#define GL_T2F_C3F_V3F 0x2A2A")]
        public const int GL_T2F_C3F_V3F = 0x2A2A;

        [NativeTypeName("#define GL_T2F_N3F_V3F 0x2A2B")]
        public const int GL_T2F_N3F_V3F = 0x2A2B;

        [NativeTypeName("#define GL_T2F_C4F_N3F_V3F 0x2A2C")]
        public const int GL_T2F_C4F_N3F_V3F = 0x2A2C;

        [NativeTypeName("#define GL_T4F_C4F_N3F_V4F 0x2A2D")]
        public const int GL_T4F_C4F_N3F_V4F = 0x2A2D;

        [NativeTypeName("#define GL_MATRIX_MODE 0x0BA0")]
        public const int GL_MATRIX_MODE = 0x0BA0;

        [NativeTypeName("#define GL_MODELVIEW 0x1700")]
        public const int GL_MODELVIEW = 0x1700;

        [NativeTypeName("#define GL_PROJECTION 0x1701")]
        public const int GL_PROJECTION = 0x1701;

        [NativeTypeName("#define GL_TEXTURE 0x1702")]
        public const int GL_TEXTURE = 0x1702;

        [NativeTypeName("#define GL_POINT_SMOOTH 0x0B10")]
        public const int GL_POINT_SMOOTH = 0x0B10;

        [NativeTypeName("#define GL_POINT_SIZE 0x0B11")]
        public const int GL_POINT_SIZE = 0x0B11;

        [NativeTypeName("#define GL_POINT_SIZE_GRANULARITY 0x0B13")]
        public const int GL_POINT_SIZE_GRANULARITY = 0x0B13;

        [NativeTypeName("#define GL_POINT_SIZE_RANGE 0x0B12")]
        public const int GL_POINT_SIZE_RANGE = 0x0B12;

        [NativeTypeName("#define GL_LINE_SMOOTH 0x0B20")]
        public const int GL_LINE_SMOOTH = 0x0B20;

        [NativeTypeName("#define GL_LINE_STIPPLE 0x0B24")]
        public const int GL_LINE_STIPPLE = 0x0B24;

        [NativeTypeName("#define GL_LINE_STIPPLE_PATTERN 0x0B25")]
        public const int GL_LINE_STIPPLE_PATTERN = 0x0B25;

        [NativeTypeName("#define GL_LINE_STIPPLE_REPEAT 0x0B26")]
        public const int GL_LINE_STIPPLE_REPEAT = 0x0B26;

        [NativeTypeName("#define GL_LINE_WIDTH 0x0B21")]
        public const int GL_LINE_WIDTH = 0x0B21;

        [NativeTypeName("#define GL_LINE_WIDTH_GRANULARITY 0x0B23")]
        public const int GL_LINE_WIDTH_GRANULARITY = 0x0B23;

        [NativeTypeName("#define GL_LINE_WIDTH_RANGE 0x0B22")]
        public const int GL_LINE_WIDTH_RANGE = 0x0B22;

        [NativeTypeName("#define GL_POINT 0x1B00")]
        public const int GL_POINT = 0x1B00;

        [NativeTypeName("#define GL_LINE 0x1B01")]
        public const int GL_LINE = 0x1B01;

        [NativeTypeName("#define GL_FILL 0x1B02")]
        public const int GL_FILL = 0x1B02;

        [NativeTypeName("#define GL_CW 0x0900")]
        public const int GL_CW = 0x0900;

        [NativeTypeName("#define GL_CCW 0x0901")]
        public const int GL_CCW = 0x0901;

        [NativeTypeName("#define GL_FRONT 0x0404")]
        public const int GL_FRONT = 0x0404;

        [NativeTypeName("#define GL_BACK 0x0405")]
        public const int GL_BACK = 0x0405;

        [NativeTypeName("#define GL_POLYGON_MODE 0x0B40")]
        public const int GL_POLYGON_MODE = 0x0B40;

        [NativeTypeName("#define GL_POLYGON_SMOOTH 0x0B41")]
        public const int GL_POLYGON_SMOOTH = 0x0B41;

        [NativeTypeName("#define GL_POLYGON_STIPPLE 0x0B42")]
        public const int GL_POLYGON_STIPPLE = 0x0B42;

        [NativeTypeName("#define GL_EDGE_FLAG 0x0B43")]
        public const int GL_EDGE_FLAG = 0x0B43;

        [NativeTypeName("#define GL_CULL_FACE 0x0B44")]
        public const int GL_CULL_FACE = 0x0B44;

        [NativeTypeName("#define GL_CULL_FACE_MODE 0x0B45")]
        public const int GL_CULL_FACE_MODE = 0x0B45;

        [NativeTypeName("#define GL_FRONT_FACE 0x0B46")]
        public const int GL_FRONT_FACE = 0x0B46;

        [NativeTypeName("#define GL_POLYGON_OFFSET_FACTOR 0x8038")]
        public const int GL_POLYGON_OFFSET_FACTOR = 0x8038;

        [NativeTypeName("#define GL_POLYGON_OFFSET_UNITS 0x2A00")]
        public const int GL_POLYGON_OFFSET_UNITS = 0x2A00;

        [NativeTypeName("#define GL_POLYGON_OFFSET_POINT 0x2A01")]
        public const int GL_POLYGON_OFFSET_POINT = 0x2A01;

        [NativeTypeName("#define GL_POLYGON_OFFSET_LINE 0x2A02")]
        public const int GL_POLYGON_OFFSET_LINE = 0x2A02;

        [NativeTypeName("#define GL_POLYGON_OFFSET_FILL 0x8037")]
        public const int GL_POLYGON_OFFSET_FILL = 0x8037;

        [NativeTypeName("#define GL_COMPILE 0x1300")]
        public const int GL_COMPILE = 0x1300;

        [NativeTypeName("#define GL_COMPILE_AND_EXECUTE 0x1301")]
        public const int GL_COMPILE_AND_EXECUTE = 0x1301;

        [NativeTypeName("#define GL_LIST_BASE 0x0B32")]
        public const int GL_LIST_BASE = 0x0B32;

        [NativeTypeName("#define GL_LIST_INDEX 0x0B33")]
        public const int GL_LIST_INDEX = 0x0B33;

        [NativeTypeName("#define GL_LIST_MODE 0x0B30")]
        public const int GL_LIST_MODE = 0x0B30;

        [NativeTypeName("#define GL_NEVER 0x0200")]
        public const int GL_NEVER = 0x0200;

        [NativeTypeName("#define GL_LESS 0x0201")]
        public const int GL_LESS = 0x0201;

        [NativeTypeName("#define GL_EQUAL 0x0202")]
        public const int GL_EQUAL = 0x0202;

        [NativeTypeName("#define GL_LEQUAL 0x0203")]
        public const int GL_LEQUAL = 0x0203;

        [NativeTypeName("#define GL_GREATER 0x0204")]
        public const int GL_GREATER = 0x0204;

        [NativeTypeName("#define GL_NOTEQUAL 0x0205")]
        public const int GL_NOTEQUAL = 0x0205;

        [NativeTypeName("#define GL_GEQUAL 0x0206")]
        public const int GL_GEQUAL = 0x0206;

        [NativeTypeName("#define GL_ALWAYS 0x0207")]
        public const int GL_ALWAYS = 0x0207;

        [NativeTypeName("#define GL_DEPTH_TEST 0x0B71")]
        public const int GL_DEPTH_TEST = 0x0B71;

        [NativeTypeName("#define GL_DEPTH_BITS 0x0D56")]
        public const int GL_DEPTH_BITS = 0x0D56;

        [NativeTypeName("#define GL_DEPTH_CLEAR_VALUE 0x0B73")]
        public const int GL_DEPTH_CLEAR_VALUE = 0x0B73;

        [NativeTypeName("#define GL_DEPTH_FUNC 0x0B74")]
        public const int GL_DEPTH_FUNC = 0x0B74;

        [NativeTypeName("#define GL_DEPTH_RANGE 0x0B70")]
        public const int GL_DEPTH_RANGE = 0x0B70;

        [NativeTypeName("#define GL_DEPTH_WRITEMASK 0x0B72")]
        public const int GL_DEPTH_WRITEMASK = 0x0B72;

        [NativeTypeName("#define GL_DEPTH_COMPONENT 0x1902")]
        public const int GL_DEPTH_COMPONENT = 0x1902;

        [NativeTypeName("#define GL_LIGHTING 0x0B50")]
        public const int GL_LIGHTING = 0x0B50;

        [NativeTypeName("#define GL_LIGHT0 0x4000")]
        public const int GL_LIGHT0 = 0x4000;

        [NativeTypeName("#define GL_LIGHT1 0x4001")]
        public const int GL_LIGHT1 = 0x4001;

        [NativeTypeName("#define GL_LIGHT2 0x4002")]
        public const int GL_LIGHT2 = 0x4002;

        [NativeTypeName("#define GL_LIGHT3 0x4003")]
        public const int GL_LIGHT3 = 0x4003;

        [NativeTypeName("#define GL_LIGHT4 0x4004")]
        public const int GL_LIGHT4 = 0x4004;

        [NativeTypeName("#define GL_LIGHT5 0x4005")]
        public const int GL_LIGHT5 = 0x4005;

        [NativeTypeName("#define GL_LIGHT6 0x4006")]
        public const int GL_LIGHT6 = 0x4006;

        [NativeTypeName("#define GL_LIGHT7 0x4007")]
        public const int GL_LIGHT7 = 0x4007;

        [NativeTypeName("#define GL_SPOT_EXPONENT 0x1205")]
        public const int GL_SPOT_EXPONENT = 0x1205;

        [NativeTypeName("#define GL_SPOT_CUTOFF 0x1206")]
        public const int GL_SPOT_CUTOFF = 0x1206;

        [NativeTypeName("#define GL_CONSTANT_ATTENUATION 0x1207")]
        public const int GL_CONSTANT_ATTENUATION = 0x1207;

        [NativeTypeName("#define GL_LINEAR_ATTENUATION 0x1208")]
        public const int GL_LINEAR_ATTENUATION = 0x1208;

        [NativeTypeName("#define GL_QUADRATIC_ATTENUATION 0x1209")]
        public const int GL_QUADRATIC_ATTENUATION = 0x1209;

        [NativeTypeName("#define GL_AMBIENT 0x1200")]
        public const int GL_AMBIENT = 0x1200;

        [NativeTypeName("#define GL_DIFFUSE 0x1201")]
        public const int GL_DIFFUSE = 0x1201;

        [NativeTypeName("#define GL_SPECULAR 0x1202")]
        public const int GL_SPECULAR = 0x1202;

        [NativeTypeName("#define GL_SHININESS 0x1601")]
        public const int GL_SHININESS = 0x1601;

        [NativeTypeName("#define GL_EMISSION 0x1600")]
        public const int GL_EMISSION = 0x1600;

        [NativeTypeName("#define GL_POSITION 0x1203")]
        public const int GL_POSITION = 0x1203;

        [NativeTypeName("#define GL_SPOT_DIRECTION 0x1204")]
        public const int GL_SPOT_DIRECTION = 0x1204;

        [NativeTypeName("#define GL_AMBIENT_AND_DIFFUSE 0x1602")]
        public const int GL_AMBIENT_AND_DIFFUSE = 0x1602;

        [NativeTypeName("#define GL_COLOR_INDEXES 0x1603")]
        public const int GL_COLOR_INDEXES = 0x1603;

        [NativeTypeName("#define GL_LIGHT_MODEL_TWO_SIDE 0x0B52")]
        public const int GL_LIGHT_MODEL_TWO_SIDE = 0x0B52;

        [NativeTypeName("#define GL_LIGHT_MODEL_LOCAL_VIEWER 0x0B51")]
        public const int GL_LIGHT_MODEL_LOCAL_VIEWER = 0x0B51;

        [NativeTypeName("#define GL_LIGHT_MODEL_AMBIENT 0x0B53")]
        public const int GL_LIGHT_MODEL_AMBIENT = 0x0B53;

        [NativeTypeName("#define GL_FRONT_AND_BACK 0x0408")]
        public const int GL_FRONT_AND_BACK = 0x0408;

        [NativeTypeName("#define GL_SHADE_MODEL 0x0B54")]
        public const int GL_SHADE_MODEL = 0x0B54;

        [NativeTypeName("#define GL_FLAT 0x1D00")]
        public const int GL_FLAT = 0x1D00;

        [NativeTypeName("#define GL_SMOOTH 0x1D01")]
        public const int GL_SMOOTH = 0x1D01;

        [NativeTypeName("#define GL_COLOR_MATERIAL 0x0B57")]
        public const int GL_COLOR_MATERIAL = 0x0B57;

        [NativeTypeName("#define GL_COLOR_MATERIAL_FACE 0x0B55")]
        public const int GL_COLOR_MATERIAL_FACE = 0x0B55;

        [NativeTypeName("#define GL_COLOR_MATERIAL_PARAMETER 0x0B56")]
        public const int GL_COLOR_MATERIAL_PARAMETER = 0x0B56;

        [NativeTypeName("#define GL_NORMALIZE 0x0BA1")]
        public const int GL_NORMALIZE = 0x0BA1;

        [NativeTypeName("#define GL_CLIP_PLANE0 0x3000")]
        public const int GL_CLIP_PLANE0 = 0x3000;

        [NativeTypeName("#define GL_CLIP_PLANE1 0x3001")]
        public const int GL_CLIP_PLANE1 = 0x3001;

        [NativeTypeName("#define GL_CLIP_PLANE2 0x3002")]
        public const int GL_CLIP_PLANE2 = 0x3002;

        [NativeTypeName("#define GL_CLIP_PLANE3 0x3003")]
        public const int GL_CLIP_PLANE3 = 0x3003;

        [NativeTypeName("#define GL_CLIP_PLANE4 0x3004")]
        public const int GL_CLIP_PLANE4 = 0x3004;

        [NativeTypeName("#define GL_CLIP_PLANE5 0x3005")]
        public const int GL_CLIP_PLANE5 = 0x3005;

        [NativeTypeName("#define GL_ACCUM_RED_BITS 0x0D58")]
        public const int GL_ACCUM_RED_BITS = 0x0D58;

        [NativeTypeName("#define GL_ACCUM_GREEN_BITS 0x0D59")]
        public const int GL_ACCUM_GREEN_BITS = 0x0D59;

        [NativeTypeName("#define GL_ACCUM_BLUE_BITS 0x0D5A")]
        public const int GL_ACCUM_BLUE_BITS = 0x0D5A;

        [NativeTypeName("#define GL_ACCUM_ALPHA_BITS 0x0D5B")]
        public const int GL_ACCUM_ALPHA_BITS = 0x0D5B;

        [NativeTypeName("#define GL_ACCUM_CLEAR_VALUE 0x0B80")]
        public const int GL_ACCUM_CLEAR_VALUE = 0x0B80;

        [NativeTypeName("#define GL_ACCUM 0x0100")]
        public const int GL_ACCUM = 0x0100;

        [NativeTypeName("#define GL_ADD 0x0104")]
        public const int GL_ADD = 0x0104;

        [NativeTypeName("#define GL_LOAD 0x0101")]
        public const int GL_LOAD = 0x0101;

        [NativeTypeName("#define GL_MULT 0x0103")]
        public const int GL_MULT = 0x0103;

        [NativeTypeName("#define GL_RETURN 0x0102")]
        public const int GL_RETURN = 0x0102;

        [NativeTypeName("#define GL_ALPHA_TEST 0x0BC0")]
        public const int GL_ALPHA_TEST = 0x0BC0;

        [NativeTypeName("#define GL_ALPHA_TEST_REF 0x0BC2")]
        public const int GL_ALPHA_TEST_REF = 0x0BC2;

        [NativeTypeName("#define GL_ALPHA_TEST_FUNC 0x0BC1")]
        public const int GL_ALPHA_TEST_FUNC = 0x0BC1;

        [NativeTypeName("#define GL_BLEND 0x0BE2")]
        public const int GL_BLEND = 0x0BE2;

        [NativeTypeName("#define GL_BLEND_SRC 0x0BE1")]
        public const int GL_BLEND_SRC = 0x0BE1;

        [NativeTypeName("#define GL_BLEND_DST 0x0BE0")]
        public const int GL_BLEND_DST = 0x0BE0;

        [NativeTypeName("#define GL_ZERO 0")]
        public const int GL_ZERO = 0;

        [NativeTypeName("#define GL_ONE 1")]
        public const int GL_ONE = 1;

        [NativeTypeName("#define GL_SRC_COLOR 0x0300")]
        public const int GL_SRC_COLOR = 0x0300;

        [NativeTypeName("#define GL_ONE_MINUS_SRC_COLOR 0x0301")]
        public const int GL_ONE_MINUS_SRC_COLOR = 0x0301;

        [NativeTypeName("#define GL_SRC_ALPHA 0x0302")]
        public const int GL_SRC_ALPHA = 0x0302;

        [NativeTypeName("#define GL_ONE_MINUS_SRC_ALPHA 0x0303")]
        public const int GL_ONE_MINUS_SRC_ALPHA = 0x0303;

        [NativeTypeName("#define GL_DST_ALPHA 0x0304")]
        public const int GL_DST_ALPHA = 0x0304;

        [NativeTypeName("#define GL_ONE_MINUS_DST_ALPHA 0x0305")]
        public const int GL_ONE_MINUS_DST_ALPHA = 0x0305;

        [NativeTypeName("#define GL_DST_COLOR 0x0306")]
        public const int GL_DST_COLOR = 0x0306;

        [NativeTypeName("#define GL_ONE_MINUS_DST_COLOR 0x0307")]
        public const int GL_ONE_MINUS_DST_COLOR = 0x0307;

        [NativeTypeName("#define GL_SRC_ALPHA_SATURATE 0x0308")]
        public const int GL_SRC_ALPHA_SATURATE = 0x0308;

        [NativeTypeName("#define GL_FEEDBACK 0x1C01")]
        public const int GL_FEEDBACK = 0x1C01;

        [NativeTypeName("#define GL_RENDER 0x1C00")]
        public const int GL_RENDER = 0x1C00;

        [NativeTypeName("#define GL_SELECT 0x1C02")]
        public const int GL_SELECT = 0x1C02;

        [NativeTypeName("#define GL_2D 0x0600")]
        public const int GL_2D = 0x0600;

        [NativeTypeName("#define GL_3D 0x0601")]
        public const int GL_3D = 0x0601;

        [NativeTypeName("#define GL_3D_COLOR 0x0602")]
        public const int GL_3D_COLOR = 0x0602;

        [NativeTypeName("#define GL_3D_COLOR_TEXTURE 0x0603")]
        public const int GL_3D_COLOR_TEXTURE = 0x0603;

        [NativeTypeName("#define GL_4D_COLOR_TEXTURE 0x0604")]
        public const int GL_4D_COLOR_TEXTURE = 0x0604;

        [NativeTypeName("#define GL_POINT_TOKEN 0x0701")]
        public const int GL_POINT_TOKEN = 0x0701;

        [NativeTypeName("#define GL_LINE_TOKEN 0x0702")]
        public const int GL_LINE_TOKEN = 0x0702;

        [NativeTypeName("#define GL_LINE_RESET_TOKEN 0x0707")]
        public const int GL_LINE_RESET_TOKEN = 0x0707;

        [NativeTypeName("#define GL_POLYGON_TOKEN 0x0703")]
        public const int GL_POLYGON_TOKEN = 0x0703;

        [NativeTypeName("#define GL_BITMAP_TOKEN 0x0704")]
        public const int GL_BITMAP_TOKEN = 0x0704;

        [NativeTypeName("#define GL_DRAW_PIXEL_TOKEN 0x0705")]
        public const int GL_DRAW_PIXEL_TOKEN = 0x0705;

        [NativeTypeName("#define GL_COPY_PIXEL_TOKEN 0x0706")]
        public const int GL_COPY_PIXEL_TOKEN = 0x0706;

        [NativeTypeName("#define GL_PASS_THROUGH_TOKEN 0x0700")]
        public const int GL_PASS_THROUGH_TOKEN = 0x0700;

        [NativeTypeName("#define GL_FEEDBACK_BUFFER_POINTER 0x0DF0")]
        public const int GL_FEEDBACK_BUFFER_POINTER = 0x0DF0;

        [NativeTypeName("#define GL_FEEDBACK_BUFFER_SIZE 0x0DF1")]
        public const int GL_FEEDBACK_BUFFER_SIZE = 0x0DF1;

        [NativeTypeName("#define GL_FEEDBACK_BUFFER_TYPE 0x0DF2")]
        public const int GL_FEEDBACK_BUFFER_TYPE = 0x0DF2;

        [NativeTypeName("#define GL_SELECTION_BUFFER_POINTER 0x0DF3")]
        public const int GL_SELECTION_BUFFER_POINTER = 0x0DF3;

        [NativeTypeName("#define GL_SELECTION_BUFFER_SIZE 0x0DF4")]
        public const int GL_SELECTION_BUFFER_SIZE = 0x0DF4;

        [NativeTypeName("#define GL_FOG 0x0B60")]
        public const int GL_FOG = 0x0B60;

        [NativeTypeName("#define GL_FOG_MODE 0x0B65")]
        public const int GL_FOG_MODE = 0x0B65;

        [NativeTypeName("#define GL_FOG_DENSITY 0x0B62")]
        public const int GL_FOG_DENSITY = 0x0B62;

        [NativeTypeName("#define GL_FOG_COLOR 0x0B66")]
        public const int GL_FOG_COLOR = 0x0B66;

        [NativeTypeName("#define GL_FOG_INDEX 0x0B61")]
        public const int GL_FOG_INDEX = 0x0B61;

        [NativeTypeName("#define GL_FOG_START 0x0B63")]
        public const int GL_FOG_START = 0x0B63;

        [NativeTypeName("#define GL_FOG_END 0x0B64")]
        public const int GL_FOG_END = 0x0B64;

        [NativeTypeName("#define GL_LINEAR 0x2601")]
        public const int GL_LINEAR = 0x2601;

        [NativeTypeName("#define GL_EXP 0x0800")]
        public const int GL_EXP = 0x0800;

        [NativeTypeName("#define GL_EXP2 0x0801")]
        public const int GL_EXP2 = 0x0801;

        [NativeTypeName("#define GL_LOGIC_OP 0x0BF1")]
        public const int GL_LOGIC_OP = 0x0BF1;

        [NativeTypeName("#define GL_INDEX_LOGIC_OP 0x0BF1")]
        public const int GL_INDEX_LOGIC_OP = 0x0BF1;

        [NativeTypeName("#define GL_COLOR_LOGIC_OP 0x0BF2")]
        public const int GL_COLOR_LOGIC_OP = 0x0BF2;

        [NativeTypeName("#define GL_LOGIC_OP_MODE 0x0BF0")]
        public const int GL_LOGIC_OP_MODE = 0x0BF0;

        [NativeTypeName("#define GL_CLEAR 0x1500")]
        public const int GL_CLEAR = 0x1500;

        [NativeTypeName("#define GL_SET 0x150F")]
        public const int GL_SET = 0x150F;

        [NativeTypeName("#define GL_COPY 0x1503")]
        public const int GL_COPY = 0x1503;

        [NativeTypeName("#define GL_COPY_INVERTED 0x150C")]
        public const int GL_COPY_INVERTED = 0x150C;

        [NativeTypeName("#define GL_NOOP 0x1505")]
        public const int GL_NOOP = 0x1505;

        [NativeTypeName("#define GL_INVERT 0x150A")]
        public const int GL_INVERT = 0x150A;

        [NativeTypeName("#define GL_AND 0x1501")]
        public const int GL_AND = 0x1501;

        [NativeTypeName("#define GL_NAND 0x150E")]
        public const int GL_NAND = 0x150E;

        [NativeTypeName("#define GL_OR 0x1507")]
        public const int GL_OR = 0x1507;

        [NativeTypeName("#define GL_NOR 0x1508")]
        public const int GL_NOR = 0x1508;

        [NativeTypeName("#define GL_XOR 0x1506")]
        public const int GL_XOR = 0x1506;

        [NativeTypeName("#define GL_EQUIV 0x1509")]
        public const int GL_EQUIV = 0x1509;

        [NativeTypeName("#define GL_AND_REVERSE 0x1502")]
        public const int GL_AND_REVERSE = 0x1502;

        [NativeTypeName("#define GL_AND_INVERTED 0x1504")]
        public const int GL_AND_INVERTED = 0x1504;

        [NativeTypeName("#define GL_OR_REVERSE 0x150B")]
        public const int GL_OR_REVERSE = 0x150B;

        [NativeTypeName("#define GL_OR_INVERTED 0x150D")]
        public const int GL_OR_INVERTED = 0x150D;

        [NativeTypeName("#define GL_STENCIL_BITS 0x0D57")]
        public const int GL_STENCIL_BITS = 0x0D57;

        [NativeTypeName("#define GL_STENCIL_TEST 0x0B90")]
        public const int GL_STENCIL_TEST = 0x0B90;

        [NativeTypeName("#define GL_STENCIL_CLEAR_VALUE 0x0B91")]
        public const int GL_STENCIL_CLEAR_VALUE = 0x0B91;

        [NativeTypeName("#define GL_STENCIL_FUNC 0x0B92")]
        public const int GL_STENCIL_FUNC = 0x0B92;

        [NativeTypeName("#define GL_STENCIL_VALUE_MASK 0x0B93")]
        public const int GL_STENCIL_VALUE_MASK = 0x0B93;

        [NativeTypeName("#define GL_STENCIL_FAIL 0x0B94")]
        public const int GL_STENCIL_FAIL = 0x0B94;

        [NativeTypeName("#define GL_STENCIL_PASS_DEPTH_FAIL 0x0B95")]
        public const int GL_STENCIL_PASS_DEPTH_FAIL = 0x0B95;

        [NativeTypeName("#define GL_STENCIL_PASS_DEPTH_PASS 0x0B96")]
        public const int GL_STENCIL_PASS_DEPTH_PASS = 0x0B96;

        [NativeTypeName("#define GL_STENCIL_REF 0x0B97")]
        public const int GL_STENCIL_REF = 0x0B97;

        [NativeTypeName("#define GL_STENCIL_WRITEMASK 0x0B98")]
        public const int GL_STENCIL_WRITEMASK = 0x0B98;

        [NativeTypeName("#define GL_STENCIL_INDEX 0x1901")]
        public const int GL_STENCIL_INDEX = 0x1901;

        [NativeTypeName("#define GL_KEEP 0x1E00")]
        public const int GL_KEEP = 0x1E00;

        [NativeTypeName("#define GL_REPLACE 0x1E01")]
        public const int GL_REPLACE = 0x1E01;

        [NativeTypeName("#define GL_INCR 0x1E02")]
        public const int GL_INCR = 0x1E02;

        [NativeTypeName("#define GL_DECR 0x1E03")]
        public const int GL_DECR = 0x1E03;

        [NativeTypeName("#define GL_NONE 0")]
        public const int GL_NONE = 0;

        [NativeTypeName("#define GL_LEFT 0x0406")]
        public const int GL_LEFT = 0x0406;

        [NativeTypeName("#define GL_RIGHT 0x0407")]
        public const int GL_RIGHT = 0x0407;

        [NativeTypeName("#define GL_FRONT_LEFT 0x0400")]
        public const int GL_FRONT_LEFT = 0x0400;

        [NativeTypeName("#define GL_FRONT_RIGHT 0x0401")]
        public const int GL_FRONT_RIGHT = 0x0401;

        [NativeTypeName("#define GL_BACK_LEFT 0x0402")]
        public const int GL_BACK_LEFT = 0x0402;

        [NativeTypeName("#define GL_BACK_RIGHT 0x0403")]
        public const int GL_BACK_RIGHT = 0x0403;

        [NativeTypeName("#define GL_AUX0 0x0409")]
        public const int GL_AUX0 = 0x0409;

        [NativeTypeName("#define GL_AUX1 0x040A")]
        public const int GL_AUX1 = 0x040A;

        [NativeTypeName("#define GL_AUX2 0x040B")]
        public const int GL_AUX2 = 0x040B;

        [NativeTypeName("#define GL_AUX3 0x040C")]
        public const int GL_AUX3 = 0x040C;

        [NativeTypeName("#define GL_COLOR_INDEX 0x1900")]
        public const int GL_COLOR_INDEX = 0x1900;

        [NativeTypeName("#define GL_RED 0x1903")]
        public const int GL_RED = 0x1903;

        [NativeTypeName("#define GL_GREEN 0x1904")]
        public const int GL_GREEN = 0x1904;

        [NativeTypeName("#define GL_BLUE 0x1905")]
        public const int GL_BLUE = 0x1905;

        [NativeTypeName("#define GL_ALPHA 0x1906")]
        public const int GL_ALPHA = 0x1906;

        [NativeTypeName("#define GL_LUMINANCE 0x1909")]
        public const int GL_LUMINANCE = 0x1909;

        [NativeTypeName("#define GL_LUMINANCE_ALPHA 0x190A")]
        public const int GL_LUMINANCE_ALPHA = 0x190A;

        [NativeTypeName("#define GL_ALPHA_BITS 0x0D55")]
        public const int GL_ALPHA_BITS = 0x0D55;

        [NativeTypeName("#define GL_RED_BITS 0x0D52")]
        public const int GL_RED_BITS = 0x0D52;

        [NativeTypeName("#define GL_GREEN_BITS 0x0D53")]
        public const int GL_GREEN_BITS = 0x0D53;

        [NativeTypeName("#define GL_BLUE_BITS 0x0D54")]
        public const int GL_BLUE_BITS = 0x0D54;

        [NativeTypeName("#define GL_INDEX_BITS 0x0D51")]
        public const int GL_INDEX_BITS = 0x0D51;

        [NativeTypeName("#define GL_SUBPIXEL_BITS 0x0D50")]
        public const int GL_SUBPIXEL_BITS = 0x0D50;

        [NativeTypeName("#define GL_AUX_BUFFERS 0x0C00")]
        public const int GL_AUX_BUFFERS = 0x0C00;

        [NativeTypeName("#define GL_READ_BUFFER 0x0C02")]
        public const int GL_READ_BUFFER = 0x0C02;

        [NativeTypeName("#define GL_DRAW_BUFFER 0x0C01")]
        public const int GL_DRAW_BUFFER = 0x0C01;

        [NativeTypeName("#define GL_DOUBLEBUFFER 0x0C32")]
        public const int GL_DOUBLEBUFFER = 0x0C32;

        [NativeTypeName("#define GL_STEREO 0x0C33")]
        public const int GL_STEREO = 0x0C33;

        [NativeTypeName("#define GL_BITMAP 0x1A00")]
        public const int GL_BITMAP = 0x1A00;

        [NativeTypeName("#define GL_COLOR 0x1800")]
        public const int GL_COLOR = 0x1800;

        [NativeTypeName("#define GL_DEPTH 0x1801")]
        public const int GL_DEPTH = 0x1801;

        [NativeTypeName("#define GL_STENCIL 0x1802")]
        public const int GL_STENCIL = 0x1802;

        [NativeTypeName("#define GL_DITHER 0x0BD0")]
        public const int GL_DITHER = 0x0BD0;

        [NativeTypeName("#define GL_RGB 0x1907")]
        public const int GL_RGB = 0x1907;

        [NativeTypeName("#define GL_RGBA 0x1908")]
        public const int GL_RGBA = 0x1908;

        [NativeTypeName("#define GL_MAX_LIST_NESTING 0x0B31")]
        public const int GL_MAX_LIST_NESTING = 0x0B31;

        [NativeTypeName("#define GL_MAX_EVAL_ORDER 0x0D30")]
        public const int GL_MAX_EVAL_ORDER = 0x0D30;

        [NativeTypeName("#define GL_MAX_LIGHTS 0x0D31")]
        public const int GL_MAX_LIGHTS = 0x0D31;

        [NativeTypeName("#define GL_MAX_CLIP_PLANES 0x0D32")]
        public const int GL_MAX_CLIP_PLANES = 0x0D32;

        [NativeTypeName("#define GL_MAX_TEXTURE_SIZE 0x0D33")]
        public const int GL_MAX_TEXTURE_SIZE = 0x0D33;

        [NativeTypeName("#define GL_MAX_PIXEL_MAP_TABLE 0x0D34")]
        public const int GL_MAX_PIXEL_MAP_TABLE = 0x0D34;

        [NativeTypeName("#define GL_MAX_ATTRIB_STACK_DEPTH 0x0D35")]
        public const int GL_MAX_ATTRIB_STACK_DEPTH = 0x0D35;

        [NativeTypeName("#define GL_MAX_MODELVIEW_STACK_DEPTH 0x0D36")]
        public const int GL_MAX_MODELVIEW_STACK_DEPTH = 0x0D36;

        [NativeTypeName("#define GL_MAX_NAME_STACK_DEPTH 0x0D37")]
        public const int GL_MAX_NAME_STACK_DEPTH = 0x0D37;

        [NativeTypeName("#define GL_MAX_PROJECTION_STACK_DEPTH 0x0D38")]
        public const int GL_MAX_PROJECTION_STACK_DEPTH = 0x0D38;

        [NativeTypeName("#define GL_MAX_TEXTURE_STACK_DEPTH 0x0D39")]
        public const int GL_MAX_TEXTURE_STACK_DEPTH = 0x0D39;

        [NativeTypeName("#define GL_MAX_VIEWPORT_DIMS 0x0D3A")]
        public const int GL_MAX_VIEWPORT_DIMS = 0x0D3A;

        [NativeTypeName("#define GL_MAX_CLIENT_ATTRIB_STACK_DEPTH 0x0D3B")]
        public const int GL_MAX_CLIENT_ATTRIB_STACK_DEPTH = 0x0D3B;

        [NativeTypeName("#define GL_ATTRIB_STACK_DEPTH 0x0BB0")]
        public const int GL_ATTRIB_STACK_DEPTH = 0x0BB0;

        [NativeTypeName("#define GL_CLIENT_ATTRIB_STACK_DEPTH 0x0BB1")]
        public const int GL_CLIENT_ATTRIB_STACK_DEPTH = 0x0BB1;

        [NativeTypeName("#define GL_COLOR_CLEAR_VALUE 0x0C22")]
        public const int GL_COLOR_CLEAR_VALUE = 0x0C22;

        [NativeTypeName("#define GL_COLOR_WRITEMASK 0x0C23")]
        public const int GL_COLOR_WRITEMASK = 0x0C23;

        [NativeTypeName("#define GL_CURRENT_INDEX 0x0B01")]
        public const int GL_CURRENT_INDEX = 0x0B01;

        [NativeTypeName("#define GL_CURRENT_COLOR 0x0B00")]
        public const int GL_CURRENT_COLOR = 0x0B00;

        [NativeTypeName("#define GL_CURRENT_NORMAL 0x0B02")]
        public const int GL_CURRENT_NORMAL = 0x0B02;

        [NativeTypeName("#define GL_CURRENT_RASTER_COLOR 0x0B04")]
        public const int GL_CURRENT_RASTER_COLOR = 0x0B04;

        [NativeTypeName("#define GL_CURRENT_RASTER_DISTANCE 0x0B09")]
        public const int GL_CURRENT_RASTER_DISTANCE = 0x0B09;

        [NativeTypeName("#define GL_CURRENT_RASTER_INDEX 0x0B05")]
        public const int GL_CURRENT_RASTER_INDEX = 0x0B05;

        [NativeTypeName("#define GL_CURRENT_RASTER_POSITION 0x0B07")]
        public const int GL_CURRENT_RASTER_POSITION = 0x0B07;

        [NativeTypeName("#define GL_CURRENT_RASTER_TEXTURE_COORDS 0x0B06")]
        public const int GL_CURRENT_RASTER_TEXTURE_COORDS = 0x0B06;

        [NativeTypeName("#define GL_CURRENT_RASTER_POSITION_VALID 0x0B08")]
        public const int GL_CURRENT_RASTER_POSITION_VALID = 0x0B08;

        [NativeTypeName("#define GL_CURRENT_TEXTURE_COORDS 0x0B03")]
        public const int GL_CURRENT_TEXTURE_COORDS = 0x0B03;

        [NativeTypeName("#define GL_INDEX_CLEAR_VALUE 0x0C20")]
        public const int GL_INDEX_CLEAR_VALUE = 0x0C20;

        [NativeTypeName("#define GL_INDEX_MODE 0x0C30")]
        public const int GL_INDEX_MODE = 0x0C30;

        [NativeTypeName("#define GL_INDEX_WRITEMASK 0x0C21")]
        public const int GL_INDEX_WRITEMASK = 0x0C21;

        [NativeTypeName("#define GL_MODELVIEW_MATRIX 0x0BA6")]
        public const int GL_MODELVIEW_MATRIX = 0x0BA6;

        [NativeTypeName("#define GL_MODELVIEW_STACK_DEPTH 0x0BA3")]
        public const int GL_MODELVIEW_STACK_DEPTH = 0x0BA3;

        [NativeTypeName("#define GL_NAME_STACK_DEPTH 0x0D70")]
        public const int GL_NAME_STACK_DEPTH = 0x0D70;

        [NativeTypeName("#define GL_PROJECTION_MATRIX 0x0BA7")]
        public const int GL_PROJECTION_MATRIX = 0x0BA7;

        [NativeTypeName("#define GL_PROJECTION_STACK_DEPTH 0x0BA4")]
        public const int GL_PROJECTION_STACK_DEPTH = 0x0BA4;

        [NativeTypeName("#define GL_RENDER_MODE 0x0C40")]
        public const int GL_RENDER_MODE = 0x0C40;

        [NativeTypeName("#define GL_RGBA_MODE 0x0C31")]
        public const int GL_RGBA_MODE = 0x0C31;

        [NativeTypeName("#define GL_TEXTURE_MATRIX 0x0BA8")]
        public const int GL_TEXTURE_MATRIX = 0x0BA8;

        [NativeTypeName("#define GL_TEXTURE_STACK_DEPTH 0x0BA5")]
        public const int GL_TEXTURE_STACK_DEPTH = 0x0BA5;

        [NativeTypeName("#define GL_VIEWPORT 0x0BA2")]
        public const int GL_VIEWPORT = 0x0BA2;

        [NativeTypeName("#define GL_AUTO_NORMAL 0x0D80")]
        public const int GL_AUTO_NORMAL = 0x0D80;

        [NativeTypeName("#define GL_MAP1_COLOR_4 0x0D90")]
        public const int GL_MAP1_COLOR_4 = 0x0D90;

        [NativeTypeName("#define GL_MAP1_INDEX 0x0D91")]
        public const int GL_MAP1_INDEX = 0x0D91;

        [NativeTypeName("#define GL_MAP1_NORMAL 0x0D92")]
        public const int GL_MAP1_NORMAL = 0x0D92;

        [NativeTypeName("#define GL_MAP1_TEXTURE_COORD_1 0x0D93")]
        public const int GL_MAP1_TEXTURE_COORD_1 = 0x0D93;

        [NativeTypeName("#define GL_MAP1_TEXTURE_COORD_2 0x0D94")]
        public const int GL_MAP1_TEXTURE_COORD_2 = 0x0D94;

        [NativeTypeName("#define GL_MAP1_TEXTURE_COORD_3 0x0D95")]
        public const int GL_MAP1_TEXTURE_COORD_3 = 0x0D95;

        [NativeTypeName("#define GL_MAP1_TEXTURE_COORD_4 0x0D96")]
        public const int GL_MAP1_TEXTURE_COORD_4 = 0x0D96;

        [NativeTypeName("#define GL_MAP1_VERTEX_3 0x0D97")]
        public const int GL_MAP1_VERTEX_3 = 0x0D97;

        [NativeTypeName("#define GL_MAP1_VERTEX_4 0x0D98")]
        public const int GL_MAP1_VERTEX_4 = 0x0D98;

        [NativeTypeName("#define GL_MAP2_COLOR_4 0x0DB0")]
        public const int GL_MAP2_COLOR_4 = 0x0DB0;

        [NativeTypeName("#define GL_MAP2_INDEX 0x0DB1")]
        public const int GL_MAP2_INDEX = 0x0DB1;

        [NativeTypeName("#define GL_MAP2_NORMAL 0x0DB2")]
        public const int GL_MAP2_NORMAL = 0x0DB2;

        [NativeTypeName("#define GL_MAP2_TEXTURE_COORD_1 0x0DB3")]
        public const int GL_MAP2_TEXTURE_COORD_1 = 0x0DB3;

        [NativeTypeName("#define GL_MAP2_TEXTURE_COORD_2 0x0DB4")]
        public const int GL_MAP2_TEXTURE_COORD_2 = 0x0DB4;

        [NativeTypeName("#define GL_MAP2_TEXTURE_COORD_3 0x0DB5")]
        public const int GL_MAP2_TEXTURE_COORD_3 = 0x0DB5;

        [NativeTypeName("#define GL_MAP2_TEXTURE_COORD_4 0x0DB6")]
        public const int GL_MAP2_TEXTURE_COORD_4 = 0x0DB6;

        [NativeTypeName("#define GL_MAP2_VERTEX_3 0x0DB7")]
        public const int GL_MAP2_VERTEX_3 = 0x0DB7;

        [NativeTypeName("#define GL_MAP2_VERTEX_4 0x0DB8")]
        public const int GL_MAP2_VERTEX_4 = 0x0DB8;

        [NativeTypeName("#define GL_MAP1_GRID_DOMAIN 0x0DD0")]
        public const int GL_MAP1_GRID_DOMAIN = 0x0DD0;

        [NativeTypeName("#define GL_MAP1_GRID_SEGMENTS 0x0DD1")]
        public const int GL_MAP1_GRID_SEGMENTS = 0x0DD1;

        [NativeTypeName("#define GL_MAP2_GRID_DOMAIN 0x0DD2")]
        public const int GL_MAP2_GRID_DOMAIN = 0x0DD2;

        [NativeTypeName("#define GL_MAP2_GRID_SEGMENTS 0x0DD3")]
        public const int GL_MAP2_GRID_SEGMENTS = 0x0DD3;

        [NativeTypeName("#define GL_COEFF 0x0A00")]
        public const int GL_COEFF = 0x0A00;

        [NativeTypeName("#define GL_ORDER 0x0A01")]
        public const int GL_ORDER = 0x0A01;

        [NativeTypeName("#define GL_DOMAIN 0x0A02")]
        public const int GL_DOMAIN = 0x0A02;

        [NativeTypeName("#define GL_PERSPECTIVE_CORRECTION_HINT 0x0C50")]
        public const int GL_PERSPECTIVE_CORRECTION_HINT = 0x0C50;

        [NativeTypeName("#define GL_POINT_SMOOTH_HINT 0x0C51")]
        public const int GL_POINT_SMOOTH_HINT = 0x0C51;

        [NativeTypeName("#define GL_LINE_SMOOTH_HINT 0x0C52")]
        public const int GL_LINE_SMOOTH_HINT = 0x0C52;

        [NativeTypeName("#define GL_POLYGON_SMOOTH_HINT 0x0C53")]
        public const int GL_POLYGON_SMOOTH_HINT = 0x0C53;

        [NativeTypeName("#define GL_FOG_HINT 0x0C54")]
        public const int GL_FOG_HINT = 0x0C54;

        [NativeTypeName("#define GL_DONT_CARE 0x1100")]
        public const int GL_DONT_CARE = 0x1100;

        [NativeTypeName("#define GL_FASTEST 0x1101")]
        public const int GL_FASTEST = 0x1101;

        [NativeTypeName("#define GL_NICEST 0x1102")]
        public const int GL_NICEST = 0x1102;

        [NativeTypeName("#define GL_SCISSOR_BOX 0x0C10")]
        public const int GL_SCISSOR_BOX = 0x0C10;

        [NativeTypeName("#define GL_SCISSOR_TEST 0x0C11")]
        public const int GL_SCISSOR_TEST = 0x0C11;

        [NativeTypeName("#define GL_MAP_COLOR 0x0D10")]
        public const int GL_MAP_COLOR = 0x0D10;

        [NativeTypeName("#define GL_MAP_STENCIL 0x0D11")]
        public const int GL_MAP_STENCIL = 0x0D11;

        [NativeTypeName("#define GL_INDEX_SHIFT 0x0D12")]
        public const int GL_INDEX_SHIFT = 0x0D12;

        [NativeTypeName("#define GL_INDEX_OFFSET 0x0D13")]
        public const int GL_INDEX_OFFSET = 0x0D13;

        [NativeTypeName("#define GL_RED_SCALE 0x0D14")]
        public const int GL_RED_SCALE = 0x0D14;

        [NativeTypeName("#define GL_RED_BIAS 0x0D15")]
        public const int GL_RED_BIAS = 0x0D15;

        [NativeTypeName("#define GL_GREEN_SCALE 0x0D18")]
        public const int GL_GREEN_SCALE = 0x0D18;

        [NativeTypeName("#define GL_GREEN_BIAS 0x0D19")]
        public const int GL_GREEN_BIAS = 0x0D19;

        [NativeTypeName("#define GL_BLUE_SCALE 0x0D1A")]
        public const int GL_BLUE_SCALE = 0x0D1A;

        [NativeTypeName("#define GL_BLUE_BIAS 0x0D1B")]
        public const int GL_BLUE_BIAS = 0x0D1B;

        [NativeTypeName("#define GL_ALPHA_SCALE 0x0D1C")]
        public const int GL_ALPHA_SCALE = 0x0D1C;

        [NativeTypeName("#define GL_ALPHA_BIAS 0x0D1D")]
        public const int GL_ALPHA_BIAS = 0x0D1D;

        [NativeTypeName("#define GL_DEPTH_SCALE 0x0D1E")]
        public const int GL_DEPTH_SCALE = 0x0D1E;

        [NativeTypeName("#define GL_DEPTH_BIAS 0x0D1F")]
        public const int GL_DEPTH_BIAS = 0x0D1F;

        [NativeTypeName("#define GL_PIXEL_MAP_S_TO_S_SIZE 0x0CB1")]
        public const int GL_PIXEL_MAP_S_TO_S_SIZE = 0x0CB1;

        [NativeTypeName("#define GL_PIXEL_MAP_I_TO_I_SIZE 0x0CB0")]
        public const int GL_PIXEL_MAP_I_TO_I_SIZE = 0x0CB0;

        [NativeTypeName("#define GL_PIXEL_MAP_I_TO_R_SIZE 0x0CB2")]
        public const int GL_PIXEL_MAP_I_TO_R_SIZE = 0x0CB2;

        [NativeTypeName("#define GL_PIXEL_MAP_I_TO_G_SIZE 0x0CB3")]
        public const int GL_PIXEL_MAP_I_TO_G_SIZE = 0x0CB3;

        [NativeTypeName("#define GL_PIXEL_MAP_I_TO_B_SIZE 0x0CB4")]
        public const int GL_PIXEL_MAP_I_TO_B_SIZE = 0x0CB4;

        [NativeTypeName("#define GL_PIXEL_MAP_I_TO_A_SIZE 0x0CB5")]
        public const int GL_PIXEL_MAP_I_TO_A_SIZE = 0x0CB5;

        [NativeTypeName("#define GL_PIXEL_MAP_R_TO_R_SIZE 0x0CB6")]
        public const int GL_PIXEL_MAP_R_TO_R_SIZE = 0x0CB6;

        [NativeTypeName("#define GL_PIXEL_MAP_G_TO_G_SIZE 0x0CB7")]
        public const int GL_PIXEL_MAP_G_TO_G_SIZE = 0x0CB7;

        [NativeTypeName("#define GL_PIXEL_MAP_B_TO_B_SIZE 0x0CB8")]
        public const int GL_PIXEL_MAP_B_TO_B_SIZE = 0x0CB8;

        [NativeTypeName("#define GL_PIXEL_MAP_A_TO_A_SIZE 0x0CB9")]
        public const int GL_PIXEL_MAP_A_TO_A_SIZE = 0x0CB9;

        [NativeTypeName("#define GL_PIXEL_MAP_S_TO_S 0x0C71")]
        public const int GL_PIXEL_MAP_S_TO_S = 0x0C71;

        [NativeTypeName("#define GL_PIXEL_MAP_I_TO_I 0x0C70")]
        public const int GL_PIXEL_MAP_I_TO_I = 0x0C70;

        [NativeTypeName("#define GL_PIXEL_MAP_I_TO_R 0x0C72")]
        public const int GL_PIXEL_MAP_I_TO_R = 0x0C72;

        [NativeTypeName("#define GL_PIXEL_MAP_I_TO_G 0x0C73")]
        public const int GL_PIXEL_MAP_I_TO_G = 0x0C73;

        [NativeTypeName("#define GL_PIXEL_MAP_I_TO_B 0x0C74")]
        public const int GL_PIXEL_MAP_I_TO_B = 0x0C74;

        [NativeTypeName("#define GL_PIXEL_MAP_I_TO_A 0x0C75")]
        public const int GL_PIXEL_MAP_I_TO_A = 0x0C75;

        [NativeTypeName("#define GL_PIXEL_MAP_R_TO_R 0x0C76")]
        public const int GL_PIXEL_MAP_R_TO_R = 0x0C76;

        [NativeTypeName("#define GL_PIXEL_MAP_G_TO_G 0x0C77")]
        public const int GL_PIXEL_MAP_G_TO_G = 0x0C77;

        [NativeTypeName("#define GL_PIXEL_MAP_B_TO_B 0x0C78")]
        public const int GL_PIXEL_MAP_B_TO_B = 0x0C78;

        [NativeTypeName("#define GL_PIXEL_MAP_A_TO_A 0x0C79")]
        public const int GL_PIXEL_MAP_A_TO_A = 0x0C79;

        [NativeTypeName("#define GL_PACK_ALIGNMENT 0x0D05")]
        public const int GL_PACK_ALIGNMENT = 0x0D05;

        [NativeTypeName("#define GL_PACK_LSB_FIRST 0x0D01")]
        public const int GL_PACK_LSB_FIRST = 0x0D01;

        [NativeTypeName("#define GL_PACK_ROW_LENGTH 0x0D02")]
        public const int GL_PACK_ROW_LENGTH = 0x0D02;

        [NativeTypeName("#define GL_PACK_SKIP_PIXELS 0x0D04")]
        public const int GL_PACK_SKIP_PIXELS = 0x0D04;

        [NativeTypeName("#define GL_PACK_SKIP_ROWS 0x0D03")]
        public const int GL_PACK_SKIP_ROWS = 0x0D03;

        [NativeTypeName("#define GL_PACK_SWAP_BYTES 0x0D00")]
        public const int GL_PACK_SWAP_BYTES = 0x0D00;

        [NativeTypeName("#define GL_UNPACK_ALIGNMENT 0x0CF5")]
        public const int GL_UNPACK_ALIGNMENT = 0x0CF5;

        [NativeTypeName("#define GL_UNPACK_LSB_FIRST 0x0CF1")]
        public const int GL_UNPACK_LSB_FIRST = 0x0CF1;

        [NativeTypeName("#define GL_UNPACK_ROW_LENGTH 0x0CF2")]
        public const int GL_UNPACK_ROW_LENGTH = 0x0CF2;

        [NativeTypeName("#define GL_UNPACK_SKIP_PIXELS 0x0CF4")]
        public const int GL_UNPACK_SKIP_PIXELS = 0x0CF4;

        [NativeTypeName("#define GL_UNPACK_SKIP_ROWS 0x0CF3")]
        public const int GL_UNPACK_SKIP_ROWS = 0x0CF3;

        [NativeTypeName("#define GL_UNPACK_SWAP_BYTES 0x0CF0")]
        public const int GL_UNPACK_SWAP_BYTES = 0x0CF0;

        [NativeTypeName("#define GL_ZOOM_X 0x0D16")]
        public const int GL_ZOOM_X = 0x0D16;

        [NativeTypeName("#define GL_ZOOM_Y 0x0D17")]
        public const int GL_ZOOM_Y = 0x0D17;

        [NativeTypeName("#define GL_TEXTURE_ENV 0x2300")]
        public const int GL_TEXTURE_ENV = 0x2300;

        [NativeTypeName("#define GL_TEXTURE_ENV_MODE 0x2200")]
        public const int GL_TEXTURE_ENV_MODE = 0x2200;

        [NativeTypeName("#define GL_TEXTURE_1D 0x0DE0")]
        public const int GL_TEXTURE_1D = 0x0DE0;

        [NativeTypeName("#define GL_TEXTURE_2D 0x0DE1")]
        public const int GL_TEXTURE_2D = 0x0DE1;

        [NativeTypeName("#define GL_TEXTURE_WRAP_S 0x2802")]
        public const int GL_TEXTURE_WRAP_S = 0x2802;

        [NativeTypeName("#define GL_TEXTURE_WRAP_T 0x2803")]
        public const int GL_TEXTURE_WRAP_T = 0x2803;

        [NativeTypeName("#define GL_TEXTURE_MAG_FILTER 0x2800")]
        public const int GL_TEXTURE_MAG_FILTER = 0x2800;

        [NativeTypeName("#define GL_TEXTURE_MIN_FILTER 0x2801")]
        public const int GL_TEXTURE_MIN_FILTER = 0x2801;

        [NativeTypeName("#define GL_TEXTURE_ENV_COLOR 0x2201")]
        public const int GL_TEXTURE_ENV_COLOR = 0x2201;

        [NativeTypeName("#define GL_TEXTURE_GEN_S 0x0C60")]
        public const int GL_TEXTURE_GEN_S = 0x0C60;

        [NativeTypeName("#define GL_TEXTURE_GEN_T 0x0C61")]
        public const int GL_TEXTURE_GEN_T = 0x0C61;

        [NativeTypeName("#define GL_TEXTURE_GEN_R 0x0C62")]
        public const int GL_TEXTURE_GEN_R = 0x0C62;

        [NativeTypeName("#define GL_TEXTURE_GEN_Q 0x0C63")]
        public const int GL_TEXTURE_GEN_Q = 0x0C63;

        [NativeTypeName("#define GL_TEXTURE_GEN_MODE 0x2500")]
        public const int GL_TEXTURE_GEN_MODE = 0x2500;

        [NativeTypeName("#define GL_TEXTURE_BORDER_COLOR 0x1004")]
        public const int GL_TEXTURE_BORDER_COLOR = 0x1004;

        [NativeTypeName("#define GL_TEXTURE_WIDTH 0x1000")]
        public const int GL_TEXTURE_WIDTH = 0x1000;

        [NativeTypeName("#define GL_TEXTURE_HEIGHT 0x1001")]
        public const int GL_TEXTURE_HEIGHT = 0x1001;

        [NativeTypeName("#define GL_TEXTURE_BORDER 0x1005")]
        public const int GL_TEXTURE_BORDER = 0x1005;

        [NativeTypeName("#define GL_TEXTURE_COMPONENTS 0x1003")]
        public const int GL_TEXTURE_COMPONENTS = 0x1003;

        [NativeTypeName("#define GL_TEXTURE_RED_SIZE 0x805C")]
        public const int GL_TEXTURE_RED_SIZE = 0x805C;

        [NativeTypeName("#define GL_TEXTURE_GREEN_SIZE 0x805D")]
        public const int GL_TEXTURE_GREEN_SIZE = 0x805D;

        [NativeTypeName("#define GL_TEXTURE_BLUE_SIZE 0x805E")]
        public const int GL_TEXTURE_BLUE_SIZE = 0x805E;

        [NativeTypeName("#define GL_TEXTURE_ALPHA_SIZE 0x805F")]
        public const int GL_TEXTURE_ALPHA_SIZE = 0x805F;

        [NativeTypeName("#define GL_TEXTURE_LUMINANCE_SIZE 0x8060")]
        public const int GL_TEXTURE_LUMINANCE_SIZE = 0x8060;

        [NativeTypeName("#define GL_TEXTURE_INTENSITY_SIZE 0x8061")]
        public const int GL_TEXTURE_INTENSITY_SIZE = 0x8061;

        [NativeTypeName("#define GL_NEAREST_MIPMAP_NEAREST 0x2700")]
        public const int GL_NEAREST_MIPMAP_NEAREST = 0x2700;

        [NativeTypeName("#define GL_NEAREST_MIPMAP_LINEAR 0x2702")]
        public const int GL_NEAREST_MIPMAP_LINEAR = 0x2702;

        [NativeTypeName("#define GL_LINEAR_MIPMAP_NEAREST 0x2701")]
        public const int GL_LINEAR_MIPMAP_NEAREST = 0x2701;

        [NativeTypeName("#define GL_LINEAR_MIPMAP_LINEAR 0x2703")]
        public const int GL_LINEAR_MIPMAP_LINEAR = 0x2703;

        [NativeTypeName("#define GL_OBJECT_LINEAR 0x2401")]
        public const int GL_OBJECT_LINEAR = 0x2401;

        [NativeTypeName("#define GL_OBJECT_PLANE 0x2501")]
        public const int GL_OBJECT_PLANE = 0x2501;

        [NativeTypeName("#define GL_EYE_LINEAR 0x2400")]
        public const int GL_EYE_LINEAR = 0x2400;

        [NativeTypeName("#define GL_EYE_PLANE 0x2502")]
        public const int GL_EYE_PLANE = 0x2502;

        [NativeTypeName("#define GL_SPHERE_MAP 0x2402")]
        public const int GL_SPHERE_MAP = 0x2402;

        [NativeTypeName("#define GL_DECAL 0x2101")]
        public const int GL_DECAL = 0x2101;

        [NativeTypeName("#define GL_MODULATE 0x2100")]
        public const int GL_MODULATE = 0x2100;

        [NativeTypeName("#define GL_NEAREST 0x2600")]
        public const int GL_NEAREST = 0x2600;

        [NativeTypeName("#define GL_REPEAT 0x2901")]
        public const int GL_REPEAT = 0x2901;

        [NativeTypeName("#define GL_CLAMP 0x2900")]
        public const int GL_CLAMP = 0x2900;

        [NativeTypeName("#define GL_S 0x2000")]
        public const int GL_S = 0x2000;

        [NativeTypeName("#define GL_T 0x2001")]
        public const int GL_T = 0x2001;

        [NativeTypeName("#define GL_R 0x2002")]
        public const int GL_R = 0x2002;

        [NativeTypeName("#define GL_Q 0x2003")]
        public const int GL_Q = 0x2003;

        [NativeTypeName("#define GL_VENDOR 0x1F00")]
        public const int GL_VENDOR = 0x1F00;

        [NativeTypeName("#define GL_RENDERER 0x1F01")]
        public const int GL_RENDERER = 0x1F01;

        [NativeTypeName("#define GL_VERSION 0x1F02")]
        public const int GL_VERSION = 0x1F02;

        [NativeTypeName("#define GL_EXTENSIONS 0x1F03")]
        public const int GL_EXTENSIONS = 0x1F03;

        [NativeTypeName("#define GL_NO_ERROR 0")]
        public const int GL_NO_ERROR = 0;

        [NativeTypeName("#define GL_INVALID_ENUM 0x0500")]
        public const int GL_INVALID_ENUM = 0x0500;

        [NativeTypeName("#define GL_INVALID_VALUE 0x0501")]
        public const int GL_INVALID_VALUE = 0x0501;

        [NativeTypeName("#define GL_INVALID_OPERATION 0x0502")]
        public const int GL_INVALID_OPERATION = 0x0502;

        [NativeTypeName("#define GL_STACK_OVERFLOW 0x0503")]
        public const int GL_STACK_OVERFLOW = 0x0503;

        [NativeTypeName("#define GL_STACK_UNDERFLOW 0x0504")]
        public const int GL_STACK_UNDERFLOW = 0x0504;

        [NativeTypeName("#define GL_OUT_OF_MEMORY 0x0505")]
        public const int GL_OUT_OF_MEMORY = 0x0505;

        [NativeTypeName("#define GL_CURRENT_BIT 0x00000001")]
        public const int GL_CURRENT_BIT = 0x00000001;

        [NativeTypeName("#define GL_POINT_BIT 0x00000002")]
        public const int GL_POINT_BIT = 0x00000002;

        [NativeTypeName("#define GL_LINE_BIT 0x00000004")]
        public const int GL_LINE_BIT = 0x00000004;

        [NativeTypeName("#define GL_POLYGON_BIT 0x00000008")]
        public const int GL_POLYGON_BIT = 0x00000008;

        [NativeTypeName("#define GL_POLYGON_STIPPLE_BIT 0x00000010")]
        public const int GL_POLYGON_STIPPLE_BIT = 0x00000010;

        [NativeTypeName("#define GL_PIXEL_MODE_BIT 0x00000020")]
        public const int GL_PIXEL_MODE_BIT = 0x00000020;

        [NativeTypeName("#define GL_LIGHTING_BIT 0x00000040")]
        public const int GL_LIGHTING_BIT = 0x00000040;

        [NativeTypeName("#define GL_FOG_BIT 0x00000080")]
        public const int GL_FOG_BIT = 0x00000080;

        [NativeTypeName("#define GL_DEPTH_BUFFER_BIT 0x00000100")]
        public const int GL_DEPTH_BUFFER_BIT = 0x00000100;

        [NativeTypeName("#define GL_ACCUM_BUFFER_BIT 0x00000200")]
        public const int GL_ACCUM_BUFFER_BIT = 0x00000200;

        [NativeTypeName("#define GL_STENCIL_BUFFER_BIT 0x00000400")]
        public const int GL_STENCIL_BUFFER_BIT = 0x00000400;

        [NativeTypeName("#define GL_VIEWPORT_BIT 0x00000800")]
        public const int GL_VIEWPORT_BIT = 0x00000800;

        [NativeTypeName("#define GL_TRANSFORM_BIT 0x00001000")]
        public const int GL_TRANSFORM_BIT = 0x00001000;

        [NativeTypeName("#define GL_ENABLE_BIT 0x00002000")]
        public const int GL_ENABLE_BIT = 0x00002000;

        [NativeTypeName("#define GL_COLOR_BUFFER_BIT 0x00004000")]
        public const int GL_COLOR_BUFFER_BIT = 0x00004000;

        [NativeTypeName("#define GL_HINT_BIT 0x00008000")]
        public const int GL_HINT_BIT = 0x00008000;

        [NativeTypeName("#define GL_EVAL_BIT 0x00010000")]
        public const int GL_EVAL_BIT = 0x00010000;

        [NativeTypeName("#define GL_LIST_BIT 0x00020000")]
        public const int GL_LIST_BIT = 0x00020000;

        [NativeTypeName("#define GL_TEXTURE_BIT 0x00040000")]
        public const int GL_TEXTURE_BIT = 0x00040000;

        [NativeTypeName("#define GL_SCISSOR_BIT 0x00080000")]
        public const int GL_SCISSOR_BIT = 0x00080000;

        [NativeTypeName("#define GL_ALL_ATTRIB_BITS 0x000FFFFF")]
        public const int GL_ALL_ATTRIB_BITS = 0x000FFFFF;

        [NativeTypeName("#define GL_PROXY_TEXTURE_1D 0x8063")]
        public const int GL_PROXY_TEXTURE_1D = 0x8063;

        [NativeTypeName("#define GL_PROXY_TEXTURE_2D 0x8064")]
        public const int GL_PROXY_TEXTURE_2D = 0x8064;

        [NativeTypeName("#define GL_TEXTURE_PRIORITY 0x8066")]
        public const int GL_TEXTURE_PRIORITY = 0x8066;

        [NativeTypeName("#define GL_TEXTURE_RESIDENT 0x8067")]
        public const int GL_TEXTURE_RESIDENT = 0x8067;

        [NativeTypeName("#define GL_TEXTURE_BINDING_1D 0x8068")]
        public const int GL_TEXTURE_BINDING_1D = 0x8068;

        [NativeTypeName("#define GL_TEXTURE_BINDING_2D 0x8069")]
        public const int GL_TEXTURE_BINDING_2D = 0x8069;

        [NativeTypeName("#define GL_TEXTURE_INTERNAL_FORMAT 0x1003")]
        public const int GL_TEXTURE_INTERNAL_FORMAT = 0x1003;

        [NativeTypeName("#define GL_ALPHA4 0x803B")]
        public const int GL_ALPHA4 = 0x803B;

        [NativeTypeName("#define GL_ALPHA8 0x803C")]
        public const int GL_ALPHA8 = 0x803C;

        [NativeTypeName("#define GL_ALPHA12 0x803D")]
        public const int GL_ALPHA12 = 0x803D;

        [NativeTypeName("#define GL_ALPHA16 0x803E")]
        public const int GL_ALPHA16 = 0x803E;

        [NativeTypeName("#define GL_LUMINANCE4 0x803F")]
        public const int GL_LUMINANCE4 = 0x803F;

        [NativeTypeName("#define GL_LUMINANCE8 0x8040")]
        public const int GL_LUMINANCE8 = 0x8040;

        [NativeTypeName("#define GL_LUMINANCE12 0x8041")]
        public const int GL_LUMINANCE12 = 0x8041;

        [NativeTypeName("#define GL_LUMINANCE16 0x8042")]
        public const int GL_LUMINANCE16 = 0x8042;

        [NativeTypeName("#define GL_LUMINANCE4_ALPHA4 0x8043")]
        public const int GL_LUMINANCE4_ALPHA4 = 0x8043;

        [NativeTypeName("#define GL_LUMINANCE6_ALPHA2 0x8044")]
        public const int GL_LUMINANCE6_ALPHA2 = 0x8044;

        [NativeTypeName("#define GL_LUMINANCE8_ALPHA8 0x8045")]
        public const int GL_LUMINANCE8_ALPHA8 = 0x8045;

        [NativeTypeName("#define GL_LUMINANCE12_ALPHA4 0x8046")]
        public const int GL_LUMINANCE12_ALPHA4 = 0x8046;

        [NativeTypeName("#define GL_LUMINANCE12_ALPHA12 0x8047")]
        public const int GL_LUMINANCE12_ALPHA12 = 0x8047;

        [NativeTypeName("#define GL_LUMINANCE16_ALPHA16 0x8048")]
        public const int GL_LUMINANCE16_ALPHA16 = 0x8048;

        [NativeTypeName("#define GL_INTENSITY 0x8049")]
        public const int GL_INTENSITY = 0x8049;

        [NativeTypeName("#define GL_INTENSITY4 0x804A")]
        public const int GL_INTENSITY4 = 0x804A;

        [NativeTypeName("#define GL_INTENSITY8 0x804B")]
        public const int GL_INTENSITY8 = 0x804B;

        [NativeTypeName("#define GL_INTENSITY12 0x804C")]
        public const int GL_INTENSITY12 = 0x804C;

        [NativeTypeName("#define GL_INTENSITY16 0x804D")]
        public const int GL_INTENSITY16 = 0x804D;

        [NativeTypeName("#define GL_R3_G3_B2 0x2A10")]
        public const int GL_R3_G3_B2 = 0x2A10;

        [NativeTypeName("#define GL_RGB4 0x804F")]
        public const int GL_RGB4 = 0x804F;

        [NativeTypeName("#define GL_RGB5 0x8050")]
        public const int GL_RGB5 = 0x8050;

        [NativeTypeName("#define GL_RGB8 0x8051")]
        public const int GL_RGB8 = 0x8051;

        [NativeTypeName("#define GL_RGB10 0x8052")]
        public const int GL_RGB10 = 0x8052;

        [NativeTypeName("#define GL_RGB12 0x8053")]
        public const int GL_RGB12 = 0x8053;

        [NativeTypeName("#define GL_RGB16 0x8054")]
        public const int GL_RGB16 = 0x8054;

        [NativeTypeName("#define GL_RGBA2 0x8055")]
        public const int GL_RGBA2 = 0x8055;

        [NativeTypeName("#define GL_RGBA4 0x8056")]
        public const int GL_RGBA4 = 0x8056;

        [NativeTypeName("#define GL_RGB5_A1 0x8057")]
        public const int GL_RGB5_A1 = 0x8057;

        [NativeTypeName("#define GL_RGBA8 0x8058")]
        public const int GL_RGBA8 = 0x8058;

        [NativeTypeName("#define GL_RGB10_A2 0x8059")]
        public const int GL_RGB10_A2 = 0x8059;

        [NativeTypeName("#define GL_RGBA12 0x805A")]
        public const int GL_RGBA12 = 0x805A;

        [NativeTypeName("#define GL_RGBA16 0x805B")]
        public const int GL_RGBA16 = 0x805B;

        [NativeTypeName("#define GL_CLIENT_PIXEL_STORE_BIT 0x00000001")]
        public const int GL_CLIENT_PIXEL_STORE_BIT = 0x00000001;

        [NativeTypeName("#define GL_CLIENT_VERTEX_ARRAY_BIT 0x00000002")]
        public const int GL_CLIENT_VERTEX_ARRAY_BIT = 0x00000002;

        [NativeTypeName("#define GL_ALL_CLIENT_ATTRIB_BITS 0xFFFFFFFF")]
        public const uint GL_ALL_CLIENT_ATTRIB_BITS = 0xFFFFFFFF;

        [NativeTypeName("#define GL_CLIENT_ALL_ATTRIB_BITS 0xFFFFFFFF")]
        public const uint GL_CLIENT_ALL_ATTRIB_BITS = 0xFFFFFFFF;

        [NativeTypeName("#define GL_RESCALE_NORMAL 0x803A")]
        public const int GL_RESCALE_NORMAL = 0x803A;

        [NativeTypeName("#define GL_CLAMP_TO_EDGE 0x812F")]
        public const int GL_CLAMP_TO_EDGE = 0x812F;

        [NativeTypeName("#define GL_MAX_ELEMENTS_VERTICES 0x80E8")]
        public const int GL_MAX_ELEMENTS_VERTICES = 0x80E8;

        [NativeTypeName("#define GL_MAX_ELEMENTS_INDICES 0x80E9")]
        public const int GL_MAX_ELEMENTS_INDICES = 0x80E9;

        [NativeTypeName("#define GL_BGR 0x80E0")]
        public const int GL_BGR = 0x80E0;

        [NativeTypeName("#define GL_BGRA 0x80E1")]
        public const int GL_BGRA = 0x80E1;

        [NativeTypeName("#define GL_UNSIGNED_BYTE_3_3_2 0x8032")]
        public const int GL_UNSIGNED_BYTE_3_3_2 = 0x8032;

        [NativeTypeName("#define GL_UNSIGNED_BYTE_2_3_3_REV 0x8362")]
        public const int GL_UNSIGNED_BYTE_2_3_3_REV = 0x8362;

        [NativeTypeName("#define GL_UNSIGNED_SHORT_5_6_5 0x8363")]
        public const int GL_UNSIGNED_SHORT_5_6_5 = 0x8363;

        [NativeTypeName("#define GL_UNSIGNED_SHORT_5_6_5_REV 0x8364")]
        public const int GL_UNSIGNED_SHORT_5_6_5_REV = 0x8364;

        [NativeTypeName("#define GL_UNSIGNED_SHORT_4_4_4_4 0x8033")]
        public const int GL_UNSIGNED_SHORT_4_4_4_4 = 0x8033;

        [NativeTypeName("#define GL_UNSIGNED_SHORT_4_4_4_4_REV 0x8365")]
        public const int GL_UNSIGNED_SHORT_4_4_4_4_REV = 0x8365;

        [NativeTypeName("#define GL_UNSIGNED_SHORT_5_5_5_1 0x8034")]
        public const int GL_UNSIGNED_SHORT_5_5_5_1 = 0x8034;

        [NativeTypeName("#define GL_UNSIGNED_SHORT_1_5_5_5_REV 0x8366")]
        public const int GL_UNSIGNED_SHORT_1_5_5_5_REV = 0x8366;

        [NativeTypeName("#define GL_UNSIGNED_INT_8_8_8_8 0x8035")]
        public const int GL_UNSIGNED_INT_8_8_8_8 = 0x8035;

        [NativeTypeName("#define GL_UNSIGNED_INT_8_8_8_8_REV 0x8367")]
        public const int GL_UNSIGNED_INT_8_8_8_8_REV = 0x8367;

        [NativeTypeName("#define GL_UNSIGNED_INT_10_10_10_2 0x8036")]
        public const int GL_UNSIGNED_INT_10_10_10_2 = 0x8036;

        [NativeTypeName("#define GL_UNSIGNED_INT_2_10_10_10_REV 0x8368")]
        public const int GL_UNSIGNED_INT_2_10_10_10_REV = 0x8368;

        [NativeTypeName("#define GL_LIGHT_MODEL_COLOR_CONTROL 0x81F8")]
        public const int GL_LIGHT_MODEL_COLOR_CONTROL = 0x81F8;

        [NativeTypeName("#define GL_SINGLE_COLOR 0x81F9")]
        public const int GL_SINGLE_COLOR = 0x81F9;

        [NativeTypeName("#define GL_SEPARATE_SPECULAR_COLOR 0x81FA")]
        public const int GL_SEPARATE_SPECULAR_COLOR = 0x81FA;

        [NativeTypeName("#define GL_TEXTURE_MIN_LOD 0x813A")]
        public const int GL_TEXTURE_MIN_LOD = 0x813A;

        [NativeTypeName("#define GL_TEXTURE_MAX_LOD 0x813B")]
        public const int GL_TEXTURE_MAX_LOD = 0x813B;

        [NativeTypeName("#define GL_TEXTURE_BASE_LEVEL 0x813C")]
        public const int GL_TEXTURE_BASE_LEVEL = 0x813C;

        [NativeTypeName("#define GL_TEXTURE_MAX_LEVEL 0x813D")]
        public const int GL_TEXTURE_MAX_LEVEL = 0x813D;

        [NativeTypeName("#define GL_SMOOTH_POINT_SIZE_RANGE 0x0B12")]
        public const int GL_SMOOTH_POINT_SIZE_RANGE = 0x0B12;

        [NativeTypeName("#define GL_SMOOTH_POINT_SIZE_GRANULARITY 0x0B13")]
        public const int GL_SMOOTH_POINT_SIZE_GRANULARITY = 0x0B13;

        [NativeTypeName("#define GL_SMOOTH_LINE_WIDTH_RANGE 0x0B22")]
        public const int GL_SMOOTH_LINE_WIDTH_RANGE = 0x0B22;

        [NativeTypeName("#define GL_SMOOTH_LINE_WIDTH_GRANULARITY 0x0B23")]
        public const int GL_SMOOTH_LINE_WIDTH_GRANULARITY = 0x0B23;

        [NativeTypeName("#define GL_ALIASED_POINT_SIZE_RANGE 0x846D")]
        public const int GL_ALIASED_POINT_SIZE_RANGE = 0x846D;

        [NativeTypeName("#define GL_ALIASED_LINE_WIDTH_RANGE 0x846E")]
        public const int GL_ALIASED_LINE_WIDTH_RANGE = 0x846E;

        [NativeTypeName("#define GL_PACK_SKIP_IMAGES 0x806B")]
        public const int GL_PACK_SKIP_IMAGES = 0x806B;

        [NativeTypeName("#define GL_PACK_IMAGE_HEIGHT 0x806C")]
        public const int GL_PACK_IMAGE_HEIGHT = 0x806C;

        [NativeTypeName("#define GL_UNPACK_SKIP_IMAGES 0x806D")]
        public const int GL_UNPACK_SKIP_IMAGES = 0x806D;

        [NativeTypeName("#define GL_UNPACK_IMAGE_HEIGHT 0x806E")]
        public const int GL_UNPACK_IMAGE_HEIGHT = 0x806E;

        [NativeTypeName("#define GL_TEXTURE_3D 0x806F")]
        public const int GL_TEXTURE_3D = 0x806F;

        [NativeTypeName("#define GL_PROXY_TEXTURE_3D 0x8070")]
        public const int GL_PROXY_TEXTURE_3D = 0x8070;

        [NativeTypeName("#define GL_TEXTURE_DEPTH 0x8071")]
        public const int GL_TEXTURE_DEPTH = 0x8071;

        [NativeTypeName("#define GL_TEXTURE_WRAP_R 0x8072")]
        public const int GL_TEXTURE_WRAP_R = 0x8072;

        [NativeTypeName("#define GL_MAX_3D_TEXTURE_SIZE 0x8073")]
        public const int GL_MAX_3D_TEXTURE_SIZE = 0x8073;

        [NativeTypeName("#define GL_TEXTURE_BINDING_3D 0x806A")]
        public const int GL_TEXTURE_BINDING_3D = 0x806A;

        [NativeTypeName("#define GL_CONSTANT_COLOR 0x8001")]
        public const int GL_CONSTANT_COLOR = 0x8001;

        [NativeTypeName("#define GL_ONE_MINUS_CONSTANT_COLOR 0x8002")]
        public const int GL_ONE_MINUS_CONSTANT_COLOR = 0x8002;

        [NativeTypeName("#define GL_CONSTANT_ALPHA 0x8003")]
        public const int GL_CONSTANT_ALPHA = 0x8003;

        [NativeTypeName("#define GL_ONE_MINUS_CONSTANT_ALPHA 0x8004")]
        public const int GL_ONE_MINUS_CONSTANT_ALPHA = 0x8004;

        [NativeTypeName("#define GL_COLOR_TABLE 0x80D0")]
        public const int GL_COLOR_TABLE = 0x80D0;

        [NativeTypeName("#define GL_POST_CONVOLUTION_COLOR_TABLE 0x80D1")]
        public const int GL_POST_CONVOLUTION_COLOR_TABLE = 0x80D1;

        [NativeTypeName("#define GL_POST_COLOR_MATRIX_COLOR_TABLE 0x80D2")]
        public const int GL_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D2;

        [NativeTypeName("#define GL_PROXY_COLOR_TABLE 0x80D3")]
        public const int GL_PROXY_COLOR_TABLE = 0x80D3;

        [NativeTypeName("#define GL_PROXY_POST_CONVOLUTION_COLOR_TABLE 0x80D4")]
        public const int GL_PROXY_POST_CONVOLUTION_COLOR_TABLE = 0x80D4;

        [NativeTypeName("#define GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE 0x80D5")]
        public const int GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D5;

        [NativeTypeName("#define GL_COLOR_TABLE_SCALE 0x80D6")]
        public const int GL_COLOR_TABLE_SCALE = 0x80D6;

        [NativeTypeName("#define GL_COLOR_TABLE_BIAS 0x80D7")]
        public const int GL_COLOR_TABLE_BIAS = 0x80D7;

        [NativeTypeName("#define GL_COLOR_TABLE_FORMAT 0x80D8")]
        public const int GL_COLOR_TABLE_FORMAT = 0x80D8;

        [NativeTypeName("#define GL_COLOR_TABLE_WIDTH 0x80D9")]
        public const int GL_COLOR_TABLE_WIDTH = 0x80D9;

        [NativeTypeName("#define GL_COLOR_TABLE_RED_SIZE 0x80DA")]
        public const int GL_COLOR_TABLE_RED_SIZE = 0x80DA;

        [NativeTypeName("#define GL_COLOR_TABLE_GREEN_SIZE 0x80DB")]
        public const int GL_COLOR_TABLE_GREEN_SIZE = 0x80DB;

        [NativeTypeName("#define GL_COLOR_TABLE_BLUE_SIZE 0x80DC")]
        public const int GL_COLOR_TABLE_BLUE_SIZE = 0x80DC;

        [NativeTypeName("#define GL_COLOR_TABLE_ALPHA_SIZE 0x80DD")]
        public const int GL_COLOR_TABLE_ALPHA_SIZE = 0x80DD;

        [NativeTypeName("#define GL_COLOR_TABLE_LUMINANCE_SIZE 0x80DE")]
        public const int GL_COLOR_TABLE_LUMINANCE_SIZE = 0x80DE;

        [NativeTypeName("#define GL_COLOR_TABLE_INTENSITY_SIZE 0x80DF")]
        public const int GL_COLOR_TABLE_INTENSITY_SIZE = 0x80DF;

        [NativeTypeName("#define GL_CONVOLUTION_1D 0x8010")]
        public const int GL_CONVOLUTION_1D = 0x8010;

        [NativeTypeName("#define GL_CONVOLUTION_2D 0x8011")]
        public const int GL_CONVOLUTION_2D = 0x8011;

        [NativeTypeName("#define GL_SEPARABLE_2D 0x8012")]
        public const int GL_SEPARABLE_2D = 0x8012;

        [NativeTypeName("#define GL_CONVOLUTION_BORDER_MODE 0x8013")]
        public const int GL_CONVOLUTION_BORDER_MODE = 0x8013;

        [NativeTypeName("#define GL_CONVOLUTION_FILTER_SCALE 0x8014")]
        public const int GL_CONVOLUTION_FILTER_SCALE = 0x8014;

        [NativeTypeName("#define GL_CONVOLUTION_FILTER_BIAS 0x8015")]
        public const int GL_CONVOLUTION_FILTER_BIAS = 0x8015;

        [NativeTypeName("#define GL_REDUCE 0x8016")]
        public const int GL_REDUCE = 0x8016;

        [NativeTypeName("#define GL_CONVOLUTION_FORMAT 0x8017")]
        public const int GL_CONVOLUTION_FORMAT = 0x8017;

        [NativeTypeName("#define GL_CONVOLUTION_WIDTH 0x8018")]
        public const int GL_CONVOLUTION_WIDTH = 0x8018;

        [NativeTypeName("#define GL_CONVOLUTION_HEIGHT 0x8019")]
        public const int GL_CONVOLUTION_HEIGHT = 0x8019;

        [NativeTypeName("#define GL_MAX_CONVOLUTION_WIDTH 0x801A")]
        public const int GL_MAX_CONVOLUTION_WIDTH = 0x801A;

        [NativeTypeName("#define GL_MAX_CONVOLUTION_HEIGHT 0x801B")]
        public const int GL_MAX_CONVOLUTION_HEIGHT = 0x801B;

        [NativeTypeName("#define GL_POST_CONVOLUTION_RED_SCALE 0x801C")]
        public const int GL_POST_CONVOLUTION_RED_SCALE = 0x801C;

        [NativeTypeName("#define GL_POST_CONVOLUTION_GREEN_SCALE 0x801D")]
        public const int GL_POST_CONVOLUTION_GREEN_SCALE = 0x801D;

        [NativeTypeName("#define GL_POST_CONVOLUTION_BLUE_SCALE 0x801E")]
        public const int GL_POST_CONVOLUTION_BLUE_SCALE = 0x801E;

        [NativeTypeName("#define GL_POST_CONVOLUTION_ALPHA_SCALE 0x801F")]
        public const int GL_POST_CONVOLUTION_ALPHA_SCALE = 0x801F;

        [NativeTypeName("#define GL_POST_CONVOLUTION_RED_BIAS 0x8020")]
        public const int GL_POST_CONVOLUTION_RED_BIAS = 0x8020;

        [NativeTypeName("#define GL_POST_CONVOLUTION_GREEN_BIAS 0x8021")]
        public const int GL_POST_CONVOLUTION_GREEN_BIAS = 0x8021;

        [NativeTypeName("#define GL_POST_CONVOLUTION_BLUE_BIAS 0x8022")]
        public const int GL_POST_CONVOLUTION_BLUE_BIAS = 0x8022;

        [NativeTypeName("#define GL_POST_CONVOLUTION_ALPHA_BIAS 0x8023")]
        public const int GL_POST_CONVOLUTION_ALPHA_BIAS = 0x8023;

        [NativeTypeName("#define GL_CONSTANT_BORDER 0x8151")]
        public const int GL_CONSTANT_BORDER = 0x8151;

        [NativeTypeName("#define GL_REPLICATE_BORDER 0x8153")]
        public const int GL_REPLICATE_BORDER = 0x8153;

        [NativeTypeName("#define GL_CONVOLUTION_BORDER_COLOR 0x8154")]
        public const int GL_CONVOLUTION_BORDER_COLOR = 0x8154;

        [NativeTypeName("#define GL_COLOR_MATRIX 0x80B1")]
        public const int GL_COLOR_MATRIX = 0x80B1;

        [NativeTypeName("#define GL_COLOR_MATRIX_STACK_DEPTH 0x80B2")]
        public const int GL_COLOR_MATRIX_STACK_DEPTH = 0x80B2;

        [NativeTypeName("#define GL_MAX_COLOR_MATRIX_STACK_DEPTH 0x80B3")]
        public const int GL_MAX_COLOR_MATRIX_STACK_DEPTH = 0x80B3;

        [NativeTypeName("#define GL_POST_COLOR_MATRIX_RED_SCALE 0x80B4")]
        public const int GL_POST_COLOR_MATRIX_RED_SCALE = 0x80B4;

        [NativeTypeName("#define GL_POST_COLOR_MATRIX_GREEN_SCALE 0x80B5")]
        public const int GL_POST_COLOR_MATRIX_GREEN_SCALE = 0x80B5;

        [NativeTypeName("#define GL_POST_COLOR_MATRIX_BLUE_SCALE 0x80B6")]
        public const int GL_POST_COLOR_MATRIX_BLUE_SCALE = 0x80B6;

        [NativeTypeName("#define GL_POST_COLOR_MATRIX_ALPHA_SCALE 0x80B7")]
        public const int GL_POST_COLOR_MATRIX_ALPHA_SCALE = 0x80B7;

        [NativeTypeName("#define GL_POST_COLOR_MATRIX_RED_BIAS 0x80B8")]
        public const int GL_POST_COLOR_MATRIX_RED_BIAS = 0x80B8;

        [NativeTypeName("#define GL_POST_COLOR_MATRIX_GREEN_BIAS 0x80B9")]
        public const int GL_POST_COLOR_MATRIX_GREEN_BIAS = 0x80B9;

        [NativeTypeName("#define GL_POST_COLOR_MATRIX_BLUE_BIAS 0x80BA")]
        public const int GL_POST_COLOR_MATRIX_BLUE_BIAS = 0x80BA;

        [NativeTypeName("#define GL_POST_COLOR_MATRIX_ALPHA_BIAS 0x80BB")]
        public const int GL_POST_COLOR_MATRIX_ALPHA_BIAS = 0x80BB;

        [NativeTypeName("#define GL_HISTOGRAM 0x8024")]
        public const int GL_HISTOGRAM = 0x8024;

        [NativeTypeName("#define GL_PROXY_HISTOGRAM 0x8025")]
        public const int GL_PROXY_HISTOGRAM = 0x8025;

        [NativeTypeName("#define GL_HISTOGRAM_WIDTH 0x8026")]
        public const int GL_HISTOGRAM_WIDTH = 0x8026;

        [NativeTypeName("#define GL_HISTOGRAM_FORMAT 0x8027")]
        public const int GL_HISTOGRAM_FORMAT = 0x8027;

        [NativeTypeName("#define GL_HISTOGRAM_RED_SIZE 0x8028")]
        public const int GL_HISTOGRAM_RED_SIZE = 0x8028;

        [NativeTypeName("#define GL_HISTOGRAM_GREEN_SIZE 0x8029")]
        public const int GL_HISTOGRAM_GREEN_SIZE = 0x8029;

        [NativeTypeName("#define GL_HISTOGRAM_BLUE_SIZE 0x802A")]
        public const int GL_HISTOGRAM_BLUE_SIZE = 0x802A;

        [NativeTypeName("#define GL_HISTOGRAM_ALPHA_SIZE 0x802B")]
        public const int GL_HISTOGRAM_ALPHA_SIZE = 0x802B;

        [NativeTypeName("#define GL_HISTOGRAM_LUMINANCE_SIZE 0x802C")]
        public const int GL_HISTOGRAM_LUMINANCE_SIZE = 0x802C;

        [NativeTypeName("#define GL_HISTOGRAM_SINK 0x802D")]
        public const int GL_HISTOGRAM_SINK = 0x802D;

        [NativeTypeName("#define GL_MINMAX 0x802E")]
        public const int GL_MINMAX = 0x802E;

        [NativeTypeName("#define GL_MINMAX_FORMAT 0x802F")]
        public const int GL_MINMAX_FORMAT = 0x802F;

        [NativeTypeName("#define GL_MINMAX_SINK 0x8030")]
        public const int GL_MINMAX_SINK = 0x8030;

        [NativeTypeName("#define GL_TABLE_TOO_LARGE 0x8031")]
        public const int GL_TABLE_TOO_LARGE = 0x8031;

        [NativeTypeName("#define GL_BLEND_EQUATION 0x8009")]
        public const int GL_BLEND_EQUATION = 0x8009;

        [NativeTypeName("#define GL_MIN 0x8007")]
        public const int GL_MIN = 0x8007;

        [NativeTypeName("#define GL_MAX 0x8008")]
        public const int GL_MAX = 0x8008;

        [NativeTypeName("#define GL_FUNC_ADD 0x8006")]
        public const int GL_FUNC_ADD = 0x8006;

        [NativeTypeName("#define GL_FUNC_SUBTRACT 0x800A")]
        public const int GL_FUNC_SUBTRACT = 0x800A;

        [NativeTypeName("#define GL_FUNC_REVERSE_SUBTRACT 0x800B")]
        public const int GL_FUNC_REVERSE_SUBTRACT = 0x800B;

        [NativeTypeName("#define GL_BLEND_COLOR 0x8005")]
        public const int GL_BLEND_COLOR = 0x8005;

        [NativeTypeName("#define GL_TEXTURE0 0x84C0")]
        public const int GL_TEXTURE0 = 0x84C0;

        [NativeTypeName("#define GL_TEXTURE1 0x84C1")]
        public const int GL_TEXTURE1 = 0x84C1;

        [NativeTypeName("#define GL_TEXTURE2 0x84C2")]
        public const int GL_TEXTURE2 = 0x84C2;

        [NativeTypeName("#define GL_TEXTURE3 0x84C3")]
        public const int GL_TEXTURE3 = 0x84C3;

        [NativeTypeName("#define GL_TEXTURE4 0x84C4")]
        public const int GL_TEXTURE4 = 0x84C4;

        [NativeTypeName("#define GL_TEXTURE5 0x84C5")]
        public const int GL_TEXTURE5 = 0x84C5;

        [NativeTypeName("#define GL_TEXTURE6 0x84C6")]
        public const int GL_TEXTURE6 = 0x84C6;

        [NativeTypeName("#define GL_TEXTURE7 0x84C7")]
        public const int GL_TEXTURE7 = 0x84C7;

        [NativeTypeName("#define GL_TEXTURE8 0x84C8")]
        public const int GL_TEXTURE8 = 0x84C8;

        [NativeTypeName("#define GL_TEXTURE9 0x84C9")]
        public const int GL_TEXTURE9 = 0x84C9;

        [NativeTypeName("#define GL_TEXTURE10 0x84CA")]
        public const int GL_TEXTURE10 = 0x84CA;

        [NativeTypeName("#define GL_TEXTURE11 0x84CB")]
        public const int GL_TEXTURE11 = 0x84CB;

        [NativeTypeName("#define GL_TEXTURE12 0x84CC")]
        public const int GL_TEXTURE12 = 0x84CC;

        [NativeTypeName("#define GL_TEXTURE13 0x84CD")]
        public const int GL_TEXTURE13 = 0x84CD;

        [NativeTypeName("#define GL_TEXTURE14 0x84CE")]
        public const int GL_TEXTURE14 = 0x84CE;

        [NativeTypeName("#define GL_TEXTURE15 0x84CF")]
        public const int GL_TEXTURE15 = 0x84CF;

        [NativeTypeName("#define GL_TEXTURE16 0x84D0")]
        public const int GL_TEXTURE16 = 0x84D0;

        [NativeTypeName("#define GL_TEXTURE17 0x84D1")]
        public const int GL_TEXTURE17 = 0x84D1;

        [NativeTypeName("#define GL_TEXTURE18 0x84D2")]
        public const int GL_TEXTURE18 = 0x84D2;

        [NativeTypeName("#define GL_TEXTURE19 0x84D3")]
        public const int GL_TEXTURE19 = 0x84D3;

        [NativeTypeName("#define GL_TEXTURE20 0x84D4")]
        public const int GL_TEXTURE20 = 0x84D4;

        [NativeTypeName("#define GL_TEXTURE21 0x84D5")]
        public const int GL_TEXTURE21 = 0x84D5;

        [NativeTypeName("#define GL_TEXTURE22 0x84D6")]
        public const int GL_TEXTURE22 = 0x84D6;

        [NativeTypeName("#define GL_TEXTURE23 0x84D7")]
        public const int GL_TEXTURE23 = 0x84D7;

        [NativeTypeName("#define GL_TEXTURE24 0x84D8")]
        public const int GL_TEXTURE24 = 0x84D8;

        [NativeTypeName("#define GL_TEXTURE25 0x84D9")]
        public const int GL_TEXTURE25 = 0x84D9;

        [NativeTypeName("#define GL_TEXTURE26 0x84DA")]
        public const int GL_TEXTURE26 = 0x84DA;

        [NativeTypeName("#define GL_TEXTURE27 0x84DB")]
        public const int GL_TEXTURE27 = 0x84DB;

        [NativeTypeName("#define GL_TEXTURE28 0x84DC")]
        public const int GL_TEXTURE28 = 0x84DC;

        [NativeTypeName("#define GL_TEXTURE29 0x84DD")]
        public const int GL_TEXTURE29 = 0x84DD;

        [NativeTypeName("#define GL_TEXTURE30 0x84DE")]
        public const int GL_TEXTURE30 = 0x84DE;

        [NativeTypeName("#define GL_TEXTURE31 0x84DF")]
        public const int GL_TEXTURE31 = 0x84DF;

        [NativeTypeName("#define GL_ACTIVE_TEXTURE 0x84E0")]
        public const int GL_ACTIVE_TEXTURE = 0x84E0;

        [NativeTypeName("#define GL_CLIENT_ACTIVE_TEXTURE 0x84E1")]
        public const int GL_CLIENT_ACTIVE_TEXTURE = 0x84E1;

        [NativeTypeName("#define GL_MAX_TEXTURE_UNITS 0x84E2")]
        public const int GL_MAX_TEXTURE_UNITS = 0x84E2;

        [NativeTypeName("#define GL_NORMAL_MAP 0x8511")]
        public const int GL_NORMAL_MAP = 0x8511;

        [NativeTypeName("#define GL_REFLECTION_MAP 0x8512")]
        public const int GL_REFLECTION_MAP = 0x8512;

        [NativeTypeName("#define GL_TEXTURE_CUBE_MAP 0x8513")]
        public const int GL_TEXTURE_CUBE_MAP = 0x8513;

        [NativeTypeName("#define GL_TEXTURE_BINDING_CUBE_MAP 0x8514")]
        public const int GL_TEXTURE_BINDING_CUBE_MAP = 0x8514;

        [NativeTypeName("#define GL_TEXTURE_CUBE_MAP_POSITIVE_X 0x8515")]
        public const int GL_TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515;

        [NativeTypeName("#define GL_TEXTURE_CUBE_MAP_NEGATIVE_X 0x8516")]
        public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516;

        [NativeTypeName("#define GL_TEXTURE_CUBE_MAP_POSITIVE_Y 0x8517")]
        public const int GL_TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517;

        [NativeTypeName("#define GL_TEXTURE_CUBE_MAP_NEGATIVE_Y 0x8518")]
        public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518;

        [NativeTypeName("#define GL_TEXTURE_CUBE_MAP_POSITIVE_Z 0x8519")]
        public const int GL_TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519;

        [NativeTypeName("#define GL_TEXTURE_CUBE_MAP_NEGATIVE_Z 0x851A")]
        public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A;

        [NativeTypeName("#define GL_PROXY_TEXTURE_CUBE_MAP 0x851B")]
        public const int GL_PROXY_TEXTURE_CUBE_MAP = 0x851B;

        [NativeTypeName("#define GL_MAX_CUBE_MAP_TEXTURE_SIZE 0x851C")]
        public const int GL_MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C;

        [NativeTypeName("#define GL_COMPRESSED_ALPHA 0x84E9")]
        public const int GL_COMPRESSED_ALPHA = 0x84E9;

        [NativeTypeName("#define GL_COMPRESSED_LUMINANCE 0x84EA")]
        public const int GL_COMPRESSED_LUMINANCE = 0x84EA;

        [NativeTypeName("#define GL_COMPRESSED_LUMINANCE_ALPHA 0x84EB")]
        public const int GL_COMPRESSED_LUMINANCE_ALPHA = 0x84EB;

        [NativeTypeName("#define GL_COMPRESSED_INTENSITY 0x84EC")]
        public const int GL_COMPRESSED_INTENSITY = 0x84EC;

        [NativeTypeName("#define GL_COMPRESSED_RGB 0x84ED")]
        public const int GL_COMPRESSED_RGB = 0x84ED;

        [NativeTypeName("#define GL_COMPRESSED_RGBA 0x84EE")]
        public const int GL_COMPRESSED_RGBA = 0x84EE;

        [NativeTypeName("#define GL_TEXTURE_COMPRESSION_HINT 0x84EF")]
        public const int GL_TEXTURE_COMPRESSION_HINT = 0x84EF;

        [NativeTypeName("#define GL_TEXTURE_COMPRESSED_IMAGE_SIZE 0x86A0")]
        public const int GL_TEXTURE_COMPRESSED_IMAGE_SIZE = 0x86A0;

        [NativeTypeName("#define GL_TEXTURE_COMPRESSED 0x86A1")]
        public const int GL_TEXTURE_COMPRESSED = 0x86A1;

        [NativeTypeName("#define GL_NUM_COMPRESSED_TEXTURE_FORMATS 0x86A2")]
        public const int GL_NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2;

        [NativeTypeName("#define GL_COMPRESSED_TEXTURE_FORMATS 0x86A3")]
        public const int GL_COMPRESSED_TEXTURE_FORMATS = 0x86A3;

        [NativeTypeName("#define GL_MULTISAMPLE 0x809D")]
        public const int GL_MULTISAMPLE = 0x809D;

        [NativeTypeName("#define GL_SAMPLE_ALPHA_TO_COVERAGE 0x809E")]
        public const int GL_SAMPLE_ALPHA_TO_COVERAGE = 0x809E;

        [NativeTypeName("#define GL_SAMPLE_ALPHA_TO_ONE 0x809F")]
        public const int GL_SAMPLE_ALPHA_TO_ONE = 0x809F;

        [NativeTypeName("#define GL_SAMPLE_COVERAGE 0x80A0")]
        public const int GL_SAMPLE_COVERAGE = 0x80A0;

        [NativeTypeName("#define GL_SAMPLE_BUFFERS 0x80A8")]
        public const int GL_SAMPLE_BUFFERS = 0x80A8;

        [NativeTypeName("#define GL_SAMPLES 0x80A9")]
        public const int GL_SAMPLES = 0x80A9;

        [NativeTypeName("#define GL_SAMPLE_COVERAGE_VALUE 0x80AA")]
        public const int GL_SAMPLE_COVERAGE_VALUE = 0x80AA;

        [NativeTypeName("#define GL_SAMPLE_COVERAGE_INVERT 0x80AB")]
        public const int GL_SAMPLE_COVERAGE_INVERT = 0x80AB;

        [NativeTypeName("#define GL_MULTISAMPLE_BIT 0x20000000")]
        public const int GL_MULTISAMPLE_BIT = 0x20000000;

        [NativeTypeName("#define GL_TRANSPOSE_MODELVIEW_MATRIX 0x84E3")]
        public const int GL_TRANSPOSE_MODELVIEW_MATRIX = 0x84E3;

        [NativeTypeName("#define GL_TRANSPOSE_PROJECTION_MATRIX 0x84E4")]
        public const int GL_TRANSPOSE_PROJECTION_MATRIX = 0x84E4;

        [NativeTypeName("#define GL_TRANSPOSE_TEXTURE_MATRIX 0x84E5")]
        public const int GL_TRANSPOSE_TEXTURE_MATRIX = 0x84E5;

        [NativeTypeName("#define GL_TRANSPOSE_COLOR_MATRIX 0x84E6")]
        public const int GL_TRANSPOSE_COLOR_MATRIX = 0x84E6;

        [NativeTypeName("#define GL_COMBINE 0x8570")]
        public const int GL_COMBINE = 0x8570;

        [NativeTypeName("#define GL_COMBINE_RGB 0x8571")]
        public const int GL_COMBINE_RGB = 0x8571;

        [NativeTypeName("#define GL_COMBINE_ALPHA 0x8572")]
        public const int GL_COMBINE_ALPHA = 0x8572;

        [NativeTypeName("#define GL_SOURCE0_RGB 0x8580")]
        public const int GL_SOURCE0_RGB = 0x8580;

        [NativeTypeName("#define GL_SOURCE1_RGB 0x8581")]
        public const int GL_SOURCE1_RGB = 0x8581;

        [NativeTypeName("#define GL_SOURCE2_RGB 0x8582")]
        public const int GL_SOURCE2_RGB = 0x8582;

        [NativeTypeName("#define GL_SOURCE0_ALPHA 0x8588")]
        public const int GL_SOURCE0_ALPHA = 0x8588;

        [NativeTypeName("#define GL_SOURCE1_ALPHA 0x8589")]
        public const int GL_SOURCE1_ALPHA = 0x8589;

        [NativeTypeName("#define GL_SOURCE2_ALPHA 0x858A")]
        public const int GL_SOURCE2_ALPHA = 0x858A;

        [NativeTypeName("#define GL_OPERAND0_RGB 0x8590")]
        public const int GL_OPERAND0_RGB = 0x8590;

        [NativeTypeName("#define GL_OPERAND1_RGB 0x8591")]
        public const int GL_OPERAND1_RGB = 0x8591;

        [NativeTypeName("#define GL_OPERAND2_RGB 0x8592")]
        public const int GL_OPERAND2_RGB = 0x8592;

        [NativeTypeName("#define GL_OPERAND0_ALPHA 0x8598")]
        public const int GL_OPERAND0_ALPHA = 0x8598;

        [NativeTypeName("#define GL_OPERAND1_ALPHA 0x8599")]
        public const int GL_OPERAND1_ALPHA = 0x8599;

        [NativeTypeName("#define GL_OPERAND2_ALPHA 0x859A")]
        public const int GL_OPERAND2_ALPHA = 0x859A;

        [NativeTypeName("#define GL_RGB_SCALE 0x8573")]
        public const int GL_RGB_SCALE = 0x8573;

        [NativeTypeName("#define GL_ADD_SIGNED 0x8574")]
        public const int GL_ADD_SIGNED = 0x8574;

        [NativeTypeName("#define GL_INTERPOLATE 0x8575")]
        public const int GL_INTERPOLATE = 0x8575;

        [NativeTypeName("#define GL_SUBTRACT 0x84E7")]
        public const int GL_SUBTRACT = 0x84E7;

        [NativeTypeName("#define GL_CONSTANT 0x8576")]
        public const int GL_CONSTANT = 0x8576;

        [NativeTypeName("#define GL_PRIMARY_COLOR 0x8577")]
        public const int GL_PRIMARY_COLOR = 0x8577;

        [NativeTypeName("#define GL_PREVIOUS 0x8578")]
        public const int GL_PREVIOUS = 0x8578;

        [NativeTypeName("#define GL_DOT3_RGB 0x86AE")]
        public const int GL_DOT3_RGB = 0x86AE;

        [NativeTypeName("#define GL_DOT3_RGBA 0x86AF")]
        public const int GL_DOT3_RGBA = 0x86AF;

        [NativeTypeName("#define GL_CLAMP_TO_BORDER 0x812D")]
        public const int GL_CLAMP_TO_BORDER = 0x812D;

        [NativeTypeName("#define GL_ARB_multitexture 1")]
        public const int GL_ARB_multitexture = 1;

        [NativeTypeName("#define GL_TEXTURE0_ARB 0x84C0")]
        public const int GL_TEXTURE0_ARB = 0x84C0;

        [NativeTypeName("#define GL_TEXTURE1_ARB 0x84C1")]
        public const int GL_TEXTURE1_ARB = 0x84C1;

        [NativeTypeName("#define GL_TEXTURE2_ARB 0x84C2")]
        public const int GL_TEXTURE2_ARB = 0x84C2;

        [NativeTypeName("#define GL_TEXTURE3_ARB 0x84C3")]
        public const int GL_TEXTURE3_ARB = 0x84C3;

        [NativeTypeName("#define GL_TEXTURE4_ARB 0x84C4")]
        public const int GL_TEXTURE4_ARB = 0x84C4;

        [NativeTypeName("#define GL_TEXTURE5_ARB 0x84C5")]
        public const int GL_TEXTURE5_ARB = 0x84C5;

        [NativeTypeName("#define GL_TEXTURE6_ARB 0x84C6")]
        public const int GL_TEXTURE6_ARB = 0x84C6;

        [NativeTypeName("#define GL_TEXTURE7_ARB 0x84C7")]
        public const int GL_TEXTURE7_ARB = 0x84C7;

        [NativeTypeName("#define GL_TEXTURE8_ARB 0x84C8")]
        public const int GL_TEXTURE8_ARB = 0x84C8;

        [NativeTypeName("#define GL_TEXTURE9_ARB 0x84C9")]
        public const int GL_TEXTURE9_ARB = 0x84C9;

        [NativeTypeName("#define GL_TEXTURE10_ARB 0x84CA")]
        public const int GL_TEXTURE10_ARB = 0x84CA;

        [NativeTypeName("#define GL_TEXTURE11_ARB 0x84CB")]
        public const int GL_TEXTURE11_ARB = 0x84CB;

        [NativeTypeName("#define GL_TEXTURE12_ARB 0x84CC")]
        public const int GL_TEXTURE12_ARB = 0x84CC;

        [NativeTypeName("#define GL_TEXTURE13_ARB 0x84CD")]
        public const int GL_TEXTURE13_ARB = 0x84CD;

        [NativeTypeName("#define GL_TEXTURE14_ARB 0x84CE")]
        public const int GL_TEXTURE14_ARB = 0x84CE;

        [NativeTypeName("#define GL_TEXTURE15_ARB 0x84CF")]
        public const int GL_TEXTURE15_ARB = 0x84CF;

        [NativeTypeName("#define GL_TEXTURE16_ARB 0x84D0")]
        public const int GL_TEXTURE16_ARB = 0x84D0;

        [NativeTypeName("#define GL_TEXTURE17_ARB 0x84D1")]
        public const int GL_TEXTURE17_ARB = 0x84D1;

        [NativeTypeName("#define GL_TEXTURE18_ARB 0x84D2")]
        public const int GL_TEXTURE18_ARB = 0x84D2;

        [NativeTypeName("#define GL_TEXTURE19_ARB 0x84D3")]
        public const int GL_TEXTURE19_ARB = 0x84D3;

        [NativeTypeName("#define GL_TEXTURE20_ARB 0x84D4")]
        public const int GL_TEXTURE20_ARB = 0x84D4;

        [NativeTypeName("#define GL_TEXTURE21_ARB 0x84D5")]
        public const int GL_TEXTURE21_ARB = 0x84D5;

        [NativeTypeName("#define GL_TEXTURE22_ARB 0x84D6")]
        public const int GL_TEXTURE22_ARB = 0x84D6;

        [NativeTypeName("#define GL_TEXTURE23_ARB 0x84D7")]
        public const int GL_TEXTURE23_ARB = 0x84D7;

        [NativeTypeName("#define GL_TEXTURE24_ARB 0x84D8")]
        public const int GL_TEXTURE24_ARB = 0x84D8;

        [NativeTypeName("#define GL_TEXTURE25_ARB 0x84D9")]
        public const int GL_TEXTURE25_ARB = 0x84D9;

        [NativeTypeName("#define GL_TEXTURE26_ARB 0x84DA")]
        public const int GL_TEXTURE26_ARB = 0x84DA;

        [NativeTypeName("#define GL_TEXTURE27_ARB 0x84DB")]
        public const int GL_TEXTURE27_ARB = 0x84DB;

        [NativeTypeName("#define GL_TEXTURE28_ARB 0x84DC")]
        public const int GL_TEXTURE28_ARB = 0x84DC;

        [NativeTypeName("#define GL_TEXTURE29_ARB 0x84DD")]
        public const int GL_TEXTURE29_ARB = 0x84DD;

        [NativeTypeName("#define GL_TEXTURE30_ARB 0x84DE")]
        public const int GL_TEXTURE30_ARB = 0x84DE;

        [NativeTypeName("#define GL_TEXTURE31_ARB 0x84DF")]
        public const int GL_TEXTURE31_ARB = 0x84DF;

        [NativeTypeName("#define GL_ACTIVE_TEXTURE_ARB 0x84E0")]
        public const int GL_ACTIVE_TEXTURE_ARB = 0x84E0;

        [NativeTypeName("#define GL_CLIENT_ACTIVE_TEXTURE_ARB 0x84E1")]
        public const int GL_CLIENT_ACTIVE_TEXTURE_ARB = 0x84E1;

        [NativeTypeName("#define GL_MAX_TEXTURE_UNITS_ARB 0x84E2")]
        public const int GL_MAX_TEXTURE_UNITS_ARB = 0x84E2;

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPixelFormatName", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* GetPixelFormatName([NativeTypeName("Uint32")] uint format);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PixelFormatEnumToMasks", ExactSpelling = true)]
        public static extern SDL_bool PixelFormatEnumToMasks([NativeTypeName("Uint32")] uint format, int* bpp, [NativeTypeName("Uint32 *")] uint* Rmask, [NativeTypeName("Uint32 *")] uint* Gmask, [NativeTypeName("Uint32 *")] uint* Bmask, [NativeTypeName("Uint32 *")] uint* Amask);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_MasksToPixelFormatEnum", ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint MasksToPixelFormatEnum(int bpp, [NativeTypeName("Uint32")] uint Rmask, [NativeTypeName("Uint32")] uint Gmask, [NativeTypeName("Uint32")] uint Bmask, [NativeTypeName("Uint32")] uint Amask);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AllocFormat", ExactSpelling = true)]
        public static extern SDL_PixelFormat* AllocFormat([NativeTypeName("Uint32")] uint pixel_format);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FreeFormat", ExactSpelling = true)]
        public static extern void FreeFormat(SDL_PixelFormat* format);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AllocPalette", ExactSpelling = true)]
        public static extern SDL_Palette* AllocPalette(int ncolors);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetPixelFormatPalette", ExactSpelling = true)]
        public static extern int SetPixelFormatPalette(SDL_PixelFormat* format, SDL_Palette* palette);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetPaletteColors", ExactSpelling = true)]
        public static extern int SetPaletteColors(SDL_Palette* palette, [NativeTypeName("const SDL_Color *")] SDL_Color* colors, int firstcolor, int ncolors);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FreePalette", ExactSpelling = true)]
        public static extern void FreePalette(SDL_Palette* palette);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_MapRGB", ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint MapRGB([NativeTypeName("const SDL_PixelFormat *")] SDL_PixelFormat* format, [NativeTypeName("Uint8")] byte r, [NativeTypeName("Uint8")] byte g, [NativeTypeName("Uint8")] byte b);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_MapRGBA", ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint MapRGBA([NativeTypeName("const SDL_PixelFormat *")] SDL_PixelFormat* format, [NativeTypeName("Uint8")] byte r, [NativeTypeName("Uint8")] byte g, [NativeTypeName("Uint8")] byte b, [NativeTypeName("Uint8")] byte a);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRGB", ExactSpelling = true)]
        public static extern void GetRGB([NativeTypeName("Uint32")] uint pixel, [NativeTypeName("const SDL_PixelFormat *")] SDL_PixelFormat* format, [NativeTypeName("Uint8 *")] byte* r, [NativeTypeName("Uint8 *")] byte* g, [NativeTypeName("Uint8 *")] byte* b);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRGBA", ExactSpelling = true)]
        public static extern void GetRGBA([NativeTypeName("Uint32")] uint pixel, [NativeTypeName("const SDL_PixelFormat *")] SDL_PixelFormat* format, [NativeTypeName("Uint8 *")] byte* r, [NativeTypeName("Uint8 *")] byte* g, [NativeTypeName("Uint8 *")] byte* b, [NativeTypeName("Uint8 *")] byte* a);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CalculateGammaRamp", ExactSpelling = true)]
        public static extern void CalculateGammaRamp(float gamma, [NativeTypeName("Uint16 *")] ushort* ramp);

        [NativeTypeName("#define SDL_ALPHA_OPAQUE 255")]
        public const int SDL_ALPHA_OPAQUE = 255;

        [NativeTypeName("#define SDL_ALPHA_TRANSPARENT 0")]
        public const int SDL_ALPHA_TRANSPARENT = 0;

        [NativeTypeName("#define HAVE_WCSDUP 1")]
        public const int HAVE_WCSDUP = 1;

        [NativeTypeName("#define HAVE_WCSCASECMP 1")]
        public const int HAVE_WCSCASECMP = 1;

        [NativeTypeName("#define HAVE_WCSNCASECMP 1")]
        public const int HAVE_WCSNCASECMP = 1;

        [NativeTypeName("#define HAVE_FSEEKO 1")]
        public const int HAVE_FSEEKO = 1;

        [NativeTypeName("#define HAVE_FSEEKO64 1")]
        public const int HAVE_FSEEKO64 = 1;

        [NativeTypeName("#define HAVE_SA_SIGACTION 1")]
        public const int HAVE_SA_SIGACTION = 1;

        [NativeTypeName("#define HAVE_MPROTECT 1")]
        public const int HAVE_MPROTECT = 1;

        [NativeTypeName("#define HAVE_ICONV 1")]
        public const int HAVE_ICONV = 1;

        [NativeTypeName("#define SDL_CPUINFO_DISABLED 1")]
        public const int SDL_CPUINFO_DISABLED = 1;

        [NativeTypeName("#define SDL_AUDIO_DRIVER_EMSCRIPTEN 1")]
        public const int SDL_AUDIO_DRIVER_EMSCRIPTEN = 1;

        [NativeTypeName("#define SDL_JOYSTICK_EMSCRIPTEN 1")]
        public const int SDL_JOYSTICK_EMSCRIPTEN = 1;

        [NativeTypeName("#define SDL_VIDEO_DRIVER_EMSCRIPTEN 1")]
        public const int SDL_VIDEO_DRIVER_EMSCRIPTEN = 1;

        [NativeTypeName("#define SDL_POWER_EMSCRIPTEN 1")]
        public const int SDL_POWER_EMSCRIPTEN = 1;

        [NativeTypeName("#define SDL_FILESYSTEM_EMSCRIPTEN 1")]
        public const int SDL_FILESYSTEM_EMSCRIPTEN = 1;

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_Init", ExactSpelling = true)]
        public static extern int Init([NativeTypeName("Uint32")] uint flags);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_InitSubSystem", ExactSpelling = true)]
        public static extern int InitSubSystem([NativeTypeName("Uint32")] uint flags);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_QuitSubSystem", ExactSpelling = true)]
        public static extern void QuitSubSystem([NativeTypeName("Uint32")] uint flags);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WasInit", ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint WasInit([NativeTypeName("Uint32")] uint flags);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_Quit", ExactSpelling = true)]
        public static extern void Quit();

        [NativeTypeName("#define SDL_INIT_TIMER 0x00000001u")]
        public const uint SDL_INIT_TIMER = 0x00000001U;

        [NativeTypeName("#define SDL_INIT_AUDIO 0x00000010u")]
        public const uint SDL_INIT_AUDIO = 0x00000010U;

        [NativeTypeName("#define SDL_INIT_VIDEO 0x00000020u")]
        public const uint SDL_INIT_VIDEO = 0x00000020U;

        [NativeTypeName("#define SDL_INIT_JOYSTICK 0x00000200u")]
        public const uint SDL_INIT_JOYSTICK = 0x00000200U;

        [NativeTypeName("#define SDL_INIT_HAPTIC 0x00001000u")]
        public const uint SDL_INIT_HAPTIC = 0x00001000U;

        [NativeTypeName("#define SDL_INIT_GAMECONTROLLER 0x00002000u")]
        public const uint SDL_INIT_GAMECONTROLLER = 0x00002000U;

        [NativeTypeName("#define SDL_INIT_EVENTS 0x00004000u")]
        public const uint SDL_INIT_EVENTS = 0x00004000U;

        [NativeTypeName("#define SDL_INIT_SENSOR 0x00008000u")]
        public const uint SDL_INIT_SENSOR = 0x00008000U;

        [NativeTypeName("#define SDL_INIT_NOPARACHUTE 0x00100000u")]
        public const uint SDL_INIT_NOPARACHUTE = 0x00100000U;

        [NativeTypeName("#define SDL_INIT_EVERYTHING ( \\\n                SDL_INIT_TIMER | SDL_INIT_AUDIO | SDL_INIT_VIDEO | SDL_INIT_EVENTS | \\\n                SDL_INIT_JOYSTICK | SDL_INIT_HAPTIC | SDL_INIT_GAMECONTROLLER | SDL_INIT_SENSOR \\\n            )")]
        public const uint SDL_INIT_EVERYTHING = (0x00000001U | 0x00000010U | 0x00000020U | 0x00004000U | 0x00000200U | 0x00001000U | 0x00002000U | 0x00008000U);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumAudioDrivers", ExactSpelling = true)]
        public static extern int GetNumAudioDrivers();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioDriver", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* GetAudioDriver(int index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AudioInit", ExactSpelling = true)]
        public static extern int AudioInit([NativeTypeName("const char *")] sbyte* driver_name);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AudioQuit", ExactSpelling = true)]
        public static extern void AudioQuit();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCurrentAudioDriver", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* GetCurrentAudioDriver();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenAudio", ExactSpelling = true)]
        public static extern int OpenAudio(SDL_AudioSpec* desired, SDL_AudioSpec* obtained);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumAudioDevices", ExactSpelling = true)]
        public static extern int GetNumAudioDevices(int iscapture);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioDeviceName", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* GetAudioDeviceName(int index, int iscapture);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioDeviceSpec", ExactSpelling = true)]
        public static extern int GetAudioDeviceSpec(int index, int iscapture, SDL_AudioSpec* spec);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDefaultAudioInfo", ExactSpelling = true)]
        public static extern int GetDefaultAudioInfo([NativeTypeName("char **")] sbyte** name, SDL_AudioSpec* spec, int iscapture);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenAudioDevice", ExactSpelling = true)]
        [return: NativeTypeName("SDL_AudioDeviceID")]
        public static extern uint OpenAudioDevice([NativeTypeName("const char *")] sbyte* device, int iscapture, [NativeTypeName("const SDL_AudioSpec *")] SDL_AudioSpec* desired, SDL_AudioSpec* obtained, int allowed_changes);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioStatus", ExactSpelling = true)]
        public static extern SDL_AudioStatus GetAudioStatus();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioDeviceStatus", ExactSpelling = true)]
        public static extern SDL_AudioStatus GetAudioDeviceStatus([NativeTypeName("SDL_AudioDeviceID")] uint dev);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PauseAudio", ExactSpelling = true)]
        public static extern void PauseAudio(int pause_on);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PauseAudioDevice", ExactSpelling = true)]
        public static extern void PauseAudioDevice([NativeTypeName("SDL_AudioDeviceID")] uint dev, int pause_on);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LoadWAV_RW", ExactSpelling = true)]
        public static extern SDL_AudioSpec* LoadWAV_RW(SDL_RWops* src, int freesrc, SDL_AudioSpec* spec, [NativeTypeName("Uint8 **")] byte** audio_buf, [NativeTypeName("Uint32 *")] uint* audio_len);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FreeWAV", ExactSpelling = true)]
        public static extern void FreeWAV([NativeTypeName("Uint8 *")] byte* audio_buf);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BuildAudioCVT", ExactSpelling = true)]
        public static extern int BuildAudioCVT(SDL_AudioCVT* cvt, [NativeTypeName("SDL_AudioFormat")] ushort src_format, [NativeTypeName("Uint8")] byte src_channels, int src_rate, [NativeTypeName("SDL_AudioFormat")] ushort dst_format, [NativeTypeName("Uint8")] byte dst_channels, int dst_rate);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ConvertAudio", ExactSpelling = true)]
        public static extern int ConvertAudio(SDL_AudioCVT* cvt);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_NewAudioStream", ExactSpelling = true)]
        [return: NativeTypeName("SDL_AudioStream *")]
        public static extern _SDL_AudioStream* NewAudioStream([NativeTypeName("const SDL_AudioFormat")] ushort src_format, [NativeTypeName("const Uint8")] byte src_channels, [NativeTypeName("const int")] int src_rate, [NativeTypeName("const SDL_AudioFormat")] ushort dst_format, [NativeTypeName("const Uint8")] byte dst_channels, [NativeTypeName("const int")] int dst_rate);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AudioStreamPut", ExactSpelling = true)]
        public static extern int AudioStreamPut([NativeTypeName("SDL_AudioStream *")] _SDL_AudioStream* stream, [NativeTypeName("const void *")] void* buf, int len);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AudioStreamGet", ExactSpelling = true)]
        public static extern int AudioStreamGet([NativeTypeName("SDL_AudioStream *")] _SDL_AudioStream* stream, void* buf, int len);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AudioStreamAvailable", ExactSpelling = true)]
        public static extern int AudioStreamAvailable([NativeTypeName("SDL_AudioStream *")] _SDL_AudioStream* stream);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AudioStreamFlush", ExactSpelling = true)]
        public static extern int AudioStreamFlush([NativeTypeName("SDL_AudioStream *")] _SDL_AudioStream* stream);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AudioStreamClear", ExactSpelling = true)]
        public static extern void AudioStreamClear([NativeTypeName("SDL_AudioStream *")] _SDL_AudioStream* stream);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FreeAudioStream", ExactSpelling = true)]
        public static extern void FreeAudioStream([NativeTypeName("SDL_AudioStream *")] _SDL_AudioStream* stream);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_MixAudio", ExactSpelling = true)]
        public static extern void MixAudio([NativeTypeName("Uint8 *")] byte* dst, [NativeTypeName("const Uint8 *")] byte* src, [NativeTypeName("Uint32")] uint len, int volume);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_MixAudioFormat", ExactSpelling = true)]
        public static extern void MixAudioFormat([NativeTypeName("Uint8 *")] byte* dst, [NativeTypeName("const Uint8 *")] byte* src, [NativeTypeName("SDL_AudioFormat")] ushort format, [NativeTypeName("Uint32")] uint len, int volume);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_QueueAudio", ExactSpelling = true)]
        public static extern int QueueAudio([NativeTypeName("SDL_AudioDeviceID")] uint dev, [NativeTypeName("const void *")] void* data, [NativeTypeName("Uint32")] uint len);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DequeueAudio", ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint DequeueAudio([NativeTypeName("SDL_AudioDeviceID")] uint dev, void* data, [NativeTypeName("Uint32")] uint len);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetQueuedAudioSize", ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint GetQueuedAudioSize([NativeTypeName("SDL_AudioDeviceID")] uint dev);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ClearQueuedAudio", ExactSpelling = true)]
        public static extern void ClearQueuedAudio([NativeTypeName("SDL_AudioDeviceID")] uint dev);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LockAudio", ExactSpelling = true)]
        public static extern void LockAudio();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LockAudioDevice", ExactSpelling = true)]
        public static extern void LockAudioDevice([NativeTypeName("SDL_AudioDeviceID")] uint dev);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnlockAudio", ExactSpelling = true)]
        public static extern void UnlockAudio();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnlockAudioDevice", ExactSpelling = true)]
        public static extern void UnlockAudioDevice([NativeTypeName("SDL_AudioDeviceID")] uint dev);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CloseAudio", ExactSpelling = true)]
        public static extern void CloseAudio();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CloseAudioDevice", ExactSpelling = true)]
        public static extern void CloseAudioDevice([NativeTypeName("SDL_AudioDeviceID")] uint dev);

        [NativeTypeName("#define SDL_AUDIO_MASK_BITSIZE (0xFF)")]
        public const int SDL_AUDIO_MASK_BITSIZE = (0xFF);

        [NativeTypeName("#define SDL_AUDIO_MASK_DATATYPE (1<<8)")]
        public const int SDL_AUDIO_MASK_DATATYPE = (1 << 8);

        [NativeTypeName("#define SDL_AUDIO_MASK_ENDIAN (1<<12)")]
        public const int SDL_AUDIO_MASK_ENDIAN = (1 << 12);

        [NativeTypeName("#define SDL_AUDIO_MASK_SIGNED (1<<15)")]
        public const int SDL_AUDIO_MASK_SIGNED = (1 << 15);

        [NativeTypeName("#define AUDIO_U8 0x0008")]
        public const int AUDIO_U8 = 0x0008;

        [NativeTypeName("#define AUDIO_S8 0x8008")]
        public const int AUDIO_S8 = 0x8008;

        [NativeTypeName("#define AUDIO_U16LSB 0x0010")]
        public const int AUDIO_U16LSB = 0x0010;

        [NativeTypeName("#define AUDIO_S16LSB 0x8010")]
        public const int AUDIO_S16LSB = 0x8010;

        [NativeTypeName("#define AUDIO_U16MSB 0x1010")]
        public const int AUDIO_U16MSB = 0x1010;

        [NativeTypeName("#define AUDIO_S16MSB 0x9010")]
        public const int AUDIO_S16MSB = 0x9010;

        [NativeTypeName("#define AUDIO_U16 AUDIO_U16LSB")]
        public const int AUDIO_U16 = 0x0010;

        [NativeTypeName("#define AUDIO_S16 AUDIO_S16LSB")]
        public const int AUDIO_S16 = 0x8010;

        [NativeTypeName("#define AUDIO_S32LSB 0x8020")]
        public const int AUDIO_S32LSB = 0x8020;

        [NativeTypeName("#define AUDIO_S32MSB 0x9020")]
        public const int AUDIO_S32MSB = 0x9020;

        [NativeTypeName("#define AUDIO_S32 AUDIO_S32LSB")]
        public const int AUDIO_S32 = 0x8020;

        [NativeTypeName("#define AUDIO_F32LSB 0x8120")]
        public const int AUDIO_F32LSB = 0x8120;

        [NativeTypeName("#define AUDIO_F32MSB 0x9120")]
        public const int AUDIO_F32MSB = 0x9120;

        [NativeTypeName("#define AUDIO_F32 AUDIO_F32LSB")]
        public const int AUDIO_F32 = 0x8120;

        [NativeTypeName("#define AUDIO_U16SYS AUDIO_U16LSB")]
        public const int AUDIO_U16SYS = 0x0010;

        [NativeTypeName("#define AUDIO_S16SYS AUDIO_S16LSB")]
        public const int AUDIO_S16SYS = 0x8010;

        [NativeTypeName("#define AUDIO_S32SYS AUDIO_S32LSB")]
        public const int AUDIO_S32SYS = 0x8020;

        [NativeTypeName("#define AUDIO_F32SYS AUDIO_F32LSB")]
        public const int AUDIO_F32SYS = 0x8120;

        [NativeTypeName("#define SDL_AUDIO_ALLOW_FREQUENCY_CHANGE 0x00000001")]
        public const int SDL_AUDIO_ALLOW_FREQUENCY_CHANGE = 0x00000001;

        [NativeTypeName("#define SDL_AUDIO_ALLOW_FORMAT_CHANGE 0x00000002")]
        public const int SDL_AUDIO_ALLOW_FORMAT_CHANGE = 0x00000002;

        [NativeTypeName("#define SDL_AUDIO_ALLOW_CHANNELS_CHANGE 0x00000004")]
        public const int SDL_AUDIO_ALLOW_CHANNELS_CHANGE = 0x00000004;

        [NativeTypeName("#define SDL_AUDIO_ALLOW_SAMPLES_CHANGE 0x00000008")]
        public const int SDL_AUDIO_ALLOW_SAMPLES_CHANGE = 0x00000008;

        [NativeTypeName("#define SDL_AUDIO_ALLOW_ANY_CHANGE (SDL_AUDIO_ALLOW_FREQUENCY_CHANGE|SDL_AUDIO_ALLOW_FORMAT_CHANGE|SDL_AUDIO_ALLOW_CHANNELS_CHANGE|SDL_AUDIO_ALLOW_SAMPLES_CHANGE)")]
        public const int SDL_AUDIO_ALLOW_ANY_CHANGE = (0x00000001 | 0x00000002 | 0x00000004 | 0x00000008);

        [NativeTypeName("#define SDL_AUDIOCVT_MAX_FILTERS 9")]
        public const int SDL_AUDIOCVT_MAX_FILTERS = 9;

        [NativeTypeName("#define SDL_MIX_MAXVOLUME 128")]
        public const int SDL_MIX_MAXVOLUME = 128;

        [NativeTypeName("#define SDL_AUDIO_DRIVER_OS2 1")]
        public const int SDL_AUDIO_DRIVER_OS2 = 1;

        [NativeTypeName("#define SDL_POWER_DISABLED 1")]
        public const int SDL_POWER_DISABLED = 1;

        [NativeTypeName("#define SDL_VIDEO_DRIVER_OS2 1")]
        public const int SDL_VIDEO_DRIVER_OS2 = 1;

        [NativeTypeName("#define SDL_JOYSTICK_OS2 1")]
        public const int SDL_JOYSTICK_OS2 = 1;

        [NativeTypeName("#define SDL_THREAD_OS2 1")]
        public const int SDL_THREAD_OS2 = 1;

        [NativeTypeName("#define SDL_LOADSO_OS2 1")]
        public const int SDL_LOADSO_OS2 = 1;

        [NativeTypeName("#define SDL_TIMER_OS2 1")]
        public const int SDL_TIMER_OS2 = 1;

        [NativeTypeName("#define SDL_FILESYSTEM_OS2 1")]
        public const int SDL_FILESYSTEM_OS2 = 1;

        [NativeTypeName("#define SDL_LIBSAMPLERATE_DYNAMIC \"SAMPRATE.DLL\"")]
        public static ReadOnlySpan<byte> SDL_LIBSAMPLERATE_DYNAMIC => new byte[] { 0x53, 0x41, 0x4D, 0x50, 0x52, 0x41, 0x54, 0x45, 0x2E, 0x44, 0x4C, 0x4C, 0x00 };

        [NativeTypeName("#define HAVE_LIBC 1")]
        public const int HAVE_LIBC = 1;

        [NativeTypeName("#define HAVE_FLOAT_H 1")]
        public const int HAVE_FLOAT_H = 1;

        [NativeTypeName("#define HAVE_WCSLCPY 1")]
        public const int HAVE_WCSLCPY = 1;

        [NativeTypeName("#define HAVE_WCSLCAT 1")]
        public const int HAVE_WCSLCAT = 1;

        [NativeTypeName("#define HAVE__WCSICMP 1")]
        public const int HAVE__WCSICMP = 1;

        [NativeTypeName("#define HAVE__WCSNICMP 1")]
        public const int HAVE__WCSNICMP = 1;

        [NativeTypeName("#define HAVE__WCSDUP 1")]
        public const int HAVE__WCSDUP = 1;

        [NativeTypeName("#define HAVE__STRREV 1")]
        public const int HAVE__STRREV = 1;

        [NativeTypeName("#define HAVE__STRUPR 1")]
        public const int HAVE__STRUPR = 1;

        [NativeTypeName("#define HAVE__STRLWR 1")]
        public const int HAVE__STRLWR = 1;

        [NativeTypeName("#define HAVE_ITOA 1")]
        public const int HAVE_ITOA = 1;

        [NativeTypeName("#define HAVE__LTOA 1")]
        public const int HAVE__LTOA = 1;

        [NativeTypeName("#define HAVE__ULTOA 1")]
        public const int HAVE__ULTOA = 1;

        [NativeTypeName("#define HAVE__I64TOA 1")]
        public const int HAVE__I64TOA = 1;

        [NativeTypeName("#define HAVE__UI64TOA 1")]
        public const int HAVE__UI64TOA = 1;

        [NativeTypeName("#define HAVE_STRICMP 1")]
        public const int HAVE_STRICMP = 1;

        [NativeTypeName("#define HAVE_SNPRINTF 1")]
        public const int HAVE_SNPRINTF = 1;

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetHintWithPriority", ExactSpelling = true)]
        public static extern SDL_bool SetHintWithPriority([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* value, SDL_HintPriority priority);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetHint", ExactSpelling = true)]
        public static extern SDL_bool SetHint([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* value);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ResetHint", ExactSpelling = true)]
        public static extern SDL_bool ResetHint([NativeTypeName("const char *")] sbyte* name);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ResetHints", ExactSpelling = true)]
        public static extern void ResetHints();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetHint", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* GetHint([NativeTypeName("const char *")] sbyte* name);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetHintBoolean", ExactSpelling = true)]
        public static extern SDL_bool GetHintBoolean([NativeTypeName("const char *")] sbyte* name, SDL_bool default_value);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AddHintCallback", ExactSpelling = true)]
        public static extern void AddHintCallback([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("SDL_HintCallback")] delegate* unmanaged[Cdecl]<void*, sbyte*, sbyte*, sbyte*, void> callback, void* userdata);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DelHintCallback", ExactSpelling = true)]
        public static extern void DelHintCallback([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("SDL_HintCallback")] delegate* unmanaged[Cdecl]<void*, sbyte*, sbyte*, sbyte*, void> callback, void* userdata);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ClearHints", ExactSpelling = true)]
        public static extern void ClearHints();

        [NativeTypeName("#define SDL_HINT_ACCELEROMETER_AS_JOYSTICK \"SDL_ACCELEROMETER_AS_JOYSTICK\"")]
        public static ReadOnlySpan<byte> SDL_HINT_ACCELEROMETER_AS_JOYSTICK => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x41, 0x43, 0x43, 0x45, 0x4C, 0x45, 0x52, 0x4F, 0x4D, 0x45, 0x54, 0x45, 0x52, 0x5F, 0x41, 0x53, 0x5F, 0x4A, 0x4F, 0x59, 0x53, 0x54, 0x49, 0x43, 0x4B, 0x00 };

        [NativeTypeName("#define SDL_HINT_ALLOW_ALT_TAB_WHILE_GRABBED \"SDL_ALLOW_ALT_TAB_WHILE_GRABBED\"")]
        public static ReadOnlySpan<byte> SDL_HINT_ALLOW_ALT_TAB_WHILE_GRABBED => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x41, 0x4C, 0x4C, 0x4F, 0x57, 0x5F, 0x41, 0x4C, 0x54, 0x5F, 0x54, 0x41, 0x42, 0x5F, 0x57, 0x48, 0x49, 0x4C, 0x45, 0x5F, 0x47, 0x52, 0x41, 0x42, 0x42, 0x45, 0x44, 0x00 };

        [NativeTypeName("#define SDL_HINT_ALLOW_TOPMOST \"SDL_ALLOW_TOPMOST\"")]
        public static ReadOnlySpan<byte> SDL_HINT_ALLOW_TOPMOST => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x41, 0x4C, 0x4C, 0x4F, 0x57, 0x5F, 0x54, 0x4F, 0x50, 0x4D, 0x4F, 0x53, 0x54, 0x00 };

        [NativeTypeName("#define SDL_HINT_ANDROID_APK_EXPANSION_MAIN_FILE_VERSION \"SDL_ANDROID_APK_EXPANSION_MAIN_FILE_VERSION\"")]
        public static ReadOnlySpan<byte> SDL_HINT_ANDROID_APK_EXPANSION_MAIN_FILE_VERSION => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x41, 0x4E, 0x44, 0x52, 0x4F, 0x49, 0x44, 0x5F, 0x41, 0x50, 0x4B, 0x5F, 0x45, 0x58, 0x50, 0x41, 0x4E, 0x53, 0x49, 0x4F, 0x4E, 0x5F, 0x4D, 0x41, 0x49, 0x4E, 0x5F, 0x46, 0x49, 0x4C, 0x45, 0x5F, 0x56, 0x45, 0x52, 0x53, 0x49, 0x4F, 0x4E, 0x00 };

        [NativeTypeName("#define SDL_HINT_ANDROID_APK_EXPANSION_PATCH_FILE_VERSION \"SDL_ANDROID_APK_EXPANSION_PATCH_FILE_VERSION\"")]
        public static ReadOnlySpan<byte> SDL_HINT_ANDROID_APK_EXPANSION_PATCH_FILE_VERSION => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x41, 0x4E, 0x44, 0x52, 0x4F, 0x49, 0x44, 0x5F, 0x41, 0x50, 0x4B, 0x5F, 0x45, 0x58, 0x50, 0x41, 0x4E, 0x53, 0x49, 0x4F, 0x4E, 0x5F, 0x50, 0x41, 0x54, 0x43, 0x48, 0x5F, 0x46, 0x49, 0x4C, 0x45, 0x5F, 0x56, 0x45, 0x52, 0x53, 0x49, 0x4F, 0x4E, 0x00 };

        [NativeTypeName("#define SDL_HINT_ANDROID_BLOCK_ON_PAUSE \"SDL_ANDROID_BLOCK_ON_PAUSE\"")]
        public static ReadOnlySpan<byte> SDL_HINT_ANDROID_BLOCK_ON_PAUSE => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x41, 0x4E, 0x44, 0x52, 0x4F, 0x49, 0x44, 0x5F, 0x42, 0x4C, 0x4F, 0x43, 0x4B, 0x5F, 0x4F, 0x4E, 0x5F, 0x50, 0x41, 0x55, 0x53, 0x45, 0x00 };

        [NativeTypeName("#define SDL_HINT_ANDROID_BLOCK_ON_PAUSE_PAUSEAUDIO \"SDL_ANDROID_BLOCK_ON_PAUSE_PAUSEAUDIO\"")]
        public static ReadOnlySpan<byte> SDL_HINT_ANDROID_BLOCK_ON_PAUSE_PAUSEAUDIO => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x41, 0x4E, 0x44, 0x52, 0x4F, 0x49, 0x44, 0x5F, 0x42, 0x4C, 0x4F, 0x43, 0x4B, 0x5F, 0x4F, 0x4E, 0x5F, 0x50, 0x41, 0x55, 0x53, 0x45, 0x5F, 0x50, 0x41, 0x55, 0x53, 0x45, 0x41, 0x55, 0x44, 0x49, 0x4F, 0x00 };

        [NativeTypeName("#define SDL_HINT_ANDROID_TRAP_BACK_BUTTON \"SDL_ANDROID_TRAP_BACK_BUTTON\"")]
        public static ReadOnlySpan<byte> SDL_HINT_ANDROID_TRAP_BACK_BUTTON => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x41, 0x4E, 0x44, 0x52, 0x4F, 0x49, 0x44, 0x5F, 0x54, 0x52, 0x41, 0x50, 0x5F, 0x42, 0x41, 0x43, 0x4B, 0x5F, 0x42, 0x55, 0x54, 0x54, 0x4F, 0x4E, 0x00 };

        [NativeTypeName("#define SDL_HINT_APP_NAME \"SDL_APP_NAME\"")]
        public static ReadOnlySpan<byte> SDL_HINT_APP_NAME => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x41, 0x50, 0x50, 0x5F, 0x4E, 0x41, 0x4D, 0x45, 0x00 };

        [NativeTypeName("#define SDL_HINT_APPLE_TV_CONTROLLER_UI_EVENTS \"SDL_APPLE_TV_CONTROLLER_UI_EVENTS\"")]
        public static ReadOnlySpan<byte> SDL_HINT_APPLE_TV_CONTROLLER_UI_EVENTS => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x41, 0x50, 0x50, 0x4C, 0x45, 0x5F, 0x54, 0x56, 0x5F, 0x43, 0x4F, 0x4E, 0x54, 0x52, 0x4F, 0x4C, 0x4C, 0x45, 0x52, 0x5F, 0x55, 0x49, 0x5F, 0x45, 0x56, 0x45, 0x4E, 0x54, 0x53, 0x00 };

        [NativeTypeName("#define SDL_HINT_APPLE_TV_REMOTE_ALLOW_ROTATION \"SDL_APPLE_TV_REMOTE_ALLOW_ROTATION\"")]
        public static ReadOnlySpan<byte> SDL_HINT_APPLE_TV_REMOTE_ALLOW_ROTATION => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x41, 0x50, 0x50, 0x4C, 0x45, 0x5F, 0x54, 0x56, 0x5F, 0x52, 0x45, 0x4D, 0x4F, 0x54, 0x45, 0x5F, 0x41, 0x4C, 0x4C, 0x4F, 0x57, 0x5F, 0x52, 0x4F, 0x54, 0x41, 0x54, 0x49, 0x4F, 0x4E, 0x00 };

        [NativeTypeName("#define SDL_HINT_AUDIO_CATEGORY \"SDL_AUDIO_CATEGORY\"")]
        public static ReadOnlySpan<byte> SDL_HINT_AUDIO_CATEGORY => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x41, 0x55, 0x44, 0x49, 0x4F, 0x5F, 0x43, 0x41, 0x54, 0x45, 0x47, 0x4F, 0x52, 0x59, 0x00 };

        [NativeTypeName("#define SDL_HINT_AUDIO_DEVICE_APP_NAME \"SDL_AUDIO_DEVICE_APP_NAME\"")]
        public static ReadOnlySpan<byte> SDL_HINT_AUDIO_DEVICE_APP_NAME => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x41, 0x55, 0x44, 0x49, 0x4F, 0x5F, 0x44, 0x45, 0x56, 0x49, 0x43, 0x45, 0x5F, 0x41, 0x50, 0x50, 0x5F, 0x4E, 0x41, 0x4D, 0x45, 0x00 };

        [NativeTypeName("#define SDL_HINT_AUDIO_DEVICE_STREAM_NAME \"SDL_AUDIO_DEVICE_STREAM_NAME\"")]
        public static ReadOnlySpan<byte> SDL_HINT_AUDIO_DEVICE_STREAM_NAME => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x41, 0x55, 0x44, 0x49, 0x4F, 0x5F, 0x44, 0x45, 0x56, 0x49, 0x43, 0x45, 0x5F, 0x53, 0x54, 0x52, 0x45, 0x41, 0x4D, 0x5F, 0x4E, 0x41, 0x4D, 0x45, 0x00 };

        [NativeTypeName("#define SDL_HINT_AUDIO_DEVICE_STREAM_ROLE \"SDL_AUDIO_DEVICE_STREAM_ROLE\"")]
        public static ReadOnlySpan<byte> SDL_HINT_AUDIO_DEVICE_STREAM_ROLE => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x41, 0x55, 0x44, 0x49, 0x4F, 0x5F, 0x44, 0x45, 0x56, 0x49, 0x43, 0x45, 0x5F, 0x53, 0x54, 0x52, 0x45, 0x41, 0x4D, 0x5F, 0x52, 0x4F, 0x4C, 0x45, 0x00 };

        [NativeTypeName("#define SDL_HINT_AUDIO_RESAMPLING_MODE \"SDL_AUDIO_RESAMPLING_MODE\"")]
        public static ReadOnlySpan<byte> SDL_HINT_AUDIO_RESAMPLING_MODE => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x41, 0x55, 0x44, 0x49, 0x4F, 0x5F, 0x52, 0x45, 0x53, 0x41, 0x4D, 0x50, 0x4C, 0x49, 0x4E, 0x47, 0x5F, 0x4D, 0x4F, 0x44, 0x45, 0x00 };

        [NativeTypeName("#define SDL_HINT_AUTO_UPDATE_JOYSTICKS \"SDL_AUTO_UPDATE_JOYSTICKS\"")]
        public static ReadOnlySpan<byte> SDL_HINT_AUTO_UPDATE_JOYSTICKS => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x41, 0x55, 0x54, 0x4F, 0x5F, 0x55, 0x50, 0x44, 0x41, 0x54, 0x45, 0x5F, 0x4A, 0x4F, 0x59, 0x53, 0x54, 0x49, 0x43, 0x4B, 0x53, 0x00 };

        [NativeTypeName("#define SDL_HINT_AUTO_UPDATE_SENSORS \"SDL_AUTO_UPDATE_SENSORS\"")]
        public static ReadOnlySpan<byte> SDL_HINT_AUTO_UPDATE_SENSORS => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x41, 0x55, 0x54, 0x4F, 0x5F, 0x55, 0x50, 0x44, 0x41, 0x54, 0x45, 0x5F, 0x53, 0x45, 0x4E, 0x53, 0x4F, 0x52, 0x53, 0x00 };

        [NativeTypeName("#define SDL_HINT_BMP_SAVE_LEGACY_FORMAT \"SDL_BMP_SAVE_LEGACY_FORMAT\"")]
        public static ReadOnlySpan<byte> SDL_HINT_BMP_SAVE_LEGACY_FORMAT => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x42, 0x4D, 0x50, 0x5F, 0x53, 0x41, 0x56, 0x45, 0x5F, 0x4C, 0x45, 0x47, 0x41, 0x43, 0x59, 0x5F, 0x46, 0x4F, 0x52, 0x4D, 0x41, 0x54, 0x00 };

        [NativeTypeName("#define SDL_HINT_DISPLAY_USABLE_BOUNDS \"SDL_DISPLAY_USABLE_BOUNDS\"")]
        public static ReadOnlySpan<byte> SDL_HINT_DISPLAY_USABLE_BOUNDS => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x44, 0x49, 0x53, 0x50, 0x4C, 0x41, 0x59, 0x5F, 0x55, 0x53, 0x41, 0x42, 0x4C, 0x45, 0x5F, 0x42, 0x4F, 0x55, 0x4E, 0x44, 0x53, 0x00 };

        [NativeTypeName("#define SDL_HINT_EMSCRIPTEN_ASYNCIFY \"SDL_EMSCRIPTEN_ASYNCIFY\"")]
        public static ReadOnlySpan<byte> SDL_HINT_EMSCRIPTEN_ASYNCIFY => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x45, 0x4D, 0x53, 0x43, 0x52, 0x49, 0x50, 0x54, 0x45, 0x4E, 0x5F, 0x41, 0x53, 0x59, 0x4E, 0x43, 0x49, 0x46, 0x59, 0x00 };

        [NativeTypeName("#define SDL_HINT_EMSCRIPTEN_KEYBOARD_ELEMENT \"SDL_EMSCRIPTEN_KEYBOARD_ELEMENT\"")]
        public static ReadOnlySpan<byte> SDL_HINT_EMSCRIPTEN_KEYBOARD_ELEMENT => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x45, 0x4D, 0x53, 0x43, 0x52, 0x49, 0x50, 0x54, 0x45, 0x4E, 0x5F, 0x4B, 0x45, 0x59, 0x42, 0x4F, 0x41, 0x52, 0x44, 0x5F, 0x45, 0x4C, 0x45, 0x4D, 0x45, 0x4E, 0x54, 0x00 };

        [NativeTypeName("#define SDL_HINT_ENABLE_STEAM_CONTROLLERS \"SDL_ENABLE_STEAM_CONTROLLERS\"")]
        public static ReadOnlySpan<byte> SDL_HINT_ENABLE_STEAM_CONTROLLERS => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x45, 0x4E, 0x41, 0x42, 0x4C, 0x45, 0x5F, 0x53, 0x54, 0x45, 0x41, 0x4D, 0x5F, 0x43, 0x4F, 0x4E, 0x54, 0x52, 0x4F, 0x4C, 0x4C, 0x45, 0x52, 0x53, 0x00 };

        [NativeTypeName("#define SDL_HINT_EVENT_LOGGING \"SDL_EVENT_LOGGING\"")]
        public static ReadOnlySpan<byte> SDL_HINT_EVENT_LOGGING => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x45, 0x56, 0x45, 0x4E, 0x54, 0x5F, 0x4C, 0x4F, 0x47, 0x47, 0x49, 0x4E, 0x47, 0x00 };

        [NativeTypeName("#define SDL_HINT_FORCE_RAISEWINDOW \"SDL_HINT_FORCE_RAISEWINDOW\"")]
        public static ReadOnlySpan<byte> SDL_HINT_FORCE_RAISEWINDOW => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x48, 0x49, 0x4E, 0x54, 0x5F, 0x46, 0x4F, 0x52, 0x43, 0x45, 0x5F, 0x52, 0x41, 0x49, 0x53, 0x45, 0x57, 0x49, 0x4E, 0x44, 0x4F, 0x57, 0x00 };

        [NativeTypeName("#define SDL_HINT_FRAMEBUFFER_ACCELERATION \"SDL_FRAMEBUFFER_ACCELERATION\"")]
        public static ReadOnlySpan<byte> SDL_HINT_FRAMEBUFFER_ACCELERATION => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x46, 0x52, 0x41, 0x4D, 0x45, 0x42, 0x55, 0x46, 0x46, 0x45, 0x52, 0x5F, 0x41, 0x43, 0x43, 0x45, 0x4C, 0x45, 0x52, 0x41, 0x54, 0x49, 0x4F, 0x4E, 0x00 };

        [NativeTypeName("#define SDL_HINT_GAMECONTROLLERCONFIG \"SDL_GAMECONTROLLERCONFIG\"")]
        public static ReadOnlySpan<byte> SDL_HINT_GAMECONTROLLERCONFIG => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x47, 0x41, 0x4D, 0x45, 0x43, 0x4F, 0x4E, 0x54, 0x52, 0x4F, 0x4C, 0x4C, 0x45, 0x52, 0x43, 0x4F, 0x4E, 0x46, 0x49, 0x47, 0x00 };

        [NativeTypeName("#define SDL_HINT_GAMECONTROLLERCONFIG_FILE \"SDL_GAMECONTROLLERCONFIG_FILE\"")]
        public static ReadOnlySpan<byte> SDL_HINT_GAMECONTROLLERCONFIG_FILE => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x47, 0x41, 0x4D, 0x45, 0x43, 0x4F, 0x4E, 0x54, 0x52, 0x4F, 0x4C, 0x4C, 0x45, 0x52, 0x43, 0x4F, 0x4E, 0x46, 0x49, 0x47, 0x5F, 0x46, 0x49, 0x4C, 0x45, 0x00 };

        [NativeTypeName("#define SDL_HINT_GAMECONTROLLERTYPE \"SDL_GAMECONTROLLERTYPE\"")]
        public static ReadOnlySpan<byte> SDL_HINT_GAMECONTROLLERTYPE => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x47, 0x41, 0x4D, 0x45, 0x43, 0x4F, 0x4E, 0x54, 0x52, 0x4F, 0x4C, 0x4C, 0x45, 0x52, 0x54, 0x59, 0x50, 0x45, 0x00 };

        [NativeTypeName("#define SDL_HINT_GAMECONTROLLER_IGNORE_DEVICES \"SDL_GAMECONTROLLER_IGNORE_DEVICES\"")]
        public static ReadOnlySpan<byte> SDL_HINT_GAMECONTROLLER_IGNORE_DEVICES => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x47, 0x41, 0x4D, 0x45, 0x43, 0x4F, 0x4E, 0x54, 0x52, 0x4F, 0x4C, 0x4C, 0x45, 0x52, 0x5F, 0x49, 0x47, 0x4E, 0x4F, 0x52, 0x45, 0x5F, 0x44, 0x45, 0x56, 0x49, 0x43, 0x45, 0x53, 0x00 };

        [NativeTypeName("#define SDL_HINT_GAMECONTROLLER_IGNORE_DEVICES_EXCEPT \"SDL_GAMECONTROLLER_IGNORE_DEVICES_EXCEPT\"")]
        public static ReadOnlySpan<byte> SDL_HINT_GAMECONTROLLER_IGNORE_DEVICES_EXCEPT => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x47, 0x41, 0x4D, 0x45, 0x43, 0x4F, 0x4E, 0x54, 0x52, 0x4F, 0x4C, 0x4C, 0x45, 0x52, 0x5F, 0x49, 0x47, 0x4E, 0x4F, 0x52, 0x45, 0x5F, 0x44, 0x45, 0x56, 0x49, 0x43, 0x45, 0x53, 0x5F, 0x45, 0x58, 0x43, 0x45, 0x50, 0x54, 0x00 };

        [NativeTypeName("#define SDL_HINT_GAMECONTROLLER_USE_BUTTON_LABELS \"SDL_GAMECONTROLLER_USE_BUTTON_LABELS\"")]
        public static ReadOnlySpan<byte> SDL_HINT_GAMECONTROLLER_USE_BUTTON_LABELS => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x47, 0x41, 0x4D, 0x45, 0x43, 0x4F, 0x4E, 0x54, 0x52, 0x4F, 0x4C, 0x4C, 0x45, 0x52, 0x5F, 0x55, 0x53, 0x45, 0x5F, 0x42, 0x55, 0x54, 0x54, 0x4F, 0x4E, 0x5F, 0x4C, 0x41, 0x42, 0x45, 0x4C, 0x53, 0x00 };

        [NativeTypeName("#define SDL_HINT_GRAB_KEYBOARD \"SDL_GRAB_KEYBOARD\"")]
        public static ReadOnlySpan<byte> SDL_HINT_GRAB_KEYBOARD => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x47, 0x52, 0x41, 0x42, 0x5F, 0x4B, 0x45, 0x59, 0x42, 0x4F, 0x41, 0x52, 0x44, 0x00 };

        [NativeTypeName("#define SDL_HINT_HIDAPI_IGNORE_DEVICES \"SDL_HIDAPI_IGNORE_DEVICES\"")]
        public static ReadOnlySpan<byte> SDL_HINT_HIDAPI_IGNORE_DEVICES => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x48, 0x49, 0x44, 0x41, 0x50, 0x49, 0x5F, 0x49, 0x47, 0x4E, 0x4F, 0x52, 0x45, 0x5F, 0x44, 0x45, 0x56, 0x49, 0x43, 0x45, 0x53, 0x00 };

        [NativeTypeName("#define SDL_HINT_IDLE_TIMER_DISABLED \"SDL_IOS_IDLE_TIMER_DISABLED\"")]
        public static ReadOnlySpan<byte> SDL_HINT_IDLE_TIMER_DISABLED => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x49, 0x4F, 0x53, 0x5F, 0x49, 0x44, 0x4C, 0x45, 0x5F, 0x54, 0x49, 0x4D, 0x45, 0x52, 0x5F, 0x44, 0x49, 0x53, 0x41, 0x42, 0x4C, 0x45, 0x44, 0x00 };

        [NativeTypeName("#define SDL_HINT_IME_INTERNAL_EDITING \"SDL_IME_INTERNAL_EDITING\"")]
        public static ReadOnlySpan<byte> SDL_HINT_IME_INTERNAL_EDITING => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x49, 0x4D, 0x45, 0x5F, 0x49, 0x4E, 0x54, 0x45, 0x52, 0x4E, 0x41, 0x4C, 0x5F, 0x45, 0x44, 0x49, 0x54, 0x49, 0x4E, 0x47, 0x00 };

        [NativeTypeName("#define SDL_HINT_IME_SHOW_UI \"SDL_IME_SHOW_UI\"")]
        public static ReadOnlySpan<byte> SDL_HINT_IME_SHOW_UI => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x49, 0x4D, 0x45, 0x5F, 0x53, 0x48, 0x4F, 0x57, 0x5F, 0x55, 0x49, 0x00 };

        [NativeTypeName("#define SDL_HINT_IME_SUPPORT_EXTENDED_TEXT \"SDL_IME_SUPPORT_EXTENDED_TEXT\"")]
        public static ReadOnlySpan<byte> SDL_HINT_IME_SUPPORT_EXTENDED_TEXT => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x49, 0x4D, 0x45, 0x5F, 0x53, 0x55, 0x50, 0x50, 0x4F, 0x52, 0x54, 0x5F, 0x45, 0x58, 0x54, 0x45, 0x4E, 0x44, 0x45, 0x44, 0x5F, 0x54, 0x45, 0x58, 0x54, 0x00 };

        [NativeTypeName("#define SDL_HINT_IOS_HIDE_HOME_INDICATOR \"SDL_IOS_HIDE_HOME_INDICATOR\"")]
        public static ReadOnlySpan<byte> SDL_HINT_IOS_HIDE_HOME_INDICATOR => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x49, 0x4F, 0x53, 0x5F, 0x48, 0x49, 0x44, 0x45, 0x5F, 0x48, 0x4F, 0x4D, 0x45, 0x5F, 0x49, 0x4E, 0x44, 0x49, 0x43, 0x41, 0x54, 0x4F, 0x52, 0x00 };

        [NativeTypeName("#define SDL_HINT_JOYSTICK_ALLOW_BACKGROUND_EVENTS \"SDL_JOYSTICK_ALLOW_BACKGROUND_EVENTS\"")]
        public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_ALLOW_BACKGROUND_EVENTS => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4A, 0x4F, 0x59, 0x53, 0x54, 0x49, 0x43, 0x4B, 0x5F, 0x41, 0x4C, 0x4C, 0x4F, 0x57, 0x5F, 0x42, 0x41, 0x43, 0x4B, 0x47, 0x52, 0x4F, 0x55, 0x4E, 0x44, 0x5F, 0x45, 0x56, 0x45, 0x4E, 0x54, 0x53, 0x00 };

        [NativeTypeName("#define SDL_HINT_JOYSTICK_HIDAPI \"SDL_JOYSTICK_HIDAPI\"")]
        public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4A, 0x4F, 0x59, 0x53, 0x54, 0x49, 0x43, 0x4B, 0x5F, 0x48, 0x49, 0x44, 0x41, 0x50, 0x49, 0x00 };

        [NativeTypeName("#define SDL_HINT_JOYSTICK_HIDAPI_GAMECUBE \"SDL_JOYSTICK_HIDAPI_GAMECUBE\"")]
        public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_GAMECUBE => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4A, 0x4F, 0x59, 0x53, 0x54, 0x49, 0x43, 0x4B, 0x5F, 0x48, 0x49, 0x44, 0x41, 0x50, 0x49, 0x5F, 0x47, 0x41, 0x4D, 0x45, 0x43, 0x55, 0x42, 0x45, 0x00 };

        [NativeTypeName("#define SDL_HINT_JOYSTICK_GAMECUBE_RUMBLE_BRAKE \"SDL_JOYSTICK_GAMECUBE_RUMBLE_BRAKE\"")]
        public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_GAMECUBE_RUMBLE_BRAKE => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4A, 0x4F, 0x59, 0x53, 0x54, 0x49, 0x43, 0x4B, 0x5F, 0x47, 0x41, 0x4D, 0x45, 0x43, 0x55, 0x42, 0x45, 0x5F, 0x52, 0x55, 0x4D, 0x42, 0x4C, 0x45, 0x5F, 0x42, 0x52, 0x41, 0x4B, 0x45, 0x00 };

        [NativeTypeName("#define SDL_HINT_JOYSTICK_HIDAPI_JOY_CONS \"SDL_JOYSTICK_HIDAPI_JOY_CONS\"")]
        public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_JOY_CONS => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4A, 0x4F, 0x59, 0x53, 0x54, 0x49, 0x43, 0x4B, 0x5F, 0x48, 0x49, 0x44, 0x41, 0x50, 0x49, 0x5F, 0x4A, 0x4F, 0x59, 0x5F, 0x43, 0x4F, 0x4E, 0x53, 0x00 };

        [NativeTypeName("#define SDL_HINT_JOYSTICK_HIDAPI_COMBINE_JOY_CONS \"SDL_JOYSTICK_HIDAPI_COMBINE_JOY_CONS\"")]
        public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_COMBINE_JOY_CONS => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4A, 0x4F, 0x59, 0x53, 0x54, 0x49, 0x43, 0x4B, 0x5F, 0x48, 0x49, 0x44, 0x41, 0x50, 0x49, 0x5F, 0x43, 0x4F, 0x4D, 0x42, 0x49, 0x4E, 0x45, 0x5F, 0x4A, 0x4F, 0x59, 0x5F, 0x43, 0x4F, 0x4E, 0x53, 0x00 };

        [NativeTypeName("#define SDL_HINT_JOYSTICK_HIDAPI_VERTICAL_JOY_CONS \"SDL_JOYSTICK_HIDAPI_VERTICAL_JOY_CONS\"")]
        public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_VERTICAL_JOY_CONS => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4A, 0x4F, 0x59, 0x53, 0x54, 0x49, 0x43, 0x4B, 0x5F, 0x48, 0x49, 0x44, 0x41, 0x50, 0x49, 0x5F, 0x56, 0x45, 0x52, 0x54, 0x49, 0x43, 0x41, 0x4C, 0x5F, 0x4A, 0x4F, 0x59, 0x5F, 0x43, 0x4F, 0x4E, 0x53, 0x00 };

        [NativeTypeName("#define SDL_HINT_JOYSTICK_HIDAPI_LUNA \"SDL_JOYSTICK_HIDAPI_LUNA\"")]
        public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_LUNA => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4A, 0x4F, 0x59, 0x53, 0x54, 0x49, 0x43, 0x4B, 0x5F, 0x48, 0x49, 0x44, 0x41, 0x50, 0x49, 0x5F, 0x4C, 0x55, 0x4E, 0x41, 0x00 };

        [NativeTypeName("#define SDL_HINT_JOYSTICK_HIDAPI_NINTENDO_CLASSIC \"SDL_JOYSTICK_HIDAPI_NINTENDO_CLASSIC\"")]
        public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_NINTENDO_CLASSIC => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4A, 0x4F, 0x59, 0x53, 0x54, 0x49, 0x43, 0x4B, 0x5F, 0x48, 0x49, 0x44, 0x41, 0x50, 0x49, 0x5F, 0x4E, 0x49, 0x4E, 0x54, 0x45, 0x4E, 0x44, 0x4F, 0x5F, 0x43, 0x4C, 0x41, 0x53, 0x53, 0x49, 0x43, 0x00 };

        [NativeTypeName("#define SDL_HINT_JOYSTICK_HIDAPI_SHIELD \"SDL_JOYSTICK_HIDAPI_SHIELD\"")]
        public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_SHIELD => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4A, 0x4F, 0x59, 0x53, 0x54, 0x49, 0x43, 0x4B, 0x5F, 0x48, 0x49, 0x44, 0x41, 0x50, 0x49, 0x5F, 0x53, 0x48, 0x49, 0x45, 0x4C, 0x44, 0x00 };

        [NativeTypeName("#define SDL_HINT_JOYSTICK_HIDAPI_PS3 \"SDL_JOYSTICK_HIDAPI_PS3\"")]
        public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_PS3 => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4A, 0x4F, 0x59, 0x53, 0x54, 0x49, 0x43, 0x4B, 0x5F, 0x48, 0x49, 0x44, 0x41, 0x50, 0x49, 0x5F, 0x50, 0x53, 0x33, 0x00 };

        [NativeTypeName("#define SDL_HINT_JOYSTICK_HIDAPI_PS4 \"SDL_JOYSTICK_HIDAPI_PS4\"")]
        public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_PS4 => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4A, 0x4F, 0x59, 0x53, 0x54, 0x49, 0x43, 0x4B, 0x5F, 0x48, 0x49, 0x44, 0x41, 0x50, 0x49, 0x5F, 0x50, 0x53, 0x34, 0x00 };

        [NativeTypeName("#define SDL_HINT_JOYSTICK_HIDAPI_PS4_RUMBLE \"SDL_JOYSTICK_HIDAPI_PS4_RUMBLE\"")]
        public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_PS4_RUMBLE => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4A, 0x4F, 0x59, 0x53, 0x54, 0x49, 0x43, 0x4B, 0x5F, 0x48, 0x49, 0x44, 0x41, 0x50, 0x49, 0x5F, 0x50, 0x53, 0x34, 0x5F, 0x52, 0x55, 0x4D, 0x42, 0x4C, 0x45, 0x00 };

        [NativeTypeName("#define SDL_HINT_JOYSTICK_HIDAPI_PS5 \"SDL_JOYSTICK_HIDAPI_PS5\"")]
        public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_PS5 => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4A, 0x4F, 0x59, 0x53, 0x54, 0x49, 0x43, 0x4B, 0x5F, 0x48, 0x49, 0x44, 0x41, 0x50, 0x49, 0x5F, 0x50, 0x53, 0x35, 0x00 };

        [NativeTypeName("#define SDL_HINT_JOYSTICK_HIDAPI_PS5_PLAYER_LED \"SDL_JOYSTICK_HIDAPI_PS5_PLAYER_LED\"")]
        public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_PS5_PLAYER_LED => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4A, 0x4F, 0x59, 0x53, 0x54, 0x49, 0x43, 0x4B, 0x5F, 0x48, 0x49, 0x44, 0x41, 0x50, 0x49, 0x5F, 0x50, 0x53, 0x35, 0x5F, 0x50, 0x4C, 0x41, 0x59, 0x45, 0x52, 0x5F, 0x4C, 0x45, 0x44, 0x00 };

        [NativeTypeName("#define SDL_HINT_JOYSTICK_HIDAPI_PS5_RUMBLE \"SDL_JOYSTICK_HIDAPI_PS5_RUMBLE\"")]
        public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_PS5_RUMBLE => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4A, 0x4F, 0x59, 0x53, 0x54, 0x49, 0x43, 0x4B, 0x5F, 0x48, 0x49, 0x44, 0x41, 0x50, 0x49, 0x5F, 0x50, 0x53, 0x35, 0x5F, 0x52, 0x55, 0x4D, 0x42, 0x4C, 0x45, 0x00 };

        [NativeTypeName("#define SDL_HINT_JOYSTICK_HIDAPI_STADIA \"SDL_JOYSTICK_HIDAPI_STADIA\"")]
        public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_STADIA => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4A, 0x4F, 0x59, 0x53, 0x54, 0x49, 0x43, 0x4B, 0x5F, 0x48, 0x49, 0x44, 0x41, 0x50, 0x49, 0x5F, 0x53, 0x54, 0x41, 0x44, 0x49, 0x41, 0x00 };

        [NativeTypeName("#define SDL_HINT_JOYSTICK_HIDAPI_STEAM \"SDL_JOYSTICK_HIDAPI_STEAM\"")]
        public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_STEAM => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4A, 0x4F, 0x59, 0x53, 0x54, 0x49, 0x43, 0x4B, 0x5F, 0x48, 0x49, 0x44, 0x41, 0x50, 0x49, 0x5F, 0x53, 0x54, 0x45, 0x41, 0x4D, 0x00 };

        [NativeTypeName("#define SDL_HINT_JOYSTICK_HIDAPI_SWITCH \"SDL_JOYSTICK_HIDAPI_SWITCH\"")]
        public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_SWITCH => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4A, 0x4F, 0x59, 0x53, 0x54, 0x49, 0x43, 0x4B, 0x5F, 0x48, 0x49, 0x44, 0x41, 0x50, 0x49, 0x5F, 0x53, 0x57, 0x49, 0x54, 0x43, 0x48, 0x00 };

        [NativeTypeName("#define SDL_HINT_JOYSTICK_HIDAPI_SWITCH_HOME_LED \"SDL_JOYSTICK_HIDAPI_SWITCH_HOME_LED\"")]
        public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_SWITCH_HOME_LED => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4A, 0x4F, 0x59, 0x53, 0x54, 0x49, 0x43, 0x4B, 0x5F, 0x48, 0x49, 0x44, 0x41, 0x50, 0x49, 0x5F, 0x53, 0x57, 0x49, 0x54, 0x43, 0x48, 0x5F, 0x48, 0x4F, 0x4D, 0x45, 0x5F, 0x4C, 0x45, 0x44, 0x00 };

        [NativeTypeName("#define SDL_HINT_JOYSTICK_HIDAPI_JOYCON_HOME_LED \"SDL_JOYSTICK_HIDAPI_JOYCON_HOME_LED\"")]
        public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_JOYCON_HOME_LED => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4A, 0x4F, 0x59, 0x53, 0x54, 0x49, 0x43, 0x4B, 0x5F, 0x48, 0x49, 0x44, 0x41, 0x50, 0x49, 0x5F, 0x4A, 0x4F, 0x59, 0x43, 0x4F, 0x4E, 0x5F, 0x48, 0x4F, 0x4D, 0x45, 0x5F, 0x4C, 0x45, 0x44, 0x00 };

        [NativeTypeName("#define SDL_HINT_JOYSTICK_HIDAPI_SWITCH_PLAYER_LED \"SDL_JOYSTICK_HIDAPI_SWITCH_PLAYER_LED\"")]
        public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_SWITCH_PLAYER_LED => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4A, 0x4F, 0x59, 0x53, 0x54, 0x49, 0x43, 0x4B, 0x5F, 0x48, 0x49, 0x44, 0x41, 0x50, 0x49, 0x5F, 0x53, 0x57, 0x49, 0x54, 0x43, 0x48, 0x5F, 0x50, 0x4C, 0x41, 0x59, 0x45, 0x52, 0x5F, 0x4C, 0x45, 0x44, 0x00 };

        [NativeTypeName("#define SDL_HINT_JOYSTICK_HIDAPI_WII \"SDL_JOYSTICK_HIDAPI_WII\"")]
        public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_WII => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4A, 0x4F, 0x59, 0x53, 0x54, 0x49, 0x43, 0x4B, 0x5F, 0x48, 0x49, 0x44, 0x41, 0x50, 0x49, 0x5F, 0x57, 0x49, 0x49, 0x00 };

        [NativeTypeName("#define SDL_HINT_JOYSTICK_HIDAPI_WII_PLAYER_LED \"SDL_JOYSTICK_HIDAPI_WII_PLAYER_LED\"")]
        public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_WII_PLAYER_LED => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4A, 0x4F, 0x59, 0x53, 0x54, 0x49, 0x43, 0x4B, 0x5F, 0x48, 0x49, 0x44, 0x41, 0x50, 0x49, 0x5F, 0x57, 0x49, 0x49, 0x5F, 0x50, 0x4C, 0x41, 0x59, 0x45, 0x52, 0x5F, 0x4C, 0x45, 0x44, 0x00 };

        [NativeTypeName("#define SDL_HINT_JOYSTICK_HIDAPI_XBOX \"SDL_JOYSTICK_HIDAPI_XBOX\"")]
        public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_XBOX => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4A, 0x4F, 0x59, 0x53, 0x54, 0x49, 0x43, 0x4B, 0x5F, 0x48, 0x49, 0x44, 0x41, 0x50, 0x49, 0x5F, 0x58, 0x42, 0x4F, 0x58, 0x00 };

        [NativeTypeName("#define SDL_HINT_JOYSTICK_HIDAPI_XBOX_360 \"SDL_JOYSTICK_HIDAPI_XBOX_360\"")]
        public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_XBOX_360 => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4A, 0x4F, 0x59, 0x53, 0x54, 0x49, 0x43, 0x4B, 0x5F, 0x48, 0x49, 0x44, 0x41, 0x50, 0x49, 0x5F, 0x58, 0x42, 0x4F, 0x58, 0x5F, 0x33, 0x36, 0x30, 0x00 };

        [NativeTypeName("#define SDL_HINT_JOYSTICK_HIDAPI_XBOX_360_PLAYER_LED \"SDL_JOYSTICK_HIDAPI_XBOX_360_PLAYER_LED\"")]
        public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_XBOX_360_PLAYER_LED => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4A, 0x4F, 0x59, 0x53, 0x54, 0x49, 0x43, 0x4B, 0x5F, 0x48, 0x49, 0x44, 0x41, 0x50, 0x49, 0x5F, 0x58, 0x42, 0x4F, 0x58, 0x5F, 0x33, 0x36, 0x30, 0x5F, 0x50, 0x4C, 0x41, 0x59, 0x45, 0x52, 0x5F, 0x4C, 0x45, 0x44, 0x00 };

        [NativeTypeName("#define SDL_HINT_JOYSTICK_HIDAPI_XBOX_360_WIRELESS \"SDL_JOYSTICK_HIDAPI_XBOX_360_WIRELESS\"")]
        public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_XBOX_360_WIRELESS => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4A, 0x4F, 0x59, 0x53, 0x54, 0x49, 0x43, 0x4B, 0x5F, 0x48, 0x49, 0x44, 0x41, 0x50, 0x49, 0x5F, 0x58, 0x42, 0x4F, 0x58, 0x5F, 0x33, 0x36, 0x30, 0x5F, 0x57, 0x49, 0x52, 0x45, 0x4C, 0x45, 0x53, 0x53, 0x00 };

        [NativeTypeName("#define SDL_HINT_JOYSTICK_HIDAPI_XBOX_ONE \"SDL_JOYSTICK_HIDAPI_XBOX_ONE\"")]
        public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_XBOX_ONE => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4A, 0x4F, 0x59, 0x53, 0x54, 0x49, 0x43, 0x4B, 0x5F, 0x48, 0x49, 0x44, 0x41, 0x50, 0x49, 0x5F, 0x58, 0x42, 0x4F, 0x58, 0x5F, 0x4F, 0x4E, 0x45, 0x00 };

        [NativeTypeName("#define SDL_HINT_JOYSTICK_HIDAPI_XBOX_ONE_HOME_LED \"SDL_JOYSTICK_HIDAPI_XBOX_ONE_HOME_LED\"")]
        public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_HIDAPI_XBOX_ONE_HOME_LED => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4A, 0x4F, 0x59, 0x53, 0x54, 0x49, 0x43, 0x4B, 0x5F, 0x48, 0x49, 0x44, 0x41, 0x50, 0x49, 0x5F, 0x58, 0x42, 0x4F, 0x58, 0x5F, 0x4F, 0x4E, 0x45, 0x5F, 0x48, 0x4F, 0x4D, 0x45, 0x5F, 0x4C, 0x45, 0x44, 0x00 };

        [NativeTypeName("#define SDL_HINT_JOYSTICK_RAWINPUT \"SDL_JOYSTICK_RAWINPUT\"")]
        public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_RAWINPUT => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4A, 0x4F, 0x59, 0x53, 0x54, 0x49, 0x43, 0x4B, 0x5F, 0x52, 0x41, 0x57, 0x49, 0x4E, 0x50, 0x55, 0x54, 0x00 };

        [NativeTypeName("#define SDL_HINT_JOYSTICK_RAWINPUT_CORRELATE_XINPUT \"SDL_JOYSTICK_RAWINPUT_CORRELATE_XINPUT\"")]
        public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_RAWINPUT_CORRELATE_XINPUT => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4A, 0x4F, 0x59, 0x53, 0x54, 0x49, 0x43, 0x4B, 0x5F, 0x52, 0x41, 0x57, 0x49, 0x4E, 0x50, 0x55, 0x54, 0x5F, 0x43, 0x4F, 0x52, 0x52, 0x45, 0x4C, 0x41, 0x54, 0x45, 0x5F, 0x58, 0x49, 0x4E, 0x50, 0x55, 0x54, 0x00 };

        [NativeTypeName("#define SDL_HINT_JOYSTICK_ROG_CHAKRAM \"SDL_JOYSTICK_ROG_CHAKRAM\"")]
        public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_ROG_CHAKRAM => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4A, 0x4F, 0x59, 0x53, 0x54, 0x49, 0x43, 0x4B, 0x5F, 0x52, 0x4F, 0x47, 0x5F, 0x43, 0x48, 0x41, 0x4B, 0x52, 0x41, 0x4D, 0x00 };

        [NativeTypeName("#define SDL_HINT_JOYSTICK_THREAD \"SDL_JOYSTICK_THREAD\"")]
        public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_THREAD => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4A, 0x4F, 0x59, 0x53, 0x54, 0x49, 0x43, 0x4B, 0x5F, 0x54, 0x48, 0x52, 0x45, 0x41, 0x44, 0x00 };

        [NativeTypeName("#define SDL_HINT_KMSDRM_REQUIRE_DRM_MASTER \"SDL_KMSDRM_REQUIRE_DRM_MASTER\"")]
        public static ReadOnlySpan<byte> SDL_HINT_KMSDRM_REQUIRE_DRM_MASTER => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4B, 0x4D, 0x53, 0x44, 0x52, 0x4D, 0x5F, 0x52, 0x45, 0x51, 0x55, 0x49, 0x52, 0x45, 0x5F, 0x44, 0x52, 0x4D, 0x5F, 0x4D, 0x41, 0x53, 0x54, 0x45, 0x52, 0x00 };

        [NativeTypeName("#define SDL_HINT_JOYSTICK_DEVICE \"SDL_JOYSTICK_DEVICE\"")]
        public static ReadOnlySpan<byte> SDL_HINT_JOYSTICK_DEVICE => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4A, 0x4F, 0x59, 0x53, 0x54, 0x49, 0x43, 0x4B, 0x5F, 0x44, 0x45, 0x56, 0x49, 0x43, 0x45, 0x00 };

        [NativeTypeName("#define SDL_HINT_LINUX_DIGITAL_HATS \"SDL_LINUX_DIGITAL_HATS\"")]
        public static ReadOnlySpan<byte> SDL_HINT_LINUX_DIGITAL_HATS => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4C, 0x49, 0x4E, 0x55, 0x58, 0x5F, 0x44, 0x49, 0x47, 0x49, 0x54, 0x41, 0x4C, 0x5F, 0x48, 0x41, 0x54, 0x53, 0x00 };

        [NativeTypeName("#define SDL_HINT_LINUX_HAT_DEADZONES \"SDL_LINUX_HAT_DEADZONES\"")]
        public static ReadOnlySpan<byte> SDL_HINT_LINUX_HAT_DEADZONES => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4C, 0x49, 0x4E, 0x55, 0x58, 0x5F, 0x48, 0x41, 0x54, 0x5F, 0x44, 0x45, 0x41, 0x44, 0x5A, 0x4F, 0x4E, 0x45, 0x53, 0x00 };

        [NativeTypeName("#define SDL_HINT_LINUX_JOYSTICK_CLASSIC \"SDL_LINUX_JOYSTICK_CLASSIC\"")]
        public static ReadOnlySpan<byte> SDL_HINT_LINUX_JOYSTICK_CLASSIC => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4C, 0x49, 0x4E, 0x55, 0x58, 0x5F, 0x4A, 0x4F, 0x59, 0x53, 0x54, 0x49, 0x43, 0x4B, 0x5F, 0x43, 0x4C, 0x41, 0x53, 0x53, 0x49, 0x43, 0x00 };

        [NativeTypeName("#define SDL_HINT_LINUX_JOYSTICK_DEADZONES \"SDL_LINUX_JOYSTICK_DEADZONES\"")]
        public static ReadOnlySpan<byte> SDL_HINT_LINUX_JOYSTICK_DEADZONES => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4C, 0x49, 0x4E, 0x55, 0x58, 0x5F, 0x4A, 0x4F, 0x59, 0x53, 0x54, 0x49, 0x43, 0x4B, 0x5F, 0x44, 0x45, 0x41, 0x44, 0x5A, 0x4F, 0x4E, 0x45, 0x53, 0x00 };

        [NativeTypeName("#define SDL_HINT_MAC_BACKGROUND_APP \"SDL_MAC_BACKGROUND_APP\"")]
        public static ReadOnlySpan<byte> SDL_HINT_MAC_BACKGROUND_APP => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4D, 0x41, 0x43, 0x5F, 0x42, 0x41, 0x43, 0x4B, 0x47, 0x52, 0x4F, 0x55, 0x4E, 0x44, 0x5F, 0x41, 0x50, 0x50, 0x00 };

        [NativeTypeName("#define SDL_HINT_MAC_CTRL_CLICK_EMULATE_RIGHT_CLICK \"SDL_MAC_CTRL_CLICK_EMULATE_RIGHT_CLICK\"")]
        public static ReadOnlySpan<byte> SDL_HINT_MAC_CTRL_CLICK_EMULATE_RIGHT_CLICK => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4D, 0x41, 0x43, 0x5F, 0x43, 0x54, 0x52, 0x4C, 0x5F, 0x43, 0x4C, 0x49, 0x43, 0x4B, 0x5F, 0x45, 0x4D, 0x55, 0x4C, 0x41, 0x54, 0x45, 0x5F, 0x52, 0x49, 0x47, 0x48, 0x54, 0x5F, 0x43, 0x4C, 0x49, 0x43, 0x4B, 0x00 };

        [NativeTypeName("#define SDL_HINT_MAC_OPENGL_ASYNC_DISPATCH \"SDL_MAC_OPENGL_ASYNC_DISPATCH\"")]
        public static ReadOnlySpan<byte> SDL_HINT_MAC_OPENGL_ASYNC_DISPATCH => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4D, 0x41, 0x43, 0x5F, 0x4F, 0x50, 0x45, 0x4E, 0x47, 0x4C, 0x5F, 0x41, 0x53, 0x59, 0x4E, 0x43, 0x5F, 0x44, 0x49, 0x53, 0x50, 0x41, 0x54, 0x43, 0x48, 0x00 };

        [NativeTypeName("#define SDL_HINT_MOUSE_DOUBLE_CLICK_RADIUS \"SDL_MOUSE_DOUBLE_CLICK_RADIUS\"")]
        public static ReadOnlySpan<byte> SDL_HINT_MOUSE_DOUBLE_CLICK_RADIUS => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4D, 0x4F, 0x55, 0x53, 0x45, 0x5F, 0x44, 0x4F, 0x55, 0x42, 0x4C, 0x45, 0x5F, 0x43, 0x4C, 0x49, 0x43, 0x4B, 0x5F, 0x52, 0x41, 0x44, 0x49, 0x55, 0x53, 0x00 };

        [NativeTypeName("#define SDL_HINT_MOUSE_DOUBLE_CLICK_TIME \"SDL_MOUSE_DOUBLE_CLICK_TIME\"")]
        public static ReadOnlySpan<byte> SDL_HINT_MOUSE_DOUBLE_CLICK_TIME => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4D, 0x4F, 0x55, 0x53, 0x45, 0x5F, 0x44, 0x4F, 0x55, 0x42, 0x4C, 0x45, 0x5F, 0x43, 0x4C, 0x49, 0x43, 0x4B, 0x5F, 0x54, 0x49, 0x4D, 0x45, 0x00 };

        [NativeTypeName("#define SDL_HINT_MOUSE_FOCUS_CLICKTHROUGH \"SDL_MOUSE_FOCUS_CLICKTHROUGH\"")]
        public static ReadOnlySpan<byte> SDL_HINT_MOUSE_FOCUS_CLICKTHROUGH => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4D, 0x4F, 0x55, 0x53, 0x45, 0x5F, 0x46, 0x4F, 0x43, 0x55, 0x53, 0x5F, 0x43, 0x4C, 0x49, 0x43, 0x4B, 0x54, 0x48, 0x52, 0x4F, 0x55, 0x47, 0x48, 0x00 };

        [NativeTypeName("#define SDL_HINT_MOUSE_NORMAL_SPEED_SCALE \"SDL_MOUSE_NORMAL_SPEED_SCALE\"")]
        public static ReadOnlySpan<byte> SDL_HINT_MOUSE_NORMAL_SPEED_SCALE => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4D, 0x4F, 0x55, 0x53, 0x45, 0x5F, 0x4E, 0x4F, 0x52, 0x4D, 0x41, 0x4C, 0x5F, 0x53, 0x50, 0x45, 0x45, 0x44, 0x5F, 0x53, 0x43, 0x41, 0x4C, 0x45, 0x00 };

        [NativeTypeName("#define SDL_HINT_MOUSE_RELATIVE_MODE_CENTER \"SDL_MOUSE_RELATIVE_MODE_CENTER\"")]
        public static ReadOnlySpan<byte> SDL_HINT_MOUSE_RELATIVE_MODE_CENTER => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4D, 0x4F, 0x55, 0x53, 0x45, 0x5F, 0x52, 0x45, 0x4C, 0x41, 0x54, 0x49, 0x56, 0x45, 0x5F, 0x4D, 0x4F, 0x44, 0x45, 0x5F, 0x43, 0x45, 0x4E, 0x54, 0x45, 0x52, 0x00 };

        [NativeTypeName("#define SDL_HINT_MOUSE_RELATIVE_MODE_WARP \"SDL_MOUSE_RELATIVE_MODE_WARP\"")]
        public static ReadOnlySpan<byte> SDL_HINT_MOUSE_RELATIVE_MODE_WARP => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4D, 0x4F, 0x55, 0x53, 0x45, 0x5F, 0x52, 0x45, 0x4C, 0x41, 0x54, 0x49, 0x56, 0x45, 0x5F, 0x4D, 0x4F, 0x44, 0x45, 0x5F, 0x57, 0x41, 0x52, 0x50, 0x00 };

        [NativeTypeName("#define SDL_HINT_MOUSE_RELATIVE_SCALING \"SDL_MOUSE_RELATIVE_SCALING\"")]
        public static ReadOnlySpan<byte> SDL_HINT_MOUSE_RELATIVE_SCALING => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4D, 0x4F, 0x55, 0x53, 0x45, 0x5F, 0x52, 0x45, 0x4C, 0x41, 0x54, 0x49, 0x56, 0x45, 0x5F, 0x53, 0x43, 0x41, 0x4C, 0x49, 0x4E, 0x47, 0x00 };

        [NativeTypeName("#define SDL_HINT_MOUSE_RELATIVE_SPEED_SCALE \"SDL_MOUSE_RELATIVE_SPEED_SCALE\"")]
        public static ReadOnlySpan<byte> SDL_HINT_MOUSE_RELATIVE_SPEED_SCALE => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4D, 0x4F, 0x55, 0x53, 0x45, 0x5F, 0x52, 0x45, 0x4C, 0x41, 0x54, 0x49, 0x56, 0x45, 0x5F, 0x53, 0x50, 0x45, 0x45, 0x44, 0x5F, 0x53, 0x43, 0x41, 0x4C, 0x45, 0x00 };

        [NativeTypeName("#define SDL_HINT_MOUSE_RELATIVE_SYSTEM_SCALE \"SDL_MOUSE_RELATIVE_SYSTEM_SCALE\"")]
        public static ReadOnlySpan<byte> SDL_HINT_MOUSE_RELATIVE_SYSTEM_SCALE => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4D, 0x4F, 0x55, 0x53, 0x45, 0x5F, 0x52, 0x45, 0x4C, 0x41, 0x54, 0x49, 0x56, 0x45, 0x5F, 0x53, 0x59, 0x53, 0x54, 0x45, 0x4D, 0x5F, 0x53, 0x43, 0x41, 0x4C, 0x45, 0x00 };

        [NativeTypeName("#define SDL_HINT_MOUSE_RELATIVE_WARP_MOTION \"SDL_MOUSE_RELATIVE_WARP_MOTION\"")]
        public static ReadOnlySpan<byte> SDL_HINT_MOUSE_RELATIVE_WARP_MOTION => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4D, 0x4F, 0x55, 0x53, 0x45, 0x5F, 0x52, 0x45, 0x4C, 0x41, 0x54, 0x49, 0x56, 0x45, 0x5F, 0x57, 0x41, 0x52, 0x50, 0x5F, 0x4D, 0x4F, 0x54, 0x49, 0x4F, 0x4E, 0x00 };

        [NativeTypeName("#define SDL_HINT_MOUSE_TOUCH_EVENTS \"SDL_MOUSE_TOUCH_EVENTS\"")]
        public static ReadOnlySpan<byte> SDL_HINT_MOUSE_TOUCH_EVENTS => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4D, 0x4F, 0x55, 0x53, 0x45, 0x5F, 0x54, 0x4F, 0x55, 0x43, 0x48, 0x5F, 0x45, 0x56, 0x45, 0x4E, 0x54, 0x53, 0x00 };

        [NativeTypeName("#define SDL_HINT_MOUSE_AUTO_CAPTURE \"SDL_MOUSE_AUTO_CAPTURE\"")]
        public static ReadOnlySpan<byte> SDL_HINT_MOUSE_AUTO_CAPTURE => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4D, 0x4F, 0x55, 0x53, 0x45, 0x5F, 0x41, 0x55, 0x54, 0x4F, 0x5F, 0x43, 0x41, 0x50, 0x54, 0x55, 0x52, 0x45, 0x00 };

        [NativeTypeName("#define SDL_HINT_NO_SIGNAL_HANDLERS \"SDL_NO_SIGNAL_HANDLERS\"")]
        public static ReadOnlySpan<byte> SDL_HINT_NO_SIGNAL_HANDLERS => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4E, 0x4F, 0x5F, 0x53, 0x49, 0x47, 0x4E, 0x41, 0x4C, 0x5F, 0x48, 0x41, 0x4E, 0x44, 0x4C, 0x45, 0x52, 0x53, 0x00 };

        [NativeTypeName("#define SDL_HINT_OPENGL_ES_DRIVER \"SDL_OPENGL_ES_DRIVER\"")]
        public static ReadOnlySpan<byte> SDL_HINT_OPENGL_ES_DRIVER => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4F, 0x50, 0x45, 0x4E, 0x47, 0x4C, 0x5F, 0x45, 0x53, 0x5F, 0x44, 0x52, 0x49, 0x56, 0x45, 0x52, 0x00 };

        [NativeTypeName("#define SDL_HINT_ORIENTATIONS \"SDL_IOS_ORIENTATIONS\"")]
        public static ReadOnlySpan<byte> SDL_HINT_ORIENTATIONS => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x49, 0x4F, 0x53, 0x5F, 0x4F, 0x52, 0x49, 0x45, 0x4E, 0x54, 0x41, 0x54, 0x49, 0x4F, 0x4E, 0x53, 0x00 };

        [NativeTypeName("#define SDL_HINT_POLL_SENTINEL \"SDL_POLL_SENTINEL\"")]
        public static ReadOnlySpan<byte> SDL_HINT_POLL_SENTINEL => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x50, 0x4F, 0x4C, 0x4C, 0x5F, 0x53, 0x45, 0x4E, 0x54, 0x49, 0x4E, 0x45, 0x4C, 0x00 };

        [NativeTypeName("#define SDL_HINT_PREFERRED_LOCALES \"SDL_PREFERRED_LOCALES\"")]
        public static ReadOnlySpan<byte> SDL_HINT_PREFERRED_LOCALES => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x50, 0x52, 0x45, 0x46, 0x45, 0x52, 0x52, 0x45, 0x44, 0x5F, 0x4C, 0x4F, 0x43, 0x41, 0x4C, 0x45, 0x53, 0x00 };

        [NativeTypeName("#define SDL_HINT_QTWAYLAND_CONTENT_ORIENTATION \"SDL_QTWAYLAND_CONTENT_ORIENTATION\"")]
        public static ReadOnlySpan<byte> SDL_HINT_QTWAYLAND_CONTENT_ORIENTATION => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x51, 0x54, 0x57, 0x41, 0x59, 0x4C, 0x41, 0x4E, 0x44, 0x5F, 0x43, 0x4F, 0x4E, 0x54, 0x45, 0x4E, 0x54, 0x5F, 0x4F, 0x52, 0x49, 0x45, 0x4E, 0x54, 0x41, 0x54, 0x49, 0x4F, 0x4E, 0x00 };

        [NativeTypeName("#define SDL_HINT_QTWAYLAND_WINDOW_FLAGS \"SDL_QTWAYLAND_WINDOW_FLAGS\"")]
        public static ReadOnlySpan<byte> SDL_HINT_QTWAYLAND_WINDOW_FLAGS => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x51, 0x54, 0x57, 0x41, 0x59, 0x4C, 0x41, 0x4E, 0x44, 0x5F, 0x57, 0x49, 0x4E, 0x44, 0x4F, 0x57, 0x5F, 0x46, 0x4C, 0x41, 0x47, 0x53, 0x00 };

        [NativeTypeName("#define SDL_HINT_RENDER_BATCHING \"SDL_RENDER_BATCHING\"")]
        public static ReadOnlySpan<byte> SDL_HINT_RENDER_BATCHING => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x52, 0x45, 0x4E, 0x44, 0x45, 0x52, 0x5F, 0x42, 0x41, 0x54, 0x43, 0x48, 0x49, 0x4E, 0x47, 0x00 };

        [NativeTypeName("#define SDL_HINT_RENDER_LINE_METHOD \"SDL_RENDER_LINE_METHOD\"")]
        public static ReadOnlySpan<byte> SDL_HINT_RENDER_LINE_METHOD => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x52, 0x45, 0x4E, 0x44, 0x45, 0x52, 0x5F, 0x4C, 0x49, 0x4E, 0x45, 0x5F, 0x4D, 0x45, 0x54, 0x48, 0x4F, 0x44, 0x00 };

        [NativeTypeName("#define SDL_HINT_RENDER_DIRECT3D11_DEBUG \"SDL_RENDER_DIRECT3D11_DEBUG\"")]
        public static ReadOnlySpan<byte> SDL_HINT_RENDER_DIRECT3D11_DEBUG => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x52, 0x45, 0x4E, 0x44, 0x45, 0x52, 0x5F, 0x44, 0x49, 0x52, 0x45, 0x43, 0x54, 0x33, 0x44, 0x31, 0x31, 0x5F, 0x44, 0x45, 0x42, 0x55, 0x47, 0x00 };

        [NativeTypeName("#define SDL_HINT_RENDER_DIRECT3D_THREADSAFE \"SDL_RENDER_DIRECT3D_THREADSAFE\"")]
        public static ReadOnlySpan<byte> SDL_HINT_RENDER_DIRECT3D_THREADSAFE => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x52, 0x45, 0x4E, 0x44, 0x45, 0x52, 0x5F, 0x44, 0x49, 0x52, 0x45, 0x43, 0x54, 0x33, 0x44, 0x5F, 0x54, 0x48, 0x52, 0x45, 0x41, 0x44, 0x53, 0x41, 0x46, 0x45, 0x00 };

        [NativeTypeName("#define SDL_HINT_RENDER_DRIVER \"SDL_RENDER_DRIVER\"")]
        public static ReadOnlySpan<byte> SDL_HINT_RENDER_DRIVER => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x52, 0x45, 0x4E, 0x44, 0x45, 0x52, 0x5F, 0x44, 0x52, 0x49, 0x56, 0x45, 0x52, 0x00 };

        [NativeTypeName("#define SDL_HINT_RENDER_LOGICAL_SIZE_MODE \"SDL_RENDER_LOGICAL_SIZE_MODE\"")]
        public static ReadOnlySpan<byte> SDL_HINT_RENDER_LOGICAL_SIZE_MODE => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x52, 0x45, 0x4E, 0x44, 0x45, 0x52, 0x5F, 0x4C, 0x4F, 0x47, 0x49, 0x43, 0x41, 0x4C, 0x5F, 0x53, 0x49, 0x5A, 0x45, 0x5F, 0x4D, 0x4F, 0x44, 0x45, 0x00 };

        [NativeTypeName("#define SDL_HINT_RENDER_OPENGL_SHADERS \"SDL_RENDER_OPENGL_SHADERS\"")]
        public static ReadOnlySpan<byte> SDL_HINT_RENDER_OPENGL_SHADERS => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x52, 0x45, 0x4E, 0x44, 0x45, 0x52, 0x5F, 0x4F, 0x50, 0x45, 0x4E, 0x47, 0x4C, 0x5F, 0x53, 0x48, 0x41, 0x44, 0x45, 0x52, 0x53, 0x00 };

        [NativeTypeName("#define SDL_HINT_RENDER_SCALE_QUALITY \"SDL_RENDER_SCALE_QUALITY\"")]
        public static ReadOnlySpan<byte> SDL_HINT_RENDER_SCALE_QUALITY => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x52, 0x45, 0x4E, 0x44, 0x45, 0x52, 0x5F, 0x53, 0x43, 0x41, 0x4C, 0x45, 0x5F, 0x51, 0x55, 0x41, 0x4C, 0x49, 0x54, 0x59, 0x00 };

        [NativeTypeName("#define SDL_HINT_RENDER_VSYNC \"SDL_RENDER_VSYNC\"")]
        public static ReadOnlySpan<byte> SDL_HINT_RENDER_VSYNC => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x52, 0x45, 0x4E, 0x44, 0x45, 0x52, 0x5F, 0x56, 0x53, 0x59, 0x4E, 0x43, 0x00 };

        [NativeTypeName("#define SDL_HINT_PS2_DYNAMIC_VSYNC \"SDL_PS2_DYNAMIC_VSYNC\"")]
        public static ReadOnlySpan<byte> SDL_HINT_PS2_DYNAMIC_VSYNC => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x50, 0x53, 0x32, 0x5F, 0x44, 0x59, 0x4E, 0x41, 0x4D, 0x49, 0x43, 0x5F, 0x56, 0x53, 0x59, 0x4E, 0x43, 0x00 };

        [NativeTypeName("#define SDL_HINT_RETURN_KEY_HIDES_IME \"SDL_RETURN_KEY_HIDES_IME\"")]
        public static ReadOnlySpan<byte> SDL_HINT_RETURN_KEY_HIDES_IME => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x52, 0x45, 0x54, 0x55, 0x52, 0x4E, 0x5F, 0x4B, 0x45, 0x59, 0x5F, 0x48, 0x49, 0x44, 0x45, 0x53, 0x5F, 0x49, 0x4D, 0x45, 0x00 };

        [NativeTypeName("#define SDL_HINT_RPI_VIDEO_LAYER \"SDL_RPI_VIDEO_LAYER\"")]
        public static ReadOnlySpan<byte> SDL_HINT_RPI_VIDEO_LAYER => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x52, 0x50, 0x49, 0x5F, 0x56, 0x49, 0x44, 0x45, 0x4F, 0x5F, 0x4C, 0x41, 0x59, 0x45, 0x52, 0x00 };

        [NativeTypeName("#define SDL_HINT_SCREENSAVER_INHIBIT_ACTIVITY_NAME \"SDL_SCREENSAVER_INHIBIT_ACTIVITY_NAME\"")]
        public static ReadOnlySpan<byte> SDL_HINT_SCREENSAVER_INHIBIT_ACTIVITY_NAME => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x53, 0x43, 0x52, 0x45, 0x45, 0x4E, 0x53, 0x41, 0x56, 0x45, 0x52, 0x5F, 0x49, 0x4E, 0x48, 0x49, 0x42, 0x49, 0x54, 0x5F, 0x41, 0x43, 0x54, 0x49, 0x56, 0x49, 0x54, 0x59, 0x5F, 0x4E, 0x41, 0x4D, 0x45, 0x00 };

        [NativeTypeName("#define SDL_HINT_THREAD_FORCE_REALTIME_TIME_CRITICAL \"SDL_THREAD_FORCE_REALTIME_TIME_CRITICAL\"")]
        public static ReadOnlySpan<byte> SDL_HINT_THREAD_FORCE_REALTIME_TIME_CRITICAL => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x54, 0x48, 0x52, 0x45, 0x41, 0x44, 0x5F, 0x46, 0x4F, 0x52, 0x43, 0x45, 0x5F, 0x52, 0x45, 0x41, 0x4C, 0x54, 0x49, 0x4D, 0x45, 0x5F, 0x54, 0x49, 0x4D, 0x45, 0x5F, 0x43, 0x52, 0x49, 0x54, 0x49, 0x43, 0x41, 0x4C, 0x00 };

        [NativeTypeName("#define SDL_HINT_THREAD_PRIORITY_POLICY \"SDL_THREAD_PRIORITY_POLICY\"")]
        public static ReadOnlySpan<byte> SDL_HINT_THREAD_PRIORITY_POLICY => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x54, 0x48, 0x52, 0x45, 0x41, 0x44, 0x5F, 0x50, 0x52, 0x49, 0x4F, 0x52, 0x49, 0x54, 0x59, 0x5F, 0x50, 0x4F, 0x4C, 0x49, 0x43, 0x59, 0x00 };

        [NativeTypeName("#define SDL_HINT_THREAD_STACK_SIZE \"SDL_THREAD_STACK_SIZE\"")]
        public static ReadOnlySpan<byte> SDL_HINT_THREAD_STACK_SIZE => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x54, 0x48, 0x52, 0x45, 0x41, 0x44, 0x5F, 0x53, 0x54, 0x41, 0x43, 0x4B, 0x5F, 0x53, 0x49, 0x5A, 0x45, 0x00 };

        [NativeTypeName("#define SDL_HINT_TIMER_RESOLUTION \"SDL_TIMER_RESOLUTION\"")]
        public static ReadOnlySpan<byte> SDL_HINT_TIMER_RESOLUTION => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x54, 0x49, 0x4D, 0x45, 0x52, 0x5F, 0x52, 0x45, 0x53, 0x4F, 0x4C, 0x55, 0x54, 0x49, 0x4F, 0x4E, 0x00 };

        [NativeTypeName("#define SDL_HINT_TOUCH_MOUSE_EVENTS \"SDL_TOUCH_MOUSE_EVENTS\"")]
        public static ReadOnlySpan<byte> SDL_HINT_TOUCH_MOUSE_EVENTS => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x54, 0x4F, 0x55, 0x43, 0x48, 0x5F, 0x4D, 0x4F, 0x55, 0x53, 0x45, 0x5F, 0x45, 0x56, 0x45, 0x4E, 0x54, 0x53, 0x00 };

        [NativeTypeName("#define SDL_HINT_VITA_TOUCH_MOUSE_DEVICE \"SDL_HINT_VITA_TOUCH_MOUSE_DEVICE\"")]
        public static ReadOnlySpan<byte> SDL_HINT_VITA_TOUCH_MOUSE_DEVICE => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x48, 0x49, 0x4E, 0x54, 0x5F, 0x56, 0x49, 0x54, 0x41, 0x5F, 0x54, 0x4F, 0x55, 0x43, 0x48, 0x5F, 0x4D, 0x4F, 0x55, 0x53, 0x45, 0x5F, 0x44, 0x45, 0x56, 0x49, 0x43, 0x45, 0x00 };

        [NativeTypeName("#define SDL_HINT_TV_REMOTE_AS_JOYSTICK \"SDL_TV_REMOTE_AS_JOYSTICK\"")]
        public static ReadOnlySpan<byte> SDL_HINT_TV_REMOTE_AS_JOYSTICK => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x54, 0x56, 0x5F, 0x52, 0x45, 0x4D, 0x4F, 0x54, 0x45, 0x5F, 0x41, 0x53, 0x5F, 0x4A, 0x4F, 0x59, 0x53, 0x54, 0x49, 0x43, 0x4B, 0x00 };

        [NativeTypeName("#define SDL_HINT_VIDEO_ALLOW_SCREENSAVER \"SDL_VIDEO_ALLOW_SCREENSAVER\"")]
        public static ReadOnlySpan<byte> SDL_HINT_VIDEO_ALLOW_SCREENSAVER => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x56, 0x49, 0x44, 0x45, 0x4F, 0x5F, 0x41, 0x4C, 0x4C, 0x4F, 0x57, 0x5F, 0x53, 0x43, 0x52, 0x45, 0x45, 0x4E, 0x53, 0x41, 0x56, 0x45, 0x52, 0x00 };

        [NativeTypeName("#define SDL_HINT_VIDEO_DOUBLE_BUFFER \"SDL_VIDEO_DOUBLE_BUFFER\"")]
        public static ReadOnlySpan<byte> SDL_HINT_VIDEO_DOUBLE_BUFFER => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x56, 0x49, 0x44, 0x45, 0x4F, 0x5F, 0x44, 0x4F, 0x55, 0x42, 0x4C, 0x45, 0x5F, 0x42, 0x55, 0x46, 0x46, 0x45, 0x52, 0x00 };

        [NativeTypeName("#define SDL_HINT_VIDEO_EGL_ALLOW_TRANSPARENCY \"SDL_VIDEO_EGL_ALLOW_TRANSPARENCY\"")]
        public static ReadOnlySpan<byte> SDL_HINT_VIDEO_EGL_ALLOW_TRANSPARENCY => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x56, 0x49, 0x44, 0x45, 0x4F, 0x5F, 0x45, 0x47, 0x4C, 0x5F, 0x41, 0x4C, 0x4C, 0x4F, 0x57, 0x5F, 0x54, 0x52, 0x41, 0x4E, 0x53, 0x50, 0x41, 0x52, 0x45, 0x4E, 0x43, 0x59, 0x00 };

        [NativeTypeName("#define SDL_HINT_VIDEO_EXTERNAL_CONTEXT \"SDL_VIDEO_EXTERNAL_CONTEXT\"")]
        public static ReadOnlySpan<byte> SDL_HINT_VIDEO_EXTERNAL_CONTEXT => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x56, 0x49, 0x44, 0x45, 0x4F, 0x5F, 0x45, 0x58, 0x54, 0x45, 0x52, 0x4E, 0x41, 0x4C, 0x5F, 0x43, 0x4F, 0x4E, 0x54, 0x45, 0x58, 0x54, 0x00 };

        [NativeTypeName("#define SDL_HINT_VIDEO_HIGHDPI_DISABLED \"SDL_VIDEO_HIGHDPI_DISABLED\"")]
        public static ReadOnlySpan<byte> SDL_HINT_VIDEO_HIGHDPI_DISABLED => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x56, 0x49, 0x44, 0x45, 0x4F, 0x5F, 0x48, 0x49, 0x47, 0x48, 0x44, 0x50, 0x49, 0x5F, 0x44, 0x49, 0x53, 0x41, 0x42, 0x4C, 0x45, 0x44, 0x00 };

        [NativeTypeName("#define SDL_HINT_VIDEO_MAC_FULLSCREEN_SPACES \"SDL_VIDEO_MAC_FULLSCREEN_SPACES\"")]
        public static ReadOnlySpan<byte> SDL_HINT_VIDEO_MAC_FULLSCREEN_SPACES => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x56, 0x49, 0x44, 0x45, 0x4F, 0x5F, 0x4D, 0x41, 0x43, 0x5F, 0x46, 0x55, 0x4C, 0x4C, 0x53, 0x43, 0x52, 0x45, 0x45, 0x4E, 0x5F, 0x53, 0x50, 0x41, 0x43, 0x45, 0x53, 0x00 };

        [NativeTypeName("#define SDL_HINT_VIDEO_MINIMIZE_ON_FOCUS_LOSS \"SDL_VIDEO_MINIMIZE_ON_FOCUS_LOSS\"")]
        public static ReadOnlySpan<byte> SDL_HINT_VIDEO_MINIMIZE_ON_FOCUS_LOSS => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x56, 0x49, 0x44, 0x45, 0x4F, 0x5F, 0x4D, 0x49, 0x4E, 0x49, 0x4D, 0x49, 0x5A, 0x45, 0x5F, 0x4F, 0x4E, 0x5F, 0x46, 0x4F, 0x43, 0x55, 0x53, 0x5F, 0x4C, 0x4F, 0x53, 0x53, 0x00 };

        [NativeTypeName("#define SDL_HINT_VIDEO_WAYLAND_ALLOW_LIBDECOR \"SDL_VIDEO_WAYLAND_ALLOW_LIBDECOR\"")]
        public static ReadOnlySpan<byte> SDL_HINT_VIDEO_WAYLAND_ALLOW_LIBDECOR => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x56, 0x49, 0x44, 0x45, 0x4F, 0x5F, 0x57, 0x41, 0x59, 0x4C, 0x41, 0x4E, 0x44, 0x5F, 0x41, 0x4C, 0x4C, 0x4F, 0x57, 0x5F, 0x4C, 0x49, 0x42, 0x44, 0x45, 0x43, 0x4F, 0x52, 0x00 };

        [NativeTypeName("#define SDL_HINT_VIDEO_WAYLAND_PREFER_LIBDECOR \"SDL_VIDEO_WAYLAND_PREFER_LIBDECOR\"")]
        public static ReadOnlySpan<byte> SDL_HINT_VIDEO_WAYLAND_PREFER_LIBDECOR => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x56, 0x49, 0x44, 0x45, 0x4F, 0x5F, 0x57, 0x41, 0x59, 0x4C, 0x41, 0x4E, 0x44, 0x5F, 0x50, 0x52, 0x45, 0x46, 0x45, 0x52, 0x5F, 0x4C, 0x49, 0x42, 0x44, 0x45, 0x43, 0x4F, 0x52, 0x00 };

        [NativeTypeName("#define SDL_HINT_VIDEO_WAYLAND_MODE_EMULATION \"SDL_VIDEO_WAYLAND_MODE_EMULATION\"")]
        public static ReadOnlySpan<byte> SDL_HINT_VIDEO_WAYLAND_MODE_EMULATION => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x56, 0x49, 0x44, 0x45, 0x4F, 0x5F, 0x57, 0x41, 0x59, 0x4C, 0x41, 0x4E, 0x44, 0x5F, 0x4D, 0x4F, 0x44, 0x45, 0x5F, 0x45, 0x4D, 0x55, 0x4C, 0x41, 0x54, 0x49, 0x4F, 0x4E, 0x00 };

        [NativeTypeName("#define SDL_HINT_VIDEO_WAYLAND_EMULATE_MOUSE_WARP \"SDL_VIDEO_WAYLAND_EMULATE_MOUSE_WARP\"")]
        public static ReadOnlySpan<byte> SDL_HINT_VIDEO_WAYLAND_EMULATE_MOUSE_WARP => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x56, 0x49, 0x44, 0x45, 0x4F, 0x5F, 0x57, 0x41, 0x59, 0x4C, 0x41, 0x4E, 0x44, 0x5F, 0x45, 0x4D, 0x55, 0x4C, 0x41, 0x54, 0x45, 0x5F, 0x4D, 0x4F, 0x55, 0x53, 0x45, 0x5F, 0x57, 0x41, 0x52, 0x50, 0x00 };

        [NativeTypeName("#define SDL_HINT_VIDEO_WINDOW_SHARE_PIXEL_FORMAT \"SDL_VIDEO_WINDOW_SHARE_PIXEL_FORMAT\"")]
        public static ReadOnlySpan<byte> SDL_HINT_VIDEO_WINDOW_SHARE_PIXEL_FORMAT => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x56, 0x49, 0x44, 0x45, 0x4F, 0x5F, 0x57, 0x49, 0x4E, 0x44, 0x4F, 0x57, 0x5F, 0x53, 0x48, 0x41, 0x52, 0x45, 0x5F, 0x50, 0x49, 0x58, 0x45, 0x4C, 0x5F, 0x46, 0x4F, 0x52, 0x4D, 0x41, 0x54, 0x00 };

        [NativeTypeName("#define SDL_HINT_VIDEO_FOREIGN_WINDOW_OPENGL \"SDL_VIDEO_FOREIGN_WINDOW_OPENGL\"")]
        public static ReadOnlySpan<byte> SDL_HINT_VIDEO_FOREIGN_WINDOW_OPENGL => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x56, 0x49, 0x44, 0x45, 0x4F, 0x5F, 0x46, 0x4F, 0x52, 0x45, 0x49, 0x47, 0x4E, 0x5F, 0x57, 0x49, 0x4E, 0x44, 0x4F, 0x57, 0x5F, 0x4F, 0x50, 0x45, 0x4E, 0x47, 0x4C, 0x00 };

        [NativeTypeName("#define SDL_HINT_VIDEO_FOREIGN_WINDOW_VULKAN \"SDL_VIDEO_FOREIGN_WINDOW_VULKAN\"")]
        public static ReadOnlySpan<byte> SDL_HINT_VIDEO_FOREIGN_WINDOW_VULKAN => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x56, 0x49, 0x44, 0x45, 0x4F, 0x5F, 0x46, 0x4F, 0x52, 0x45, 0x49, 0x47, 0x4E, 0x5F, 0x57, 0x49, 0x4E, 0x44, 0x4F, 0x57, 0x5F, 0x56, 0x55, 0x4C, 0x4B, 0x41, 0x4E, 0x00 };

        [NativeTypeName("#define SDL_HINT_VIDEO_WIN_D3DCOMPILER \"SDL_VIDEO_WIN_D3DCOMPILER\"")]
        public static ReadOnlySpan<byte> SDL_HINT_VIDEO_WIN_D3DCOMPILER => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x56, 0x49, 0x44, 0x45, 0x4F, 0x5F, 0x57, 0x49, 0x4E, 0x5F, 0x44, 0x33, 0x44, 0x43, 0x4F, 0x4D, 0x50, 0x49, 0x4C, 0x45, 0x52, 0x00 };

        [NativeTypeName("#define SDL_HINT_VIDEO_X11_FORCE_EGL \"SDL_VIDEO_X11_FORCE_EGL\"")]
        public static ReadOnlySpan<byte> SDL_HINT_VIDEO_X11_FORCE_EGL => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x56, 0x49, 0x44, 0x45, 0x4F, 0x5F, 0x58, 0x31, 0x31, 0x5F, 0x46, 0x4F, 0x52, 0x43, 0x45, 0x5F, 0x45, 0x47, 0x4C, 0x00 };

        [NativeTypeName("#define SDL_HINT_VIDEO_X11_NET_WM_BYPASS_COMPOSITOR \"SDL_VIDEO_X11_NET_WM_BYPASS_COMPOSITOR\"")]
        public static ReadOnlySpan<byte> SDL_HINT_VIDEO_X11_NET_WM_BYPASS_COMPOSITOR => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x56, 0x49, 0x44, 0x45, 0x4F, 0x5F, 0x58, 0x31, 0x31, 0x5F, 0x4E, 0x45, 0x54, 0x5F, 0x57, 0x4D, 0x5F, 0x42, 0x59, 0x50, 0x41, 0x53, 0x53, 0x5F, 0x43, 0x4F, 0x4D, 0x50, 0x4F, 0x53, 0x49, 0x54, 0x4F, 0x52, 0x00 };

        [NativeTypeName("#define SDL_HINT_VIDEO_X11_NET_WM_PING \"SDL_VIDEO_X11_NET_WM_PING\"")]
        public static ReadOnlySpan<byte> SDL_HINT_VIDEO_X11_NET_WM_PING => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x56, 0x49, 0x44, 0x45, 0x4F, 0x5F, 0x58, 0x31, 0x31, 0x5F, 0x4E, 0x45, 0x54, 0x5F, 0x57, 0x4D, 0x5F, 0x50, 0x49, 0x4E, 0x47, 0x00 };

        [NativeTypeName("#define SDL_HINT_VIDEO_X11_WINDOW_VISUALID \"SDL_VIDEO_X11_WINDOW_VISUALID\"")]
        public static ReadOnlySpan<byte> SDL_HINT_VIDEO_X11_WINDOW_VISUALID => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x56, 0x49, 0x44, 0x45, 0x4F, 0x5F, 0x58, 0x31, 0x31, 0x5F, 0x57, 0x49, 0x4E, 0x44, 0x4F, 0x57, 0x5F, 0x56, 0x49, 0x53, 0x55, 0x41, 0x4C, 0x49, 0x44, 0x00 };

        [NativeTypeName("#define SDL_HINT_VIDEO_X11_XINERAMA \"SDL_VIDEO_X11_XINERAMA\"")]
        public static ReadOnlySpan<byte> SDL_HINT_VIDEO_X11_XINERAMA => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x56, 0x49, 0x44, 0x45, 0x4F, 0x5F, 0x58, 0x31, 0x31, 0x5F, 0x58, 0x49, 0x4E, 0x45, 0x52, 0x41, 0x4D, 0x41, 0x00 };

        [NativeTypeName("#define SDL_HINT_VIDEO_X11_XRANDR \"SDL_VIDEO_X11_XRANDR\"")]
        public static ReadOnlySpan<byte> SDL_HINT_VIDEO_X11_XRANDR => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x56, 0x49, 0x44, 0x45, 0x4F, 0x5F, 0x58, 0x31, 0x31, 0x5F, 0x58, 0x52, 0x41, 0x4E, 0x44, 0x52, 0x00 };

        [NativeTypeName("#define SDL_HINT_VIDEO_X11_XVIDMODE \"SDL_VIDEO_X11_XVIDMODE\"")]
        public static ReadOnlySpan<byte> SDL_HINT_VIDEO_X11_XVIDMODE => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x56, 0x49, 0x44, 0x45, 0x4F, 0x5F, 0x58, 0x31, 0x31, 0x5F, 0x58, 0x56, 0x49, 0x44, 0x4D, 0x4F, 0x44, 0x45, 0x00 };

        [NativeTypeName("#define SDL_HINT_WAVE_FACT_CHUNK \"SDL_WAVE_FACT_CHUNK\"")]
        public static ReadOnlySpan<byte> SDL_HINT_WAVE_FACT_CHUNK => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x57, 0x41, 0x56, 0x45, 0x5F, 0x46, 0x41, 0x43, 0x54, 0x5F, 0x43, 0x48, 0x55, 0x4E, 0x4B, 0x00 };

        [NativeTypeName("#define SDL_HINT_WAVE_RIFF_CHUNK_SIZE \"SDL_WAVE_RIFF_CHUNK_SIZE\"")]
        public static ReadOnlySpan<byte> SDL_HINT_WAVE_RIFF_CHUNK_SIZE => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x57, 0x41, 0x56, 0x45, 0x5F, 0x52, 0x49, 0x46, 0x46, 0x5F, 0x43, 0x48, 0x55, 0x4E, 0x4B, 0x5F, 0x53, 0x49, 0x5A, 0x45, 0x00 };

        [NativeTypeName("#define SDL_HINT_WAVE_TRUNCATION \"SDL_WAVE_TRUNCATION\"")]
        public static ReadOnlySpan<byte> SDL_HINT_WAVE_TRUNCATION => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x57, 0x41, 0x56, 0x45, 0x5F, 0x54, 0x52, 0x55, 0x4E, 0x43, 0x41, 0x54, 0x49, 0x4F, 0x4E, 0x00 };

        [NativeTypeName("#define SDL_HINT_WINDOWS_DISABLE_THREAD_NAMING \"SDL_WINDOWS_DISABLE_THREAD_NAMING\"")]
        public static ReadOnlySpan<byte> SDL_HINT_WINDOWS_DISABLE_THREAD_NAMING => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x57, 0x49, 0x4E, 0x44, 0x4F, 0x57, 0x53, 0x5F, 0x44, 0x49, 0x53, 0x41, 0x42, 0x4C, 0x45, 0x5F, 0x54, 0x48, 0x52, 0x45, 0x41, 0x44, 0x5F, 0x4E, 0x41, 0x4D, 0x49, 0x4E, 0x47, 0x00 };

        [NativeTypeName("#define SDL_HINT_WINDOWS_ENABLE_MESSAGELOOP \"SDL_WINDOWS_ENABLE_MESSAGELOOP\"")]
        public static ReadOnlySpan<byte> SDL_HINT_WINDOWS_ENABLE_MESSAGELOOP => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x57, 0x49, 0x4E, 0x44, 0x4F, 0x57, 0x53, 0x5F, 0x45, 0x4E, 0x41, 0x42, 0x4C, 0x45, 0x5F, 0x4D, 0x45, 0x53, 0x53, 0x41, 0x47, 0x45, 0x4C, 0x4F, 0x4F, 0x50, 0x00 };

        [NativeTypeName("#define SDL_HINT_WINDOWS_FORCE_MUTEX_CRITICAL_SECTIONS \"SDL_WINDOWS_FORCE_MUTEX_CRITICAL_SECTIONS\"")]
        public static ReadOnlySpan<byte> SDL_HINT_WINDOWS_FORCE_MUTEX_CRITICAL_SECTIONS => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x57, 0x49, 0x4E, 0x44, 0x4F, 0x57, 0x53, 0x5F, 0x46, 0x4F, 0x52, 0x43, 0x45, 0x5F, 0x4D, 0x55, 0x54, 0x45, 0x58, 0x5F, 0x43, 0x52, 0x49, 0x54, 0x49, 0x43, 0x41, 0x4C, 0x5F, 0x53, 0x45, 0x43, 0x54, 0x49, 0x4F, 0x4E, 0x53, 0x00 };

        [NativeTypeName("#define SDL_HINT_WINDOWS_FORCE_SEMAPHORE_KERNEL \"SDL_WINDOWS_FORCE_SEMAPHORE_KERNEL\"")]
        public static ReadOnlySpan<byte> SDL_HINT_WINDOWS_FORCE_SEMAPHORE_KERNEL => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x57, 0x49, 0x4E, 0x44, 0x4F, 0x57, 0x53, 0x5F, 0x46, 0x4F, 0x52, 0x43, 0x45, 0x5F, 0x53, 0x45, 0x4D, 0x41, 0x50, 0x48, 0x4F, 0x52, 0x45, 0x5F, 0x4B, 0x45, 0x52, 0x4E, 0x45, 0x4C, 0x00 };

        [NativeTypeName("#define SDL_HINT_WINDOWS_INTRESOURCE_ICON \"SDL_WINDOWS_INTRESOURCE_ICON\"")]
        public static ReadOnlySpan<byte> SDL_HINT_WINDOWS_INTRESOURCE_ICON => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x57, 0x49, 0x4E, 0x44, 0x4F, 0x57, 0x53, 0x5F, 0x49, 0x4E, 0x54, 0x52, 0x45, 0x53, 0x4F, 0x55, 0x52, 0x43, 0x45, 0x5F, 0x49, 0x43, 0x4F, 0x4E, 0x00 };

        [NativeTypeName("#define SDL_HINT_WINDOWS_INTRESOURCE_ICON_SMALL \"SDL_WINDOWS_INTRESOURCE_ICON_SMALL\"")]
        public static ReadOnlySpan<byte> SDL_HINT_WINDOWS_INTRESOURCE_ICON_SMALL => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x57, 0x49, 0x4E, 0x44, 0x4F, 0x57, 0x53, 0x5F, 0x49, 0x4E, 0x54, 0x52, 0x45, 0x53, 0x4F, 0x55, 0x52, 0x43, 0x45, 0x5F, 0x49, 0x43, 0x4F, 0x4E, 0x5F, 0x53, 0x4D, 0x41, 0x4C, 0x4C, 0x00 };

        [NativeTypeName("#define SDL_HINT_WINDOWS_NO_CLOSE_ON_ALT_F4 \"SDL_WINDOWS_NO_CLOSE_ON_ALT_F4\"")]
        public static ReadOnlySpan<byte> SDL_HINT_WINDOWS_NO_CLOSE_ON_ALT_F4 => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x57, 0x49, 0x4E, 0x44, 0x4F, 0x57, 0x53, 0x5F, 0x4E, 0x4F, 0x5F, 0x43, 0x4C, 0x4F, 0x53, 0x45, 0x5F, 0x4F, 0x4E, 0x5F, 0x41, 0x4C, 0x54, 0x5F, 0x46, 0x34, 0x00 };

        [NativeTypeName("#define SDL_HINT_WINDOWS_USE_D3D9EX \"SDL_WINDOWS_USE_D3D9EX\"")]
        public static ReadOnlySpan<byte> SDL_HINT_WINDOWS_USE_D3D9EX => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x57, 0x49, 0x4E, 0x44, 0x4F, 0x57, 0x53, 0x5F, 0x55, 0x53, 0x45, 0x5F, 0x44, 0x33, 0x44, 0x39, 0x45, 0x58, 0x00 };

        [NativeTypeName("#define SDL_HINT_WINDOWS_DPI_AWARENESS \"SDL_WINDOWS_DPI_AWARENESS\"")]
        public static ReadOnlySpan<byte> SDL_HINT_WINDOWS_DPI_AWARENESS => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x57, 0x49, 0x4E, 0x44, 0x4F, 0x57, 0x53, 0x5F, 0x44, 0x50, 0x49, 0x5F, 0x41, 0x57, 0x41, 0x52, 0x45, 0x4E, 0x45, 0x53, 0x53, 0x00 };

        [NativeTypeName("#define SDL_HINT_WINDOWS_DPI_SCALING \"SDL_WINDOWS_DPI_SCALING\"")]
        public static ReadOnlySpan<byte> SDL_HINT_WINDOWS_DPI_SCALING => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x57, 0x49, 0x4E, 0x44, 0x4F, 0x57, 0x53, 0x5F, 0x44, 0x50, 0x49, 0x5F, 0x53, 0x43, 0x41, 0x4C, 0x49, 0x4E, 0x47, 0x00 };

        [NativeTypeName("#define SDL_HINT_WINDOW_FRAME_USABLE_WHILE_CURSOR_HIDDEN \"SDL_WINDOW_FRAME_USABLE_WHILE_CURSOR_HIDDEN\"")]
        public static ReadOnlySpan<byte> SDL_HINT_WINDOW_FRAME_USABLE_WHILE_CURSOR_HIDDEN => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x57, 0x49, 0x4E, 0x44, 0x4F, 0x57, 0x5F, 0x46, 0x52, 0x41, 0x4D, 0x45, 0x5F, 0x55, 0x53, 0x41, 0x42, 0x4C, 0x45, 0x5F, 0x57, 0x48, 0x49, 0x4C, 0x45, 0x5F, 0x43, 0x55, 0x52, 0x53, 0x4F, 0x52, 0x5F, 0x48, 0x49, 0x44, 0x44, 0x45, 0x4E, 0x00 };

        [NativeTypeName("#define SDL_HINT_WINDOW_NO_ACTIVATION_WHEN_SHOWN \"SDL_WINDOW_NO_ACTIVATION_WHEN_SHOWN\"")]
        public static ReadOnlySpan<byte> SDL_HINT_WINDOW_NO_ACTIVATION_WHEN_SHOWN => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x57, 0x49, 0x4E, 0x44, 0x4F, 0x57, 0x5F, 0x4E, 0x4F, 0x5F, 0x41, 0x43, 0x54, 0x49, 0x56, 0x41, 0x54, 0x49, 0x4F, 0x4E, 0x5F, 0x57, 0x48, 0x45, 0x4E, 0x5F, 0x53, 0x48, 0x4F, 0x57, 0x4E, 0x00 };

        [NativeTypeName("#define SDL_HINT_WINRT_HANDLE_BACK_BUTTON \"SDL_WINRT_HANDLE_BACK_BUTTON\"")]
        public static ReadOnlySpan<byte> SDL_HINT_WINRT_HANDLE_BACK_BUTTON => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x57, 0x49, 0x4E, 0x52, 0x54, 0x5F, 0x48, 0x41, 0x4E, 0x44, 0x4C, 0x45, 0x5F, 0x42, 0x41, 0x43, 0x4B, 0x5F, 0x42, 0x55, 0x54, 0x54, 0x4F, 0x4E, 0x00 };

        [NativeTypeName("#define SDL_HINT_WINRT_PRIVACY_POLICY_LABEL \"SDL_WINRT_PRIVACY_POLICY_LABEL\"")]
        public static ReadOnlySpan<byte> SDL_HINT_WINRT_PRIVACY_POLICY_LABEL => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x57, 0x49, 0x4E, 0x52, 0x54, 0x5F, 0x50, 0x52, 0x49, 0x56, 0x41, 0x43, 0x59, 0x5F, 0x50, 0x4F, 0x4C, 0x49, 0x43, 0x59, 0x5F, 0x4C, 0x41, 0x42, 0x45, 0x4C, 0x00 };

        [NativeTypeName("#define SDL_HINT_WINRT_PRIVACY_POLICY_URL \"SDL_WINRT_PRIVACY_POLICY_URL\"")]
        public static ReadOnlySpan<byte> SDL_HINT_WINRT_PRIVACY_POLICY_URL => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x57, 0x49, 0x4E, 0x52, 0x54, 0x5F, 0x50, 0x52, 0x49, 0x56, 0x41, 0x43, 0x59, 0x5F, 0x50, 0x4F, 0x4C, 0x49, 0x43, 0x59, 0x5F, 0x55, 0x52, 0x4C, 0x00 };

        [NativeTypeName("#define SDL_HINT_X11_FORCE_OVERRIDE_REDIRECT \"SDL_X11_FORCE_OVERRIDE_REDIRECT\"")]
        public static ReadOnlySpan<byte> SDL_HINT_X11_FORCE_OVERRIDE_REDIRECT => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x58, 0x31, 0x31, 0x5F, 0x46, 0x4F, 0x52, 0x43, 0x45, 0x5F, 0x4F, 0x56, 0x45, 0x52, 0x52, 0x49, 0x44, 0x45, 0x5F, 0x52, 0x45, 0x44, 0x49, 0x52, 0x45, 0x43, 0x54, 0x00 };

        [NativeTypeName("#define SDL_HINT_XINPUT_ENABLED \"SDL_XINPUT_ENABLED\"")]
        public static ReadOnlySpan<byte> SDL_HINT_XINPUT_ENABLED => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x58, 0x49, 0x4E, 0x50, 0x55, 0x54, 0x5F, 0x45, 0x4E, 0x41, 0x42, 0x4C, 0x45, 0x44, 0x00 };

        [NativeTypeName("#define SDL_HINT_DIRECTINPUT_ENABLED \"SDL_DIRECTINPUT_ENABLED\"")]
        public static ReadOnlySpan<byte> SDL_HINT_DIRECTINPUT_ENABLED => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x44, 0x49, 0x52, 0x45, 0x43, 0x54, 0x49, 0x4E, 0x50, 0x55, 0x54, 0x5F, 0x45, 0x4E, 0x41, 0x42, 0x4C, 0x45, 0x44, 0x00 };

        [NativeTypeName("#define SDL_HINT_XINPUT_USE_OLD_JOYSTICK_MAPPING \"SDL_XINPUT_USE_OLD_JOYSTICK_MAPPING\"")]
        public static ReadOnlySpan<byte> SDL_HINT_XINPUT_USE_OLD_JOYSTICK_MAPPING => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x58, 0x49, 0x4E, 0x50, 0x55, 0x54, 0x5F, 0x55, 0x53, 0x45, 0x5F, 0x4F, 0x4C, 0x44, 0x5F, 0x4A, 0x4F, 0x59, 0x53, 0x54, 0x49, 0x43, 0x4B, 0x5F, 0x4D, 0x41, 0x50, 0x50, 0x49, 0x4E, 0x47, 0x00 };

        [NativeTypeName("#define SDL_HINT_AUDIO_INCLUDE_MONITORS \"SDL_AUDIO_INCLUDE_MONITORS\"")]
        public static ReadOnlySpan<byte> SDL_HINT_AUDIO_INCLUDE_MONITORS => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x41, 0x55, 0x44, 0x49, 0x4F, 0x5F, 0x49, 0x4E, 0x43, 0x4C, 0x55, 0x44, 0x45, 0x5F, 0x4D, 0x4F, 0x4E, 0x49, 0x54, 0x4F, 0x52, 0x53, 0x00 };

        [NativeTypeName("#define SDL_HINT_X11_WINDOW_TYPE \"SDL_X11_WINDOW_TYPE\"")]
        public static ReadOnlySpan<byte> SDL_HINT_X11_WINDOW_TYPE => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x58, 0x31, 0x31, 0x5F, 0x57, 0x49, 0x4E, 0x44, 0x4F, 0x57, 0x5F, 0x54, 0x59, 0x50, 0x45, 0x00 };

        [NativeTypeName("#define SDL_HINT_QUIT_ON_LAST_WINDOW_CLOSE \"SDL_QUIT_ON_LAST_WINDOW_CLOSE\"")]
        public static ReadOnlySpan<byte> SDL_HINT_QUIT_ON_LAST_WINDOW_CLOSE => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x51, 0x55, 0x49, 0x54, 0x5F, 0x4F, 0x4E, 0x5F, 0x4C, 0x41, 0x53, 0x54, 0x5F, 0x57, 0x49, 0x4E, 0x44, 0x4F, 0x57, 0x5F, 0x43, 0x4C, 0x4F, 0x53, 0x45, 0x00 };

        [NativeTypeName("#define SDL_HINT_VIDEODRIVER \"SDL_VIDEODRIVER\"")]
        public static ReadOnlySpan<byte> SDL_HINT_VIDEODRIVER => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x56, 0x49, 0x44, 0x45, 0x4F, 0x44, 0x52, 0x49, 0x56, 0x45, 0x52, 0x00 };

        [NativeTypeName("#define SDL_HINT_AUDIODRIVER \"SDL_AUDIODRIVER\"")]
        public static ReadOnlySpan<byte> SDL_HINT_AUDIODRIVER => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x41, 0x55, 0x44, 0x49, 0x4F, 0x44, 0x52, 0x49, 0x56, 0x45, 0x52, 0x00 };

        [NativeTypeName("#define SDL_HINT_KMSDRM_DEVICE_INDEX \"SDL_KMSDRM_DEVICE_INDEX\"")]
        public static ReadOnlySpan<byte> SDL_HINT_KMSDRM_DEVICE_INDEX => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x4B, 0x4D, 0x53, 0x44, 0x52, 0x4D, 0x5F, 0x44, 0x45, 0x56, 0x49, 0x43, 0x45, 0x5F, 0x49, 0x4E, 0x44, 0x45, 0x58, 0x00 };

        [NativeTypeName("#define SDL_HINT_TRACKPAD_IS_TOUCH_ONLY \"SDL_TRACKPAD_IS_TOUCH_ONLY\"")]
        public static ReadOnlySpan<byte> SDL_HINT_TRACKPAD_IS_TOUCH_ONLY => new byte[] { 0x53, 0x44, 0x4C, 0x5F, 0x54, 0x52, 0x41, 0x43, 0x4B, 0x50, 0x41, 0x44, 0x5F, 0x49, 0x53, 0x5F, 0x54, 0x4F, 0x55, 0x43, 0x48, 0x5F, 0x4F, 0x4E, 0x4C, 0x59, 0x00 };

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetClipboardText", ExactSpelling = true)]
        public static extern int SetClipboardText([NativeTypeName("const char *")] sbyte* text);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetClipboardText", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* GetClipboardText();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasClipboardText", ExactSpelling = true)]
        public static extern SDL_bool HasClipboardText();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetPrimarySelectionText", ExactSpelling = true)]
        public static extern int SetPrimarySelectionText([NativeTypeName("const char *")] sbyte* text);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPrimarySelectionText", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* GetPrimarySelectionText();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasPrimarySelectionText", ExactSpelling = true)]
        public static extern SDL_bool HasPrimarySelectionText();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ComposeCustomBlendMode", ExactSpelling = true)]
        public static extern SDL_BlendMode ComposeCustomBlendMode(SDL_BlendFactor srcColorFactor, SDL_BlendFactor dstColorFactor, SDL_BlendOperation colorOperation, SDL_BlendFactor srcAlphaFactor, SDL_BlendFactor dstAlphaFactor, SDL_BlendOperation alphaOperation);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetError", ExactSpelling = true)]
        public static extern int SetError([NativeTypeName("const char *")] sbyte* fmt, __arglist);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetError", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* GetError();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetErrorMsg", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* GetErrorMsg([NativeTypeName("char *")] sbyte* errstr, int maxlen);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ClearError", ExactSpelling = true)]
        public static extern void ClearError();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_Error", ExactSpelling = true)]
        public static extern int Error(SDL_errorcode code);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RecordGesture", ExactSpelling = true)]
        public static extern int RecordGesture([NativeTypeName("SDL_TouchID")] nint touchId);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SaveAllDollarTemplates", ExactSpelling = true)]
        public static extern int SaveAllDollarTemplates(SDL_RWops* dst);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SaveDollarTemplate", ExactSpelling = true)]
        public static extern int SaveDollarTemplate([NativeTypeName("SDL_GestureID")] nint gestureId, SDL_RWops* dst);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LoadDollarTemplates", ExactSpelling = true)]
        public static extern int LoadDollarTemplates([NativeTypeName("SDL_TouchID")] nint touchId, SDL_RWops* src);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GUIDToString", ExactSpelling = true)]
        public static extern void GUIDToString(SDL_GUID guid, [NativeTypeName("char *")] sbyte* pszGUID, int cbGUID);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GUIDFromString", ExactSpelling = true)]
        public static extern SDL_GUID GUIDFromString([NativeTypeName("const char *")] sbyte* pchGUID);

        [NativeTypeName("#define SDL_REVISION \"\"")]
        public static ReadOnlySpan<byte> SDL_REVISION => new byte[] { 0x00 };

        [NativeTypeName("#define SDL_REVISION_NUMBER 0")]
        public const int SDL_REVISION_NUMBER = 0;

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumTouchDevices", ExactSpelling = true)]
        public static extern int GetNumTouchDevices();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTouchDevice", ExactSpelling = true)]
        [return: NativeTypeName("SDL_TouchID")]
        public static extern nint GetTouchDevice(int index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTouchName", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* GetTouchName(int index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTouchDeviceType", ExactSpelling = true)]
        public static extern SDL_TouchDeviceType GetTouchDeviceType([NativeTypeName("SDL_TouchID")] nint touchID);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumTouchFingers", ExactSpelling = true)]
        public static extern int GetNumTouchFingers([NativeTypeName("SDL_TouchID")] nint touchID);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTouchFinger", ExactSpelling = true)]
        public static extern SDL_Finger* GetTouchFinger([NativeTypeName("SDL_TouchID")] nint touchID, int index);

        [NativeTypeName("#define SDL_TOUCH_MOUSEID ((Uint32)-1)")]
        public const uint SDL_TOUCH_MOUSEID = unchecked((uint)(-1));

        [NativeTypeName("#define SDL_MOUSE_TOUCHID ((Sint64)-1)")]
        public static readonly nint SDL_MOUSE_TOUCHID = ((nint)(-1));

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPlatform", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* GetPlatform();

        [NativeTypeName("#define __LINUX__ 1")]
        public const int __LINUX__ = 1;

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RWFromFile", ExactSpelling = true)]
        public static extern SDL_RWops* RWFromFile([NativeTypeName("const char *")] sbyte* file, [NativeTypeName("const char *")] sbyte* mode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RWFromFP", ExactSpelling = true)]
        public static extern SDL_RWops* RWFromFP(void* fp, SDL_bool autoclose);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RWFromMem", ExactSpelling = true)]
        public static extern SDL_RWops* RWFromMem(void* mem, int size);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RWFromConstMem", ExactSpelling = true)]
        public static extern SDL_RWops* RWFromConstMem([NativeTypeName("const void *")] void* mem, int size);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AllocRW", ExactSpelling = true)]
        public static extern SDL_RWops* AllocRW();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FreeRW", ExactSpelling = true)]
        public static extern void FreeRW(SDL_RWops* area);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RWsize", ExactSpelling = true)]
        [return: NativeTypeName("Sint64")]
        public static extern nint RWsize(SDL_RWops* context);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RWseek", ExactSpelling = true)]
        [return: NativeTypeName("Sint64")]
        public static extern nint RWseek(SDL_RWops* context, [NativeTypeName("Sint64")] nint offset, int whence);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RWtell", ExactSpelling = true)]
        [return: NativeTypeName("Sint64")]
        public static extern nint RWtell(SDL_RWops* context);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RWread", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint RWread(SDL_RWops* context, void* ptr, [NativeTypeName("size_t")] nuint size, [NativeTypeName("size_t")] nuint maxnum);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RWwrite", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint RWwrite(SDL_RWops* context, [NativeTypeName("const void *")] void* ptr, [NativeTypeName("size_t")] nuint size, [NativeTypeName("size_t")] nuint num);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RWclose", ExactSpelling = true)]
        public static extern int RWclose(SDL_RWops* context);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LoadFile_RW", ExactSpelling = true)]
        public static extern void* LoadFile_RW(SDL_RWops* src, [NativeTypeName("size_t *")] nuint* datasize, int freesrc);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LoadFile", ExactSpelling = true)]
        public static extern void* LoadFile([NativeTypeName("const char *")] sbyte* file, [NativeTypeName("size_t *")] nuint* datasize);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadU8", ExactSpelling = true)]
        [return: NativeTypeName("Uint8")]
        public static extern byte ReadU8(SDL_RWops* src);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadLE16", ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort ReadLE16(SDL_RWops* src);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadBE16", ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort ReadBE16(SDL_RWops* src);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadLE32", ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint ReadLE32(SDL_RWops* src);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadBE32", ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint ReadBE32(SDL_RWops* src);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadLE64", ExactSpelling = true)]
        [return: NativeTypeName("Uint64")]
        public static extern nuint ReadLE64(SDL_RWops* src);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadBE64", ExactSpelling = true)]
        [return: NativeTypeName("Uint64")]
        public static extern nuint ReadBE64(SDL_RWops* src);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteU8", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint WriteU8(SDL_RWops* dst, [NativeTypeName("Uint8")] byte value);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteLE16", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint WriteLE16(SDL_RWops* dst, [NativeTypeName("Uint16")] ushort value);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteBE16", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint WriteBE16(SDL_RWops* dst, [NativeTypeName("Uint16")] ushort value);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteLE32", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint WriteLE32(SDL_RWops* dst, [NativeTypeName("Uint32")] uint value);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteBE32", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint WriteBE32(SDL_RWops* dst, [NativeTypeName("Uint32")] uint value);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteLE64", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint WriteLE64(SDL_RWops* dst, [NativeTypeName("Uint64")] nuint value);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteBE64", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint WriteBE64(SDL_RWops* dst, [NativeTypeName("Uint64")] nuint value);

        [NativeTypeName("#define SDL_RWOPS_UNKNOWN 0U")]
        public const uint SDL_RWOPS_UNKNOWN = 0U;

        [NativeTypeName("#define SDL_RWOPS_WINFILE 1U")]
        public const uint SDL_RWOPS_WINFILE = 1U;

        [NativeTypeName("#define SDL_RWOPS_STDFILE 2U")]
        public const uint SDL_RWOPS_STDFILE = 2U;

        [NativeTypeName("#define SDL_RWOPS_JNIFILE 3U")]
        public const uint SDL_RWOPS_JNIFILE = 3U;

        [NativeTypeName("#define SDL_RWOPS_MEMORY 4U")]
        public const uint SDL_RWOPS_MEMORY = 4U;

        [NativeTypeName("#define SDL_RWOPS_MEMORY_RO 5U")]
        public const uint SDL_RWOPS_MEMORY_RO = 5U;

        [NativeTypeName("#define RW_SEEK_SET 0")]
        public const int RW_SEEK_SET = 0;

        [NativeTypeName("#define RW_SEEK_CUR 1")]
        public const int RW_SEEK_CUR = 1;

        [NativeTypeName("#define RW_SEEK_END 2")]
        public const int RW_SEEK_END = 2;

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetVersion", ExactSpelling = true)]
        public static extern void GetVersion(SDL_version* ver);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRevision", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* GetRevision();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRevisionNumber", ExactSpelling = true)]
        [Obsolete]
        public static extern int GetRevisionNumber();

        [NativeTypeName("#define SDL_MAJOR_VERSION 2")]
        public const int SDL_MAJOR_VERSION = 2;

        [NativeTypeName("#define SDL_MINOR_VERSION 26")]
        public const int SDL_MINOR_VERSION = 26;

        [NativeTypeName("#define SDL_PATCHLEVEL 5")]
        public const int SDL_PATCHLEVEL = 5;

        [NativeTypeName("#define SDL_COMPILEDVERSION SDL_VERSIONNUM(SDL_MAJOR_VERSION, SDL_MINOR_VERSION, SDL_PATCHLEVEL)")]
        public const int SDL_COMPILEDVERSION = ((2) * 1000 + (26) * 100 + (5));

        [NativeTypeName("#define SDLK_SCANCODE_MASK (1<<30)")]
        public const int SDLK_SCANCODE_MASK = (1 << 30);

        [NativeTypeName("#define SDL_MAIN_NEEDED 1")]
        public const int SDL_MAIN_NEEDED = 1;

        [NativeTypeName("#define LACKS_SYS_MMAN_H 1")]
        public const int LACKS_SYS_MMAN_H = 1;

        [NativeTypeName("#define SDL_THREAD_NGAGE 1")]
        public const int SDL_THREAD_NGAGE = 1;

        [NativeTypeName("#define SDL_TIMER_NGAGE 1")]
        public const int SDL_TIMER_NGAGE = 1;

        [NativeTypeName("#define SDL_VIDEO_DRIVER_NGAGE 1")]
        public const int SDL_VIDEO_DRIVER_NGAGE = 1;

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateShapedWindow", ExactSpelling = true)]
        public static extern SDL_Window* CreateShapedWindow([NativeTypeName("const char *")] sbyte* title, [NativeTypeName("unsigned int")] uint x, [NativeTypeName("unsigned int")] uint y, [NativeTypeName("unsigned int")] uint w, [NativeTypeName("unsigned int")] uint h, [NativeTypeName("Uint32")] uint flags);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IsShapedWindow", ExactSpelling = true)]
        public static extern SDL_bool IsShapedWindow([NativeTypeName("const SDL_Window *")] SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowShape", ExactSpelling = true)]
        public static extern int SetWindowShape(SDL_Window* window, SDL_Surface* shape, SDL_WindowShapeMode* shape_mode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetShapedWindowMode", ExactSpelling = true)]
        public static extern int GetShapedWindowMode(SDL_Window* window, SDL_WindowShapeMode* shape_mode);

        [NativeTypeName("#define SDL_NONSHAPEABLE_WINDOW -1")]
        public const int SDL_NONSHAPEABLE_WINDOW = -1;

        [NativeTypeName("#define SDL_INVALID_SHAPE_ARGUMENT -2")]
        public const int SDL_INVALID_SHAPE_ARGUMENT = -2;

        [NativeTypeName("#define SDL_WINDOW_LACKS_SHAPE -3")]
        public const int SDL_WINDOW_LACKS_SHAPE = -3;

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PumpEvents", ExactSpelling = true)]
        public static extern void PumpEvents();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PeepEvents", ExactSpelling = true)]
        public static extern int PeepEvents(SDL_Event* events, int numevents, SDL_eventaction action, [NativeTypeName("Uint32")] uint minType, [NativeTypeName("Uint32")] uint maxType);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasEvent", ExactSpelling = true)]
        public static extern SDL_bool HasEvent([NativeTypeName("Uint32")] uint type);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasEvents", ExactSpelling = true)]
        public static extern SDL_bool HasEvents([NativeTypeName("Uint32")] uint minType, [NativeTypeName("Uint32")] uint maxType);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FlushEvent", ExactSpelling = true)]
        public static extern void FlushEvent([NativeTypeName("Uint32")] uint type);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FlushEvents", ExactSpelling = true)]
        public static extern void FlushEvents([NativeTypeName("Uint32")] uint minType, [NativeTypeName("Uint32")] uint maxType);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PollEvent", ExactSpelling = true)]
        public static extern int PollEvent(SDL_Event* @event);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WaitEvent", ExactSpelling = true)]
        public static extern int WaitEvent(SDL_Event* @event);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WaitEventTimeout", ExactSpelling = true)]
        public static extern int WaitEventTimeout(SDL_Event* @event, int timeout);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PushEvent", ExactSpelling = true)]
        public static extern int PushEvent(SDL_Event* @event);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetEventFilter", ExactSpelling = true)]
        public static extern void SetEventFilter([NativeTypeName("SDL_EventFilter")] delegate* unmanaged[Cdecl]<void*, SDL_Event*, int> filter, void* userdata);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetEventFilter", ExactSpelling = true)]
        public static extern SDL_bool GetEventFilter([NativeTypeName("SDL_EventFilter *")] delegate* unmanaged[Cdecl]<void*, SDL_Event*, int>* filter, void** userdata);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AddEventWatch", ExactSpelling = true)]
        public static extern void AddEventWatch([NativeTypeName("SDL_EventFilter")] delegate* unmanaged[Cdecl]<void*, SDL_Event*, int> filter, void* userdata);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DelEventWatch", ExactSpelling = true)]
        public static extern void DelEventWatch([NativeTypeName("SDL_EventFilter")] delegate* unmanaged[Cdecl]<void*, SDL_Event*, int> filter, void* userdata);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FilterEvents", ExactSpelling = true)]
        public static extern void FilterEvents([NativeTypeName("SDL_EventFilter")] delegate* unmanaged[Cdecl]<void*, SDL_Event*, int> filter, void* userdata);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EventState", ExactSpelling = true)]
        [return: NativeTypeName("Uint8")]
        public static extern byte EventState([NativeTypeName("Uint32")] uint type, int state);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RegisterEvents", ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint RegisterEvents(int numevents);

        [NativeTypeName("#define SDL_RELEASED 0")]
        public const int SDL_RELEASED = 0;

        [NativeTypeName("#define SDL_PRESSED 1")]
        public const int SDL_PRESSED = 1;

        [NativeTypeName("#define SDL_TEXTEDITINGEVENT_TEXT_SIZE (32)")]
        public const int SDL_TEXTEDITINGEVENT_TEXT_SIZE = (32);

        [NativeTypeName("#define SDL_TEXTINPUTEVENT_TEXT_SIZE (32)")]
        public const int SDL_TEXTINPUTEVENT_TEXT_SIZE = (32);

        [NativeTypeName("#define SDL_QUERY -1")]
        public const int SDL_QUERY = -1;

        [NativeTypeName("#define SDL_IGNORE 0")]
        public const int SDL_IGNORE = 0;

        [NativeTypeName("#define SDL_DISABLE 0")]
        public const int SDL_DISABLE = 0;

        [NativeTypeName("#define SDL_ENABLE 1")]
        public const int SDL_ENABLE = 1;

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetMouseFocus", ExactSpelling = true)]
        public static extern SDL_Window* GetMouseFocus();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetMouseState", ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint GetMouseState(int* x, int* y);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGlobalMouseState", ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint GetGlobalMouseState(int* x, int* y);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRelativeMouseState", ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint GetRelativeMouseState(int* x, int* y);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WarpMouseInWindow", ExactSpelling = true)]
        public static extern void WarpMouseInWindow(SDL_Window* window, int x, int y);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WarpMouseGlobal", ExactSpelling = true)]
        public static extern int WarpMouseGlobal(int x, int y);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRelativeMouseMode", ExactSpelling = true)]
        public static extern int SetRelativeMouseMode(SDL_bool enabled);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CaptureMouse", ExactSpelling = true)]
        public static extern int CaptureMouse(SDL_bool enabled);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRelativeMouseMode", ExactSpelling = true)]
        public static extern SDL_bool GetRelativeMouseMode();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateCursor", ExactSpelling = true)]
        public static extern SDL_Cursor* CreateCursor([NativeTypeName("const Uint8 *")] byte* data, [NativeTypeName("const Uint8 *")] byte* mask, int w, int h, int hot_x, int hot_y);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateColorCursor", ExactSpelling = true)]
        public static extern SDL_Cursor* CreateColorCursor(SDL_Surface* surface, int hot_x, int hot_y);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateSystemCursor", ExactSpelling = true)]
        public static extern SDL_Cursor* CreateSystemCursor(SDL_SystemCursor id);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetCursor", ExactSpelling = true)]
        public static extern void SetCursor(SDL_Cursor* cursor);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCursor", ExactSpelling = true)]
        public static extern SDL_Cursor* GetCursor();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDefaultCursor", ExactSpelling = true)]
        public static extern SDL_Cursor* GetDefaultCursor();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FreeCursor", ExactSpelling = true)]
        public static extern void FreeCursor(SDL_Cursor* cursor);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShowCursor", ExactSpelling = true)]
        public static extern int ShowCursor(int toggle);

        [NativeTypeName("#define SDL_BUTTON_LEFT 1")]
        public const int SDL_BUTTON_LEFT = 1;

        [NativeTypeName("#define SDL_BUTTON_MIDDLE 2")]
        public const int SDL_BUTTON_MIDDLE = 2;

        [NativeTypeName("#define SDL_BUTTON_RIGHT 3")]
        public const int SDL_BUTTON_RIGHT = 3;

        [NativeTypeName("#define SDL_BUTTON_X1 4")]
        public const int SDL_BUTTON_X1 = 4;

        [NativeTypeName("#define SDL_BUTTON_X2 5")]
        public const int SDL_BUTTON_X2 = 5;

        [NativeTypeName("#define SDL_BUTTON_LMASK SDL_BUTTON(SDL_BUTTON_LEFT)")]
        public const int SDL_BUTTON_LMASK = (1 << ((1) - 1));

        [NativeTypeName("#define SDL_BUTTON_MMASK SDL_BUTTON(SDL_BUTTON_MIDDLE)")]
        public const int SDL_BUTTON_MMASK = (1 << ((2) - 1));

        [NativeTypeName("#define SDL_BUTTON_RMASK SDL_BUTTON(SDL_BUTTON_RIGHT)")]
        public const int SDL_BUTTON_RMASK = (1 << ((3) - 1));

        [NativeTypeName("#define SDL_BUTTON_X1MASK SDL_BUTTON(SDL_BUTTON_X1)")]
        public const int SDL_BUTTON_X1MASK = (1 << ((4) - 1));

        [NativeTypeName("#define SDL_BUTTON_X2MASK SDL_BUTTON(SDL_BUTTON_X2)")]
        public const int SDL_BUTTON_X2MASK = (1 << ((5) - 1));

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumRenderDrivers", ExactSpelling = true)]
        public static extern int GetNumRenderDrivers();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderDriverInfo", ExactSpelling = true)]
        public static extern int GetRenderDriverInfo(int index, SDL_RendererInfo* info);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateWindowAndRenderer", ExactSpelling = true)]
        public static extern int CreateWindowAndRenderer(int width, int height, [NativeTypeName("Uint32")] uint window_flags, SDL_Window** window, SDL_Renderer** renderer);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateRenderer", ExactSpelling = true)]
        public static extern SDL_Renderer* CreateRenderer(SDL_Window* window, int index, [NativeTypeName("Uint32")] uint flags);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateSoftwareRenderer", ExactSpelling = true)]
        public static extern SDL_Renderer* CreateSoftwareRenderer(SDL_Surface* surface);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderer", ExactSpelling = true)]
        public static extern SDL_Renderer* GetRenderer(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderGetWindow", ExactSpelling = true)]
        public static extern SDL_Window* RenderGetWindow(SDL_Renderer* renderer);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRendererInfo", ExactSpelling = true)]
        public static extern int GetRendererInfo(SDL_Renderer* renderer, SDL_RendererInfo* info);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRendererOutputSize", ExactSpelling = true)]
        public static extern int GetRendererOutputSize(SDL_Renderer* renderer, int* w, int* h);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateTexture", ExactSpelling = true)]
        public static extern SDL_Texture* CreateTexture(SDL_Renderer* renderer, [NativeTypeName("Uint32")] uint format, int access, int w, int h);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateTextureFromSurface", ExactSpelling = true)]
        public static extern SDL_Texture* CreateTextureFromSurface(SDL_Renderer* renderer, SDL_Surface* surface);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_QueryTexture", ExactSpelling = true)]
        public static extern int QueryTexture(SDL_Texture* texture, [NativeTypeName("Uint32 *")] uint* format, int* access, int* w, int* h);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTextureColorMod", ExactSpelling = true)]
        public static extern int SetTextureColorMod(SDL_Texture* texture, [NativeTypeName("Uint8")] byte r, [NativeTypeName("Uint8")] byte g, [NativeTypeName("Uint8")] byte b);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTextureColorMod", ExactSpelling = true)]
        public static extern int GetTextureColorMod(SDL_Texture* texture, [NativeTypeName("Uint8 *")] byte* r, [NativeTypeName("Uint8 *")] byte* g, [NativeTypeName("Uint8 *")] byte* b);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTextureAlphaMod", ExactSpelling = true)]
        public static extern int SetTextureAlphaMod(SDL_Texture* texture, [NativeTypeName("Uint8")] byte alpha);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTextureAlphaMod", ExactSpelling = true)]
        public static extern int GetTextureAlphaMod(SDL_Texture* texture, [NativeTypeName("Uint8 *")] byte* alpha);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTextureBlendMode", ExactSpelling = true)]
        public static extern int SetTextureBlendMode(SDL_Texture* texture, SDL_BlendMode blendMode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTextureBlendMode", ExactSpelling = true)]
        public static extern int GetTextureBlendMode(SDL_Texture* texture, SDL_BlendMode* blendMode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTextureScaleMode", ExactSpelling = true)]
        public static extern int SetTextureScaleMode(SDL_Texture* texture, SDL_ScaleMode scaleMode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTextureScaleMode", ExactSpelling = true)]
        public static extern int GetTextureScaleMode(SDL_Texture* texture, SDL_ScaleMode* scaleMode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTextureUserData", ExactSpelling = true)]
        public static extern int SetTextureUserData(SDL_Texture* texture, void* userdata);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTextureUserData", ExactSpelling = true)]
        public static extern void* GetTextureUserData(SDL_Texture* texture);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UpdateTexture", ExactSpelling = true)]
        public static extern int UpdateTexture(SDL_Texture* texture, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, [NativeTypeName("const void *")] void* pixels, int pitch);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UpdateYUVTexture", ExactSpelling = true)]
        public static extern int UpdateYUVTexture(SDL_Texture* texture, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, [NativeTypeName("const Uint8 *")] byte* Yplane, int Ypitch, [NativeTypeName("const Uint8 *")] byte* Uplane, int Upitch, [NativeTypeName("const Uint8 *")] byte* Vplane, int Vpitch);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UpdateNVTexture", ExactSpelling = true)]
        public static extern int UpdateNVTexture(SDL_Texture* texture, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, [NativeTypeName("const Uint8 *")] byte* Yplane, int Ypitch, [NativeTypeName("const Uint8 *")] byte* UVplane, int UVpitch);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LockTexture", ExactSpelling = true)]
        public static extern int LockTexture(SDL_Texture* texture, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, void** pixels, int* pitch);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LockTextureToSurface", ExactSpelling = true)]
        public static extern int LockTextureToSurface(SDL_Texture* texture, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, SDL_Surface** surface);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnlockTexture", ExactSpelling = true)]
        public static extern void UnlockTexture(SDL_Texture* texture);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderTargetSupported", ExactSpelling = true)]
        public static extern SDL_bool RenderTargetSupported(SDL_Renderer* renderer);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderTarget", ExactSpelling = true)]
        public static extern int SetRenderTarget(SDL_Renderer* renderer, SDL_Texture* texture);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderTarget", ExactSpelling = true)]
        public static extern SDL_Texture* GetRenderTarget(SDL_Renderer* renderer);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderSetLogicalSize", ExactSpelling = true)]
        public static extern int RenderSetLogicalSize(SDL_Renderer* renderer, int w, int h);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderGetLogicalSize", ExactSpelling = true)]
        public static extern void RenderGetLogicalSize(SDL_Renderer* renderer, int* w, int* h);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderSetIntegerScale", ExactSpelling = true)]
        public static extern int RenderSetIntegerScale(SDL_Renderer* renderer, SDL_bool enable);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderGetIntegerScale", ExactSpelling = true)]
        public static extern SDL_bool RenderGetIntegerScale(SDL_Renderer* renderer);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderSetViewport", ExactSpelling = true)]
        public static extern int RenderSetViewport(SDL_Renderer* renderer, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderGetViewport", ExactSpelling = true)]
        public static extern void RenderGetViewport(SDL_Renderer* renderer, SDL_Rect* rect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderSetClipRect", ExactSpelling = true)]
        public static extern int RenderSetClipRect(SDL_Renderer* renderer, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderGetClipRect", ExactSpelling = true)]
        public static extern void RenderGetClipRect(SDL_Renderer* renderer, SDL_Rect* rect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderIsClipEnabled", ExactSpelling = true)]
        public static extern SDL_bool RenderIsClipEnabled(SDL_Renderer* renderer);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderSetScale", ExactSpelling = true)]
        public static extern int RenderSetScale(SDL_Renderer* renderer, float scaleX, float scaleY);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderGetScale", ExactSpelling = true)]
        public static extern void RenderGetScale(SDL_Renderer* renderer, float* scaleX, float* scaleY);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderWindowToLogical", ExactSpelling = true)]
        public static extern void RenderWindowToLogical(SDL_Renderer* renderer, int windowX, int windowY, float* logicalX, float* logicalY);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderLogicalToWindow", ExactSpelling = true)]
        public static extern void RenderLogicalToWindow(SDL_Renderer* renderer, float logicalX, float logicalY, int* windowX, int* windowY);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderDrawColor", ExactSpelling = true)]
        public static extern int SetRenderDrawColor(SDL_Renderer* renderer, [NativeTypeName("Uint8")] byte r, [NativeTypeName("Uint8")] byte g, [NativeTypeName("Uint8")] byte b, [NativeTypeName("Uint8")] byte a);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderDrawColor", ExactSpelling = true)]
        public static extern int GetRenderDrawColor(SDL_Renderer* renderer, [NativeTypeName("Uint8 *")] byte* r, [NativeTypeName("Uint8 *")] byte* g, [NativeTypeName("Uint8 *")] byte* b, [NativeTypeName("Uint8 *")] byte* a);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderDrawBlendMode", ExactSpelling = true)]
        public static extern int SetRenderDrawBlendMode(SDL_Renderer* renderer, SDL_BlendMode blendMode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderDrawBlendMode", ExactSpelling = true)]
        public static extern int GetRenderDrawBlendMode(SDL_Renderer* renderer, SDL_BlendMode* blendMode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderClear", ExactSpelling = true)]
        public static extern int RenderClear(SDL_Renderer* renderer);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderDrawPoint", ExactSpelling = true)]
        public static extern int RenderDrawPoint(SDL_Renderer* renderer, int x, int y);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderDrawPoints", ExactSpelling = true)]
        public static extern int RenderDrawPoints(SDL_Renderer* renderer, [NativeTypeName("const SDL_Point *")] SDL_Point* points, int count);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderDrawLine", ExactSpelling = true)]
        public static extern int RenderDrawLine(SDL_Renderer* renderer, int x1, int y1, int x2, int y2);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderDrawLines", ExactSpelling = true)]
        public static extern int RenderDrawLines(SDL_Renderer* renderer, [NativeTypeName("const SDL_Point *")] SDL_Point* points, int count);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderDrawRect", ExactSpelling = true)]
        public static extern int RenderDrawRect(SDL_Renderer* renderer, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderDrawRects", ExactSpelling = true)]
        public static extern int RenderDrawRects(SDL_Renderer* renderer, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rects, int count);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderFillRect", ExactSpelling = true)]
        public static extern int RenderFillRect(SDL_Renderer* renderer, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderFillRects", ExactSpelling = true)]
        public static extern int RenderFillRects(SDL_Renderer* renderer, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rects, int count);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderCopy", ExactSpelling = true)]
        public static extern int RenderCopy(SDL_Renderer* renderer, SDL_Texture* texture, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, [NativeTypeName("const SDL_Rect *")] SDL_Rect* dstrect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderCopyEx", ExactSpelling = true)]
        public static extern int RenderCopyEx(SDL_Renderer* renderer, SDL_Texture* texture, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, [NativeTypeName("const SDL_Rect *")] SDL_Rect* dstrect, [NativeTypeName("const double")] double angle, [NativeTypeName("const SDL_Point *")] SDL_Point* center, [NativeTypeName("const SDL_RendererFlip")] SDL_RendererFlip flip);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderDrawPointF", ExactSpelling = true)]
        public static extern int RenderDrawPointF(SDL_Renderer* renderer, float x, float y);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderDrawPointsF", ExactSpelling = true)]
        public static extern int RenderDrawPointsF(SDL_Renderer* renderer, [NativeTypeName("const SDL_FPoint *")] SDL_FPoint* points, int count);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderDrawLineF", ExactSpelling = true)]
        public static extern int RenderDrawLineF(SDL_Renderer* renderer, float x1, float y1, float x2, float y2);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderDrawLinesF", ExactSpelling = true)]
        public static extern int RenderDrawLinesF(SDL_Renderer* renderer, [NativeTypeName("const SDL_FPoint *")] SDL_FPoint* points, int count);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderDrawRectF", ExactSpelling = true)]
        public static extern int RenderDrawRectF(SDL_Renderer* renderer, [NativeTypeName("const SDL_FRect *")] SDL_FRect* rect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderDrawRectsF", ExactSpelling = true)]
        public static extern int RenderDrawRectsF(SDL_Renderer* renderer, [NativeTypeName("const SDL_FRect *")] SDL_FRect* rects, int count);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderFillRectF", ExactSpelling = true)]
        public static extern int RenderFillRectF(SDL_Renderer* renderer, [NativeTypeName("const SDL_FRect *")] SDL_FRect* rect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderFillRectsF", ExactSpelling = true)]
        public static extern int RenderFillRectsF(SDL_Renderer* renderer, [NativeTypeName("const SDL_FRect *")] SDL_FRect* rects, int count);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderCopyF", ExactSpelling = true)]
        public static extern int RenderCopyF(SDL_Renderer* renderer, SDL_Texture* texture, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, [NativeTypeName("const SDL_FRect *")] SDL_FRect* dstrect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderCopyExF", ExactSpelling = true)]
        public static extern int RenderCopyExF(SDL_Renderer* renderer, SDL_Texture* texture, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, [NativeTypeName("const SDL_FRect *")] SDL_FRect* dstrect, [NativeTypeName("const double")] double angle, [NativeTypeName("const SDL_FPoint *")] SDL_FPoint* center, [NativeTypeName("const SDL_RendererFlip")] SDL_RendererFlip flip);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderGeometry", ExactSpelling = true)]
        public static extern int RenderGeometry(SDL_Renderer* renderer, SDL_Texture* texture, [NativeTypeName("const SDL_Vertex *")] SDL_Vertex* vertices, int num_vertices, [NativeTypeName("const int *")] int* indices, int num_indices);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderGeometryRaw", ExactSpelling = true)]
        public static extern int RenderGeometryRaw(SDL_Renderer* renderer, SDL_Texture* texture, [NativeTypeName("const float *")] float* xy, int xy_stride, [NativeTypeName("const SDL_Color *")] SDL_Color* color, int color_stride, [NativeTypeName("const float *")] float* uv, int uv_stride, int num_vertices, [NativeTypeName("const void *")] void* indices, int num_indices, int size_indices);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderReadPixels", ExactSpelling = true)]
        public static extern int RenderReadPixels(SDL_Renderer* renderer, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, [NativeTypeName("Uint32")] uint format, void* pixels, int pitch);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderPresent", ExactSpelling = true)]
        public static extern void RenderPresent(SDL_Renderer* renderer);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyTexture", ExactSpelling = true)]
        public static extern void DestroyTexture(SDL_Texture* texture);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyRenderer", ExactSpelling = true)]
        public static extern void DestroyRenderer(SDL_Renderer* renderer);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderFlush", ExactSpelling = true)]
        public static extern int RenderFlush(SDL_Renderer* renderer);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_BindTexture", ExactSpelling = true)]
        public static extern int GL_BindTexture(SDL_Texture* texture, float* texw, float* texh);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_UnbindTexture", ExactSpelling = true)]
        public static extern int GL_UnbindTexture(SDL_Texture* texture);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderGetMetalLayer", ExactSpelling = true)]
        public static extern void* RenderGetMetalLayer(SDL_Renderer* renderer);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderGetMetalCommandEncoder", ExactSpelling = true)]
        public static extern void* RenderGetMetalCommandEncoder(SDL_Renderer* renderer);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderSetVSync", ExactSpelling = true)]
        public static extern int RenderSetVSync(SDL_Renderer* renderer, int vsync);

        [NativeTypeName("#define HAVE_SYSCTLBYNAME 1")]
        public const int HAVE_SYSCTLBYNAME = 1;

        [NativeTypeName("#define HAVE_O_CLOEXEC 1")]
        public const int HAVE_O_CLOEXEC = 1;

        [NativeTypeName("#define SDL_AUDIO_DRIVER_COREAUDIO 1")]
        public const int SDL_AUDIO_DRIVER_COREAUDIO = 1;

        [NativeTypeName("#define SDL_HAPTIC_DUMMY 1")]
        public const int SDL_HAPTIC_DUMMY = 1;

        [NativeTypeName("#define SDL_JOYSTICK_MFI 1")]
        public const int SDL_JOYSTICK_MFI = 1;

        [NativeTypeName("#define SDL_SENSOR_COREMOTION 1")]
        public const int SDL_SENSOR_COREMOTION = 1;

        [NativeTypeName("#define SDL_VIDEO_DRIVER_UIKIT 1")]
        public const int SDL_VIDEO_DRIVER_UIKIT = 1;

        [NativeTypeName("#define SDL_PLATFORM_SUPPORTS_METAL 0")]
        public const int SDL_PLATFORM_SUPPORTS_METAL = 0;

        [NativeTypeName("#define SDL_POWER_UIKIT 1")]
        public const int SDL_POWER_UIKIT = 1;

        [NativeTypeName("#define SDL_IPHONE_KEYBOARD 1")]
        public const int SDL_IPHONE_KEYBOARD = 1;

        [NativeTypeName("#define SDL_IPHONE_LAUNCHSCREEN 1")]
        public const int SDL_IPHONE_LAUNCHSCREEN = 1;

        [NativeTypeName("#define SDL_FILESYSTEM_COCOA 1")]
        public const int SDL_FILESYSTEM_COCOA = 1;

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetKeyboardFocus", ExactSpelling = true)]
        public static extern SDL_Window* GetKeyboardFocus();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetKeyboardState", ExactSpelling = true)]
        [return: NativeTypeName("const Uint8 *")]
        public static extern byte* GetKeyboardState(int* numkeys);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ResetKeyboard", ExactSpelling = true)]
        public static extern void ResetKeyboard();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetModState", ExactSpelling = true)]
        public static extern SDL_Keymod GetModState();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetModState", ExactSpelling = true)]
        public static extern void SetModState(SDL_Keymod modstate);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetKeyFromScancode", ExactSpelling = true)]
        [return: NativeTypeName("SDL_Keycode")]
        public static extern int GetKeyFromScancode(SDL_Scancode scancode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetScancodeFromKey", ExactSpelling = true)]
        public static extern SDL_Scancode GetScancodeFromKey([NativeTypeName("SDL_Keycode")] int key);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetScancodeName", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* GetScancodeName(SDL_Scancode scancode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetScancodeFromName", ExactSpelling = true)]
        public static extern SDL_Scancode GetScancodeFromName([NativeTypeName("const char *")] sbyte* name);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetKeyName", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* GetKeyName([NativeTypeName("SDL_Keycode")] int key);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetKeyFromName", ExactSpelling = true)]
        [return: NativeTypeName("SDL_Keycode")]
        public static extern int GetKeyFromName([NativeTypeName("const char *")] sbyte* name);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_StartTextInput", ExactSpelling = true)]
        public static extern void StartTextInput();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IsTextInputActive", ExactSpelling = true)]
        public static extern SDL_bool IsTextInputActive();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_StopTextInput", ExactSpelling = true)]
        public static extern void StopTextInput();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ClearComposition", ExactSpelling = true)]
        public static extern void ClearComposition();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IsTextInputShown", ExactSpelling = true)]
        public static extern SDL_bool IsTextInputShown();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTextInputRect", ExactSpelling = true)]
        public static extern void SetTextInputRect([NativeTypeName("const SDL_Rect *")] SDL_Rect* rect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasScreenKeyboardSupport", ExactSpelling = true)]
        public static extern SDL_bool HasScreenKeyboardSupport();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IsScreenKeyboardShown", ExactSpelling = true)]
        public static extern SDL_bool IsScreenKeyboardShown(SDL_Window* window);

        [NativeTypeName("#define SDL_AUDIO_DRIVER_OSS 1")]
        public const int SDL_AUDIO_DRIVER_OSS = 1;

        [NativeTypeName("#define SDL_INPUT_LINUXEV 1")]
        public const int SDL_INPUT_LINUXEV = 1;

        [NativeTypeName("#define SDL_JOYSTICK_LINUX 1")]
        public const int SDL_JOYSTICK_LINUX = 1;

        [NativeTypeName("#define SDL_HAPTIC_LINUX 1")]
        public const int SDL_HAPTIC_LINUX = 1;

        [NativeTypeName("#define SDL_THREAD_PTHREAD_RECURSIVE_MUTEX_NP 1")]
        public const int SDL_THREAD_PTHREAD_RECURSIVE_MUTEX_NP = 1;

        [NativeTypeName("#define SDL_FILESYSTEM_UNIX 1")]
        public const int SDL_FILESYSTEM_UNIX = 1;

        [NativeTypeName("#define SDL_VIDEO_DRIVER_X11 1")]
        public const int SDL_VIDEO_DRIVER_X11 = 1;

        [NativeTypeName("#define SDL_VIDEO_DRIVER_PANDORA 1")]
        public const int SDL_VIDEO_DRIVER_PANDORA = 1;

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_Metal_CreateView", ExactSpelling = true)]
        [return: NativeTypeName("SDL_MetalView")]
        public static extern void* Metal_CreateView(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_Metal_DestroyView", ExactSpelling = true)]
        public static extern void Metal_DestroyView([NativeTypeName("SDL_MetalView")] void* view);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_Metal_GetLayer", ExactSpelling = true)]
        public static extern void* Metal_GetLayer([NativeTypeName("SDL_MetalView")] void* view);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_Metal_GetDrawableSize", ExactSpelling = true)]
        public static extern void Metal_GetDrawableSize(SDL_Window* window, int* w, int* h);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumVideoDrivers", ExactSpelling = true)]
        public static extern int GetNumVideoDrivers();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetVideoDriver", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* GetVideoDriver(int index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_VideoInit", ExactSpelling = true)]
        public static extern int VideoInit([NativeTypeName("const char *")] sbyte* driver_name);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_VideoQuit", ExactSpelling = true)]
        public static extern void VideoQuit();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCurrentVideoDriver", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* GetCurrentVideoDriver();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumVideoDisplays", ExactSpelling = true)]
        public static extern int GetNumVideoDisplays();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDisplayName", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* GetDisplayName(int displayIndex);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDisplayBounds", ExactSpelling = true)]
        public static extern int GetDisplayBounds(int displayIndex, SDL_Rect* rect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDisplayUsableBounds", ExactSpelling = true)]
        public static extern int GetDisplayUsableBounds(int displayIndex, SDL_Rect* rect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDisplayDPI", ExactSpelling = true)]
        public static extern int GetDisplayDPI(int displayIndex, float* ddpi, float* hdpi, float* vdpi);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDisplayOrientation", ExactSpelling = true)]
        public static extern SDL_DisplayOrientation GetDisplayOrientation(int displayIndex);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumDisplayModes", ExactSpelling = true)]
        public static extern int GetNumDisplayModes(int displayIndex);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDisplayMode", ExactSpelling = true)]
        public static extern int GetDisplayMode(int displayIndex, int modeIndex, SDL_DisplayMode* mode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDesktopDisplayMode", ExactSpelling = true)]
        public static extern int GetDesktopDisplayMode(int displayIndex, SDL_DisplayMode* mode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCurrentDisplayMode", ExactSpelling = true)]
        public static extern int GetCurrentDisplayMode(int displayIndex, SDL_DisplayMode* mode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetClosestDisplayMode", ExactSpelling = true)]
        public static extern SDL_DisplayMode* GetClosestDisplayMode(int displayIndex, [NativeTypeName("const SDL_DisplayMode *")] SDL_DisplayMode* mode, SDL_DisplayMode* closest);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPointDisplayIndex", ExactSpelling = true)]
        public static extern int GetPointDisplayIndex([NativeTypeName("const SDL_Point *")] SDL_Point* point);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRectDisplayIndex", ExactSpelling = true)]
        public static extern int GetRectDisplayIndex([NativeTypeName("const SDL_Rect *")] SDL_Rect* rect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowDisplayIndex", ExactSpelling = true)]
        public static extern int GetWindowDisplayIndex(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowDisplayMode", ExactSpelling = true)]
        public static extern int SetWindowDisplayMode(SDL_Window* window, [NativeTypeName("const SDL_DisplayMode *")] SDL_DisplayMode* mode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowDisplayMode", ExactSpelling = true)]
        public static extern int GetWindowDisplayMode(SDL_Window* window, SDL_DisplayMode* mode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowICCProfile", ExactSpelling = true)]
        public static extern void* GetWindowICCProfile(SDL_Window* window, [NativeTypeName("size_t *")] nuint* size);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowPixelFormat", ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint GetWindowPixelFormat(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateWindow", ExactSpelling = true)]
        public static extern SDL_Window* CreateWindow([NativeTypeName("const char *")] sbyte* title, int x, int y, int w, int h, [NativeTypeName("Uint32")] uint flags);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateWindowFrom", ExactSpelling = true)]
        public static extern SDL_Window* CreateWindowFrom([NativeTypeName("const void *")] void* data);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowID", ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint GetWindowID(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowFromID", ExactSpelling = true)]
        public static extern SDL_Window* GetWindowFromID([NativeTypeName("Uint32")] uint id);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowFlags", ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint GetWindowFlags(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowTitle", ExactSpelling = true)]
        public static extern void SetWindowTitle(SDL_Window* window, [NativeTypeName("const char *")] sbyte* title);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowTitle", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* GetWindowTitle(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowIcon", ExactSpelling = true)]
        public static extern void SetWindowIcon(SDL_Window* window, SDL_Surface* icon);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowData", ExactSpelling = true)]
        public static extern void* SetWindowData(SDL_Window* window, [NativeTypeName("const char *")] sbyte* name, void* userdata);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowData", ExactSpelling = true)]
        public static extern void* GetWindowData(SDL_Window* window, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowPosition", ExactSpelling = true)]
        public static extern void SetWindowPosition(SDL_Window* window, int x, int y);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowPosition", ExactSpelling = true)]
        public static extern void GetWindowPosition(SDL_Window* window, int* x, int* y);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowSize", ExactSpelling = true)]
        public static extern void SetWindowSize(SDL_Window* window, int w, int h);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowSize", ExactSpelling = true)]
        public static extern void GetWindowSize(SDL_Window* window, int* w, int* h);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowBordersSize", ExactSpelling = true)]
        public static extern int GetWindowBordersSize(SDL_Window* window, int* top, int* left, int* bottom, int* right);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowSizeInPixels", ExactSpelling = true)]
        public static extern void GetWindowSizeInPixels(SDL_Window* window, int* w, int* h);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowMinimumSize", ExactSpelling = true)]
        public static extern void SetWindowMinimumSize(SDL_Window* window, int min_w, int min_h);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowMinimumSize", ExactSpelling = true)]
        public static extern void GetWindowMinimumSize(SDL_Window* window, int* w, int* h);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowMaximumSize", ExactSpelling = true)]
        public static extern void SetWindowMaximumSize(SDL_Window* window, int max_w, int max_h);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowMaximumSize", ExactSpelling = true)]
        public static extern void GetWindowMaximumSize(SDL_Window* window, int* w, int* h);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowBordered", ExactSpelling = true)]
        public static extern void SetWindowBordered(SDL_Window* window, SDL_bool bordered);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowResizable", ExactSpelling = true)]
        public static extern void SetWindowResizable(SDL_Window* window, SDL_bool resizable);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowAlwaysOnTop", ExactSpelling = true)]
        public static extern void SetWindowAlwaysOnTop(SDL_Window* window, SDL_bool on_top);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShowWindow", ExactSpelling = true)]
        public static extern void ShowWindow(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HideWindow", ExactSpelling = true)]
        public static extern void HideWindow(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RaiseWindow", ExactSpelling = true)]
        public static extern void RaiseWindow(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_MaximizeWindow", ExactSpelling = true)]
        public static extern void MaximizeWindow(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_MinimizeWindow", ExactSpelling = true)]
        public static extern void MinimizeWindow(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RestoreWindow", ExactSpelling = true)]
        public static extern void RestoreWindow(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowFullscreen", ExactSpelling = true)]
        public static extern int SetWindowFullscreen(SDL_Window* window, [NativeTypeName("Uint32")] uint flags);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowSurface", ExactSpelling = true)]
        public static extern SDL_Surface* GetWindowSurface(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UpdateWindowSurface", ExactSpelling = true)]
        public static extern int UpdateWindowSurface(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UpdateWindowSurfaceRects", ExactSpelling = true)]
        public static extern int UpdateWindowSurfaceRects(SDL_Window* window, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rects, int numrects);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowGrab", ExactSpelling = true)]
        public static extern void SetWindowGrab(SDL_Window* window, SDL_bool grabbed);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowKeyboardGrab", ExactSpelling = true)]
        public static extern void SetWindowKeyboardGrab(SDL_Window* window, SDL_bool grabbed);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowMouseGrab", ExactSpelling = true)]
        public static extern void SetWindowMouseGrab(SDL_Window* window, SDL_bool grabbed);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowGrab", ExactSpelling = true)]
        public static extern SDL_bool GetWindowGrab(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowKeyboardGrab", ExactSpelling = true)]
        public static extern SDL_bool GetWindowKeyboardGrab(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowMouseGrab", ExactSpelling = true)]
        public static extern SDL_bool GetWindowMouseGrab(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGrabbedWindow", ExactSpelling = true)]
        public static extern SDL_Window* GetGrabbedWindow();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowMouseRect", ExactSpelling = true)]
        public static extern int SetWindowMouseRect(SDL_Window* window, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowMouseRect", ExactSpelling = true)]
        [return: NativeTypeName("const SDL_Rect *")]
        public static extern SDL_Rect* GetWindowMouseRect(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowBrightness", ExactSpelling = true)]
        public static extern int SetWindowBrightness(SDL_Window* window, float brightness);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowBrightness", ExactSpelling = true)]
        public static extern float GetWindowBrightness(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowOpacity", ExactSpelling = true)]
        public static extern int SetWindowOpacity(SDL_Window* window, float opacity);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowOpacity", ExactSpelling = true)]
        public static extern int GetWindowOpacity(SDL_Window* window, float* out_opacity);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowModalFor", ExactSpelling = true)]
        public static extern int SetWindowModalFor(SDL_Window* modal_window, SDL_Window* parent_window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowInputFocus", ExactSpelling = true)]
        public static extern int SetWindowInputFocus(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowGammaRamp", ExactSpelling = true)]
        public static extern int SetWindowGammaRamp(SDL_Window* window, [NativeTypeName("const Uint16 *")] ushort* red, [NativeTypeName("const Uint16 *")] ushort* green, [NativeTypeName("const Uint16 *")] ushort* blue);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowGammaRamp", ExactSpelling = true)]
        public static extern int GetWindowGammaRamp(SDL_Window* window, [NativeTypeName("Uint16 *")] ushort* red, [NativeTypeName("Uint16 *")] ushort* green, [NativeTypeName("Uint16 *")] ushort* blue);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowHitTest", ExactSpelling = true)]
        public static extern int SetWindowHitTest(SDL_Window* window, [NativeTypeName("SDL_HitTest")] delegate* unmanaged[Cdecl]<SDL_Window*, SDL_Point*, void*, SDL_HitTestResult> callback, void* callback_data);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FlashWindow", ExactSpelling = true)]
        public static extern int FlashWindow(SDL_Window* window, SDL_FlashOperation operation);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyWindow", ExactSpelling = true)]
        public static extern void DestroyWindow(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IsScreenSaverEnabled", ExactSpelling = true)]
        public static extern SDL_bool IsScreenSaverEnabled();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EnableScreenSaver", ExactSpelling = true)]
        public static extern void EnableScreenSaver();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DisableScreenSaver", ExactSpelling = true)]
        public static extern void DisableScreenSaver();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_LoadLibrary", ExactSpelling = true)]
        public static extern int GL_LoadLibrary([NativeTypeName("const char *")] sbyte* path);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_GetProcAddress", ExactSpelling = true)]
        public static extern void* GL_GetProcAddress([NativeTypeName("const char *")] sbyte* proc);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_UnloadLibrary", ExactSpelling = true)]
        public static extern void GL_UnloadLibrary();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_ExtensionSupported", ExactSpelling = true)]
        public static extern SDL_bool GL_ExtensionSupported([NativeTypeName("const char *")] sbyte* extension);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_ResetAttributes", ExactSpelling = true)]
        public static extern void GL_ResetAttributes();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_SetAttribute", ExactSpelling = true)]
        public static extern int GL_SetAttribute(SDL_GLattr attr, int value);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_GetAttribute", ExactSpelling = true)]
        public static extern int GL_GetAttribute(SDL_GLattr attr, int* value);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_CreateContext", ExactSpelling = true)]
        [return: NativeTypeName("SDL_GLContext")]
        public static extern void* GL_CreateContext(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_MakeCurrent", ExactSpelling = true)]
        public static extern int GL_MakeCurrent(SDL_Window* window, [NativeTypeName("SDL_GLContext")] void* context);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_GetCurrentWindow", ExactSpelling = true)]
        public static extern SDL_Window* GL_GetCurrentWindow();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_GetCurrentContext", ExactSpelling = true)]
        [return: NativeTypeName("SDL_GLContext")]
        public static extern void* GL_GetCurrentContext();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_GetDrawableSize", ExactSpelling = true)]
        public static extern void GL_GetDrawableSize(SDL_Window* window, int* w, int* h);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_SetSwapInterval", ExactSpelling = true)]
        public static extern int GL_SetSwapInterval(int interval);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_GetSwapInterval", ExactSpelling = true)]
        public static extern int GL_GetSwapInterval();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_SwapWindow", ExactSpelling = true)]
        public static extern void GL_SwapWindow(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_DeleteContext", ExactSpelling = true)]
        public static extern void GL_DeleteContext([NativeTypeName("SDL_GLContext")] void* context);

        [NativeTypeName("#define SDL_WINDOWPOS_UNDEFINED_MASK 0x1FFF0000u")]
        public const uint SDL_WINDOWPOS_UNDEFINED_MASK = 0x1FFF0000U;

        [NativeTypeName("#define SDL_WINDOWPOS_UNDEFINED SDL_WINDOWPOS_UNDEFINED_DISPLAY(0)")]
        public const uint SDL_WINDOWPOS_UNDEFINED = (0x1FFF0000U | (0));

        [NativeTypeName("#define SDL_WINDOWPOS_CENTERED_MASK 0x2FFF0000u")]
        public const uint SDL_WINDOWPOS_CENTERED_MASK = 0x2FFF0000U;

        [NativeTypeName("#define SDL_WINDOWPOS_CENTERED SDL_WINDOWPOS_CENTERED_DISPLAY(0)")]
        public const uint SDL_WINDOWPOS_CENTERED = (0x2FFF0000U | (0));

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint __builtin_bswap32([NativeTypeName("unsigned int")] uint param0);

        [NativeTypeName("#define SDL_LIL_ENDIAN 1234")]
        public const int SDL_LIL_ENDIAN = 1234;

        [NativeTypeName("#define SDL_BIG_ENDIAN 4321")]
        public const int SDL_BIG_ENDIAN = 4321;

        [NativeTypeName("#define SDL_FLOATWORDORDER SDL_BYTEORDER")]
        public const int SDL_FLOATWORDORDER = 1234;

        [NativeTypeName("#define HAS_BUILTIN_BSWAP16 (_SDL_HAS_BUILTIN(__builtin_bswap16)) || \\\n        (__GNUC__ > 4 || (__GNUC__ == 4 && __GNUC_MINOR__ >= 8))")]
        public const bool HAS_BUILTIN_BSWAP16 = (1) != 0 || (4 > 4 || (4 == 4 && 2 >= 8));

        [NativeTypeName("#define HAS_BUILTIN_BSWAP32 (_SDL_HAS_BUILTIN(__builtin_bswap32)) || \\\n        (__GNUC__ > 4 || (__GNUC__ == 4 && __GNUC_MINOR__ >= 3))")]
        public const bool HAS_BUILTIN_BSWAP32 = (1) != 0 || (4 > 4 || (4 == 4 && 2 >= 3));

        [NativeTypeName("#define HAS_BUILTIN_BSWAP64 (_SDL_HAS_BUILTIN(__builtin_bswap64)) || \\\n        (__GNUC__ > 4 || (__GNUC__ == 4 && __GNUC_MINOR__ >= 3))")]
        public const bool HAS_BUILTIN_BSWAP64 = (1) != 0 || (4 > 4 || (4 == 4 && 2 >= 3));

        [NativeTypeName("#define HAS_BROKEN_BSWAP (__GNUC__ == 2 && __GNUC_MINOR__ <= 95)")]
        public const bool HAS_BROKEN_BSWAP = (4 == 2 && 2 <= 95);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReportAssertion", ExactSpelling = true)]
        public static extern SDL_AssertState ReportAssertion(SDL_AssertData* param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("const char *")] sbyte* param2, int param3);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAssertionHandler", ExactSpelling = true)]
        public static extern void SetAssertionHandler([NativeTypeName("SDL_AssertionHandler")] delegate* unmanaged[Cdecl]<SDL_AssertData*, void*, SDL_AssertState> handler, void* userdata);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDefaultAssertionHandler", ExactSpelling = true)]
        [return: NativeTypeName("SDL_AssertionHandler")]
        public static extern delegate* unmanaged[Cdecl]<SDL_AssertData*, void*, SDL_AssertState> GetDefaultAssertionHandler();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAssertionHandler", ExactSpelling = true)]
        [return: NativeTypeName("SDL_AssertionHandler")]
        public static extern delegate* unmanaged[Cdecl]<SDL_AssertData*, void*, SDL_AssertState> GetAssertionHandler(void** puserdata);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAssertionReport", ExactSpelling = true)]
        [return: NativeTypeName("const SDL_AssertData *")]
        public static extern SDL_AssertData* GetAssertionReport();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ResetAssertionReport", ExactSpelling = true)]
        public static extern void ResetAssertionReport();

        [NativeTypeName("#define SDL_ASSERT_LEVEL 2")]
        public const int SDL_ASSERT_LEVEL = 2;

        [NativeTypeName("#define SDL_FILE __FILE__")]
        public static ReadOnlySpan<byte> SDL_FILE => new byte[] { 0x2E, 0x2E, 0x2F, 0x53, 0x44, 0x4C, 0x2F, 0x69, 0x6E, 0x63, 0x6C, 0x75, 0x64, 0x65, 0x2F, 0x53, 0x44, 0x4C, 0x5F, 0x61, 0x73, 0x73, 0x65, 0x72, 0x74, 0x2E, 0x68, 0x00 };

        [NativeTypeName("#define SDL_LINE __LINE__")]
        public const int SDL_LINE = 326;

        [NativeTypeName("#define SDL_NULL_WHILE_LOOP_CONDITION (0)")]
        public const int SDL_NULL_WHILE_LOOP_CONDITION = (0);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_Vulkan_LoadLibrary", ExactSpelling = true)]
        public static extern int Vulkan_LoadLibrary([NativeTypeName("const char *")] sbyte* path);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_Vulkan_GetVkGetInstanceProcAddr", ExactSpelling = true)]
        public static extern void* Vulkan_GetVkGetInstanceProcAddr();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_Vulkan_UnloadLibrary", ExactSpelling = true)]
        public static extern void Vulkan_UnloadLibrary();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_Vulkan_GetInstanceExtensions", ExactSpelling = true)]
        public static extern SDL_bool Vulkan_GetInstanceExtensions(SDL_Window* window, [NativeTypeName("unsigned int *")] uint* pCount, [NativeTypeName("const char **")] sbyte** pNames);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_Vulkan_CreateSurface", ExactSpelling = true)]
        public static extern SDL_bool Vulkan_CreateSurface(SDL_Window* window, [NativeTypeName("VkInstance")] VkInstance_T* instance, [NativeTypeName("VkSurfaceKHR *")] VkSurfaceKHR_T** surface);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_Vulkan_GetDrawableSize", ExactSpelling = true)]
        public static extern void Vulkan_GetDrawableSize(SDL_Window* window, int* w, int* h);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPowerInfo", ExactSpelling = true)]
        public static extern SDL_PowerState GetPowerInfo(int* secs, int* pct);

        [NativeTypeName("#define NeedFunctionPrototypes 1")]
        public const int NeedFunctionPrototypes = 1;

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LoadObject", ExactSpelling = true)]
        public static extern void* LoadObject([NativeTypeName("const char *")] sbyte* sofile);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LoadFunction", ExactSpelling = true)]
        public static extern void* LoadFunction(void* handle, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnloadObject", ExactSpelling = true)]
        public static extern void UnloadObject(void* handle);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShowMessageBox", ExactSpelling = true)]
        public static extern int ShowMessageBox([NativeTypeName("const SDL_MessageBoxData *")] SDL_MessageBoxData* messageboxdata, int* buttonid);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShowSimpleMessageBox", ExactSpelling = true)]
        public static extern int ShowSimpleMessageBox([NativeTypeName("Uint32")] uint flags, [NativeTypeName("const char *")] sbyte* title, [NativeTypeName("const char *")] sbyte* message, SDL_Window* window);

        [NativeTypeName("#define HAVE_WINDOWS_GAMING_INPUT_H 1")]
        public const int HAVE_WINDOWS_GAMING_INPUT_H = 1;

        [NativeTypeName("#define HAVE_D3D11_H 1")]
        public const int HAVE_D3D11_H = 1;

        [NativeTypeName("#define HAVE_ROAPI_H 1")]
        public const int HAVE_ROAPI_H = 1;

        [NativeTypeName("#define HAVE_SHELLSCALINGAPI_H 1")]
        public const int HAVE_SHELLSCALINGAPI_H = 1;

        [NativeTypeName("#define SDL_JOYSTICK_WGI 1")]
        public const int SDL_JOYSTICK_WGI = 1;

        [NativeTypeName("#define SDL_VIDEO_RENDER_D3D11 1")]
        public const int SDL_VIDEO_RENDER_D3D11 = 1;

        [NativeTypeName("#define NULL 0")]
        public const int NULL = 0;

        [NativeTypeName("#define _HAS_FALLTHROUGH )")]
        public const int _HAS_FALLTHROUGH = 1;

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LogSetAllPriority", ExactSpelling = true)]
        public static extern void LogSetAllPriority(SDL_LogPriority priority);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LogSetPriority", ExactSpelling = true)]
        public static extern void LogSetPriority(int category, SDL_LogPriority priority);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LogGetPriority", ExactSpelling = true)]
        public static extern SDL_LogPriority LogGetPriority(int category);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LogResetPriorities", ExactSpelling = true)]
        public static extern void LogResetPriorities();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_Log", ExactSpelling = true)]
        public static extern void Log([NativeTypeName("const char *")] sbyte* fmt, __arglist);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LogVerbose", ExactSpelling = true)]
        public static extern void LogVerbose(int category, [NativeTypeName("const char *")] sbyte* fmt, __arglist);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LogDebug", ExactSpelling = true)]
        public static extern void LogDebug(int category, [NativeTypeName("const char *")] sbyte* fmt, __arglist);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LogInfo", ExactSpelling = true)]
        public static extern void LogInfo(int category, [NativeTypeName("const char *")] sbyte* fmt, __arglist);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LogWarn", ExactSpelling = true)]
        public static extern void LogWarn(int category, [NativeTypeName("const char *")] sbyte* fmt, __arglist);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LogError", ExactSpelling = true)]
        public static extern void LogError(int category, [NativeTypeName("const char *")] sbyte* fmt, __arglist);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LogCritical", ExactSpelling = true)]
        public static extern void LogCritical(int category, [NativeTypeName("const char *")] sbyte* fmt, __arglist);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LogMessage", ExactSpelling = true)]
        public static extern void LogMessage(int category, SDL_LogPriority priority, [NativeTypeName("const char *")] sbyte* fmt, __arglist);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LogGetOutputFunction", ExactSpelling = true)]
        public static extern void LogGetOutputFunction([NativeTypeName("SDL_LogOutputFunction *")] delegate* unmanaged[Cdecl]<void*, int, SDL_LogPriority, sbyte*, void>* callback, void** userdata);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LogSetOutputFunction", ExactSpelling = true)]
        public static extern void LogSetOutputFunction([NativeTypeName("SDL_LogOutputFunction")] delegate* unmanaged[Cdecl]<void*, int, SDL_LogPriority, sbyte*, void> callback, void* userdata);

        [NativeTypeName("#define SDL_MAX_LOG_MESSAGE 4096")]
        public const int SDL_MAX_LOG_MESSAGE = 4096;

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_init", ExactSpelling = true)]
        public static extern int hid_init();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_exit", ExactSpelling = true)]
        public static extern int hid_exit();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_device_change_count", ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint hid_device_change_count();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_enumerate", ExactSpelling = true)]
        public static extern SDL_hid_device_info* hid_enumerate([NativeTypeName("unsigned short")] ushort vendor_id, [NativeTypeName("unsigned short")] ushort product_id);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_free_enumeration", ExactSpelling = true)]
        public static extern void hid_free_enumeration(SDL_hid_device_info* devs);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_open", ExactSpelling = true)]
        [return: NativeTypeName("SDL_hid_device *")]
        public static extern SDL_hid_device_* hid_open([NativeTypeName("unsigned short")] ushort vendor_id, [NativeTypeName("unsigned short")] ushort product_id, [NativeTypeName("const wchar_t *")] uint* serial_number);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_open_path", ExactSpelling = true)]
        [return: NativeTypeName("SDL_hid_device *")]
        public static extern SDL_hid_device_* hid_open_path([NativeTypeName("const char *")] sbyte* path, int bExclusive);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_write", ExactSpelling = true)]
        public static extern int hid_write([NativeTypeName("SDL_hid_device *")] SDL_hid_device_* dev, [NativeTypeName("const unsigned char *")] byte* data, [NativeTypeName("size_t")] nuint length);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_read_timeout", ExactSpelling = true)]
        public static extern int hid_read_timeout([NativeTypeName("SDL_hid_device *")] SDL_hid_device_* dev, [NativeTypeName("unsigned char *")] byte* data, [NativeTypeName("size_t")] nuint length, int milliseconds);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_read", ExactSpelling = true)]
        public static extern int hid_read([NativeTypeName("SDL_hid_device *")] SDL_hid_device_* dev, [NativeTypeName("unsigned char *")] byte* data, [NativeTypeName("size_t")] nuint length);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_set_nonblocking", ExactSpelling = true)]
        public static extern int hid_set_nonblocking([NativeTypeName("SDL_hid_device *")] SDL_hid_device_* dev, int nonblock);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_send_feature_report", ExactSpelling = true)]
        public static extern int hid_send_feature_report([NativeTypeName("SDL_hid_device *")] SDL_hid_device_* dev, [NativeTypeName("const unsigned char *")] byte* data, [NativeTypeName("size_t")] nuint length);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_get_feature_report", ExactSpelling = true)]
        public static extern int hid_get_feature_report([NativeTypeName("SDL_hid_device *")] SDL_hid_device_* dev, [NativeTypeName("unsigned char *")] byte* data, [NativeTypeName("size_t")] nuint length);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_close", ExactSpelling = true)]
        public static extern void hid_close([NativeTypeName("SDL_hid_device *")] SDL_hid_device_* dev);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_get_manufacturer_string", ExactSpelling = true)]
        public static extern int hid_get_manufacturer_string([NativeTypeName("SDL_hid_device *")] SDL_hid_device_* dev, [NativeTypeName("wchar_t *")] uint* @string, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_get_product_string", ExactSpelling = true)]
        public static extern int hid_get_product_string([NativeTypeName("SDL_hid_device *")] SDL_hid_device_* dev, [NativeTypeName("wchar_t *")] uint* @string, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_get_serial_number_string", ExactSpelling = true)]
        public static extern int hid_get_serial_number_string([NativeTypeName("SDL_hid_device *")] SDL_hid_device_* dev, [NativeTypeName("wchar_t *")] uint* @string, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_get_indexed_string", ExactSpelling = true)]
        public static extern int hid_get_indexed_string([NativeTypeName("SDL_hid_device *")] SDL_hid_device_* dev, int string_index, [NativeTypeName("wchar_t *")] uint* @string, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_ble_scan", ExactSpelling = true)]
        public static extern void hid_ble_scan(SDL_bool active);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowWMInfo", ExactSpelling = true)]
        public static extern SDL_bool GetWindowWMInfo(SDL_Window* window, SDL_SysWMinfo* info);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateThread", ExactSpelling = true)]
        public static extern SDL_Thread* CreateThread([NativeTypeName("SDL_ThreadFunction")] delegate* unmanaged[Cdecl]<void*, int> fn, [NativeTypeName("const char *")] sbyte* name, void* data);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateThreadWithStackSize", ExactSpelling = true)]
        public static extern SDL_Thread* CreateThreadWithStackSize([NativeTypeName("SDL_ThreadFunction")] delegate* unmanaged[Cdecl]<void*, int> fn, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const size_t")] nuint stacksize, void* data);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetThreadName", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* GetThreadName(SDL_Thread* thread);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ThreadID", ExactSpelling = true)]
        [return: NativeTypeName("SDL_threadID")]
        public static extern nuint ThreadID();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetThreadID", ExactSpelling = true)]
        [return: NativeTypeName("SDL_threadID")]
        public static extern nuint GetThreadID(SDL_Thread* thread);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetThreadPriority", ExactSpelling = true)]
        public static extern int SetThreadPriority(SDL_ThreadPriority priority);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WaitThread", ExactSpelling = true)]
        public static extern void WaitThread(SDL_Thread* thread, int* status);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DetachThread", ExactSpelling = true)]
        public static extern void DetachThread(SDL_Thread* thread);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_TLSCreate", ExactSpelling = true)]
        [return: NativeTypeName("SDL_TLSID")]
        public static extern uint TLSCreate();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_TLSGet", ExactSpelling = true)]
        public static extern void* TLSGet([NativeTypeName("SDL_TLSID")] uint id);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_TLSSet", ExactSpelling = true)]
        public static extern int TLSSet([NativeTypeName("SDL_TLSID")] uint id, [NativeTypeName("const void *")] void* value, [NativeTypeName("void (*)(void *)")] delegate* unmanaged[Cdecl]<void*, void> destructor);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_TLSCleanup", ExactSpelling = true)]
        public static extern void TLSCleanup();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetBasePath", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* GetBasePath();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPrefPath", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* GetPrefPath([NativeTypeName("const char *")] sbyte* org, [NativeTypeName("const char *")] sbyte* app);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_main", ExactSpelling = true)]
        public static extern int main(int argc, [NativeTypeName("char *[]")] sbyte** argv);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetMainReady", ExactSpelling = true)]
        public static extern void SetMainReady();
    }
}
