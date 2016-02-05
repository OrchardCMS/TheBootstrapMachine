using Orchard.ContentManagement;
using Orchard.ContentManagement.Handlers;
using Orchard.Localization;
using TheBootstrapMachine.Models;

namespace TheBootstrapMachine.Handlers {
    public class BootstrapSettingsPartHandler : ContentHandler {
        public BootstrapSettingsPartHandler() {
            T = NullLocalizer.Instance;
            Filters.Add(new ActivatingFilter<BootstrapSettingsPart>("Site"));
            Filters.Add(new TemplateFilterForPart<BootstrapSettingsPart>("BootstrapSettings", "Parts/BootstrapSettings", "Theme Options"));
        }

        public Localizer T { get; set; }

        protected override void GetItemMetadata(GetContentItemMetadataContext context) {
            if (context.ContentItem.ContentType != "Site")
                return;
            base.GetItemMetadata(context);
            context.Metadata.EditorGroupInfo.Add(new GroupInfo(T("Theme Options")));
        }
    }
}