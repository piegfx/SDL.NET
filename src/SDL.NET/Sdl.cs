using System;
using System.Runtime.InteropServices;
using static SDL.NET.SDL_bool;

namespace SDL.NET
{
    public static unsafe partial class Sdl
    {
        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenURL", ExactSpelling = true)]
        public static extern int OpenURL([NativeTypeName("const char *")] sbyte* url);

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

        public static void* memcpy4(void* dst, [NativeTypeName("const void *")] void* src, [NativeTypeName("size_t")] nuint dwords)
        {
            return memcpy(dst, src, dwords * 4);
        }

        public static int size_mul_overflow([NativeTypeName("size_t")] nuint a, [NativeTypeName("size_t")] nuint b, [NativeTypeName("size_t *")] nuint* ret)
        {
            if (a != 0 && b > (18446744073709551615U) / a)
            {
                return -1;
            }

            *ret = a * b;
            return 0;
        }

        public static int size_add_overflow([NativeTypeName("size_t")] nuint a, [NativeTypeName("size_t")] nuint b, [NativeTypeName("size_t *")] nuint* ret)
        {
            if (b > (18446744073709551615U) - a)
            {
                return -1;
            }

            *ret = a + b;
            return 0;
        }

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte __builtin_mul_overflow(__arglist);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte __builtin_add_overflow(__arglist);

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

        public static int MostSignificantBitIndex32([NativeTypeName("Uint32")] uint x)
        {
            if (x == 0)
            {
                return -1;
            }

            return 31 - __builtin_clz(x);
        }

        public static SDL_bool HasExactlyOneBitSet32([NativeTypeName("Uint32")] uint x)
        {
            if ((x) != 0 && (x & (x - 1)) == 0)
            {
                return SDL_TRUE;
            }

            return SDL_FALSE;
        }

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int __builtin_clz([NativeTypeName("unsigned int")] uint param0);

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

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPreferredLocales", ExactSpelling = true)]
        public static extern SDL_Locale* GetPreferredLocales();

        public static SDL_bool PointInRect([NativeTypeName("const SDL_Point *")] SDL_Point* p, [NativeTypeName("const SDL_Rect *")] SDL_Rect* r)
        {
            return ((p->x >= r->x) && (p->x < (r->x + r->w)) && (p->y >= r->y) && (p->y < (r->y + r->h))) ? SDL_TRUE : SDL_FALSE;
        }

        public static SDL_bool RectEmpty([NativeTypeName("const SDL_Rect *")] SDL_Rect* r)
        {
            return ((r == null) || (r->w <= 0) || (r->h <= 0)) ? SDL_TRUE : SDL_FALSE;
        }

        public static SDL_bool RectEquals([NativeTypeName("const SDL_Rect *")] SDL_Rect* a, [NativeTypeName("const SDL_Rect *")] SDL_Rect* b)
        {
            return ((a) != null && (b) != null && (a->x == b->x) && (a->y == b->y) && (a->w == b->w) && (a->h == b->h)) ? SDL_TRUE : SDL_FALSE;
        }

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

        public static SDL_bool PointInFRect([NativeTypeName("const SDL_FPoint *")] SDL_FPoint* p, [NativeTypeName("const SDL_FRect *")] SDL_FRect* r)
        {
            return ((p->x >= r->x) && (p->x < (r->x + r->w)) && (p->y >= r->y) && (p->y < (r->y + r->h))) ? SDL_TRUE : SDL_FALSE;
        }

        public static SDL_bool FRectEmpty([NativeTypeName("const SDL_FRect *")] SDL_FRect* r)
        {
            return ((r == null) || (r->w <= 0.0f) || (r->h <= 0.0f)) ? SDL_TRUE : SDL_FALSE;
        }

        public static SDL_bool FRectEqualsEpsilon([NativeTypeName("const SDL_FRect *")] SDL_FRect* a, [NativeTypeName("const SDL_FRect *")] SDL_FRect* b, [NativeTypeName("const float")] float epsilon)
        {
            return ((a) != null && (b) != null && ((a == b) || ((fabsf(a->x - b->x) <= epsilon) && (fabsf(a->y - b->y) <= epsilon) && (fabsf(a->w - b->w) <= epsilon) && (fabsf(a->h - b->h) <= epsilon)))) ? SDL_TRUE : SDL_FALSE;
        }

        public static SDL_bool FRectEquals([NativeTypeName("const SDL_FRect *")] SDL_FRect* a, [NativeTypeName("const SDL_FRect *")] SDL_FRect* b)
        {
            return FRectEqualsEpsilon(a, b, 1.1920928955078125e-07F);
        }

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

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPlatform", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* GetPlatform();

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

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetVersion", ExactSpelling = true)]
        public static extern void GetVersion(SDL_version* ver);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRevision", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* GetRevision();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRevisionNumber", ExactSpelling = true)]
        [Obsolete]
        public static extern int GetRevisionNumber();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateShapedWindow", ExactSpelling = true)]
        public static extern SDL_Window* CreateShapedWindow([NativeTypeName("const char *")] sbyte* title, [NativeTypeName("unsigned int")] uint x, [NativeTypeName("unsigned int")] uint y, [NativeTypeName("unsigned int")] uint w, [NativeTypeName("unsigned int")] uint h, [NativeTypeName("Uint32")] uint flags);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IsShapedWindow", ExactSpelling = true)]
        public static extern SDL_bool IsShapedWindow([NativeTypeName("const SDL_Window *")] SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowShape", ExactSpelling = true)]
        public static extern int SetWindowShape(SDL_Window* window, SDL_Surface* shape, SDL_WindowShapeMode* shape_mode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetShapedWindowMode", ExactSpelling = true)]
        public static extern int GetShapedWindowMode(SDL_Window* window, SDL_WindowShapeMode* shape_mode);

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

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint __builtin_bswap32([NativeTypeName("unsigned int")] uint param0);

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
