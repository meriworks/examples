using EPiServer.Core;
using EPiServer.DataAnnotations;

namespace Meriworks.Examples.ImageVault.Epi.MediaList {
    [ContentType(DisplayName = "MediaList Page", Description = "A page to demonstrate listing of ImageVault media in a content area", GUID = "9D46F9ED-2B1D-4636-82F7-BC7A295B7430")]
    public class MediaListPage : PageData {
        [AllowedTypes(new[] { typeof(MediaBlock) })]
        public virtual ContentArea MediaList { get; set; }
    }
}
