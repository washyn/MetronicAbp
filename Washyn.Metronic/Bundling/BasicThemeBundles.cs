using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Bundling;

public static class BasicThemeBundles
{
    public static class Styles
    {
        public const string Global = "Basic.Global";
    }

    public static class Scripts
    {
        public const string Global = "Basic.Global";
    }
}

public class FirstStylesBundle : BundleContributor
{
    //ok
    public override void ConfigureBundle(BundleConfigurationContext context)
    {
        context.Files.Add("/assets/plugins/custom/datatables/datatables.bundle.css");
    }
}

public class SecondStylesBundle : BundleContributor
{
    public override void ConfigureBundle(BundleConfigurationContext context)
    {
        // fix
        
        context.Files.Add("/libs/abp/core/abp.css");
        // context.Files.Add("/libs/bootstrap/css/bootstrap.css");
        context.Files.Add("/assets/plugins/global/plugins.bundle.css");
        context.Files.Add("/assets/css/style.bundle.css");
        
        context.Files.Add("/libs/@fortawesome/fontawesome-free/css/all.css");
        context.Files.Add("/libs/@fortawesome/fontawesome-free/css/v4-shims.css");
        // context.Files.Add("/libs/toastr/toastr.min.css");
        // context.Files.Add("/libs/select2/css/select2.min.css");
        context.Files.Add("/libs/malihu-custom-scrollbar-plugin/jquery.mCustomScrollbar.css");
        // context.Files.Add("/libs/datatables.net-bs5/css/dataTables.bootstrap5.css");
        // context.Files.Add("/libs/bootstrap-datepicker/bootstrap-datepicker.min.css");
        // context.Files.Add("/libs/bootstrap-daterangepicker/daterangepicker.css");
    }
}

public class ThrirdStylesBundle : BundleContributor
{
    public override void ConfigureBundle(BundleConfigurationContext context)
    {
        // ok
        context.Files.Add("/libs/abp/aspnetcore-mvc-ui-theme-shared/datatables/datatables-styles.css");
    }
}




public class FirstScriptsBundle : BundleContributor
{
    public override void ConfigureBundle(BundleConfigurationContext context)
    {
        // fix
        
        context.Files.Add("/libs/abp/utils/abp-utils.umd.min.js");
        context.Files.Add("/libs/abp/core/abp.js");
        // context.Files.Add("/libs/jquery/jquery.js");
        context.Files.Add("/assets/plugins/global/plugins.bundle.js");
        context.Files.Add("/assets/js/scripts.bundle.js");
        
        context.Files.Add("/libs/abp/jquery/abp.jquery.js");
        // context.Files.Add("/libs/bootstrap/js/bootstrap.bundle.js");
        context.Files.Add("/libs/bootstrap/js/bootstrap.enable.tooltips.everywhere.js");
        context.Files.Add("/libs/bootstrap/js/bootstrap.enable.popovers.everywhere.js");
        context.Files.Add("/libs/lodash/lodash.min.js");
        context.Files.Add("/libs/jquery-validation/jquery.validate.js");
        context.Files.Add("/libs/jquery-validation-unobtrusive/jquery.validate.unobtrusive.js");
        context.Files.Add("/libs/jquery-form/jquery.form.min.js");
        // context.Files.Add("/libs/select2/js/select2.min.js");
        // context.Files.Add("/libs/datatables.net/js/jquery.dataTables.js");
        // context.Files.Add("/libs/datatables.net-bs5/js/dataTables.bootstrap5.js");
        // context.Files.Add("/libs/sweetalert2/sweetalert2.all.min.js");
        // context.Files.Add("/libs/toastr/toastr.min.js");
        context.Files.Add("/libs/malihu-custom-scrollbar-plugin/jquery.mCustomScrollbar.concat.min.js");
        context.Files.Add("/libs/luxon/luxon.min.js");
        context.Files.Add("/libs/abp/luxon/abp.luxon.js");
        context.Files.Add("/libs/timeago/jquery.timeago.js");
        context.Files.Add("/libs/bootstrap-datepicker/bootstrap-datepicker.min.js");
        // context.Files.Add("/libs/moment/moment.min.js");
        context.Files.Add("/libs/bootstrap-daterangepicker/daterangepicker.js");
    }
}

public class SecondScriptsBundle : BundleContributor
{
    public override void ConfigureBundle(BundleConfigurationContext context)
    {
        context.Files.Add("/assets/plugins/custom/datatables/datatables.bundle.js");
    }
}

public class ThrirdScriptsBundle : BundleContributor
{
    public override void ConfigureBundle(BundleConfigurationContext context)
    {
        // ok
        context.Files.Add("/libs/abp/aspnetcore-mvc-ui-theme-shared/ui-extensions.js");
        context.Files.Add("/libs/abp/aspnetcore-mvc-ui-theme-shared/jquery/jquery-extensions.js");
        context.Files.Add("/libs/abp/aspnetcore-mvc-ui-theme-shared/jquery-form/jquery-form-extensions.js");
        context.Files.Add("/libs/abp/aspnetcore-mvc-ui-theme-shared/jquery/widget-manager.js");
        context.Files.Add("/libs/abp/aspnetcore-mvc-ui-theme-shared/bootstrap/dom-event-handlers.js");
        context.Files.Add("/libs/abp/aspnetcore-mvc-ui-theme-shared/bootstrap/modal-manager.js");
        context.Files.Add("/libs/abp/aspnetcore-mvc-ui-theme-shared/datatables/datatables-extensions-new.js");
        context.Files.Add("/libs/abp/aspnetcore-mvc-ui-theme-shared/sweetalert2/abp-sweetalert2.js");
        context.Files.Add("/libs/abp/aspnetcore-mvc-ui-theme-shared/toastr/abp-toastr.js");
    }
}