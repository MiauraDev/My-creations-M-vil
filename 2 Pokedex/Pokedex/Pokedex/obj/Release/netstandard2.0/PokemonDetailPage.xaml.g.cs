//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("Pokedex.PokemonDetailPage.xaml", "PokemonDetailPage.xaml", typeof(global::PokemonApp.Views.PokemonDetailPage))]

namespace PokemonApp.Views {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("PokemonDetailPage.xaml")]
    public partial class PokemonDetailPage : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Image pokemonImage;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.BoxView HPBarView;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.BoxView AttackBarView;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.BoxView DefenseBarView;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(PokemonDetailPage));
            pokemonImage = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Image>(this, "pokemonImage");
            HPBarView = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.BoxView>(this, "HPBarView");
            AttackBarView = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.BoxView>(this, "AttackBarView");
            DefenseBarView = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.BoxView>(this, "DefenseBarView");
        }
    }
}
