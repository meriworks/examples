using EPiServer.Core;
using EPiServer.DataAnnotations;
using ImageVault.EPiServer;

namespace Meriworks.Examples.ImageVault.Epi.MediaList {
    [ContentType(DisplayName = "MediaBlock", Description = "A block type with a single media property", GUID = "0C2F7101-DA9F-4646-B52E-4DBCB2E8406E")]
    public class MediaBlock : BlockData {
        public virtual MediaReference Media { get; set; }
    }
}
