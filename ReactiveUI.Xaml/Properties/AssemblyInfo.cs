using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Windows;

[assembly: AssemblyDescription("An MVVM framework that integrates the Reactive Extensions")]
[assembly: AssemblyProduct("ReactiveUI.Xaml")]
[assembly: AssemblyVersion("4.6.7")]

#if !(WINRT || SILVERLIGHT || MONO)
[assembly: ThemeInfo(
   ResourceDictionaryLocation.None, //where theme specific resource dictionaries are located
    //(used if a resource is not found in the page, 
    // or application resource dictionaries)
   ResourceDictionaryLocation.SourceAssembly //where the generic resource dictionary is located
    //(used if a resource is not found in the page, 
    // app, or any theme specific resource dictionaries)
)]
#endif

[assembly: InternalsVisibleTo(@"ReactiveUI.Tests,PublicKey=
0024000004800000940000000602000000240000525341310004000001000100d3f3667211ec28
9fcfa329f70809f2bbb14350d4a383b15da880713fff33a5387ccfd748dedabd7e926bff72b5fe
bd4d6e7ef58dc33851536cb0687f362f0cafb0ac9e83511ffcfed8117673c55252a7601a55949c
59a6f2a616fb4af73a4ec590b8c09b94f0a26c2feb633c87e3e9f829d72aa9f421bdcb77dfd77a
121415b0")]
[assembly: InternalsVisibleTo(@"ReactiveUI.Tests_SL4,PublicKey=
0024000004800000940000000602000000240000525341310004000001000100d3f3667211ec28
9fcfa329f70809f2bbb14350d4a383b15da880713fff33a5387ccfd748dedabd7e926bff72b5fe
bd4d6e7ef58dc33851536cb0687f362f0cafb0ac9e83511ffcfed8117673c55252a7601a55949c
59a6f2a616fb4af73a4ec590b8c09b94f0a26c2feb633c87e3e9f829d72aa9f421bdcb77dfd77a
121415b0")]
[assembly: InternalsVisibleTo(@"ReactiveUI.Tests_SL5,PublicKey=
0024000004800000940000000602000000240000525341310004000001000100d3f3667211ec28
9fcfa329f70809f2bbb14350d4a383b15da880713fff33a5387ccfd748dedabd7e926bff72b5fe
bd4d6e7ef58dc33851536cb0687f362f0cafb0ac9e83511ffcfed8117673c55252a7601a55949c
59a6f2a616fb4af73a4ec590b8c09b94f0a26c2feb633c87e3e9f829d72aa9f421bdcb77dfd77a
121415b0")]
[assembly: InternalsVisibleTo(@"ReactiveUI.Tests_WinRT,PublicKey=
0024000004800000940000000602000000240000525341310004000001000100d3f3667211ec28
9fcfa329f70809f2bbb14350d4a383b15da880713fff33a5387ccfd748dedabd7e926bff72b5fe
bd4d6e7ef58dc33851536cb0687f362f0cafb0ac9e83511ffcfed8117673c55252a7601a55949c
59a6f2a616fb4af73a4ec590b8c09b94f0a26c2feb633c87e3e9f829d72aa9f421bdcb77dfd77a
121415b0")]