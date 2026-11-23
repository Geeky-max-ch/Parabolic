using Nickvision.Parabolic.Shared.Models;

namespace Nickvision.Parabolic.Shared.Helpers;

public static class MediaFileTypeExtensions
{
    extension(MediaFileType type)
    {
        public string DotExtension => type switch
        {
            MediaFileType.Audio => string.Empty,
            MediaFileType.Video => string.Empty,
            _ => $".{type.ToString().ToLowerInvariant()}"
        };