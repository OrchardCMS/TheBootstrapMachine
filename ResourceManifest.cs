using Orchard.UI.Resources;

namespace Orchard.Gallery {
    public class ResourceManifest : IResourceManifestProvider {
        public void BuildManifests(ResourceManifestBuilder builder) {
            var manifest = builder.Add();
            manifest.DefineStyle("TheBootstrapMachine").SetUrl("styles.min.css", "styles.css");
        }
    }
}
