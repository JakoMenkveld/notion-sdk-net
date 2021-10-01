﻿using Newtonsoft.Json;

namespace Notion.Client
{
    public class FileBlock : Block
    {
        public override BlockType Type => BlockType.File;

        [JsonProperty("file")]
        public FileObject File { get; set; }
    }
}
