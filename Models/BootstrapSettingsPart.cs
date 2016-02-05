using Orchard.ContentManagement;

namespace TheBootstrapMachine.Models {
    public class BootstrapSettingsPart : ContentPart {

        // Disable zooming capabilities on mobile devices
        public bool DisableUserScalable {
            get { return this.Retrieve(x => x.DisableUserScalable, false); }
            set { this.Store(x => x.DisableUserScalable, value); }
        }

        public string CustomHeaderContent {
            get { return this.Retrieve(x => x.CustomHeaderContent); }
            set { this.Store(x => x.CustomHeaderContent, value); }
        }

        public string CustomFooterContent {
            get { return this.Retrieve(x => x.CustomFooterContent); }
            set { this.Store(x => x.CustomFooterContent, value); }
        }

        public bool ShowFullSummaries {
            get { return this.Retrieve(x => x.ShowFullSummaries, false); }
            set { this.Store(x => x.ShowFullSummaries, value); }
        }

        public bool ScriptsInHeader {
            get { return this.Retrieve(x => x.ScriptsInHeader, false); }
            set { this.Store(x => x.ScriptsInHeader, value); }
        }
    }
}