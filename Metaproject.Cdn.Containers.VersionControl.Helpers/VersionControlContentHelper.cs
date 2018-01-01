using DevOps.ContentDelivery.Structures.AzureBlob;
using static Metaproject.Cdn.Common.Helpers.CDorstCdnHelper;
using static Metaproject.Cdn.Containers.VersionControl.Helpers.ContentConstants;

namespace Metaproject.Cdn.Containers.VersionControl.Helpers
{
    public static class VersionControlContentHelper
    {
        private const string Container = "versioncontrol";

        public static void SaveGitAttributeIgnoreFiles(string destinationPath)
            => ExtractZip(new Blob(Container, GitAttributesIgnore), destinationPath);

        public static void SaveGnuGpl3License(string destinationPath)
            => ExtractZip(new Blob(Container, GnuGpl3License), destinationPath);
    }
}
