using Microsoft.Extensions.Options;
using OrchardCore.ResourceManagement;

namespace OrchardCore.Themes.TheComingSoonTheme
{
    public class ResourceManagementOptionsConfiguration : IConfigureOptions<ResourceManagementOptions>
    {
        private static ResourceManifest _manifest;

        static ResourceManagementOptionsConfiguration()
        {
            _manifest = new ResourceManifest();

            _manifest
                .DefineScript("TheComingSoonTheme-jQuery")
                .SetCdn("https://code.jquery.com/jquery-3.5.1.min.js", "https://code.jquery.com/jquery-3.5.1.js")
                .SetCdnIntegrity("sha384-ZvpUoO/+PpLXR1lu4jmpXWu80pZlYUAfxl5NsBMWOEPSjUn/6Z/hRTt8+pR6L4N2", "sha384-/LjQZzcpTzaYn7qWqRIWYC5l8FWEZ2bIHIz0D73Uzba4pShEcdLdZyZkI4Kv676E")
                .SetVersion("3.5.1");

            _manifest
                .DefineScript("TheComingSoonTheme-bootstrap-bundle")
                .SetDependencies("TheComingSoonTheme-jQuery")
                .SetCdn("https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/js/bootstrap.bundle.min.js", "https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/js/bootstrap.bundle.js")
                .SetCdnIntegrity("sha384-Piv4xVNRyMGpqkS2by6br4gNJ7DXjqk09RmUpJ8jgGtD7zP9yug3goQfGII0yAns", "sha384-ZEiV3j24mJ99uunGq2LXkicfbHO18KBrDHpdTjD1NUT07kWB6B8u6U5t6UBimJ7w")
                .SetVersion("4.6.0");

            _manifest
                .DefineScript("coming-soon")
                .SetDependencies("TheComingSoonTheme-jQuery")
                .SetUrl("~/TheComingSoonTheme/js/scripts.min.js", "TheComingSoonTheme/js/scripts.js")
                .SetVersion("5.1.0");

            _manifest
                .DefineStyle("coming-soon")
                .SetUrl("~/TheComingSoonTheme/css/styles.min.css", "TheComingSoonTheme/css/styles.css")
                .SetVersion("5.1.0");

            _manifest
                .DefineStyle("TheComingSoonTheme-bootstrap-oc")
                .SetUrl("~/TheComingSoonTheme/css/bootstrap-oc.min.css", "~/TheComingSoonTheme/css/bootstrap-oc.css")
                .SetVersion("1.0.0");
        }

        public void Configure(ResourceManagementOptions options)
        {
            options.ResourceManifests.Add(_manifest);
        }
    }
}
