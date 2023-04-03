using Volo.Abp.Autofac;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.Ui.Branding;

namespace Acme.Samples;

[DependsOn(typeof(TemplateModules))]
[DependsOn(typeof(AbpAutofacModule))]
public class SamplesModule : AbpModule
{

}

[Dependency(ReplaceServices = true)]
public class SamplesBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Test";
    public override string LogoUrl => "/assets/media/logos/default.svg";
    public override string LogoReverseUrl => "/assets/media/logos/default-dark.svg";
}
